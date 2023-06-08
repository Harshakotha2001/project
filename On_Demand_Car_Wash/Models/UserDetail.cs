using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace On_Demand_Car_Wash.Models
{
    public class UserDetail
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }

        public string FirstName { get; set; }
      
        public string LastName { get; set; }
       
        [DataType(DataType.PhoneNumber)]
        public long PhoneNumber { get; set; }
      
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
      
        [DataType(DataType.Password)]
        public string Password { get; set; }
      
        public string Token { get; set; }
       
        public string Status { get; set; } = "Active";
    
        public string Role { get; set; }

    }
}
