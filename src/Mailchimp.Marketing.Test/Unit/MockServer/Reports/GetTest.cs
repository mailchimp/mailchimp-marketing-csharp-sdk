using Mailchimp.Marketing;
using Mailchimp.Marketing.Test.Unit.MockServer;
using Mailchimp.Marketing.Test.Utils;
using NUnit.Framework;

namespace Mailchimp.Marketing.Test.Unit.MockServer.Reports;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class GetTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "ab_split": {
                "a": {
                  "abuse_reports": 1,
                  "bounces": 1,
                  "forwards": 1,
                  "forwards_opens": 1,
                  "last_open": "last_open",
                  "opens": 1,
                  "recipient_clicks": 1,
                  "unique_opens": 1,
                  "unsubs": 1
                },
                "b": {
                  "abuse_reports": 1,
                  "bounces": 1,
                  "forwards": 1,
                  "forwards_opens": 1,
                  "last_open": "last_open",
                  "opens": 1,
                  "recipient_clicks": 1,
                  "unique_opens": 1,
                  "unsubs": 1
                }
              },
              "abuse_reports": 1,
              "bounces": {
                "hard_bounces": 1,
                "soft_bounces": 1,
                "syntax_errors": 1
              },
              "clicks": {
                "click_rate": 1.1,
                "clicks_total": 1,
                "last_click": "2024-01-15T09:30:00.000Z",
                "unique_clicks": 1,
                "unique_subscriber_clicks": 1
              },
              "delivery_status": {},
              "ecommerce": {},
              "emails_sent": 1,
              "facebook_likes": {
                "facebook_likes": 1,
                "recipient_likes": 1,
                "unique_likes": 1
              },
              "forwards": {
                "forwards_count": 1,
                "forwards_opens": 1
              },
              "id": "id",
              "industry_stats": {
                "abuse_rate": 1.1,
                "bounce_rate": 1.1,
                "click_rate": 1.1,
                "open_rate": 1.1,
                "type": "type",
                "unopen_rate": 1.1,
                "unsub_rate": 1.1
              },
              "list_stats": {},
              "opens": {
                "last_open": "2024-01-15T09:30:00.000Z",
                "open_rate": 1.1,
                "opens_total": 1,
                "proxy_excluded_open_rate": 1.1,
                "proxy_excluded_opens": 1,
                "proxy_excluded_unique_opens": 1,
                "unique_opens": 1
              },
              "preview_text": "preview_text",
              "share_report": {},
              "timeseries": [
                {
                  "emails_sent": 1,
                  "proxy_excluded_unique_opens": 1,
                  "recipients_clicks": 1,
                  "timestamp": "2024-01-15T09:30:00.000Z",
                  "unique_opens": 1
                }
              ],
              "timewarp": [
                {
                  "bounces": 1,
                  "clicks": 1,
                  "gmt_offset": 1,
                  "last_click": "2024-01-15T09:30:00.000Z",
                  "last_open": "2024-01-15T09:30:00.000Z",
                  "opens": 1,
                  "unique_clicks": 1,
                  "unique_opens": 1
                }
              ],
              "type": "type"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/3.0/reports/campaign_id")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Reports.GetAsync(
            new GetReportsRequest { CampaignId = "campaign_id" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
