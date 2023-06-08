using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace On_Demand_Car_Wash.Models
{
    public class Address
    {
        [Key]
        [DataType("int")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string CustAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Pincode { get; set; }
        public string Country { get; set; }

        public int CustId { get; set; }
        [ForeignKey("CustId")]
        public UserDetail UserDetail { get; set; }
    }
}
