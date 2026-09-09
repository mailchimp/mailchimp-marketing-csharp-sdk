using Mailchimp.Marketing;
using Mailchimp.Marketing.Test.Unit.MockServer;
using NUnit.Framework;

namespace Mailchimp.Marketing.Test.Unit.MockServer.Ecommerce;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class DeleteStorePromoRuleTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public void MockServerTest()
    {
        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/3.0/ecommerce/stores/store_id/promo-rules/promo_rule_id")
                    .UsingDelete()
            )
            .RespondWith(WireMock.ResponseBuilders.Response.Create().WithStatusCode(200));

        Assert.DoesNotThrowAsync(async () =>
            await Client.Ecommerce.DeleteStorePromoRuleAsync(
                new DeleteStorePromoRuleEcommerceRequest
                {
                    StoreId = "store_id",
                    PromoRuleId = "promo_rule_id",
                }
            )
        );
    }
}
