using Mailchimp.Marketing;
using Mailchimp.Marketing.Test.Unit.MockServer;
using NUnit.Framework;

namespace Mailchimp.Marketing.Test.Unit.MockServer.FacebookAds;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class ListTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "facebook_ads": [
                {
                  "canceled_at": "2024-01-15T09:30:00.000Z",
                  "create_time": "2024-01-15T09:30:00.000Z",
                  "has_segment": true,
                  "id": "id",
                  "name": "name",
                  "published_time": "2024-01-15T09:30:00.000Z",
                  "recipients": {
                    "segment_opts": {
                      "conditions": [
                        {
                          "condition_type": "Aim",
                          "value": "any"
                        }
                      ],
                      "prebuilt_segment_id": "subscribers-female"
                    }
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
                  "has_audience": true,
                  "has_content": true,
                  "is_connected": true,
                  "site": {
                    "id": 43,
                    "name": "My Connected Site",
                    "url": "www.example.com"
                  }
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock.RequestBuilders.Request.Create().WithPath("/3.0/facebook-ads").UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var items = await Client.FacebookAds.ListAsync(new ListFacebookAdsRequest());
        await foreach (var item in items)
        {
            Assert.That(item, Is.Not.Null);
            break; // Only check the first item
        }
    }
}
