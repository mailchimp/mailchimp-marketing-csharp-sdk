using Mailchimp.Marketing;
using Mailchimp.Marketing.Test.Unit.MockServer;
using Mailchimp.Marketing.Test.Utils;
using NUnit.Framework;

namespace Mailchimp.Marketing.Test.Unit.MockServer.Reporting;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class GetSurveyResponsTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "is_new_contact": true,
              "results": [
                {
                  "answer": "answer",
                  "query": "query",
                  "question_id": "question_id",
                  "question_type": "pickOne"
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/3.0/reporting/surveys/survey_id/responses/response_id")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Reporting.GetSurveyResponsAsync(
            new GetSurveyResponsReportingRequest
            {
                SurveyId = "survey_id",
                ResponseId = "response_id",
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
