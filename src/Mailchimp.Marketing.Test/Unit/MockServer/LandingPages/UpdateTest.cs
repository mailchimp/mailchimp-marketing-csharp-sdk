using Mailchimp.Marketing;
using Mailchimp.Marketing.Test.Unit.MockServer;
using Mailchimp.Marketing.Test.Utils;
using NUnit.Framework;

namespace Mailchimp.Marketing.Test.Unit.MockServer.LandingPages;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class UpdateTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string requestJson = """
            {}
            """;

        const string mockResponse = """
            {
              "description": "description",
              "list_id": "fde02ad86b",
              "name": "name",
              "store_id": "store_id",
              "title": "title",
              "tracking": {
                "enable_restricted_data_processing": true,
                "track_with_mailchimp": true
              },
              "web_id": 1
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/3.0/landing-pages/page_id")
                    .WithHeader("Content-Type", "application/json")
                    .UsingPatch()
                    .WithBodyAsJson(requestJson)
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.LandingPages.UpdateAsync(
            new UpdateLandingPagesRequest { PageId = "page_id" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
