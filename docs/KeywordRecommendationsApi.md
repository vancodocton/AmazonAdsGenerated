# Amazon.Advertising.SponsoredProducts.Api.KeywordRecommendationsApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetRankedKeywordRecommendation**](KeywordRecommendationsApi.md#getrankedkeywordrecommendation) | **POST** /sp/targets/keywords/recommendations | Get keyword recommendations |

<a name="getrankedkeywordrecommendation"></a>
# **GetRankedKeywordRecommendation**
> List&lt;KeywordTargetResponse&gt; GetRankedKeywordRecommendation (string amazonAdvertisingAPIClientId, string amazonAdvertisingAPIScope, string? amazonAdvertisingAPIMarketplaceId = null, string? amazonAdvertisingAPIAdvertiserId = null, GetRankedKeywordRecommendationRequest? getRankedKeywordRecommendationRequest = null)

Get keyword recommendations

The <b> POST /sp/targets/keywords/recommendations </b> endpoint returns recommended keyword targets given either A) a list of ad ASINs or B) a campaign ID and ad group ID. Please use the recommendationType field to specify if you want to use option A or option B. This endpoint will also return recommended bids along with each recommendation keyword target.<br><br> <b> Ranking </b> <br> The keyword recommendations will be ranked in descending order of clicks or impressions, depending on the <b>sortDimension</b> field provided by the user. You may also input your own keyword targets to be ranked alongside the keyword recommendations by using the <b>targets</b> array. <br><br> <b> Localization </b> <br> Use the <b> locale </b> field to get keywords in your specified locale. Supported marketplace to locale mappings can be found at the <a href='https://advertising.amazon.com/API/docs/en-us/localization/#/Keyword%20Localization'>POST /keywords/localize</a> endpoint. <h1> Version 5.0 </h1>  <h2> New Features </h2> Version 5.0 utilizes the new theme-based bid recommendations, which can be retrieved at the endpoint <b>/sp/targets/bid/recommendations</b>, to return improved bid recommendations for each keyword. Theme-based bid recommendations provide \\\\\\\"themes\\\\\\\" and \\\\\\\"impact metrics\\\\\\\" along with each bid suggestion to help you choose the right bid for your keyword target.<br><br><b>Themes</b><br> We now may return multiple bid suggestions for each keyword target. Each suggestion will have a theme to express the business objective of the bid. Available themes are: <ul> <li> CONVERSION_OPPORTUNITIES - The default theme which aims to maximize number of conversions. </li> <li> SPECIAL_DAYS - A theme available during high sales events such as Prime Day, to anticipate an increase in sales and competition.</li></ul><b>Impact Metrics</b><br>We have added impact metrics which provide insight on the number of clicks and conversions you will receive for targeting a keyword at a certain bid. <br><br><b>Bidding Strategy</b><br> You may now specify your bidding strategy in the KEYWORDS_BY_ASINS request to get bid suggestions tailored to your bidding strategy. For KEYWORDS_BY_ADGROUP requests, you will not specify a bidding strategy, because the bidding strategy of the ad group is used. The three bidding strategies are: <ul> <li> LEGACY_FOR_SALES - Dynamic bids (down only) </li> <li> AUTO_FOR_SALES - Dynamic bids (up and down) </li> <li> MANUAL - Fixed bids </li> </ul> <h3> Availability </h3> Version 5.0 is only available in the following marketplaces: US, CA, UK, DE, FR, ES, IN, JP. <h1> Version 4.0 </h1> <h2> New features </h2> Version 4.0 allows users to retrieve recommended keyword targets which are sorted in descending order of clicks or conversions. The default sort dimension, if not specified, ranks recommendations by our interal ranking mechanism. We have also have added search term metrics. <b> Search term impression share </b> indicates the percentage share of all ad-attributed impressions you received on that keyword in the last 30 days. This metric helps advertisers identify potential opportunities based on their share on relevant keywords. <b> Search term impression rank </b> indicates your ranking among all advertisers for the keyword by ad impressions in a marketplace. It tells an advertiser how many advertisers had higher share of ad impressions. <i> Search term information is only available for keywords the advertiser targeted with ad impressions. </i> <h3> Availability </h3> Version 4.0 is available in all marketplaces.  **Requires one of these permissions**: [\"advertiser_campaign_edit\",\"advertiser_campaign_view\"]

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Amazon.Advertising.SponsoredProducts.Api;
using Amazon.Advertising.SponsoredProducts.Client;
using Amazon.Advertising.SponsoredProducts.Model;

namespace Example
{
    public class GetRankedKeywordRecommendationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new KeywordRecommendationsApi(config);
            var amazonAdvertisingAPIClientId = "amazonAdvertisingAPIClientId_example";  // string | The identifier of a client associated with a \"Login with Amazon\" account. This is a required header for advertisers and integrators using the Advertising API.
            var amazonAdvertisingAPIScope = "amazonAdvertisingAPIScope_example";  // string | The identifier of a profile associated with the advertiser account. Use `GET` method on Profiles resource to list profiles associated with the access token passed in the HTTP Authorization header. This is a required header for advertisers and integrators using the Advertising API.
            var amazonAdvertisingAPIMarketplaceId = "amazonAdvertisingAPIMarketplaceId_example";  // string? | The advertiser's Marketplace ID associated with the advertiser account. (optional) 
            var amazonAdvertisingAPIAdvertiserId = "amazonAdvertisingAPIAdvertiserId_example";  // string? | The advertiser's ID associated with the advertiser account. (optional) 
            var getRankedKeywordRecommendationRequest = new GetRankedKeywordRecommendationRequest?(); // GetRankedKeywordRecommendationRequest? |  (optional) 

            try
            {
                // Get keyword recommendations
                List<KeywordTargetResponse> result = apiInstance.GetRankedKeywordRecommendation(amazonAdvertisingAPIClientId, amazonAdvertisingAPIScope, amazonAdvertisingAPIMarketplaceId, amazonAdvertisingAPIAdvertiserId, getRankedKeywordRecommendationRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling KeywordRecommendationsApi.GetRankedKeywordRecommendation: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetRankedKeywordRecommendationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get keyword recommendations
    ApiResponse<List<KeywordTargetResponse>> response = apiInstance.GetRankedKeywordRecommendationWithHttpInfo(amazonAdvertisingAPIClientId, amazonAdvertisingAPIScope, amazonAdvertisingAPIMarketplaceId, amazonAdvertisingAPIAdvertiserId, getRankedKeywordRecommendationRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling KeywordRecommendationsApi.GetRankedKeywordRecommendationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **amazonAdvertisingAPIClientId** | **string** | The identifier of a client associated with a \&quot;Login with Amazon\&quot; account. This is a required header for advertisers and integrators using the Advertising API. |  |
| **amazonAdvertisingAPIScope** | **string** | The identifier of a profile associated with the advertiser account. Use &#x60;GET&#x60; method on Profiles resource to list profiles associated with the access token passed in the HTTP Authorization header. This is a required header for advertisers and integrators using the Advertising API. |  |
| **amazonAdvertisingAPIMarketplaceId** | **string?** | The advertiser&#39;s Marketplace ID associated with the advertiser account. | [optional]  |
| **amazonAdvertisingAPIAdvertiserId** | **string?** | The advertiser&#39;s ID associated with the advertiser account. | [optional]  |
| **getRankedKeywordRecommendationRequest** | [**GetRankedKeywordRecommendationRequest?**](GetRankedKeywordRecommendationRequest?.md) |  | [optional]  |

### Return type

[**List&lt;KeywordTargetResponse&gt;**](KeywordTargetResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/vnd.spkeywordsrecommendation.v3+json, application/vnd.spkeywordsrecommendation.v5+json, application/vnd.spkeywordsrecommendation.v4+json
 - **Accept**: application/vnd.spkeywordsrecommendation.v3+json, application/vnd.spkeywordsrecommendation.v5+json, application/vnd.spkeywordsrecommendation.v4+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | success |  -  |
| **400** | Bad Request |  -  |
| **422** | Unprocessable entity - Failed due to invalid parameters. |  -  |
| **401** | Unauthorized - Request failed because user is not authenticated or is not allowed to invoke the operation. |  -  |
| **500** | Internal Server Error - Something went wrong on the server. Retry later and report an error if unresolved. |  -  |
| **429** | Too Many Requests - Request was rate-limited. Retry later. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

