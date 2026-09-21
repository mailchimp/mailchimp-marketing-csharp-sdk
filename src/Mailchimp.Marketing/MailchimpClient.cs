using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

public partial class MailchimpClient : IMailchimpClient
{
    private readonly RawClient _client;

    public MailchimpClient(string? token = null, ClientOptions? clientOptions = null)
    {
        clientOptions ??= new ClientOptions();
        var platformHeaders = new Headers(
            new Dictionary<string, string>()
            {
                { "X-Fern-Language", "C#" },
                { "X-Fern-SDK-Name", "Mailchimp.Marketing" },
                { "X-Fern-SDK-Version", global::Mailchimp.Marketing.Version.Current },
                { "User-Agent", "Mailchimp.Marketing/1.0.0" },
            }
        );
        foreach (var header in platformHeaders)
        {
            if (!clientOptions.Headers.ContainsKey(header.Key))
            {
                clientOptions.Headers[header.Key] = header.Value;
            }
        }
        var clientOptionsWithAuth = clientOptions.Clone();
        var authHeaders = new Headers(
            new Dictionary<string, string>() { { "Authorization", $"Bearer {token ?? ""}" } }
        );
        foreach (var header in authHeaders)
        {
            clientOptionsWithAuth.Headers[header.Key] = header.Value;
        }
        _client = new RawClient(clientOptionsWithAuth);
        Root = new RootClient(_client);
        AccountExports = new AccountExportsClient(_client);
        ActivityFeed = new ActivityFeedClient(_client);
        Audiences = new AudiencesClient(_client);
        AuthorizedApps = new AuthorizedAppsClient(_client);
        Automations = new AutomationsClient(_client);
        BatchWebhooks = new BatchWebhooksClient(_client);
        Batches = new BatchesClient(_client);
        CampaignFolders = new CampaignFoldersClient(_client);
        Campaigns = new CampaignsClient(_client);
        ConnectedSites = new ConnectedSitesClient(_client);
        Conversations = new ConversationsClient(_client);
        CustomerJourneys = new CustomerJourneysClient(_client);
        Ecommerce = new EcommerceClient(_client);
        FacebookAds = new FacebookAdsClient(_client);
        FileManager = new FileManagerClient(_client);
        LandingPages = new LandingPagesClient(_client);
        Lists = new ListsClient(_client);
        Surveys = new SurveysClient(_client);
        Ping = new PingClient(_client);
        Reporting = new ReportingClient(_client);
        Reports = new ReportsClient(_client);
        SearchCampaigns = new SearchCampaignsClient(_client);
        SmsCampaigns = new SmsCampaignsClient(_client);
        SearchMembers = new SearchMembersClient(_client);
        TemplateFolders = new TemplateFoldersClient(_client);
        Templates = new TemplatesClient(_client);
        VerifiedDomains = new VerifiedDomainsClient(_client);
    }

    public IRootClient Root { get; }

    public IAccountExportsClient AccountExports { get; }

    public IActivityFeedClient ActivityFeed { get; }

    public IAudiencesClient Audiences { get; }

    public IAuthorizedAppsClient AuthorizedApps { get; }

    public IAutomationsClient Automations { get; }

    public IBatchWebhooksClient BatchWebhooks { get; }

    public IBatchesClient Batches { get; }

    public ICampaignFoldersClient CampaignFolders { get; }

    public ICampaignsClient Campaigns { get; }

    public IConnectedSitesClient ConnectedSites { get; }

    public IConversationsClient Conversations { get; }

    public ICustomerJourneysClient CustomerJourneys { get; }

    public IEcommerceClient Ecommerce { get; }

    public IFacebookAdsClient FacebookAds { get; }

    public IFileManagerClient FileManager { get; }

    public ILandingPagesClient LandingPages { get; }

    public IListsClient Lists { get; }

    public ISurveysClient Surveys { get; }

    public IPingClient Ping { get; }

    public IReportingClient Reporting { get; }

    public IReportsClient Reports { get; }

    public ISearchCampaignsClient SearchCampaigns { get; }

    public ISmsCampaignsClient SmsCampaigns { get; }

    public ISearchMembersClient SearchMembers { get; }

    public ITemplateFoldersClient TemplateFolders { get; }

    public ITemplatesClient Templates { get; }

    public IVerifiedDomainsClient VerifiedDomains { get; }
}
