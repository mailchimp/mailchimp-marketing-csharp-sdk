using Mailchimp.Marketing;
using Mailchimp.Marketing.Test.Unit.MockServer;
using Mailchimp.Marketing.Test.Utils;
using NUnit.Framework;

namespace Mailchimp.Marketing.Test.Unit.MockServer.VerifiedDomains;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class CreateActionVerifyTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string requestJson = """
            {
              "code": "code"
            }
            """;

        const string mockResponse = """
            {}
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/3.0/verified-domains/domain_name/actions/verify")
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

        var response = await Client.VerifiedDomains.CreateActionVerifyAsync(
            new CreateActionVerifyVerifiedDomainsRequest
            {
                DomainName = "domain_name",
                Code = "code",
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
