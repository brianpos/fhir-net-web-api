/* 
 * Copyright (c) 2017+ brianpos, Firely and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://github.com/ewoutkramer/fhir-net-api/blob/master/LICENSE
 */

namespace Hl7.Fhir.WebApi
{
    public static class Const
    {
        static public int MAX_HISTORY_RESULT_SIZE = 400;
        static public int DEFAULT_PAGE_SIZE = 20;

        static public string ResourceIdentityKey = "ResourceIdentity";
    }

    public static class FhirParameter
    {
        public const string SUMMARY = "_summary";
        public const string COUNT = "_count";
        public const string SINCE = "_since";
        public const string SORT = "_sort";
    }
}
