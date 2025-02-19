using System;
namespace Course.Entities
{
    class Employee : IComparable
    {
        public string Name { get; set; }
        public double Salary { get; set; }

        public Employee(string csvEmployee)
        {
            string[] vet = csvEmployee.Split(',');
            Name = vet[0];
            Salary = double.Parse(vet[1]);
        }

        public override string ToString()
        {
            return Name + ", " + Salary.ToString("F2");
        }

        public int CompareTo(object? obj)
        {
            if (!(obj is Employee))
            {
                throw new ArgumentNullException("Error: Argument not Employee");
            }
            Employee other = obj as Employee;
            return Name.CompareTo(other.Name);

        }
    }
}
