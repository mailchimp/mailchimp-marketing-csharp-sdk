using Mailchimp.Marketing;
using Mailchimp.Marketing.Test.Unit.MockServer;
using Mailchimp.Marketing.Test.Utils;
using NUnit.Framework;

namespace Mailchimp.Marketing.Test.Unit.MockServer.FileManager;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class CreateFileTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string requestJson = """
            {
              "file_data": "file_data",
              "name": "name"
            }
            """;

        const string mockResponse = """
            {
              "folder_id": 1,
              "name": "name"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/3.0/file-manager/files")
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

        var response = await Client.FileManager.CreateFileAsync(
            new CreateFileFileManagerRequest { FileData = "file_data", Name = "name" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
