using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankingKata;
using NSubstitute;
using NUnit.Framework;

namespace BankingKataTests
{
    class AccountTests
    {
        [Test]
        public void DepositingCashIntoAccountRecordsCashDeposit()
        {
            var log = Substitute.For<IAccountLog>();
            var account = new Account(log);
            account.Deposit(new Money(50));

            var comedyVariable = log.Received();
            comedyVariable.RecordDeposit(new Money(50));
        }
    }
}
