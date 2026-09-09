using Mailchimp.Marketing;
using Mailchimp.Marketing.Test.Unit.MockServer;
using NUnit.Framework;

namespace Mailchimp.Marketing.Test.Unit.MockServer.Ecommerce;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class ListStorePromoRulesTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "promo_rules": [
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
              ],
              "store_id": "store_id"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/3.0/ecommerce/stores/store_id/promo-rules")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var items = await Client.Ecommerce.ListStorePromoRulesAsync(
            new ListStorePromoRulesEcommerceRequest { StoreId = "store_id" }
        );
        await foreach (var item in items)
        {
            Assert.That(item, Is.Not.Null);
            break; // Only check the first item
        }
    }
}
