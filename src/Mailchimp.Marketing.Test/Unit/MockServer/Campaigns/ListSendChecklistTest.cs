using Mailchimp.Marketing;
using Mailchimp.Marketing.Test.Unit.MockServer;
using Mailchimp.Marketing.Test.Utils;
using NUnit.Framework;

namespace Mailchimp.Marketing.Test.Unit.MockServer.Campaigns;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class ListSendChecklistTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "is_ready": true,
              "items": [
                {
                  "details": "details",
                  "heading": "heading",
                  "id": 1,
                  "type": "success"
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/3.0/campaigns/campaign_id/send-checklist")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Campaigns.ListSendChecklistAsync(
            new ListSendChecklistCampaignsRequest { CampaignId = "campaign_id" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
