# Amazon.Advertising.SponsoredProducts.Api.BudgetUsageApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**SpCampaignsBudgetUsage**](BudgetUsageApi.md#spcampaignsbudgetusage) | **POST** /sp/campaigns/budget/usage | Budget usage API for SP campaigns |

<a name="spcampaignsbudgetusage"></a>
# **SpCampaignsBudgetUsage**
> BudgetUsageCampaignResponse SpCampaignsBudgetUsage (Object amazonAdvertisingAPIClientId, Object amazonAdvertisingAPIScope, BudgetUsageCampaignRequest budgetUsageCampaignRequest)

Budget usage API for SP campaigns

  **Requires one of these permissions**: [\"advertiser_campaign_edit\",\"advertiser_campaign_view\"]

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Amazon.Advertising.SponsoredProducts.Api;
using Amazon.Advertising.SponsoredProducts.Client;
using Amazon.Advertising.SponsoredProducts.Model;

namespace Example
{
    public class SpCampaignsBudgetUsageExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new BudgetUsageApi(config);
            var amazonAdvertisingAPIClientId = new Object(); // Object | The identifier of a client associated with a \"Login with Amazon\" account. This is a required header for advertisers and integrators using the Advertising API.
            var amazonAdvertisingAPIScope = new Object(); // Object | The identifier of a profile associated with the advertiser account. Use `GET` method on Profiles resource to list profiles associated with the access token passed in the HTTP Authorization header. This is a required header for advertisers and integrators using the Advertising API.
            var budgetUsageCampaignRequest = new BudgetUsageCampaignRequest(); // BudgetUsageCampaignRequest | 

            try
            {
                // Budget usage API for SP campaigns
                BudgetUsageCampaignResponse result = apiInstance.SpCampaignsBudgetUsage(amazonAdvertisingAPIClientId, amazonAdvertisingAPIScope, budgetUsageCampaignRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BudgetUsageApi.SpCampaignsBudgetUsage: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SpCampaignsBudgetUsageWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Budget usage API for SP campaigns
    ApiResponse<BudgetUsageCampaignResponse> response = apiInstance.SpCampaignsBudgetUsageWithHttpInfo(amazonAdvertisingAPIClientId, amazonAdvertisingAPIScope, budgetUsageCampaignRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BudgetUsageApi.SpCampaignsBudgetUsageWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **amazonAdvertisingAPIClientId** | [**Object**](Object.md) | The identifier of a client associated with a \&quot;Login with Amazon\&quot; account. This is a required header for advertisers and integrators using the Advertising API. |  |
| **amazonAdvertisingAPIScope** | [**Object**](Object.md) | The identifier of a profile associated with the advertiser account. Use &#x60;GET&#x60; method on Profiles resource to list profiles associated with the access token passed in the HTTP Authorization header. This is a required header for advertisers and integrators using the Advertising API. |  |
| **budgetUsageCampaignRequest** | [**BudgetUsageCampaignRequest**](BudgetUsageCampaignRequest.md) |  |  |

### Return type

[**BudgetUsageCampaignResponse**](BudgetUsageCampaignResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/vnd.spcampaignbudgetusage.v1+json
 - **Accept**: application/json, application/vnd.spcampaignbudgetusage.v1+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **400** | Bad Request. |  -  |
| **422** | Unprocessable entity. The server understood the request, but was unable to process the instruction. |  -  |
| **401** | Unauthorized. The request failed because the user is not authenticated or is not allowed to invoke the operation. |  -  |
| **500** | Internal Server BudgetUsageError - Something went wrong on the server. Retry later and report an BudgetUsageError if unresolved. |  -  |
| **403** | Forbidden. The request failed because user does not have access to a specified resource. |  -  |
| **207** | Multi-status. An object containing a list of budget usage response objects reflecting the same order as the input. |  -  |
| **429** | Too Many Requests. The request was rate-limited. Retry later. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

