using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankingKata;
using NSubstitute;
using NUnit.Framework;

namespace BankingKataTests
{
    class AccountLogTests
    {
        [Test]
        public void LogStartsEmpty()
        {
            var accountLog = new AccountLog();

            var mock = Substitute.For<IAccountLog>();
            accountLog.CopyTo(mock);

            mock.DidNotReceiveWithAnyArgs().RecordDeposit(null);
        }

        [Test]
        public void LogHasOneRecordAfterOneDeposit()
        {
            var accountLog = new AccountLog();
            accountLog.RecordDeposit(new Money(50));

            var mock = Substitute.For<IAccountLog>();
            accountLog.CopyTo(mock);

            mock.Received(1).RecordDeposit(new Money(50));
        }
    }
}
