using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Refatoring_Switch
{
    public class Employee
    {
        public EmployeeType Type { get;private set; }
        ISalaryStrategy salaryStrategy;
        public Employee(EmployeeType employeeType, ISalaryStrategy salaryStrategy)
        {
            this.Type = employeeType;
            this.salaryStrategy = salaryStrategy;
        }
        public double CalculateNewSalary(double @base, double sumOfIncomes, double employeeIncome, double importantCalculationFactor)
        {
            return this.salaryStrategy.Calculate(@base,  sumOfIncomes,  employeeIncome,  importantCalculationFactor);
            //switch (Type)
            //{
            //    case EmployeeType.CEO:

            //        return new  CEOStrategy().Calculate(@base, sumOfIncomes, employeeIncome, importantCalculationFactor);
            //    case EmployeeType.Sales:

            //        return new SalesStrategy().Calculate(@base, sumOfIncomes, employeeIncome, importantCalculationFactor);
            //    case EmployeeType.Worker:

            //        return new WorkerStrategy().Calculate(@base, sumOfIncomes, employeeIncome, importantCalculationFactor);
            //    default:
            //        return 0.00;
            //}
        }

    }

     
}
