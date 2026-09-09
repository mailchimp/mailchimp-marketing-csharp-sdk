using Mailchimp.Marketing;
using Mailchimp.Marketing.Test.Unit.MockServer;
using Mailchimp.Marketing.Test.Utils;
using NUnit.Framework;

namespace Mailchimp.Marketing.Test.Unit.MockServer.Lists;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class GetInterestCategoryInterestTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "display_order": 1,
              "name": "name"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath(
                        "/3.0/lists/list_id/interest-categories/interest_category_id/interests/interest_id"
                    )
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Lists.GetInterestCategoryInterestAsync(
            new GetInterestCategoryInterestListsRequest
            {
                ListId = "list_id",
                InterestCategoryId = "interest_category_id",
                InterestId = "interest_id",
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
