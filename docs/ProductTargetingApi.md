# Amazon.Advertising.SponsoredProducts.Api.ProductTargetingApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetCategoryRecommendationsForASINs**](ProductTargetingApi.md#getcategoryrecommendationsforasins) | **POST** /sp/targets/categories/recommendations | Returns a list of category recommendations for the input list of ASINs. |
| [**GetNegativeBrands**](ProductTargetingApi.md#getnegativebrands) | **GET** /sp/negativeTargets/brands/recommendations | Returns brands recommended for negative targeting. |
| [**GetRefinementsForCategory**](ProductTargetingApi.md#getrefinementsforcategory) | **GET** /sp/targets/category/{categoryId}/refinements | Returns refinements according to category input. |
| [**GetTargetableASINCounts**](ProductTargetingApi.md#gettargetableasincounts) | **POST** /sp/targets/products/count | Get number of targetable asins based on refinements provided by the user. |
| [**GetTargetableCategories**](ProductTargetingApi.md#gettargetablecategories) | **GET** /sp/targets/categories | Returns all targetable categories. |
| [**SearchBrands**](ProductTargetingApi.md#searchbrands) | **POST** /sp/negativeTargets/brands/search | Returns brands related to keyword input for negative targeting. |

<a name="getcategoryrecommendationsforasins"></a>
# **GetCategoryRecommendationsForASINs**
> CategoryRecommendations GetCategoryRecommendationsForASINs (string amazonAdvertisingAPIClientId, string amazonAdvertisingAPIScope, string? prefer = null, GetCategoryRecommendationsForAsinsRequest? getCategoryRecommendationsForAsinsRequest = null)

Returns a list of category recommendations for the input list of ASINs.

Returns a list of category recommendations for the input list of ASINs. Use this API to discover relevant categories to target. To find ASINs, either use the Product Metadata API or browse the Amazon Retail Website. <br> <ul><li>Response can be requested in different versions with the help of accept header. Please review the response mediaTypes for more information.</li><ul>  **Requires one of these permissions**: [\"advertiser_campaign_edit\",\"advertiser_campaign_view\"]

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Amazon.Advertising.SponsoredProducts.Api;
using Amazon.Advertising.SponsoredProducts.Client;
using Amazon.Advertising.SponsoredProducts.Model;

namespace Example
{
    public class GetCategoryRecommendationsForASINsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new ProductTargetingApi(config);
            var amazonAdvertisingAPIClientId = "amazonAdvertisingAPIClientId_example";  // string | The identifier of a client associated with a \"Login with Amazon\" account. This is a required header for advertisers and integrators using the Advertising API.
            var amazonAdvertisingAPIScope = "amazonAdvertisingAPIScope_example";  // string | The identifier of a profile associated with the advertiser account. Use `GET` method on Profiles resource to list profiles associated with the access token passed in the HTTP Authorization header. This is a required header for advertisers and integrators using the Advertising API.
            var prefer = "prefer_example";  // string? | Used to indicate the behavior preferred by the client but is not required for successful completion of the request. Supported values will be updated in the future. (optional) 
            var getCategoryRecommendationsForAsinsRequest = new GetCategoryRecommendationsForAsinsRequest?(); // GetCategoryRecommendationsForAsinsRequest? |  (optional) 

            try
            {
                // Returns a list of category recommendations for the input list of ASINs.
                CategoryRecommendations result = apiInstance.GetCategoryRecommendationsForASINs(amazonAdvertisingAPIClientId, amazonAdvertisingAPIScope, prefer, getCategoryRecommendationsForAsinsRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductTargetingApi.GetCategoryRecommendationsForASINs: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCategoryRecommendationsForASINsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Returns a list of category recommendations for the input list of ASINs.
    ApiResponse<CategoryRecommendations> response = apiInstance.GetCategoryRecommendationsForASINsWithHttpInfo(amazonAdvertisingAPIClientId, amazonAdvertisingAPIScope, prefer, getCategoryRecommendationsForAsinsRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductTargetingApi.GetCategoryRecommendationsForASINsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **amazonAdvertisingAPIClientId** | **string** | The identifier of a client associated with a \&quot;Login with Amazon\&quot; account. This is a required header for advertisers and integrators using the Advertising API. |  |
| **amazonAdvertisingAPIScope** | **string** | The identifier of a profile associated with the advertiser account. Use &#x60;GET&#x60; method on Profiles resource to list profiles associated with the access token passed in the HTTP Authorization header. This is a required header for advertisers and integrators using the Advertising API. |  |
| **prefer** | **string?** | Used to indicate the behavior preferred by the client but is not required for successful completion of the request. Supported values will be updated in the future. | [optional]  |
| **getCategoryRecommendationsForAsinsRequest** | [**GetCategoryRecommendationsForAsinsRequest?**](GetCategoryRecommendationsForAsinsRequest?.md) |  | [optional]  |

### Return type

[**CategoryRecommendations**](CategoryRecommendations.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/vnd.spproducttargeting.v3+json
 - **Accept**: application/vnd.spproducttargetingresponse.v3+json, application/vnd.spproducttargetingresponse.v4+json, application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | success |  -  |
| **400** | Bad Request |  -  |
| **422** | Unprocessable entity - Failed due to invalid parameters. |  -  |
| **401** | Unauthorized - Request failed because user is not authenticated. |  -  |
| **500** | Internal Server Error - Something went wrong on the server. Retry later and report an error if unresolved. |  -  |
| **429** | Too Many Requests - Request was rate-limited. Retry later. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getnegativebrands"></a>
# **GetNegativeBrands**
> List&lt;Brand&gt; GetNegativeBrands (string amazonAdvertisingAPIClientId, string amazonAdvertisingAPIScope, string? prefer = null)

Returns brands recommended for negative targeting.

Returns brands recommended for negative targeting. Only available for Sellers and Vendors. These recommendations include your own brands because targeting your own brands usually results in lower performance than targeting competitors' brands.  **Requires one of these permissions**: [\"advertiser_campaign_edit\",\"advertiser_campaign_view\"]

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Amazon.Advertising.SponsoredProducts.Api;
using Amazon.Advertising.SponsoredProducts.Client;
using Amazon.Advertising.SponsoredProducts.Model;

namespace Example
{
    public class GetNegativeBrandsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new ProductTargetingApi(config);
            var amazonAdvertisingAPIClientId = "amazonAdvertisingAPIClientId_example";  // string | The identifier of a client associated with a \"Login with Amazon\" account. This is a required header for advertisers and integrators using the Advertising API.
            var amazonAdvertisingAPIScope = "amazonAdvertisingAPIScope_example";  // string | The identifier of a profile associated with the advertiser account. Use `GET` method on Profiles resource to list profiles associated with the access token passed in the HTTP Authorization header. This is a required header for advertisers and integrators using the Advertising API.
            var prefer = "prefer_example";  // string? | Used to indicate the behavior preferred by the client but is not required for successful completion of the request. Supported values will be updated in the future. (optional) 

            try
            {
                // Returns brands recommended for negative targeting.
                List<Brand> result = apiInstance.GetNegativeBrands(amazonAdvertisingAPIClientId, amazonAdvertisingAPIScope, prefer);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductTargetingApi.GetNegativeBrands: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetNegativeBrandsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Returns brands recommended for negative targeting.
    ApiResponse<List<Brand>> response = apiInstance.GetNegativeBrandsWithHttpInfo(amazonAdvertisingAPIClientId, amazonAdvertisingAPIScope, prefer);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductTargetingApi.GetNegativeBrandsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **amazonAdvertisingAPIClientId** | **string** | The identifier of a client associated with a \&quot;Login with Amazon\&quot; account. This is a required header for advertisers and integrators using the Advertising API. |  |
| **amazonAdvertisingAPIScope** | **string** | The identifier of a profile associated with the advertiser account. Use &#x60;GET&#x60; method on Profiles resource to list profiles associated with the access token passed in the HTTP Authorization header. This is a required header for advertisers and integrators using the Advertising API. |  |
| **prefer** | **string?** | Used to indicate the behavior preferred by the client but is not required for successful completion of the request. Supported values will be updated in the future. | [optional]  |

### Return type

[**List&lt;Brand&gt;**](Brand.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.spproducttargetingresponse.v3+json, application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | success |  -  |
| **400** | Bad Request - The input fails to satisfy the constraints of the API. |  -  |
| **401** | Unauthorized - Request failed because user is not authenticated. |  -  |
| **500** | Internal Server Error - Something went wrong on the server. Retry later and report an error if unresolved. |  -  |
| **403** | Access Denied - Request failed because the user is not allowed to invoke the operation. |  -  |
| **429** | Too Many Requests - Request was rate-limited. Retry later. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getrefinementsforcategory"></a>
# **GetRefinementsForCategory**
> Refinements GetRefinementsForCategory (string amazonAdvertisingAPIClientId, string amazonAdvertisingAPIScope, string categoryId, string? prefer = null)

Returns refinements according to category input.

Returns refinements according to category input.  **Requires one of these permissions**: [\"advertiser_campaign_edit\",\"advertiser_campaign_view\"]

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Amazon.Advertising.SponsoredProducts.Api;
using Amazon.Advertising.SponsoredProducts.Client;
using Amazon.Advertising.SponsoredProducts.Model;

namespace Example
{
    public class GetRefinementsForCategoryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new ProductTargetingApi(config);
            var amazonAdvertisingAPIClientId = "amazonAdvertisingAPIClientId_example";  // string | The identifier of a client associated with a \"Login with Amazon\" account. This is a required header for advertisers and integrators using the Advertising API.
            var amazonAdvertisingAPIScope = "amazonAdvertisingAPIScope_example";  // string | The identifier of a profile associated with the advertiser account. Use `GET` method on Profiles resource to list profiles associated with the access token passed in the HTTP Authorization header. This is a required header for advertisers and integrators using the Advertising API.
            var categoryId = "categoryId_example";  // string | The category ID. Please use the GetTargetableCategories API or the GetCategoriesForASINs API to retrieve categories IDs. This API does not check if the category is a valid category.
            var prefer = "prefer_example";  // string? | Used to indicate the behavior preferred by the client but is not required for successful completion of the request. Supported values will be updated in the future. (optional) 

            try
            {
                // Returns refinements according to category input.
                Refinements result = apiInstance.GetRefinementsForCategory(amazonAdvertisingAPIClientId, amazonAdvertisingAPIScope, categoryId, prefer);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductTargetingApi.GetRefinementsForCategory: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetRefinementsForCategoryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Returns refinements according to category input.
    ApiResponse<Refinements> response = apiInstance.GetRefinementsForCategoryWithHttpInfo(amazonAdvertisingAPIClientId, amazonAdvertisingAPIScope, categoryId, prefer);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductTargetingApi.GetRefinementsForCategoryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **amazonAdvertisingAPIClientId** | **string** | The identifier of a client associated with a \&quot;Login with Amazon\&quot; account. This is a required header for advertisers and integrators using the Advertising API. |  |
| **amazonAdvertisingAPIScope** | **string** | The identifier of a profile associated with the advertiser account. Use &#x60;GET&#x60; method on Profiles resource to list profiles associated with the access token passed in the HTTP Authorization header. This is a required header for advertisers and integrators using the Advertising API. |  |
| **categoryId** | **string** | The category ID. Please use the GetTargetableCategories API or the GetCategoriesForASINs API to retrieve categories IDs. This API does not check if the category is a valid category. |  |
| **prefer** | **string?** | Used to indicate the behavior preferred by the client but is not required for successful completion of the request. Supported values will be updated in the future. | [optional]  |

### Return type

[**Refinements**](Refinements.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.spproducttargetingresponse.v3+json, application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | success |  -  |
| **400** | Bad Request |  -  |
| **422** | Unprocessable entity - Failed due to invalid parameters. |  -  |
| **401** | Unauthorized - Request failed because user is not authenticated. |  -  |
| **500** | Internal Server Error - Something went wrong on the server. Retry later and report an error if unresolved. |  -  |
| **429** | Too Many Requests - Request was rate-limited. Retry later. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettargetableasincounts"></a>
# **GetTargetableASINCounts**
> TargetableAsinCounts GetTargetableASINCounts (string amazonAdvertisingAPIClientId, string amazonAdvertisingAPIScope, string? prefer = null, GetTargetableAsinCountsRequest? getTargetableAsinCountsRequest = null)

Get number of targetable asins based on refinements provided by the user.

Get number of targetable asins based on refinements provided by the user. Please use the GetTargetableCategories API or the GetCategoryRecommendationsForASINs API to retrieve the category ID. Please use the GetRefinementsByCategory API to retrieve refinements data for a category.  **Requires one of these permissions**: [\"advertiser_campaign_edit\",\"advertiser_campaign_view\"]

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Amazon.Advertising.SponsoredProducts.Api;
using Amazon.Advertising.SponsoredProducts.Client;
using Amazon.Advertising.SponsoredProducts.Model;

namespace Example
{
    public class GetTargetableASINCountsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new ProductTargetingApi(config);
            var amazonAdvertisingAPIClientId = "amazonAdvertisingAPIClientId_example";  // string | The identifier of a client associated with a \"Login with Amazon\" account. This is a required header for advertisers and integrators using the Advertising API.
            var amazonAdvertisingAPIScope = "amazonAdvertisingAPIScope_example";  // string | The identifier of a profile associated with the advertiser account. Use `GET` method on Profiles resource to list profiles associated with the access token passed in the HTTP Authorization header. This is a required header for advertisers and integrators using the Advertising API.
            var prefer = "prefer_example";  // string? | Used to indicate the behavior preferred by the client but is not required for successful completion of the request. Supported values will be updated in the future. (optional) 
            var getTargetableAsinCountsRequest = new GetTargetableAsinCountsRequest?(); // GetTargetableAsinCountsRequest? |  (optional) 

            try
            {
                // Get number of targetable asins based on refinements provided by the user.
                TargetableAsinCounts result = apiInstance.GetTargetableASINCounts(amazonAdvertisingAPIClientId, amazonAdvertisingAPIScope, prefer, getTargetableAsinCountsRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductTargetingApi.GetTargetableASINCounts: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetTargetableASINCountsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get number of targetable asins based on refinements provided by the user.
    ApiResponse<TargetableAsinCounts> response = apiInstance.GetTargetableASINCountsWithHttpInfo(amazonAdvertisingAPIClientId, amazonAdvertisingAPIScope, prefer, getTargetableAsinCountsRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductTargetingApi.GetTargetableASINCountsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **amazonAdvertisingAPIClientId** | **string** | The identifier of a client associated with a \&quot;Login with Amazon\&quot; account. This is a required header for advertisers and integrators using the Advertising API. |  |
| **amazonAdvertisingAPIScope** | **string** | The identifier of a profile associated with the advertiser account. Use &#x60;GET&#x60; method on Profiles resource to list profiles associated with the access token passed in the HTTP Authorization header. This is a required header for advertisers and integrators using the Advertising API. |  |
| **prefer** | **string?** | Used to indicate the behavior preferred by the client but is not required for successful completion of the request. Supported values will be updated in the future. | [optional]  |
| **getTargetableAsinCountsRequest** | [**GetTargetableAsinCountsRequest?**](GetTargetableAsinCountsRequest?.md) |  | [optional]  |

### Return type

[**TargetableAsinCounts**](TargetableAsinCounts.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/vnd.spproducttargeting.v3+json
 - **Accept**: application/vnd.spproducttargetingresponse.v3+json, application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | success |  -  |
| **400** | Bad Request - The input fails to satisfy the constraints of the API. |  -  |
| **422** | Unprocessable entity - Failed due to invalid parameters. |  -  |
| **401** | Unauthorized - Request failed because user is not authenticated. |  -  |
| **500** | Internal Server Error - Something went wrong on the server. Retry later and report an error if unresolved. |  -  |
| **429** | Too Many Requests - Request was rate-limited. Retry later. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettargetablecategories"></a>
# **GetTargetableCategories**
> TargetableCategories GetTargetableCategories (string amazonAdvertisingAPIClientId, string amazonAdvertisingAPIScope, string? prefer = null)

Returns all targetable categories.

Returns all targetable categories. This API returns a large JSON string containing a tree of category nodes. Each category node has the fields - category id, category name, and child categories.  **Requires one of these permissions**: [\"advertiser_campaign_edit\",\"advertiser_campaign_view\"]

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Amazon.Advertising.SponsoredProducts.Api;
using Amazon.Advertising.SponsoredProducts.Client;
using Amazon.Advertising.SponsoredProducts.Model;

namespace Example
{
    public class GetTargetableCategoriesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new ProductTargetingApi(config);
            var amazonAdvertisingAPIClientId = "amazonAdvertisingAPIClientId_example";  // string | The identifier of a client associated with a \"Login with Amazon\" account. This is a required header for advertisers and integrators using the Advertising API.
            var amazonAdvertisingAPIScope = "amazonAdvertisingAPIScope_example";  // string | The identifier of a profile associated with the advertiser account. Use `GET` method on Profiles resource to list profiles associated with the access token passed in the HTTP Authorization header. This is a required header for advertisers and integrators using the Advertising API.
            var prefer = "prefer_example";  // string? | Used to indicate the behavior preferred by the client but is not required for successful completion of the request. Supported values will be updated in the future. (optional) 

            try
            {
                // Returns all targetable categories.
                TargetableCategories result = apiInstance.GetTargetableCategories(amazonAdvertisingAPIClientId, amazonAdvertisingAPIScope, prefer);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductTargetingApi.GetTargetableCategories: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetTargetableCategoriesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Returns all targetable categories.
    ApiResponse<TargetableCategories> response = apiInstance.GetTargetableCategoriesWithHttpInfo(amazonAdvertisingAPIClientId, amazonAdvertisingAPIScope, prefer);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductTargetingApi.GetTargetableCategoriesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **amazonAdvertisingAPIClientId** | **string** | The identifier of a client associated with a \&quot;Login with Amazon\&quot; account. This is a required header for advertisers and integrators using the Advertising API. |  |
| **amazonAdvertisingAPIScope** | **string** | The identifier of a profile associated with the advertiser account. Use &#x60;GET&#x60; method on Profiles resource to list profiles associated with the access token passed in the HTTP Authorization header. This is a required header for advertisers and integrators using the Advertising API. |  |
| **prefer** | **string?** | Used to indicate the behavior preferred by the client but is not required for successful completion of the request. Supported values will be updated in the future. | [optional]  |

### Return type

[**TargetableCategories**](TargetableCategories.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.spproducttargetingresponse.v3+json, application/vnd.spproducttargetingresponse.v4+json, application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | success |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized - Request failed because user is not authenticated. |  -  |
| **500** | Internal Server Error - Something went wrong on the server. Retry later and report an error if unresolved. |  -  |
| **429** | Too Many Requests - Request was rate-limited. Retry later. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="searchbrands"></a>
# **SearchBrands**
> List&lt;Brand&gt; SearchBrands (string amazonAdvertisingAPIClientId, string amazonAdvertisingAPIScope, string? prefer = null, SearchBrandsRequest? searchBrandsRequest = null)

Returns brands related to keyword input for negative targeting.

Returns up to 100 brands related to keyword input for negative targeting.  **Requires one of these permissions**: [\"advertiser_campaign_edit\",\"advertiser_campaign_view\"]

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Amazon.Advertising.SponsoredProducts.Api;
using Amazon.Advertising.SponsoredProducts.Client;
using Amazon.Advertising.SponsoredProducts.Model;

namespace Example
{
    public class SearchBrandsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new ProductTargetingApi(config);
            var amazonAdvertisingAPIClientId = "amazonAdvertisingAPIClientId_example";  // string | The identifier of a client associated with a \"Login with Amazon\" account. This is a required header for advertisers and integrators using the Advertising API.
            var amazonAdvertisingAPIScope = "amazonAdvertisingAPIScope_example";  // string | The identifier of a profile associated with the advertiser account. Use `GET` method on Profiles resource to list profiles associated with the access token passed in the HTTP Authorization header. This is a required header for advertisers and integrators using the Advertising API.
            var prefer = "prefer_example";  // string? | Used to indicate the behavior preferred by the client but is not required for successful completion of the request. Supported values will be updated in the future. (optional) 
            var searchBrandsRequest = new SearchBrandsRequest?(); // SearchBrandsRequest? |  (optional) 

            try
            {
                // Returns brands related to keyword input for negative targeting.
                List<Brand> result = apiInstance.SearchBrands(amazonAdvertisingAPIClientId, amazonAdvertisingAPIScope, prefer, searchBrandsRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductTargetingApi.SearchBrands: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SearchBrandsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Returns brands related to keyword input for negative targeting.
    ApiResponse<List<Brand>> response = apiInstance.SearchBrandsWithHttpInfo(amazonAdvertisingAPIClientId, amazonAdvertisingAPIScope, prefer, searchBrandsRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductTargetingApi.SearchBrandsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **amazonAdvertisingAPIClientId** | **string** | The identifier of a client associated with a \&quot;Login with Amazon\&quot; account. This is a required header for advertisers and integrators using the Advertising API. |  |
| **amazonAdvertisingAPIScope** | **string** | The identifier of a profile associated with the advertiser account. Use &#x60;GET&#x60; method on Profiles resource to list profiles associated with the access token passed in the HTTP Authorization header. This is a required header for advertisers and integrators using the Advertising API. |  |
| **prefer** | **string?** | Used to indicate the behavior preferred by the client but is not required for successful completion of the request. Supported values will be updated in the future. | [optional]  |
| **searchBrandsRequest** | [**SearchBrandsRequest?**](SearchBrandsRequest?.md) |  | [optional]  |

### Return type

[**List&lt;Brand&gt;**](Brand.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/vnd.spproducttargeting.v3+json
 - **Accept**: application/vnd.spproducttargetingresponse.v3+json, application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | success |  -  |
| **400** | Bad Request - The input fails to satisfy the constraints of the API. |  -  |
| **401** | Unauthorized - Request failed because user is not authenticated. |  -  |
| **500** | Internal Server Error - Something went wrong on the server. Retry later and report an error if unresolved. |  -  |
| **429** | Too Many Requests - Request was rate-limited. Retry later. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

