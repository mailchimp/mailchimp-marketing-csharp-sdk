using Mailchimp.Marketing;
using Mailchimp.Marketing.Test.Unit.MockServer;
using Mailchimp.Marketing.Test.Utils;
using NUnit.Framework;

namespace Mailchimp.Marketing.Test.Unit.MockServer.Ecommerce;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class CreateStoreOrderTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string requestJson = """
            {
              "currency_code": "currency_code",
              "customer": {
                "id": "id"
              },
              "id": "id",
              "lines": [
                {
                  "id": "id",
                  "price": 1.1,
                  "product_id": "product_id",
                  "product_variant_id": "product_variant_id",
                  "quantity": 1
                }
              ],
              "order_total": 1.1
            }
            """;

        const string mockResponse = """
            {
              "billing_address": {
                "address1": "675 Ponce de Leon Ave NE",
                "address2": "Suite 5000",
                "city": "Atlanta",
                "company": "company",
                "country": "United States",
                "country_code": "US",
                "latitude": 45.427408,
                "longitude": -75.68903,
                "name": "Freddie Chimpenheimer",
                "phone": "8675309",
                "postal_code": "30308",
                "province": "Georgia",
                "province_code": "GA"
              },
              "campaign_id": "839488a60b",
              "cart_id": "cart-123",
              "cancelled_at_foreign": "2015-07-15T19:28:00.000Z",
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
              "discount_total": 1.1,
              "financial_status": "financial_status",
              "fulfillment_status": "fulfillment_status",
              "landing_site": "http://www.example.com?source=abc",
              "lines": [
                {
                  "discount": 1.1,
                  "price": 1.1,
                  "product_id": "product_id",
                  "product_variant_id": "product_variant_id",
                  "quantity": 1
                }
              ],
              "order_total": 1.1,
              "order_url": "order_url",
              "outreach": {
                "id": "839488a60b"
              },
              "processed_at_foreign": "2015-07-15T19:28:00.000Z",
              "promos": [
                {
                  "amount_discounted": 1.1,
                  "code": "code",
                  "type": "fixed"
                }
              ],
              "shipping_address": {
                "address1": "675 Ponce de Leon Ave NE",
                "address2": "Suite 5000",
                "city": "Atlanta",
                "company": "company",
                "country": "United States",
                "country_code": "US",
                "latitude": 45.427408,
                "longitude": -75.68903,
                "name": "Freddie Chimpenheimer",
                "phone": "8675309",
                "postal_code": "30308",
                "province": "Georgia",
                "province_code": "GA"
              },
              "shipping_total": 1.1,
              "tax_total": 1.1,
              "tracking_carrier": "tracking_carrier",
              "tracking_code": "prec",
              "tracking_number": "tracking_number",
              "tracking_url": "tracking_url",
              "updated_at_foreign": "2015-07-15T19:28:00.000Z"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/3.0/ecommerce/stores/store_id/orders")
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

        var response = await Client.Ecommerce.CreateStoreOrderAsync(
            new CreateStoreOrderEcommerceRequest
            {
                StoreId = "store_id",
                CurrencyCode = "currency_code",
                Customer = new EcommerceStoresCartsPost { Id = "id" },
                Id = "id",
                Lines =
                    new global::System.Collections.Generic.List<CreateStoreOrderEcommerceRequestLinesItem>()
                    {
                        new CreateStoreOrderEcommerceRequestLinesItem
                        {
                            Id = "id",
                            Price = 1.1,
                            ProductId = "product_id",
                            ProductVariantId = "product_variant_id",
                            Quantity = 1,
                        },
                    },
                OrderTotal = 1.1,
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
