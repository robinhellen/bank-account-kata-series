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
    }
}
