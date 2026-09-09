using Mailchimp.Marketing;
using Mailchimp.Marketing.Test.Unit.MockServer;
using NUnit.Framework;

namespace Mailchimp.Marketing.Test.Unit.MockServer.Automations;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class CreateEmailActionStartTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public void MockServerTest()
    {
        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/3.0/automations/workflow_id/emails/workflow_email_id/actions/start")
                    .UsingPost()
            )
            .RespondWith(WireMock.ResponseBuilders.Response.Create().WithStatusCode(200));

        Assert.DoesNotThrowAsync(async () =>
            await Client.Automations.CreateEmailActionStartAsync(
                new CreateEmailActionStartAutomationsRequest
                {
                    WorkflowId = "workflow_id",
                    WorkflowEmailId = "workflow_email_id",
                }
            )
        );
    }
}
