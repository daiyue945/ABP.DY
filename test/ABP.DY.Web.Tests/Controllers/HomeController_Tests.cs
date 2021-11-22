using System.Threading.Tasks;
using ABP.DY.Models.TokenAuth;
using ABP.DY.Web.Controllers;
using Shouldly;
using Xunit;

namespace ABP.DY.Web.Tests.Controllers
{
    public class HomeController_Tests: DYWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}