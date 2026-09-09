using Mailchimp.Marketing;
using Mailchimp.Marketing.Test.Unit.MockServer;
using Mailchimp.Marketing.Test.Utils;
using NUnit.Framework;

namespace Mailchimp.Marketing.Test.Unit.MockServer.Ecommerce;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class GetStoreProductVariantTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
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
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath(
                        "/3.0/ecommerce/stores/store_id/products/product_id/variants/variant_id"
                    )
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Ecommerce.GetStoreProductVariantAsync(
            new GetStoreProductVariantEcommerceRequest
            {
                StoreId = "store_id",
                ProductId = "product_id",
                VariantId = "variant_id",
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
