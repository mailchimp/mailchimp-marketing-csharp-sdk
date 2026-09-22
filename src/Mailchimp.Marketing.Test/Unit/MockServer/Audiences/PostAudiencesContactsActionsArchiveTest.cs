using Mailchimp.Marketing;
using Mailchimp.Marketing.Test.Unit.MockServer;
using NUnit.Framework;

namespace Mailchimp.Marketing.Test.Unit.MockServer.Audiences;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostAudiencesContactsActionsArchiveTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public void MockServerTest()
    {
        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/3.0/audiences/audience_id/contacts/contact_id/actions/archive")
                    .UsingPost()
            )
            .RespondWith(WireMock.ResponseBuilders.Response.Create().WithStatusCode(200));

        Assert.DoesNotThrowAsync(async () =>
            await Client.Audiences.PostAudiencesContactsActionsArchiveAsync(
                new PostAudiencesContactsActionsArchiveRequest
                {
                    AudienceId = "audience_id",
                    ContactId = "contact_id",
                }
            )
        );
    }
}
