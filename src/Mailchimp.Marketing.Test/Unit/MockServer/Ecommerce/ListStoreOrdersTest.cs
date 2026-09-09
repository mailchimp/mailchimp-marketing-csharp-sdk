using Mailchimp.Marketing;
using Mailchimp.Marketing.Test.Unit.MockServer;
using NUnit.Framework;

namespace Mailchimp.Marketing.Test.Unit.MockServer.Ecommerce;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class ListStoreOrdersTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "store_id": "store_id",
              "orders": [
                {
                  "billing_address": {
                    "address1": "675 Ponce de Leon Ave NE",
                    "address2": "Suite 5000",
                    "city": "Atlanta",
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
                    }
                  },
                  "discount_total": 1.1,
                  "financial_status": "financial_status",
                  "fulfillment_status": "fulfillment_status",
                  "landing_site": "http://www.example.com?source=abc",
                  "lines": [
                    {}
                  ],
                  "order_total": 1.1,
                  "order_url": "order_url",
                  "outreach": {
                    "id": "839488a60b"
                  },
                  "processed_at_foreign": "2015-07-15T19:28:00.000Z",
                  "promos": [
                    {}
                  ],
                  "shipping_address": {
                    "address1": "675 Ponce de Leon Ave NE",
                    "address2": "Suite 5000",
                    "city": "Atlanta",
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
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/3.0/ecommerce/stores/store_id/orders")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var items = await Client.Ecommerce.ListStoreOrdersAsync(
            new ListStoreOrdersEcommerceRequest { StoreId = "store_id" }
        );
        await foreach (var item in items)
        {
            Assert.That(item, Is.Not.Null);
            break; // Only check the first item
        }
    }
}
