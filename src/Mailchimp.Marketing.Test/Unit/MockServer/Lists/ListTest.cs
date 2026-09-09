using Mailchimp.Marketing;
using Mailchimp.Marketing.Test.Unit.MockServer;
using NUnit.Framework;

namespace Mailchimp.Marketing.Test.Unit.MockServer.Lists;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class ListTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "constraints": {
                "current_total_instances": 1,
                "max_instances": 1,
                "may_create": true
              },
              "lists": [
                {
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
              ]
            }
            """;

        Server
            .Given(WireMock.RequestBuilders.Request.Create().WithPath("/3.0/lists").UsingGet())
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var items = await Client.Lists.ListAsync(new ListListsRequest());
        await foreach (var item in items)
        {
            Assert.That(item, Is.Not.Null);
            break; // Only check the first item
        }
    }
}
