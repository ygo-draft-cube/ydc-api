using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Xunit;
using Amazon.Lambda.Core;
using Amazon.Lambda.TestUtilities;
using Amazon.Lambda.APIGatewayEvents;
using Amazon.Lambda.AspNetCoreServer;
using Newtonsoft.Json;
using GetDraftList;
using GetDraftList.Models;
using JsonConverter = System.Text.Json.Serialization.JsonConverter;


namespace GetDraftList.Tests
{
    public class ValuesControllerTests
    {
        [Fact]
        public async Task TestGet()
        {
            var lambdaFunction = new LambdaEntryPoint();

            var requestStr = File.ReadAllText("./SampleRequests/DraftListController-GetById.json");
            var request = JsonConvert.DeserializeObject<APIGatewayHttpApiV2ProxyRequest>(requestStr);
            var context = new TestLambdaContext();
            var response = await lambdaFunction.FunctionHandlerAsync(request, context);
            var status = response.StatusCode;
            var body = JsonConvert.DeserializeObject<DraftList>(response.Body);

            Assert.Equal(200, status);
            Assert.Equal("12345",body.Id);
            Assert.True(body.List.Contains("46986414"), "Draft List is missing 46986414");
        }
    }
}