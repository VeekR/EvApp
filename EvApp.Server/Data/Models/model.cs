
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.Metrics;
namespace EvApp.Server.Data.Models
{
    public class Model
    {
        #region Properties
        /// <summary>
        /// The unique id and primary key for this City
        /// </summary>
        [Key]
        [Required]
        public int Id { get; set; }
        /// <summary>
        /// City name (in UTF8 format)
        /// </summary>
        public required string ModelName { get; set; }
        /// <summary>
        /// City latitude
        /// </summary>
        [Column(TypeName = "decimal(7,4)")]
        public int TopSpeed { get; set; }
        /// <summary>
        /// City longitude
        /// </summary>
        [Column(TypeName = "decimal(7,4)")]
        public int MileRange { get; set; }
        /// <summary>
        /// Country Id (foreign key)
        /// </summary>
        [ForeignKey(nameof(brand))] 
        public int BrandId { get; set; }
        #endregion
        #region Navigation Properties
        /// <summary>
        /// The country related to this city.
        /// </summary>
        public brand? brand { get; set; }
        #endregion
    }
}
