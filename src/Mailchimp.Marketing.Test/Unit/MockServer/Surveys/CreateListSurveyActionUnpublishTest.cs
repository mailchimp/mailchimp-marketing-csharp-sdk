using Mailchimp.Marketing;
using Mailchimp.Marketing.Test.Unit.MockServer;
using Mailchimp.Marketing.Test.Utils;
using NUnit.Framework;

namespace Mailchimp.Marketing.Test.Unit.MockServer.Surveys;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class CreateListSurveyActionUnpublishTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "key": "value"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/3.0/lists/list_id/surveys/survey_id/actions/unpublish")
                    .UsingPost()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Surveys.CreateListSurveyActionUnpublishAsync(
            new CreateListSurveyActionUnpublishSurveysRequest
            {
                ListId = "list_id",
                SurveyId = "survey_id",
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
