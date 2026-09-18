using global::System.Text.Json;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

public partial class AudiencesClient : IAudiencesClient
{
    private readonly RawClient _client;

    internal AudiencesClient(RawClient client)
    {
        _client = client;
    }

    private async Task<
        WithRawResponse<GetAudienceContactListResponse>
    > GetAudienceContactListAsyncCore(
        GetAudienceContactListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _queryString = new Mailchimp.Marketing.Core.QueryStringBuilder.Builder(capacity: 10)
            .Add("fields", request.Fields)
            .Add("exclude_fields", request.ExcludeFields)
            .Add("count", request.Count)
            .Add("cursor", request.Cursor)
            .Add("created_before", request.CreatedBefore)
            .Add("created_since", request.CreatedSince)
            .Add("updated_before", request.UpdatedBefore)
            .Add("updated_since", request.UpdatedSince)
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
                        "3.0/audiences/{0}/contacts",
                        ValueConvert.ToPathParameterString(request.AudienceId)
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
                var responseData = JsonUtils.Deserialize<GetAudienceContactListResponse>(
                    responseBody
                )!;
                return new WithRawResponse<GetAudienceContactListResponse>()
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

    private async Task<WithRawResponse<AudiencesContact>> CreateAudienceContactAsyncCore(
        CreateAudienceContactRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _queryString = new Mailchimp.Marketing.Core.QueryStringBuilder.Builder(capacity: 2)
            .Add("merge_field_validation_mode", request.MergeFieldValidationMode)
            .Add("data_mode", request.DataMode)
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
                        "3.0/audiences/{0}/contacts",
                        ValueConvert.ToPathParameterString(request.AudienceId)
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
                var responseData = JsonUtils.Deserialize<AudiencesContact>(responseBody)!;
                return new WithRawResponse<AudiencesContact>()
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

    private async Task<WithRawResponse<AudiencesContact>> GetAudienceContactAsyncCore(
        GetAudienceContactRequest request,
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
                        "3.0/audiences/{0}/contacts/{1}",
                        ValueConvert.ToPathParameterString(request.AudienceId),
                        ValueConvert.ToPathParameterString(request.ContactId)
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
                var responseData = JsonUtils.Deserialize<AudiencesContact>(responseBody)!;
                return new WithRawResponse<AudiencesContact>()
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

    private async Task<WithRawResponse<AudiencesContact>> PatchAudienceContactAsyncCore(
        PatchAudienceContactRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _queryString = new Mailchimp.Marketing.Core.QueryStringBuilder.Builder(capacity: 2)
            .Add("merge_field_validation_mode", request.MergeFieldValidationMode)
            .Add("data_mode", request.DataMode)
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
                        "3.0/audiences/{0}/contacts/{1}",
                        ValueConvert.ToPathParameterString(request.AudienceId),
                        ValueConvert.ToPathParameterString(request.ContactId)
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
                var responseData = JsonUtils.Deserialize<AudiencesContact>(responseBody)!;
                return new WithRawResponse<AudiencesContact>()
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

    private async Task<RawResponse> PostAudiencesContactsActionsArchiveAsyncCore(
        PostAudiencesContactsActionsArchiveRequest request,
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
                        "3.0/audiences/{0}/contacts/{1}/actions/archive",
                        ValueConvert.ToPathParameterString(request.AudienceId),
                        ValueConvert.ToPathParameterString(request.ContactId)
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

    private async Task<RawResponse> PostAudiencesContactsActionsForgetAsyncCore(
        PostAudiencesContactsActionsForgetRequest request,
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
                        "3.0/audiences/{0}/contacts/{1}/actions/forget",
                        ValueConvert.ToPathParameterString(request.AudienceId),
                        ValueConvert.ToPathParameterString(request.ContactId)
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

    /// <summary>
    /// Get a list of omni-channel contacts for a given audience.
    /// </summary>
    /// <example><code>
    /// await client.Audiences.GetAudienceContactListAsync(
    ///     new GetAudienceContactListRequest { AudienceId = "audience_id" }
    /// );
    /// </code></example>
    public WithRawResponseTask<GetAudienceContactListResponse> GetAudienceContactListAsync(
        GetAudienceContactListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<GetAudienceContactListResponse>(
            GetAudienceContactListAsyncCore(request, options, cancellationToken)
        );
    }

    /// <summary>
    /// Create a new omni-channel contact for an audience.
    /// </summary>
    /// <example><code>
    /// await client.Audiences.CreateAudienceContactAsync(
    ///     new CreateAudienceContactRequest { AudienceId = "audience_id" }
    /// );
    /// </code></example>
    public WithRawResponseTask<AudiencesContact> CreateAudienceContactAsync(
        CreateAudienceContactRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<AudiencesContact>(
            CreateAudienceContactAsyncCore(request, options, cancellationToken)
        );
    }

    /// <summary>
    /// Retrieve a specific omni-channel contact in an audience.
    /// </summary>
    /// <example><code>
    /// await client.Audiences.GetAudienceContactAsync(
    ///     new GetAudienceContactRequest { AudienceId = "audience_id", ContactId = "contact_id" }
    /// );
    /// </code></example>
    public WithRawResponseTask<AudiencesContact> GetAudienceContactAsync(
        GetAudienceContactRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<AudiencesContact>(
            GetAudienceContactAsyncCore(request, options, cancellationToken)
        );
    }

    /// <summary>
    /// Update an existing omni-channel contact.
    /// </summary>
    /// <example><code>
    /// await client.Audiences.PatchAudienceContactAsync(
    ///     new PatchAudienceContactRequest { AudienceId = "audience_id", ContactId = "contact_id" }
    /// );
    /// </code></example>
    public WithRawResponseTask<AudiencesContact> PatchAudienceContactAsync(
        PatchAudienceContactRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<AudiencesContact>(
            PatchAudienceContactAsyncCore(request, options, cancellationToken)
        );
    }

    /// <summary>
    /// Archives a Contact.
    /// </summary>
    /// <example><code>
    /// await client.Audiences.PostAudiencesContactsActionsArchiveAsync(
    ///     new PostAudiencesContactsActionsArchiveRequest
    ///     {
    ///         AudienceId = "audience_id",
    ///         ContactId = "contact_id",
    ///     }
    /// );
    /// </code></example>
    public WithRawResponseTask PostAudiencesContactsActionsArchiveAsync(
        PostAudiencesContactsActionsArchiveRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask(
            PostAudiencesContactsActionsArchiveAsyncCore(request, options, cancellationToken)
        );
    }

    /// <summary>
    /// Forgets a Contact.
    /// </summary>
    /// <example><code>
    /// await client.Audiences.PostAudiencesContactsActionsForgetAsync(
    ///     new PostAudiencesContactsActionsForgetRequest
    ///     {
    ///         AudienceId = "audience_id",
    ///         ContactId = "contact_id",
    ///     }
    /// );
    /// </code></example>
    public WithRawResponseTask PostAudiencesContactsActionsForgetAsync(
        PostAudiencesContactsActionsForgetRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask(
            PostAudiencesContactsActionsForgetAsyncCore(request, options, cancellationToken)
        );
    }
}
