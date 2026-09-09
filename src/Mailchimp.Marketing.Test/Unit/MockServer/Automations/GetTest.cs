using Mailchimp.Marketing;
using Mailchimp.Marketing.Test.Unit.MockServer;
using Mailchimp.Marketing.Test.Utils;
using NUnit.Framework;

namespace Mailchimp.Marketing.Test.Unit.MockServer.Automations;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class GetTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "recipients": {
                "list_id": "list_id",
                "list_name": "list_name",
                "segment_opts": [
                  {
                    "condition_type": "Aim",
                    "value": "any"
                  }
                ],
                "store_id": "1a2df69xxx"
              },
              "report_summary": {},
              "settings": {
                "authenticate": true,
                "auto_footer": true,
                "from_name": "from_name",
                "inline_css": true,
                "reply_to": "reply_to",
                "title": "title",
                "to_name": "to_name",
                "use_conversation": true
              },
              "tracking": {
                "capsule": {
                  "notes": true
                },
                "clicktale": "clicktale",
                "ecomm360": true,
                "goal_tracking": true,
                "google_analytics": "google_analytics",
                "html_clicks": true,
                "opens": true,
                "salesforce": {
                  "campaign": true,
                  "notes": true
                },
                "text_clicks": true
              },
              "trigger_settings": {
                "runtime": {
                  "days": [
                    "sunday"
                  ],
                  "hours": {
                    "type": "send_asap"
                  }
                },
                "workflow_type": "abandonedBrowse"
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/3.0/automations/workflow_id")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Automations.GetAsync(
            new GetAutomationsRequest { WorkflowId = "workflow_id" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
