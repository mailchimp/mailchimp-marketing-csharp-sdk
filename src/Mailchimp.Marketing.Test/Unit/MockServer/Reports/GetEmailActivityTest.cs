using Mailchimp.Marketing;
using Mailchimp.Marketing.Test.Unit.MockServer;
using Mailchimp.Marketing.Test.Utils;
using NUnit.Framework;

namespace Mailchimp.Marketing.Test.Unit.MockServer.Reports;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class GetEmailActivityTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "activity": [
                {
                  "action": "action",
                  "ip": "ip",
                  "timestamp": "2024-01-15T09:30:00.000Z",
                  "type": "type",
                  "url": "url"
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/3.0/reports/campaign_id/email-activity/subscriber_hash")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Reports.GetEmailActivityAsync(
            new GetEmailActivityReportsRequest
            {
                CampaignId = "campaign_id",
                SubscriberHash = "subscriber_hash",
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
