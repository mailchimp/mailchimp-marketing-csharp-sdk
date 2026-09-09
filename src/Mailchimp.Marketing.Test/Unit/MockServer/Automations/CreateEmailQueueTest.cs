using Mailchimp.Marketing;
using Mailchimp.Marketing.Test.Unit.MockServer;
using Mailchimp.Marketing.Test.Utils;
using NUnit.Framework;

namespace Mailchimp.Marketing.Test.Unit.MockServer.Automations;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class CreateEmailQueueTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string requestJson = """
            {
              "email_address": "email_address"
            }
            """;

        const string mockResponse = """
            {
              "email_address": "email_address"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/3.0/automations/workflow_id/emails/workflow_email_id/queue")
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

        var response = await Client.Automations.CreateEmailQueueAsync(
            new CreateEmailQueueAutomationsRequest
            {
                WorkflowId = "workflow_id",
                WorkflowEmailId = "workflow_email_id",
                EmailAddress = "email_address",
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
