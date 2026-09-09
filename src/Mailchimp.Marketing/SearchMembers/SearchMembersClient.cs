using global::System.Text.Json;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

public partial class SearchMembersClient : ISearchMembersClient
{
    private readonly RawClient _client;

    internal SearchMembersClient(RawClient client)
    {
        _client = client;
    }

    private async Task<WithRawResponse<ListSearchMembersResponse>> ListAsyncCore(
        ListSearchMembersRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _queryString = new Mailchimp.Marketing.Core.QueryStringBuilder.Builder(capacity: 4)
            .Add("fields", request.Fields)
            .Add("exclude_fields", request.ExcludeFields)
            .Add("query", request.Query)
            .Add("list_id", request.ListId)
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
                    Method = HttpMethod.Get,
                    Path = "3.0/search-members",
                    QueryString = _queryString,
                    Headers = _headers,
                    Options = options,
                },
                cancellationToken
            )
            .ConfigureAwait(false);
        if (response.StatusCode is >= 200 and < 400)
        {
            var responseBody = await response
                .Raw.Content.ReadAsStringAsync(cancellationToken)
                .ConfigureAwait(false);
            try
            {
                var responseData = JsonUtils.Deserialize<ListSearchMembersResponse>(responseBody)!;
                return new WithRawResponse<ListSearchMembersResponse>()
                {
                    Data = responseData,
                    RawResponse = new Mailchimp.Marketing.RawResponse()
                    {
                        StatusCode = response.Raw.StatusCode,
                        Url = response.Raw.RequestMessage?.RequestUri ?? new Uri("about:blank"),
                        Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                    },
                };
            }
            catch (JsonException e)
            {
                throw new MailchimpClientApiException(
                    "Failed to deserialize response",
                    response.StatusCode,
                    responseBody,
                    e,
                    rawResponse: new Mailchimp.Marketing.RawResponse()
                    {
                        StatusCode = response.Raw.StatusCode,
                        Url = response.Raw.RequestMessage?.RequestUri ?? new Uri("about:blank"),
                        Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                    }
                );
            }
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
    /// Search for list members. This search can be restricted to a specific list, or can be used to search across all lists in an account.
    /// </summary>
    /// <example><code>
    /// await client.SearchMembers.ListAsync(new ListSearchMembersRequest { Query = "query" });
    /// </code></example>
    public WithRawResponseTask<ListSearchMembersResponse> ListAsync(
        ListSearchMembersRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<ListSearchMembersResponse>(
            ListAsyncCore(request, options, cancellationToken)
        );
    }
}
