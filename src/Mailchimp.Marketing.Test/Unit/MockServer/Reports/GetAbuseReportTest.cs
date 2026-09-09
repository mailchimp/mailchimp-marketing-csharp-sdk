using Mailchimp.Marketing;
using Mailchimp.Marketing.Test.Unit.MockServer;
using Mailchimp.Marketing.Test.Utils;
using NUnit.Framework;

namespace Mailchimp.Marketing.Test.Unit.MockServer.Reports;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class GetAbuseReportTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "merge_fields": {
                "key": {
                  "addr1": "addr1",
                  "addr2": "addr2",
                  "city": "city",
                  "state": "state",
                  "zip": "zip",
                  "country": "country"
                }
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/3.0/reports/campaign_id/abuse-reports/report_id")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Reports.GetAbuseReportAsync(
            new GetAbuseReportReportsRequest { CampaignId = "campaign_id", ReportId = "report_id" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
