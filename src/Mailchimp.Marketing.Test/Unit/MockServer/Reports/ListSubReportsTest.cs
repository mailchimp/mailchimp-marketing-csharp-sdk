using Mailchimp.Marketing;
using Mailchimp.Marketing.Test.Unit.MockServer;
using Mailchimp.Marketing.Test.Utils;
using NUnit.Framework;

namespace Mailchimp.Marketing.Test.Unit.MockServer.Reports;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class ListSubReportsTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "campaign_id": "campaign_id",
              "reports": [
                {
                  "abuse_reports": 1,
                  "ecommerce": {},
                  "emails_sent": 1,
                  "id": "id",
                  "preview_text": "preview_text",
                  "timeseries": [
                    {}
                  ],
                  "timewarp": [
                    {}
                  ],
                  "type": "type"
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/3.0/reports/campaign_id/sub-reports")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Reports.ListSubReportsAsync(
            new ListSubReportsReportsRequest { CampaignId = "campaign_id" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
