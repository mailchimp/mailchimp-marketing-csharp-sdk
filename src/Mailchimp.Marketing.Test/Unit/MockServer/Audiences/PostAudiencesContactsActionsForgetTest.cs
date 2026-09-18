using Mailchimp.Marketing;
using Mailchimp.Marketing.Test.Unit.MockServer;
using NUnit.Framework;

namespace Mailchimp.Marketing.Test.Unit.MockServer.Audiences;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostAudiencesContactsActionsForgetTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public void MockServerTest()
    {
        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/3.0/audiences/audience_id/contacts/contact_id/actions/forget")
                    .UsingPost()
            )
            .RespondWith(WireMock.ResponseBuilders.Response.Create().WithStatusCode(200));

        Assert.DoesNotThrowAsync(async () =>
            await Client.Audiences.PostAudiencesContactsActionsForgetAsync(
                new PostAudiencesContactsActionsForgetRequest
                {
                    AudienceId = "audience_id",
                    ContactId = "contact_id",
                }
            )
        );
    }
}
