using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hl7.Fhir.Specification.Source
{
    public class SpecificationContext : DbContext
    {
        public SpecificationContext(DbContextOptions<SpecificationContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ConformanceResourceEntity>().HasIndex(entity => new { entity.ResourceType, entity.ResourceId, entity.InternalId }).HasDatabaseName("IX_ConformanceResource_ResourceId");
            modelBuilder.Entity<ConformanceResourceEntity>().HasIndex(entity => new { entity.CanonicalUrl, entity.Version, entity.InternalId }).HasDatabaseName("IX_ConformanceResource_VersionedCanonicalUrl");
            modelBuilder.Entity<ConformanceResourceEntity>().HasIndex(entity => new { entity.CanonicalUrl, entity.InternalId }).HasDatabaseName("IX_ConformanceResource_CurrentCanonicalUrl").HasFilter("Current = 1");
            modelBuilder.Entity<ConformanceResourceEntity>().HasIndex(entity => new { entity.SourceCanonicalUrl, entity.InternalId }).HasDatabaseName("IX_ConformanceResource_ConceptMapSource");
            modelBuilder.Entity<ConformanceResourceEntity>().HasIndex(entity => new { entity.SourceCanonicalUrl, entity.TargetCanonicalUrl, entity.InternalId }).HasDatabaseName("IX_ConformanceResource_ConceptMapSourceAndTarget");
            modelBuilder.Entity<ConformanceResourceEntity>().HasIndex(entity => new { entity.TargetCanonicalUrl, entity.InternalId }).HasDatabaseName("IX_ConformanceResource_ConceptMapTarget");
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<ConformanceResourceEntity> ConformanceResource { get; set; }
    }

    /// <summary>
    /// A Conformance resource e.g. StructureDefinition, Questionaire, ValueSet
    /// </summary>
    [Table("ConformanceResource")]
    public class ConformanceResourceEntity
    {
        /// <summary>
        /// Internal ID for the entity (PK)
        /// </summary>
        [Key(), DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int InternalId { get; set; }

        /// <summary>
        /// The FHIR Resource Type
        /// </summary>
        [StringLength(128)]
        [Required(AllowEmptyStrings = false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// ID of the FHIR Resource
        /// </summary>
        [StringLength(64)]
        [Required(AllowEmptyStrings = false)]
        public string ResourceId { get; set; }

        /// <summary>
        /// Canonical URL of the conformance resource
        /// </summary>
        [StringLength(256)]
        [Required(AllowEmptyStrings = false)]
        public string CanonicalUrl { get; set; }

        /// <summary>
        /// The Canonical Version of the conformance resource
        /// - not the fhir history version number
        /// </summary>
        [StringLength(20)]
        public string Version { get; set; }

        /// <summary>
        /// Flag indicating if this resource is the current canonical version
        /// </summary>
        public bool Current { get; set; }

        /// <summary>
        /// Where this resource is a ConceptMap, the source canonical URL mapped from
        /// </summary>
        [StringLength(256)]
        public string SourceCanonicalUrl { get; set; }

        /// <summary>
        /// Where this resource is a ConceptMap, the target canonical URL mapped to
        /// </summary>
        [StringLength(256)]
        public string TargetCanonicalUrl { get; set; }

        /// <summary>
        /// The XML content of the ConformanceResource
        /// </summary>
        [System.ComponentModel.DataAnnotations.Schema.Column(TypeName = "xml")]
        [Required(AllowEmptyStrings = false)]
        public string ResourceXML { get; set; }
    }
}
