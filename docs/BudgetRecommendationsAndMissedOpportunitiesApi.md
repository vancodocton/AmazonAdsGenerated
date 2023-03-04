# Amazon.Advertising.SponsoredProducts.Api.BudgetRecommendationsAndMissedOpportunitiesApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetBudgetRecommendations**](BudgetRecommendationsAndMissedOpportunitiesApi.md#getbudgetrecommendations) | **POST** /sp/campaigns/budgetRecommendations | Get recommended daily budget and estimated missed opportunities for campaigns. |

<a name="getbudgetrecommendations"></a>
# **GetBudgetRecommendations**
> BudgetRecommendationResponse GetBudgetRecommendations (string amazonAdvertisingAPIClientId, string amazonAdvertisingAPIScope, BudgetRecommendationRequest budgetRecommendationRequest)

Get recommended daily budget and estimated missed opportunities for campaigns.

Given a list of campaigns as input, this API provides the following metrics -  <br> <b>1. Recommended daily budget - </b> Estimated budget needed to keep the campaign in budget for the full 24-hour period. Consider this budget to minimize your campaign's chances of running out of budget. <br> <b>2. Percent time in budget </b> - The share of time the campaign was in budget during the past 7 days. <br> <b>3. Estimated missed impressions, clicks and sales </b> - for all campaigns. These are the estimated additional impressions, clicks and sales the campaign might have generated had it adopt the recommended budget. These are estimates based on previous website traffic and campaign's historical performance - and not a guarantee of actual impressions, clicks and sales. Consider using these metrics to further inform your budget allocation decisions. Note: the API only supports NA region currently and when you send the requst, please make sure the campaign belongs to the corresponding marketplace.  **Requires one of these permissions**: [\"advertiser_campaign_edit\",\"advertiser_campaign_view\"]

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Amazon.Advertising.SponsoredProducts.Api;
using Amazon.Advertising.SponsoredProducts.Client;
using Amazon.Advertising.SponsoredProducts.Model;

namespace Example
{
    public class GetBudgetRecommendationsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new BudgetRecommendationsAndMissedOpportunitiesApi(config);
            var amazonAdvertisingAPIClientId = "amazonAdvertisingAPIClientId_example";  // string | The identifier of a client associated with a \"Login with Amazon\" account.
            var amazonAdvertisingAPIScope = "amazonAdvertisingAPIScope_example";  // string | The identifier of a profile associated with the advertiser account. Use `GET` method on Profiles resource to list profiles associated with the access token passed in the HTTP Authorization header.
            var budgetRecommendationRequest = new BudgetRecommendationRequest(); // BudgetRecommendationRequest | 

            try
            {
                // Get recommended daily budget and estimated missed opportunities for campaigns.
                BudgetRecommendationResponse result = apiInstance.GetBudgetRecommendations(amazonAdvertisingAPIClientId, amazonAdvertisingAPIScope, budgetRecommendationRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BudgetRecommendationsAndMissedOpportunitiesApi.GetBudgetRecommendations: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetBudgetRecommendationsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get recommended daily budget and estimated missed opportunities for campaigns.
    ApiResponse<BudgetRecommendationResponse> response = apiInstance.GetBudgetRecommendationsWithHttpInfo(amazonAdvertisingAPIClientId, amazonAdvertisingAPIScope, budgetRecommendationRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BudgetRecommendationsAndMissedOpportunitiesApi.GetBudgetRecommendationsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **amazonAdvertisingAPIClientId** | **string** | The identifier of a client associated with a \&quot;Login with Amazon\&quot; account. |  |
| **amazonAdvertisingAPIScope** | **string** | The identifier of a profile associated with the advertiser account. Use &#x60;GET&#x60; method on Profiles resource to list profiles associated with the access token passed in the HTTP Authorization header. |  |
| **budgetRecommendationRequest** | [**BudgetRecommendationRequest**](BudgetRecommendationRequest.md) |  |  |

### Return type

[**BudgetRecommendationResponse**](BudgetRecommendationResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/vnd.budgetrecommendation.v3+json
 - **Accept**: application/vnd.budgetrecommendation.v3+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful Operation. |  -  |
| **400** | Bad Request. |  -  |
| **422** | Unprocessable Entity - Failed due to invalid parameters. |  -  |
| **401** | Unauthorized - Request failed because user is not authenticated or is not allowed to invoke the operation. |  -  |
| **500** | Internal Server DBCError - something went wrong on the server. Retry later and report a DBCError if unresolved. |  -  |
| **403** | Forbidden - access to the requested resource is forbidden |  -  |
| **415** | Unsupported Media Type - the payload is in a format not supported by this method. |  -  |
| **429** | Too Many Requests - request was rate-limited. Retry later. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

