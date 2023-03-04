# Amazon.Advertising.SponsoredProducts.Api.ProductRecommendationServiceApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetProductRecommendations**](ProductRecommendationServiceApi.md#getproductrecommendations) | **POST** /sp/targets/products/recommendations | Suggested target ASINs for your advertised product |

<a name="getproductrecommendations"></a>
# **GetProductRecommendations**
> ProductRecommendationsByTheme GetProductRecommendations (string amazonAdvertisingAPIClientId, string amazonAdvertisingAPIScope, string? amazonAdvertisingAPIAdvertiserId = null, GetProductRecommendationsRequest? getProductRecommendationsRequest = null)

Suggested target ASINs for your advertised product

Given an advertised ASIN as input, this API returns suggested ASINs to target in a product targeting campaign. We use various methods to generate these suggestions. These include using historical performance of your ad, items that shoppers they frequently view and purchase together, etc. The suggested targets can be retrieved either as a single list, or grouped by ‘theme' – i.e. an accompanying context for why we recommend the items. You can pick the desired format using the Accepts header, please see the response mediaTypes for more information. </br> <h4>Pagination Behavior</h4> The API supports cursor based pagination using encoded cursor values to return next set of records or previously served records. The <b>count</b> parameter in the request body will be used to determine the size of results when requesting the previous page or next page. If no value for <b>count</b> is passed in the request, a default value is assumed. Please refer the range and defaults for these values in the request schema under GetProductRecommendationsRequest. </br> <i><b>Note:</b> The clients should never cache pagination cursor values locally as these values will expire after a certain time period. However a cursor value can be reused to perform retries in case of failures as long as the value has not expired. </br></br> <h4>Themes </h4> Themes provide additional context for why we are recommending a product as a target. See below for an overall list of themes currently available –  </br><b>- Top converting targets</b> – These ASINs generated conversions for the input ASIN in the past 30 days (e.g. your product appeared as an ad on the detail page of these items, and a shopper clicked and purchased your item). The suggested ASINs under this theme are sorted in decreasing order of sales generated for your promoted item. </br><b>- Similar items (frequently viewed together)</b> – Items that shoppers frequently view and click along with your advertised item during a shopping session. </br><b>- Complements</b> – Items that are frequently purchased together as complements. For example, if you are promoting a tennis racquet, you may see tennis balls recommended under this theme. </br><b>- Similar items with low ratings and reviews</b> – Subset of the ‘similar items’ theme containing items that are rated lower than 3 stars and/or with fewer than 5 reviews. </br><b>- Other books read by your readers</b> – Items that shoppers frequently view and click along with your advertised item during a shopping session. </br></br><i><b>Note:</b> Availability of themes differs by input ASIN - some ASINs may not have all above themes available</i> 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Amazon.Advertising.SponsoredProducts.Api;
using Amazon.Advertising.SponsoredProducts.Client;
using Amazon.Advertising.SponsoredProducts.Model;

namespace Example
{
    public class GetProductRecommendationsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new ProductRecommendationServiceApi(config);
            var amazonAdvertisingAPIClientId = "amazonAdvertisingAPIClientId_example";  // string | The identifier of a client associated with a \"Login with Amazon\" account. This is a required header for advertisers and integrators using the Advertising API.
            var amazonAdvertisingAPIScope = "amazonAdvertisingAPIScope_example";  // string | The identifier of a profile associated with the advertiser account. Use `GET` method on Profiles resource to list profiles associated with the access token passed in the HTTP Authorization header. This is a required header for advertisers and integrators using the Advertising API.
            var amazonAdvertisingAPIAdvertiserId = "amazonAdvertisingAPIAdvertiserId_example";  // string? | The Advertiser ID associated with the advertiser account. (optional) 
            var getProductRecommendationsRequest = new GetProductRecommendationsRequest?(); // GetProductRecommendationsRequest? |  (optional) 

            try
            {
                // Suggested target ASINs for your advertised product
                ProductRecommendationsByTheme result = apiInstance.GetProductRecommendations(amazonAdvertisingAPIClientId, amazonAdvertisingAPIScope, amazonAdvertisingAPIAdvertiserId, getProductRecommendationsRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductRecommendationServiceApi.GetProductRecommendations: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetProductRecommendationsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Suggested target ASINs for your advertised product
    ApiResponse<ProductRecommendationsByTheme> response = apiInstance.GetProductRecommendationsWithHttpInfo(amazonAdvertisingAPIClientId, amazonAdvertisingAPIScope, amazonAdvertisingAPIAdvertiserId, getProductRecommendationsRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductRecommendationServiceApi.GetProductRecommendationsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **amazonAdvertisingAPIClientId** | **string** | The identifier of a client associated with a \&quot;Login with Amazon\&quot; account. This is a required header for advertisers and integrators using the Advertising API. |  |
| **amazonAdvertisingAPIScope** | **string** | The identifier of a profile associated with the advertiser account. Use &#x60;GET&#x60; method on Profiles resource to list profiles associated with the access token passed in the HTTP Authorization header. This is a required header for advertisers and integrators using the Advertising API. |  |
| **amazonAdvertisingAPIAdvertiserId** | **string?** | The Advertiser ID associated with the advertiser account. | [optional]  |
| **getProductRecommendationsRequest** | [**GetProductRecommendationsRequest?**](GetProductRecommendationsRequest?.md) |  | [optional]  |

### Return type

[**ProductRecommendationsByTheme**](ProductRecommendationsByTheme.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/vnd.spproductrecommendation.v3+json
 - **Accept**: application/vnd.spproductrecommendationresponse.themes.v3+json, application/vnd.spproductrecommendationresponse.asins.v3+json, application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | success |  -  |
| **400** | Bad Request |  -  |
| **422** | Unprocessable entity - Failed due to invalid parameters. |  -  |
| **500** | Internal Server Error - Something went wrong on the server. Retry later and report an error if unresolved. |  -  |
| **429** | Too Many Requests - Request was rate-limited. Retry later. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

