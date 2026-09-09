using Mailchimp.Marketing;
using Mailchimp.Marketing.Test.Unit.MockServer;
using Mailchimp.Marketing.Test.Utils;
using NUnit.Framework;

namespace Mailchimp.Marketing.Test.Unit.MockServer.Ecommerce;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class CreateStoreCustomerTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string requestJson = """
            {
              "id": "id",
              "opt_in_status": true
            }
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
                    .WithPath("/3.0/ecommerce/stores/store_id/customers")
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

        var response = await Client.Ecommerce.CreateStoreCustomerAsync(
            new CreateStoreCustomerEcommerceRequest
            {
                StoreId = "store_id",
                Id = "id",
                OptInStatus = true,
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
