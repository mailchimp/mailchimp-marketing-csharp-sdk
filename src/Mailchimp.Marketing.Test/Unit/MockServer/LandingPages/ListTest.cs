using Mailchimp.Marketing;
using Mailchimp.Marketing.Test.Unit.MockServer;
using Mailchimp.Marketing.Test.Utils;
using NUnit.Framework;

namespace Mailchimp.Marketing.Test.Unit.MockServer.LandingPages;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class ListTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "landing_pages": [
                {
                  "description": "description",
                  "list_id": "fde02ad86b",
                  "name": "name",
                  "store_id": "store_id",
                  "title": "title",
                  "web_id": 1
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock.RequestBuilders.Request.Create().WithPath("/3.0/landing-pages").UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.LandingPages.ListAsync(new ListLandingPagesRequest());
        JsonAssert.AreEqual(response, mockResponse);
    }
}
