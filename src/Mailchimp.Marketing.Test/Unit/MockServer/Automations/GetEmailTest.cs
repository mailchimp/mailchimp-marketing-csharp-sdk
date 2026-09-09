using Mailchimp.Marketing;
using Mailchimp.Marketing.Test.Unit.MockServer;
using Mailchimp.Marketing.Test.Utils;
using NUnit.Framework;

namespace Mailchimp.Marketing.Test.Unit.MockServer.Automations;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class GetEmailTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "delay": {
                "action": "previous_campaign_sent",
                "direction": "before",
                "type": "now"
              },
              "recipients": {
                "list_id": "list_id",
                "segment_opts": {
                  "conditions": [
                    {
                      "condition_type": "Aim",
                      "value": "any"
                    }
                  ],
                  "match": "any",
                  "prebuilt_segment_id": "subscribers-female",
                  "saved_segment_id": 1
                }
              },
              "report_summary": {},
              "settings": {
                "authenticate": true,
                "auto_fb_post": [
                  "auto_fb_post"
                ],
                "auto_footer": true,
                "auto_tweet": true,
                "fb_comments": true,
                "from_name": "from_name",
                "inline_css": true,
                "preview_text": "preview_text",
                "reply_to": "reply_to",
                "subject_line": "subject_line",
                "template_id": 1,
                "title": "title"
              },
              "social_card": {
                "description": "description",
                "image_url": "image_url",
                "title": "title"
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
                    .WithPath("/3.0/automations/workflow_id/emails/workflow_email_id")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Automations.GetEmailAsync(
            new GetEmailAutomationsRequest
            {
                WorkflowId = "workflow_id",
                WorkflowEmailId = "workflow_email_id",
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
