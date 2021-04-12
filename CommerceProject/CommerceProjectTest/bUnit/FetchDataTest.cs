using Bunit;
using CommerceProject.Data;
using Xunit;
using CommerceProject.Pages;
// needed for AddSingleton
using Microsoft.Extensions.DependencyInjection;

namespace CommerceProjectTest
{
    public class FetchDataTest : TestContext
    {

        [Fact]
        public void TableRenderTest()
        {
            var ctx = new TestContext();

            ctx.Services.AddSingleton<WeatherForecastService>(new WeatherForecastService());

            var cut = ctx.RenderComponent<FetchData>();

            // have to make sure forecasts is public, not private
            Assert.NotNull(cut.Instance.forecasts);
        }

    }
}

