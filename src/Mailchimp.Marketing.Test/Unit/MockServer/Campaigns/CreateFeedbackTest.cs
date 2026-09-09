using Mailchimp.Marketing;
using Mailchimp.Marketing.Test.Unit.MockServer;
using Mailchimp.Marketing.Test.Utils;
using NUnit.Framework;

namespace Mailchimp.Marketing.Test.Unit.MockServer.Campaigns;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class CreateFeedbackTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string requestJson = """
            {
              "message": "message"
            }
            """;

        const string mockResponse = """
            {
              "block_id": 1,
              "is_complete": true,
              "message": "message"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/3.0/campaigns/campaign_id/feedback")
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

        var response = await Client.Campaigns.CreateFeedbackAsync(
            new CreateFeedbackCampaignsRequest { CampaignId = "campaign_id", Message = "message" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
