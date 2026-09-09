using Mailchimp.Marketing;
using Mailchimp.Marketing.Test.Unit.MockServer;
using Mailchimp.Marketing.Test.Utils;
using NUnit.Framework;

namespace Mailchimp.Marketing.Test.Unit.MockServer.Conversations;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class ListMessagesTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "conversation_id": "conversation_id",
              "conversation_messages": [
                {
                  "from_email": "from_email",
                  "message": "message",
                  "read": true,
                  "subject": "subject"
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/3.0/conversations/conversation_id/messages")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Conversations.ListMessagesAsync(
            new ListMessagesConversationsRequest { ConversationId = "conversation_id" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
