using Mailchimp.Marketing;
using Mailchimp.Marketing.Test.Unit.MockServer;
using Mailchimp.Marketing.Test.Utils;
using NUnit.Framework;

namespace Mailchimp.Marketing.Test.Unit.MockServer.Lists;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class GetSegmentTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "name": "name",
              "options": {
                "conditions": [
                  {
                    "condition_type": "Aim",
                    "value": "any"
                  }
                ],
                "match": "any"
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/3.0/lists/list_id/segments/segment_id")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Lists.GetSegmentAsync(
            new GetSegmentListsRequest { ListId = "list_id", SegmentId = "segment_id" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
