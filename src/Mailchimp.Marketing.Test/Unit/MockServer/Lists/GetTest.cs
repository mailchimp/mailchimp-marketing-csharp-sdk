using Mailchimp.Marketing;
using Mailchimp.Marketing.Test.Unit.MockServer;
using Mailchimp.Marketing.Test.Utils;
using NUnit.Framework;

namespace Mailchimp.Marketing.Test.Unit.MockServer.Lists;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class GetTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "campaign_defaults": {
                "from_email": "from_email",
                "from_name": "from_name",
                "language": "language",
                "subject": "subject"
              },
              "contact": {
                "address1": "address1",
                "address2": "address2",
                "city": "city",
                "company": "company",
                "country": "country",
                "phone": "phone",
                "state": "state",
                "zip": "zip"
              },
              "double_optin": true,
              "email_type_option": true,
              "has_welcome": false,
              "marketing_permissions": true,
              "name": "name",
              "notify_on_subscribe": "notify_on_subscribe",
              "notify_on_unsubscribe": "notify_on_unsubscribe",
              "permission_reminder": "permission_reminder",
              "use_archive_bar": true,
              "visibility": "pub"
            }
            """;

        Server
            .Given(
                WireMock.RequestBuilders.Request.Create().WithPath("/3.0/lists/list_id").UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Lists.GetAsync(new GetListsRequest { ListId = "list_id" });
        JsonAssert.AreEqual(response, mockResponse);
    }
}
