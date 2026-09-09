using Mailchimp.Marketing;
using Mailchimp.Marketing.Test.Unit.MockServer;
using Mailchimp.Marketing.Test.Utils;
using NUnit.Framework;

namespace Mailchimp.Marketing.Test.Unit.MockServer.Reporting;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class GetLandingPageTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "ecommerce": {},
              "timeseries": {}
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/3.0/reporting/landing-pages/outreach_id")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Reporting.GetLandingPageAsync(
            new GetLandingPageReportingRequest { OutreachId = "outreach_id" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
