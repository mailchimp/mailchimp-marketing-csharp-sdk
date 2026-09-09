namespace Mailchimp.Marketing;

public partial interface ICustomerJourneysClient
{
    /// <summary>
    /// A step trigger in an Automation flow. To use it, create a starting point or step from the Automation flow builder in the app using the Customer Journeys API condition. We’ll provide a url during the process that includes the {journey_id} and {step_id}. You’ll then be able to use this endpoint to trigger the condition for the posted contact.
    /// </summary>
    WithRawResponseTask CreateJourneyStepActionTriggerAsync(
        CreateJourneyStepActionTriggerCustomerJourneysRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
