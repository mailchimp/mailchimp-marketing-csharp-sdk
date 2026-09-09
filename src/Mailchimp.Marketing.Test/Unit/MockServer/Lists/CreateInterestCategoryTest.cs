using Mailchimp.Marketing;
using Mailchimp.Marketing.Test.Unit.MockServer;
using Mailchimp.Marketing.Test.Utils;
using NUnit.Framework;

namespace Mailchimp.Marketing.Test.Unit.MockServer.Lists;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class CreateInterestCategoryTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string requestJson = """
            {
              "title": "title",
              "type": "checkboxes"
            }
            """;

        const string mockResponse = """
            {
              "display_order": 1,
              "title": "title",
              "type": "checkboxes"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/3.0/lists/list_id/interest-categories")
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

        var response = await Client.Lists.CreateInterestCategoryAsync(
            new CreateInterestCategoryListsRequest
            {
                ListId = "list_id",
                Title = "title",
                Type = CreateInterestCategoryListsRequestType.Checkboxes,
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
