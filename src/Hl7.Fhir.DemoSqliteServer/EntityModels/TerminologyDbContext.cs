using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Hl7.Fhir.DemoSqliteFhirServer.DemoEntityModels
{
    public class TerminologyDbContext : DbContext
    {
        public TerminologyDbContext(DbContextOptions<TerminologyDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
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

        public DbSet<ClosureTable> ClosureTable { get; set; }
        public DbSet<ClosureConcept> ClosureConcepts { get; set; }
        public DbSet<ClosureRelationship> ClosureRelationships { get; set; }
    }

    [System.ComponentModel.DataAnnotations.Schema.Table("closure")]
    public class ClosureTable
    {
        /// <summary>
        /// Internal Primary Key for the Closure Table
        /// </summary>
        [System.ComponentModel.DataAnnotations.Key()]
        public long Id { get; set; }

        public long CodeSystemHash { get; set; }

        [System.ComponentModel.DataAnnotations.StringLength(2048)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = false)]
        public string CodeSystem { get; set; }

        /// <summary>
        /// The Name of the Closure Table as used on the External Terminology Server
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Version Number of the sync table last updated
        /// </summary>
        [System.ComponentModel.DataAnnotations.StringLength(40)]
        public string SyncVersion { get; set; }
    }

    [System.ComponentModel.DataAnnotations.Schema.Table("closure_concept")]
    public class ClosureConcept
    {
        /// <summary>
        /// Internal Primary Key for the Closure Value Table
        /// </summary>
        [System.ComponentModel.DataAnnotations.Key()]
        public long Id { get; set; }

        /// <summary>
        /// Foreign Key for the Closure Table
        /// </summary>
        [System.ComponentModel.DataAnnotations.Schema.ForeignKey("IX_closure_value_closure")]
        public long ClosureId { get; set; }

        /// <summary>
        /// Code Value
        /// </summary>
        [System.ComponentModel.DataAnnotations.StringLength(100)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = false)]
        [Indexed()]
        public string Code { get; set; }

        /// <summary>
        /// Code Value
        /// </summary>
        [System.ComponentModel.DataAnnotations.StringLength(200)]
        [Indexed()]
        public string Display { get; set; }

        /// <summary>
        /// This code value is actually in our internal FHIR server data (not to be cleared during a reset)
        /// </summary>
        public bool ActualDataValue { get; set; }
    }

    [System.ComponentModel.DataAnnotations.Schema.Table("closure_relationship")]
    public class ClosureRelationship
    {
        /// <summary>
        /// Internal Primary Key for the Closure Value Table
        /// </summary>
        [System.ComponentModel.DataAnnotations.Key()]
        public long Id { get; set; }

        /// <summary>
        /// Foreign Key for the Closure Table
        /// </summary>
        [System.ComponentModel.DataAnnotations.Schema.ForeignKey("IX_closure_relationship_closure")]
        public long ClosureId { get; set; }

        /// <summary>
        /// Code Value
        /// </summary>
        [System.ComponentModel.DataAnnotations.StringLength(100)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = false)]
        [Indexed()]
        public string ParentCode { get; set; }

        /// <summary>
        /// Code Value
        /// </summary>
        [System.ComponentModel.DataAnnotations.StringLength(100)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = false)]
        [Indexed()]
        public string ChildCode { get; set; }

        public string ConceptJson { get; set; }
    }
}
