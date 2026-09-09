using Mailchimp.Marketing;
using Mailchimp.Marketing.Test.Unit.MockServer;
using Mailchimp.Marketing.Test.Utils;
using NUnit.Framework;

namespace Mailchimp.Marketing.Test.Unit.MockServer.Lists;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class ListMemberGoalsTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "goals": [
                {
                  "data": "data",
                  "event": "event",
                  "goal_id": 1,
                  "last_visited_at": "2024-01-15T09:30:00.000Z"
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/3.0/lists/list_id/members/subscriber_hash/goals")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Lists.ListMemberGoalsAsync(
            new ListMemberGoalsListsRequest
            {
                ListId = "list_id",
                SubscriberHash = "subscriber_hash",
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
