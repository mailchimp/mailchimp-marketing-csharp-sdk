using Mailchimp.Marketing;
using Mailchimp.Marketing.Test.Unit.MockServer;
using NUnit.Framework;

namespace Mailchimp.Marketing.Test.Unit.MockServer.Campaigns;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class CreateActionTestTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public void MockServerTest()
    {
        const string requestJson = """
            {
              "send_type": "html",
              "test_emails": [
                "test_emails"
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/3.0/campaigns/campaign_id/actions/test")
                    .WithHeader("Content-Type", "application/json")
                    .UsingPost()
                    .WithBodyAsJson(requestJson)
            )
            .RespondWith(WireMock.ResponseBuilders.Response.Create().WithStatusCode(200));

        Assert.DoesNotThrowAsync(async () =>
            await Client.Campaigns.CreateActionTestAsync(
                new CreateActionTestCampaignsRequest
                {
                    CampaignId = "campaign_id",
                    SendType = CreateActionTestCampaignsRequestSendType.Html,
                    TestEmails = new global::System.Collections.Generic.List<string>()
                    {
                        "test_emails",
                    },
                }
            )
        );
    }
}
