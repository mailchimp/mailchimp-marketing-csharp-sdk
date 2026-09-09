using Mailchimp.Marketing;
using Mailchimp.Marketing.Test.Unit.MockServer;
using Mailchimp.Marketing.Test.Utils;
using NUnit.Framework;

namespace Mailchimp.Marketing.Test.Unit.MockServer.Lists;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class BatchAddOrRemoveMembersTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string requestJson = """
            {}
            """;

        const string mockResponse = """
            {
              "error_count": 42,
              "errors": [
                {
                  "email_addresses": [
                    "email_addresses"
                  ],
                  "error": "error"
                }
              ],
              "members_added": [
                {
                  "email_address": "email_address",
                  "email_type": "email_type",
                  "interests": {
                    "key": true
                  },
                  "language": "language",
                  "merge_fields": {
                    "key": "value"
                  },
                  "status": "subscribed",
                  "tags": [
                    {}
                  ],
                  "vip": true
                }
              ],
              "members_removed": [
                {
                  "email_address": "email_address",
                  "email_type": "email_type",
                  "interests": {
                    "key": true
                  },
                  "language": "language",
                  "merge_fields": {
                    "key": "value"
                  },
                  "status": "subscribed",
                  "tags": [
                    {}
                  ],
                  "vip": true
                }
              ],
              "total_added": 42,
              "total_removed": 42
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/3.0/lists/list_id/segments/segment_id")
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

        var response = await Client.Lists.BatchAddOrRemoveMembersAsync(
            new BatchAddOrRemoveMembersListsRequest { ListId = "list_id", SegmentId = "segment_id" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
