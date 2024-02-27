namespace esercizio.Models
{

    public static class Db
    {
        public static List<Employee> employees = new List<Employee>();
        public static List<Payment> payments = new List<Payment>();
        public static int EmployeeCount = 1;
        public static int PaymentCount = 1;

        public static void AddEmployee(int id, string name, string surname, string address, string cf, int children, bool married, Roles role)
        {
            Employee e4 = new Employee(Db.EmployeeCount, name, surname, address, cf, children, married, role);
            AddEmployee(e4);
        }

        public static void AddEmployee(Employee emp)
        {
            employees.Add(emp);
            Db.EmployeeCount = Db.EmployeeCount + 1;

        }

        public static void AddPayment(Payment pay)
        {
            payments.Add(pay);
            Employee emp = pay.reference;
            emp.payments.Add(pay);
            Db.PaymentCount = Db.PaymentCount + 1;
        }

        public static void Init()
        {
            Employee e1 = new Employee(Db.EmployeeCount, "Plofi", "Briccoli", "Cesena cucks 123", "BKSJDI72K48F923P", 0, false, Roles.Manager);
            AddEmployee(e1);

            Employee e2 = new Employee(Db.EmployeeCount, "Pepe", "Kek", "Cesena cucks 123", "BKSJDI72K48F923P", 0, false, Roles.Developer);
            AddEmployee(e2);

            Employee e3 = new Employee(Db.EmployeeCount, "Arkhea", "Zaxanon", "Cesena cucks 123", "BKSJDI72K48F923P", 2, true, Roles.Developer);
            AddEmployee(e3);

            Payment p1 = new Payment(Db.PaymentCount, 727.24, PaymentType.Stipendio, ["02-06-2002", "02-07-2002"], Db.employees[0]);
            AddPayment(p1);

            Payment p2 = new Payment(Db.PaymentCount, 727.24, PaymentType.Acconto, ["02-06-2002", "02-07-2002"], Db.employees[1]);
            AddPayment(p2);

            Payment p3 = new Payment(Db.PaymentCount, 727.24, PaymentType.Stipendio, ["02-06-2002", "02-07-2002"], Db.employees[0]);
            AddPayment(p3);



        }
    }
}
