using Mailchimp.Marketing;
using Mailchimp.Marketing.Test.Unit.MockServer;
using NUnit.Framework;

namespace Mailchimp.Marketing.Test.Unit.MockServer.Ecommerce;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class ListStoresTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "stores": [
                {
                  "address": {
                    "address1": "675 Ponce de Leon Ave NE",
                    "address2": "Suite 5000",
                    "city": "Atlanta",
                    "country": "United States",
                    "country_code": "US",
                    "latitude": 45.427408,
                    "longitude": -75.68903,
                    "postal_code": "30308",
                    "province": "Georgia",
                    "province_code": "GA"
                  },
                  "currency_code": "USD",
                  "domain": "example.com",
                  "email_address": "freddie@mailchimp.com",
                  "is_syncing": true,
                  "money_format": "$",
                  "name": "Freddie's Cat Hat Emporium",
                  "phone": "+16155550128",
                  "platform": "platform",
                  "primary_locale": "fr",
                  "timezone": "Eastern"
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/3.0/ecommerce/stores")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var items = await Client.Ecommerce.ListStoresAsync(new ListStoresEcommerceRequest());
        await foreach (var item in items)
        {
            Assert.That(item, Is.Not.Null);
            break; // Only check the first item
        }
    }
}
