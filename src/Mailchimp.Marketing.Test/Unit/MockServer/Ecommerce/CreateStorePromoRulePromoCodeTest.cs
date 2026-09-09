using Mailchimp.Marketing;
using Mailchimp.Marketing.Test.Unit.MockServer;
using Mailchimp.Marketing.Test.Utils;
using NUnit.Framework;

namespace Mailchimp.Marketing.Test.Unit.MockServer.Ecommerce;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class CreateStorePromoRulePromoCodeTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string requestJson = """
            {
              "code": "summersale",
              "id": "id",
              "redemption_url": "A url that applies promo code directly at checkout or a url that points to sale page or store url"
            }
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
                        "/3.0/ecommerce/stores/store_id/promo-rules/promo_rule_id/promo-codes"
                    )
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

        var response = await Client.Ecommerce.CreateStorePromoRulePromoCodeAsync(
            new CreateStorePromoRulePromoCodeEcommerceRequest
            {
                StoreId = "store_id",
                PromoRuleId = "promo_rule_id",
                Code = "summersale",
                Id = "id",
                RedemptionUrl =
                    "A url that applies promo code directly at checkout or a url that points to sale page or store url",
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
