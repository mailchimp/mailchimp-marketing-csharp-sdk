using Mailchimp.Marketing;
using Mailchimp.Marketing.Test.Unit.MockServer;
using Mailchimp.Marketing.Test.Utils;
using NUnit.Framework;

namespace Mailchimp.Marketing.Test.Unit.MockServer.AuthorizedApps;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class GetTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "description": "description",
              "id": 1,
              "name": "name",
              "users": [
                "users"
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/3.0/authorized-apps/app_id")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.AuthorizedApps.GetAsync(
            new GetAuthorizedAppsRequest { AppId = "app_id" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
