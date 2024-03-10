using System.Threading.Tasks;
using eManager.Models.TokenAuth;
using eManager.Web.Controllers;
using Shouldly;
using Xunit;

namespace eManager.Web.Tests.Controllers
{
    public class HomeController_Tests: eManagerWebTestBase
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