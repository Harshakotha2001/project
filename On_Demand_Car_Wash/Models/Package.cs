using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace On_Demand_Car_Wash.Models
{
    public class Package
    {
        [Key]
        [DataType("int")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public float Price { get; set; }
        public string Status { get; set; } = "Available";
    }
}
