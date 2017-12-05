using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Practice.Bank;

namespace Practice.BankTest
{
    [TestClass]
    public class BankAccountTest
    {
        [TestMethod]
        public void Debit_WithValidAmount_UpdatesBalance()
        {
            //ARRANGE
            double beginningBalance = 11.99;
            double debitAmount = 4.55;
            double expected = 7.44;
            BankAccount account = new BankAccount("Mr. Richie Reich", beginningBalance);
            //ACT
            account.Debit(debitAmount);
            //ASSERT
            double actual = account.Balance;
            Assert.AreEqual(expected, actual, 0.001, "Account not debited correctly");
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Debit_WhenAmountIsLessThanZero_ShouldThrowArgumentOutOfRange()
        {
            //ARRANGE
            double beginningBalance = 11.99;
            double debitAmount = -4.55;
            BankAccount account = new BankAccount("Mr. Richie Reich", beginningBalance);
            //ACT
            account.Debit(debitAmount);
            //ASSET is handled by ExpectedException
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Debit_WhenAmountIsMoreThanBalance_ShouldThrowArgumentOutOfRange()
        {
            //ARRANGE
            double beginningBalance = 11.99;
            double debitAmount = 12.99;
            BankAccount account = new BankAccount("Mr. Richie Rich", beginningBalance);
            //ACT
            account.Debit(debitAmount);
            //ASSERT is handled by ExpectedException
        }
        [TestMethod]
        public void Debit_WhenAmountIsLessThanZero_ShouldThrowArgumentOutOfRange_V1()
        {
            //ARRANGE
            double beginningBalance = 11.99;
            double debitAmount = -4.55;
            BankAccount account = new BankAccount("Mr. Richie Reich", beginningBalance);
            //ACT
            try
            {
                account.Debit(debitAmount);
            }
            catch(ArgumentOutOfRangeException ex)
            {
                //ASSET
                StringAssert.Contains(ex.Message, BankAccount.DebitAmountLessThanZeroMessage);
                return;
            }
            Assert.Fail("No exception was thrown");
        }
        [TestMethod]
        public void Debit_WhenAmountIsMoreThanBalance_ShouldThrowArgumentOutOfRange_V1()
        {
            //ARRANGE
            double beginningBalance = 11.99;
            double debitAmount = 12.99;
            BankAccount account = new BankAccount("Mr. Richie Rich", beginningBalance);
            //ACT
            try
            {
                account.Debit(debitAmount);
            }
            catch(ArgumentOutOfRangeException ex)
            {
                //ASSERT
                StringAssert.Contains(ex.Message, BankAccount.DebitAmountExceedsBalanceMessage);
                return;
            }
            Assert.Fail("No exception was thrown");
        }
    }
}
