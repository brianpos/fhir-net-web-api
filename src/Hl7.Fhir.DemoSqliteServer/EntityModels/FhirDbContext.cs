using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Hl7.Fhir.WebApi.DemoEntityModels
{
    public class FhirDbContext : DbContext
    {
        public FhirDbContext(DbContextOptions<FhirDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<resource_history>().HasKey(ba => new { ba.internal_id, ba.version_id});
            base.OnModelCreating(modelBuilder);

            // https://blog.dangl.me/archive/handling-datetimeoffset-in-sqlite-with-entity-framework-core/
            if (Database.ProviderName == "Microsoft.EntityFrameworkCore.Sqlite")
            {
                // SQLite does not have proper support for DateTimeOffset via Entity Framework Core, see the limitations
                // here: https://docs.microsoft.com/en-us/ef/core/providers/sqlite/limitations#query-limitations
                // To work around this, when the Sqlite database provider is used, all model properties of type DateTimeOffset
                // use the DateTimeOffsetToBinaryConverter
                // Based on: https://github.com/aspnet/EntityFrameworkCore/issues/10784#issuecomment-415769754
                // This only supports millisecond precision, but should be sufficient for most use cases.
                foreach (var entityType in modelBuilder.Model.GetEntityTypes())
                {
                    var properties = entityType.ClrType.GetProperties().Where(p => p.PropertyType == typeof(DateTimeOffset)
                                                                                || p.PropertyType == typeof(DateTimeOffset?));
                    foreach (var property in properties)
                    {
                        modelBuilder
                            .Entity(entityType.Name)
                            .Property(property.Name)
                            .HasConversion(new DateTimeOffsetToBinaryConverter());
                    }
                }
            }
        }

        public DbSet<resource_header> Resource_Header { get; set; }
        public DbSet<resource_history> Resource_History { get; set; }
        public DbSet<IndexString> SearchIndexString { get; set; }
    }

    public class resource_header
    {
        /// <summary>
        /// Internal Identifier
        /// </summary>
        [System.ComponentModel.DataAnnotations.Key()]
        public long internal_id { get; set; }

        [System.ComponentModel.DataAnnotations.StringLength(128)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// The key of the resource_history that is most recent
        /// </summary>
        public int current_version_id { get; set; }

        /// <summary>
        /// ID that is exposed to the FHIR interface
        /// </summary>
        [System.ComponentModel.DataAnnotations.StringLength(64)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = false)]
        public string resource_id { get; set; }

        /// <summary>
        /// This resource is currently deleted
        /// </summary>
        public bool deleted { get; set; }

        /// <summary>
        /// The date that this entry was last modified
        /// </summary>
        public DateTimeOffset last_updated { get; set; }

        /// <summary>
        /// The XML content of the record
        /// </summary>
        [System.ComponentModel.DataAnnotations.Schema.Column(TypeName = "xml")]
        public string contentXML { get; set; }
    }

    public class resource_history
    {
        /// <summary>
        /// Foreign Key to the resource internal id
        /// </summary>
        public long internal_id { get; set; }

        [System.ComponentModel.DataAnnotations.StringLength(128)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// ID that is exposed to the FHIR interface
        /// </summary>
        [System.ComponentModel.DataAnnotations.StringLength(64)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = false)]
        public string resource_id { get; set; }

        /// <summary>
        /// Version ID
        /// </summary>
        /// <remarks>
        /// This version id is what is found as the version field in the Meta object
        /// and thus what is considered the resource instance's VersionID
        /// This does mean that these are not sequential within a specific instance,
        /// but across all instances of the same resource type.
        /// This approach does not require the use of composite primary keys, or
        /// evaluating the next applicable version id for a specific resource id.
        /// It was a tradeoff between performance of updates, and readability and
        /// debug-ability - and what people would usually expect.
        /// </remarks>
        public int version_id { get; set; }

        /// <summary>
        /// This resource is currently deleted
        /// </summary>
        public bool deleted { get; set; }

        /// <summary>
        /// The date that this entry was last modified
        /// </summary>
        public DateTimeOffset last_updated { get; set; }

        /// <summary>
        /// Used the The PUT HTTP Method that to create this record
        /// </summary>
        /// <remarks>
        /// true = PUT, false = POST, null = DELETE
        /// </remarks>
        public bool? UsedPutHttpMethod { get; set; }

        /// <summary>
        /// The XML content of the record
        /// </summary>
        [System.ComponentModel.DataAnnotations.Schema.Column(TypeName = "xml")]
        public byte[] contentXML { get; set; }
    }

    [System.ComponentModel.DataAnnotations.Schema.Table("index_string", Schema = "pfhir")]
    public class IndexString
    {
        [System.ComponentModel.DataAnnotations.Key()]
        public long Id { get; set; }

        public long internal_id { get; set; }

        [System.ComponentModel.DataAnnotations.StringLength(256)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = false)]
        public string Path { get; set; }

        [System.ComponentModel.DataAnnotations.StringLength(256)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = false)]
        public string Value { get; set; }
    }
}
