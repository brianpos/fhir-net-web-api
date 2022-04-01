using Microsoft.EntityFrameworkCore;

namespace Microsoft.Health.Fhir.Facade.SqlServer.DemoEntityModels
{
    public class TerminologyDbContext : DbContext
    {
        public TerminologyDbContext(DbContextOptions<TerminologyDbContext> options) : base(options)
        {
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
        public int Id { get; set; }

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
        public int Id { get; set; }

        /// <summary>
        /// Foreign Key for the Closure Table
        /// </summary>
        [System.ComponentModel.DataAnnotations.Schema.ForeignKey("IX_closure_value_closure")]
        public int ClosureId { get; set; }

        /// <summary>
        /// Code Value
        /// </summary>
        [System.ComponentModel.DataAnnotations.StringLength(100)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = false)]
        // [Indexed()]
        public string Code { get; set; }

        /// <summary>
        /// Code Value
        /// </summary>
        [System.ComponentModel.DataAnnotations.StringLength(200)]
        // [Indexed()]
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
        public int Id { get; set; }

        /// <summary>
        /// Foreign Key for the Closure Table
        /// </summary>
        [System.ComponentModel.DataAnnotations.Schema.ForeignKey("IX_closure_relationship_closure")]
        public int ClosureId { get; set; }

        /// <summary>
        /// Code Value
        /// </summary>
        [System.ComponentModel.DataAnnotations.StringLength(100)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = false)]
        // [Indexed()]
        public string ParentCode { get; set; }

        /// <summary>
        /// Code Value
        /// </summary>
        [System.ComponentModel.DataAnnotations.StringLength(100)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = false)]
        // [Indexed()]
        public string ChildCode { get; set; }

        public string ConceptJson { get; set; }
    }
}
