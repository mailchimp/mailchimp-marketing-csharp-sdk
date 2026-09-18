using global::System.Text.Json;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

public partial class ListsClient : IListsClient
{
    private readonly RawClient _client;

    internal ListsClient(RawClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Get information about all lists in the account.
    /// </summary>
    private WithRawResponseTask<ListListsResponse> ListInternalAsync(
        ListListsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<ListListsResponse>(
            ListInternalAsyncCore(request, options, cancellationToken)
        );
    }

    private async Task<WithRawResponse<ListListsResponse>> ListInternalAsyncCore(
        ListListsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _queryString = new Mailchimp.Marketing.Core.QueryStringBuilder.Builder(capacity: 13)
            .Add("fields", request.Fields)
            .Add("exclude_fields", request.ExcludeFields)
            .Add("count", request.Count)
            .Add("offset", request.Offset)
            .Add("before_date_created", request.BeforeDateCreated)
            .Add("since_date_created", request.SinceDateCreated)
            .Add("before_campaign_last_sent", request.BeforeCampaignLastSent)
            .Add("since_campaign_last_sent", request.SinceCampaignLastSent)
            .Add("email", request.Email)
            .Add("sort_field", request.SortField)
            .Add("sort_dir", request.SortDir)
            .Add("has_ecommerce_store", request.HasEcommerceStore)
            .Add("include_total_contacts", request.IncludeTotalContacts)
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
                    Path = "3.0/lists",
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
                var responseData = JsonUtils.Deserialize<ListListsResponse>(responseBody)!;
                return new WithRawResponse<ListListsResponse>()
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

    private async Task<WithRawResponse<SubscriberList>> CreateAsyncCore(
        CreateListsRequest request,
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
                    Path = "3.0/lists",
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
            var responseBody = await response
                .Raw.Content.ReadAsStringAsync(cancellationToken)
                .ConfigureAwait(false);
            try
            {
                var responseData = JsonUtils.Deserialize<SubscriberList>(responseBody)!;
                return new WithRawResponse<SubscriberList>()
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

    private async Task<WithRawResponse<SubscriberList>> GetAsyncCore(
        GetListsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _queryString = new Mailchimp.Marketing.Core.QueryStringBuilder.Builder(capacity: 3)
            .Add("fields", request.Fields)
            .Add("exclude_fields", request.ExcludeFields)
            .Add("include_total_contacts", request.IncludeTotalContacts)
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
                    Path = string.Format(
                        "3.0/lists/{0}",
                        ValueConvert.ToPathParameterString(request.ListId)
                    ),
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
                var responseData = JsonUtils.Deserialize<SubscriberList>(responseBody)!;
                return new WithRawResponse<SubscriberList>()
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

    private async Task<
        WithRawResponse<BatchSubscribeOrUnsubscribeListsResponse>
    > BatchSubscribeOrUnsubscribeAsyncCore(
        BatchSubscribeOrUnsubscribeListsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _queryString = new Mailchimp.Marketing.Core.QueryStringBuilder.Builder(capacity: 2)
            .Add("skip_merge_validation", request.SkipMergeValidation)
            .Add("skip_duplicate_check", request.SkipDuplicateCheck)
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
                        "3.0/lists/{0}",
                        ValueConvert.ToPathParameterString(request.ListId)
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
            var responseBody = await response
                .Raw.Content.ReadAsStringAsync(cancellationToken)
                .ConfigureAwait(false);
            try
            {
                var responseData = JsonUtils.Deserialize<BatchSubscribeOrUnsubscribeListsResponse>(
                    responseBody
                )!;
                return new WithRawResponse<BatchSubscribeOrUnsubscribeListsResponse>()
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

    private async Task<RawResponse> DeleteAsyncCore(
        DeleteListsRequest request,
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
                    Method = HttpMethod.Delete,
                    Path = string.Format(
                        "3.0/lists/{0}",
                        ValueConvert.ToPathParameterString(request.ListId)
                    ),
                    QueryString = _queryString,
                    Headers = _headers,
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

    private async Task<WithRawResponse<SubscriberList>> UpdateAsyncCore(
        UpdateListsRequest request,
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
                    Method = HttpMethodExtensions.Patch,
                    Path = string.Format(
                        "3.0/lists/{0}",
                        ValueConvert.ToPathParameterString(request.ListId)
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
            var responseBody = await response
                .Raw.Content.ReadAsStringAsync(cancellationToken)
                .ConfigureAwait(false);
            try
            {
                var responseData = JsonUtils.Deserialize<SubscriberList>(responseBody)!;
                return new WithRawResponse<SubscriberList>()
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
    /// Get all abuse reports for a specific list.
    /// </summary>
    private WithRawResponseTask<ListAbuseReportsListsResponse> ListAbuseReportsInternalAsync(
        ListAbuseReportsListsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<ListAbuseReportsListsResponse>(
            ListAbuseReportsInternalAsyncCore(request, options, cancellationToken)
        );
    }

    private async Task<
        WithRawResponse<ListAbuseReportsListsResponse>
    > ListAbuseReportsInternalAsyncCore(
        ListAbuseReportsListsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _queryString = new Mailchimp.Marketing.Core.QueryStringBuilder.Builder(capacity: 4)
            .Add("fields", request.Fields)
            .Add("exclude_fields", request.ExcludeFields)
            .Add("count", request.Count)
            .Add("offset", request.Offset)
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
                    Path = string.Format(
                        "3.0/lists/{0}/abuse-reports",
                        ValueConvert.ToPathParameterString(request.ListId)
                    ),
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
                var responseData = JsonUtils.Deserialize<ListAbuseReportsListsResponse>(
                    responseBody
                )!;
                return new WithRawResponse<ListAbuseReportsListsResponse>()
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

    private async Task<WithRawResponse<ListsAbuseReports>> GetAbuseReportAsyncCore(
        GetAbuseReportListsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _queryString = new Mailchimp.Marketing.Core.QueryStringBuilder.Builder(capacity: 4)
            .Add("fields", request.Fields)
            .Add("exclude_fields", request.ExcludeFields)
            .Add("count", request.Count)
            .Add("offset", request.Offset)
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
                    Path = string.Format(
                        "3.0/lists/{0}/abuse-reports/{1}",
                        ValueConvert.ToPathParameterString(request.ListId),
                        ValueConvert.ToPathParameterString(request.ReportId)
                    ),
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
                var responseData = JsonUtils.Deserialize<ListsAbuseReports>(responseBody)!;
                return new WithRawResponse<ListsAbuseReports>()
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
    /// Get up to the previous 180 days of daily detailed aggregated activity stats for a list, not including Automation activity.
    /// </summary>
    private WithRawResponseTask<ListActivityListsResponse> ListActivityInternalAsync(
        ListActivityListsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<ListActivityListsResponse>(
            ListActivityInternalAsyncCore(request, options, cancellationToken)
        );
    }

    private async Task<WithRawResponse<ListActivityListsResponse>> ListActivityInternalAsyncCore(
        ListActivityListsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _queryString = new Mailchimp.Marketing.Core.QueryStringBuilder.Builder(capacity: 4)
            .Add("fields", request.Fields)
            .Add("exclude_fields", request.ExcludeFields)
            .Add("count", request.Count)
            .Add("offset", request.Offset)
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
                    Path = string.Format(
                        "3.0/lists/{0}/activity",
                        ValueConvert.ToPathParameterString(request.ListId)
                    ),
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
                var responseData = JsonUtils.Deserialize<ListActivityListsResponse>(responseBody)!;
                return new WithRawResponse<ListActivityListsResponse>()
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

    private async Task<WithRawResponse<ListClientsListsResponse>> ListClientsAsyncCore(
        ListClientsListsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _queryString = new Mailchimp.Marketing.Core.QueryStringBuilder.Builder(capacity: 2)
            .Add("fields", request.Fields)
            .Add("exclude_fields", request.ExcludeFields)
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
                    Path = string.Format(
                        "3.0/lists/{0}/clients",
                        ValueConvert.ToPathParameterString(request.ListId)
                    ),
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
                var responseData = JsonUtils.Deserialize<ListClientsListsResponse>(responseBody)!;
                return new WithRawResponse<ListClientsListsResponse>()
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
    /// Get a month-by-month summary of a specific list's growth activity.
    /// </summary>
    private WithRawResponseTask<ListGrowthHistoryListsResponse> ListGrowthHistoryInternalAsync(
        ListGrowthHistoryListsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<ListGrowthHistoryListsResponse>(
            ListGrowthHistoryInternalAsyncCore(request, options, cancellationToken)
        );
    }

    private async Task<
        WithRawResponse<ListGrowthHistoryListsResponse>
    > ListGrowthHistoryInternalAsyncCore(
        ListGrowthHistoryListsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _queryString = new Mailchimp.Marketing.Core.QueryStringBuilder.Builder(capacity: 6)
            .Add("fields", request.Fields)
            .Add("exclude_fields", request.ExcludeFields)
            .Add("count", request.Count)
            .Add("offset", request.Offset)
            .Add("sort_field", request.SortField)
            .Add("sort_dir", request.SortDir)
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
                    Path = string.Format(
                        "3.0/lists/{0}/growth-history",
                        ValueConvert.ToPathParameterString(request.ListId)
                    ),
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
                var responseData = JsonUtils.Deserialize<ListGrowthHistoryListsResponse>(
                    responseBody
                )!;
                return new WithRawResponse<ListGrowthHistoryListsResponse>()
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

    private async Task<WithRawResponse<GrowthHistory>> GetGrowthHistoryAsyncCore(
        GetGrowthHistoryListsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _queryString = new Mailchimp.Marketing.Core.QueryStringBuilder.Builder(capacity: 2)
            .Add("fields", request.Fields)
            .Add("exclude_fields", request.ExcludeFields)
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
                    Path = string.Format(
                        "3.0/lists/{0}/growth-history/{1}",
                        ValueConvert.ToPathParameterString(request.ListId),
                        ValueConvert.ToPathParameterString(request.Month)
                    ),
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
                var responseData = JsonUtils.Deserialize<GrowthHistory>(responseBody)!;
                return new WithRawResponse<GrowthHistory>()
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
    /// Get information about a list's interest categories.
    /// </summary>
    private WithRawResponseTask<ListInterestCategoriesListsResponse> ListInterestCategoriesInternalAsync(
        ListInterestCategoriesListsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<ListInterestCategoriesListsResponse>(
            ListInterestCategoriesInternalAsyncCore(request, options, cancellationToken)
        );
    }

    private async Task<
        WithRawResponse<ListInterestCategoriesListsResponse>
    > ListInterestCategoriesInternalAsyncCore(
        ListInterestCategoriesListsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _queryString = new Mailchimp.Marketing.Core.QueryStringBuilder.Builder(capacity: 7)
            .Add("fields", request.Fields)
            .Add("exclude_fields", request.ExcludeFields)
            .Add("count", request.Count)
            .Add("offset", request.Offset)
            .Add("type", request.Type)
            .Add("sort_field", request.SortField)
            .Add("sort_dir", request.SortDir)
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
                    Path = string.Format(
                        "3.0/lists/{0}/interest-categories",
                        ValueConvert.ToPathParameterString(request.ListId)
                    ),
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
                var responseData = JsonUtils.Deserialize<ListInterestCategoriesListsResponse>(
                    responseBody
                )!;
                return new WithRawResponse<ListInterestCategoriesListsResponse>()
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

    private async Task<WithRawResponse<InterestCategory>> CreateInterestCategoryAsyncCore(
        CreateInterestCategoryListsRequest request,
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
                        "3.0/lists/{0}/interest-categories",
                        ValueConvert.ToPathParameterString(request.ListId)
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
            var responseBody = await response
                .Raw.Content.ReadAsStringAsync(cancellationToken)
                .ConfigureAwait(false);
            try
            {
                var responseData = JsonUtils.Deserialize<InterestCategory>(responseBody)!;
                return new WithRawResponse<InterestCategory>()
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

    private async Task<WithRawResponse<InterestCategory>> GetInterestCategoryAsyncCore(
        GetInterestCategoryListsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _queryString = new Mailchimp.Marketing.Core.QueryStringBuilder.Builder(capacity: 2)
            .Add("fields", request.Fields)
            .Add("exclude_fields", request.ExcludeFields)
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
                    Path = string.Format(
                        "3.0/lists/{0}/interest-categories/{1}",
                        ValueConvert.ToPathParameterString(request.ListId),
                        ValueConvert.ToPathParameterString(request.InterestCategoryId)
                    ),
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
                var responseData = JsonUtils.Deserialize<InterestCategory>(responseBody)!;
                return new WithRawResponse<InterestCategory>()
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

    private async Task<RawResponse> DeleteInterestCategoryAsyncCore(
        DeleteInterestCategoryListsRequest request,
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
                    Method = HttpMethod.Delete,
                    Path = string.Format(
                        "3.0/lists/{0}/interest-categories/{1}",
                        ValueConvert.ToPathParameterString(request.ListId),
                        ValueConvert.ToPathParameterString(request.InterestCategoryId)
                    ),
                    QueryString = _queryString,
                    Headers = _headers,
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

    private async Task<WithRawResponse<InterestCategory>> UpdateInterestCategoryAsyncCore(
        UpdateInterestCategoryListsRequest request,
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
                    Method = HttpMethodExtensions.Patch,
                    Path = string.Format(
                        "3.0/lists/{0}/interest-categories/{1}",
                        ValueConvert.ToPathParameterString(request.ListId),
                        ValueConvert.ToPathParameterString(request.InterestCategoryId)
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
            var responseBody = await response
                .Raw.Content.ReadAsStringAsync(cancellationToken)
                .ConfigureAwait(false);
            try
            {
                var responseData = JsonUtils.Deserialize<InterestCategory>(responseBody)!;
                return new WithRawResponse<InterestCategory>()
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
    /// Get a list of this category's interests.
    /// </summary>
    private WithRawResponseTask<ListInterestCategoryInterestsListsResponse> ListInterestCategoryInterestsInternalAsync(
        ListInterestCategoryInterestsListsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<ListInterestCategoryInterestsListsResponse>(
            ListInterestCategoryInterestsInternalAsyncCore(request, options, cancellationToken)
        );
    }

    private async Task<
        WithRawResponse<ListInterestCategoryInterestsListsResponse>
    > ListInterestCategoryInterestsInternalAsyncCore(
        ListInterestCategoryInterestsListsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _queryString = new Mailchimp.Marketing.Core.QueryStringBuilder.Builder(capacity: 4)
            .Add("fields", request.Fields)
            .Add("exclude_fields", request.ExcludeFields)
            .Add("count", request.Count)
            .Add("offset", request.Offset)
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
                    Path = string.Format(
                        "3.0/lists/{0}/interest-categories/{1}/interests",
                        ValueConvert.ToPathParameterString(request.ListId),
                        ValueConvert.ToPathParameterString(request.InterestCategoryId)
                    ),
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
                var responseData =
                    JsonUtils.Deserialize<ListInterestCategoryInterestsListsResponse>(
                        responseBody
                    )!;
                return new WithRawResponse<ListInterestCategoryInterestsListsResponse>()
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

    private async Task<WithRawResponse<Interest>> CreateInterestCategoryInterestAsyncCore(
        CreateInterestCategoryInterestListsRequest request,
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
                        "3.0/lists/{0}/interest-categories/{1}/interests",
                        ValueConvert.ToPathParameterString(request.ListId),
                        ValueConvert.ToPathParameterString(request.InterestCategoryId)
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
            var responseBody = await response
                .Raw.Content.ReadAsStringAsync(cancellationToken)
                .ConfigureAwait(false);
            try
            {
                var responseData = JsonUtils.Deserialize<Interest>(responseBody)!;
                return new WithRawResponse<Interest>()
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

    private async Task<WithRawResponse<Interest>> GetInterestCategoryInterestAsyncCore(
        GetInterestCategoryInterestListsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _queryString = new Mailchimp.Marketing.Core.QueryStringBuilder.Builder(capacity: 2)
            .Add("fields", request.Fields)
            .Add("exclude_fields", request.ExcludeFields)
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
                    Path = string.Format(
                        "3.0/lists/{0}/interest-categories/{1}/interests/{2}",
                        ValueConvert.ToPathParameterString(request.ListId),
                        ValueConvert.ToPathParameterString(request.InterestCategoryId),
                        ValueConvert.ToPathParameterString(request.InterestId)
                    ),
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
                var responseData = JsonUtils.Deserialize<Interest>(responseBody)!;
                return new WithRawResponse<Interest>()
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

    private async Task<RawResponse> DeleteInterestCategoryInterestAsyncCore(
        DeleteInterestCategoryInterestListsRequest request,
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
                    Method = HttpMethod.Delete,
                    Path = string.Format(
                        "3.0/lists/{0}/interest-categories/{1}/interests/{2}",
                        ValueConvert.ToPathParameterString(request.ListId),
                        ValueConvert.ToPathParameterString(request.InterestCategoryId),
                        ValueConvert.ToPathParameterString(request.InterestId)
                    ),
                    QueryString = _queryString,
                    Headers = _headers,
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

    private async Task<WithRawResponse<Interest>> UpdateInterestCategoryInterestAsyncCore(
        UpdateInterestCategoryInterestListsRequest request,
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
                    Method = HttpMethodExtensions.Patch,
                    Path = string.Format(
                        "3.0/lists/{0}/interest-categories/{1}/interests/{2}",
                        ValueConvert.ToPathParameterString(request.ListId),
                        ValueConvert.ToPathParameterString(request.InterestCategoryId),
                        ValueConvert.ToPathParameterString(request.InterestId)
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
            var responseBody = await response
                .Raw.Content.ReadAsStringAsync(cancellationToken)
                .ConfigureAwait(false);
            try
            {
                var responseData = JsonUtils.Deserialize<Interest>(responseBody)!;
                return new WithRawResponse<Interest>()
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

    private async Task<WithRawResponse<ListLocationsListsResponse>> ListLocationsAsyncCore(
        ListLocationsListsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _queryString = new Mailchimp.Marketing.Core.QueryStringBuilder.Builder(capacity: 2)
            .Add("fields", request.Fields)
            .Add("exclude_fields", request.ExcludeFields)
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
                    Path = string.Format(
                        "3.0/lists/{0}/locations",
                        ValueConvert.ToPathParameterString(request.ListId)
                    ),
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
                var responseData = JsonUtils.Deserialize<ListLocationsListsResponse>(responseBody)!;
                return new WithRawResponse<ListLocationsListsResponse>()
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
    /// Get information about members in a specific Mailchimp list.
    /// </summary>
    private WithRawResponseTask<ListMembersListsResponse> ListMembersInternalAsync(
        ListMembersListsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<ListMembersListsResponse>(
            ListMembersInternalAsyncCore(request, options, cancellationToken)
        );
    }

    private async Task<WithRawResponse<ListMembersListsResponse>> ListMembersInternalAsyncCore(
        ListMembersListsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _queryString = new Mailchimp.Marketing.Core.QueryStringBuilder.Builder(capacity: 19)
            .Add("fields", request.Fields)
            .Add("exclude_fields", request.ExcludeFields)
            .Add("count", request.Count)
            .Add("offset", request.Offset)
            .Add("email_type", request.EmailType)
            .Add("status", request.Status)
            .Add("since_timestamp_opt", request.SinceTimestampOpt)
            .Add("before_timestamp_opt", request.BeforeTimestampOpt)
            .Add("since_last_changed", request.SinceLastChanged)
            .Add("before_last_changed", request.BeforeLastChanged)
            .Add("unique_email_id", request.UniqueEmailId)
            .Add("vip_only", request.VipOnly)
            .Add("interest_category_id", request.InterestCategoryId)
            .Add("interest_ids", request.InterestIds)
            .Add("interest_match", request.InterestMatch)
            .Add("sort_field", request.SortField)
            .Add("sort_dir", request.SortDir)
            .Add("since_last_campaign", request.SinceLastCampaign)
            .Add("unsubscribed_since", request.UnsubscribedSince)
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
                    Path = string.Format(
                        "3.0/lists/{0}/members",
                        ValueConvert.ToPathParameterString(request.ListId)
                    ),
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
                var responseData = JsonUtils.Deserialize<ListMembersListsResponse>(responseBody)!;
                return new WithRawResponse<ListMembersListsResponse>()
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

    private async Task<WithRawResponse<ListMembers>> CreateMemberAsyncCore(
        CreateMemberListsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _queryString = new Mailchimp.Marketing.Core.QueryStringBuilder.Builder(capacity: 1)
            .Add("skip_merge_validation", request.SkipMergeValidation)
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
                        "3.0/lists/{0}/members",
                        ValueConvert.ToPathParameterString(request.ListId)
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
            var responseBody = await response
                .Raw.Content.ReadAsStringAsync(cancellationToken)
                .ConfigureAwait(false);
            try
            {
                var responseData = JsonUtils.Deserialize<ListMembers>(responseBody)!;
                return new WithRawResponse<ListMembers>()
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

    private async Task<WithRawResponse<ListMembers>> GetMemberAsyncCore(
        GetMemberListsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _queryString = new Mailchimp.Marketing.Core.QueryStringBuilder.Builder(capacity: 2)
            .Add("fields", request.Fields)
            .Add("exclude_fields", request.ExcludeFields)
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
                    Path = string.Format(
                        "3.0/lists/{0}/members/{1}",
                        ValueConvert.ToPathParameterString(request.ListId),
                        ValueConvert.ToPathParameterString(request.SubscriberHash)
                    ),
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
                var responseData = JsonUtils.Deserialize<ListMembers>(responseBody)!;
                return new WithRawResponse<ListMembers>()
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

    private async Task<WithRawResponse<ListMembers>> UpsertMemberAsyncCore(
        UpsertMemberListsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _queryString = new Mailchimp.Marketing.Core.QueryStringBuilder.Builder(capacity: 1)
            .Add("skip_merge_validation", request.SkipMergeValidation)
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
                    Method = HttpMethod.Put,
                    Path = string.Format(
                        "3.0/lists/{0}/members/{1}",
                        ValueConvert.ToPathParameterString(request.ListId),
                        ValueConvert.ToPathParameterString(request.SubscriberHash)
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
            var responseBody = await response
                .Raw.Content.ReadAsStringAsync(cancellationToken)
                .ConfigureAwait(false);
            try
            {
                var responseData = JsonUtils.Deserialize<ListMembers>(responseBody)!;
                return new WithRawResponse<ListMembers>()
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

    private async Task<RawResponse> DeleteMemberAsyncCore(
        DeleteMemberListsRequest request,
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
                    Method = HttpMethod.Delete,
                    Path = string.Format(
                        "3.0/lists/{0}/members/{1}",
                        ValueConvert.ToPathParameterString(request.ListId),
                        ValueConvert.ToPathParameterString(request.SubscriberHash)
                    ),
                    QueryString = _queryString,
                    Headers = _headers,
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

    private async Task<WithRawResponse<ListMembers>> UpdateMemberAsyncCore(
        UpdateMemberListsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _queryString = new Mailchimp.Marketing.Core.QueryStringBuilder.Builder(capacity: 1)
            .Add("skip_merge_validation", request.SkipMergeValidation)
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
                    Method = HttpMethodExtensions.Patch,
                    Path = string.Format(
                        "3.0/lists/{0}/members/{1}",
                        ValueConvert.ToPathParameterString(request.ListId),
                        ValueConvert.ToPathParameterString(request.SubscriberHash)
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
            var responseBody = await response
                .Raw.Content.ReadAsStringAsync(cancellationToken)
                .ConfigureAwait(false);
            try
            {
                var responseData = JsonUtils.Deserialize<ListMembers>(responseBody)!;
                return new WithRawResponse<ListMembers>()
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

    private async Task<RawResponse> CreateMemberActionDeletePermanentAsyncCore(
        CreateMemberActionDeletePermanentListsRequest request,
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
                        "3.0/lists/{0}/members/{1}/actions/delete-permanent",
                        ValueConvert.ToPathParameterString(request.ListId),
                        ValueConvert.ToPathParameterString(request.SubscriberHash)
                    ),
                    QueryString = _queryString,
                    Headers = _headers,
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

    private async Task<
        WithRawResponse<ListMemberActivityListsResponse>
    > ListMemberActivityAsyncCore(
        ListMemberActivityListsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _queryString = new Mailchimp.Marketing.Core.QueryStringBuilder.Builder(capacity: 3)
            .Add("fields", request.Fields)
            .Add("exclude_fields", request.ExcludeFields)
            .Add("action", request.Action)
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
                    Path = string.Format(
                        "3.0/lists/{0}/members/{1}/activity",
                        ValueConvert.ToPathParameterString(request.ListId),
                        ValueConvert.ToPathParameterString(request.SubscriberHash)
                    ),
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
                var responseData = JsonUtils.Deserialize<ListMemberActivityListsResponse>(
                    responseBody
                )!;
                return new WithRawResponse<ListMemberActivityListsResponse>()
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
    /// Get a member's activity on a specific list, including opens, clicks, and unsubscribes.
    /// </summary>
    private WithRawResponseTask<ListMemberActivityFeedListsResponse> ListMemberActivityFeedInternalAsync(
        ListMemberActivityFeedListsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<ListMemberActivityFeedListsResponse>(
            ListMemberActivityFeedInternalAsyncCore(request, options, cancellationToken)
        );
    }

    private async Task<
        WithRawResponse<ListMemberActivityFeedListsResponse>
    > ListMemberActivityFeedInternalAsyncCore(
        ListMemberActivityFeedListsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _queryString = new Mailchimp.Marketing.Core.QueryStringBuilder.Builder(capacity: 5)
            .Add("fields", request.Fields)
            .Add("exclude_fields", request.ExcludeFields)
            .Add("count", request.Count)
            .Add("offset", request.Offset)
            .Add("activity_filters", request.ActivityFilters)
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
                    Path = string.Format(
                        "3.0/lists/{0}/members/{1}/activity-feed",
                        ValueConvert.ToPathParameterString(request.ListId),
                        ValueConvert.ToPathParameterString(request.SubscriberHash)
                    ),
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
                var responseData = JsonUtils.Deserialize<ListMemberActivityFeedListsResponse>(
                    responseBody
                )!;
                return new WithRawResponse<ListMemberActivityFeedListsResponse>()
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
    /// Get events for a contact.
    /// </summary>
    private WithRawResponseTask<ListMemberEventsListsResponse> ListMemberEventsInternalAsync(
        ListMemberEventsListsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<ListMemberEventsListsResponse>(
            ListMemberEventsInternalAsyncCore(request, options, cancellationToken)
        );
    }

    private async Task<
        WithRawResponse<ListMemberEventsListsResponse>
    > ListMemberEventsInternalAsyncCore(
        ListMemberEventsListsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _queryString = new Mailchimp.Marketing.Core.QueryStringBuilder.Builder(capacity: 4)
            .Add("count", request.Count)
            .Add("offset", request.Offset)
            .Add("fields", request.Fields)
            .Add("exclude_fields", request.ExcludeFields)
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
                    Path = string.Format(
                        "3.0/lists/{0}/members/{1}/events",
                        ValueConvert.ToPathParameterString(request.ListId),
                        ValueConvert.ToPathParameterString(request.SubscriberHash)
                    ),
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
                var responseData = JsonUtils.Deserialize<ListMemberEventsListsResponse>(
                    responseBody
                )!;
                return new WithRawResponse<ListMemberEventsListsResponse>()
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

    private async Task<RawResponse> CreateMemberEventAsyncCore(
        CreateMemberEventListsRequest request,
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
                        "3.0/lists/{0}/members/{1}/events",
                        ValueConvert.ToPathParameterString(request.ListId),
                        ValueConvert.ToPathParameterString(request.SubscriberHash)
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

    private async Task<WithRawResponse<ListMemberGoalsListsResponse>> ListMemberGoalsAsyncCore(
        ListMemberGoalsListsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _queryString = new Mailchimp.Marketing.Core.QueryStringBuilder.Builder(capacity: 2)
            .Add("fields", request.Fields)
            .Add("exclude_fields", request.ExcludeFields)
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
                    Path = string.Format(
                        "3.0/lists/{0}/members/{1}/goals",
                        ValueConvert.ToPathParameterString(request.ListId),
                        ValueConvert.ToPathParameterString(request.SubscriberHash)
                    ),
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
                var responseData = JsonUtils.Deserialize<ListMemberGoalsListsResponse>(
                    responseBody
                )!;
                return new WithRawResponse<ListMemberGoalsListsResponse>()
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
    /// Get recent notes for a specific list member.
    /// </summary>
    private WithRawResponseTask<ListMemberNotesListsResponse> ListMemberNotesInternalAsync(
        ListMemberNotesListsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<ListMemberNotesListsResponse>(
            ListMemberNotesInternalAsyncCore(request, options, cancellationToken)
        );
    }

    private async Task<
        WithRawResponse<ListMemberNotesListsResponse>
    > ListMemberNotesInternalAsyncCore(
        ListMemberNotesListsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _queryString = new Mailchimp.Marketing.Core.QueryStringBuilder.Builder(capacity: 6)
            .Add("sort_field", request.SortField)
            .Add("sort_dir", request.SortDir)
            .Add("fields", request.Fields)
            .Add("exclude_fields", request.ExcludeFields)
            .Add("count", request.Count)
            .Add("offset", request.Offset)
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
                    Path = string.Format(
                        "3.0/lists/{0}/members/{1}/notes",
                        ValueConvert.ToPathParameterString(request.ListId),
                        ValueConvert.ToPathParameterString(request.SubscriberHash)
                    ),
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
                var responseData = JsonUtils.Deserialize<ListMemberNotesListsResponse>(
                    responseBody
                )!;
                return new WithRawResponse<ListMemberNotesListsResponse>()
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

    private async Task<WithRawResponse<MemberNotes>> CreateMemberNoteAsyncCore(
        CreateMemberNoteListsRequest request,
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
                        "3.0/lists/{0}/members/{1}/notes",
                        ValueConvert.ToPathParameterString(request.ListId),
                        ValueConvert.ToPathParameterString(request.SubscriberHash)
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
            var responseBody = await response
                .Raw.Content.ReadAsStringAsync(cancellationToken)
                .ConfigureAwait(false);
            try
            {
                var responseData = JsonUtils.Deserialize<MemberNotes>(responseBody)!;
                return new WithRawResponse<MemberNotes>()
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

    private async Task<WithRawResponse<MemberNotes>> GetMemberNoteAsyncCore(
        GetMemberNoteListsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _queryString = new Mailchimp.Marketing.Core.QueryStringBuilder.Builder(capacity: 2)
            .Add("fields", request.Fields)
            .Add("exclude_fields", request.ExcludeFields)
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
                    Path = string.Format(
                        "3.0/lists/{0}/members/{1}/notes/{2}",
                        ValueConvert.ToPathParameterString(request.ListId),
                        ValueConvert.ToPathParameterString(request.SubscriberHash),
                        ValueConvert.ToPathParameterString(request.NoteId)
                    ),
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
                var responseData = JsonUtils.Deserialize<MemberNotes>(responseBody)!;
                return new WithRawResponse<MemberNotes>()
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

    private async Task<RawResponse> DeleteMemberNoteAsyncCore(
        DeleteMemberNoteListsRequest request,
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
                    Method = HttpMethod.Delete,
                    Path = string.Format(
                        "3.0/lists/{0}/members/{1}/notes/{2}",
                        ValueConvert.ToPathParameterString(request.ListId),
                        ValueConvert.ToPathParameterString(request.SubscriberHash),
                        ValueConvert.ToPathParameterString(request.NoteId)
                    ),
                    QueryString = _queryString,
                    Headers = _headers,
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

    private async Task<WithRawResponse<MemberNotes>> UpdateMemberNoteAsyncCore(
        UpdateMemberNoteListsRequest request,
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
                    Method = HttpMethodExtensions.Patch,
                    Path = string.Format(
                        "3.0/lists/{0}/members/{1}/notes/{2}",
                        ValueConvert.ToPathParameterString(request.ListId),
                        ValueConvert.ToPathParameterString(request.SubscriberHash),
                        ValueConvert.ToPathParameterString(request.NoteId)
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
            var responseBody = await response
                .Raw.Content.ReadAsStringAsync(cancellationToken)
                .ConfigureAwait(false);
            try
            {
                var responseData = JsonUtils.Deserialize<MemberNotes>(responseBody)!;
                return new WithRawResponse<MemberNotes>()
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
    /// Get the tags on a list member.
    /// </summary>
    private WithRawResponseTask<ListMemberTagsListsResponse> ListMemberTagsInternalAsync(
        ListMemberTagsListsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<ListMemberTagsListsResponse>(
            ListMemberTagsInternalAsyncCore(request, options, cancellationToken)
        );
    }

    private async Task<
        WithRawResponse<ListMemberTagsListsResponse>
    > ListMemberTagsInternalAsyncCore(
        ListMemberTagsListsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _queryString = new Mailchimp.Marketing.Core.QueryStringBuilder.Builder(capacity: 4)
            .Add("fields", request.Fields)
            .Add("exclude_fields", request.ExcludeFields)
            .Add("count", request.Count)
            .Add("offset", request.Offset)
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
                    Path = string.Format(
                        "3.0/lists/{0}/members/{1}/tags",
                        ValueConvert.ToPathParameterString(request.ListId),
                        ValueConvert.ToPathParameterString(request.SubscriberHash)
                    ),
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
                var responseData = JsonUtils.Deserialize<ListMemberTagsListsResponse>(
                    responseBody
                )!;
                return new WithRawResponse<ListMemberTagsListsResponse>()
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

    private async Task<RawResponse> CreateMemberTagAsyncCore(
        CreateMemberTagListsRequest request,
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
                        "3.0/lists/{0}/members/{1}/tags",
                        ValueConvert.ToPathParameterString(request.ListId),
                        ValueConvert.ToPathParameterString(request.SubscriberHash)
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
    /// Get a list of all merge fields for an audience.
    /// </summary>
    private WithRawResponseTask<ListMergeFieldsListsResponse> ListMergeFieldsInternalAsync(
        ListMergeFieldsListsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<ListMergeFieldsListsResponse>(
            ListMergeFieldsInternalAsyncCore(request, options, cancellationToken)
        );
    }

    private async Task<
        WithRawResponse<ListMergeFieldsListsResponse>
    > ListMergeFieldsInternalAsyncCore(
        ListMergeFieldsListsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _queryString = new Mailchimp.Marketing.Core.QueryStringBuilder.Builder(capacity: 6)
            .Add("fields", request.Fields)
            .Add("exclude_fields", request.ExcludeFields)
            .Add("count", request.Count)
            .Add("offset", request.Offset)
            .Add("type", request.Type)
            .Add("required", request.Required)
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
                    Path = string.Format(
                        "3.0/lists/{0}/merge-fields",
                        ValueConvert.ToPathParameterString(request.ListId)
                    ),
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
                var responseData = JsonUtils.Deserialize<ListMergeFieldsListsResponse>(
                    responseBody
                )!;
                return new WithRawResponse<ListMergeFieldsListsResponse>()
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

    private async Task<WithRawResponse<MergeField>> CreateMergeFieldAsyncCore(
        CreateMergeFieldListsRequest request,
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
                        "3.0/lists/{0}/merge-fields",
                        ValueConvert.ToPathParameterString(request.ListId)
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
            var responseBody = await response
                .Raw.Content.ReadAsStringAsync(cancellationToken)
                .ConfigureAwait(false);
            try
            {
                var responseData = JsonUtils.Deserialize<MergeField>(responseBody)!;
                return new WithRawResponse<MergeField>()
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

    private async Task<WithRawResponse<MergeField>> GetMergeFieldAsyncCore(
        GetMergeFieldListsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _queryString = new Mailchimp.Marketing.Core.QueryStringBuilder.Builder(capacity: 2)
            .Add("exclude_fields", request.ExcludeFields)
            .Add("fields", request.Fields)
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
                    Path = string.Format(
                        "3.0/lists/{0}/merge-fields/{1}",
                        ValueConvert.ToPathParameterString(request.ListId),
                        ValueConvert.ToPathParameterString(request.MergeId)
                    ),
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
                var responseData = JsonUtils.Deserialize<MergeField>(responseBody)!;
                return new WithRawResponse<MergeField>()
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

    private async Task<RawResponse> DeleteMergeFieldAsyncCore(
        DeleteMergeFieldListsRequest request,
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
                    Method = HttpMethod.Delete,
                    Path = string.Format(
                        "3.0/lists/{0}/merge-fields/{1}",
                        ValueConvert.ToPathParameterString(request.ListId),
                        ValueConvert.ToPathParameterString(request.MergeId)
                    ),
                    QueryString = _queryString,
                    Headers = _headers,
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

    private async Task<WithRawResponse<MergeField>> UpdateMergeFieldAsyncCore(
        UpdateMergeFieldListsRequest request,
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
                    Method = HttpMethodExtensions.Patch,
                    Path = string.Format(
                        "3.0/lists/{0}/merge-fields/{1}",
                        ValueConvert.ToPathParameterString(request.ListId),
                        ValueConvert.ToPathParameterString(request.MergeId)
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
            var responseBody = await response
                .Raw.Content.ReadAsStringAsync(cancellationToken)
                .ConfigureAwait(false);
            try
            {
                var responseData = JsonUtils.Deserialize<MergeField>(responseBody)!;
                return new WithRawResponse<MergeField>()
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
    /// Get information about all available segments for a specific list.
    /// </summary>
    private WithRawResponseTask<ListSegmentsListsResponse> ListSegmentsInternalAsync(
        ListSegmentsListsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<ListSegmentsListsResponse>(
            ListSegmentsInternalAsyncCore(request, options, cancellationToken)
        );
    }

    private async Task<WithRawResponse<ListSegmentsListsResponse>> ListSegmentsInternalAsyncCore(
        ListSegmentsListsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _queryString = new Mailchimp.Marketing.Core.QueryStringBuilder.Builder(capacity: 13)
            .Add("fields", request.Fields)
            .Add("exclude_fields", request.ExcludeFields)
            .Add("count", request.Count)
            .Add("offset", request.Offset)
            .Add("type", request.Type)
            .Add("since_created_at", request.SinceCreatedAt)
            .Add("before_created_at", request.BeforeCreatedAt)
            .Add("include_cleaned", request.IncludeCleaned)
            .Add("include_transactional", request.IncludeTransactional)
            .Add("include_unsubscribed", request.IncludeUnsubscribed)
            .Add("since_updated_at", request.SinceUpdatedAt)
            .Add("before_updated_at", request.BeforeUpdatedAt)
            .Add("exclude_type", request.ExcludeType)
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
                    Path = string.Format(
                        "3.0/lists/{0}/segments",
                        ValueConvert.ToPathParameterString(request.ListId)
                    ),
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
                var responseData = JsonUtils.Deserialize<ListSegmentsListsResponse>(responseBody)!;
                return new WithRawResponse<ListSegmentsListsResponse>()
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

    private async Task<WithRawResponse<List>> CreateSegmentAsyncCore(
        CreateSegmentListsRequest request,
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
                        "3.0/lists/{0}/segments",
                        ValueConvert.ToPathParameterString(request.ListId)
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
            var responseBody = await response
                .Raw.Content.ReadAsStringAsync(cancellationToken)
                .ConfigureAwait(false);
            try
            {
                var responseData = JsonUtils.Deserialize<List>(responseBody)!;
                return new WithRawResponse<List>()
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

    private async Task<WithRawResponse<List>> GetSegmentAsyncCore(
        GetSegmentListsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _queryString = new Mailchimp.Marketing.Core.QueryStringBuilder.Builder(capacity: 5)
            .Add("fields", request.Fields)
            .Add("exclude_fields", request.ExcludeFields)
            .Add("include_cleaned", request.IncludeCleaned)
            .Add("include_transactional", request.IncludeTransactional)
            .Add("include_unsubscribed", request.IncludeUnsubscribed)
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
                    Path = string.Format(
                        "3.0/lists/{0}/segments/{1}",
                        ValueConvert.ToPathParameterString(request.ListId),
                        ValueConvert.ToPathParameterString(request.SegmentId)
                    ),
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
                var responseData = JsonUtils.Deserialize<List>(responseBody)!;
                return new WithRawResponse<List>()
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

    private async Task<
        WithRawResponse<BatchAddOrRemoveMembersListsResponse>
    > BatchAddOrRemoveMembersAsyncCore(
        BatchAddOrRemoveMembersListsRequest request,
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
                        "3.0/lists/{0}/segments/{1}",
                        ValueConvert.ToPathParameterString(request.ListId),
                        ValueConvert.ToPathParameterString(request.SegmentId)
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
            var responseBody = await response
                .Raw.Content.ReadAsStringAsync(cancellationToken)
                .ConfigureAwait(false);
            try
            {
                var responseData = JsonUtils.Deserialize<BatchAddOrRemoveMembersListsResponse>(
                    responseBody
                )!;
                return new WithRawResponse<BatchAddOrRemoveMembersListsResponse>()
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

    private async Task<RawResponse> DeleteSegmentAsyncCore(
        DeleteSegmentListsRequest request,
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
                    Method = HttpMethod.Delete,
                    Path = string.Format(
                        "3.0/lists/{0}/segments/{1}",
                        ValueConvert.ToPathParameterString(request.ListId),
                        ValueConvert.ToPathParameterString(request.SegmentId)
                    ),
                    QueryString = _queryString,
                    Headers = _headers,
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

    private async Task<WithRawResponse<List>> UpdateSegmentAsyncCore(
        UpdateSegmentListsRequest request,
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
                    Method = HttpMethodExtensions.Patch,
                    Path = string.Format(
                        "3.0/lists/{0}/segments/{1}",
                        ValueConvert.ToPathParameterString(request.ListId),
                        ValueConvert.ToPathParameterString(request.SegmentId)
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
            var responseBody = await response
                .Raw.Content.ReadAsStringAsync(cancellationToken)
                .ConfigureAwait(false);
            try
            {
                var responseData = JsonUtils.Deserialize<List>(responseBody)!;
                return new WithRawResponse<List>()
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
    /// Get information about members in a saved segment.
    /// </summary>
    private WithRawResponseTask<ListSegmentMembersListsResponse> ListSegmentMembersInternalAsync(
        ListSegmentMembersListsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<ListSegmentMembersListsResponse>(
            ListSegmentMembersInternalAsyncCore(request, options, cancellationToken)
        );
    }

    private async Task<
        WithRawResponse<ListSegmentMembersListsResponse>
    > ListSegmentMembersInternalAsyncCore(
        ListSegmentMembersListsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _queryString = new Mailchimp.Marketing.Core.QueryStringBuilder.Builder(capacity: 7)
            .Add("fields", request.Fields)
            .Add("exclude_fields", request.ExcludeFields)
            .Add("count", request.Count)
            .Add("offset", request.Offset)
            .Add("include_cleaned", request.IncludeCleaned)
            .Add("include_transactional", request.IncludeTransactional)
            .Add("include_unsubscribed", request.IncludeUnsubscribed)
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
                    Path = string.Format(
                        "3.0/lists/{0}/segments/{1}/members",
                        ValueConvert.ToPathParameterString(request.ListId),
                        ValueConvert.ToPathParameterString(request.SegmentId)
                    ),
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
                var responseData = JsonUtils.Deserialize<ListSegmentMembersListsResponse>(
                    responseBody
                )!;
                return new WithRawResponse<ListSegmentMembersListsResponse>()
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

    private async Task<WithRawResponse<ListsSegmentsMembers>> CreateSegmentMemberAsyncCore(
        CreateSegmentMemberListsRequest request,
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
                        "3.0/lists/{0}/segments/{1}/members",
                        ValueConvert.ToPathParameterString(request.ListId),
                        ValueConvert.ToPathParameterString(request.SegmentId)
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
            var responseBody = await response
                .Raw.Content.ReadAsStringAsync(cancellationToken)
                .ConfigureAwait(false);
            try
            {
                var responseData = JsonUtils.Deserialize<ListsSegmentsMembers>(responseBody)!;
                return new WithRawResponse<ListsSegmentsMembers>()
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

    private async Task<RawResponse> DeleteSegmentMemberAsyncCore(
        DeleteSegmentMemberListsRequest request,
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
                    Method = HttpMethod.Delete,
                    Path = string.Format(
                        "3.0/lists/{0}/segments/{1}/members/{2}",
                        ValueConvert.ToPathParameterString(request.ListId),
                        ValueConvert.ToPathParameterString(request.SegmentId),
                        ValueConvert.ToPathParameterString(request.SubscriberHash)
                    ),
                    QueryString = _queryString,
                    Headers = _headers,
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

    private async Task<WithRawResponse<ListSignupFormsListsResponse>> ListSignupFormsAsyncCore(
        ListSignupFormsListsRequest request,
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
                    Method = HttpMethod.Get,
                    Path = string.Format(
                        "3.0/lists/{0}/signup-forms",
                        ValueConvert.ToPathParameterString(request.ListId)
                    ),
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
                var responseData = JsonUtils.Deserialize<ListSignupFormsListsResponse>(
                    responseBody
                )!;
                return new WithRawResponse<ListSignupFormsListsResponse>()
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

    private async Task<WithRawResponse<SignupForm>> CreateSignupFormAsyncCore(
        CreateSignupFormListsRequest request,
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
                        "3.0/lists/{0}/signup-forms",
                        ValueConvert.ToPathParameterString(request.ListId)
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
            var responseBody = await response
                .Raw.Content.ReadAsStringAsync(cancellationToken)
                .ConfigureAwait(false);
            try
            {
                var responseData = JsonUtils.Deserialize<SignupForm>(responseBody)!;
                return new WithRawResponse<SignupForm>()
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

    private async Task<WithRawResponse<object>> ListSurveysAsyncCore(
        ListSurveysListsRequest request,
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
                    Method = HttpMethod.Get,
                    Path = string.Format(
                        "3.0/lists/{0}/surveys",
                        ValueConvert.ToPathParameterString(request.ListId)
                    ),
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
                var responseData = JsonUtils.Deserialize<object>(responseBody)!;
                return new WithRawResponse<object>()
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

    private async Task<WithRawResponse<object>> CreateSurveyAsyncCore(
        CreateSurveyListsRequest request,
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
                        "3.0/lists/{0}/surveys",
                        ValueConvert.ToPathParameterString(request.ListId)
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
            var responseBody = await response
                .Raw.Content.ReadAsStringAsync(cancellationToken)
                .ConfigureAwait(false);
            try
            {
                var responseData = JsonUtils.Deserialize<object>(responseBody)!;
                return new WithRawResponse<object>()
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

    private async Task<WithRawResponse<object>> GetSurveyAsyncCore(
        GetSurveyListsRequest request,
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
                    Method = HttpMethod.Get,
                    Path = string.Format(
                        "3.0/lists/{0}/surveys/{1}",
                        ValueConvert.ToPathParameterString(request.ListId),
                        ValueConvert.ToPathParameterString(request.SurveyId)
                    ),
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
                var responseData = JsonUtils.Deserialize<object>(responseBody)!;
                return new WithRawResponse<object>()
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

    private async Task<RawResponse> DeleteSurveyAsyncCore(
        DeleteSurveyListsRequest request,
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
                    Method = HttpMethod.Delete,
                    Path = string.Format(
                        "3.0/lists/{0}/surveys/{1}",
                        ValueConvert.ToPathParameterString(request.ListId),
                        ValueConvert.ToPathParameterString(request.SurveyId)
                    ),
                    QueryString = _queryString,
                    Headers = _headers,
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

    private async Task<WithRawResponse<object>> UpdateSurveyAsyncCore(
        UpdateSurveyListsRequest request,
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
                    Method = HttpMethodExtensions.Patch,
                    Path = string.Format(
                        "3.0/lists/{0}/surveys/{1}",
                        ValueConvert.ToPathParameterString(request.ListId),
                        ValueConvert.ToPathParameterString(request.SurveyId)
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
            var responseBody = await response
                .Raw.Content.ReadAsStringAsync(cancellationToken)
                .ConfigureAwait(false);
            try
            {
                var responseData = JsonUtils.Deserialize<object>(responseBody)!;
                return new WithRawResponse<object>()
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

    private async Task<WithRawResponse<object>> CreateListSurveyActionReplicateAsyncCore(
        CreateListSurveyActionReplicateListsRequest request,
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
                        "3.0/lists/{0}/surveys/{1}/actions/replicate",
                        ValueConvert.ToPathParameterString(request.ListIdPathParam),
                        ValueConvert.ToPathParameterString(request.SurveyId)
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
            var responseBody = await response
                .Raw.Content.ReadAsStringAsync(cancellationToken)
                .ConfigureAwait(false);
            try
            {
                var responseData = JsonUtils.Deserialize<object>(responseBody)!;
                return new WithRawResponse<object>()
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

    private async Task<WithRawResponse<ListTagSearchListsResponse>> ListTagSearchAsyncCore(
        ListTagSearchListsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _queryString = new Mailchimp.Marketing.Core.QueryStringBuilder.Builder(capacity: 1)
            .Add("name", request.Name)
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
                    Path = string.Format(
                        "3.0/lists/{0}/tag-search",
                        ValueConvert.ToPathParameterString(request.ListId)
                    ),
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
                var responseData = JsonUtils.Deserialize<ListTagSearchListsResponse>(responseBody)!;
                return new WithRawResponse<ListTagSearchListsResponse>()
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

    private async Task<WithRawResponse<ListWebhooksListsResponse>> ListWebhooksAsyncCore(
        ListWebhooksListsRequest request,
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
                    Method = HttpMethod.Get,
                    Path = string.Format(
                        "3.0/lists/{0}/webhooks",
                        ValueConvert.ToPathParameterString(request.ListId)
                    ),
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
                var responseData = JsonUtils.Deserialize<ListWebhooksListsResponse>(responseBody)!;
                return new WithRawResponse<ListWebhooksListsResponse>()
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

    private async Task<WithRawResponse<CreateWebhookListsResponse>> CreateWebhookAsyncCore(
        CreateWebhookListsRequest request,
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
                        "3.0/lists/{0}/webhooks",
                        ValueConvert.ToPathParameterString(request.ListId)
                    ),
                    Body = request.Body,
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
            var responseBody = await response
                .Raw.Content.ReadAsStringAsync(cancellationToken)
                .ConfigureAwait(false);
            try
            {
                var responseData = JsonUtils.Deserialize<CreateWebhookListsResponse>(responseBody)!;
                return new WithRawResponse<CreateWebhookListsResponse>()
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

    private async Task<WithRawResponse<ListWebhooks>> GetWebhookAsyncCore(
        GetWebhookListsRequest request,
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
                    Method = HttpMethod.Get,
                    Path = string.Format(
                        "3.0/lists/{0}/webhooks/{1}",
                        ValueConvert.ToPathParameterString(request.ListId),
                        ValueConvert.ToPathParameterString(request.WebhookId)
                    ),
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
                var responseData = JsonUtils.Deserialize<ListWebhooks>(responseBody)!;
                return new WithRawResponse<ListWebhooks>()
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

    private async Task<RawResponse> DeleteWebhookAsyncCore(
        DeleteWebhookListsRequest request,
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
                    Method = HttpMethod.Delete,
                    Path = string.Format(
                        "3.0/lists/{0}/webhooks/{1}",
                        ValueConvert.ToPathParameterString(request.ListId),
                        ValueConvert.ToPathParameterString(request.WebhookId)
                    ),
                    QueryString = _queryString,
                    Headers = _headers,
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

    private async Task<WithRawResponse<ListWebhooks>> UpdateWebhookAsyncCore(
        UpdateWebhookListsRequest request,
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
                    Method = HttpMethodExtensions.Patch,
                    Path = string.Format(
                        "3.0/lists/{0}/webhooks/{1}",
                        ValueConvert.ToPathParameterString(request.ListId),
                        ValueConvert.ToPathParameterString(request.WebhookId)
                    ),
                    Body = request.Body,
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
            var responseBody = await response
                .Raw.Content.ReadAsStringAsync(cancellationToken)
                .ConfigureAwait(false);
            try
            {
                var responseData = JsonUtils.Deserialize<ListWebhooks>(responseBody)!;
                return new WithRawResponse<ListWebhooks>()
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
    /// Get information about all lists in the account.
    /// </summary>
    /// <example><code>
    /// await client.Lists.ListAsync(new ListListsRequest());
    /// </code></example>
    public async Task<Pager<SubscriberList>> ListAsync(
        ListListsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        request = request with { };
        var pager = await OffsetPager<
            ListListsRequest,
            RequestOptions?,
            ListListsResponse,
            int,
            object,
            SubscriberList
        >
            .CreateInstanceAsync(
                request,
                options,
                async (request, options, cancellationToken) =>
                    await ListInternalAsync(request, options, cancellationToken).WithRawResponse(),
                request => request.Offset ?? 0,
                (request, offset) =>
                {
                    request.Offset = offset;
                },
                null,
                response => response.Lists?.ToList(),
                null,
                cancellationToken
            )
            .ConfigureAwait(false);
        return pager;
    }

    /// <summary>
    /// Create a new list in your Mailchimp account.
    /// </summary>
    /// <example><code>
    /// await client.Lists.CreateAsync(
    ///     new CreateListsRequest
    ///     {
    ///         CampaignDefaults = new CreateListsRequestCampaignDefaults
    ///         {
    ///             FromEmail = "from_email",
    ///             FromName = "from_name",
    ///             Language = "language",
    ///             Subject = "subject",
    ///         },
    ///         Contact = new CreateListsRequestContact
    ///         {
    ///             Address1 = "address1",
    ///             City = "city",
    ///             Company = "company",
    ///             Country = "country",
    ///         },
    ///         EmailTypeOption = true,
    ///         Name = "name",
    ///         PermissionReminder = "permission_reminder",
    ///     }
    /// );
    /// </code></example>
    public WithRawResponseTask<SubscriberList> CreateAsync(
        CreateListsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<SubscriberList>(
            CreateAsyncCore(request, options, cancellationToken)
        );
    }

    /// <summary>
    /// Get information about a specific list in your Mailchimp account. Results include list members who have signed up but haven't confirmed their subscription yet and unsubscribed or cleaned.
    /// </summary>
    /// <example><code>
    /// await client.Lists.GetAsync(new GetListsRequest { ListId = "list_id" });
    /// </code></example>
    public WithRawResponseTask<SubscriberList> GetAsync(
        GetListsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<SubscriberList>(
            GetAsyncCore(request, options, cancellationToken)
        );
    }

    /// <summary>
    /// Batch subscribe or unsubscribe list members.
    /// </summary>
    /// <example><code>
    /// await client.Lists.BatchSubscribeOrUnsubscribeAsync(
    ///     new BatchSubscribeOrUnsubscribeListsRequest
    ///     {
    ///         ListId = "list_id",
    ///         Members = new global::System.Collections.Generic.List&lt;OneOf&lt;object&gt;&gt;() { },
    ///     }
    /// );
    /// </code></example>
    public WithRawResponseTask<BatchSubscribeOrUnsubscribeListsResponse> BatchSubscribeOrUnsubscribeAsync(
        BatchSubscribeOrUnsubscribeListsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<BatchSubscribeOrUnsubscribeListsResponse>(
            BatchSubscribeOrUnsubscribeAsyncCore(request, options, cancellationToken)
        );
    }

    /// <summary>
    /// Delete a list from your Mailchimp account. If you delete a list, you'll lose the list history—including subscriber activity, unsubscribes, complaints, and bounces. You’ll also lose subscribers’ email addresses, unless you exported and backed up your list.
    /// </summary>
    /// <example><code>
    /// await client.Lists.DeleteAsync(new DeleteListsRequest { ListId = "list_id" });
    /// </code></example>
    public WithRawResponseTask DeleteAsync(
        DeleteListsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask(DeleteAsyncCore(request, options, cancellationToken));
    }

    /// <summary>
    /// Update the settings for a specific list.
    /// </summary>
    /// <example><code>
    /// await client.Lists.UpdateAsync(new UpdateListsRequest { ListId = "list_id" });
    /// </code></example>
    public WithRawResponseTask<SubscriberList> UpdateAsync(
        UpdateListsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<SubscriberList>(
            UpdateAsyncCore(request, options, cancellationToken)
        );
    }

    /// <summary>
    /// Get all abuse reports for a specific list.
    /// </summary>
    /// <example><code>
    /// await client.Lists.ListAbuseReportsAsync(new ListAbuseReportsListsRequest { ListId = "list_id" });
    /// </code></example>
    public async Task<Pager<ListsAbuseReports>> ListAbuseReportsAsync(
        ListAbuseReportsListsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        request = request with { };
        var pager = await OffsetPager<
            ListAbuseReportsListsRequest,
            RequestOptions?,
            ListAbuseReportsListsResponse,
            int,
            object,
            ListsAbuseReports
        >
            .CreateInstanceAsync(
                request,
                options,
                async (request, options, cancellationToken) =>
                    await ListAbuseReportsInternalAsync(request, options, cancellationToken)
                        .WithRawResponse(),
                request => request.Offset ?? 0,
                (request, offset) =>
                {
                    request.Offset = offset;
                },
                null,
                response => response.AbuseReports?.ToList(),
                null,
                cancellationToken
            )
            .ConfigureAwait(false);
        return pager;
    }

    /// <summary>
    /// Get details about a specific abuse report.
    /// </summary>
    /// <example><code>
    /// await client.Lists.GetAbuseReportAsync(
    ///     new GetAbuseReportListsRequest { ListId = "list_id", ReportId = "report_id" }
    /// );
    /// </code></example>
    public WithRawResponseTask<ListsAbuseReports> GetAbuseReportAsync(
        GetAbuseReportListsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<ListsAbuseReports>(
            GetAbuseReportAsyncCore(request, options, cancellationToken)
        );
    }

    /// <summary>
    /// Get up to the previous 180 days of daily detailed aggregated activity stats for a list, not including Automation activity.
    /// </summary>
    /// <example><code>
    /// await client.Lists.ListActivityAsync(new ListActivityListsRequest { ListId = "list_id" });
    /// </code></example>
    public async Task<Pager<ListActivityListsResponseActivityItem>> ListActivityAsync(
        ListActivityListsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        request = request with { };
        var pager = await OffsetPager<
            ListActivityListsRequest,
            RequestOptions?,
            ListActivityListsResponse,
            int,
            object,
            ListActivityListsResponseActivityItem
        >
            .CreateInstanceAsync(
                request,
                options,
                async (request, options, cancellationToken) =>
                    await ListActivityInternalAsync(request, options, cancellationToken)
                        .WithRawResponse(),
                request => request.Offset ?? 0,
                (request, offset) =>
                {
                    request.Offset = offset;
                },
                null,
                response => response.Activity?.ToList(),
                null,
                cancellationToken
            )
            .ConfigureAwait(false);
        return pager;
    }

    /// <summary>
    /// Get a list of the top email clients based on user-agent strings.
    /// </summary>
    /// <example><code>
    /// await client.Lists.ListClientsAsync(new ListClientsListsRequest { ListId = "list_id" });
    /// </code></example>
    public WithRawResponseTask<ListClientsListsResponse> ListClientsAsync(
        ListClientsListsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<ListClientsListsResponse>(
            ListClientsAsyncCore(request, options, cancellationToken)
        );
    }

    /// <summary>
    /// Get a month-by-month summary of a specific list's growth activity.
    /// </summary>
    /// <example><code>
    /// await client.Lists.ListGrowthHistoryAsync(new ListGrowthHistoryListsRequest { ListId = "list_id" });
    /// </code></example>
    public async Task<Pager<GrowthHistory>> ListGrowthHistoryAsync(
        ListGrowthHistoryListsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        request = request with { };
        var pager = await OffsetPager<
            ListGrowthHistoryListsRequest,
            RequestOptions?,
            ListGrowthHistoryListsResponse,
            int,
            object,
            GrowthHistory
        >
            .CreateInstanceAsync(
                request,
                options,
                async (request, options, cancellationToken) =>
                    await ListGrowthHistoryInternalAsync(request, options, cancellationToken)
                        .WithRawResponse(),
                request => request.Offset ?? 0,
                (request, offset) =>
                {
                    request.Offset = offset;
                },
                null,
                response => response.History?.ToList(),
                null,
                cancellationToken
            )
            .ConfigureAwait(false);
        return pager;
    }

    /// <summary>
    /// Get a summary of a specific list's growth activity for a specific month and year.
    /// </summary>
    /// <example><code>
    /// await client.Lists.GetGrowthHistoryAsync(
    ///     new GetGrowthHistoryListsRequest { ListId = "list_id", Month = "month" }
    /// );
    /// </code></example>
    public WithRawResponseTask<GrowthHistory> GetGrowthHistoryAsync(
        GetGrowthHistoryListsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<GrowthHistory>(
            GetGrowthHistoryAsyncCore(request, options, cancellationToken)
        );
    }

    /// <summary>
    /// Get information about a list's interest categories.
    /// </summary>
    /// <example><code>
    /// await client.Lists.ListInterestCategoriesAsync(
    ///     new ListInterestCategoriesListsRequest { ListId = "list_id" }
    /// );
    /// </code></example>
    public async Task<Pager<InterestCategory>> ListInterestCategoriesAsync(
        ListInterestCategoriesListsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        request = request with { };
        var pager = await OffsetPager<
            ListInterestCategoriesListsRequest,
            RequestOptions?,
            ListInterestCategoriesListsResponse,
            int,
            object,
            InterestCategory
        >
            .CreateInstanceAsync(
                request,
                options,
                async (request, options, cancellationToken) =>
                    await ListInterestCategoriesInternalAsync(request, options, cancellationToken)
                        .WithRawResponse(),
                request => request.Offset ?? 0,
                (request, offset) =>
                {
                    request.Offset = offset;
                },
                null,
                response => response.Categories?.ToList(),
                null,
                cancellationToken
            )
            .ConfigureAwait(false);
        return pager;
    }

    /// <summary>
    /// Create a new interest category.
    /// </summary>
    /// <example><code>
    /// await client.Lists.CreateInterestCategoryAsync(
    ///     new CreateInterestCategoryListsRequest
    ///     {
    ///         ListId = "list_id",
    ///         Title = "title",
    ///         Type = CreateInterestCategoryListsRequestType.Checkboxes,
    ///     }
    /// );
    /// </code></example>
    public WithRawResponseTask<InterestCategory> CreateInterestCategoryAsync(
        CreateInterestCategoryListsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<InterestCategory>(
            CreateInterestCategoryAsyncCore(request, options, cancellationToken)
        );
    }

    /// <summary>
    /// Get information about a specific interest category.
    /// </summary>
    /// <example><code>
    /// await client.Lists.GetInterestCategoryAsync(
    ///     new GetInterestCategoryListsRequest
    ///     {
    ///         ListId = "list_id",
    ///         InterestCategoryId = "interest_category_id",
    ///     }
    /// );
    /// </code></example>
    public WithRawResponseTask<InterestCategory> GetInterestCategoryAsync(
        GetInterestCategoryListsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<InterestCategory>(
            GetInterestCategoryAsyncCore(request, options, cancellationToken)
        );
    }

    /// <summary>
    /// Delete a specific interest category.
    /// </summary>
    /// <example><code>
    /// await client.Lists.DeleteInterestCategoryAsync(
    ///     new DeleteInterestCategoryListsRequest
    ///     {
    ///         ListId = "list_id",
    ///         InterestCategoryId = "interest_category_id",
    ///     }
    /// );
    /// </code></example>
    public WithRawResponseTask DeleteInterestCategoryAsync(
        DeleteInterestCategoryListsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask(
            DeleteInterestCategoryAsyncCore(request, options, cancellationToken)
        );
    }

    /// <summary>
    /// Update a specific interest category.
    /// </summary>
    /// <example><code>
    /// await client.Lists.UpdateInterestCategoryAsync(
    ///     new UpdateInterestCategoryListsRequest
    ///     {
    ///         ListId = "list_id",
    ///         InterestCategoryId = "interest_category_id",
    ///     }
    /// );
    /// </code></example>
    public WithRawResponseTask<InterestCategory> UpdateInterestCategoryAsync(
        UpdateInterestCategoryListsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<InterestCategory>(
            UpdateInterestCategoryAsyncCore(request, options, cancellationToken)
        );
    }

    /// <summary>
    /// Get a list of this category's interests.
    /// </summary>
    /// <example><code>
    /// await client.Lists.ListInterestCategoryInterestsAsync(
    ///     new ListInterestCategoryInterestsListsRequest
    ///     {
    ///         ListId = "list_id",
    ///         InterestCategoryId = "interest_category_id",
    ///     }
    /// );
    /// </code></example>
    public async Task<Pager<Interest>> ListInterestCategoryInterestsAsync(
        ListInterestCategoryInterestsListsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        request = request with { };
        var pager = await OffsetPager<
            ListInterestCategoryInterestsListsRequest,
            RequestOptions?,
            ListInterestCategoryInterestsListsResponse,
            int,
            object,
            Interest
        >
            .CreateInstanceAsync(
                request,
                options,
                async (request, options, cancellationToken) =>
                    await ListInterestCategoryInterestsInternalAsync(
                            request,
                            options,
                            cancellationToken
                        )
                        .WithRawResponse(),
                request => request.Offset ?? 0,
                (request, offset) =>
                {
                    request.Offset = offset;
                },
                null,
                response => response.Interests?.ToList(),
                null,
                cancellationToken
            )
            .ConfigureAwait(false);
        return pager;
    }

    /// <summary>
    /// Create a new interest or 'group name' for a specific category.
    /// </summary>
    /// <example><code>
    /// await client.Lists.CreateInterestCategoryInterestAsync(
    ///     new CreateInterestCategoryInterestListsRequest
    ///     {
    ///         ListId = "list_id",
    ///         InterestCategoryId = "interest_category_id",
    ///         Name = "name",
    ///     }
    /// );
    /// </code></example>
    public WithRawResponseTask<Interest> CreateInterestCategoryInterestAsync(
        CreateInterestCategoryInterestListsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<Interest>(
            CreateInterestCategoryInterestAsyncCore(request, options, cancellationToken)
        );
    }

    /// <summary>
    /// Get interests or 'group names' for a specific category.
    /// </summary>
    /// <example><code>
    /// await client.Lists.GetInterestCategoryInterestAsync(
    ///     new GetInterestCategoryInterestListsRequest
    ///     {
    ///         ListId = "list_id",
    ///         InterestCategoryId = "interest_category_id",
    ///         InterestId = "interest_id",
    ///     }
    /// );
    /// </code></example>
    public WithRawResponseTask<Interest> GetInterestCategoryInterestAsync(
        GetInterestCategoryInterestListsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<Interest>(
            GetInterestCategoryInterestAsyncCore(request, options, cancellationToken)
        );
    }

    /// <summary>
    /// Delete interests or group names in a specific category.
    /// </summary>
    /// <example><code>
    /// await client.Lists.DeleteInterestCategoryInterestAsync(
    ///     new DeleteInterestCategoryInterestListsRequest
    ///     {
    ///         ListId = "list_id",
    ///         InterestCategoryId = "interest_category_id",
    ///         InterestId = "interest_id",
    ///     }
    /// );
    /// </code></example>
    public WithRawResponseTask DeleteInterestCategoryInterestAsync(
        DeleteInterestCategoryInterestListsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask(
            DeleteInterestCategoryInterestAsyncCore(request, options, cancellationToken)
        );
    }

    /// <summary>
    /// Update interests or 'group names' for a specific category.
    /// </summary>
    /// <example><code>
    /// await client.Lists.UpdateInterestCategoryInterestAsync(
    ///     new UpdateInterestCategoryInterestListsRequest
    ///     {
    ///         ListId = "list_id",
    ///         InterestCategoryId = "interest_category_id",
    ///         InterestId = "interest_id",
    ///     }
    /// );
    /// </code></example>
    public WithRawResponseTask<Interest> UpdateInterestCategoryInterestAsync(
        UpdateInterestCategoryInterestListsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<Interest>(
            UpdateInterestCategoryInterestAsyncCore(request, options, cancellationToken)
        );
    }

    /// <summary>
    /// Get the locations (countries) that the list's subscribers have been tagged to based on geocoding their IP address.
    /// </summary>
    /// <example><code>
    /// await client.Lists.ListLocationsAsync(new ListLocationsListsRequest { ListId = "list_id" });
    /// </code></example>
    public WithRawResponseTask<ListLocationsListsResponse> ListLocationsAsync(
        ListLocationsListsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<ListLocationsListsResponse>(
            ListLocationsAsyncCore(request, options, cancellationToken)
        );
    }

    /// <summary>
    /// Get information about members in a specific Mailchimp list.
    /// </summary>
    /// <example><code>
    /// await client.Lists.ListMembersAsync(new ListMembersListsRequest { ListId = "list_id" });
    /// </code></example>
    public async Task<Pager<ListMembers>> ListMembersAsync(
        ListMembersListsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        request = request with { };
        var pager = await OffsetPager<
            ListMembersListsRequest,
            RequestOptions?,
            ListMembersListsResponse,
            int,
            object,
            ListMembers
        >
            .CreateInstanceAsync(
                request,
                options,
                async (request, options, cancellationToken) =>
                    await ListMembersInternalAsync(request, options, cancellationToken)
                        .WithRawResponse(),
                request => request.Offset ?? 0,
                (request, offset) =>
                {
                    request.Offset = offset;
                },
                null,
                response => response.Members?.ToList(),
                null,
                cancellationToken
            )
            .ConfigureAwait(false);
        return pager;
    }

    /// <summary>
    /// Add a new member to the list.
    /// </summary>
    /// <example><code>
    /// await client.Lists.CreateMemberAsync(
    ///     new CreateMemberListsRequest
    ///     {
    ///         ListId = "list_id",
    ///         EmailAddress = "email_address",
    ///         Status = CreateMemberListsRequestStatus.Subscribed,
    ///     }
    /// );
    /// </code></example>
    public WithRawResponseTask<ListMembers> CreateMemberAsync(
        CreateMemberListsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<ListMembers>(
            CreateMemberAsyncCore(request, options, cancellationToken)
        );
    }

    /// <summary>
    /// Get information about a specific list member, including a currently subscribed, unsubscribed, or bounced member.
    /// </summary>
    /// <example><code>
    /// await client.Lists.GetMemberAsync(
    ///     new GetMemberListsRequest { ListId = "list_id", SubscriberHash = "subscriber_hash" }
    /// );
    /// </code></example>
    public WithRawResponseTask<ListMembers> GetMemberAsync(
        GetMemberListsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<ListMembers>(
            GetMemberAsyncCore(request, options, cancellationToken)
        );
    }

    /// <summary>
    /// Add or update a list member.
    /// </summary>
    /// <example><code>
    /// await client.Lists.UpsertMemberAsync(
    ///     new UpsertMemberListsRequest
    ///     {
    ///         ListId = "list_id",
    ///         SubscriberHash = "subscriber_hash",
    ///         EmailAddress = "email_address",
    ///     }
    /// );
    /// </code></example>
    public WithRawResponseTask<ListMembers> UpsertMemberAsync(
        UpsertMemberListsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<ListMembers>(
            UpsertMemberAsyncCore(request, options, cancellationToken)
        );
    }

    /// <summary>
    /// Archive a list member. To permanently delete, use the delete-permanent action.
    /// </summary>
    /// <example><code>
    /// await client.Lists.DeleteMemberAsync(
    ///     new DeleteMemberListsRequest { ListId = "list_id", SubscriberHash = "subscriber_hash" }
    /// );
    /// </code></example>
    public WithRawResponseTask DeleteMemberAsync(
        DeleteMemberListsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask(DeleteMemberAsyncCore(request, options, cancellationToken));
    }

    /// <summary>
    /// Update information for a specific list member.
    /// </summary>
    /// <example><code>
    /// await client.Lists.UpdateMemberAsync(
    ///     new UpdateMemberListsRequest { ListId = "list_id", SubscriberHash = "subscriber_hash" }
    /// );
    /// </code></example>
    public WithRawResponseTask<ListMembers> UpdateMemberAsync(
        UpdateMemberListsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<ListMembers>(
            UpdateMemberAsyncCore(request, options, cancellationToken)
        );
    }

    /// <summary>
    /// Delete all personally identifiable information related to a list member, and remove them from a list. This will make it impossible to re-import the list member.
    /// </summary>
    /// <example><code>
    /// await client.Lists.CreateMemberActionDeletePermanentAsync(
    ///     new CreateMemberActionDeletePermanentListsRequest
    ///     {
    ///         ListId = "list_id",
    ///         SubscriberHash = "subscriber_hash",
    ///     }
    /// );
    /// </code></example>
    public WithRawResponseTask CreateMemberActionDeletePermanentAsync(
        CreateMemberActionDeletePermanentListsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask(
            CreateMemberActionDeletePermanentAsyncCore(request, options, cancellationToken)
        );
    }

    /// <summary>
    /// Get the last 50 events of a member's activity on a specific list, including opens, clicks, and unsubscribes.
    /// </summary>
    /// <example><code>
    /// await client.Lists.ListMemberActivityAsync(
    ///     new ListMemberActivityListsRequest { ListId = "list_id", SubscriberHash = "subscriber_hash" }
    /// );
    /// </code></example>
    public WithRawResponseTask<ListMemberActivityListsResponse> ListMemberActivityAsync(
        ListMemberActivityListsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<ListMemberActivityListsResponse>(
            ListMemberActivityAsyncCore(request, options, cancellationToken)
        );
    }

    /// <summary>
    /// Get a member's activity on a specific list, including opens, clicks, and unsubscribes.
    /// </summary>
    /// <example><code>
    /// await client.Lists.ListMemberActivityFeedAsync(
    ///     new ListMemberActivityFeedListsRequest
    ///     {
    ///         ListId = "list_id",
    ///         SubscriberHash = "subscriber_hash",
    ///     }
    /// );
    /// </code></example>
    public async Task<Pager<object>> ListMemberActivityFeedAsync(
        ListMemberActivityFeedListsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        request = request with { };
        var pager = await OffsetPager<
            ListMemberActivityFeedListsRequest,
            RequestOptions?,
            ListMemberActivityFeedListsResponse,
            int,
            object,
            object
        >
            .CreateInstanceAsync(
                request,
                options,
                async (request, options, cancellationToken) =>
                    await ListMemberActivityFeedInternalAsync(request, options, cancellationToken)
                        .WithRawResponse(),
                request => request.Offset ?? 0,
                (request, offset) =>
                {
                    request.Offset = offset;
                },
                null,
                response => response.Activity?.ToList(),
                null,
                cancellationToken
            )
            .ConfigureAwait(false);
        return pager;
    }

    /// <summary>
    /// Get events for a contact.
    /// </summary>
    /// <example><code>
    /// await client.Lists.ListMemberEventsAsync(
    ///     new ListMemberEventsListsRequest { ListId = "list_id", SubscriberHash = "subscriber_hash" }
    /// );
    /// </code></example>
    public async Task<Pager<ListMemberEventsListsResponseEventsItem>> ListMemberEventsAsync(
        ListMemberEventsListsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        request = request with { };
        var pager = await OffsetPager<
            ListMemberEventsListsRequest,
            RequestOptions?,
            ListMemberEventsListsResponse,
            int,
            object,
            ListMemberEventsListsResponseEventsItem
        >
            .CreateInstanceAsync(
                request,
                options,
                async (request, options, cancellationToken) =>
                    await ListMemberEventsInternalAsync(request, options, cancellationToken)
                        .WithRawResponse(),
                request => request.Offset ?? 0,
                (request, offset) =>
                {
                    request.Offset = offset;
                },
                null,
                response => response.Events?.ToList(),
                null,
                cancellationToken
            )
            .ConfigureAwait(false);
        return pager;
    }

    /// <summary>
    /// Add an event for a list member.
    /// </summary>
    /// <example><code>
    /// await client.Lists.CreateMemberEventAsync(
    ///     new CreateMemberEventListsRequest
    ///     {
    ///         ListId = "list_id",
    ///         SubscriberHash = "subscriber_hash",
    ///         Name = "name",
    ///     }
    /// );
    /// </code></example>
    public WithRawResponseTask CreateMemberEventAsync(
        CreateMemberEventListsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask(
            CreateMemberEventAsyncCore(request, options, cancellationToken)
        );
    }

    /// <summary>
    /// Get the last 50 Goal events for a member on a specific list.
    /// </summary>
    /// <example><code>
    /// await client.Lists.ListMemberGoalsAsync(
    ///     new ListMemberGoalsListsRequest { ListId = "list_id", SubscriberHash = "subscriber_hash" }
    /// );
    /// </code></example>
    public WithRawResponseTask<ListMemberGoalsListsResponse> ListMemberGoalsAsync(
        ListMemberGoalsListsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<ListMemberGoalsListsResponse>(
            ListMemberGoalsAsyncCore(request, options, cancellationToken)
        );
    }

    /// <summary>
    /// Get recent notes for a specific list member.
    /// </summary>
    /// <example><code>
    /// await client.Lists.ListMemberNotesAsync(
    ///     new ListMemberNotesListsRequest { ListId = "list_id", SubscriberHash = "subscriber_hash" }
    /// );
    /// </code></example>
    public async Task<Pager<MemberNotes>> ListMemberNotesAsync(
        ListMemberNotesListsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        request = request with { };
        var pager = await OffsetPager<
            ListMemberNotesListsRequest,
            RequestOptions?,
            ListMemberNotesListsResponse,
            int,
            object,
            MemberNotes
        >
            .CreateInstanceAsync(
                request,
                options,
                async (request, options, cancellationToken) =>
                    await ListMemberNotesInternalAsync(request, options, cancellationToken)
                        .WithRawResponse(),
                request => request.Offset ?? 0,
                (request, offset) =>
                {
                    request.Offset = offset;
                },
                null,
                response => response.Notes?.ToList(),
                null,
                cancellationToken
            )
            .ConfigureAwait(false);
        return pager;
    }

    /// <summary>
    /// Add a new note for a specific subscriber.
    /// </summary>
    /// <example><code>
    /// await client.Lists.CreateMemberNoteAsync(
    ///     new CreateMemberNoteListsRequest { ListId = "list_id", SubscriberHash = "subscriber_hash" }
    /// );
    /// </code></example>
    public WithRawResponseTask<MemberNotes> CreateMemberNoteAsync(
        CreateMemberNoteListsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<MemberNotes>(
            CreateMemberNoteAsyncCore(request, options, cancellationToken)
        );
    }

    /// <summary>
    /// Get a specific note for a specific list member.
    /// </summary>
    /// <example><code>
    /// await client.Lists.GetMemberNoteAsync(
    ///     new GetMemberNoteListsRequest
    ///     {
    ///         ListId = "list_id",
    ///         SubscriberHash = "subscriber_hash",
    ///         NoteId = "note_id",
    ///     }
    /// );
    /// </code></example>
    public WithRawResponseTask<MemberNotes> GetMemberNoteAsync(
        GetMemberNoteListsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<MemberNotes>(
            GetMemberNoteAsyncCore(request, options, cancellationToken)
        );
    }

    /// <summary>
    /// Delete a specific note for a specific list member.
    /// </summary>
    /// <example><code>
    /// await client.Lists.DeleteMemberNoteAsync(
    ///     new DeleteMemberNoteListsRequest
    ///     {
    ///         ListId = "list_id",
    ///         SubscriberHash = "subscriber_hash",
    ///         NoteId = "note_id",
    ///     }
    /// );
    /// </code></example>
    public WithRawResponseTask DeleteMemberNoteAsync(
        DeleteMemberNoteListsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask(
            DeleteMemberNoteAsyncCore(request, options, cancellationToken)
        );
    }

    /// <summary>
    /// Update a specific note for a specific list member.
    /// </summary>
    /// <example><code>
    /// await client.Lists.UpdateMemberNoteAsync(
    ///     new UpdateMemberNoteListsRequest
    ///     {
    ///         ListId = "list_id",
    ///         SubscriberHash = "subscriber_hash",
    ///         NoteId = "note_id",
    ///     }
    /// );
    /// </code></example>
    public WithRawResponseTask<MemberNotes> UpdateMemberNoteAsync(
        UpdateMemberNoteListsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<MemberNotes>(
            UpdateMemberNoteAsyncCore(request, options, cancellationToken)
        );
    }

    /// <summary>
    /// Get the tags on a list member.
    /// </summary>
    /// <example><code>
    /// await client.Lists.ListMemberTagsAsync(
    ///     new ListMemberTagsListsRequest { ListId = "list_id", SubscriberHash = "subscriber_hash" }
    /// );
    /// </code></example>
    public async Task<Pager<ListMemberTagsListsResponseTagsItem>> ListMemberTagsAsync(
        ListMemberTagsListsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        request = request with { };
        var pager = await OffsetPager<
            ListMemberTagsListsRequest,
            RequestOptions?,
            ListMemberTagsListsResponse,
            int,
            object,
            ListMemberTagsListsResponseTagsItem
        >
            .CreateInstanceAsync(
                request,
                options,
                async (request, options, cancellationToken) =>
                    await ListMemberTagsInternalAsync(request, options, cancellationToken)
                        .WithRawResponse(),
                request => request.Offset ?? 0,
                (request, offset) =>
                {
                    request.Offset = offset;
                },
                null,
                response => response.Tags?.ToList(),
                null,
                cancellationToken
            )
            .ConfigureAwait(false);
        return pager;
    }

    /// <summary>
    /// Add or remove tags from a list member. If a tag that does not exist is passed in and set as 'active', a new tag will be created.
    /// </summary>
    /// <example><code>
    /// await client.Lists.CreateMemberTagAsync(
    ///     new CreateMemberTagListsRequest
    ///     {
    ///         ListId = "list_id",
    ///         SubscriberHash = "subscriber_hash",
    ///         Tags = new global::System.Collections.Generic.List&lt;CreateMemberTagListsRequestTagsItem&gt;()
    ///         {
    ///             new CreateMemberTagListsRequestTagsItem
    ///             {
    ///                 Name = "name",
    ///                 Status = CreateMemberTagListsRequestTagsItemStatus.Inactive,
    ///             },
    ///         },
    ///     }
    /// );
    /// </code></example>
    public WithRawResponseTask CreateMemberTagAsync(
        CreateMemberTagListsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask(
            CreateMemberTagAsyncCore(request, options, cancellationToken)
        );
    }

    /// <summary>
    /// Get a list of all merge fields for an audience.
    /// </summary>
    /// <example><code>
    /// await client.Lists.ListMergeFieldsAsync(new ListMergeFieldsListsRequest { ListId = "list_id" });
    /// </code></example>
    public async Task<Pager<MergeField>> ListMergeFieldsAsync(
        ListMergeFieldsListsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        request = request with { };
        var pager = await OffsetPager<
            ListMergeFieldsListsRequest,
            RequestOptions?,
            ListMergeFieldsListsResponse,
            int,
            object,
            MergeField
        >
            .CreateInstanceAsync(
                request,
                options,
                async (request, options, cancellationToken) =>
                    await ListMergeFieldsInternalAsync(request, options, cancellationToken)
                        .WithRawResponse(),
                request => request.Offset ?? 0,
                (request, offset) =>
                {
                    request.Offset = offset;
                },
                null,
                response => response.MergeFields?.ToList(),
                null,
                cancellationToken
            )
            .ConfigureAwait(false);
        return pager;
    }

    /// <summary>
    /// Add a new merge field for a specific audience.
    /// </summary>
    /// <example><code>
    /// await client.Lists.CreateMergeFieldAsync(
    ///     new CreateMergeFieldListsRequest
    ///     {
    ///         ListId = "list_id",
    ///         Name = "name",
    ///         Type = CreateMergeFieldListsRequestType.Text,
    ///     }
    /// );
    /// </code></example>
    public WithRawResponseTask<MergeField> CreateMergeFieldAsync(
        CreateMergeFieldListsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<MergeField>(
            CreateMergeFieldAsyncCore(request, options, cancellationToken)
        );
    }

    /// <summary>
    /// Get information about a specific merge field.
    /// </summary>
    /// <example><code>
    /// await client.Lists.GetMergeFieldAsync(
    ///     new GetMergeFieldListsRequest { ListId = "list_id", MergeId = "merge_id" }
    /// );
    /// </code></example>
    public WithRawResponseTask<MergeField> GetMergeFieldAsync(
        GetMergeFieldListsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<MergeField>(
            GetMergeFieldAsyncCore(request, options, cancellationToken)
        );
    }

    /// <summary>
    /// Delete a specific merge field.
    /// </summary>
    /// <example><code>
    /// await client.Lists.DeleteMergeFieldAsync(
    ///     new DeleteMergeFieldListsRequest { ListId = "list_id", MergeId = "merge_id" }
    /// );
    /// </code></example>
    public WithRawResponseTask DeleteMergeFieldAsync(
        DeleteMergeFieldListsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask(
            DeleteMergeFieldAsyncCore(request, options, cancellationToken)
        );
    }

    /// <summary>
    /// Update a specific merge field.
    /// </summary>
    /// <example><code>
    /// await client.Lists.UpdateMergeFieldAsync(
    ///     new UpdateMergeFieldListsRequest { ListId = "list_id", MergeId = "merge_id" }
    /// );
    /// </code></example>
    public WithRawResponseTask<MergeField> UpdateMergeFieldAsync(
        UpdateMergeFieldListsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<MergeField>(
            UpdateMergeFieldAsyncCore(request, options, cancellationToken)
        );
    }

    /// <summary>
    /// Get information about all available segments for a specific list.
    /// </summary>
    /// <example><code>
    /// await client.Lists.ListSegmentsAsync(new ListSegmentsListsRequest { ListId = "list_id" });
    /// </code></example>
    public async Task<Pager<List>> ListSegmentsAsync(
        ListSegmentsListsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        request = request with { };
        var pager = await OffsetPager<
            ListSegmentsListsRequest,
            RequestOptions?,
            ListSegmentsListsResponse,
            int,
            object,
            List
        >
            .CreateInstanceAsync(
                request,
                options,
                async (request, options, cancellationToken) =>
                    await ListSegmentsInternalAsync(request, options, cancellationToken)
                        .WithRawResponse(),
                request => request.Offset ?? 0,
                (request, offset) =>
                {
                    request.Offset = offset;
                },
                null,
                response => response.Segments?.ToList(),
                null,
                cancellationToken
            )
            .ConfigureAwait(false);
        return pager;
    }

    /// <summary>
    /// Create a new segment in a specific list.
    /// </summary>
    /// <example><code>
    /// await client.Lists.CreateSegmentAsync(
    ///     new CreateSegmentListsRequest { ListId = "list_id", Name = "name" }
    /// );
    /// </code></example>
    public WithRawResponseTask<List> CreateSegmentAsync(
        CreateSegmentListsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<List>(
            CreateSegmentAsyncCore(request, options, cancellationToken)
        );
    }

    /// <summary>
    /// Get information about a specific segment.
    /// </summary>
    /// <example><code>
    /// await client.Lists.GetSegmentAsync(
    ///     new GetSegmentListsRequest { ListId = "list_id", SegmentId = "segment_id" }
    /// );
    /// </code></example>
    public WithRawResponseTask<List> GetSegmentAsync(
        GetSegmentListsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<List>(
            GetSegmentAsyncCore(request, options, cancellationToken)
        );
    }

    /// <summary>
    /// Batch add/remove list members to static segment
    /// </summary>
    /// <example><code>
    /// await client.Lists.BatchAddOrRemoveMembersAsync(
    ///     new BatchAddOrRemoveMembersListsRequest { ListId = "list_id", SegmentId = "segment_id" }
    /// );
    /// </code></example>
    public WithRawResponseTask<BatchAddOrRemoveMembersListsResponse> BatchAddOrRemoveMembersAsync(
        BatchAddOrRemoveMembersListsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<BatchAddOrRemoveMembersListsResponse>(
            BatchAddOrRemoveMembersAsyncCore(request, options, cancellationToken)
        );
    }

    /// <summary>
    /// Delete a specific segment in a list.
    /// </summary>
    /// <example><code>
    /// await client.Lists.DeleteSegmentAsync(
    ///     new DeleteSegmentListsRequest { ListId = "list_id", SegmentId = "segment_id" }
    /// );
    /// </code></example>
    public WithRawResponseTask DeleteSegmentAsync(
        DeleteSegmentListsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask(DeleteSegmentAsyncCore(request, options, cancellationToken));
    }

    /// <summary>
    /// Update a specific segment in a list.
    /// </summary>
    /// <example><code>
    /// await client.Lists.UpdateSegmentAsync(
    ///     new UpdateSegmentListsRequest { ListId = "list_id", SegmentId = "segment_id" }
    /// );
    /// </code></example>
    public WithRawResponseTask<List> UpdateSegmentAsync(
        UpdateSegmentListsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<List>(
            UpdateSegmentAsyncCore(request, options, cancellationToken)
        );
    }

    /// <summary>
    /// Get information about members in a saved segment.
    /// </summary>
    /// <example><code>
    /// await client.Lists.ListSegmentMembersAsync(
    ///     new ListSegmentMembersListsRequest { ListId = "list_id", SegmentId = "segment_id" }
    /// );
    /// </code></example>
    public async Task<Pager<ListsSegmentsMembers>> ListSegmentMembersAsync(
        ListSegmentMembersListsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        request = request with { };
        var pager = await OffsetPager<
            ListSegmentMembersListsRequest,
            RequestOptions?,
            ListSegmentMembersListsResponse,
            int,
            object,
            ListsSegmentsMembers
        >
            .CreateInstanceAsync(
                request,
                options,
                async (request, options, cancellationToken) =>
                    await ListSegmentMembersInternalAsync(request, options, cancellationToken)
                        .WithRawResponse(),
                request => request.Offset ?? 0,
                (request, offset) =>
                {
                    request.Offset = offset;
                },
                null,
                response => response.Members?.ToList(),
                null,
                cancellationToken
            )
            .ConfigureAwait(false);
        return pager;
    }

    /// <summary>
    /// Add a member to a static segment.
    /// </summary>
    /// <example><code>
    /// await client.Lists.CreateSegmentMemberAsync(
    ///     new CreateSegmentMemberListsRequest
    ///     {
    ///         ListId = "list_id",
    ///         SegmentId = "segment_id",
    ///         EmailAddress = "email_address",
    ///     }
    /// );
    /// </code></example>
    public WithRawResponseTask<ListsSegmentsMembers> CreateSegmentMemberAsync(
        CreateSegmentMemberListsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<ListsSegmentsMembers>(
            CreateSegmentMemberAsyncCore(request, options, cancellationToken)
        );
    }

    /// <summary>
    /// Remove a member from the specified static segment.
    /// </summary>
    /// <example><code>
    /// await client.Lists.DeleteSegmentMemberAsync(
    ///     new DeleteSegmentMemberListsRequest
    ///     {
    ///         ListId = "list_id",
    ///         SegmentId = "segment_id",
    ///         SubscriberHash = "subscriber_hash",
    ///     }
    /// );
    /// </code></example>
    public WithRawResponseTask DeleteSegmentMemberAsync(
        DeleteSegmentMemberListsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask(
            DeleteSegmentMemberAsyncCore(request, options, cancellationToken)
        );
    }

    /// <summary>
    /// Get signup forms for a specific list.
    /// </summary>
    /// <example><code>
    /// await client.Lists.ListSignupFormsAsync(new ListSignupFormsListsRequest { ListId = "list_id" });
    /// </code></example>
    public WithRawResponseTask<ListSignupFormsListsResponse> ListSignupFormsAsync(
        ListSignupFormsListsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<ListSignupFormsListsResponse>(
            ListSignupFormsAsyncCore(request, options, cancellationToken)
        );
    }

    /// <summary>
    /// Customize a list's default signup form.
    /// </summary>
    /// <example><code>
    /// await client.Lists.CreateSignupFormAsync(new CreateSignupFormListsRequest { ListId = "list_id" });
    /// </code></example>
    public WithRawResponseTask<SignupForm> CreateSignupFormAsync(
        CreateSignupFormListsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<SignupForm>(
            CreateSignupFormAsyncCore(request, options, cancellationToken)
        );
    }

    /// <summary>
    /// Get information about all available surveys for a specific list.
    /// </summary>
    /// <example><code>
    /// await client.Lists.ListSurveysAsync(new ListSurveysListsRequest { ListId = "list_id" });
    /// </code></example>
    public WithRawResponseTask<object> ListSurveysAsync(
        ListSurveysListsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<object>(
            ListSurveysAsyncCore(request, options, cancellationToken)
        );
    }

    /// <summary>
    /// Create a draft survey for an audience.
    /// </summary>
    /// <example><code>
    /// await client.Lists.CreateSurveyAsync(new CreateSurveyListsRequest { ListId = "list_id" });
    /// </code></example>
    public WithRawResponseTask<object> CreateSurveyAsync(
        CreateSurveyListsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<object>(
            CreateSurveyAsyncCore(request, options, cancellationToken)
        );
    }

    /// <summary>
    /// Get details about a specific survey.
    /// </summary>
    /// <example><code>
    /// await client.Lists.GetSurveyAsync(
    ///     new GetSurveyListsRequest { ListId = "list_id", SurveyId = "survey_id" }
    /// );
    /// </code></example>
    public WithRawResponseTask<object> GetSurveyAsync(
        GetSurveyListsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<object>(
            GetSurveyAsyncCore(request, options, cancellationToken)
        );
    }

    /// <summary>
    /// Delete a survey.
    /// </summary>
    /// <example><code>
    /// await client.Lists.DeleteSurveyAsync(
    ///     new DeleteSurveyListsRequest { ListId = "list_id", SurveyId = "survey_id" }
    /// );
    /// </code></example>
    public WithRawResponseTask DeleteSurveyAsync(
        DeleteSurveyListsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask(DeleteSurveyAsyncCore(request, options, cancellationToken));
    }

    /// <summary>
    /// Update a survey. When sections is provided, send the complete section list in display order. Any existing section not included is deleted.
    /// </summary>
    /// <example><code>
    /// await client.Lists.UpdateSurveyAsync(
    ///     new UpdateSurveyListsRequest { ListId = "list_id", SurveyId = "survey_id" }
    /// );
    /// </code></example>
    public WithRawResponseTask<object> UpdateSurveyAsync(
        UpdateSurveyListsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<object>(
            UpdateSurveyAsyncCore(request, options, cancellationToken)
        );
    }

    /// <summary>
    /// Replicate a survey.
    /// </summary>
    /// <example><code>
    /// await client.Lists.CreateListSurveyActionReplicateAsync(
    ///     new CreateListSurveyActionReplicateListsRequest
    ///     {
    ///         ListIdPathParam = "list_id",
    ///         SurveyId = "survey_id",
    ///     }
    /// );
    /// </code></example>
    public WithRawResponseTask<object> CreateListSurveyActionReplicateAsync(
        CreateListSurveyActionReplicateListsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<object>(
            CreateListSurveyActionReplicateAsyncCore(request, options, cancellationToken)
        );
    }

    /// <summary>
    /// Search for tags on a list by name. If no name is provided, will return all tags on the list.
    /// </summary>
    /// <example><code>
    /// await client.Lists.ListTagSearchAsync(new ListTagSearchListsRequest { ListId = "list_id" });
    /// </code></example>
    public WithRawResponseTask<ListTagSearchListsResponse> ListTagSearchAsync(
        ListTagSearchListsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<ListTagSearchListsResponse>(
            ListTagSearchAsyncCore(request, options, cancellationToken)
        );
    }

    /// <summary>
    /// Get information about all webhooks for a specific list.
    /// </summary>
    /// <example><code>
    /// await client.Lists.ListWebhooksAsync(new ListWebhooksListsRequest { ListId = "list_id" });
    /// </code></example>
    public WithRawResponseTask<ListWebhooksListsResponse> ListWebhooksAsync(
        ListWebhooksListsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<ListWebhooksListsResponse>(
            ListWebhooksAsyncCore(request, options, cancellationToken)
        );
    }

    /// <summary>
    /// Create a new webhook for a specific list.
    /// </summary>
    /// <example><code>
    /// await client.Lists.CreateWebhookAsync(
    ///     new CreateWebhookListsRequest { ListId = "list_id", Body = new AddWebhook() }
    /// );
    /// </code></example>
    public WithRawResponseTask<CreateWebhookListsResponse> CreateWebhookAsync(
        CreateWebhookListsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<CreateWebhookListsResponse>(
            CreateWebhookAsyncCore(request, options, cancellationToken)
        );
    }

    /// <summary>
    /// Get information about a specific webhook.
    /// </summary>
    /// <example><code>
    /// await client.Lists.GetWebhookAsync(
    ///     new GetWebhookListsRequest { ListId = "list_id", WebhookId = "webhook_id" }
    /// );
    /// </code></example>
    public WithRawResponseTask<ListWebhooks> GetWebhookAsync(
        GetWebhookListsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<ListWebhooks>(
            GetWebhookAsyncCore(request, options, cancellationToken)
        );
    }

    /// <summary>
    /// Delete a specific webhook in a list.
    /// </summary>
    /// <example><code>
    /// await client.Lists.DeleteWebhookAsync(
    ///     new DeleteWebhookListsRequest { ListId = "list_id", WebhookId = "webhook_id" }
    /// );
    /// </code></example>
    public WithRawResponseTask DeleteWebhookAsync(
        DeleteWebhookListsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask(DeleteWebhookAsyncCore(request, options, cancellationToken));
    }

    /// <summary>
    /// Update the settings for an existing webhook.
    /// </summary>
    /// <example><code>
    /// await client.Lists.UpdateWebhookAsync(
    ///     new UpdateWebhookListsRequest
    ///     {
    ///         ListId = "list_id",
    ///         WebhookId = "webhook_id",
    ///         Body = new AddWebhook(),
    ///     }
    /// );
    /// </code></example>
    public WithRawResponseTask<ListWebhooks> UpdateWebhookAsync(
        UpdateWebhookListsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<ListWebhooks>(
            UpdateWebhookAsyncCore(request, options, cancellationToken)
        );
    }
}
