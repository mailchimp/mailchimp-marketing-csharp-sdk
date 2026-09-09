namespace Mailchimp.Marketing;

public partial interface IMailchimpClient
{
    public IRootClient Root { get; }
    public IAccountExportsClient AccountExports { get; }
    public IActivityFeedClient ActivityFeed { get; }
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
