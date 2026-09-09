using Mailchimp.Marketing;
using Mailchimp.Marketing.Test.Unit.MockServer;
using Mailchimp.Marketing.Test.Utils;
using NUnit.Framework;

namespace Mailchimp.Marketing.Test.Unit.MockServer.LandingPages;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class ListContentTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "html": "html",
              "json": "json"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/3.0/landing-pages/page_id/content")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.LandingPages.ListContentAsync(
            new ListContentLandingPagesRequest { PageId = "page_id" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
