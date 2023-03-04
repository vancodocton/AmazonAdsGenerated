# Amazon.Advertising.SponsoredProducts.Api.ConsolidatedRecommendationsApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetCampaignRecommendations**](ConsolidatedRecommendationsApi.md#getcampaignrecommendations) | **GET** /sp/campaign/recommendations |  |

<a name="getcampaignrecommendations"></a>
# **GetCampaignRecommendations**
> GetCampaignRecommendationsResponse GetCampaignRecommendations (string amazonAdvertisingAPIClientId, string amazonAdvertisingAPIScope, string? nextToken = null, string? maxResults = null)



Gets the top consolidated recommendations across bid, budget, targeting for SP campaigns given an advertiser profile id. The recommendations are refreshed everyday.  **Requires one of these permissions**: [\"advertiser_campaign_view\",\"advertiser_campaign_edit\"]

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Amazon.Advertising.SponsoredProducts.Api;
using Amazon.Advertising.SponsoredProducts.Client;
using Amazon.Advertising.SponsoredProducts.Model;

namespace Example
{
    public class GetCampaignRecommendationsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new ConsolidatedRecommendationsApi(config);
            var amazonAdvertisingAPIClientId = "amazonAdvertisingAPIClientId_example";  // string | The identifier of a client associated with a \"Login with Amazon\" account.
            var amazonAdvertisingAPIScope = "amazonAdvertisingAPIScope_example";  // string | The identifier of a profile associated with the advertiser account. Use `GET` method on Profiles resource to list profiles associated with the access token passed in the HTTP Authorization header and choose profile id `profileId` from the response to pass it as input.
            var nextToken = "nextToken_example";  // string? | Optional. Token to retrieve subsequent page of results. (optional) 
            var maxResults = "maxResults_example";  // string? | Optional. Limits the number of items to return in the response. (optional) 

            try
            {
                GetCampaignRecommendationsResponse result = apiInstance.GetCampaignRecommendations(amazonAdvertisingAPIClientId, amazonAdvertisingAPIScope, nextToken, maxResults);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConsolidatedRecommendationsApi.GetCampaignRecommendations: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCampaignRecommendationsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<GetCampaignRecommendationsResponse> response = apiInstance.GetCampaignRecommendationsWithHttpInfo(amazonAdvertisingAPIClientId, amazonAdvertisingAPIScope, nextToken, maxResults);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConsolidatedRecommendationsApi.GetCampaignRecommendationsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **amazonAdvertisingAPIClientId** | **string** | The identifier of a client associated with a \&quot;Login with Amazon\&quot; account. |  |
| **amazonAdvertisingAPIScope** | **string** | The identifier of a profile associated with the advertiser account. Use &#x60;GET&#x60; method on Profiles resource to list profiles associated with the access token passed in the HTTP Authorization header and choose profile id &#x60;profileId&#x60; from the response to pass it as input. |  |
| **nextToken** | **string?** | Optional. Token to retrieve subsequent page of results. | [optional]  |
| **maxResults** | **string?** | Optional. Limits the number of items to return in the response. | [optional]  |

### Return type

[**GetCampaignRecommendationsResponse**](GetCampaignRecommendationsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.spgetcampaignrecommendationsresponse.v1+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success. |  -  |
| **400** | Invalid Request - The input fails to satisfy the constraints of the API. |  -  |
| **422** | Unprocessable entity - Failed due to invalid parameters. |  -  |
| **401** | Unauthorized - Request failed because user is not authenticated. |  -  |
| **500** | Internal Server Error - Something went wrong on the server. Retry later and report an error if unresolved. |  -  |
| **403** | Access Denied - Request failed because the user is not allowed to invoke the operation. |  -  |
| **429** | Too Many Requests - Request was rate-limited. Retry later. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

