using Mailchimp.Marketing;
using Mailchimp.Marketing.Test.Unit.MockServer;
using Mailchimp.Marketing.Test.Utils;
using NUnit.Framework;

namespace Mailchimp.Marketing.Test.Unit.MockServer.Batches;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class CreateTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string requestJson = """
            {
              "operations": [
                {
                  "method": "GET",
                  "path": "/lists"
                }
              ]
            }
            """;

        const string mockResponse = """
            {}
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/3.0/batches")
                    .WithHeader("Content-Type", "application/json")
                    .UsingPost()
                    .WithBodyAsJson(requestJson)
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Batches.CreateAsync(
            new CreateBatchesRequest
            {
                Operations =
                    new global::System.Collections.Generic.List<CreateBatchesRequestOperationsItem>()
                    {
                        new CreateBatchesRequestOperationsItem
                        {
                            Method = CreateBatchesRequestOperationsItemMethod.Get,
                            Path = "/lists",
                        },
                    },
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
