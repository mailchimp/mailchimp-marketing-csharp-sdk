using Mailchimp.Marketing;
using Mailchimp.Marketing.Test.Unit.MockServer;
using Mailchimp.Marketing.Test.Utils;
using NUnit.Framework;

namespace Mailchimp.Marketing.Test.Unit.MockServer.Ecommerce;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class UpdateStoreCustomerTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string requestJson = """
            {}
            """;

        const string mockResponse = """
            {
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
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/3.0/ecommerce/stores/store_id/customers/customer_id")
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

        var response = await Client.Ecommerce.UpdateStoreCustomerAsync(
            new UpdateStoreCustomerEcommerceRequest
            {
                StoreId = "store_id",
                CustomerId = "customer_id",
                Body = new EcommerceStoresCartsPatch(),
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
