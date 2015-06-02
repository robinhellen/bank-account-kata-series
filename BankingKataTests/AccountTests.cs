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
            var account = new Account();


            account.Deposit(new Money(50));

            log.Received().RecordDeposit(new Money(50));
        }
    }
}
