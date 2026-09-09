using Mailchimp.Marketing;
using Mailchimp.Marketing.Test.Unit.MockServer;
using Mailchimp.Marketing.Test.Utils;
using NUnit.Framework;

namespace Mailchimp.Marketing.Test.Unit.MockServer.Lists;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class CreateSegmentMemberTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string requestJson = """
            {
              "email_address": "email_address"
            }
            """;

        const string mockResponse = """
            {
              "email_type": "email_type",
              "interests": {
                "key": true
              },
              "language": "language",
              "location": {
                "latitude": 1.1,
                "longitude": 1.1
              },
              "merge_fields": {
                "key": {
                  "addr1": "addr1",
                  "addr2": "addr2",
                  "city": "city",
                  "state": "state",
                  "zip": "zip",
                  "country": "country"
                }
              },
              "status": "subscribed",
              "vip": true
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/3.0/lists/list_id/segments/segment_id/members")
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

        var response = await Client.Lists.CreateSegmentMemberAsync(
            new CreateSegmentMemberListsRequest
            {
                ListId = "list_id",
                SegmentId = "segment_id",
                EmailAddress = "email_address",
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
