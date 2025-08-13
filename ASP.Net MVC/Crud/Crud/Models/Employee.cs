namespace Crud.Models
{
    public class Employee
    {
        

        public int Id { get; set; }
        public string Name { get; set; }

        //public string Email { get; set; }
        public string Designation { get; set; }

        public string Role { get; set; }
        


        public Employee() { }


        public Employee(int ID, string name, string designation, string role)
        {
            ID = ID;
            Name = name;
            Designation = designation;
            Role = role;
        }



    }
}
