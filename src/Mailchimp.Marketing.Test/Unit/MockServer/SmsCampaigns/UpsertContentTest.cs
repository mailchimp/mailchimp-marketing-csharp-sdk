using Mailchimp.Marketing;
using Mailchimp.Marketing.Test.Unit.MockServer;
using Mailchimp.Marketing.Test.Utils;
using NUnit.Framework;

namespace Mailchimp.Marketing.Test.Unit.MockServer.SmsCampaigns;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class UpsertContentTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string requestJson = """
            {
              "message_body": "message_body"
            }
            """;

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
                    .WithHeader("Content-Type", "application/json")
                    .UsingPut()
                    .WithBodyAsJson(requestJson)
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.SmsCampaigns.UpsertContentAsync(
            new UpsertContentSmsCampaignsRequest
            {
                SmsCampaignId = "sms_campaign_id",
                MessageBody = "message_body",
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
