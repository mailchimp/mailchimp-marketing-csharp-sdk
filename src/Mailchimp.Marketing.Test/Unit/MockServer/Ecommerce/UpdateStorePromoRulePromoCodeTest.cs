using Mailchimp.Marketing;
using Mailchimp.Marketing.Test.Unit.MockServer;
using Mailchimp.Marketing.Test.Utils;
using NUnit.Framework;

namespace Mailchimp.Marketing.Test.Unit.MockServer.Ecommerce;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class UpdateStorePromoRulePromoCodeTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string requestJson = """
            {}
            """;

        const string mockResponse = """
            {
              "code": "summersale",
              "created_at_foreign": "2024-01-15T09:30:00.000Z",
              "enabled": true,
              "redemption_url": "A url that applies promo code directly at checkout or a url that points to sale page or store url",
              "updated_at_foreign": "2024-01-15T09:30:00.000Z",
              "usage_count": 1
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath(
                        "/3.0/ecommerce/stores/store_id/promo-rules/promo_rule_id/promo-codes/promo_code_id"
                    )
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

        var response = await Client.Ecommerce.UpdateStorePromoRulePromoCodeAsync(
            new UpdateStorePromoRulePromoCodeEcommerceRequest
            {
                StoreId = "store_id",
                PromoRuleId = "promo_rule_id",
                PromoCodeId = "promo_code_id",
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
