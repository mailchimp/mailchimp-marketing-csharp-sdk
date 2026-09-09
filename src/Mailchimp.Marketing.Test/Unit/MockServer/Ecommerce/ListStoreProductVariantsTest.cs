using Mailchimp.Marketing;
using Mailchimp.Marketing.Test.Unit.MockServer;
using NUnit.Framework;

namespace Mailchimp.Marketing.Test.Unit.MockServer.Ecommerce;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class ListStoreProductVariantsTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "product_id": "product_id",
              "store_id": "store_id",
              "variants": [
                {
                  "backorders": "backorders",
                  "image_url": "image_url",
                  "inventory_quantity": 1,
                  "price": 1.1,
                  "sku": "sku",
                  "title": "Cat Hat",
                  "url": "url",
                  "visibility": "visibility"
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/3.0/ecommerce/stores/store_id/products/product_id/variants")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var items = await Client.Ecommerce.ListStoreProductVariantsAsync(
            new ListStoreProductVariantsEcommerceRequest
            {
                StoreId = "store_id",
                ProductId = "product_id",
            }
        );
        await foreach (var item in items)
        {
            Assert.That(item, Is.Not.Null);
            break; // Only check the first item
        }
    }
}
