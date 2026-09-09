using Mailchimp.Marketing;
using Mailchimp.Marketing.Test.Unit.MockServer;
using Mailchimp.Marketing.Test.Utils;
using NUnit.Framework;

namespace Mailchimp.Marketing.Test.Unit.MockServer.Ecommerce;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class GetStoreCartLineTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
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
                    .WithPath("/3.0/ecommerce/stores/store_id/carts/cart_id/lines/line_id")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Ecommerce.GetStoreCartLineAsync(
            new GetStoreCartLineEcommerceRequest
            {
                StoreId = "store_id",
                CartId = "cart_id",
                LineId = "line_id",
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
