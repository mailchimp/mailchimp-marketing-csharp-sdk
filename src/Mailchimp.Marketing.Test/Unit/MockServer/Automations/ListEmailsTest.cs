using Mailchimp.Marketing;
using Mailchimp.Marketing.Test.Unit.MockServer;
using Mailchimp.Marketing.Test.Utils;
using NUnit.Framework;

namespace Mailchimp.Marketing.Test.Unit.MockServer.Automations;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class ListEmailsTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "emails": [
                {
                  "delay": {},
                  "recipients": {
                    "segment_opts": {
                      "conditions": [
                        {
                          "condition_type": "Aim",
                          "value": "any"
                        }
                      ],
                      "prebuilt_segment_id": "subscribers-female"
                    }
                  },
                  "trigger_settings": {
                    "workflow_type": "abandonedBrowse"
                  }
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/3.0/automations/workflow_id/emails")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Automations.ListEmailsAsync(
            new ListEmailsAutomationsRequest { WorkflowId = "workflow_id" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
