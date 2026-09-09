using Mailchimp.Marketing;
using Mailchimp.Marketing.Test.Unit.MockServer;
using NUnit.Framework;

namespace Mailchimp.Marketing.Test.Unit.MockServer.Lists;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class ListSegmentMembersTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "members": [
                {
                  "email_type": "email_type",
                  "interests": {
                    "key": true
                  },
                  "language": "language",
                  "merge_fields": {
                    "key": {
                      "addr1": "addr1",
                      "city": "city",
                      "state": "state",
                      "zip": "zip"
                    }
                  },
                  "status": "subscribed",
                  "vip": true
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/3.0/lists/list_id/segments/segment_id/members")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var items = await Client.Lists.ListSegmentMembersAsync(
            new ListSegmentMembersListsRequest { ListId = "list_id", SegmentId = "segment_id" }
        );
        await foreach (var item in items)
        {
            Assert.That(item, Is.Not.Null);
            break; // Only check the first item
        }
    }
}
