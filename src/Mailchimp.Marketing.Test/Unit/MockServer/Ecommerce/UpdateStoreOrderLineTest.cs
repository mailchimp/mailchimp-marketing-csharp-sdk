using Mailchimp.Marketing;
using Mailchimp.Marketing.Test.Unit.MockServer;
using Mailchimp.Marketing.Test.Utils;
using NUnit.Framework;

namespace Mailchimp.Marketing.Test.Unit.MockServer.Ecommerce;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class UpdateStoreOrderLineTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string requestJson = """
            {}
            """;

        const string mockResponse = """
            {
              "discount": 1.1,
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
                    .WithPath("/3.0/ecommerce/stores/store_id/orders/order_id/lines/line_id")
                    .WithHeader("Content-Type", "application/json")
                    .UsingPatch()
                    .WithBodyAsJson(requestJson)
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Ecommerce.UpdateStoreOrderLineAsync(
            new UpdateStoreOrderLineEcommerceRequest
            {
                StoreId = "store_id",
                OrderId = "order_id",
                LineId = "line_id",
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
