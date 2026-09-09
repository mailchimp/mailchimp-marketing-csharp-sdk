namespace Mailchimp.Marketing;

public partial interface ISurveysClient
{
    /// <summary>
    /// Utilize the List ID and Survey ID to generate a Campaign that links to your survey.
    /// </summary>
    WithRawResponseTask<Campaign> CreateListSurveyActionCreateEmailAsync(
        CreateListSurveyActionCreateEmailSurveysRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Publish a survey that is in draft, unpublished, or has been previously published and edited.
    /// </summary>
    WithRawResponseTask<object> CreateListSurveyActionPublishAsync(
        CreateListSurveyActionPublishSurveysRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Unpublish a survey that has been published.
    /// </summary>
    WithRawResponseTask<object> CreateListSurveyActionUnpublishAsync(
        CreateListSurveyActionUnpublishSurveysRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
