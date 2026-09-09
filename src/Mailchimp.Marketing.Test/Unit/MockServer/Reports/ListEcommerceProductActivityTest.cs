using Mailchimp.Marketing;
using Mailchimp.Marketing.Test.Unit.MockServer;
using NUnit.Framework;

namespace Mailchimp.Marketing.Test.Unit.MockServer.Reports;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class ListEcommerceProductActivityTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "products": [
                {
                  "currency_code": "currency_code",
                  "image_url": "image_url",
                  "recommendation_purchased": 1,
                  "recommendation_total": 1,
                  "sku": "sku",
                  "title": "title",
                  "total_purchased": 1.1,
                  "total_revenue": 1.1
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/3.0/reports/campaign_id/ecommerce-product-activity")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var items = await Client.Reports.ListEcommerceProductActivityAsync(
            new ListEcommerceProductActivityReportsRequest { CampaignId = "campaign_id" }
        );
        await foreach (var item in items)
        {
            Assert.That(item, Is.Not.Null);
            break; // Only check the first item
        }
    }
}
