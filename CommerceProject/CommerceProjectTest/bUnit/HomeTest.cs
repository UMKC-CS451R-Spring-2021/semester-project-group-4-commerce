using Bunit;
using Xunit;
using Moq;
using CommerceProject.Data;
using CommerceProject.Pages;
// needed for AddSingleton
using Microsoft.Extensions.DependencyInjection;
using System.Threading.Tasks;

namespace CommerceProjectTest.bUnit
{
    public class HomeTest
    {

        [Fact]
        public void HomeTest_TransactionsLoad()
        {
            var ctx = new TestContext();

            ctx.Services.AddSingleton<GetTransactionData>(new GetTransactionData());
            ctx.Services.AddSingleton<WeatherForecastService>(new WeatherForecastService());
            
            var cut = ctx.RenderComponent<Home>();

            Assert.NotNull(cut.Instance.transaction_list);
        }

        [Fact]
        public void HomeTest_TransactionTableLoads()
        {
            var ctx = new TestContext();

            ctx.Services.AddSingleton<GetTransactionData>(new GetTransactionData());
            ctx.Services.AddSingleton<WeatherForecastService>(new WeatherForecastService());

            var cut = ctx.RenderComponent<Home>();

            var tableHead = cut.FindAll("tr:first-child");
            var tableCells = cut.FindAll("tr ");
            var numTransactions = cut.Instance.transaction_list.Count;

            //Assert.All(tableCells, td => td.HasAttribute("style"));
            Assert.Equal(4, tableHead.Count);
            Assert.Equal(numTransactions, tableCells.Count);
        }

        [Fact]
        public void HomeTest_TransactionView()
        {
            var ctx = new TestContext();

            var transaction = new Transaction(100, "4/21/2020", "KC");

            var GetTransactionsMoq = new Mock<GetTransactionData>();
            GetTransactionsMoq.Setup(m => m.GetTransactions())
                .Returns(new Transaction[] { transaction, transaction, transaction });

            ctx.Services.AddSingleton<GetTransactionData>(GetTransactionsMoq.Object);

            var cut = ctx.RenderComponent<Home>();
            var table = cut.Find("table-responsive-sm");

            Assert.Equal(3, table.ChildElementCount);
        }
    }
}
