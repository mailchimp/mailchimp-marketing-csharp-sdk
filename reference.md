# Reference
## root
<details><summary><code>client.Root.<a href="/src/Mailchimp.Marketing/Root/RootClient.cs">ListAsync</a>(ListRootRequest { ... }) -> WithRawResponseTask&lt;ListRootResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get links to all other resources available in the API.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Root.ListAsync(new ListRootRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ListRootRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## AccountExports
<details><summary><code>client.AccountExports.<a href="/src/Mailchimp.Marketing/AccountExports/AccountExportsClient.cs">ListAsync</a>(ListAccountExportsRequest { ... }) -> Pager&lt;ListAccountExportsResponseExportsItem&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get a list of account exports for a given account.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.AccountExports.ListAsync(new ListAccountExportsRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ListAccountExportsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.AccountExports.<a href="/src/Mailchimp.Marketing/AccountExports/AccountExportsClient.cs">CreateAsync</a>(CreateAccountExportsRequest { ... }) -> WithRawResponseTask&lt;CreateAccountExportsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Create a new account export in your Mailchimp account.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.AccountExports.CreateAsync(
    new CreateAccountExportsRequest
    {
        IncludeStages =
            new global::System.Collections.Generic.List<CreateAccountExportsRequestIncludeStagesItem>()
            {
                CreateAccountExportsRequestIncludeStagesItem.Audiences,
                CreateAccountExportsRequestIncludeStagesItem.GalleryFiles,
            },
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `CreateAccountExportsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.AccountExports.<a href="/src/Mailchimp.Marketing/AccountExports/AccountExportsClient.cs">GetAsync</a>(GetAccountExportsRequest { ... }) -> WithRawResponseTask&lt;GetAccountExportsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get information about a specific account export.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.AccountExports.GetAsync(new GetAccountExportsRequest { ExportId = "export_id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `GetAccountExportsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## ActivityFeed
<details><summary><code>client.ActivityFeed.<a href="/src/Mailchimp.Marketing/ActivityFeed/ActivityFeedClient.cs">ListAsync</a>() -> WithRawResponseTask&lt;IEnumerable&lt;ListActivityFeedResponseItem&gt;&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get information about the activity feed endpoint's resources.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.ActivityFeed.ListAsync();
```
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.ActivityFeed.<a href="/src/Mailchimp.Marketing/ActivityFeed/ActivityFeedClient.cs">ListChimpChatterAsync</a>(ListChimpChatterActivityFeedRequest { ... }) -> Pager&lt;ListChimpChatterActivityFeedResponseChimpChatterItem&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Return the Chimp Chatter for this account ordered by most recent.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.ActivityFeed.ListChimpChatterAsync(new ListChimpChatterActivityFeedRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ListChimpChatterActivityFeedRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Audiences
<details><summary><code>client.Audiences.<a href="/src/Mailchimp.Marketing/Audiences/AudiencesClient.cs">GetAudienceContactListAsync</a>(GetAudienceContactListRequest { ... }) -> WithRawResponseTask&lt;GetAudienceContactListResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get a list of omni-channel contacts for a given audience.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Audiences.GetAudienceContactListAsync(
    new GetAudienceContactListRequest { AudienceId = "audience_id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `GetAudienceContactListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Audiences.<a href="/src/Mailchimp.Marketing/Audiences/AudiencesClient.cs">CreateAudienceContactAsync</a>(CreateAudienceContactRequest { ... }) -> WithRawResponseTask&lt;AudiencesContact&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Create a new omni-channel contact for an audience.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Audiences.CreateAudienceContactAsync(
    new CreateAudienceContactRequest { AudienceId = "audience_id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `CreateAudienceContactRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Audiences.<a href="/src/Mailchimp.Marketing/Audiences/AudiencesClient.cs">GetAudienceContactAsync</a>(GetAudienceContactRequest { ... }) -> WithRawResponseTask&lt;AudiencesContact&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Retrieve a specific omni-channel contact in an audience.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Audiences.GetAudienceContactAsync(
    new GetAudienceContactRequest { AudienceId = "audience_id", ContactId = "contact_id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `GetAudienceContactRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Audiences.<a href="/src/Mailchimp.Marketing/Audiences/AudiencesClient.cs">PatchAudienceContactAsync</a>(PatchAudienceContactRequest { ... }) -> WithRawResponseTask&lt;AudiencesContact&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Update an existing omni-channel contact.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Audiences.PatchAudienceContactAsync(
    new PatchAudienceContactRequest { AudienceId = "audience_id", ContactId = "contact_id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PatchAudienceContactRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Audiences.<a href="/src/Mailchimp.Marketing/Audiences/AudiencesClient.cs">PostAudiencesContactsActionsArchiveAsync</a>(PostAudiencesContactsActionsArchiveRequest { ... }) -> WithRawResponseTask</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Archives a Contact.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Audiences.PostAudiencesContactsActionsArchiveAsync(
    new PostAudiencesContactsActionsArchiveRequest
    {
        AudienceId = "audience_id",
        ContactId = "contact_id",
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostAudiencesContactsActionsArchiveRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Audiences.<a href="/src/Mailchimp.Marketing/Audiences/AudiencesClient.cs">PostAudiencesContactsActionsForgetAsync</a>(PostAudiencesContactsActionsForgetRequest { ... }) -> WithRawResponseTask</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Forgets a Contact.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Audiences.PostAudiencesContactsActionsForgetAsync(
    new PostAudiencesContactsActionsForgetRequest
    {
        AudienceId = "audience_id",
        ContactId = "contact_id",
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostAudiencesContactsActionsForgetRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## AuthorizedApps
<details><summary><code>client.AuthorizedApps.<a href="/src/Mailchimp.Marketing/AuthorizedApps/AuthorizedAppsClient.cs">ListAsync</a>(ListAuthorizedAppsRequest { ... }) -> Pager&lt;ListAuthorizedAppsResponseAppsItem&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get a list of an account's registered, connected applications.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.AuthorizedApps.ListAsync(new ListAuthorizedAppsRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ListAuthorizedAppsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.AuthorizedApps.<a href="/src/Mailchimp.Marketing/AuthorizedApps/AuthorizedAppsClient.cs">GetAsync</a>(GetAuthorizedAppsRequest { ... }) -> WithRawResponseTask&lt;GetAuthorizedAppsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get information about a specific authorized application.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.AuthorizedApps.GetAsync(new GetAuthorizedAppsRequest { AppId = "app_id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `GetAuthorizedAppsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## automations
<details><summary><code>client.Automations.<a href="/src/Mailchimp.Marketing/Automations/AutomationsClient.cs">ListAsync</a>(ListAutomationsRequest { ... }) -> Pager&lt;AutomationWorkflow&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get a summary of an account's classic automations.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Automations.ListAsync(new ListAutomationsRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ListAutomationsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Automations.<a href="/src/Mailchimp.Marketing/Automations/AutomationsClient.cs">CreateAsync</a>(CreateAutomationsRequest { ... }) -> WithRawResponseTask&lt;AutomationWorkflow&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Create a new classic automation in your Mailchimp account.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Automations.CreateAsync(
    new CreateAutomationsRequest
    {
        Recipients = new CreateAutomationsRequestRecipients(),
        TriggerSettings = new CreateAutomationsRequestTriggerSettings
        {
            WorkflowType = CreateAutomationsRequestTriggerSettingsWorkflowType.AbandonedBrowse,
        },
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `CreateAutomationsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Automations.<a href="/src/Mailchimp.Marketing/Automations/AutomationsClient.cs">GetAsync</a>(GetAutomationsRequest { ... }) -> WithRawResponseTask&lt;AutomationWorkflow&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get a summary of an individual classic automation workflow's settings and content. The `trigger_settings` object returns information for the first email in the workflow.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Automations.GetAsync(new GetAutomationsRequest { WorkflowId = "workflow_id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `GetAutomationsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Automations.<a href="/src/Mailchimp.Marketing/Automations/AutomationsClient.cs">CreateActionArchiveAsync</a>(CreateActionArchiveAutomationsRequest { ... }) -> WithRawResponseTask</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Archiving will permanently end your automation and keep the report data. You’ll be able to replicate your archived automation, but you can’t restart it.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Automations.CreateActionArchiveAsync(
    new CreateActionArchiveAutomationsRequest { WorkflowId = "workflow_id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `CreateActionArchiveAutomationsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Automations.<a href="/src/Mailchimp.Marketing/Automations/AutomationsClient.cs">CreateActionPauseAllEmailAsync</a>(CreateActionPauseAllEmailAutomationsRequest { ... }) -> WithRawResponseTask</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Pause all emails in a specific classic automation workflow.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Automations.CreateActionPauseAllEmailAsync(
    new CreateActionPauseAllEmailAutomationsRequest { WorkflowId = "workflow_id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `CreateActionPauseAllEmailAutomationsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Automations.<a href="/src/Mailchimp.Marketing/Automations/AutomationsClient.cs">CreateActionStartAllEmailAsync</a>(CreateActionStartAllEmailAutomationsRequest { ... }) -> WithRawResponseTask</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Start all emails in a classic automation workflow.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Automations.CreateActionStartAllEmailAsync(
    new CreateActionStartAllEmailAutomationsRequest { WorkflowId = "workflow_id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `CreateActionStartAllEmailAutomationsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Automations.<a href="/src/Mailchimp.Marketing/Automations/AutomationsClient.cs">ListEmailsAsync</a>(ListEmailsAutomationsRequest { ... }) -> WithRawResponseTask&lt;ListEmailsAutomationsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get a summary of the emails in a classic automation workflow.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Automations.ListEmailsAsync(
    new ListEmailsAutomationsRequest { WorkflowId = "workflow_id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ListEmailsAutomationsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Automations.<a href="/src/Mailchimp.Marketing/Automations/AutomationsClient.cs">GetEmailAsync</a>(GetEmailAutomationsRequest { ... }) -> WithRawResponseTask&lt;AutomationWorkflowEmail&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get information about an individual classic automation workflow email.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Automations.GetEmailAsync(
    new GetEmailAutomationsRequest
    {
        WorkflowId = "workflow_id",
        WorkflowEmailId = "workflow_email_id",
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `GetEmailAutomationsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Automations.<a href="/src/Mailchimp.Marketing/Automations/AutomationsClient.cs">DeleteEmailAsync</a>(DeleteEmailAutomationsRequest { ... }) -> WithRawResponseTask</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Removes an individual classic automation workflow email. Emails from certain workflow types, including the Abandoned Cart Email (abandonedCart) and Product Retargeting Email (abandonedBrowse) Workflows, cannot be deleted.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Automations.DeleteEmailAsync(
    new DeleteEmailAutomationsRequest
    {
        WorkflowId = "workflow_id",
        WorkflowEmailId = "workflow_email_id",
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `DeleteEmailAutomationsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Automations.<a href="/src/Mailchimp.Marketing/Automations/AutomationsClient.cs">UpdateEmailAsync</a>(UpdateEmailAutomationsRequest { ... }) -> WithRawResponseTask&lt;AutomationWorkflowEmail&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Update settings for a classic automation workflow email.  Only works with workflows of type: abandonedBrowse, abandonedCart, emailFollowup, or singleWelcome.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Automations.UpdateEmailAsync(
    new UpdateEmailAutomationsRequest
    {
        WorkflowId = "workflow_id",
        WorkflowEmailId = "workflow_email_id",
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `UpdateEmailAutomationsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Automations.<a href="/src/Mailchimp.Marketing/Automations/AutomationsClient.cs">CreateEmailActionPauseAsync</a>(CreateEmailActionPauseAutomationsRequest { ... }) -> WithRawResponseTask</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Pause an automated email.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Automations.CreateEmailActionPauseAsync(
    new CreateEmailActionPauseAutomationsRequest
    {
        WorkflowId = "workflow_id",
        WorkflowEmailId = "workflow_email_id",
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `CreateEmailActionPauseAutomationsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Automations.<a href="/src/Mailchimp.Marketing/Automations/AutomationsClient.cs">CreateEmailActionStartAsync</a>(CreateEmailActionStartAutomationsRequest { ... }) -> WithRawResponseTask</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Start an automated email.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Automations.CreateEmailActionStartAsync(
    new CreateEmailActionStartAutomationsRequest
    {
        WorkflowId = "workflow_id",
        WorkflowEmailId = "workflow_email_id",
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `CreateEmailActionStartAutomationsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Automations.<a href="/src/Mailchimp.Marketing/Automations/AutomationsClient.cs">ListEmailQueueAsync</a>(ListEmailQueueAutomationsRequest { ... }) -> WithRawResponseTask&lt;ListEmailQueueAutomationsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get information about a classic automation email queue.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Automations.ListEmailQueueAsync(
    new ListEmailQueueAutomationsRequest
    {
        WorkflowId = "workflow_id",
        WorkflowEmailId = "workflow_email_id",
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ListEmailQueueAutomationsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Automations.<a href="/src/Mailchimp.Marketing/Automations/AutomationsClient.cs">CreateEmailQueueAsync</a>(CreateEmailQueueAutomationsRequest { ... }) -> WithRawResponseTask&lt;SubscriberInAutomationQueue&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Manually add a subscriber to a workflow, bypassing the default trigger settings. You can also use this endpoint to trigger a series of automated emails in an API 3.0 workflow type.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Automations.CreateEmailQueueAsync(
    new CreateEmailQueueAutomationsRequest
    {
        WorkflowId = "workflow_id",
        WorkflowEmailId = "workflow_email_id",
        EmailAddress = "email_address",
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `CreateEmailQueueAutomationsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Automations.<a href="/src/Mailchimp.Marketing/Automations/AutomationsClient.cs">GetEmailQueueAsync</a>(GetEmailQueueAutomationsRequest { ... }) -> WithRawResponseTask&lt;SubscriberInAutomationQueue&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get information about a specific subscriber in a classic automation email queue.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Automations.GetEmailQueueAsync(
    new GetEmailQueueAutomationsRequest
    {
        WorkflowId = "workflow_id",
        WorkflowEmailId = "workflow_email_id",
        SubscriberHash = "subscriber_hash",
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `GetEmailQueueAutomationsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Automations.<a href="/src/Mailchimp.Marketing/Automations/AutomationsClient.cs">ListRemovedSubscribersAsync</a>(ListRemovedSubscribersAutomationsRequest { ... }) -> WithRawResponseTask&lt;ListRemovedSubscribersAutomationsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get information about subscribers who were removed from a classic automation workflow.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Automations.ListRemovedSubscribersAsync(
    new ListRemovedSubscribersAutomationsRequest { WorkflowId = "workflow_id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ListRemovedSubscribersAutomationsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Automations.<a href="/src/Mailchimp.Marketing/Automations/AutomationsClient.cs">CreateRemovedSubscriberAsync</a>(CreateRemovedSubscriberAutomationsRequest { ... }) -> WithRawResponseTask&lt;SubscriberRemovedFromAutomationWorkflow&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Remove a subscriber from a specific classic automation workflow. You can remove a subscriber at any point in an automation workflow, regardless of how many emails they've been sent from that workflow. Once they're removed, they can never be added back to the same workflow.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Automations.CreateRemovedSubscriberAsync(
    new CreateRemovedSubscriberAutomationsRequest
    {
        WorkflowId = "workflow_id",
        EmailAddress = "email_address",
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `CreateRemovedSubscriberAutomationsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Automations.<a href="/src/Mailchimp.Marketing/Automations/AutomationsClient.cs">GetRemovedSubscriberAsync</a>(GetRemovedSubscriberAutomationsRequest { ... }) -> WithRawResponseTask&lt;SubscriberRemovedFromAutomationWorkflow&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get information about a specific subscriber who was removed from a classic automation workflow.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Automations.GetRemovedSubscriberAsync(
    new GetRemovedSubscriberAutomationsRequest
    {
        WorkflowId = "workflow_id",
        SubscriberHash = "subscriber_hash",
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `GetRemovedSubscriberAutomationsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## BatchWebhooks
<details><summary><code>client.BatchWebhooks.<a href="/src/Mailchimp.Marketing/BatchWebhooks/BatchWebhooksClient.cs">ListAsync</a>(ListBatchWebhooksRequest { ... }) -> Pager&lt;BatchWebhook&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get all webhooks that have been configured for batches.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.BatchWebhooks.ListAsync(new ListBatchWebhooksRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ListBatchWebhooksRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.BatchWebhooks.<a href="/src/Mailchimp.Marketing/BatchWebhooks/BatchWebhooksClient.cs">CreateAsync</a>(CreateBatchWebhooksRequest { ... }) -> WithRawResponseTask&lt;CreateBatchWebhooksResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Configure a webhook that will fire whenever any batch request completes processing.  You may only have a maximum of 20 batch webhooks.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.BatchWebhooks.CreateAsync(
    new CreateBatchWebhooksRequest { Url = "http://yourdomain.com/webhook" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `CreateBatchWebhooksRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.BatchWebhooks.<a href="/src/Mailchimp.Marketing/BatchWebhooks/BatchWebhooksClient.cs">GetAsync</a>(GetBatchWebhooksRequest { ... }) -> WithRawResponseTask&lt;BatchWebhook&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get information about a specific batch webhook.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.BatchWebhooks.GetAsync(
    new GetBatchWebhooksRequest { BatchWebhookId = "batch_webhook_id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `GetBatchWebhooksRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.BatchWebhooks.<a href="/src/Mailchimp.Marketing/BatchWebhooks/BatchWebhooksClient.cs">DeleteAsync</a>(DeleteBatchWebhooksRequest { ... }) -> WithRawResponseTask</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Remove a batch webhook. Webhooks will no longer be sent to the given URL.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.BatchWebhooks.DeleteAsync(
    new DeleteBatchWebhooksRequest { BatchWebhookId = "batch_webhook_id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `DeleteBatchWebhooksRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.BatchWebhooks.<a href="/src/Mailchimp.Marketing/BatchWebhooks/BatchWebhooksClient.cs">UpdateAsync</a>(UpdateBatchWebhooksRequest { ... }) -> WithRawResponseTask&lt;BatchWebhook&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Update a webhook that will fire whenever any batch request completes processing.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.BatchWebhooks.UpdateAsync(
    new UpdateBatchWebhooksRequest { BatchWebhookId = "batch_webhook_id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `UpdateBatchWebhooksRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## batches
<details><summary><code>client.Batches.<a href="/src/Mailchimp.Marketing/Batches/BatchesClient.cs">ListAsync</a>(ListBatchesRequest { ... }) -> Pager&lt;Batch&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get a summary of batch requests that have been made.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Batches.ListAsync(new ListBatchesRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ListBatchesRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Batches.<a href="/src/Mailchimp.Marketing/Batches/BatchesClient.cs">CreateAsync</a>(CreateBatchesRequest { ... }) -> WithRawResponseTask&lt;Batch&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Begin processing a batch operations request.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Batches.CreateAsync(
    new CreateBatchesRequest
    {
        Operations =
            new global::System.Collections.Generic.List<CreateBatchesRequestOperationsItem>()
            {
                new CreateBatchesRequestOperationsItem
                {
                    Method = CreateBatchesRequestOperationsItemMethod.Get,
                    Path = "/lists",
                },
            },
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `CreateBatchesRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Batches.<a href="/src/Mailchimp.Marketing/Batches/BatchesClient.cs">GetAsync</a>(GetBatchesRequest { ... }) -> WithRawResponseTask&lt;Batch&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get the status of a batch request.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Batches.GetAsync(new GetBatchesRequest { BatchId = "batch_id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `GetBatchesRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Batches.<a href="/src/Mailchimp.Marketing/Batches/BatchesClient.cs">DeleteAsync</a>(DeleteBatchesRequest { ... }) -> WithRawResponseTask</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Stops a batch request from running. Since only one batch request is run at a time, this can be used to cancel a long running request. The results of any completed operations will not be available after this call.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Batches.DeleteAsync(new DeleteBatchesRequest { BatchId = "batch_id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `DeleteBatchesRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## CampaignFolders
<details><summary><code>client.CampaignFolders.<a href="/src/Mailchimp.Marketing/CampaignFolders/CampaignFoldersClient.cs">ListAsync</a>(ListCampaignFoldersRequest { ... }) -> Pager&lt;CampaignFoldersFoldersItem&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get all folders used to organize campaigns.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.CampaignFolders.ListAsync(new ListCampaignFoldersRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ListCampaignFoldersRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.CampaignFolders.<a href="/src/Mailchimp.Marketing/CampaignFolders/CampaignFoldersClient.cs">CreateAsync</a>(CreateCampaignFoldersRequest { ... }) -> WithRawResponseTask&lt;CampaignFolders&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Create a new campaign folder.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.CampaignFolders.CreateAsync(new CreateCampaignFoldersRequest { Name = "name" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `CreateCampaignFoldersRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.CampaignFolders.<a href="/src/Mailchimp.Marketing/CampaignFolders/CampaignFoldersClient.cs">GetAsync</a>(GetCampaignFoldersRequest { ... }) -> WithRawResponseTask&lt;GetCampaignFoldersResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get information about a specific folder used to organize campaigns.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.CampaignFolders.GetAsync(new GetCampaignFoldersRequest { FolderId = "folder_id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `GetCampaignFoldersRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.CampaignFolders.<a href="/src/Mailchimp.Marketing/CampaignFolders/CampaignFoldersClient.cs">DeleteAsync</a>(DeleteCampaignFoldersRequest { ... }) -> WithRawResponseTask</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Delete a specific campaign folder, and mark all the campaigns in the folder as 'unfiled'.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.CampaignFolders.DeleteAsync(
    new DeleteCampaignFoldersRequest { FolderId = "folder_id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `DeleteCampaignFoldersRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.CampaignFolders.<a href="/src/Mailchimp.Marketing/CampaignFolders/CampaignFoldersClient.cs">UpdateAsync</a>(UpdateCampaignFoldersRequest { ... }) -> WithRawResponseTask&lt;UpdateCampaignFoldersResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Update a specific folder used to organize campaigns.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.CampaignFolders.UpdateAsync(
    new UpdateCampaignFoldersRequest { FolderId = "folder_id", Name = "name" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `UpdateCampaignFoldersRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## campaigns
<details><summary><code>client.Campaigns.<a href="/src/Mailchimp.Marketing/Campaigns/CampaignsClient.cs">ListAsync</a>(ListCampaignsRequest { ... }) -> Pager&lt;Campaigns&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get all campaigns in an account.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Campaigns.ListAsync(new ListCampaignsRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ListCampaignsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Campaigns.<a href="/src/Mailchimp.Marketing/Campaigns/CampaignsClient.cs">CreateAsync</a>(CreateCampaignsRequest { ... }) -> WithRawResponseTask&lt;Campaign&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Create a new Mailchimp campaign.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Campaigns.CreateAsync(
    new CreateCampaignsRequest { Type = CreateCampaignsRequestType.Regular }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `CreateCampaignsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Campaigns.<a href="/src/Mailchimp.Marketing/Campaigns/CampaignsClient.cs">GetAsync</a>(GetCampaignsRequest { ... }) -> WithRawResponseTask&lt;Campaign&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get information about a specific campaign.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Campaigns.GetAsync(new GetCampaignsRequest { CampaignId = "campaign_id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `GetCampaignsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Campaigns.<a href="/src/Mailchimp.Marketing/Campaigns/CampaignsClient.cs">DeleteAsync</a>(DeleteCampaignsRequest { ... }) -> WithRawResponseTask</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Remove a campaign from your Mailchimp account.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Campaigns.DeleteAsync(new DeleteCampaignsRequest { CampaignId = "campaign_id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `DeleteCampaignsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Campaigns.<a href="/src/Mailchimp.Marketing/Campaigns/CampaignsClient.cs">UpdateAsync</a>(UpdateCampaignsRequest { ... }) -> WithRawResponseTask&lt;Campaign&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Update some or all of the settings for a specific campaign.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Campaigns.UpdateAsync(new UpdateCampaignsRequest { CampaignId = "campaign_id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `UpdateCampaignsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Campaigns.<a href="/src/Mailchimp.Marketing/Campaigns/CampaignsClient.cs">CreateActionCancelSendAsync</a>(CreateActionCancelSendCampaignsRequest { ... }) -> WithRawResponseTask</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Cancel a Regular or Plain-Text Campaign after you send, before all of your recipients receive it. This feature is included with Mailchimp Pro.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Campaigns.CreateActionCancelSendAsync(
    new CreateActionCancelSendCampaignsRequest { CampaignId = "campaign_id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `CreateActionCancelSendCampaignsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Campaigns.<a href="/src/Mailchimp.Marketing/Campaigns/CampaignsClient.cs">CreateActionCreateResendAsync</a>(CreateActionCreateResendCampaignsRequest { ... }) -> WithRawResponseTask&lt;Campaign&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Remove the guesswork for resending a campaign to certain segments. You can use this endpoint as a shortcut to replicate a campaign and resend it to common segments, such as those who didn't open the campaign, or any new subscribers since it was sent.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Campaigns.CreateActionCreateResendAsync(
    new CreateActionCreateResendCampaignsRequest { CampaignId = "campaign_id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `CreateActionCreateResendCampaignsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Campaigns.<a href="/src/Mailchimp.Marketing/Campaigns/CampaignsClient.cs">CreateActionPauseAsync</a>(CreateActionPauseCampaignsRequest { ... }) -> WithRawResponseTask</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Pause an RSS-Driven campaign.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Campaigns.CreateActionPauseAsync(
    new CreateActionPauseCampaignsRequest { CampaignId = "campaign_id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `CreateActionPauseCampaignsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Campaigns.<a href="/src/Mailchimp.Marketing/Campaigns/CampaignsClient.cs">CreateActionReplicateAsync</a>(CreateActionReplicateCampaignsRequest { ... }) -> WithRawResponseTask&lt;Campaign&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Replicate a campaign in saved or send status.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Campaigns.CreateActionReplicateAsync(
    new CreateActionReplicateCampaignsRequest { CampaignId = "campaign_id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `CreateActionReplicateCampaignsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Campaigns.<a href="/src/Mailchimp.Marketing/Campaigns/CampaignsClient.cs">CreateActionResumeAsync</a>(CreateActionResumeCampaignsRequest { ... }) -> WithRawResponseTask</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Resume an RSS-Driven campaign.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Campaigns.CreateActionResumeAsync(
    new CreateActionResumeCampaignsRequest { CampaignId = "campaign_id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `CreateActionResumeCampaignsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Campaigns.<a href="/src/Mailchimp.Marketing/Campaigns/CampaignsClient.cs">CreateActionScheduleAsync</a>(CreateActionScheduleCampaignsRequest { ... }) -> WithRawResponseTask</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Schedule a campaign for delivery. If you're using Multivariate Campaigns to test send times or sending RSS Campaigns, use the send action instead.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Campaigns.CreateActionScheduleAsync(
    new CreateActionScheduleCampaignsRequest
    {
        CampaignId = "campaign_id",
        ScheduleTime = new DateTime(2024, 01, 15, 09, 30, 00, 000),
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `CreateActionScheduleCampaignsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Campaigns.<a href="/src/Mailchimp.Marketing/Campaigns/CampaignsClient.cs">CreateActionSendAsync</a>(CreateActionSendCampaignsRequest { ... }) -> WithRawResponseTask</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Send a Mailchimp campaign. For RSS Campaigns, the campaign will send according to its schedule. All other campaigns will send immediately.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Campaigns.CreateActionSendAsync(
    new CreateActionSendCampaignsRequest { CampaignId = "campaign_id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `CreateActionSendCampaignsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Campaigns.<a href="/src/Mailchimp.Marketing/Campaigns/CampaignsClient.cs">CreateActionTestAsync</a>(CreateActionTestCampaignsRequest { ... }) -> WithRawResponseTask</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Send a test email.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Campaigns.CreateActionTestAsync(
    new CreateActionTestCampaignsRequest
    {
        CampaignId = "campaign_id",
        SendType = CreateActionTestCampaignsRequestSendType.Html,
        TestEmails = new global::System.Collections.Generic.List<string>() { "test_emails" },
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `CreateActionTestCampaignsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Campaigns.<a href="/src/Mailchimp.Marketing/Campaigns/CampaignsClient.cs">CreateActionUnscheduleAsync</a>(CreateActionUnscheduleCampaignsRequest { ... }) -> WithRawResponseTask</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Unschedule a scheduled campaign that hasn't started sending.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Campaigns.CreateActionUnscheduleAsync(
    new CreateActionUnscheduleCampaignsRequest { CampaignId = "campaign_id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `CreateActionUnscheduleCampaignsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Campaigns.<a href="/src/Mailchimp.Marketing/Campaigns/CampaignsClient.cs">GetContentAsync</a>(GetContentCampaignsRequest { ... }) -> WithRawResponseTask&lt;CampaignContent&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get the the HTML and plain-text content for a campaign.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Campaigns.GetContentAsync(
    new GetContentCampaignsRequest { CampaignId = "campaign_id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `GetContentCampaignsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Campaigns.<a href="/src/Mailchimp.Marketing/Campaigns/CampaignsClient.cs">UpsertContentAsync</a>(UpsertContentCampaignsRequest { ... }) -> WithRawResponseTask&lt;CampaignContent&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Set the content for a campaign.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Campaigns.UpsertContentAsync(
    new UpsertContentCampaignsRequest { CampaignId = "campaign_id", Body = new CampaignContent() }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `UpsertContentCampaignsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Campaigns.<a href="/src/Mailchimp.Marketing/Campaigns/CampaignsClient.cs">ListFeedbackAsync</a>(ListFeedbackCampaignsRequest { ... }) -> WithRawResponseTask&lt;ListFeedbackCampaignsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get team feedback while you're working together on a Mailchimp campaign.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Campaigns.ListFeedbackAsync(
    new ListFeedbackCampaignsRequest { CampaignId = "campaign_id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ListFeedbackCampaignsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Campaigns.<a href="/src/Mailchimp.Marketing/Campaigns/CampaignsClient.cs">CreateFeedbackAsync</a>(CreateFeedbackCampaignsRequest { ... }) -> WithRawResponseTask&lt;CreateFeedbackCampaignsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Add feedback on a specific campaign.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Campaigns.CreateFeedbackAsync(
    new CreateFeedbackCampaignsRequest { CampaignId = "campaign_id", Message = "message" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `CreateFeedbackCampaignsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Campaigns.<a href="/src/Mailchimp.Marketing/Campaigns/CampaignsClient.cs">GetFeedbackAsync</a>(GetFeedbackCampaignsRequest { ... }) -> WithRawResponseTask&lt;CampaignFeedback&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get a specific feedback message from a campaign.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Campaigns.GetFeedbackAsync(
    new GetFeedbackCampaignsRequest { CampaignId = "campaign_id", FeedbackId = "feedback_id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `GetFeedbackCampaignsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Campaigns.<a href="/src/Mailchimp.Marketing/Campaigns/CampaignsClient.cs">DeleteFeedbackAsync</a>(DeleteFeedbackCampaignsRequest { ... }) -> WithRawResponseTask</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Remove a specific feedback message for a campaign.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Campaigns.DeleteFeedbackAsync(
    new DeleteFeedbackCampaignsRequest { CampaignId = "campaign_id", FeedbackId = "feedback_id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `DeleteFeedbackCampaignsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Campaigns.<a href="/src/Mailchimp.Marketing/Campaigns/CampaignsClient.cs">UpdateFeedbackAsync</a>(UpdateFeedbackCampaignsRequest { ... }) -> WithRawResponseTask&lt;CampaignFeedback&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Update a specific feedback message for a campaign.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Campaigns.UpdateFeedbackAsync(
    new UpdateFeedbackCampaignsRequest { CampaignId = "campaign_id", FeedbackId = "feedback_id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `UpdateFeedbackCampaignsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Campaigns.<a href="/src/Mailchimp.Marketing/Campaigns/CampaignsClient.cs">ListSendChecklistAsync</a>(ListSendChecklistCampaignsRequest { ... }) -> WithRawResponseTask&lt;ListSendChecklistCampaignsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Review the send checklist for a campaign, and resolve any issues before sending.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Campaigns.ListSendChecklistAsync(
    new ListSendChecklistCampaignsRequest { CampaignId = "campaign_id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ListSendChecklistCampaignsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## ConnectedSites
<details><summary><code>client.ConnectedSites.<a href="/src/Mailchimp.Marketing/ConnectedSites/ConnectedSitesClient.cs">ListAsync</a>(ListConnectedSitesRequest { ... }) -> Pager&lt;ConnectedSite&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get all connected sites in an account.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.ConnectedSites.ListAsync(new ListConnectedSitesRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ListConnectedSitesRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.ConnectedSites.<a href="/src/Mailchimp.Marketing/ConnectedSites/ConnectedSitesClient.cs">CreateAsync</a>(CreateConnectedSitesRequest { ... }) -> WithRawResponseTask&lt;ConnectedSite&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Create a new Mailchimp connected site.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.ConnectedSites.CreateAsync(
    new CreateConnectedSitesRequest { Domain = "example.com", ForeignId = "MC001" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `CreateConnectedSitesRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.ConnectedSites.<a href="/src/Mailchimp.Marketing/ConnectedSites/ConnectedSitesClient.cs">GetAsync</a>(GetConnectedSitesRequest { ... }) -> WithRawResponseTask&lt;ConnectedSite&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get information about a specific connected site.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.ConnectedSites.GetAsync(
    new GetConnectedSitesRequest { ConnectedSiteId = "connected_site_id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `GetConnectedSitesRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.ConnectedSites.<a href="/src/Mailchimp.Marketing/ConnectedSites/ConnectedSitesClient.cs">DeleteAsync</a>(DeleteConnectedSitesRequest { ... }) -> WithRawResponseTask</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Remove a connected site from your Mailchimp account.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.ConnectedSites.DeleteAsync(
    new DeleteConnectedSitesRequest { ConnectedSiteId = "connected_site_id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `DeleteConnectedSitesRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.ConnectedSites.<a href="/src/Mailchimp.Marketing/ConnectedSites/ConnectedSitesClient.cs">CreateActionVerifyScriptInstallationAsync</a>(CreateActionVerifyScriptInstallationConnectedSitesRequest { ... }) -> WithRawResponseTask</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Verify that the connected sites script has been installed, either via the script URL or fragment.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.ConnectedSites.CreateActionVerifyScriptInstallationAsync(
    new CreateActionVerifyScriptInstallationConnectedSitesRequest
    {
        ConnectedSiteId = "connected_site_id",
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `CreateActionVerifyScriptInstallationConnectedSitesRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## conversations
<details><summary><code>client.Conversations.<a href="/src/Mailchimp.Marketing/Conversations/ConversationsClient.cs">ListAsync</a>(ListConversationsRequest { ... }) -> Pager&lt;Conversation&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get a list of conversations for the account. Conversations has been deprecated in favor of Inbox and these endpoints don't include Inbox data. Past Conversations are still available via this endpoint, but new campaign replies and other Inbox messages aren’t available using this endpoint.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Conversations.ListAsync(new ListConversationsRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ListConversationsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Conversations.<a href="/src/Mailchimp.Marketing/Conversations/ConversationsClient.cs">GetAsync</a>(GetConversationsRequest { ... }) -> WithRawResponseTask&lt;Conversation&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get details about an individual conversation. Conversations has been deprecated in favor of Inbox and these endpoints don't include Inbox data. Past Conversations are still available via this endpoint, but new campaign replies and other Inbox messages aren’t available using this endpoint.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Conversations.GetAsync(
    new GetConversationsRequest { ConversationId = "conversation_id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `GetConversationsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Conversations.<a href="/src/Mailchimp.Marketing/Conversations/ConversationsClient.cs">ListMessagesAsync</a>(ListMessagesConversationsRequest { ... }) -> WithRawResponseTask&lt;ListMessagesConversationsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get messages from a specific conversation. Conversations has been deprecated in favor of Inbox and these endpoints don't include Inbox data. Past Conversations are still available via this endpoint, but new campaign replies and other Inbox messages aren’t available using this endpoint.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Conversations.ListMessagesAsync(
    new ListMessagesConversationsRequest { ConversationId = "conversation_id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ListMessagesConversationsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Conversations.<a href="/src/Mailchimp.Marketing/Conversations/ConversationsClient.cs">GetMessageAsync</a>(GetMessageConversationsRequest { ... }) -> WithRawResponseTask&lt;ConversationMessage&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get an individual message in a conversation. Conversations has been deprecated in favor of Inbox and these endpoints don't include Inbox data. Past Conversations are still available via this endpoint, but new campaign replies and other Inbox messages aren’t available using this endpoint.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Conversations.GetMessageAsync(
    new GetMessageConversationsRequest
    {
        ConversationId = "conversation_id",
        MessageId = "message_id",
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `GetMessageConversationsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## CustomerJourneys
<details><summary><code>client.CustomerJourneys.<a href="/src/Mailchimp.Marketing/CustomerJourneys/CustomerJourneysClient.cs">CreateJourneyStepActionTriggerAsync</a>(CreateJourneyStepActionTriggerCustomerJourneysRequest { ... }) -> WithRawResponseTask</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

A step trigger in an Automation flow. To use it, create a starting point or step from the Automation flow builder in the app using the Customer Journeys API condition. We’ll provide a url during the process that includes the {journey_id} and {step_id}. You’ll then be able to use this endpoint to trigger the condition for the posted contact.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.CustomerJourneys.CreateJourneyStepActionTriggerAsync(
    new CreateJourneyStepActionTriggerCustomerJourneysRequest
    {
        JourneyId = 1,
        StepId = 1,
        EmailAddress = "email_address",
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `CreateJourneyStepActionTriggerCustomerJourneysRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## ecommerce
<details><summary><code>client.Ecommerce.<a href="/src/Mailchimp.Marketing/Ecommerce/EcommerceClient.cs">ListAsync</a>() -> WithRawResponseTask&lt;ListEcommerceResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get information about the e-commerce endpoint's resources.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ecommerce.ListAsync();
```
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Ecommerce.<a href="/src/Mailchimp.Marketing/Ecommerce/EcommerceClient.cs">ListOrdersAsync</a>(ListOrdersEcommerceRequest { ... }) -> Pager&lt;ECommerceOrder&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get information about an account's orders.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ecommerce.ListOrdersAsync(new ListOrdersEcommerceRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ListOrdersEcommerceRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Ecommerce.<a href="/src/Mailchimp.Marketing/Ecommerce/EcommerceClient.cs">ListStoresAsync</a>(ListStoresEcommerceRequest { ... }) -> Pager&lt;ECommerceStore&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get information about all stores in the account.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ecommerce.ListStoresAsync(new ListStoresEcommerceRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ListStoresEcommerceRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Ecommerce.<a href="/src/Mailchimp.Marketing/Ecommerce/EcommerceClient.cs">CreateStoreAsync</a>(CreateStoreEcommerceRequest { ... }) -> WithRawResponseTask&lt;ECommerceStore&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Add a new store to your Mailchimp account.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ecommerce.CreateStoreAsync(
    new CreateStoreEcommerceRequest
    {
        CurrencyCode = "USD",
        Id = "example_store",
        ListId = "1a2df69511",
        Name = "Freddie's Cat Hat Emporium",
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `CreateStoreEcommerceRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Ecommerce.<a href="/src/Mailchimp.Marketing/Ecommerce/EcommerceClient.cs">GetStoreAsync</a>(GetStoreEcommerceRequest { ... }) -> WithRawResponseTask&lt;ECommerceStore&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get information about a specific store.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ecommerce.GetStoreAsync(new GetStoreEcommerceRequest { StoreId = "store_id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `GetStoreEcommerceRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Ecommerce.<a href="/src/Mailchimp.Marketing/Ecommerce/EcommerceClient.cs">DeleteStoreAsync</a>(DeleteStoreEcommerceRequest { ... }) -> WithRawResponseTask</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Delete a store. Deleting a store will also delete any associated subresources, including Customers, Orders, Products, and Carts.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ecommerce.DeleteStoreAsync(new DeleteStoreEcommerceRequest { StoreId = "store_id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `DeleteStoreEcommerceRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Ecommerce.<a href="/src/Mailchimp.Marketing/Ecommerce/EcommerceClient.cs">UpdateStoreAsync</a>(UpdateStoreEcommerceRequest { ... }) -> WithRawResponseTask&lt;ECommerceStore&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Update a store.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ecommerce.UpdateStoreAsync(new UpdateStoreEcommerceRequest { StoreId = "store_id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `UpdateStoreEcommerceRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Ecommerce.<a href="/src/Mailchimp.Marketing/Ecommerce/EcommerceClient.cs">ListStoreCartsAsync</a>(ListStoreCartsEcommerceRequest { ... }) -> Pager&lt;ECommerceCart&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get information about a store's carts.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ecommerce.ListStoreCartsAsync(
    new ListStoreCartsEcommerceRequest { StoreId = "store_id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ListStoreCartsEcommerceRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Ecommerce.<a href="/src/Mailchimp.Marketing/Ecommerce/EcommerceClient.cs">CreateStoreCartAsync</a>(CreateStoreCartEcommerceRequest { ... }) -> WithRawResponseTask&lt;ECommerceCart&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Add a new cart to a store.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ecommerce.CreateStoreCartAsync(
    new CreateStoreCartEcommerceRequest
    {
        StoreId = "store_id",
        CurrencyCode = "currency_code",
        Customer = new EcommerceStoresCartsPost { Id = "id" },
        Id = "id",
        Lines =
            new global::System.Collections.Generic.List<CreateStoreCartEcommerceRequestLinesItem>()
            {
                new CreateStoreCartEcommerceRequestLinesItem
                {
                    Id = "id",
                    Price = 1.1,
                    ProductId = "product_id",
                    ProductVariantId = "product_variant_id",
                    Quantity = 1,
                },
            },
        OrderTotal = 1.1,
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `CreateStoreCartEcommerceRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Ecommerce.<a href="/src/Mailchimp.Marketing/Ecommerce/EcommerceClient.cs">GetStoreCartAsync</a>(GetStoreCartEcommerceRequest { ... }) -> WithRawResponseTask&lt;ECommerceCart&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get information about a specific cart.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ecommerce.GetStoreCartAsync(
    new GetStoreCartEcommerceRequest { StoreId = "store_id", CartId = "cart_id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `GetStoreCartEcommerceRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Ecommerce.<a href="/src/Mailchimp.Marketing/Ecommerce/EcommerceClient.cs">DeleteStoreCartAsync</a>(DeleteStoreCartEcommerceRequest { ... }) -> WithRawResponseTask</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Delete a cart.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ecommerce.DeleteStoreCartAsync(
    new DeleteStoreCartEcommerceRequest { StoreId = "store_id", CartId = "cart_id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `DeleteStoreCartEcommerceRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Ecommerce.<a href="/src/Mailchimp.Marketing/Ecommerce/EcommerceClient.cs">UpdateStoreCartAsync</a>(UpdateStoreCartEcommerceRequest { ... }) -> WithRawResponseTask&lt;ECommerceCart&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Update a specific cart.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ecommerce.UpdateStoreCartAsync(
    new UpdateStoreCartEcommerceRequest { StoreId = "store_id", CartId = "cart_id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `UpdateStoreCartEcommerceRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Ecommerce.<a href="/src/Mailchimp.Marketing/Ecommerce/EcommerceClient.cs">ListStoreCartLinesAsync</a>(ListStoreCartLinesEcommerceRequest { ... }) -> Pager&lt;ECommerceCartLineItem&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get information about a cart's line items.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ecommerce.ListStoreCartLinesAsync(
    new ListStoreCartLinesEcommerceRequest { StoreId = "store_id", CartId = "cart_id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ListStoreCartLinesEcommerceRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Ecommerce.<a href="/src/Mailchimp.Marketing/Ecommerce/EcommerceClient.cs">CreateStoreCartLineAsync</a>(CreateStoreCartLineEcommerceRequest { ... }) -> WithRawResponseTask&lt;ECommerceCartLineItem&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Add a new line item to an existing cart.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ecommerce.CreateStoreCartLineAsync(
    new CreateStoreCartLineEcommerceRequest
    {
        StoreId = "store_id",
        CartId = "cart_id",
        Id = "id",
        Price = 1.1,
        ProductId = "product_id",
        ProductVariantId = "product_variant_id",
        Quantity = 1,
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `CreateStoreCartLineEcommerceRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Ecommerce.<a href="/src/Mailchimp.Marketing/Ecommerce/EcommerceClient.cs">GetStoreCartLineAsync</a>(GetStoreCartLineEcommerceRequest { ... }) -> WithRawResponseTask&lt;ECommerceCartLineItem&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get information about a specific cart line item.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ecommerce.GetStoreCartLineAsync(
    new GetStoreCartLineEcommerceRequest
    {
        StoreId = "store_id",
        CartId = "cart_id",
        LineId = "line_id",
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `GetStoreCartLineEcommerceRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Ecommerce.<a href="/src/Mailchimp.Marketing/Ecommerce/EcommerceClient.cs">DeleteStoreCartLineAsync</a>(DeleteStoreCartLineEcommerceRequest { ... }) -> WithRawResponseTask</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Delete a specific cart line item.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ecommerce.DeleteStoreCartLineAsync(
    new DeleteStoreCartLineEcommerceRequest
    {
        StoreId = "store_id",
        CartId = "cart_id",
        LineId = "line_id",
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `DeleteStoreCartLineEcommerceRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Ecommerce.<a href="/src/Mailchimp.Marketing/Ecommerce/EcommerceClient.cs">UpdateStoreCartLineAsync</a>(UpdateStoreCartLineEcommerceRequest { ... }) -> WithRawResponseTask&lt;ECommerceCartLineItem&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Update a specific cart line item.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ecommerce.UpdateStoreCartLineAsync(
    new UpdateStoreCartLineEcommerceRequest
    {
        StoreId = "store_id",
        CartId = "cart_id",
        LineId = "line_id",
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `UpdateStoreCartLineEcommerceRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Ecommerce.<a href="/src/Mailchimp.Marketing/Ecommerce/EcommerceClient.cs">ListStoreCustomersAsync</a>(ListStoreCustomersEcommerceRequest { ... }) -> Pager&lt;ECommerceCustomer&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get information about a store's customers.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ecommerce.ListStoreCustomersAsync(
    new ListStoreCustomersEcommerceRequest { StoreId = "store_id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ListStoreCustomersEcommerceRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Ecommerce.<a href="/src/Mailchimp.Marketing/Ecommerce/EcommerceClient.cs">CreateStoreCustomerAsync</a>(CreateStoreCustomerEcommerceRequest { ... }) -> WithRawResponseTask&lt;ECommerceCustomer&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Add a new customer to a store.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ecommerce.CreateStoreCustomerAsync(
    new CreateStoreCustomerEcommerceRequest
    {
        StoreId = "store_id",
        Id = "id",
        OptInStatus = true,
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `CreateStoreCustomerEcommerceRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Ecommerce.<a href="/src/Mailchimp.Marketing/Ecommerce/EcommerceClient.cs">GetStoreCustomerAsync</a>(GetStoreCustomerEcommerceRequest { ... }) -> WithRawResponseTask&lt;ECommerceCustomer&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get information about a specific customer.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ecommerce.GetStoreCustomerAsync(
    new GetStoreCustomerEcommerceRequest { StoreId = "store_id", CustomerId = "customer_id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `GetStoreCustomerEcommerceRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Ecommerce.<a href="/src/Mailchimp.Marketing/Ecommerce/EcommerceClient.cs">UpsertStoreCustomerAsync</a>(UpsertStoreCustomerEcommerceRequest { ... }) -> WithRawResponseTask&lt;ECommerceCustomer&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Add or update a customer.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ecommerce.UpsertStoreCustomerAsync(
    new UpsertStoreCustomerEcommerceRequest { StoreId = "store_id", CustomerId = "customer_id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `UpsertStoreCustomerEcommerceRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Ecommerce.<a href="/src/Mailchimp.Marketing/Ecommerce/EcommerceClient.cs">DeleteStoreCustomerAsync</a>(DeleteStoreCustomerEcommerceRequest { ... }) -> WithRawResponseTask</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Delete a customer from a store.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ecommerce.DeleteStoreCustomerAsync(
    new DeleteStoreCustomerEcommerceRequest { StoreId = "store_id", CustomerId = "customer_id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `DeleteStoreCustomerEcommerceRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Ecommerce.<a href="/src/Mailchimp.Marketing/Ecommerce/EcommerceClient.cs">UpdateStoreCustomerAsync</a>(UpdateStoreCustomerEcommerceRequest { ... }) -> WithRawResponseTask&lt;ECommerceCustomer&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Update a customer.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ecommerce.UpdateStoreCustomerAsync(
    new UpdateStoreCustomerEcommerceRequest
    {
        StoreId = "store_id",
        CustomerId = "customer_id",
        Body = new EcommerceStoresCartsPatch(),
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `UpdateStoreCustomerEcommerceRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Ecommerce.<a href="/src/Mailchimp.Marketing/Ecommerce/EcommerceClient.cs">ListStoreOrdersAsync</a>(ListStoreOrdersEcommerceRequest { ... }) -> Pager&lt;ECommerceOrder&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get information about a store's orders.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ecommerce.ListStoreOrdersAsync(
    new ListStoreOrdersEcommerceRequest { StoreId = "store_id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ListStoreOrdersEcommerceRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Ecommerce.<a href="/src/Mailchimp.Marketing/Ecommerce/EcommerceClient.cs">CreateStoreOrderAsync</a>(CreateStoreOrderEcommerceRequest { ... }) -> WithRawResponseTask&lt;ECommerceOrder&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Add a new order to a store.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ecommerce.CreateStoreOrderAsync(
    new CreateStoreOrderEcommerceRequest
    {
        StoreId = "store_id",
        CurrencyCode = "currency_code",
        Customer = new EcommerceStoresCartsPost { Id = "id" },
        Id = "id",
        Lines =
            new global::System.Collections.Generic.List<CreateStoreOrderEcommerceRequestLinesItem>()
            {
                new CreateStoreOrderEcommerceRequestLinesItem
                {
                    Id = "id",
                    Price = 1.1,
                    ProductId = "product_id",
                    ProductVariantId = "product_variant_id",
                    Quantity = 1,
                },
            },
        OrderTotal = 1.1,
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `CreateStoreOrderEcommerceRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Ecommerce.<a href="/src/Mailchimp.Marketing/Ecommerce/EcommerceClient.cs">GetStoreOrderAsync</a>(GetStoreOrderEcommerceRequest { ... }) -> WithRawResponseTask&lt;ECommerceOrder&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get information about a specific order.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ecommerce.GetStoreOrderAsync(
    new GetStoreOrderEcommerceRequest { StoreId = "store_id", OrderId = "order_id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `GetStoreOrderEcommerceRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Ecommerce.<a href="/src/Mailchimp.Marketing/Ecommerce/EcommerceClient.cs">DeleteStoreOrderAsync</a>(DeleteStoreOrderEcommerceRequest { ... }) -> WithRawResponseTask</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Delete an order.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ecommerce.DeleteStoreOrderAsync(
    new DeleteStoreOrderEcommerceRequest { StoreId = "store_id", OrderId = "order_id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `DeleteStoreOrderEcommerceRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Ecommerce.<a href="/src/Mailchimp.Marketing/Ecommerce/EcommerceClient.cs">UpdateStoreOrderAsync</a>(UpdateStoreOrderEcommerceRequest { ... }) -> WithRawResponseTask&lt;ECommerceOrder&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Update a specific order.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ecommerce.UpdateStoreOrderAsync(
    new UpdateStoreOrderEcommerceRequest { StoreId = "store_id", OrderId = "order_id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `UpdateStoreOrderEcommerceRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Ecommerce.<a href="/src/Mailchimp.Marketing/Ecommerce/EcommerceClient.cs">ListStoreOrderLinesAsync</a>(ListStoreOrderLinesEcommerceRequest { ... }) -> Pager&lt;ECommerceOrderLineItem&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get information about an order's line items.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ecommerce.ListStoreOrderLinesAsync(
    new ListStoreOrderLinesEcommerceRequest { StoreId = "store_id", OrderId = "order_id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ListStoreOrderLinesEcommerceRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Ecommerce.<a href="/src/Mailchimp.Marketing/Ecommerce/EcommerceClient.cs">CreateStoreOrderLineAsync</a>(CreateStoreOrderLineEcommerceRequest { ... }) -> WithRawResponseTask&lt;ECommerceOrderLineItem&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Add a new line item to an existing order.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ecommerce.CreateStoreOrderLineAsync(
    new CreateStoreOrderLineEcommerceRequest
    {
        StoreId = "store_id",
        OrderId = "order_id",
        Id = "id",
        Price = 1.1,
        ProductId = "product_id",
        ProductVariantId = "product_variant_id",
        Quantity = 1,
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `CreateStoreOrderLineEcommerceRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Ecommerce.<a href="/src/Mailchimp.Marketing/Ecommerce/EcommerceClient.cs">GetStoreOrderLineAsync</a>(GetStoreOrderLineEcommerceRequest { ... }) -> WithRawResponseTask&lt;ECommerceOrderLineItem&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get information about a specific order line item.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ecommerce.GetStoreOrderLineAsync(
    new GetStoreOrderLineEcommerceRequest
    {
        StoreId = "store_id",
        OrderId = "order_id",
        LineId = "line_id",
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `GetStoreOrderLineEcommerceRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Ecommerce.<a href="/src/Mailchimp.Marketing/Ecommerce/EcommerceClient.cs">DeleteStoreOrderLineAsync</a>(DeleteStoreOrderLineEcommerceRequest { ... }) -> WithRawResponseTask</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Delete a specific order line item.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ecommerce.DeleteStoreOrderLineAsync(
    new DeleteStoreOrderLineEcommerceRequest
    {
        StoreId = "store_id",
        OrderId = "order_id",
        LineId = "line_id",
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `DeleteStoreOrderLineEcommerceRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Ecommerce.<a href="/src/Mailchimp.Marketing/Ecommerce/EcommerceClient.cs">UpdateStoreOrderLineAsync</a>(UpdateStoreOrderLineEcommerceRequest { ... }) -> WithRawResponseTask&lt;ECommerceOrderLineItem&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Update a specific order line item.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ecommerce.UpdateStoreOrderLineAsync(
    new UpdateStoreOrderLineEcommerceRequest
    {
        StoreId = "store_id",
        OrderId = "order_id",
        LineId = "line_id",
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `UpdateStoreOrderLineEcommerceRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Ecommerce.<a href="/src/Mailchimp.Marketing/Ecommerce/EcommerceClient.cs">ListStoreProductsAsync</a>(ListStoreProductsEcommerceRequest { ... }) -> Pager&lt;ECommerceProduct&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get information about a store's products.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ecommerce.ListStoreProductsAsync(
    new ListStoreProductsEcommerceRequest { StoreId = "store_id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ListStoreProductsEcommerceRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Ecommerce.<a href="/src/Mailchimp.Marketing/Ecommerce/EcommerceClient.cs">CreateStoreProductAsync</a>(CreateStoreProductEcommerceRequest { ... }) -> WithRawResponseTask&lt;ECommerceProduct&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Add a new product to a store.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ecommerce.CreateStoreProductAsync(
    new CreateStoreProductEcommerceRequest
    {
        StoreId = "store_id",
        Body = new EcommerceStoresOrdersPost
        {
            Id = "id",
            Title = "Cat Hat",
            Variants =
                new global::System.Collections.Generic.List<EcommerceStoresOrdersPostVariantsItem>()
                {
                    new EcommerceStoresOrdersPostVariantsItem { Id = "id", Title = "Cat Hat" },
                },
        },
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `CreateStoreProductEcommerceRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Ecommerce.<a href="/src/Mailchimp.Marketing/Ecommerce/EcommerceClient.cs">GetStoreProductAsync</a>(GetStoreProductEcommerceRequest { ... }) -> WithRawResponseTask&lt;ECommerceProduct&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get information about a specific product.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ecommerce.GetStoreProductAsync(
    new GetStoreProductEcommerceRequest { StoreId = "store_id", ProductId = "product_id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `GetStoreProductEcommerceRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Ecommerce.<a href="/src/Mailchimp.Marketing/Ecommerce/EcommerceClient.cs">UpsertStoreProductAsync</a>(UpsertStoreProductEcommerceRequest { ... }) -> WithRawResponseTask&lt;ECommerceProduct&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Update a specific product.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ecommerce.UpsertStoreProductAsync(
    new UpsertStoreProductEcommerceRequest
    {
        StoreId = "store_id",
        ProductId = "product_id",
        Id = "id",
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `UpsertStoreProductEcommerceRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Ecommerce.<a href="/src/Mailchimp.Marketing/Ecommerce/EcommerceClient.cs">DeleteStoreProductAsync</a>(DeleteStoreProductEcommerceRequest { ... }) -> WithRawResponseTask</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Delete a product.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ecommerce.DeleteStoreProductAsync(
    new DeleteStoreProductEcommerceRequest { StoreId = "store_id", ProductId = "product_id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `DeleteStoreProductEcommerceRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Ecommerce.<a href="/src/Mailchimp.Marketing/Ecommerce/EcommerceClient.cs">UpdateStoreProductAsync</a>(UpdateStoreProductEcommerceRequest { ... }) -> WithRawResponseTask&lt;ECommerceProduct&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Update a specific product.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ecommerce.UpdateStoreProductAsync(
    new UpdateStoreProductEcommerceRequest { StoreId = "store_id", ProductId = "product_id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `UpdateStoreProductEcommerceRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Ecommerce.<a href="/src/Mailchimp.Marketing/Ecommerce/EcommerceClient.cs">ListStoreProductImagesAsync</a>(ListStoreProductImagesEcommerceRequest { ... }) -> Pager&lt;ListStoreProductImagesEcommerceResponseImagesItem&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get information about a product's images.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ecommerce.ListStoreProductImagesAsync(
    new ListStoreProductImagesEcommerceRequest { StoreId = "store_id", ProductId = "product_id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ListStoreProductImagesEcommerceRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Ecommerce.<a href="/src/Mailchimp.Marketing/Ecommerce/EcommerceClient.cs">CreateStoreProductImageAsync</a>(CreateStoreProductImageEcommerceRequest { ... }) -> WithRawResponseTask&lt;CreateStoreProductImageEcommerceResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Add a new image to the product.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ecommerce.CreateStoreProductImageAsync(
    new CreateStoreProductImageEcommerceRequest
    {
        StoreId = "store_id",
        ProductId = "product_id",
        Id = "id",
        Url = "url",
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `CreateStoreProductImageEcommerceRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Ecommerce.<a href="/src/Mailchimp.Marketing/Ecommerce/EcommerceClient.cs">GetStoreProductImageAsync</a>(GetStoreProductImageEcommerceRequest { ... }) -> WithRawResponseTask&lt;GetStoreProductImageEcommerceResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get information about a specific product image.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ecommerce.GetStoreProductImageAsync(
    new GetStoreProductImageEcommerceRequest
    {
        StoreId = "store_id",
        ProductId = "product_id",
        ImageId = "image_id",
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `GetStoreProductImageEcommerceRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Ecommerce.<a href="/src/Mailchimp.Marketing/Ecommerce/EcommerceClient.cs">DeleteStoreProductImageAsync</a>(DeleteStoreProductImageEcommerceRequest { ... }) -> WithRawResponseTask</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Delete a product image.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ecommerce.DeleteStoreProductImageAsync(
    new DeleteStoreProductImageEcommerceRequest
    {
        StoreId = "store_id",
        ProductId = "product_id",
        ImageId = "image_id",
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `DeleteStoreProductImageEcommerceRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Ecommerce.<a href="/src/Mailchimp.Marketing/Ecommerce/EcommerceClient.cs">UpdateStoreProductImageAsync</a>(UpdateStoreProductImageEcommerceRequest { ... }) -> WithRawResponseTask&lt;UpdateStoreProductImageEcommerceResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Update a product image.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ecommerce.UpdateStoreProductImageAsync(
    new UpdateStoreProductImageEcommerceRequest
    {
        StoreId = "store_id",
        ProductId = "product_id",
        ImageId = "image_id",
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `UpdateStoreProductImageEcommerceRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Ecommerce.<a href="/src/Mailchimp.Marketing/Ecommerce/EcommerceClient.cs">ListStoreProductVariantsAsync</a>(ListStoreProductVariantsEcommerceRequest { ... }) -> Pager&lt;ECommerceProductVariant&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get information about a product's variants.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ecommerce.ListStoreProductVariantsAsync(
    new ListStoreProductVariantsEcommerceRequest { StoreId = "store_id", ProductId = "product_id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ListStoreProductVariantsEcommerceRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Ecommerce.<a href="/src/Mailchimp.Marketing/Ecommerce/EcommerceClient.cs">CreateStoreProductVariantAsync</a>(CreateStoreProductVariantEcommerceRequest { ... }) -> WithRawResponseTask&lt;ECommerceProductVariant&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Add a new variant to the product.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ecommerce.CreateStoreProductVariantAsync(
    new CreateStoreProductVariantEcommerceRequest
    {
        StoreId = "store_id",
        ProductId = "product_id",
        Id = "id",
        Title = "Cat Hat",
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `CreateStoreProductVariantEcommerceRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Ecommerce.<a href="/src/Mailchimp.Marketing/Ecommerce/EcommerceClient.cs">GetStoreProductVariantAsync</a>(GetStoreProductVariantEcommerceRequest { ... }) -> WithRawResponseTask&lt;ECommerceProductVariant&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get information about a specific product variant.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ecommerce.GetStoreProductVariantAsync(
    new GetStoreProductVariantEcommerceRequest
    {
        StoreId = "store_id",
        ProductId = "product_id",
        VariantId = "variant_id",
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `GetStoreProductVariantEcommerceRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Ecommerce.<a href="/src/Mailchimp.Marketing/Ecommerce/EcommerceClient.cs">UpsertStoreProductVariantAsync</a>(UpsertStoreProductVariantEcommerceRequest { ... }) -> WithRawResponseTask&lt;ECommerceProductVariant&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Add or update a product variant.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ecommerce.UpsertStoreProductVariantAsync(
    new UpsertStoreProductVariantEcommerceRequest
    {
        StoreId = "store_id",
        ProductId = "product_id",
        VariantId = "variant_id",
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `UpsertStoreProductVariantEcommerceRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Ecommerce.<a href="/src/Mailchimp.Marketing/Ecommerce/EcommerceClient.cs">DeleteStoreProductVariantAsync</a>(DeleteStoreProductVariantEcommerceRequest { ... }) -> WithRawResponseTask</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Delete a product variant.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ecommerce.DeleteStoreProductVariantAsync(
    new DeleteStoreProductVariantEcommerceRequest
    {
        StoreId = "store_id",
        ProductId = "product_id",
        VariantId = "variant_id",
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `DeleteStoreProductVariantEcommerceRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Ecommerce.<a href="/src/Mailchimp.Marketing/Ecommerce/EcommerceClient.cs">UpdateStoreProductVariantAsync</a>(UpdateStoreProductVariantEcommerceRequest { ... }) -> WithRawResponseTask&lt;ECommerceProductVariant&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Update a product variant.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ecommerce.UpdateStoreProductVariantAsync(
    new UpdateStoreProductVariantEcommerceRequest
    {
        StoreId = "store_id",
        ProductId = "product_id",
        VariantId = "variant_id",
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `UpdateStoreProductVariantEcommerceRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Ecommerce.<a href="/src/Mailchimp.Marketing/Ecommerce/EcommerceClient.cs">ListStorePromoRulesAsync</a>(ListStorePromoRulesEcommerceRequest { ... }) -> Pager&lt;ECommercePromoRule&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get information about a store's promo rules.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ecommerce.ListStorePromoRulesAsync(
    new ListStorePromoRulesEcommerceRequest { StoreId = "store_id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ListStorePromoRulesEcommerceRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Ecommerce.<a href="/src/Mailchimp.Marketing/Ecommerce/EcommerceClient.cs">CreateStorePromoRuleAsync</a>(CreateStorePromoRuleEcommerceRequest { ... }) -> WithRawResponseTask&lt;ECommercePromoRule&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Add a new promo rule to a store.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ecommerce.CreateStorePromoRuleAsync(
    new CreateStorePromoRuleEcommerceRequest
    {
        StoreId = "store_id",
        Amount = 1.1,
        Description = "Save BIG during our summer sale!",
        Id = "id",
        Target = CreateStorePromoRuleEcommerceRequestTarget.PerItem,
        Type = CreateStorePromoRuleEcommerceRequestType.Fixed,
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `CreateStorePromoRuleEcommerceRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Ecommerce.<a href="/src/Mailchimp.Marketing/Ecommerce/EcommerceClient.cs">GetStorePromoRuleAsync</a>(GetStorePromoRuleEcommerceRequest { ... }) -> WithRawResponseTask&lt;ECommercePromoRule&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get information about a specific promo rule.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ecommerce.GetStorePromoRuleAsync(
    new GetStorePromoRuleEcommerceRequest { StoreId = "store_id", PromoRuleId = "promo_rule_id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `GetStorePromoRuleEcommerceRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Ecommerce.<a href="/src/Mailchimp.Marketing/Ecommerce/EcommerceClient.cs">DeleteStorePromoRuleAsync</a>(DeleteStorePromoRuleEcommerceRequest { ... }) -> WithRawResponseTask</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Delete a promo rule from a store.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ecommerce.DeleteStorePromoRuleAsync(
    new DeleteStorePromoRuleEcommerceRequest { StoreId = "store_id", PromoRuleId = "promo_rule_id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `DeleteStorePromoRuleEcommerceRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Ecommerce.<a href="/src/Mailchimp.Marketing/Ecommerce/EcommerceClient.cs">UpdateStorePromoRuleAsync</a>(UpdateStorePromoRuleEcommerceRequest { ... }) -> WithRawResponseTask&lt;ECommercePromoRule&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Update a promo rule.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ecommerce.UpdateStorePromoRuleAsync(
    new UpdateStorePromoRuleEcommerceRequest { StoreId = "store_id", PromoRuleId = "promo_rule_id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `UpdateStorePromoRuleEcommerceRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Ecommerce.<a href="/src/Mailchimp.Marketing/Ecommerce/EcommerceClient.cs">ListStorePromoRulePromoCodesAsync</a>(ListStorePromoRulePromoCodesEcommerceRequest { ... }) -> Pager&lt;ECommercePromoCode&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get information about a store's promo codes.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ecommerce.ListStorePromoRulePromoCodesAsync(
    new ListStorePromoRulePromoCodesEcommerceRequest
    {
        StoreId = "store_id",
        PromoRuleId = "promo_rule_id",
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ListStorePromoRulePromoCodesEcommerceRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Ecommerce.<a href="/src/Mailchimp.Marketing/Ecommerce/EcommerceClient.cs">CreateStorePromoRulePromoCodeAsync</a>(CreateStorePromoRulePromoCodeEcommerceRequest { ... }) -> WithRawResponseTask&lt;ECommercePromoCode&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Add a new promo code to a store.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ecommerce.CreateStorePromoRulePromoCodeAsync(
    new CreateStorePromoRulePromoCodeEcommerceRequest
    {
        StoreId = "store_id",
        PromoRuleId = "promo_rule_id",
        Code = "summersale",
        Id = "id",
        RedemptionUrl =
            "A url that applies promo code directly at checkout or a url that points to sale page or store url",
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `CreateStorePromoRulePromoCodeEcommerceRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Ecommerce.<a href="/src/Mailchimp.Marketing/Ecommerce/EcommerceClient.cs">GetStorePromoRulePromoCodeAsync</a>(GetStorePromoRulePromoCodeEcommerceRequest { ... }) -> WithRawResponseTask&lt;ECommercePromoCode&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get information about a specific promo code.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ecommerce.GetStorePromoRulePromoCodeAsync(
    new GetStorePromoRulePromoCodeEcommerceRequest
    {
        StoreId = "store_id",
        PromoRuleId = "promo_rule_id",
        PromoCodeId = "promo_code_id",
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `GetStorePromoRulePromoCodeEcommerceRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Ecommerce.<a href="/src/Mailchimp.Marketing/Ecommerce/EcommerceClient.cs">DeleteStorePromoRulePromoCodeAsync</a>(DeleteStorePromoRulePromoCodeEcommerceRequest { ... }) -> WithRawResponseTask</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Delete a promo code from a store.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ecommerce.DeleteStorePromoRulePromoCodeAsync(
    new DeleteStorePromoRulePromoCodeEcommerceRequest
    {
        StoreId = "store_id",
        PromoRuleId = "promo_rule_id",
        PromoCodeId = "promo_code_id",
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `DeleteStorePromoRulePromoCodeEcommerceRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Ecommerce.<a href="/src/Mailchimp.Marketing/Ecommerce/EcommerceClient.cs">UpdateStorePromoRulePromoCodeAsync</a>(UpdateStorePromoRulePromoCodeEcommerceRequest { ... }) -> WithRawResponseTask&lt;ECommercePromoCode&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Update a promo code.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ecommerce.UpdateStorePromoRulePromoCodeAsync(
    new UpdateStorePromoRulePromoCodeEcommerceRequest
    {
        StoreId = "store_id",
        PromoRuleId = "promo_rule_id",
        PromoCodeId = "promo_code_id",
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `UpdateStorePromoRulePromoCodeEcommerceRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## FacebookAds
<details><summary><code>client.FacebookAds.<a href="/src/Mailchimp.Marketing/FacebookAds/FacebookAdsClient.cs">ListAsync</a>(ListFacebookAdsRequest { ... }) -> Pager&lt;FacebookAds&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get list of Facebook ads.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.FacebookAds.ListAsync(new ListFacebookAdsRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ListFacebookAdsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.FacebookAds.<a href="/src/Mailchimp.Marketing/FacebookAds/FacebookAdsClient.cs">GetAsync</a>(GetFacebookAdsRequest { ... }) -> WithRawResponseTask&lt;FacebookAds&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get details of a Facebook ad.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.FacebookAds.GetAsync(new GetFacebookAdsRequest { OutreachId = "outreach_id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `GetFacebookAdsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## FileManager
<details><summary><code>client.FileManager.<a href="/src/Mailchimp.Marketing/FileManager/FileManagerClient.cs">ListAsync</a>() -> WithRawResponseTask&lt;IEnumerable&lt;ListFileManagerResponseItem&gt;&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get information about the file-manager endpoint's resources
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.FileManager.ListAsync();
```
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.FileManager.<a href="/src/Mailchimp.Marketing/FileManager/FileManagerClient.cs">ListFilesAsync</a>(ListFilesFileManagerRequest { ... }) -> Pager&lt;GalleryFile&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get a list of available images and files stored in the File Manager for the account.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.FileManager.ListFilesAsync(new ListFilesFileManagerRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ListFilesFileManagerRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.FileManager.<a href="/src/Mailchimp.Marketing/FileManager/FileManagerClient.cs">CreateFileAsync</a>(CreateFileFileManagerRequest { ... }) -> WithRawResponseTask&lt;GalleryFile&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Upload a new image or file to the File Manager.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.FileManager.CreateFileAsync(
    new CreateFileFileManagerRequest { FileData = "file_data", Name = "name" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `CreateFileFileManagerRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.FileManager.<a href="/src/Mailchimp.Marketing/FileManager/FileManagerClient.cs">GetFileAsync</a>(GetFileFileManagerRequest { ... }) -> WithRawResponseTask&lt;GalleryFile&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get information about a specific file in the File Manager.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.FileManager.GetFileAsync(new GetFileFileManagerRequest { FileId = "file_id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `GetFileFileManagerRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.FileManager.<a href="/src/Mailchimp.Marketing/FileManager/FileManagerClient.cs">DeleteFileAsync</a>(DeleteFileFileManagerRequest { ... }) -> WithRawResponseTask</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Remove a specific file from the File Manager.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.FileManager.DeleteFileAsync(new DeleteFileFileManagerRequest { FileId = "file_id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `DeleteFileFileManagerRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.FileManager.<a href="/src/Mailchimp.Marketing/FileManager/FileManagerClient.cs">UpdateFileAsync</a>(UpdateFileFileManagerRequest { ... }) -> WithRawResponseTask&lt;GalleryFile&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Update a file in the File Manager.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.FileManager.UpdateFileAsync(new UpdateFileFileManagerRequest { FileId = "file_id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `UpdateFileFileManagerRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.FileManager.<a href="/src/Mailchimp.Marketing/FileManager/FileManagerClient.cs">ListFoldersAsync</a>(ListFoldersFileManagerRequest { ... }) -> Pager&lt;ListFoldersFileManagerResponseFoldersItem&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get a list of all folders in the File Manager.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.FileManager.ListFoldersAsync(new ListFoldersFileManagerRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ListFoldersFileManagerRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.FileManager.<a href="/src/Mailchimp.Marketing/FileManager/FileManagerClient.cs">CreateFolderAsync</a>(CreateFolderFileManagerRequest { ... }) -> WithRawResponseTask&lt;CreateFolderFileManagerResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Create a new folder in the File Manager.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.FileManager.CreateFolderAsync(new CreateFolderFileManagerRequest { Name = "name" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `CreateFolderFileManagerRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.FileManager.<a href="/src/Mailchimp.Marketing/FileManager/FileManagerClient.cs">GetFolderAsync</a>(GetFolderFileManagerRequest { ... }) -> WithRawResponseTask&lt;GetFolderFileManagerResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get information about a specific folder in the File Manager.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.FileManager.GetFolderAsync(new GetFolderFileManagerRequest { FolderId = "folder_id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `GetFolderFileManagerRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.FileManager.<a href="/src/Mailchimp.Marketing/FileManager/FileManagerClient.cs">DeleteFolderAsync</a>(DeleteFolderFileManagerRequest { ... }) -> WithRawResponseTask</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Delete a specific folder in the File Manager.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.FileManager.DeleteFolderAsync(
    new DeleteFolderFileManagerRequest { FolderId = "folder_id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `DeleteFolderFileManagerRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.FileManager.<a href="/src/Mailchimp.Marketing/FileManager/FileManagerClient.cs">UpdateFolderAsync</a>(UpdateFolderFileManagerRequest { ... }) -> WithRawResponseTask&lt;UpdateFolderFileManagerResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Update a specific File Manager folder.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.FileManager.UpdateFolderAsync(
    new UpdateFolderFileManagerRequest { FolderId = "folder_id", Name = "name" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `UpdateFolderFileManagerRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.FileManager.<a href="/src/Mailchimp.Marketing/FileManager/FileManagerClient.cs">ListFolderFilesAsync</a>(ListFolderFilesFileManagerRequest { ... }) -> Pager&lt;GalleryFile&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get a list of available images and files stored in this folder.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.FileManager.ListFolderFilesAsync(
    new ListFolderFilesFileManagerRequest { FolderId = "folder_id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ListFolderFilesFileManagerRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## LandingPages
<details><summary><code>client.LandingPages.<a href="/src/Mailchimp.Marketing/LandingPages/LandingPagesClient.cs">ListAsync</a>(ListLandingPagesRequest { ... }) -> WithRawResponseTask&lt;ListLandingPagesResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get all landing pages.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.LandingPages.ListAsync(new ListLandingPagesRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ListLandingPagesRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.LandingPages.<a href="/src/Mailchimp.Marketing/LandingPages/LandingPagesClient.cs">CreateAsync</a>(CreateLandingPagesRequest { ... }) -> WithRawResponseTask&lt;LandingPage&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Create an unpublished and contentless Mailchimp landing page.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.LandingPages.CreateAsync(new CreateLandingPagesRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `CreateLandingPagesRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.LandingPages.<a href="/src/Mailchimp.Marketing/LandingPages/LandingPagesClient.cs">GetAsync</a>(GetLandingPagesRequest { ... }) -> WithRawResponseTask&lt;LandingPage&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get information about a specific page.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.LandingPages.GetAsync(new GetLandingPagesRequest { PageId = "page_id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `GetLandingPagesRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.LandingPages.<a href="/src/Mailchimp.Marketing/LandingPages/LandingPagesClient.cs">DeleteAsync</a>(DeleteLandingPagesRequest { ... }) -> WithRawResponseTask</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Delete a landing page.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.LandingPages.DeleteAsync(new DeleteLandingPagesRequest { PageId = "page_id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `DeleteLandingPagesRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.LandingPages.<a href="/src/Mailchimp.Marketing/LandingPages/LandingPagesClient.cs">UpdateAsync</a>(UpdateLandingPagesRequest { ... }) -> WithRawResponseTask&lt;LandingPage&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Update a landing page.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.LandingPages.UpdateAsync(new UpdateLandingPagesRequest { PageId = "page_id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `UpdateLandingPagesRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.LandingPages.<a href="/src/Mailchimp.Marketing/LandingPages/LandingPagesClient.cs">CreateActionPublishAsync</a>(CreateActionPublishLandingPagesRequest { ... }) -> WithRawResponseTask</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Publish a landing page that is in draft, unpublished, or has been previously published and edited.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.LandingPages.CreateActionPublishAsync(
    new CreateActionPublishLandingPagesRequest { PageId = "page_id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `CreateActionPublishLandingPagesRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.LandingPages.<a href="/src/Mailchimp.Marketing/LandingPages/LandingPagesClient.cs">CreateActionUnpublishAsync</a>(CreateActionUnpublishLandingPagesRequest { ... }) -> WithRawResponseTask</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Unpublish a landing page that is in draft or has been published.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.LandingPages.CreateActionUnpublishAsync(
    new CreateActionUnpublishLandingPagesRequest { PageId = "page_id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `CreateActionUnpublishLandingPagesRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.LandingPages.<a href="/src/Mailchimp.Marketing/LandingPages/LandingPagesClient.cs">ListContentAsync</a>(ListContentLandingPagesRequest { ... }) -> WithRawResponseTask&lt;ListContentLandingPagesResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get the the HTML for your landing page.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.LandingPages.ListContentAsync(
    new ListContentLandingPagesRequest { PageId = "page_id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ListContentLandingPagesRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## lists
<details><summary><code>client.Lists.<a href="/src/Mailchimp.Marketing/Lists/ListsClient.cs">ListAsync</a>(ListListsRequest { ... }) -> Pager&lt;SubscriberList&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get information about all lists in the account.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Lists.ListAsync(new ListListsRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ListListsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Lists.<a href="/src/Mailchimp.Marketing/Lists/ListsClient.cs">CreateAsync</a>(CreateListsRequest { ... }) -> WithRawResponseTask&lt;SubscriberList&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Create a new list in your Mailchimp account.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Lists.CreateAsync(
    new CreateListsRequest
    {
        CampaignDefaults = new CreateListsRequestCampaignDefaults
        {
            FromEmail = "from_email",
            FromName = "from_name",
            Language = "language",
            Subject = "subject",
        },
        Contact = new CreateListsRequestContact
        {
            Address1 = "address1",
            City = "city",
            Company = "company",
            Country = "country",
        },
        EmailTypeOption = true,
        Name = "name",
        PermissionReminder = "permission_reminder",
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `CreateListsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Lists.<a href="/src/Mailchimp.Marketing/Lists/ListsClient.cs">GetAsync</a>(GetListsRequest { ... }) -> WithRawResponseTask&lt;SubscriberList&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get information about a specific list in your Mailchimp account. Results include list members who have signed up but haven't confirmed their subscription yet and unsubscribed or cleaned.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Lists.GetAsync(new GetListsRequest { ListId = "list_id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `GetListsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Lists.<a href="/src/Mailchimp.Marketing/Lists/ListsClient.cs">BatchSubscribeOrUnsubscribeAsync</a>(BatchSubscribeOrUnsubscribeListsRequest { ... }) -> WithRawResponseTask&lt;BatchSubscribeOrUnsubscribeListsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Batch subscribe or unsubscribe list members.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Lists.BatchSubscribeOrUnsubscribeAsync(
    new BatchSubscribeOrUnsubscribeListsRequest
    {
        ListId = "list_id",
        Members = new global::System.Collections.Generic.List<OneOf<object>>() { },
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `BatchSubscribeOrUnsubscribeListsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Lists.<a href="/src/Mailchimp.Marketing/Lists/ListsClient.cs">DeleteAsync</a>(DeleteListsRequest { ... }) -> WithRawResponseTask</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Delete a list from your Mailchimp account. If you delete a list, you'll lose the list history—including subscriber activity, unsubscribes, complaints, and bounces. You’ll also lose subscribers’ email addresses, unless you exported and backed up your list.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Lists.DeleteAsync(new DeleteListsRequest { ListId = "list_id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `DeleteListsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Lists.<a href="/src/Mailchimp.Marketing/Lists/ListsClient.cs">UpdateAsync</a>(UpdateListsRequest { ... }) -> WithRawResponseTask&lt;SubscriberList&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Update the settings for a specific list.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Lists.UpdateAsync(new UpdateListsRequest { ListId = "list_id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `UpdateListsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Lists.<a href="/src/Mailchimp.Marketing/Lists/ListsClient.cs">ListAbuseReportsAsync</a>(ListAbuseReportsListsRequest { ... }) -> Pager&lt;ListsAbuseReports&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get all abuse reports for a specific list.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Lists.ListAbuseReportsAsync(new ListAbuseReportsListsRequest { ListId = "list_id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ListAbuseReportsListsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Lists.<a href="/src/Mailchimp.Marketing/Lists/ListsClient.cs">GetAbuseReportAsync</a>(GetAbuseReportListsRequest { ... }) -> WithRawResponseTask&lt;ListsAbuseReports&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get details about a specific abuse report.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Lists.GetAbuseReportAsync(
    new GetAbuseReportListsRequest { ListId = "list_id", ReportId = "report_id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `GetAbuseReportListsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Lists.<a href="/src/Mailchimp.Marketing/Lists/ListsClient.cs">ListActivityAsync</a>(ListActivityListsRequest { ... }) -> Pager&lt;ListActivityListsResponseActivityItem&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get up to the previous 180 days of daily detailed aggregated activity stats for a list, not including Automation activity.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Lists.ListActivityAsync(new ListActivityListsRequest { ListId = "list_id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ListActivityListsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Lists.<a href="/src/Mailchimp.Marketing/Lists/ListsClient.cs">ListClientsAsync</a>(ListClientsListsRequest { ... }) -> WithRawResponseTask&lt;ListClientsListsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get a list of the top email clients based on user-agent strings.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Lists.ListClientsAsync(new ListClientsListsRequest { ListId = "list_id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ListClientsListsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Lists.<a href="/src/Mailchimp.Marketing/Lists/ListsClient.cs">ListGrowthHistoryAsync</a>(ListGrowthHistoryListsRequest { ... }) -> Pager&lt;GrowthHistory&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get a month-by-month summary of a specific list's growth activity.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Lists.ListGrowthHistoryAsync(new ListGrowthHistoryListsRequest { ListId = "list_id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ListGrowthHistoryListsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Lists.<a href="/src/Mailchimp.Marketing/Lists/ListsClient.cs">GetGrowthHistoryAsync</a>(GetGrowthHistoryListsRequest { ... }) -> WithRawResponseTask&lt;GrowthHistory&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get a summary of a specific list's growth activity for a specific month and year.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Lists.GetGrowthHistoryAsync(
    new GetGrowthHistoryListsRequest { ListId = "list_id", Month = "month" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `GetGrowthHistoryListsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Lists.<a href="/src/Mailchimp.Marketing/Lists/ListsClient.cs">ListInterestCategoriesAsync</a>(ListInterestCategoriesListsRequest { ... }) -> Pager&lt;InterestCategory&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get information about a list's interest categories.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Lists.ListInterestCategoriesAsync(
    new ListInterestCategoriesListsRequest { ListId = "list_id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ListInterestCategoriesListsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Lists.<a href="/src/Mailchimp.Marketing/Lists/ListsClient.cs">CreateInterestCategoryAsync</a>(CreateInterestCategoryListsRequest { ... }) -> WithRawResponseTask&lt;InterestCategory&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Create a new interest category.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Lists.CreateInterestCategoryAsync(
    new CreateInterestCategoryListsRequest
    {
        ListId = "list_id",
        Title = "title",
        Type = CreateInterestCategoryListsRequestType.Checkboxes,
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `CreateInterestCategoryListsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Lists.<a href="/src/Mailchimp.Marketing/Lists/ListsClient.cs">GetInterestCategoryAsync</a>(GetInterestCategoryListsRequest { ... }) -> WithRawResponseTask&lt;InterestCategory&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get information about a specific interest category.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Lists.GetInterestCategoryAsync(
    new GetInterestCategoryListsRequest
    {
        ListId = "list_id",
        InterestCategoryId = "interest_category_id",
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `GetInterestCategoryListsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Lists.<a href="/src/Mailchimp.Marketing/Lists/ListsClient.cs">DeleteInterestCategoryAsync</a>(DeleteInterestCategoryListsRequest { ... }) -> WithRawResponseTask</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Delete a specific interest category.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Lists.DeleteInterestCategoryAsync(
    new DeleteInterestCategoryListsRequest
    {
        ListId = "list_id",
        InterestCategoryId = "interest_category_id",
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `DeleteInterestCategoryListsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Lists.<a href="/src/Mailchimp.Marketing/Lists/ListsClient.cs">UpdateInterestCategoryAsync</a>(UpdateInterestCategoryListsRequest { ... }) -> WithRawResponseTask&lt;InterestCategory&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Update a specific interest category.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Lists.UpdateInterestCategoryAsync(
    new UpdateInterestCategoryListsRequest
    {
        ListId = "list_id",
        InterestCategoryId = "interest_category_id",
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `UpdateInterestCategoryListsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Lists.<a href="/src/Mailchimp.Marketing/Lists/ListsClient.cs">ListInterestCategoryInterestsAsync</a>(ListInterestCategoryInterestsListsRequest { ... }) -> Pager&lt;Interest&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get a list of this category's interests.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Lists.ListInterestCategoryInterestsAsync(
    new ListInterestCategoryInterestsListsRequest
    {
        ListId = "list_id",
        InterestCategoryId = "interest_category_id",
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ListInterestCategoryInterestsListsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Lists.<a href="/src/Mailchimp.Marketing/Lists/ListsClient.cs">CreateInterestCategoryInterestAsync</a>(CreateInterestCategoryInterestListsRequest { ... }) -> WithRawResponseTask&lt;Interest&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Create a new interest or 'group name' for a specific category.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Lists.CreateInterestCategoryInterestAsync(
    new CreateInterestCategoryInterestListsRequest
    {
        ListId = "list_id",
        InterestCategoryId = "interest_category_id",
        Name = "name",
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `CreateInterestCategoryInterestListsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Lists.<a href="/src/Mailchimp.Marketing/Lists/ListsClient.cs">GetInterestCategoryInterestAsync</a>(GetInterestCategoryInterestListsRequest { ... }) -> WithRawResponseTask&lt;Interest&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get interests or 'group names' for a specific category.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Lists.GetInterestCategoryInterestAsync(
    new GetInterestCategoryInterestListsRequest
    {
        ListId = "list_id",
        InterestCategoryId = "interest_category_id",
        InterestId = "interest_id",
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `GetInterestCategoryInterestListsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Lists.<a href="/src/Mailchimp.Marketing/Lists/ListsClient.cs">DeleteInterestCategoryInterestAsync</a>(DeleteInterestCategoryInterestListsRequest { ... }) -> WithRawResponseTask</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Delete interests or group names in a specific category.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Lists.DeleteInterestCategoryInterestAsync(
    new DeleteInterestCategoryInterestListsRequest
    {
        ListId = "list_id",
        InterestCategoryId = "interest_category_id",
        InterestId = "interest_id",
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `DeleteInterestCategoryInterestListsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Lists.<a href="/src/Mailchimp.Marketing/Lists/ListsClient.cs">UpdateInterestCategoryInterestAsync</a>(UpdateInterestCategoryInterestListsRequest { ... }) -> WithRawResponseTask&lt;Interest&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Update interests or 'group names' for a specific category.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Lists.UpdateInterestCategoryInterestAsync(
    new UpdateInterestCategoryInterestListsRequest
    {
        ListId = "list_id",
        InterestCategoryId = "interest_category_id",
        InterestId = "interest_id",
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `UpdateInterestCategoryInterestListsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Lists.<a href="/src/Mailchimp.Marketing/Lists/ListsClient.cs">ListLocationsAsync</a>(ListLocationsListsRequest { ... }) -> WithRawResponseTask&lt;ListLocationsListsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get the locations (countries) that the list's subscribers have been tagged to based on geocoding their IP address.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Lists.ListLocationsAsync(new ListLocationsListsRequest { ListId = "list_id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ListLocationsListsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Lists.<a href="/src/Mailchimp.Marketing/Lists/ListsClient.cs">ListMembersAsync</a>(ListMembersListsRequest { ... }) -> Pager&lt;ListMembers&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get information about members in a specific Mailchimp list.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Lists.ListMembersAsync(new ListMembersListsRequest { ListId = "list_id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ListMembersListsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Lists.<a href="/src/Mailchimp.Marketing/Lists/ListsClient.cs">CreateMemberAsync</a>(CreateMemberListsRequest { ... }) -> WithRawResponseTask&lt;ListMembers&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Add a new member to the list.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Lists.CreateMemberAsync(
    new CreateMemberListsRequest
    {
        ListId = "list_id",
        EmailAddress = "email_address",
        Status = CreateMemberListsRequestStatus.Subscribed,
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `CreateMemberListsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Lists.<a href="/src/Mailchimp.Marketing/Lists/ListsClient.cs">GetMemberAsync</a>(GetMemberListsRequest { ... }) -> WithRawResponseTask&lt;ListMembers&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get information about a specific list member, including a currently subscribed, unsubscribed, or bounced member.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Lists.GetMemberAsync(
    new GetMemberListsRequest { ListId = "list_id", SubscriberHash = "subscriber_hash" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `GetMemberListsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Lists.<a href="/src/Mailchimp.Marketing/Lists/ListsClient.cs">UpsertMemberAsync</a>(UpsertMemberListsRequest { ... }) -> WithRawResponseTask&lt;ListMembers&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Add or update a list member.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Lists.UpsertMemberAsync(
    new UpsertMemberListsRequest
    {
        ListId = "list_id",
        SubscriberHash = "subscriber_hash",
        EmailAddress = "email_address",
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `UpsertMemberListsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Lists.<a href="/src/Mailchimp.Marketing/Lists/ListsClient.cs">DeleteMemberAsync</a>(DeleteMemberListsRequest { ... }) -> WithRawResponseTask</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Archive a list member. To permanently delete, use the delete-permanent action.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Lists.DeleteMemberAsync(
    new DeleteMemberListsRequest { ListId = "list_id", SubscriberHash = "subscriber_hash" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `DeleteMemberListsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Lists.<a href="/src/Mailchimp.Marketing/Lists/ListsClient.cs">UpdateMemberAsync</a>(UpdateMemberListsRequest { ... }) -> WithRawResponseTask&lt;ListMembers&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Update information for a specific list member.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Lists.UpdateMemberAsync(
    new UpdateMemberListsRequest { ListId = "list_id", SubscriberHash = "subscriber_hash" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `UpdateMemberListsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Lists.<a href="/src/Mailchimp.Marketing/Lists/ListsClient.cs">CreateMemberActionDeletePermanentAsync</a>(CreateMemberActionDeletePermanentListsRequest { ... }) -> WithRawResponseTask</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Delete all personally identifiable information related to a list member, and remove them from a list. This will make it impossible to re-import the list member.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Lists.CreateMemberActionDeletePermanentAsync(
    new CreateMemberActionDeletePermanentListsRequest
    {
        ListId = "list_id",
        SubscriberHash = "subscriber_hash",
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `CreateMemberActionDeletePermanentListsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Lists.<a href="/src/Mailchimp.Marketing/Lists/ListsClient.cs">ListMemberActivityAsync</a>(ListMemberActivityListsRequest { ... }) -> WithRawResponseTask&lt;ListMemberActivityListsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get the last 50 events of a member's activity on a specific list, including opens, clicks, and unsubscribes.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Lists.ListMemberActivityAsync(
    new ListMemberActivityListsRequest { ListId = "list_id", SubscriberHash = "subscriber_hash" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ListMemberActivityListsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Lists.<a href="/src/Mailchimp.Marketing/Lists/ListsClient.cs">ListMemberActivityFeedAsync</a>(ListMemberActivityFeedListsRequest { ... }) -> Pager&lt;object&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get a member's activity on a specific list, including opens, clicks, and unsubscribes.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Lists.ListMemberActivityFeedAsync(
    new ListMemberActivityFeedListsRequest
    {
        ListId = "list_id",
        SubscriberHash = "subscriber_hash",
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ListMemberActivityFeedListsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Lists.<a href="/src/Mailchimp.Marketing/Lists/ListsClient.cs">ListMemberEventsAsync</a>(ListMemberEventsListsRequest { ... }) -> Pager&lt;ListMemberEventsListsResponseEventsItem&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get events for a contact.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Lists.ListMemberEventsAsync(
    new ListMemberEventsListsRequest { ListId = "list_id", SubscriberHash = "subscriber_hash" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ListMemberEventsListsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Lists.<a href="/src/Mailchimp.Marketing/Lists/ListsClient.cs">CreateMemberEventAsync</a>(CreateMemberEventListsRequest { ... }) -> WithRawResponseTask</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Add an event for a list member.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Lists.CreateMemberEventAsync(
    new CreateMemberEventListsRequest
    {
        ListId = "list_id",
        SubscriberHash = "subscriber_hash",
        Name = "name",
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `CreateMemberEventListsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Lists.<a href="/src/Mailchimp.Marketing/Lists/ListsClient.cs">ListMemberGoalsAsync</a>(ListMemberGoalsListsRequest { ... }) -> WithRawResponseTask&lt;ListMemberGoalsListsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get the last 50 Goal events for a member on a specific list.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Lists.ListMemberGoalsAsync(
    new ListMemberGoalsListsRequest { ListId = "list_id", SubscriberHash = "subscriber_hash" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ListMemberGoalsListsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Lists.<a href="/src/Mailchimp.Marketing/Lists/ListsClient.cs">ListMemberNotesAsync</a>(ListMemberNotesListsRequest { ... }) -> Pager&lt;MemberNotes&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get recent notes for a specific list member.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Lists.ListMemberNotesAsync(
    new ListMemberNotesListsRequest { ListId = "list_id", SubscriberHash = "subscriber_hash" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ListMemberNotesListsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Lists.<a href="/src/Mailchimp.Marketing/Lists/ListsClient.cs">CreateMemberNoteAsync</a>(CreateMemberNoteListsRequest { ... }) -> WithRawResponseTask&lt;MemberNotes&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Add a new note for a specific subscriber.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Lists.CreateMemberNoteAsync(
    new CreateMemberNoteListsRequest { ListId = "list_id", SubscriberHash = "subscriber_hash" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `CreateMemberNoteListsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Lists.<a href="/src/Mailchimp.Marketing/Lists/ListsClient.cs">GetMemberNoteAsync</a>(GetMemberNoteListsRequest { ... }) -> WithRawResponseTask&lt;MemberNotes&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get a specific note for a specific list member.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Lists.GetMemberNoteAsync(
    new GetMemberNoteListsRequest
    {
        ListId = "list_id",
        SubscriberHash = "subscriber_hash",
        NoteId = "note_id",
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `GetMemberNoteListsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Lists.<a href="/src/Mailchimp.Marketing/Lists/ListsClient.cs">DeleteMemberNoteAsync</a>(DeleteMemberNoteListsRequest { ... }) -> WithRawResponseTask</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Delete a specific note for a specific list member.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Lists.DeleteMemberNoteAsync(
    new DeleteMemberNoteListsRequest
    {
        ListId = "list_id",
        SubscriberHash = "subscriber_hash",
        NoteId = "note_id",
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `DeleteMemberNoteListsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Lists.<a href="/src/Mailchimp.Marketing/Lists/ListsClient.cs">UpdateMemberNoteAsync</a>(UpdateMemberNoteListsRequest { ... }) -> WithRawResponseTask&lt;MemberNotes&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Update a specific note for a specific list member.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Lists.UpdateMemberNoteAsync(
    new UpdateMemberNoteListsRequest
    {
        ListId = "list_id",
        SubscriberHash = "subscriber_hash",
        NoteId = "note_id",
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `UpdateMemberNoteListsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Lists.<a href="/src/Mailchimp.Marketing/Lists/ListsClient.cs">ListMemberTagsAsync</a>(ListMemberTagsListsRequest { ... }) -> Pager&lt;ListMemberTagsListsResponseTagsItem&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get the tags on a list member.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Lists.ListMemberTagsAsync(
    new ListMemberTagsListsRequest { ListId = "list_id", SubscriberHash = "subscriber_hash" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ListMemberTagsListsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Lists.<a href="/src/Mailchimp.Marketing/Lists/ListsClient.cs">CreateMemberTagAsync</a>(CreateMemberTagListsRequest { ... }) -> WithRawResponseTask</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Add or remove tags from a list member. If a tag that does not exist is passed in and set as 'active', a new tag will be created.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Lists.CreateMemberTagAsync(
    new CreateMemberTagListsRequest
    {
        ListId = "list_id",
        SubscriberHash = "subscriber_hash",
        Tags = new global::System.Collections.Generic.List<CreateMemberTagListsRequestTagsItem>()
        {
            new CreateMemberTagListsRequestTagsItem
            {
                Name = "name",
                Status = CreateMemberTagListsRequestTagsItemStatus.Inactive,
            },
        },
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `CreateMemberTagListsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Lists.<a href="/src/Mailchimp.Marketing/Lists/ListsClient.cs">ListMergeFieldsAsync</a>(ListMergeFieldsListsRequest { ... }) -> Pager&lt;MergeField&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get a list of all merge fields for an audience.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Lists.ListMergeFieldsAsync(new ListMergeFieldsListsRequest { ListId = "list_id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ListMergeFieldsListsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Lists.<a href="/src/Mailchimp.Marketing/Lists/ListsClient.cs">CreateMergeFieldAsync</a>(CreateMergeFieldListsRequest { ... }) -> WithRawResponseTask&lt;MergeField&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Add a new merge field for a specific audience.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Lists.CreateMergeFieldAsync(
    new CreateMergeFieldListsRequest
    {
        ListId = "list_id",
        Name = "name",
        Type = CreateMergeFieldListsRequestType.Text,
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `CreateMergeFieldListsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Lists.<a href="/src/Mailchimp.Marketing/Lists/ListsClient.cs">GetMergeFieldAsync</a>(GetMergeFieldListsRequest { ... }) -> WithRawResponseTask&lt;MergeField&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get information about a specific merge field.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Lists.GetMergeFieldAsync(
    new GetMergeFieldListsRequest { ListId = "list_id", MergeId = "merge_id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `GetMergeFieldListsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Lists.<a href="/src/Mailchimp.Marketing/Lists/ListsClient.cs">DeleteMergeFieldAsync</a>(DeleteMergeFieldListsRequest { ... }) -> WithRawResponseTask</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Delete a specific merge field.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Lists.DeleteMergeFieldAsync(
    new DeleteMergeFieldListsRequest { ListId = "list_id", MergeId = "merge_id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `DeleteMergeFieldListsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Lists.<a href="/src/Mailchimp.Marketing/Lists/ListsClient.cs">UpdateMergeFieldAsync</a>(UpdateMergeFieldListsRequest { ... }) -> WithRawResponseTask&lt;MergeField&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Update a specific merge field.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Lists.UpdateMergeFieldAsync(
    new UpdateMergeFieldListsRequest { ListId = "list_id", MergeId = "merge_id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `UpdateMergeFieldListsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Lists.<a href="/src/Mailchimp.Marketing/Lists/ListsClient.cs">ListSegmentsAsync</a>(ListSegmentsListsRequest { ... }) -> Pager&lt;List&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get information about all available segments for a specific list.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Lists.ListSegmentsAsync(new ListSegmentsListsRequest { ListId = "list_id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ListSegmentsListsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Lists.<a href="/src/Mailchimp.Marketing/Lists/ListsClient.cs">CreateSegmentAsync</a>(CreateSegmentListsRequest { ... }) -> WithRawResponseTask&lt;List&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Create a new segment in a specific list.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Lists.CreateSegmentAsync(
    new CreateSegmentListsRequest { ListId = "list_id", Name = "name" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `CreateSegmentListsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Lists.<a href="/src/Mailchimp.Marketing/Lists/ListsClient.cs">GetSegmentAsync</a>(GetSegmentListsRequest { ... }) -> WithRawResponseTask&lt;List&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get information about a specific segment.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Lists.GetSegmentAsync(
    new GetSegmentListsRequest { ListId = "list_id", SegmentId = "segment_id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `GetSegmentListsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Lists.<a href="/src/Mailchimp.Marketing/Lists/ListsClient.cs">BatchAddOrRemoveMembersAsync</a>(BatchAddOrRemoveMembersListsRequest { ... }) -> WithRawResponseTask&lt;BatchAddOrRemoveMembersListsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Batch add/remove list members to static segment
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Lists.BatchAddOrRemoveMembersAsync(
    new BatchAddOrRemoveMembersListsRequest { ListId = "list_id", SegmentId = "segment_id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `BatchAddOrRemoveMembersListsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Lists.<a href="/src/Mailchimp.Marketing/Lists/ListsClient.cs">DeleteSegmentAsync</a>(DeleteSegmentListsRequest { ... }) -> WithRawResponseTask</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Delete a specific segment in a list.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Lists.DeleteSegmentAsync(
    new DeleteSegmentListsRequest { ListId = "list_id", SegmentId = "segment_id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `DeleteSegmentListsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Lists.<a href="/src/Mailchimp.Marketing/Lists/ListsClient.cs">UpdateSegmentAsync</a>(UpdateSegmentListsRequest { ... }) -> WithRawResponseTask&lt;List&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Update a specific segment in a list.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Lists.UpdateSegmentAsync(
    new UpdateSegmentListsRequest { ListId = "list_id", SegmentId = "segment_id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `UpdateSegmentListsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Lists.<a href="/src/Mailchimp.Marketing/Lists/ListsClient.cs">ListSegmentMembersAsync</a>(ListSegmentMembersListsRequest { ... }) -> Pager&lt;ListsSegmentsMembers&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get information about members in a saved segment.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Lists.ListSegmentMembersAsync(
    new ListSegmentMembersListsRequest { ListId = "list_id", SegmentId = "segment_id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ListSegmentMembersListsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Lists.<a href="/src/Mailchimp.Marketing/Lists/ListsClient.cs">CreateSegmentMemberAsync</a>(CreateSegmentMemberListsRequest { ... }) -> WithRawResponseTask&lt;ListsSegmentsMembers&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Add a member to a static segment.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Lists.CreateSegmentMemberAsync(
    new CreateSegmentMemberListsRequest
    {
        ListId = "list_id",
        SegmentId = "segment_id",
        EmailAddress = "email_address",
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `CreateSegmentMemberListsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Lists.<a href="/src/Mailchimp.Marketing/Lists/ListsClient.cs">DeleteSegmentMemberAsync</a>(DeleteSegmentMemberListsRequest { ... }) -> WithRawResponseTask</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Remove a member from the specified static segment.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Lists.DeleteSegmentMemberAsync(
    new DeleteSegmentMemberListsRequest
    {
        ListId = "list_id",
        SegmentId = "segment_id",
        SubscriberHash = "subscriber_hash",
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `DeleteSegmentMemberListsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Lists.<a href="/src/Mailchimp.Marketing/Lists/ListsClient.cs">ListSignupFormsAsync</a>(ListSignupFormsListsRequest { ... }) -> WithRawResponseTask&lt;ListSignupFormsListsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get signup forms for a specific list.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Lists.ListSignupFormsAsync(new ListSignupFormsListsRequest { ListId = "list_id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ListSignupFormsListsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Lists.<a href="/src/Mailchimp.Marketing/Lists/ListsClient.cs">CreateSignupFormAsync</a>(CreateSignupFormListsRequest { ... }) -> WithRawResponseTask&lt;SignupForm&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Customize a list's default signup form.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Lists.CreateSignupFormAsync(new CreateSignupFormListsRequest { ListId = "list_id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `CreateSignupFormListsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Lists.<a href="/src/Mailchimp.Marketing/Lists/ListsClient.cs">ListSurveysAsync</a>(ListSurveysListsRequest { ... }) -> WithRawResponseTask&lt;object&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get information about all available surveys for a specific list.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Lists.ListSurveysAsync(new ListSurveysListsRequest { ListId = "list_id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ListSurveysListsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Lists.<a href="/src/Mailchimp.Marketing/Lists/ListsClient.cs">CreateSurveyAsync</a>(CreateSurveyListsRequest { ... }) -> WithRawResponseTask&lt;object&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Create a draft survey for an audience.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Lists.CreateSurveyAsync(new CreateSurveyListsRequest { ListId = "list_id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `CreateSurveyListsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Lists.<a href="/src/Mailchimp.Marketing/Lists/ListsClient.cs">GetSurveyAsync</a>(GetSurveyListsRequest { ... }) -> WithRawResponseTask&lt;object&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get details about a specific survey.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Lists.GetSurveyAsync(
    new GetSurveyListsRequest { ListId = "list_id", SurveyId = "survey_id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `GetSurveyListsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Lists.<a href="/src/Mailchimp.Marketing/Lists/ListsClient.cs">DeleteSurveyAsync</a>(DeleteSurveyListsRequest { ... }) -> WithRawResponseTask</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Delete a survey.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Lists.DeleteSurveyAsync(
    new DeleteSurveyListsRequest { ListId = "list_id", SurveyId = "survey_id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `DeleteSurveyListsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Lists.<a href="/src/Mailchimp.Marketing/Lists/ListsClient.cs">UpdateSurveyAsync</a>(UpdateSurveyListsRequest { ... }) -> WithRawResponseTask&lt;object&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Update a survey. When sections is provided, send the complete section list in display order. Any existing section not included is deleted.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Lists.UpdateSurveyAsync(
    new UpdateSurveyListsRequest { ListId = "list_id", SurveyId = "survey_id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `UpdateSurveyListsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Lists.<a href="/src/Mailchimp.Marketing/Lists/ListsClient.cs">CreateListSurveyActionReplicateAsync</a>(CreateListSurveyActionReplicateListsRequest { ... }) -> WithRawResponseTask&lt;object&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Replicate a survey.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Lists.CreateListSurveyActionReplicateAsync(
    new CreateListSurveyActionReplicateListsRequest
    {
        ListIdPathParam = "list_id",
        SurveyId = "survey_id",
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `CreateListSurveyActionReplicateListsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Lists.<a href="/src/Mailchimp.Marketing/Lists/ListsClient.cs">ListTagSearchAsync</a>(ListTagSearchListsRequest { ... }) -> WithRawResponseTask&lt;ListTagSearchListsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Search for tags on a list by name. If no name is provided, will return all tags on the list.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Lists.ListTagSearchAsync(new ListTagSearchListsRequest { ListId = "list_id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ListTagSearchListsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Lists.<a href="/src/Mailchimp.Marketing/Lists/ListsClient.cs">ListWebhooksAsync</a>(ListWebhooksListsRequest { ... }) -> WithRawResponseTask&lt;ListWebhooksListsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get information about all webhooks for a specific list.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Lists.ListWebhooksAsync(new ListWebhooksListsRequest { ListId = "list_id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ListWebhooksListsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Lists.<a href="/src/Mailchimp.Marketing/Lists/ListsClient.cs">CreateWebhookAsync</a>(CreateWebhookListsRequest { ... }) -> WithRawResponseTask&lt;CreateWebhookListsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Create a new webhook for a specific list.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Lists.CreateWebhookAsync(
    new CreateWebhookListsRequest { ListId = "list_id", Body = new AddWebhook() }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `CreateWebhookListsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Lists.<a href="/src/Mailchimp.Marketing/Lists/ListsClient.cs">GetWebhookAsync</a>(GetWebhookListsRequest { ... }) -> WithRawResponseTask&lt;ListWebhooks&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get information about a specific webhook.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Lists.GetWebhookAsync(
    new GetWebhookListsRequest { ListId = "list_id", WebhookId = "webhook_id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `GetWebhookListsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Lists.<a href="/src/Mailchimp.Marketing/Lists/ListsClient.cs">DeleteWebhookAsync</a>(DeleteWebhookListsRequest { ... }) -> WithRawResponseTask</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Delete a specific webhook in a list.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Lists.DeleteWebhookAsync(
    new DeleteWebhookListsRequest { ListId = "list_id", WebhookId = "webhook_id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `DeleteWebhookListsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Lists.<a href="/src/Mailchimp.Marketing/Lists/ListsClient.cs">UpdateWebhookAsync</a>(UpdateWebhookListsRequest { ... }) -> WithRawResponseTask&lt;ListWebhooks&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Update the settings for an existing webhook.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Lists.UpdateWebhookAsync(
    new UpdateWebhookListsRequest
    {
        ListId = "list_id",
        WebhookId = "webhook_id",
        Body = new AddWebhook(),
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `UpdateWebhookListsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## surveys
<details><summary><code>client.Surveys.<a href="/src/Mailchimp.Marketing/Surveys/SurveysClient.cs">CreateListSurveyActionCreateEmailAsync</a>(CreateListSurveyActionCreateEmailSurveysRequest { ... }) -> WithRawResponseTask&lt;Campaign&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Utilize the List ID and Survey ID to generate a Campaign that links to your survey.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Surveys.CreateListSurveyActionCreateEmailAsync(
    new CreateListSurveyActionCreateEmailSurveysRequest
    {
        ListId = "list_id",
        SurveyId = "survey_id",
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `CreateListSurveyActionCreateEmailSurveysRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Surveys.<a href="/src/Mailchimp.Marketing/Surveys/SurveysClient.cs">CreateListSurveyActionPublishAsync</a>(CreateListSurveyActionPublishSurveysRequest { ... }) -> WithRawResponseTask&lt;object&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Publish a survey that is in draft, unpublished, or has been previously published and edited.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Surveys.CreateListSurveyActionPublishAsync(
    new CreateListSurveyActionPublishSurveysRequest { ListId = "list_id", SurveyId = "survey_id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `CreateListSurveyActionPublishSurveysRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Surveys.<a href="/src/Mailchimp.Marketing/Surveys/SurveysClient.cs">CreateListSurveyActionUnpublishAsync</a>(CreateListSurveyActionUnpublishSurveysRequest { ... }) -> WithRawResponseTask&lt;object&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Unpublish a survey that has been published.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Surveys.CreateListSurveyActionUnpublishAsync(
    new CreateListSurveyActionUnpublishSurveysRequest { ListId = "list_id", SurveyId = "survey_id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `CreateListSurveyActionUnpublishSurveysRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## ping
<details><summary><code>client.Ping.<a href="/src/Mailchimp.Marketing/Ping/PingClient.cs">ListAsync</a>() -> WithRawResponseTask&lt;ListPingResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

A health check for the API that won't return any account-specific information.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ping.ListAsync();
```
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## reporting
<details><summary><code>client.Reporting.<a href="/src/Mailchimp.Marketing/Reporting/ReportingClient.cs">ListAsync</a>() -> WithRawResponseTask&lt;IEnumerable&lt;ListReportingResponseItem&gt;&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get information about the reporting endpoint's resources.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Reporting.ListAsync();
```
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Reporting.<a href="/src/Mailchimp.Marketing/Reporting/ReportingClient.cs">ListFacebookAdsAsync</a>(ListFacebookAdsReportingRequest { ... }) -> Pager&lt;ReportingFacebookAd&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get reports of Facebook ads.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Reporting.ListFacebookAdsAsync(new ListFacebookAdsReportingRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ListFacebookAdsReportingRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Reporting.<a href="/src/Mailchimp.Marketing/Reporting/ReportingClient.cs">GetFacebookAdAsync</a>(GetFacebookAdReportingRequest { ... }) -> WithRawResponseTask&lt;ReportingFacebookAd&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get report of a Facebook ad.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Reporting.GetFacebookAdAsync(
    new GetFacebookAdReportingRequest { OutreachId = "outreach_id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `GetFacebookAdReportingRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Reporting.<a href="/src/Mailchimp.Marketing/Reporting/ReportingClient.cs">ListFacebookAdEcommerceProductActivityAsync</a>(ListFacebookAdEcommerceProductActivityReportingRequest { ... }) -> Pager&lt;ListFacebookAdEcommerceProductActivityReportingResponseProductsItem&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get breakdown of product activity for an outreach.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Reporting.ListFacebookAdEcommerceProductActivityAsync(
    new ListFacebookAdEcommerceProductActivityReportingRequest { OutreachId = "outreach_id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ListFacebookAdEcommerceProductActivityReportingRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Reporting.<a href="/src/Mailchimp.Marketing/Reporting/ReportingClient.cs">ListLandingPagesAsync</a>(ListLandingPagesReportingRequest { ... }) -> Pager&lt;LandingPageReport&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get reports of landing pages.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Reporting.ListLandingPagesAsync(new ListLandingPagesReportingRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ListLandingPagesReportingRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Reporting.<a href="/src/Mailchimp.Marketing/Reporting/ReportingClient.cs">GetLandingPageAsync</a>(GetLandingPageReportingRequest { ... }) -> WithRawResponseTask&lt;LandingPageReport&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get report of a landing page.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Reporting.GetLandingPageAsync(
    new GetLandingPageReportingRequest { OutreachId = "outreach_id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `GetLandingPageReportingRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Reporting.<a href="/src/Mailchimp.Marketing/Reporting/ReportingClient.cs">ListSurveysAsync</a>(ListSurveysReportingRequest { ... }) -> Pager&lt;ListSurveysReportingResponseSurveysItem&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get reports for surveys.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Reporting.ListSurveysAsync(new ListSurveysReportingRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ListSurveysReportingRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Reporting.<a href="/src/Mailchimp.Marketing/Reporting/ReportingClient.cs">GetSurveyAsync</a>(GetSurveyReportingRequest { ... }) -> WithRawResponseTask&lt;GetSurveyReportingResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get report for a survey.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Reporting.GetSurveyAsync(new GetSurveyReportingRequest { SurveyId = "survey_id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `GetSurveyReportingRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Reporting.<a href="/src/Mailchimp.Marketing/Reporting/ReportingClient.cs">ListSurveyQuestionsAsync</a>(ListSurveyQuestionsReportingRequest { ... }) -> WithRawResponseTask&lt;ListSurveyQuestionsReportingResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get reports for survey questions.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Reporting.ListSurveyQuestionsAsync(
    new ListSurveyQuestionsReportingRequest { SurveyId = "survey_id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ListSurveyQuestionsReportingRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Reporting.<a href="/src/Mailchimp.Marketing/Reporting/ReportingClient.cs">GetSurveyQuestionAsync</a>(GetSurveyQuestionReportingRequest { ... }) -> WithRawResponseTask&lt;SurveyQuestionReport&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get report for a survey question.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Reporting.GetSurveyQuestionAsync(
    new GetSurveyQuestionReportingRequest { SurveyId = "survey_id", QuestionId = "question_id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `GetSurveyQuestionReportingRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Reporting.<a href="/src/Mailchimp.Marketing/Reporting/ReportingClient.cs">ListSurveyQuestionAnswersAsync</a>(ListSurveyQuestionAnswersReportingRequest { ... }) -> WithRawResponseTask&lt;ListSurveyQuestionAnswersReportingResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get answers for a survey question.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Reporting.ListSurveyQuestionAnswersAsync(
    new ListSurveyQuestionAnswersReportingRequest
    {
        SurveyId = "survey_id",
        QuestionId = "question_id",
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ListSurveyQuestionAnswersReportingRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Reporting.<a href="/src/Mailchimp.Marketing/Reporting/ReportingClient.cs">ListSurveyResponsesAsync</a>(ListSurveyResponsesReportingRequest { ... }) -> WithRawResponseTask&lt;ListSurveyResponsesReportingResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get responses to a survey.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Reporting.ListSurveyResponsesAsync(
    new ListSurveyResponsesReportingRequest { SurveyId = "survey_id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ListSurveyResponsesReportingRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Reporting.<a href="/src/Mailchimp.Marketing/Reporting/ReportingClient.cs">GetSurveyResponsAsync</a>(GetSurveyResponsReportingRequest { ... }) -> WithRawResponseTask&lt;GetSurveyResponsReportingResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get a single survey response.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Reporting.GetSurveyResponsAsync(
    new GetSurveyResponsReportingRequest { SurveyId = "survey_id", ResponseId = "response_id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `GetSurveyResponsReportingRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## reports
<details><summary><code>client.Reports.<a href="/src/Mailchimp.Marketing/Reports/ReportsClient.cs">ListAsync</a>(ListReportsRequest { ... }) -> Pager&lt;CampaignReport&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get campaign reports.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Reports.ListAsync(new ListReportsRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ListReportsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Reports.<a href="/src/Mailchimp.Marketing/Reports/ReportsClient.cs">GetAsync</a>(GetReportsRequest { ... }) -> WithRawResponseTask&lt;CampaignReport&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get report details for a specific sent campaign.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Reports.GetAsync(new GetReportsRequest { CampaignId = "campaign_id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `GetReportsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Reports.<a href="/src/Mailchimp.Marketing/Reports/ReportsClient.cs">ListAbuseReportsAsync</a>(ListAbuseReportsReportsRequest { ... }) -> WithRawResponseTask&lt;ListAbuseReportsReportsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get a list of abuse complaints for a specific campaign.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Reports.ListAbuseReportsAsync(
    new ListAbuseReportsReportsRequest { CampaignId = "campaign_id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ListAbuseReportsReportsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Reports.<a href="/src/Mailchimp.Marketing/Reports/ReportsClient.cs">GetAbuseReportAsync</a>(GetAbuseReportReportsRequest { ... }) -> WithRawResponseTask&lt;AbuseComplaint&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get information about a specific abuse report for a campaign.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Reports.GetAbuseReportAsync(
    new GetAbuseReportReportsRequest { CampaignId = "campaign_id", ReportId = "report_id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `GetAbuseReportReportsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Reports.<a href="/src/Mailchimp.Marketing/Reports/ReportsClient.cs">ListAdviceAsync</a>(ListAdviceReportsRequest { ... }) -> WithRawResponseTask&lt;ListAdviceReportsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get feedback based on a campaign's statistics. Advice feedback is based on campaign stats like opens, clicks, unsubscribes, bounces, and more.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Reports.ListAdviceAsync(new ListAdviceReportsRequest { CampaignId = "campaign_id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ListAdviceReportsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Reports.<a href="/src/Mailchimp.Marketing/Reports/ReportsClient.cs">ListClickDetailsAsync</a>(ListClickDetailsReportsRequest { ... }) -> Pager&lt;ClickDetailReport&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get information about clicks on specific links in your Mailchimp campaigns.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Reports.ListClickDetailsAsync(
    new ListClickDetailsReportsRequest { CampaignId = "campaign_id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ListClickDetailsReportsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Reports.<a href="/src/Mailchimp.Marketing/Reports/ReportsClient.cs">GetClickDetailAsync</a>(GetClickDetailReportsRequest { ... }) -> WithRawResponseTask&lt;ClickDetailReport&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get click details for a specific link in a campaign.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Reports.GetClickDetailAsync(
    new GetClickDetailReportsRequest { CampaignId = "campaign_id", LinkId = "link_id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `GetClickDetailReportsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Reports.<a href="/src/Mailchimp.Marketing/Reports/ReportsClient.cs">ListClickDetailMembersAsync</a>(ListClickDetailMembersReportsRequest { ... }) -> Pager&lt;ClickDetailMember&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get information about list members who clicked on a specific link in a campaign.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Reports.ListClickDetailMembersAsync(
    new ListClickDetailMembersReportsRequest { CampaignId = "campaign_id", LinkId = "link_id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ListClickDetailMembersReportsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Reports.<a href="/src/Mailchimp.Marketing/Reports/ReportsClient.cs">GetClickDetailMemberAsync</a>(GetClickDetailMemberReportsRequest { ... }) -> WithRawResponseTask&lt;ClickDetailMember&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get information about a specific subscriber who clicked a link in a specific campaign.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Reports.GetClickDetailMemberAsync(
    new GetClickDetailMemberReportsRequest
    {
        CampaignId = "campaign_id",
        LinkId = "link_id",
        SubscriberHash = "subscriber_hash",
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `GetClickDetailMemberReportsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Reports.<a href="/src/Mailchimp.Marketing/Reports/ReportsClient.cs">ListDomainPerformanceAsync</a>(ListDomainPerformanceReportsRequest { ... }) -> WithRawResponseTask&lt;ListDomainPerformanceReportsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get statistics for the top-performing email domains in a campaign.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Reports.ListDomainPerformanceAsync(
    new ListDomainPerformanceReportsRequest { CampaignId = "campaign_id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ListDomainPerformanceReportsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Reports.<a href="/src/Mailchimp.Marketing/Reports/ReportsClient.cs">ListEcommerceProductActivityAsync</a>(ListEcommerceProductActivityReportsRequest { ... }) -> Pager&lt;ListEcommerceProductActivityReportsResponseProductsItem&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get breakdown of product activity for a campaign
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Reports.ListEcommerceProductActivityAsync(
    new ListEcommerceProductActivityReportsRequest { CampaignId = "campaign_id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ListEcommerceProductActivityReportsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Reports.<a href="/src/Mailchimp.Marketing/Reports/ReportsClient.cs">ListEepurlAsync</a>(ListEepurlReportsRequest { ... }) -> WithRawResponseTask&lt;ListEepurlReportsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get a summary of social activity for the campaign, tracked by EepURL.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Reports.ListEepurlAsync(new ListEepurlReportsRequest { CampaignId = "campaign_id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ListEepurlReportsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Reports.<a href="/src/Mailchimp.Marketing/Reports/ReportsClient.cs">ListEmailActivityAsync</a>(ListEmailActivityReportsRequest { ... }) -> Pager&lt;EmailActivity&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get a list of member's subscriber activity in a specific campaign.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Reports.ListEmailActivityAsync(
    new ListEmailActivityReportsRequest { CampaignId = "campaign_id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ListEmailActivityReportsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Reports.<a href="/src/Mailchimp.Marketing/Reports/ReportsClient.cs">GetEmailActivityAsync</a>(GetEmailActivityReportsRequest { ... }) -> WithRawResponseTask&lt;EmailActivity&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get a specific list member's activity in a campaign including opens, clicks, and bounces.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Reports.GetEmailActivityAsync(
    new GetEmailActivityReportsRequest
    {
        CampaignId = "campaign_id",
        SubscriberHash = "subscriber_hash",
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `GetEmailActivityReportsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Reports.<a href="/src/Mailchimp.Marketing/Reports/ReportsClient.cs">ListLocationsAsync</a>(ListLocationsReportsRequest { ... }) -> Pager&lt;ListLocationsReportsResponseLocationsItem&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get top open locations for a specific campaign.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Reports.ListLocationsAsync(
    new ListLocationsReportsRequest { CampaignId = "campaign_id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ListLocationsReportsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Reports.<a href="/src/Mailchimp.Marketing/Reports/ReportsClient.cs">ListOpenDetailsAsync</a>(ListOpenDetailsReportsRequest { ... }) -> Pager&lt;OpenActivity&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get detailed information about any campaign emails that were opened by a list member.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Reports.ListOpenDetailsAsync(
    new ListOpenDetailsReportsRequest { CampaignId = "campaign_id", Since = "2016-04-12 12:00:00" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ListOpenDetailsReportsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Reports.<a href="/src/Mailchimp.Marketing/Reports/ReportsClient.cs">GetOpenDetailAsync</a>(GetOpenDetailReportsRequest { ... }) -> WithRawResponseTask&lt;OpenActivity&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get information about a specific subscriber who opened a campaign.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Reports.GetOpenDetailAsync(
    new GetOpenDetailReportsRequest
    {
        CampaignId = "campaign_id",
        SubscriberHash = "subscriber_hash",
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `GetOpenDetailReportsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Reports.<a href="/src/Mailchimp.Marketing/Reports/ReportsClient.cs">ListSentToAsync</a>(ListSentToReportsRequest { ... }) -> Pager&lt;SentTo&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get information about campaign recipients.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Reports.ListSentToAsync(new ListSentToReportsRequest { CampaignId = "campaign_id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ListSentToReportsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Reports.<a href="/src/Mailchimp.Marketing/Reports/ReportsClient.cs">GetSentToAsync</a>(GetSentToReportsRequest { ... }) -> WithRawResponseTask&lt;SentTo&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get information about a specific campaign recipient.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Reports.GetSentToAsync(
    new GetSentToReportsRequest { CampaignId = "campaign_id", SubscriberHash = "subscriber_hash" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `GetSentToReportsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Reports.<a href="/src/Mailchimp.Marketing/Reports/ReportsClient.cs">ListSubReportsAsync</a>(ListSubReportsReportsRequest { ... }) -> WithRawResponseTask&lt;ListSubReportsReportsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get a list of reports with child campaigns for a specific parent campaign.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Reports.ListSubReportsAsync(
    new ListSubReportsReportsRequest { CampaignId = "campaign_id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ListSubReportsReportsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Reports.<a href="/src/Mailchimp.Marketing/Reports/ReportsClient.cs">ListUnsubscribedAsync</a>(ListUnsubscribedReportsRequest { ... }) -> Pager&lt;Unsubscribes&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get information about members who have unsubscribed from a specific campaign.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Reports.ListUnsubscribedAsync(
    new ListUnsubscribedReportsRequest { CampaignId = "campaign_id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ListUnsubscribedReportsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Reports.<a href="/src/Mailchimp.Marketing/Reports/ReportsClient.cs">GetUnsubscribedAsync</a>(GetUnsubscribedReportsRequest { ... }) -> WithRawResponseTask&lt;Unsubscribes&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get information about a specific list member who unsubscribed from a campaign.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Reports.GetUnsubscribedAsync(
    new GetUnsubscribedReportsRequest
    {
        CampaignId = "campaign_id",
        SubscriberHash = "subscriber_hash",
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `GetUnsubscribedReportsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## SearchCampaigns
<details><summary><code>client.SearchCampaigns.<a href="/src/Mailchimp.Marketing/SearchCampaigns/SearchCampaignsClient.cs">ListAsync</a>(ListSearchCampaignsRequest { ... }) -> WithRawResponseTask&lt;ListSearchCampaignsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Search all campaigns for the specified query terms.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.SearchCampaigns.ListAsync(new ListSearchCampaignsRequest { Query = "query" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ListSearchCampaignsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## SmsCampaigns
<details><summary><code>client.SmsCampaigns.<a href="/src/Mailchimp.Marketing/SmsCampaigns/SmsCampaignsClient.cs">ListAsync</a>(ListSmsCampaignsRequest { ... }) -> Pager&lt;SmsCampaign&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get all SMS campaigns in an account.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.SmsCampaigns.ListAsync(new ListSmsCampaignsRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ListSmsCampaignsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.SmsCampaigns.<a href="/src/Mailchimp.Marketing/SmsCampaigns/SmsCampaignsClient.cs">CreateAsync</a>(CreateSmsCampaignsRequest { ... }) -> WithRawResponseTask&lt;SmsCampaign&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Create a new SMS campaign.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.SmsCampaigns.CreateAsync(new CreateSmsCampaignsRequest { Name = "name" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `CreateSmsCampaignsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.SmsCampaigns.<a href="/src/Mailchimp.Marketing/SmsCampaigns/SmsCampaignsClient.cs">GetAsync</a>(GetSmsCampaignsRequest { ... }) -> WithRawResponseTask&lt;SmsCampaign&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get the details for a single SMS campaign.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.SmsCampaigns.GetAsync(
    new GetSmsCampaignsRequest { SmsCampaignId = "sms_campaign_id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `GetSmsCampaignsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.SmsCampaigns.<a href="/src/Mailchimp.Marketing/SmsCampaigns/SmsCampaignsClient.cs">DeleteAsync</a>(DeleteSmsCampaignsRequest { ... }) -> WithRawResponseTask</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Remove a campaign from your Mailchimp account.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.SmsCampaigns.DeleteAsync(
    new DeleteSmsCampaignsRequest { SmsCampaignId = "sms_campaign_id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `DeleteSmsCampaignsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.SmsCampaigns.<a href="/src/Mailchimp.Marketing/SmsCampaigns/SmsCampaignsClient.cs">UpdateAsync</a>(UpdateSmsCampaignsRequest { ... }) -> WithRawResponseTask&lt;SmsCampaign&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Update an SMS campaign.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.SmsCampaigns.UpdateAsync(
    new UpdateSmsCampaignsRequest { SmsCampaignId = "sms_campaign_id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `UpdateSmsCampaignsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.SmsCampaigns.<a href="/src/Mailchimp.Marketing/SmsCampaigns/SmsCampaignsClient.cs">CreateActionCancelSendAsync</a>(CreateActionCancelSendSmsCampaignsRequest { ... }) -> WithRawResponseTask</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Cancel a scheduled or sending SMS campaign.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.SmsCampaigns.CreateActionCancelSendAsync(
    new CreateActionCancelSendSmsCampaignsRequest { SmsCampaignId = "sms_campaign_id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `CreateActionCancelSendSmsCampaignsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.SmsCampaigns.<a href="/src/Mailchimp.Marketing/SmsCampaigns/SmsCampaignsClient.cs">CreateActionScheduleAsync</a>(CreateActionScheduleSmsCampaignsRequest { ... }) -> WithRawResponseTask</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Schedule an SMS campaign for delivery.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.SmsCampaigns.CreateActionScheduleAsync(
    new CreateActionScheduleSmsCampaignsRequest
    {
        SmsCampaignId = "sms_campaign_id",
        ScheduleTime = new DateTime(2024, 01, 15, 09, 30, 00, 000),
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `CreateActionScheduleSmsCampaignsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.SmsCampaigns.<a href="/src/Mailchimp.Marketing/SmsCampaigns/SmsCampaignsClient.cs">CreateActionSendAsync</a>(CreateActionSendSmsCampaignsRequest { ... }) -> WithRawResponseTask</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Send an SMS campaign.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.SmsCampaigns.CreateActionSendAsync(
    new CreateActionSendSmsCampaignsRequest { SmsCampaignId = "sms_campaign_id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `CreateActionSendSmsCampaignsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.SmsCampaigns.<a href="/src/Mailchimp.Marketing/SmsCampaigns/SmsCampaignsClient.cs">GetContentAsync</a>(GetContentSmsCampaignsRequest { ... }) -> WithRawResponseTask&lt;SmsCampaignContent&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get the content for an SMS campaign.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.SmsCampaigns.GetContentAsync(
    new GetContentSmsCampaignsRequest { SmsCampaignId = "sms_campaign_id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `GetContentSmsCampaignsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.SmsCampaigns.<a href="/src/Mailchimp.Marketing/SmsCampaigns/SmsCampaignsClient.cs">UpsertContentAsync</a>(UpsertContentSmsCampaignsRequest { ... }) -> WithRawResponseTask&lt;SmsCampaignContent&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Set the content for an SMS campaign.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.SmsCampaigns.UpsertContentAsync(
    new UpsertContentSmsCampaignsRequest
    {
        SmsCampaignId = "sms_campaign_id",
        MessageBody = "message_body",
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `UpsertContentSmsCampaignsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## SearchMembers
<details><summary><code>client.SearchMembers.<a href="/src/Mailchimp.Marketing/SearchMembers/SearchMembersClient.cs">ListAsync</a>(ListSearchMembersRequest { ... }) -> WithRawResponseTask&lt;ListSearchMembersResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Search for list members. This search can be restricted to a specific list, or can be used to search across all lists in an account.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.SearchMembers.ListAsync(new ListSearchMembersRequest { Query = "query" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ListSearchMembersRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## TemplateFolders
<details><summary><code>client.TemplateFolders.<a href="/src/Mailchimp.Marketing/TemplateFolders/TemplateFoldersClient.cs">ListAsync</a>(ListTemplateFoldersRequest { ... }) -> Pager&lt;ListTemplateFoldersResponseFoldersItem&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get all folders used to organize templates.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.TemplateFolders.ListAsync(new ListTemplateFoldersRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ListTemplateFoldersRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.TemplateFolders.<a href="/src/Mailchimp.Marketing/TemplateFolders/TemplateFoldersClient.cs">CreateAsync</a>(CreateTemplateFoldersRequest { ... }) -> WithRawResponseTask&lt;CreateTemplateFoldersResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Create a new template folder.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.TemplateFolders.CreateAsync(new CreateTemplateFoldersRequest { Name = "name" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `CreateTemplateFoldersRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.TemplateFolders.<a href="/src/Mailchimp.Marketing/TemplateFolders/TemplateFoldersClient.cs">GetAsync</a>(GetTemplateFoldersRequest { ... }) -> WithRawResponseTask&lt;GetTemplateFoldersResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get information about a specific folder used to organize templates.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.TemplateFolders.GetAsync(new GetTemplateFoldersRequest { FolderId = "folder_id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `GetTemplateFoldersRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.TemplateFolders.<a href="/src/Mailchimp.Marketing/TemplateFolders/TemplateFoldersClient.cs">DeleteAsync</a>(DeleteTemplateFoldersRequest { ... }) -> WithRawResponseTask</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Delete a specific template folder, and mark all the templates in the folder as 'unfiled'.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.TemplateFolders.DeleteAsync(
    new DeleteTemplateFoldersRequest { FolderId = "folder_id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `DeleteTemplateFoldersRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.TemplateFolders.<a href="/src/Mailchimp.Marketing/TemplateFolders/TemplateFoldersClient.cs">UpdateAsync</a>(UpdateTemplateFoldersRequest { ... }) -> WithRawResponseTask&lt;UpdateTemplateFoldersResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Update a specific folder used to organize templates.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.TemplateFolders.UpdateAsync(
    new UpdateTemplateFoldersRequest { FolderId = "folder_id", Name = "name" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `UpdateTemplateFoldersRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## templates
<details><summary><code>client.Templates.<a href="/src/Mailchimp.Marketing/Templates/TemplatesClient.cs">ListAsync</a>(ListTemplatesRequest { ... }) -> Pager&lt;TemplateInstance&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get a list of an account's available templates.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Templates.ListAsync(new ListTemplatesRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ListTemplatesRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Templates.<a href="/src/Mailchimp.Marketing/Templates/TemplatesClient.cs">CreateAsync</a>(CreateTemplatesRequest { ... }) -> WithRawResponseTask&lt;TemplateInstance&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Create a new template for the account. Only Classic templates are supported.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Templates.CreateAsync(
    new CreateTemplatesRequest { Html = "html", Name = "Freddie's Jokes" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `CreateTemplatesRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Templates.<a href="/src/Mailchimp.Marketing/Templates/TemplatesClient.cs">GetAsync</a>(GetTemplatesRequest { ... }) -> WithRawResponseTask&lt;TemplateInstance&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get information about a specific template.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Templates.GetAsync(new GetTemplatesRequest { TemplateId = "template_id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `GetTemplatesRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Templates.<a href="/src/Mailchimp.Marketing/Templates/TemplatesClient.cs">DeleteAsync</a>(DeleteTemplatesRequest { ... }) -> WithRawResponseTask</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Delete a specific template.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Templates.DeleteAsync(new DeleteTemplatesRequest { TemplateId = "template_id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `DeleteTemplatesRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Templates.<a href="/src/Mailchimp.Marketing/Templates/TemplatesClient.cs">UpdateAsync</a>(UpdateTemplatesRequest { ... }) -> WithRawResponseTask&lt;TemplateInstance&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Update the name, HTML, or `folder_id` of an existing template.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Templates.UpdateAsync(new UpdateTemplatesRequest { TemplateId = "template_id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `UpdateTemplatesRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Templates.<a href="/src/Mailchimp.Marketing/Templates/TemplatesClient.cs">ListDefaultContentAsync</a>(ListDefaultContentTemplatesRequest { ... }) -> WithRawResponseTask&lt;ListDefaultContentTemplatesResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get the sections that you can edit in a template, including each section's default content.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Templates.ListDefaultContentAsync(
    new ListDefaultContentTemplatesRequest { TemplateId = "template_id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ListDefaultContentTemplatesRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## VerifiedDomains
<details><summary><code>client.VerifiedDomains.<a href="/src/Mailchimp.Marketing/VerifiedDomains/VerifiedDomainsClient.cs">ListAsync</a>() -> WithRawResponseTask&lt;ListVerifiedDomainsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get all of the sending domains on the account.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.VerifiedDomains.ListAsync();
```
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.VerifiedDomains.<a href="/src/Mailchimp.Marketing/VerifiedDomains/VerifiedDomainsClient.cs">CreateAsync</a>(CreateVerifiedDomainsRequest { ... }) -> WithRawResponseTask&lt;CreateVerifiedDomainsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Add a domain to the account.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.VerifiedDomains.CreateAsync(
    new CreateVerifiedDomainsRequest { VerificationEmail = "verification_email" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `CreateVerifiedDomainsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.VerifiedDomains.<a href="/src/Mailchimp.Marketing/VerifiedDomains/VerifiedDomainsClient.cs">GetAsync</a>(GetVerifiedDomainsRequest { ... }) -> WithRawResponseTask&lt;GetVerifiedDomainsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get the details for a single domain on the account.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.VerifiedDomains.GetAsync(new GetVerifiedDomainsRequest { DomainName = "domain_name" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `GetVerifiedDomainsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.VerifiedDomains.<a href="/src/Mailchimp.Marketing/VerifiedDomains/VerifiedDomainsClient.cs">DeleteAsync</a>(DeleteVerifiedDomainsRequest { ... }) -> WithRawResponseTask</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Delete a verified domain from the account.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.VerifiedDomains.DeleteAsync(
    new DeleteVerifiedDomainsRequest { DomainName = "domain_name" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `DeleteVerifiedDomainsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.VerifiedDomains.<a href="/src/Mailchimp.Marketing/VerifiedDomains/VerifiedDomainsClient.cs">CreateActionVerifyAsync</a>(CreateActionVerifyVerifiedDomainsRequest { ... }) -> WithRawResponseTask&lt;CreateActionVerifyVerifiedDomainsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Verify a domain for sending.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.VerifiedDomains.CreateActionVerifyAsync(
    new CreateActionVerifyVerifiedDomainsRequest { DomainName = "domain_name", Code = "code" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `CreateActionVerifyVerifiedDomainsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

