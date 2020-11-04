using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Testing;
using RESTApiTraining;
using Xunit;
using Newtonsoft.Json;
using System.Collections.Generic;
using RESTApiTraining.Models;
using System.Net.Http;
using System.Text;
using System.Net;

namespace TestingREST
{
    public class ControllerTests : IClassFixture<WebApplicationFactory<Startup>>
    {
        private readonly WebApplicationFactory<Startup> factory;
        public ControllerTests(WebApplicationFactory<Startup> factory)
        {
            this.factory = factory;
        }

        [Fact]
        public async Task MainPageLoadsSuccessfully()
        {
            var responseMessage = await factory.CreateClient().GetAsync("/");

            responseMessage.EnsureSuccessStatusCode();
        }
        /*[Fact]
        public async Task Doubling_ReturnResult()
        {
            var expected = 10;

            var response = await factory.CreateClient().GetAsync("api/home/doubling?input=5");
            var data = await response.Content.ReadAsStringAsync();

            var result = JsonConvert.DeserializeObject<Dictionary<string, int>>(data);
            result.TryGetValue("result", out int actual);

            response.EnsureSuccessStatusCode(); // version 1 off check of Status Code
            Assert.Equal(expected, actual);
        }*/
        [Fact]
        public async Task Doubling_ReturnResult() // an Object result version
        {
            var expected = 10;

            var response = await factory.CreateClient().GetAsync("api/home/doubling?input=5");
            var data = await response.Content.ReadAsStringAsync();

            var result = JsonConvert.DeserializeObject<Data>(data);

            response.EnsureSuccessStatusCode();
            Assert.Equal(expected, result.Result);
        }
        [Fact]
        public async Task Doubling_ReturnError()
        {
            var expected = "Please provide an input!";

            var response = await factory.CreateClient().GetAsync("api/home/doubling");
            var data = await response.Content.ReadAsStringAsync();

            var result = JsonConvert.DeserializeObject<Dictionary<string, string>>(data);
            result.TryGetValue("error", out string actual);

            Assert.Equal(HttpStatusCode.BadRequest, response.StatusCode);
            Assert.Equal(expected, actual);
        }
        [Fact]
        public async Task DoUntil_Multiply_ReturnResult()
        {
            //Arrange
            var expected = 3628800;
            var toSend = JsonConvert.SerializeObject(new Operation { Until = 10 });
            var httpContent = new StringContent(toSend, Encoding.UTF8, "application/json");

            //Act
            var response = await factory.CreateClient().PostAsync("api/home/dountil/factor", httpContent);
            var data = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<Dictionary<string, int>>(data);
            result.TryGetValue("result", out int actual);

            //Assert
            Assert.Equal(HttpStatusCode.OK, response.StatusCode); // version 2 off check of Status Code
            Assert.Equal(expected, actual);
        }
        [Fact]
        public async Task DoUntil_Sum_ReturnResult()
        {
            //Arrange
            var expected = 55;
            var toSend = JsonConvert.SerializeObject(new Operation { Until = 10 });
            var httpContent = new StringContent(toSend, Encoding.UTF8, "application/json");

            //Act
            var response = await factory.CreateClient().PostAsync("api/home/dountil/sum", httpContent);
            var data = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<Dictionary<string, int>>(data);
            result.TryGetValue("result", out int actual);

            //Assert
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
            Assert.Equal(expected, actual);
        }
        [Fact]
        public async Task DoUntil_ReturnError()
        {
            //Arrange
            var expected = "Please provide a number!";
            var httpContent = new StringContent("", Encoding.UTF8, "application/json");

            //Act
            var response = await factory.CreateClient().PostAsync("api/home/dountil/sum", httpContent);
            var data = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<Dictionary<string, string>>(data);
            result.TryGetValue("error", out string actual);

            //Assert
            Assert.Equal(HttpStatusCode.BadRequest, response.StatusCode);
            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData("Peter", "specialist")]
        [InlineData("Pepa", "anarchist")]
        [InlineData("Bob", "assist")]
        public async Task Greeter_ReturnResult(string name, string title)
        {
            //Arrange
            var expected = $"Oh, hi there {name}, my dear {title}!";

            //Act
            var response = await factory.CreateClient().GetAsync($"api/home/greeter?name={name}&title={title}");
            var data = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<Dictionary<string, string>>(data);
            result.TryGetValue("welcome_message", out string actual);

            //Assert
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData("Please provide a title!", "Peter", null)]
        [InlineData("Please provide a name!", null, "anarchist")]
        [InlineData("Please provide a name and a title!", null, null)]
        public async Task Greeter_ReturnErrors(string expected, string name, string title)
        {
            //Arrange
            //var expected = $"Oh, hi there {name}, my dear {title}!";

            //Act
            var response = await factory.CreateClient().GetAsync($"api/home/greeter?name={name}&title={title}");
            var data = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<Dictionary<string, string>>(data);
            result.TryGetValue("error", out string actual);

            //Assert
            Assert.Equal(HttpStatusCode.BadRequest, response.StatusCode);
            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData("Petera", "Peter")]
        [InlineData("Reacta", "React")]
        [InlineData("Kytara", "Kytar")]
        public async Task AppendA_ReturnResults(string expected, string appendable)
        {
            //Arrange
            // expected passed through inline data

            //Act
            var response = await factory.CreateClient().GetAsync($"api/home/appenda/{appendable}");
            var data = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<Dictionary<string, string>>(data);
            result.TryGetValue("appended", out string actual);

            //Assert
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
            Assert.Equal(expected, actual);
        }
    }
}
