using System;

namespace Properties
{
    class Employee
    {
        string _empName; // fields are private by default
        string _empSSN;
        public const double PI = 3.14; // constant field

        // get define read only
        public string SocialSecurityNumber => _empSSN;
        // this is syntax sugar for:
        // public string SocialSecurityNumber { get { return _empSSN; } }

        // property with input validation
        public string Name
        {
            get => _empName;
            set
            {
                if (value.Length > 15)
                {
                    throw new Exception("Error! Name length exceeds 15 characters!");
                }
                else
                {
                    _empName = value;
                }
            }
        }
        // auto-implemented property, if the property type is a reference type, the property is initialized to null
        public int Id { get; init; } // init keyword: after initialization, the property is set to readonly aka immutable
        public float Pay { get; set; } = 99; // auto-implemented proprety can have default values
        public int Age { get; set; }

        public Employee() {}
        public Employee(string name, int id, float pay, int age, string ssn)
        {
            // good practice to use properties in constructors
            Name = name;
            Id = id;
            Pay = pay;
            Age = age;
            _empSSN = ssn; // a read only property doesn't have a setter, so need to use the field directly
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            // calling the constructor
            var emp = new Employee("Henry", 1, 32500, 24, "abcdefg");
            Console.WriteLine("Name: {0}, Id: {1}, Pay: {2}, Age: {3}", emp.Name, emp.Id, emp.Pay, emp.Age);

            // initialization syntax
            var emp1 = new Employee() { Name = "Henry", Id = 1, Pay = 32500, Age = 24 };
            Console.WriteLine("Name: {0}, Id: {1}, Pay: {2}, Age: {3}", emp1.Name, emp1.Id, emp1.Pay, emp1.Age);
            Console.WriteLine(Employee.PI);
            

        }
    }
}
