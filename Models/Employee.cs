namespace esercizio.Models
{
    public class Employee
    {

        public int id;
        public string name;
        public string surname;
        public string address;
        public string cf;
        public int children;
        public bool married;
        public Roles role;
        public List<Payment> payments = new List<Payment>();

        public Employee(int id, string name, string surname, string address, string cf, int children, bool married, Roles role)
        {
            this.id = id;
            this.name = name;
            this.surname = surname;
            this.address = address;
            this.cf = cf; this.children = children;
            this.married = married;
            this.role = role;
        }


    }
}
