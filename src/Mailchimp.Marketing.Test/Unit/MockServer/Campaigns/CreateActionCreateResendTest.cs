using Mailchimp.Marketing;
using Mailchimp.Marketing.Test.Unit.MockServer;
using Mailchimp.Marketing.Test.Utils;
using NUnit.Framework;

namespace Mailchimp.Marketing.Test.Unit.MockServer.Campaigns;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class CreateActionCreateResendTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string requestJson = """
            {}
            """;

        const string mockResponse = """
            {
              "delivery_status": {},
              "recipients": {
                "list_id": "list_id",
                "segment_opts": {
                  "conditions": [
                    {
                      "condition_type": "Aim",
                      "value": "any"
                    }
                  ],
                  "match": "any",
                  "prebuilt_segment_id": "subscribers-female",
                  "saved_segment_id": 1
                }
              },
              "report_summary": {
                "ecommerce": {}
              },
              "rss_opts": {
                "constrain_rss_img": true,
                "feed_url": "feed_url",
                "frequency": "daily",
                "schedule": {
                  "hour": 1,
                  "monthly_send_date": 1.1,
                  "weekly_send_day": "sunday"
                }
              },
              "settings": {
                "authenticate": true,
                "auto_fb_post": [
                  "auto_fb_post"
                ],
                "auto_footer": true,
                "auto_tweet": true,
                "fb_comments": true,
                "folder_id": "folder_id",
                "from_name": "from_name",
                "inline_css": true,
                "preview_text": "preview_text",
                "reply_to": "reply_to",
                "subject_line": "subject_line",
                "title": "title",
                "to_name": "to_name",
                "use_conversation": true
              },
              "social_card": {
                "description": "description",
                "image_url": "image_url",
                "title": "title"
              },
              "tracking": {
                "capsule": {
                  "notes": true
                },
                "clicktale": "clicktale",
                "ecomm360": true,
                "goal_tracking": true,
                "google_analytics": "google_analytics",
                "html_clicks": true,
                "opens": true,
                "salesforce": {
                  "campaign": true,
                  "notes": true
                },
                "text_clicks": true
              },
              "type": "regular",
              "variate_settings": {
                "from_names": [
                  "from_names"
                ],
                "reply_to_addresses": [
                  "reply_to_addresses"
                ],
                "send_times": [
                  "2024-01-15T09:30:00.000Z"
                ],
                "subject_lines": [
                  "subject_lines"
                ],
                "test_size": 1,
                "wait_time": 1,
                "winner_criteria": "opens"
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/3.0/campaigns/campaign_id/actions/create-resend")
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

        var response = await Client.Campaigns.CreateActionCreateResendAsync(
            new CreateActionCreateResendCampaignsRequest { CampaignId = "campaign_id" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
