using Mailchimp.Marketing;
using Mailchimp.Marketing.Test.Unit.MockServer;
using Mailchimp.Marketing.Test.Utils;
using NUnit.Framework;

namespace Mailchimp.Marketing.Test.Unit.MockServer.Lists;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class GetMemberTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "email_address": "email_address",
              "email_type": {
                "key": "value"
              },
              "interests": {
                "key": true
              },
              "language": "language",
              "location": {
                "latitude": 1.1,
                "longitude": 1.1
              },
              "marketing_permissions": [
                {
                  "enabled": true,
                  "marketing_permission_id": "marketing_permission_id",
                  "text": "text"
                }
              ],
              "merge_fields": {
                "key": {
                  "addr1": "addr1",
                  "addr2": "addr2",
                  "city": "city",
                  "state": "state",
                  "zip": "zip",
                  "country": "country"
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
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/3.0/lists/list_id/members/subscriber_hash")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Lists.GetMemberAsync(
            new GetMemberListsRequest { ListId = "list_id", SubscriberHash = "subscriber_hash" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
