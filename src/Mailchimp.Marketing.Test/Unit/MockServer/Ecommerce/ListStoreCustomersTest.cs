using Mailchimp.Marketing;
using Mailchimp.Marketing.Test.Unit.MockServer;
using NUnit.Framework;

namespace Mailchimp.Marketing.Test.Unit.MockServer.Ecommerce;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class ListStoreCustomersTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "customers": [
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
              ],
              "store_id": "store_id"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/3.0/ecommerce/stores/store_id/customers")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var items = await Client.Ecommerce.ListStoreCustomersAsync(
            new ListStoreCustomersEcommerceRequest { StoreId = "store_id" }
        );
        await foreach (var item in items)
        {
            Assert.That(item, Is.Not.Null);
            break; // Only check the first item
        }
    }
}
