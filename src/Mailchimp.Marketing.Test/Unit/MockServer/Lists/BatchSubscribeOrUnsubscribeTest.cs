using Mailchimp.Marketing;
using Mailchimp.Marketing.Test.Unit.MockServer;
using Mailchimp.Marketing.Test.Utils;
using NUnit.Framework;
using OneOf;

namespace Mailchimp.Marketing.Test.Unit.MockServer.Lists;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class BatchSubscribeOrUnsubscribeTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string requestJson = """
            {
              "members": []
            }
            """;

        const string mockResponse = """
            {
              "error_count": 42,
              "errors": [
                {
                  "email_address": "email_address",
                  "error": "error",
                  "error_code": "ERROR_CONTACT_EXISTS",
                  "field": "field",
                  "field_message": "field_message"
                }
              ],
              "new_members": [
                {
                  "email_address": "email_address",
                  "email_type": "email_type",
                  "interests": {
                    "key": true
                  },
                  "language": "language",
                  "merge_fields": {
                    "key": "value"
                  },
                  "status": "subscribed",
                  "tags": [
                    {}
                  ],
                  "vip": true
                }
              ],
              "total_created": 42,
              "total_updated": 42,
              "updated_members": [
                {
                  "email_address": "email_address",
                  "email_type": "email_type",
                  "interests": {
                    "key": true
                  },
                  "language": "language",
                  "merge_fields": {
                    "key": "value"
                  },
                  "status": "subscribed",
                  "tags": [
                    {}
                  ],
                  "vip": true
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/3.0/lists/list_id")
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

        var response = await Client.Lists.BatchSubscribeOrUnsubscribeAsync(
            new BatchSubscribeOrUnsubscribeListsRequest
            {
                ListId = "list_id",
                Members = new global::System.Collections.Generic.List<OneOf<object>>() { },
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
