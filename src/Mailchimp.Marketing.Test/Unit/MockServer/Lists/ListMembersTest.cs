using Mailchimp.Marketing;
using Mailchimp.Marketing.Test.Unit.MockServer;
using NUnit.Framework;

namespace Mailchimp.Marketing.Test.Unit.MockServer.Lists;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class ListMembersTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "list_id": "list_id",
              "members": [
                {
                  "email_address": "email_address",
                  "email_type": {
                    "key": "value"
                  },
                  "interests": {
                    "key": true
                  },
                  "language": "language",
                  "marketing_permissions": [
                    {}
                  ],
                  "merge_fields": {
                    "key": {
                      "addr1": "addr1",
                      "city": "city",
                      "state": "state",
                      "zip": "zip"
                    }
                  },
                  "sms_phone_number": "sms_phone_number",
                  "sms_subscription_last_updated": "sms_subscription_last_updated",
                  "sms_subscription_status": "subscribed",
                  "status": "subscribed",
                  "tags": [
                    {}
                  ],
                  "unsubscribe_reason": "unsubscribe_reason",
                  "vip": true
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/3.0/lists/list_id/members")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var items = await Client.Lists.ListMembersAsync(
            new ListMembersListsRequest { ListId = "list_id" }
        );
        await foreach (var item in items)
        {
            Assert.That(item, Is.Not.Null);
            break; // Only check the first item
        }
    }
}
