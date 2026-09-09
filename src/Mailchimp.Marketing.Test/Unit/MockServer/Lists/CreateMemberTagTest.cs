using Mailchimp.Marketing;
using Mailchimp.Marketing.Test.Unit.MockServer;
using NUnit.Framework;

namespace Mailchimp.Marketing.Test.Unit.MockServer.Lists;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class CreateMemberTagTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public void MockServerTest()
    {
        const string requestJson = """
            {
              "tags": [
                {
                  "name": "name",
                  "status": "inactive"
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/3.0/lists/list_id/members/subscriber_hash/tags")
                    .WithHeader("Content-Type", "application/json")
                    .UsingPost()
                    .WithBodyAsJson(requestJson)
            )
            .RespondWith(WireMock.ResponseBuilders.Response.Create().WithStatusCode(200));

        Assert.DoesNotThrowAsync(async () =>
            await Client.Lists.CreateMemberTagAsync(
                new CreateMemberTagListsRequest
                {
                    ListId = "list_id",
                    SubscriberHash = "subscriber_hash",
                    Tags =
                        new global::System.Collections.Generic.List<CreateMemberTagListsRequestTagsItem>()
                        {
                            new CreateMemberTagListsRequestTagsItem
                            {
                                Name = "name",
                                Status = CreateMemberTagListsRequestTagsItemStatus.Inactive,
                            },
                        },
                }
            )
        );
    }
}
