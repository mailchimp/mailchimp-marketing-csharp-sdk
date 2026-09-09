using Mailchimp.Marketing;
using Mailchimp.Marketing.Test.Unit.MockServer;
using NUnit.Framework;

namespace Mailchimp.Marketing.Test.Unit.MockServer.LandingPages;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class CreateActionUnpublishTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public void MockServerTest()
    {
        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/3.0/landing-pages/page_id/actions/unpublish")
                    .UsingPost()
            )
            .RespondWith(WireMock.ResponseBuilders.Response.Create().WithStatusCode(200));

        Assert.DoesNotThrowAsync(async () =>
            await Client.LandingPages.CreateActionUnpublishAsync(
                new CreateActionUnpublishLandingPagesRequest { PageId = "page_id" }
            )
        );
    }
}
