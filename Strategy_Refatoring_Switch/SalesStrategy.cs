using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Refatoring_Switch
{
    public class SalesStrategy : ISalaryStrategy
    {
        public double Calculate(double @base, double sumOfIncomes, double employeeIncome, double importantCalculationFactor)
        {
            return @base + sumOfIncomes * 0.1 + importantCalculationFactor * employeeIncome;
        }

    }
}
