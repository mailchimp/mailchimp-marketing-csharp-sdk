using Mailchimp.Marketing;
using Mailchimp.Marketing.Test.Unit.MockServer;
using Mailchimp.Marketing.Test.Utils;
using NUnit.Framework;

namespace Mailchimp.Marketing.Test.Unit.MockServer.FacebookAds;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class GetTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "canceled_at": "2024-01-15T09:30:00.000Z",
              "create_time": "2024-01-15T09:30:00.000Z",
              "has_segment": true,
              "id": "id",
              "name": "name",
              "published_time": "2024-01-15T09:30:00.000Z",
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
                "click_rate": 1.1,
                "clicks": 1,
                "conversion_rate": 1.1,
                "ecommerce": {
                  "average_order_revenue": 1.1,
                  "currency_code": "currency_code",
                  "total_revenue": 1.1
                },
                "engagements": 1,
                "impressions": 1.1,
                "open_rate": 1.1,
                "opens": 1,
                "proxy_excluded_open_rate": 1.1,
                "proxy_excluded_opens": 1,
                "proxy_excluded_unique_opens": 1,
                "reach": 1,
                "subscriber_clicks": 1,
                "subscribes": 1,
                "total_sent": 1,
                "unique_opens": 1,
                "unique_visits": 1,
                "visits": 1
              },
              "show_report": true,
              "start_time": "2024-01-15T09:30:00.000Z",
              "status": "save",
              "type": "regular",
              "updated_at": "2024-01-15T09:30:00.000Z",
              "web_id": 1,
              "email_source_name": "email_source_name",
              "end_time": "2024-01-15T09:30:00.000Z",
              "needs_attention": true,
              "paused_at": "2024-01-15T09:30:00.000Z",
              "thumbnail": "thumbnail",
              "was_canceled_by_facebook": true,
              "audience": {
                "email_source": {
                  "is_segment": true,
                  "list_name": "list_name",
                  "name": "name",
                  "segment_type": "segment_type",
                  "type": "type"
                },
                "include_source_in_target": true,
                "lookalike_country_code": "lookalike_country_code",
                "source_type": "facebook",
                "targeting_specs": {
                  "gender": 1,
                  "interests": [
                    {}
                  ],
                  "max_age": 1,
                  "min_age": 1
                },
                "type": "Custom Audience"
              },
              "budget": {
                "currency_code": "USD",
                "duration": 86400,
                "total_amount": 500
              },
              "channel": {
                "fb_placement_audience": false,
                "fb_placement_feed": true,
                "ig_placement_feed": false
              },
              "content": {
                "attachments": [
                  {}
                ],
                "call_to_action": "call_to_action",
                "description": "description",
                "image_url": "image_url",
                "link_url": "link_url",
                "message": "message",
                "title": "title"
              },
              "feedback": {
                "audience": "audience",
                "budget": "budget",
                "compliance": "compliance",
                "content": "content"
              },
              "has_audience": true,
              "has_content": true,
              "is_connected": true,
              "site": {
                "id": 43,
                "name": "My Connected Site",
                "url": "www.example.com"
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/3.0/facebook-ads/outreach_id")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.FacebookAds.GetAsync(
            new GetFacebookAdsRequest { OutreachId = "outreach_id" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
