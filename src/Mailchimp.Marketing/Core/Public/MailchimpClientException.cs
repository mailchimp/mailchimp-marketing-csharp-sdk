namespace Mailchimp.Marketing;

/// <summary>
/// Base exception class for all exceptions thrown by the SDK.
/// </summary>
public class MailchimpClientException(string message, Exception? innerException = null)
    : Exception(message, innerException);
