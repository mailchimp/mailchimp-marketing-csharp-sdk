using Mailchimp.Marketing;
using Mailchimp.Marketing.Test.Unit.MockServer;
using Mailchimp.Marketing.Test.Utils;
using NUnit.Framework;

namespace Mailchimp.Marketing.Test.Unit.MockServer.Ecommerce;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class CreateStoreCartLineTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string requestJson = """
            {
              "id": "id",
              "price": 1.1,
              "product_id": "product_id",
              "product_variant_id": "product_variant_id",
              "quantity": 1
            }
            """;

        const string mockResponse = """
            {
              "price": 1.1,
              "product_id": "product_id",
              "product_variant_id": "product_variant_id",
              "quantity": 1
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/3.0/ecommerce/stores/store_id/carts/cart_id/lines")
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

        var response = await Client.Ecommerce.CreateStoreCartLineAsync(
            new CreateStoreCartLineEcommerceRequest
            {
                StoreId = "store_id",
                CartId = "cart_id",
                Id = "id",
                Price = 1.1,
                ProductId = "product_id",
                ProductVariantId = "product_variant_id",
                Quantity = 1,
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
