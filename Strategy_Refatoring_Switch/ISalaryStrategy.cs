using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Refatoring_Switch
{
    public interface ISalaryStrategy
    {
        double Calculate(double @base, double sumOfIncomes, double employeeIncome, double importantCalculationFactor);
    }
}
