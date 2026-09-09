using Mailchimp.Marketing;
using Mailchimp.Marketing.Test.Unit.MockServer;
using NUnit.Framework;

namespace Mailchimp.Marketing.Test.Unit.MockServer.Automations;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class CreateActionPauseAllEmailTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public void MockServerTest()
    {
        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/3.0/automations/workflow_id/actions/pause-all-emails")
                    .UsingPost()
            )
            .RespondWith(WireMock.ResponseBuilders.Response.Create().WithStatusCode(200));

        Assert.DoesNotThrowAsync(async () =>
            await Client.Automations.CreateActionPauseAllEmailAsync(
                new CreateActionPauseAllEmailAutomationsRequest { WorkflowId = "workflow_id" }
            )
        );
    }
}
