using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

public partial interface IReportingClient
{
    /// <summary>
    /// Get information about the reporting endpoint's resources.
    /// </summary>
    WithRawResponseTask<IEnumerable<ListReportingResponseItem>> ListAsync(
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Get reports of Facebook ads.
    /// </summary>
    Task<Pager<ReportingFacebookAd>> ListFacebookAdsAsync(
        ListFacebookAdsReportingRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Get report of a Facebook ad.
    /// </summary>
    WithRawResponseTask<ReportingFacebookAd> GetFacebookAdAsync(
        GetFacebookAdReportingRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Get breakdown of product activity for an outreach.
    /// </summary>
    Task<
        Pager<ListFacebookAdEcommerceProductActivityReportingResponseProductsItem>
    > ListFacebookAdEcommerceProductActivityAsync(
        ListFacebookAdEcommerceProductActivityReportingRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Get reports of landing pages.
    /// </summary>
    Task<Pager<LandingPageReport>> ListLandingPagesAsync(
        ListLandingPagesReportingRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Get report of a landing page.
    /// </summary>
    WithRawResponseTask<LandingPageReport> GetLandingPageAsync(
        GetLandingPageReportingRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Get reports for surveys.
    /// </summary>
    Task<Pager<ListSurveysReportingResponseSurveysItem>> ListSurveysAsync(
        ListSurveysReportingRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Get report for a survey.
    /// </summary>
    WithRawResponseTask<GetSurveyReportingResponse> GetSurveyAsync(
        GetSurveyReportingRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Get reports for survey questions.
    /// </summary>
    WithRawResponseTask<ListSurveyQuestionsReportingResponse> ListSurveyQuestionsAsync(
        ListSurveyQuestionsReportingRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Get report for a survey question.
    /// </summary>
    WithRawResponseTask<SurveyQuestionReport> GetSurveyQuestionAsync(
        GetSurveyQuestionReportingRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Get answers for a survey question.
    /// </summary>
    WithRawResponseTask<ListSurveyQuestionAnswersReportingResponse> ListSurveyQuestionAnswersAsync(
        ListSurveyQuestionAnswersReportingRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Get responses to a survey.
    /// </summary>
    WithRawResponseTask<ListSurveyResponsesReportingResponse> ListSurveyResponsesAsync(
        ListSurveyResponsesReportingRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Get a single survey response.
    /// </summary>
    WithRawResponseTask<GetSurveyResponsReportingResponse> GetSurveyResponsAsync(
        GetSurveyResponsReportingRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
