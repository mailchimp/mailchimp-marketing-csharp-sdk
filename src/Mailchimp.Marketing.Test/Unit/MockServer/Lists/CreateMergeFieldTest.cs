using Mailchimp.Marketing;
using Mailchimp.Marketing.Test.Unit.MockServer;
using Mailchimp.Marketing.Test.Utils;
using NUnit.Framework;

namespace Mailchimp.Marketing.Test.Unit.MockServer.Lists;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class CreateMergeFieldTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string requestJson = """
            {
              "name": "name",
              "type": "text"
            }
            """;

        const string mockResponse = """
            {
              "default_value": "default_value",
              "display_order": 1,
              "help_text": "help_text",
              "name": "name",
              "options": {
                "choices": [
                  "First Choice",
                  "Second Choice",
                  "Third Choice"
                ],
                "date_format": "date_format",
                "default_country": 1,
                "phone_format": "phone_format"
              },
              "public": true,
              "required": true,
              "tag": "tag"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/3.0/lists/list_id/merge-fields")
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

        var response = await Client.Lists.CreateMergeFieldAsync(
            new CreateMergeFieldListsRequest
            {
                ListId = "list_id",
                Name = "name",
                Type = CreateMergeFieldListsRequestType.Text,
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
