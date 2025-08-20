using System.ComponentModel.DataAnnotations;

namespace CurdWebApplication.Models
{
    public class Employee
    {


        [Key]
        public int Id { get; set; }


        [Required]
        public string Name { get; set; }

        //[Required]
        //[MaxLength]
        //public string Email { get; set; }

        [Required]
        [MaxLength(35)]
        public string Designation { get; set; }

        [Required]
        [StringLength(8,MinimumLength =4)]
        public string Role { get; set; }



        public Employee() { }


        public Employee(int ID, string name, string designation, String role)
        {
            ID = ID;
            Name = name;
            Designation = designation;
            Role = role;
        }



    }
}
