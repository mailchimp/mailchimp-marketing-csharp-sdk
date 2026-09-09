using Mailchimp.Marketing;
using Mailchimp.Marketing.Test.Unit.MockServer;
using NUnit.Framework;

namespace Mailchimp.Marketing.Test.Unit.MockServer.ConnectedSites;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class CreateActionVerifyScriptInstallationTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public void MockServerTest()
    {
        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath(
                        "/3.0/connected-sites/connected_site_id/actions/verify-script-installation"
                    )
                    .UsingPost()
            )
            .RespondWith(WireMock.ResponseBuilders.Response.Create().WithStatusCode(200));

        Assert.DoesNotThrowAsync(async () =>
            await Client.ConnectedSites.CreateActionVerifyScriptInstallationAsync(
                new CreateActionVerifyScriptInstallationConnectedSitesRequest
                {
                    ConnectedSiteId = "connected_site_id",
                }
            )
        );
    }
}
