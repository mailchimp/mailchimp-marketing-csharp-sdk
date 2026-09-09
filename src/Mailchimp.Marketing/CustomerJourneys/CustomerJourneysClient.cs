using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

public partial class CustomerJourneysClient : ICustomerJourneysClient
{
    private readonly RawClient _client;

    internal CustomerJourneysClient(RawClient client)
    {
        _client = client;
    }

    private async Task<RawResponse> CreateJourneyStepActionTriggerAsyncCore(
        CreateJourneyStepActionTriggerCustomerJourneysRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _queryString = new Mailchimp.Marketing.Core.QueryStringBuilder.Builder(capacity: 0)
            .MergeAdditional(options?.AdditionalQueryParameters)
            .Build();
        var _headers = await new Mailchimp.Marketing.Core.HeadersBuilder.Builder()
            .Add(_client.Options.Headers)
            .Add(_client.Options.AdditionalHeaders)
            .Add(options?.AdditionalHeaders)
            .BuildAsync()
            .ConfigureAwait(false);
        var response = await _client
            .SendRequestAsync(
                new JsonRequest
                {
                    Method = HttpMethod.Post,
                    Path = string.Format(
                        "3.0/customer-journeys/journeys/{0}/steps/{1}/actions/trigger",
                        ValueConvert.ToPathParameterString(request.JourneyId),
                        ValueConvert.ToPathParameterString(request.StepId)
                    ),
                    Body = request,
                    QueryString = _queryString,
                    Headers = _headers,
                    ContentType = "application/json",
                    Options = options,
                },
                cancellationToken
            )
            .ConfigureAwait(false);
        if (response.StatusCode is >= 200 and < 400)
        {
            return new Mailchimp.Marketing.RawResponse()
            {
                StatusCode = response.Raw.StatusCode,
                Url = response.Raw.RequestMessage?.RequestUri ?? new Uri("about:blank"),
                Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
            };
        }
        {
            var responseBody = await response
                .Raw.Content.ReadAsStringAsync(cancellationToken)
                .ConfigureAwait(false);
            throw new MailchimpClientApiException(
                $"Error with status code {response.StatusCode}",
                response.StatusCode,
                responseBody,
                rawResponse: new Mailchimp.Marketing.RawResponse()
                {
                    StatusCode = response.Raw.StatusCode,
                    Url = response.Raw.RequestMessage?.RequestUri ?? new Uri("about:blank"),
                    Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                }
            );
        }
    }

    /// <summary>
    /// A step trigger in an Automation flow. To use it, create a starting point or step from the Automation flow builder in the app using the Customer Journeys API condition. We’ll provide a url during the process that includes the {journey_id} and {step_id}. You’ll then be able to use this endpoint to trigger the condition for the posted contact.
    /// </summary>
    /// <example><code>
    /// await client.CustomerJourneys.CreateJourneyStepActionTriggerAsync(
    ///     new CreateJourneyStepActionTriggerCustomerJourneysRequest
    ///     {
    ///         JourneyId = 1,
    ///         StepId = 1,
    ///         EmailAddress = "email_address",
    ///     }
    /// );
    /// </code></example>
    public WithRawResponseTask CreateJourneyStepActionTriggerAsync(
        CreateJourneyStepActionTriggerCustomerJourneysRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask(
            CreateJourneyStepActionTriggerAsyncCore(request, options, cancellationToken)
        );
    }
}
