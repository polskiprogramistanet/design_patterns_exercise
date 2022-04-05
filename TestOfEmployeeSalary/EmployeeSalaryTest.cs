using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Strategy_Refatoring_Switch;

namespace Tests
{
    [TestClass]
    public class EmployeeSalaryTest
    {
        [TestMethod]
        public void CalculateSalaryForCeoTest()
        {
            //Arrange
            var employee = new Employee(EmployeeType.CEO, new CEOStrategy());

            //Act
            var salary = employee.CalculateNewSalary(100, 100, 1, 2);

            //Assert
            Assert.AreEqual(324.0d, salary, 0.0001);
        }

        [TestMethod]
        public void CalculateSalaryForSalesTest()
        {
            //Arrange
            var employee = new Employee(EmployeeType.Sales, new SalesStrategy());

            //Act
            var salary = employee.CalculateNewSalary(100, 100, 1, 2);

            //Assert
            Assert.AreEqual(112.0d, salary, 0.0001);

        }

        [TestMethod]
        public void CalculateSalaryForWorkerTest()
        {
            //Arrange
            var employee = new Employee(EmployeeType.Worker, new WorkerStrategy());

            //Act
            var salary = employee.CalculateNewSalary(100, 100, 1, 2);


            //Assert
            Assert.AreEqual(300.0d, salary, 0.0001);
        }
        [TestMethod]
        public void CalculateSalaryForWorkerTest2()
        {
            //Arrange
            var employee = new Employee(EmployeeType.Worker, new WorkerStrategy());

            //Act
            var salary = employee.CalculateNewSalary(100, 100, 1, 2);


            //Assert
            Assert.AreEqual(300.0d, salary, 0.0001);
        }
    }
}
