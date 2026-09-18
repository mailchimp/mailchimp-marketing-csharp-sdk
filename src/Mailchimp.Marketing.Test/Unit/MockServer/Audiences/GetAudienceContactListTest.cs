using Mailchimp.Marketing;
using Mailchimp.Marketing.Test.Unit.MockServer;
using Mailchimp.Marketing.Test.Utils;
using NUnit.Framework;

namespace Mailchimp.Marketing.Test.Unit.MockServer.Audiences;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class GetAudienceContactListTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "contacts": [
                {
                  "email_channel": {
                    "email": "example@freddiemail.com",
                    "hashed_email": "9115d71ba28088047d342e3bcedacd0f",
                    "marketing_consent": {
                      "captured_at": "2024-01-15T10:30:00.000Z"
                    }
                  },
                  "language": "",
                  "merge_fields": {
                    "key": {
                      "addr1": "addr1",
                      "city": "city",
                      "state": "state",
                      "zip": "zip"
                    }
                  },
                  "sms_channel": {
                    "marketing_consent": {
                      "captured_at": "2024-01-15T10:30:00.000Z"
                    },
                    "sms_phone": "+14045550102",
                    "hashed_sms_phone": "0572084e1f8288816f02cdb7bd930c62400bc8aef510adfaa9eec2b995fa7609"
                  },
                  "tags": [
                    "tags"
                  ]
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/3.0/audiences/audience_id/contacts")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Audiences.GetAudienceContactListAsync(
            new GetAudienceContactListRequest { AudienceId = "audience_id" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
