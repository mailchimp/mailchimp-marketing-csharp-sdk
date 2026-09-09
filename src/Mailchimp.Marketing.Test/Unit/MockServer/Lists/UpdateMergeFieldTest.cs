using Mailchimp.Marketing;
using Mailchimp.Marketing.Test.Unit.MockServer;
using Mailchimp.Marketing.Test.Utils;
using NUnit.Framework;

namespace Mailchimp.Marketing.Test.Unit.MockServer.Lists;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class UpdateMergeFieldTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string requestJson = """
            {}
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
                    .WithPath("/3.0/lists/list_id/merge-fields/merge_id")
                    .WithHeader("Content-Type", "application/json")
                    .UsingPatch()
                    .WithBodyAsJson(requestJson)
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Lists.UpdateMergeFieldAsync(
            new UpdateMergeFieldListsRequest { ListId = "list_id", MergeId = "merge_id" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
