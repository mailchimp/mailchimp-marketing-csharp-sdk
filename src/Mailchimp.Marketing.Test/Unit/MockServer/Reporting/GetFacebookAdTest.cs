using Mailchimp.Marketing;
using Mailchimp.Marketing.Test.Unit.MockServer;
using Mailchimp.Marketing.Test.Utils;
using NUnit.Framework;

namespace Mailchimp.Marketing.Test.Unit.MockServer.Reporting;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class GetFacebookAdTest : BaseMockServerTest
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
                "average_daily_budget": {
                  "amount": 1.1,
                  "currency_code": "currency_code"
                },
                "average_order_amount": {
                  "amount": 1.1,
                  "currency_code": "currency_code"
                },
                "click_rate": 1.1,
                "clicks": 1,
                "comments": 1,
                "cost_per_click": {
                  "amount": 1.1,
                  "currency_code": "currency_code"
                },
                "ecommerce": {
                  "currency_code": "currency_code",
                  "total_revenue": 1.1
                },
                "extended_at": {
                  "datetime": "datetime",
                  "timezone": "timezone"
                },
                "first_time_buyers": 1,
                "has_extended_ad_duration": true,
                "impressions": 1,
                "likes": 1,
                "reach": 1,
                "return_on_investment": 1.1,
                "shares": 1,
                "total_orders": 1,
                "total_products_sold": 1,
                "unique_clicks": 1
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
              "audience_activity": {
                "clicks": [
                  {}
                ],
                "impressions": [
                  {}
                ],
                "revenue": [
                  {}
                ]
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
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/3.0/reporting/facebook-ads/outreach_id")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Reporting.GetFacebookAdAsync(
            new GetFacebookAdReportingRequest { OutreachId = "outreach_id" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
