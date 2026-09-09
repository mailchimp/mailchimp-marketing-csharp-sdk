using Mailchimp.Marketing;
using Mailchimp.Marketing.Test.Unit.MockServer;
using NUnit.Framework;

namespace Mailchimp.Marketing.Test.Unit.MockServer.Ecommerce;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class ListStoreCartsTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "carts": [
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
                    }
                  },
                  "lines": [
                    {}
                  ],
                  "order_total": 1.1,
                  "tax_total": 1.1
                }
              ],
              "store_id": "store_id"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/3.0/ecommerce/stores/store_id/carts")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var items = await Client.Ecommerce.ListStoreCartsAsync(
            new ListStoreCartsEcommerceRequest { StoreId = "store_id" }
        );
        await foreach (var item in items)
        {
            Assert.That(item, Is.Not.Null);
            break; // Only check the first item
        }
    }
}
