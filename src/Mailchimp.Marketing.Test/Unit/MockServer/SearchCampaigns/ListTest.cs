using Mailchimp.Marketing;
using Mailchimp.Marketing.Test.Unit.MockServer;
using Mailchimp.Marketing.Test.Utils;
using NUnit.Framework;

namespace Mailchimp.Marketing.Test.Unit.MockServer.SearchCampaigns;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class ListTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "results": [
                {
                  "campaign": {
                    "recipients": {
                      "segment_opts": {
                        "conditions": [
                          {
                            "condition_type": "Aim",
                            "value": "any"
                          }
                        ],
                        "prebuilt_segment_id": "subscribers-female"
                      }
                    }
                  },
                  "snippet": "snippet"
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/3.0/search-campaigns")
                    .WithParam("query", "query")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.SearchCampaigns.ListAsync(
            new ListSearchCampaignsRequest { Query = "query" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
