using Mailchimp.Marketing;
using Mailchimp.Marketing.Test.Unit.MockServer;
using Mailchimp.Marketing.Test.Utils;
using NUnit.Framework;

namespace Mailchimp.Marketing.Test.Unit.MockServer.Reporting;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class ListSurveyQuestionAnswersTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "answers": [
                {
                  "is_new_contact": true
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/3.0/reporting/surveys/survey_id/questions/question_id/answers")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Reporting.ListSurveyQuestionAnswersAsync(
            new ListSurveyQuestionAnswersReportingRequest
            {
                SurveyId = "survey_id",
                QuestionId = "question_id",
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
