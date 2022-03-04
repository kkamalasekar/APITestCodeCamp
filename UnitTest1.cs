using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestSharp;
using System;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace AusPostTest
{
    [TestClass]
    public class UnitTest1
    {
        private Task<RestResponse> response;

        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            RestClient client = new RestClient("https://digitalapi.auspost.com.au/");
            RestRequest request = new RestRequest("postcode/search", Method.Get);
            request.AddHeader("auth-key", "4fc1962d-4624-419d-b847-40955ec58949");
            request.AddParameter("q", "Hallett Cove");
            request.AddParameter("State", "SA");

            //Act
            response = client.ExecuteAsync(request);
            var jsonBody = response.Result.Content;
            PCSearchResBody body = JsonConvert.DeserializeObject<PCSearchResBody>(jsonBody);
            //dynamic body = JsonConvert.DeserializeObject(jsonBody);

            //Assert
            //Assert.IsTrue(body.localities.locality[0].postcode == 5158);
            Assert.AreEqual(body.localities.locality.postcode, 5158);

        }
    }
}
