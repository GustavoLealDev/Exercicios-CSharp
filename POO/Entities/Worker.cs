using System;
using System.Collections.Generic;
using Course.Entities.Enums;

namespace Course.Entities
{
     class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public Department Department { get; set; }
        public double BaseSalary { get; set; }
        public List<HourContract> Contracts { get; set; } = new List<HourContract>();

        public Worker(string name, WorkerLevel level, Department department, double baseSalary)
        {
            Name = name;
            Level = level;
            Department = department;
            BaseSalary = baseSalary;
        }

        public void AddContract (HourContract contract)
        {
            Contracts.Add(contract);
        }

        public void Removeontract(HourContract contract)
        {
            Contracts.Remove(contract);
        }

    }
}
