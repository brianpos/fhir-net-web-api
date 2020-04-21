/* 
 * Copyright (c) 2017+ brianpos, Firely and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://github.com/ewoutkramer/fhir-net-api/blob/master/LICENSE
 */

using Hl7.Fhir.Model;
using System;
using System.IO;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Formatters;
using System.Threading.Tasks;
using Microsoft.Net.Http.Headers;
using Microsoft.Extensions.Primitives;
using System.Text;

namespace Hl7.Fhir.WebApi
{
    public class BinaryFhirInputFormatter : FhirMediaTypeInputFormatter
    {
        public BinaryFhirInputFormatter() : base()
        {
            SupportedMediaTypes.Add(new MediaTypeHeaderValue(FhirMediaType.BinaryResource));
        }

        public override async Task<InputFormatterResult> ReadRequestBodyAsync(InputFormatterContext context, Encoding encoding)
        {
            if (context == null)
                throw new ArgumentNullException(nameof(context));

            MemoryStream stream = new MemoryStream();
            await context.HttpContext.Request.Body.CopyToAsync(stream);

            StringValues xContentHeader;
            var success = context.HttpContext.Request.Headers.TryGetValue("X-Content-Type", out xContentHeader);

            if (!success)
                throw new FhirServerException(System.Net.HttpStatusCode.BadRequest, "POST to binary must provide a Content-Type header");

            string contentType = xContentHeader.FirstOrDefault();

            Binary binary = new Binary();
            binary.Data = stream.ToArray();
            binary.ContentType = contentType;

            return InputFormatterResult.Success(binary);
        }
    }
    public class BinaryFhirOutputFormatter : FhirMediaTypeOutputFormatter
    {
        public BinaryFhirOutputFormatter() : base()
        {
            SupportedMediaTypes.Add(new MediaTypeHeaderValue(FhirMediaType.BinaryResource));
        }

        public override void WriteResponseHeaders(OutputFormatterWriteContext context)
        {
            base.WriteResponseHeaders(context);

            if (context.Object is Hl7.Fhir.Model.Binary binary)
            {
                var contentDisposition = new ContentDispositionHeaderValue("attachment")
                {
                    FileName = String.Format("fhir_binary_{0}_{1}{2}",
                    binary.Id,
                    binary.Meta?.VersionId ?? "0",
                    GetFileExtensionForMimeType(binary.ContentType)),
                    Size = binary.Data.Length
                };

                contentDisposition.SetHttpFileName(contentDisposition.FileName);
                context.HttpContext.Response.Headers[HeaderNames.ContentDisposition] = contentDisposition.ToString();
                if (!string.IsNullOrEmpty(binary.SecurityContext?.Reference))
                    context.HttpContext.Response.Headers["X-Security-Context"] = binary.SecurityContext?.Reference;
            }
        }

        private string GetFileExtensionForMimeType(string mimetype)
        {
            Microsoft.Win32.RegistryKey regKey = Microsoft.Win32.Registry.ClassesRoot.OpenSubKey(@"MIME\Database\Content Type\" + mimetype, false);
            if (regKey != null && regKey.GetValue("Extension") != null)
                return regKey.GetValue("Extension").ToString();
            return null;
        }

        public override async System.Threading.Tasks.Task WriteResponseBodyAsync(OutputFormatterWriteContext context, Encoding selectedEncoding)
        {
            if (context == null)
                throw new ArgumentNullException(nameof(context));

            if (selectedEncoding == null)
                throw new ArgumentNullException(nameof(selectedEncoding));

            if (context.ObjectType == typeof(Binary))
            {
                Binary binary = (Binary)context.Object;

                var stream = new MemoryStream(binary.Data);
                await stream.CopyToAsync(context.HttpContext.Response.Body);
                await stream.FlushAsync();
            }
        }
    }
}