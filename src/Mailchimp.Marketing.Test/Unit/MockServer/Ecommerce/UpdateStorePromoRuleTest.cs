using Mailchimp.Marketing;
using Mailchimp.Marketing.Test.Unit.MockServer;
using Mailchimp.Marketing.Test.Utils;
using NUnit.Framework;

namespace Mailchimp.Marketing.Test.Unit.MockServer.Ecommerce;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class UpdateStorePromoRuleTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string requestJson = """
            {}
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
                    .WithPath("/3.0/ecommerce/stores/store_id/promo-rules/promo_rule_id")
                    .WithHeader("Content-Type", "application/json")
                    .UsingPatch()
                    .WithBodyAsJson(requestJson)
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Ecommerce.UpdateStorePromoRuleAsync(
            new UpdateStorePromoRuleEcommerceRequest
            {
                StoreId = "store_id",
                PromoRuleId = "promo_rule_id",
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
