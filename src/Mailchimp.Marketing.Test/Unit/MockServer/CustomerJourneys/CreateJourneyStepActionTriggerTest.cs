using Mailchimp.Marketing;
using Mailchimp.Marketing.Test.Unit.MockServer;
using NUnit.Framework;

namespace Mailchimp.Marketing.Test.Unit.MockServer.CustomerJourneys;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class CreateJourneyStepActionTriggerTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public void MockServerTest()
    {
        const string requestJson = """
            {
              "email_address": "email_address"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/3.0/customer-journeys/journeys/1/steps/1/actions/trigger")
                    .WithHeader("Content-Type", "application/json")
                    .UsingPost()
                    .WithBodyAsJson(requestJson)
            )
            .RespondWith(WireMock.ResponseBuilders.Response.Create().WithStatusCode(200));

        Assert.DoesNotThrowAsync(async () =>
            await Client.CustomerJourneys.CreateJourneyStepActionTriggerAsync(
                new CreateJourneyStepActionTriggerCustomerJourneysRequest
                {
                    JourneyId = 1,
                    StepId = 1,
                    EmailAddress = "email_address",
                }
            )
        );
    }
}
