using Mailchimp.Marketing;
using Mailchimp.Marketing.Test.Unit.MockServer;
using Mailchimp.Marketing.Test.Utils;
using NUnit.Framework;

namespace Mailchimp.Marketing.Test.Unit.MockServer.AccountExports;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class CreateTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string requestJson = """
            {
              "include_stages": [
                "audiences",
                "gallery_files"
              ]
            }
            """;

        const string mockResponse = """
            {
              "download_url": "download_url",
              "export_id": 1,
              "finished": "2024-01-15T09:30:00.000Z",
              "size_in_bytes": 1,
              "started": "2024-01-15T09:30:00.000Z"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/3.0/account-exports")
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

        var response = await Client.AccountExports.CreateAsync(
            new CreateAccountExportsRequest
            {
                IncludeStages =
                    new global::System.Collections.Generic.List<CreateAccountExportsRequestIncludeStagesItem>()
                    {
                        CreateAccountExportsRequestIncludeStagesItem.Audiences,
                        CreateAccountExportsRequestIncludeStagesItem.GalleryFiles,
                    },
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
