using Microsoft.AspNetCore.Mvc.Testing;
using Xunit;
using Users.Registration.Api;
using System.Net;
using System.Threading.Tasks;

namespace Users.Registrations.Tests
{
    public class UserRegistrationTest : IClassFixture<WebApplicationFactory<Program>>
    {
        [Fact]
        public async Task GetAllUserInformation_WhenDataIsHas()
        {
            var client = new WebApplicationFactory<Program>().CreateClient();

            var response = await client.GetAsync("/User/GetAllUsers");
            
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }
    }
}