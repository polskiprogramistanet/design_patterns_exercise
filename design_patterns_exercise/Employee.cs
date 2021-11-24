using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns_exercise
{
    public class Employee
    {
        public EmployeeType Type { get;private set; }

        public Employee(EmployeeType employeeType)
        {
            this.Type = employeeType;
        }

        public double CalculateNewSalary(double @base, double sumOfIncomes, double employeeIncome, double importantCalculationFactor)
        {

            switch (Type)
            {
                case EmployeeType.CEO:

                    return @base + sumOfIncomes * 0.2 + 200 + importantCalculationFactor * employeeIncome * 2;
                case EmployeeType.Sales:

                    return @base + sumOfIncomes * 0.1 + importantCalculationFactor * employeeIncome;
                case EmployeeType.Worker:

                    return @base + sumOfIncomes * importantCalculationFactor;
                default:
                    return 0.00;
            }
        }
    }
}
