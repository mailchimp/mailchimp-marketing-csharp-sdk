using Mailchimp.Marketing;
using Mailchimp.Marketing.Test.Unit.MockServer;
using NUnit.Framework;

namespace Mailchimp.Marketing.Test.Unit.MockServer.Ecommerce;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class ListStoreProductsTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "products": [
                {
                  "description": "This is a cat hat.",
                  "handle": "cat-hat",
                  "image_url": "image_url",
                  "images": [
                    {}
                  ],
                  "published_at_foreign": "2015-07-15T19:28:00.000Z",
                  "title": "Cat Hat",
                  "type": "Accessories",
                  "url": "url",
                  "variants": [
                    {
                      "title": "Cat Hat"
                    }
                  ],
                  "vendor": "vendor"
                }
              ],
              "store_id": "store_id"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/3.0/ecommerce/stores/store_id/products")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var items = await Client.Ecommerce.ListStoreProductsAsync(
            new ListStoreProductsEcommerceRequest { StoreId = "store_id" }
        );
        await foreach (var item in items)
        {
            Assert.That(item, Is.Not.Null);
            break; // Only check the first item
        }
    }
}
