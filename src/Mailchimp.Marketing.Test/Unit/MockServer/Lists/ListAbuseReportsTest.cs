using Mailchimp.Marketing;
using Mailchimp.Marketing.Test.Unit.MockServer;
using NUnit.Framework;

namespace Mailchimp.Marketing.Test.Unit.MockServer.Lists;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class ListAbuseReportsTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "abuse_reports": [
                {
                  "merge_fields": {
                    "key": {
                      "addr1": "addr1",
                      "city": "city",
                      "state": "state",
                      "zip": "zip"
                    }
                  }
                }
              ],
              "list_id": "list_id"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/3.0/lists/list_id/abuse-reports")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var items = await Client.Lists.ListAbuseReportsAsync(
            new ListAbuseReportsListsRequest { ListId = "list_id" }
        );
        await foreach (var item in items)
        {
            Assert.That(item, Is.Not.Null);
            break; // Only check the first item
        }
    }
}
