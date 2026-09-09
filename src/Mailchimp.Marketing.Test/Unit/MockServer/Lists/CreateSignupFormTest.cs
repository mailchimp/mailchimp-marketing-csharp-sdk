using Mailchimp.Marketing;
using Mailchimp.Marketing.Test.Unit.MockServer;
using Mailchimp.Marketing.Test.Utils;
using NUnit.Framework;

namespace Mailchimp.Marketing.Test.Unit.MockServer.Lists;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class CreateSignupFormTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string requestJson = """
            {}
            """;

        const string mockResponse = """
            {
              "contents": [
                {
                  "section": "signup_message",
                  "value": "Signup message goes here"
                }
              ],
              "header": {
                "image_align": "none",
                "image_alt": "This is an image",
                "image_border_color": "#896d6d",
                "image_border_style": "none",
                "image_border_width": "2",
                "image_height": "200",
                "image_link": "gotothisimage.com",
                "image_target": "_blank",
                "image_url": "http://gallery.mailchimp.com/332310cb9a420a9e7fea2858a/images/2491208c-9458-4834-a708-fef4ee736472.png",
                "image_width": "800",
                "text": "Header Text goes here"
              },
              "signup_form_url": "signup_form_url",
              "styles": [
                {
                  "options": [
                    {
                      "property": "background-color",
                      "value": "#111111"
                    }
                  ],
                  "selector": "page_background"
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/3.0/lists/list_id/signup-forms")
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

        var response = await Client.Lists.CreateSignupFormAsync(
            new CreateSignupFormListsRequest { ListId = "list_id" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
