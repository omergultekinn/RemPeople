using Newtonsoft.Json;
using RemPeople.Api;
using RemPeople.Model;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;
using Xunit;

namespace RemPeople.Test
{
    public class SalaryControllerTests : IClassFixture<StartupFixture<Startup>>
    {
        private HttpClient Client;

        public SalaryControllerTests(StartupFixture<Startup> fixture)
        {
            Client = fixture.Client;
        }
        [Theory]
        [InlineData(1, 500)]
        public async Task GetSalaryByIdTest(int id, decimal expected)
        {
            var request = $"/api/v1.0/salary/getsalarybyid?id={id}";
            var response = await Client.GetAsync(request);
            var stringResponse = await response.Content.ReadAsStringAsync();

            var clientResponse = JsonConvert.DeserializeObject<ClientResponseModel>(stringResponse);
            Assert.Equal(expected, clientResponse.Salary);
        }

        [Fact]
        public async Task GetAllEmployeesTest()
        {
            var request = $"/api/v1.1/salary/getallemployees";
            var response = await Client.GetAsync(request);
            var stringResponse = await response.Content.ReadAsStringAsync();

            var clientResponse = JsonConvert.DeserializeObject<List<ClientResponseModel>>(stringResponse);
            Assert.Equal(4, clientResponse.Count);
        }
    }
}
