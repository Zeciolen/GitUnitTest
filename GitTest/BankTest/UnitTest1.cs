using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BankLib;

namespace BankTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestConstructors()
        {
            //Arrange
            BankAccount defaultCon = new BankAccount();
            BankAccount setCon = new BankAccount(2000);

            //Assert
            Assert.AreEqual(defaultCon.getBalance(), 1000);
            Assert.AreEqual(setCon.getBalance(), 2000);
        }

        [TestMethod]
        public void TestWithdraw()
        {
            bool test1;
            bool test2;

            //Arrange
            BankAccount testCon = new BankAccount(1000);

            //Act
            test1 = testCon.withdraw(600);
            test2 = testCon.withdraw(500);

            //Assert
            Assert.IsTrue(test1);
            Assert.IsFalse(test2);
        }

        [TestMethod]
        public void TestDeposit()
        {
            bool test1;

            //Arrange
            BankAccount testCon = new BankAccount();

            //Act
            test1 = testCon.deposit(200);

            //Assert
            Assert.IsTrue(test1);
        }
    }
}
