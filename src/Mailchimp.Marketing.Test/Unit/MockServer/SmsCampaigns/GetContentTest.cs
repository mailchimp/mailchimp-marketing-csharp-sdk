using Mailchimp.Marketing;
using Mailchimp.Marketing.Test.Unit.MockServer;
using Mailchimp.Marketing.Test.Utils;
using NUnit.Framework;

namespace Mailchimp.Marketing.Test.Unit.MockServer.SmsCampaigns;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class GetContentTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "message_body": "message_body",
              "media": [
                {
                  "url": "url"
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/3.0/sms-campaigns/sms_campaign_id/content")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.SmsCampaigns.GetContentAsync(
            new GetContentSmsCampaignsRequest { SmsCampaignId = "sms_campaign_id" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
