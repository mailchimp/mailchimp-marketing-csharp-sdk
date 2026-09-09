using Mailchimp.Marketing;
using Mailchimp.Marketing.Test.Unit.MockServer;
using NUnit.Framework;

namespace Mailchimp.Marketing.Test.Unit.MockServer.SmsCampaigns;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class CreateActionSendTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public void MockServerTest()
    {
        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/3.0/sms-campaigns/sms_campaign_id/actions/send")
                    .UsingPost()
            )
            .RespondWith(WireMock.ResponseBuilders.Response.Create().WithStatusCode(200));

        Assert.DoesNotThrowAsync(async () =>
            await Client.SmsCampaigns.CreateActionSendAsync(
                new CreateActionSendSmsCampaignsRequest { SmsCampaignId = "sms_campaign_id" }
            )
        );
    }
}
