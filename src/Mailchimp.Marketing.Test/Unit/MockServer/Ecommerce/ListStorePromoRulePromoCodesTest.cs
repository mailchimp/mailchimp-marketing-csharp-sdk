using Mailchimp.Marketing;
using Mailchimp.Marketing.Test.Unit.MockServer;
using NUnit.Framework;

namespace Mailchimp.Marketing.Test.Unit.MockServer.Ecommerce;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class ListStorePromoRulePromoCodesTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "promo_codes": [
                {
                  "code": "summersale",
                  "created_at_foreign": "2024-01-15T09:30:00.000Z",
                  "enabled": true,
                  "redemption_url": "A url that applies promo code directly at checkout or a url that points to sale page or store url",
                  "updated_at_foreign": "2024-01-15T09:30:00.000Z",
                  "usage_count": 1
                }
              ],
              "store_id": "store_id"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath(
                        "/3.0/ecommerce/stores/store_id/promo-rules/promo_rule_id/promo-codes"
                    )
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var items = await Client.Ecommerce.ListStorePromoRulePromoCodesAsync(
            new ListStorePromoRulePromoCodesEcommerceRequest
            {
                StoreId = "store_id",
                PromoRuleId = "promo_rule_id",
            }
        );
        await foreach (var item in items)
        {
            Assert.That(item, Is.Not.Null);
            break; // Only check the first item
        }
    }
}
