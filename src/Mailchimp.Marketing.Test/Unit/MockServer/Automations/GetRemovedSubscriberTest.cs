using Mailchimp.Marketing;
using Mailchimp.Marketing.Test.Unit.MockServer;
using Mailchimp.Marketing.Test.Utils;
using NUnit.Framework;

namespace Mailchimp.Marketing.Test.Unit.MockServer.Automations;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class GetRemovedSubscriberTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "email_address": "email_address"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/3.0/automations/workflow_id/removed-subscribers/subscriber_hash")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Automations.GetRemovedSubscriberAsync(
            new GetRemovedSubscriberAutomationsRequest
            {
                WorkflowId = "workflow_id",
                SubscriberHash = "subscriber_hash",
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
