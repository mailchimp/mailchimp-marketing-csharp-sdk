using Mailchimp.Marketing;
using Mailchimp.Marketing.Test.Unit.MockServer;
using Mailchimp.Marketing.Test.Utils;
using NUnit.Framework;

namespace Mailchimp.Marketing.Test.Unit.MockServer.Ecommerce;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class CreateStoreProductTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string requestJson = """
            {
              "id": "id",
              "title": "Cat Hat",
              "variants": [
                {
                  "id": "id",
                  "title": "Cat Hat"
                }
              ]
            }
            """;

        const string mockResponse = """
            {
              "description": "This is a cat hat.",
              "handle": "cat-hat",
              "image_url": "image_url",
              "images": [
                {
                  "id": "id",
                  "url": "url",
                  "variant_ids": [
                    "variant_ids"
                  ]
                }
              ],
              "published_at_foreign": "2015-07-15T19:28:00.000Z",
              "title": "Cat Hat",
              "type": "Accessories",
              "url": "url",
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
              ],
              "vendor": "vendor"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/3.0/ecommerce/stores/store_id/products")
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

        var response = await Client.Ecommerce.CreateStoreProductAsync(
            new CreateStoreProductEcommerceRequest
            {
                StoreId = "store_id",
                Body = new EcommerceStoresOrdersPost
                {
                    Id = "id",
                    Title = "Cat Hat",
                    Variants =
                        new global::System.Collections.Generic.List<EcommerceStoresOrdersPostVariantsItem>()
                        {
                            new EcommerceStoresOrdersPostVariantsItem
                            {
                                Id = "id",
                                Title = "Cat Hat",
                            },
                        },
                },
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
