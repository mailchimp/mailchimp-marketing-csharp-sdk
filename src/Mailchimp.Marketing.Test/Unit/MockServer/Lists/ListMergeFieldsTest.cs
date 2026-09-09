using Mailchimp.Marketing;
using Mailchimp.Marketing.Test.Unit.MockServer;
using NUnit.Framework;

namespace Mailchimp.Marketing.Test.Unit.MockServer.Lists;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class ListMergeFieldsTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "merge_fields": [
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
                    ]
                  },
                  "public": true,
                  "required": true,
                  "tag": "tag"
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/3.0/lists/list_id/merge-fields")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var items = await Client.Lists.ListMergeFieldsAsync(
            new ListMergeFieldsListsRequest { ListId = "list_id" }
        );
        await foreach (var item in items)
        {
            Assert.That(item, Is.Not.Null);
            break; // Only check the first item
        }
    }
}
