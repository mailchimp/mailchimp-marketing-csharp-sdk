using Mailchimp.Marketing;
using Mailchimp.Marketing.Test.Unit.MockServer;
using Mailchimp.Marketing.Test.Utils;
using NUnit.Framework;

namespace Mailchimp.Marketing.Test.Unit.MockServer.Ecommerce;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class GetStoreCartTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "campaign_id": "839488a60b",
              "checkout_url": "checkout_url",
              "currency_code": "currency_code",
              "customer": {
                "address": {
                  "address1": "675 Ponce de Leon Ave NE",
                  "address2": "Suite 5000",
                  "city": "Atlanta",
                  "country": "United States",
                  "country_code": "US",
                  "postal_code": "30308",
                  "province": "Georgia",
                  "province_code": "GA"
                },
                "company": "company",
                "first_name": "first_name",
                "last_name": "last_name",
                "opt_in_status": true,
                "sms_phone_number": "sms_phone_number",
                "total_spent": 1.1
              },
              "lines": [
                {
                  "price": 1.1,
                  "product_id": "product_id",
                  "product_variant_id": "product_variant_id",
                  "quantity": 1
                }
              ],
              "order_total": 1.1,
              "tax_total": 1.1
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/3.0/ecommerce/stores/store_id/carts/cart_id")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Ecommerce.GetStoreCartAsync(
            new GetStoreCartEcommerceRequest { StoreId = "store_id", CartId = "cart_id" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
