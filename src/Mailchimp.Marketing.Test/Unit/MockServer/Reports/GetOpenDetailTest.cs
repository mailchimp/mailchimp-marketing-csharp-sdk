using Mailchimp.Marketing;
using Mailchimp.Marketing.Test.Unit.MockServer;
using Mailchimp.Marketing.Test.Utils;
using NUnit.Framework;

namespace Mailchimp.Marketing.Test.Unit.MockServer.Reports;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class GetOpenDetailTest : BaseMockServerTest
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
              },
              "opens": [
                {
                  "timestamp": "2024-01-15T09:30:00.000Z"
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/3.0/reports/campaign_id/open-details/subscriber_hash")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Reports.GetOpenDetailAsync(
            new GetOpenDetailReportsRequest
            {
                CampaignId = "campaign_id",
                SubscriberHash = "subscriber_hash",
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
