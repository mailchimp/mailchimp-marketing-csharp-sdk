using Mailchimp.Marketing;
using Mailchimp.Marketing.Test.Unit.MockServer;
using Mailchimp.Marketing.Test.Utils;
using NUnit.Framework;

namespace Mailchimp.Marketing.Test.Unit.MockServer.Surveys;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class CreateListSurveyActionPublishTest : BaseMockServerTest
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
                    .WithPath("/3.0/lists/list_id/surveys/survey_id/actions/publish")
                    .UsingPost()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Surveys.CreateListSurveyActionPublishAsync(
            new CreateListSurveyActionPublishSurveysRequest
            {
                ListId = "list_id",
                SurveyId = "survey_id",
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
