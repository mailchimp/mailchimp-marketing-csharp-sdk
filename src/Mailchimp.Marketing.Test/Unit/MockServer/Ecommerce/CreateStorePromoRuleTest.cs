using Mailchimp.Marketing;
using Mailchimp.Marketing.Test.Unit.MockServer;
using Mailchimp.Marketing.Test.Utils;
using NUnit.Framework;

namespace Mailchimp.Marketing.Test.Unit.MockServer.Ecommerce;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class CreateStorePromoRuleTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string requestJson = """
            {
              "amount": 1.1,
              "description": "Save BIG during our summer sale!",
              "id": "id",
              "target": "per_item",
              "type": "fixed"
            }
            """;

        const string mockResponse = """
            {
              "amount": 0.5,
              "created_at_foreign": "2024-01-15T09:30:00.000Z",
              "description": "Save BIG during our summer sale!",
              "enabled": true,
              "ends_at": "ends_at",
              "starts_at": "2024-01-15T09:30:00.000Z",
              "target": "per_item",
              "title": "50% off Total Order",
              "type": "fixed",
              "updated_at_foreign": "2024-01-15T09:30:00.000Z"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/3.0/ecommerce/stores/store_id/promo-rules")
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

        var response = await Client.Ecommerce.CreateStorePromoRuleAsync(
            new CreateStorePromoRuleEcommerceRequest
            {
                StoreId = "store_id",
                Amount = 1.1,
                Description = "Save BIG during our summer sale!",
                Id = "id",
                Target = CreateStorePromoRuleEcommerceRequestTarget.PerItem,
                Type = CreateStorePromoRuleEcommerceRequestType.Fixed,
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
