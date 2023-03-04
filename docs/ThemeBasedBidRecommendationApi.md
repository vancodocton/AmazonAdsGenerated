# Amazon.Advertising.SponsoredProducts.Api.ThemeBasedBidRecommendationApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetThemeBasedBidRecommendationForAdGroupV1**](ThemeBasedBidRecommendationApi.md#getthemebasedbidrecommendationforadgroupv1) | **POST** /sp/targets/bid/recommendations | This API is currently available in US, UK, DE, CA, JP, IN, ES, and FR. The API supports keyword and auto targets only. The API will return a 422 response when an unsupported marketplace or target is provided. For product targets in all marketplaces, and keyword or auto targets in other marketplaces, call /v2/sp/targets/bidRecommendations. |

<a name="getthemebasedbidrecommendationforadgroupv1"></a>
# **GetThemeBasedBidRecommendationForAdGroupV1**
> ThemeBasedBidRecommendationResponse GetThemeBasedBidRecommendationForAdGroupV1 (string amazonAdvertisingAPIClientId, string amazonAdvertisingAPIScope, GetThemeBasedBidRecommendationForAdGroupV1Request? getThemeBasedBidRecommendationForAdGroupV1Request = null)

This API is currently available in US, UK, DE, CA, JP, IN, ES, and FR. The API supports keyword and auto targets only. The API will return a 422 response when an unsupported marketplace or target is provided. For product targets in all marketplaces, and keyword or auto targets in other marketplaces, call /v2/sp/targets/bidRecommendations.

Gets theme-based bid recommendations for new or existing ad groups.  **Requires one of these permissions**: [\"advertiser_campaign_edit\",\"advertiser_campaign_view\"]

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Amazon.Advertising.SponsoredProducts.Api;
using Amazon.Advertising.SponsoredProducts.Client;
using Amazon.Advertising.SponsoredProducts.Model;

namespace Example
{
    public class GetThemeBasedBidRecommendationForAdGroupV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new ThemeBasedBidRecommendationApi(config);
            var amazonAdvertisingAPIClientId = "amazonAdvertisingAPIClientId_example";  // string | The identifier of a client associated with a \"Login with Amazon\" account.
            var amazonAdvertisingAPIScope = "amazonAdvertisingAPIScope_example";  // string | The identifier of a profile associated with the advertiser account. Use `GET` method on Profiles resource to list profiles associated with the access token passed in the HTTP Authorization header.
            var getThemeBasedBidRecommendationForAdGroupV1Request = new GetThemeBasedBidRecommendationForAdGroupV1Request?(); // GetThemeBasedBidRecommendationForAdGroupV1Request? |  (optional) 

            try
            {
                // This API is currently available in US, UK, DE, CA, JP, IN, ES, and FR. The API supports keyword and auto targets only. The API will return a 422 response when an unsupported marketplace or target is provided. For product targets in all marketplaces, and keyword or auto targets in other marketplaces, call /v2/sp/targets/bidRecommendations.
                ThemeBasedBidRecommendationResponse result = apiInstance.GetThemeBasedBidRecommendationForAdGroupV1(amazonAdvertisingAPIClientId, amazonAdvertisingAPIScope, getThemeBasedBidRecommendationForAdGroupV1Request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ThemeBasedBidRecommendationApi.GetThemeBasedBidRecommendationForAdGroupV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetThemeBasedBidRecommendationForAdGroupV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // This API is currently available in US, UK, DE, CA, JP, IN, ES, and FR. The API supports keyword and auto targets only. The API will return a 422 response when an unsupported marketplace or target is provided. For product targets in all marketplaces, and keyword or auto targets in other marketplaces, call /v2/sp/targets/bidRecommendations.
    ApiResponse<ThemeBasedBidRecommendationResponse> response = apiInstance.GetThemeBasedBidRecommendationForAdGroupV1WithHttpInfo(amazonAdvertisingAPIClientId, amazonAdvertisingAPIScope, getThemeBasedBidRecommendationForAdGroupV1Request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ThemeBasedBidRecommendationApi.GetThemeBasedBidRecommendationForAdGroupV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **amazonAdvertisingAPIClientId** | **string** | The identifier of a client associated with a \&quot;Login with Amazon\&quot; account. |  |
| **amazonAdvertisingAPIScope** | **string** | The identifier of a profile associated with the advertiser account. Use &#x60;GET&#x60; method on Profiles resource to list profiles associated with the access token passed in the HTTP Authorization header. |  |
| **getThemeBasedBidRecommendationForAdGroupV1Request** | [**GetThemeBasedBidRecommendationForAdGroupV1Request?**](GetThemeBasedBidRecommendationForAdGroupV1Request?.md) |  | [optional]  |

### Return type

[**ThemeBasedBidRecommendationResponse**](ThemeBasedBidRecommendationResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/vnd.spthemebasedbidrecommendation.v3+json
 - **Accept**: application/vnd.spthemebasedbidrecommendation.v3+json, application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful Operation. |  -  |
| **400** | Bad Request. |  -  |
| **422** | Unprocessable entity. Failed due to invalid parameters. If you receive an error like “Invalid Advertiser and ASINs combination in the request”, please make sure the ad group has at least one ASIN in it. |  -  |
| **401** | Unauthorized. Request failed because user is not authenticated or is not allowed to invoke the operation. |  -  |
| **500** | Internal Server Error. Something went wrong on the server. |  -  |
| **429** | Too Many Requests. Request was rate-limited. Retry later. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

