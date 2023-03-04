# Amazon.Advertising.SponsoredProducts.Api.BudgetRecommendationNewCampaignsApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetBudgetRecommendation**](BudgetRecommendationNewCampaignsApi.md#getbudgetrecommendation) | **POST** /sp/campaigns/initialBudgetRecommendation |  |

<a name="getbudgetrecommendation"></a>
# **GetBudgetRecommendation**
> InitialBudgetRecommendationResponse GetBudgetRecommendation (string amazonAdvertisingAPIClientId, string amazonAdvertisingAPIScope, InitialBudgetRecommendationRequest? initialBudgetRecommendationRequest = null)



Creates daily budget recommendation along with benchmark metrics when creating a new campaign.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Amazon.Advertising.SponsoredProducts.Api;
using Amazon.Advertising.SponsoredProducts.Client;
using Amazon.Advertising.SponsoredProducts.Model;

namespace Example
{
    public class GetBudgetRecommendationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new BudgetRecommendationNewCampaignsApi(config);
            var amazonAdvertisingAPIClientId = "amazonAdvertisingAPIClientId_example";  // string | The identifier of a client associated with a \"Login with Amazon\" account.
            var amazonAdvertisingAPIScope = "amazonAdvertisingAPIScope_example";  // string | The identifier of a profile associated with the advertiser account. Use `GET` method on Profiles resource to list profiles associated with the access token passed in the HTTP Authorization header and choose profile id `profileId` from the response to pass it as input.
            var initialBudgetRecommendationRequest = new InitialBudgetRecommendationRequest?(); // InitialBudgetRecommendationRequest? |  (optional) 

            try
            {
                InitialBudgetRecommendationResponse result = apiInstance.GetBudgetRecommendation(amazonAdvertisingAPIClientId, amazonAdvertisingAPIScope, initialBudgetRecommendationRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BudgetRecommendationNewCampaignsApi.GetBudgetRecommendation: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetBudgetRecommendationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<InitialBudgetRecommendationResponse> response = apiInstance.GetBudgetRecommendationWithHttpInfo(amazonAdvertisingAPIClientId, amazonAdvertisingAPIScope, initialBudgetRecommendationRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BudgetRecommendationNewCampaignsApi.GetBudgetRecommendationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **amazonAdvertisingAPIClientId** | **string** | The identifier of a client associated with a \&quot;Login with Amazon\&quot; account. |  |
| **amazonAdvertisingAPIScope** | **string** | The identifier of a profile associated with the advertiser account. Use &#x60;GET&#x60; method on Profiles resource to list profiles associated with the access token passed in the HTTP Authorization header and choose profile id &#x60;profileId&#x60; from the response to pass it as input. |  |
| **initialBudgetRecommendationRequest** | [**InitialBudgetRecommendationRequest?**](InitialBudgetRecommendationRequest?.md) |  | [optional]  |

### Return type

[**InitialBudgetRecommendationResponse**](InitialBudgetRecommendationResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/vnd.spinitialbudgetrecommendation.v3.4+json
 - **Accept**: application/vnd.spinitialbudgetrecommendation.v3.4+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | 200 response. |  -  |
| **400** | 400 response. |  -  |
| **401** | 401 response. |  -  |
| **500** | 500 response. |  -  |
| **403** | 403 response. |  -  |
| **415** | 415 response. |  -  |
| **429** | 429 response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

