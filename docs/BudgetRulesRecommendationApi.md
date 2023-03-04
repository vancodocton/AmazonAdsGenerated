# Amazon.Advertising.SponsoredProducts.Api.BudgetRulesRecommendationApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**SPGetBudgetRulesRecommendation**](BudgetRulesRecommendationApi.md#spgetbudgetrulesrecommendation) | **POST** /sp/campaigns/budgetRules/recommendations | Gets a list of special events with suggested date range and suggested budget increase for a campaign specified by identifier. |

<a name="spgetbudgetrulesrecommendation"></a>
# **SPGetBudgetRulesRecommendation**
> SPBudgetRulesRecommendationEventResponse SPGetBudgetRulesRecommendation (string amazonAdvertisingAPIClientId, string amazonAdvertisingAPIScope, SPGetBudgetRulesRecommendationRequest? sPGetBudgetRulesRecommendationRequest = null)

Gets a list of special events with suggested date range and suggested budget increase for a campaign specified by identifier.

A rule enables an automatic budget increase for a specified date range or for a special event. The response also includes a suggested budget increase for each special event.  **Requires one of these permissions**: [\"advertiser_campaign_edit\",\"advertiser_campaign_view\"]

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Amazon.Advertising.SponsoredProducts.Api;
using Amazon.Advertising.SponsoredProducts.Client;
using Amazon.Advertising.SponsoredProducts.Model;

namespace Example
{
    public class SPGetBudgetRulesRecommendationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new BudgetRulesRecommendationApi(config);
            var amazonAdvertisingAPIClientId = "amazonAdvertisingAPIClientId_example";  // string | The identifier of a client associated with a \"Login with Amazon\" account.
            var amazonAdvertisingAPIScope = "amazonAdvertisingAPIScope_example";  // string | The identifier of a profile associated with the advertiser account. Use `GET` method on Profiles resource to list profiles associated with the access token passed in the HTTP Authorization header.
            var sPGetBudgetRulesRecommendationRequest = new SPGetBudgetRulesRecommendationRequest?(); // SPGetBudgetRulesRecommendationRequest? |  (optional) 

            try
            {
                // Gets a list of special events with suggested date range and suggested budget increase for a campaign specified by identifier.
                SPBudgetRulesRecommendationEventResponse result = apiInstance.SPGetBudgetRulesRecommendation(amazonAdvertisingAPIClientId, amazonAdvertisingAPIScope, sPGetBudgetRulesRecommendationRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BudgetRulesRecommendationApi.SPGetBudgetRulesRecommendation: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SPGetBudgetRulesRecommendationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets a list of special events with suggested date range and suggested budget increase for a campaign specified by identifier.
    ApiResponse<SPBudgetRulesRecommendationEventResponse> response = apiInstance.SPGetBudgetRulesRecommendationWithHttpInfo(amazonAdvertisingAPIClientId, amazonAdvertisingAPIScope, sPGetBudgetRulesRecommendationRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BudgetRulesRecommendationApi.SPGetBudgetRulesRecommendationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **amazonAdvertisingAPIClientId** | **string** | The identifier of a client associated with a \&quot;Login with Amazon\&quot; account. |  |
| **amazonAdvertisingAPIScope** | **string** | The identifier of a profile associated with the advertiser account. Use &#x60;GET&#x60; method on Profiles resource to list profiles associated with the access token passed in the HTTP Authorization header. |  |
| **sPGetBudgetRulesRecommendationRequest** | [**SPGetBudgetRulesRecommendationRequest?**](SPGetBudgetRulesRecommendationRequest?.md) |  | [optional]  |

### Return type

[**SPBudgetRulesRecommendationEventResponse**](SPBudgetRulesRecommendationEventResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/vnd.spbudgetrulesrecommendation.v3+json
 - **Accept**: application/vnd.spbudgetrulesrecommendation.v3+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful Operation. |  -  |
| **400** | Bad Request. |  -  |
| **500** | Internal Server Error. Something went wrong on the server. |  -  |
| **429** | Too Many Requests. Request was rate-limited. Retry later. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

