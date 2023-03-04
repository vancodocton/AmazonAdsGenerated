# Amazon.Advertising.SponsoredProducts.Api.NegativeKeywordsApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateSponsoredProductsNegativeKeywords**](NegativeKeywordsApi.md#createsponsoredproductsnegativekeywords) | **POST** /sp/negativeKeywords |  |
| [**DeleteSponsoredProductsNegativeKeywords**](NegativeKeywordsApi.md#deletesponsoredproductsnegativekeywords) | **POST** /sp/negativeKeywords/delete |  |
| [**ListSponsoredProductsNegativeKeywords**](NegativeKeywordsApi.md#listsponsoredproductsnegativekeywords) | **POST** /sp/negativeKeywords/list |  |
| [**UpdateSponsoredProductsNegativeKeywords**](NegativeKeywordsApi.md#updatesponsoredproductsnegativekeywords) | **PUT** /sp/negativeKeywords |  |

<a name="createsponsoredproductsnegativekeywords"></a>
# **CreateSponsoredProductsNegativeKeywords**
> SponsoredProductsCreateSponsoredProductsNegativeKeywordsResponseContent CreateSponsoredProductsNegativeKeywords (string amazonAdvertisingAPIClientId, string amazonAdvertisingAPIScope, SponsoredProductsCreateSponsoredProductsNegativeKeywordsRequestContent sponsoredProductsCreateSponsoredProductsNegativeKeywordsRequestContent, string? prefer = null)



  **Requires one of these permissions**: [\"advertiser_campaign_edit\"]

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Amazon.Advertising.SponsoredProducts.Api;
using Amazon.Advertising.SponsoredProducts.Client;
using Amazon.Advertising.SponsoredProducts.Model;

namespace Example
{
    public class CreateSponsoredProductsNegativeKeywordsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new NegativeKeywordsApi(config);
            var amazonAdvertisingAPIClientId = "amazonAdvertisingAPIClientId_example";  // string | The identifier of a client associated with a \"Login with Amazon\" account.
            var amazonAdvertisingAPIScope = "amazonAdvertisingAPIScope_example";  // string | The identifier of a profile associated with the advertiser account. Use GET method on Profiles resource to list profiles associated with the access token passed in the HTTP Authorization header.
            var sponsoredProductsCreateSponsoredProductsNegativeKeywordsRequestContent = new SponsoredProductsCreateSponsoredProductsNegativeKeywordsRequestContent(); // SponsoredProductsCreateSponsoredProductsNegativeKeywordsRequestContent | 
            var prefer = "prefer_example";  // string? | The \"Prefer\" header, as defined in [RFC7240], allows clients to request certain behavior from the service. The service ignores preference values that are either not supported or not known by the service. Either multiple Prefer headers are passed or single one with comma separated values, both forms are equivalent Supported preferences: return=representation - return the full object when doing create/update/delete operations instead of ids (optional) 

            try
            {
                SponsoredProductsCreateSponsoredProductsNegativeKeywordsResponseContent result = apiInstance.CreateSponsoredProductsNegativeKeywords(amazonAdvertisingAPIClientId, amazonAdvertisingAPIScope, sponsoredProductsCreateSponsoredProductsNegativeKeywordsRequestContent, prefer);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NegativeKeywordsApi.CreateSponsoredProductsNegativeKeywords: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateSponsoredProductsNegativeKeywordsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<SponsoredProductsCreateSponsoredProductsNegativeKeywordsResponseContent> response = apiInstance.CreateSponsoredProductsNegativeKeywordsWithHttpInfo(amazonAdvertisingAPIClientId, amazonAdvertisingAPIScope, sponsoredProductsCreateSponsoredProductsNegativeKeywordsRequestContent, prefer);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling NegativeKeywordsApi.CreateSponsoredProductsNegativeKeywordsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **amazonAdvertisingAPIClientId** | **string** | The identifier of a client associated with a \&quot;Login with Amazon\&quot; account. |  |
| **amazonAdvertisingAPIScope** | **string** | The identifier of a profile associated with the advertiser account. Use GET method on Profiles resource to list profiles associated with the access token passed in the HTTP Authorization header. |  |
| **sponsoredProductsCreateSponsoredProductsNegativeKeywordsRequestContent** | [**SponsoredProductsCreateSponsoredProductsNegativeKeywordsRequestContent**](SponsoredProductsCreateSponsoredProductsNegativeKeywordsRequestContent.md) |  |  |
| **prefer** | **string?** | The \&quot;Prefer\&quot; header, as defined in [RFC7240], allows clients to request certain behavior from the service. The service ignores preference values that are either not supported or not known by the service. Either multiple Prefer headers are passed or single one with comma separated values, both forms are equivalent Supported preferences: return&#x3D;representation - return the full object when doing create/update/delete operations instead of ids | [optional]  |

### Return type

[**SponsoredProductsCreateSponsoredProductsNegativeKeywordsResponseContent**](SponsoredProductsCreateSponsoredProductsNegativeKeywordsResponseContent.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/vnd.spNegativeKeyword.v3+json
 - **Accept**: application/json, application/vnd.spNegativeKeyword.v3+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **400** | NegativeKeywordMutationException 400 response |  -  |
| **401** | UnauthorizedException 401 response |  -  |
| **500** | InternalServerException 500 response |  -  |
| **403** | AccessDeniedException 403 response |  -  |
| **415** | UnsupportedMediaTypeException 415 response |  -  |
| **207** | CreateSponsoredProductsNegativeKeywords 207 response |  * Preference-Applied - Header containing preferences applied while processing API call <br>  |
| **429** | ThrottlingException 429 response |  * Retry-After - Delay in seconds, before the next re-try attempt to the operation is recommended <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletesponsoredproductsnegativekeywords"></a>
# **DeleteSponsoredProductsNegativeKeywords**
> SponsoredProductsDeleteSponsoredProductsNegativeKeywordsResponseContent DeleteSponsoredProductsNegativeKeywords (string amazonAdvertisingAPIClientId, string amazonAdvertisingAPIScope, SponsoredProductsDeleteSponsoredProductsNegativeKeywordsRequestContent sponsoredProductsDeleteSponsoredProductsNegativeKeywordsRequestContent)



  **Requires one of these permissions**: [\"advertiser_campaign_edit\"]

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Amazon.Advertising.SponsoredProducts.Api;
using Amazon.Advertising.SponsoredProducts.Client;
using Amazon.Advertising.SponsoredProducts.Model;

namespace Example
{
    public class DeleteSponsoredProductsNegativeKeywordsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new NegativeKeywordsApi(config);
            var amazonAdvertisingAPIClientId = "amazonAdvertisingAPIClientId_example";  // string | The identifier of a client associated with a \"Login with Amazon\" account.
            var amazonAdvertisingAPIScope = "amazonAdvertisingAPIScope_example";  // string | The identifier of a profile associated with the advertiser account. Use GET method on Profiles resource to list profiles associated with the access token passed in the HTTP Authorization header.
            var sponsoredProductsDeleteSponsoredProductsNegativeKeywordsRequestContent = new SponsoredProductsDeleteSponsoredProductsNegativeKeywordsRequestContent(); // SponsoredProductsDeleteSponsoredProductsNegativeKeywordsRequestContent | 

            try
            {
                SponsoredProductsDeleteSponsoredProductsNegativeKeywordsResponseContent result = apiInstance.DeleteSponsoredProductsNegativeKeywords(amazonAdvertisingAPIClientId, amazonAdvertisingAPIScope, sponsoredProductsDeleteSponsoredProductsNegativeKeywordsRequestContent);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NegativeKeywordsApi.DeleteSponsoredProductsNegativeKeywords: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteSponsoredProductsNegativeKeywordsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<SponsoredProductsDeleteSponsoredProductsNegativeKeywordsResponseContent> response = apiInstance.DeleteSponsoredProductsNegativeKeywordsWithHttpInfo(amazonAdvertisingAPIClientId, amazonAdvertisingAPIScope, sponsoredProductsDeleteSponsoredProductsNegativeKeywordsRequestContent);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling NegativeKeywordsApi.DeleteSponsoredProductsNegativeKeywordsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **amazonAdvertisingAPIClientId** | **string** | The identifier of a client associated with a \&quot;Login with Amazon\&quot; account. |  |
| **amazonAdvertisingAPIScope** | **string** | The identifier of a profile associated with the advertiser account. Use GET method on Profiles resource to list profiles associated with the access token passed in the HTTP Authorization header. |  |
| **sponsoredProductsDeleteSponsoredProductsNegativeKeywordsRequestContent** | [**SponsoredProductsDeleteSponsoredProductsNegativeKeywordsRequestContent**](SponsoredProductsDeleteSponsoredProductsNegativeKeywordsRequestContent.md) |  |  |

### Return type

[**SponsoredProductsDeleteSponsoredProductsNegativeKeywordsResponseContent**](SponsoredProductsDeleteSponsoredProductsNegativeKeywordsResponseContent.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/vnd.spNegativeKeyword.v3+json
 - **Accept**: application/json, application/vnd.spNegativeKeyword.v3+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **400** | NegativeKeywordMutationException 400 response |  -  |
| **401** | UnauthorizedException 401 response |  -  |
| **500** | InternalServerException 500 response |  -  |
| **403** | AccessDeniedException 403 response |  -  |
| **415** | UnsupportedMediaTypeException 415 response |  -  |
| **207** | DeleteSponsoredProductsNegativeKeywords 207 response |  -  |
| **429** | ThrottlingException 429 response |  * Retry-After - Delay in seconds, before the next re-try attempt to the operation is recommended <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listsponsoredproductsnegativekeywords"></a>
# **ListSponsoredProductsNegativeKeywords**
> SponsoredProductsListSponsoredProductsNegativeKeywordsResponseContent ListSponsoredProductsNegativeKeywords (string amazonAdvertisingAPIClientId, string amazonAdvertisingAPIScope, SponsoredProductsListSponsoredProductsNegativeKeywordsRequestContent? sponsoredProductsListSponsoredProductsNegativeKeywordsRequestContent = null)



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
    public class ListSponsoredProductsNegativeKeywordsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new NegativeKeywordsApi(config);
            var amazonAdvertisingAPIClientId = "amazonAdvertisingAPIClientId_example";  // string | The identifier of a client associated with a \"Login with Amazon\" account.
            var amazonAdvertisingAPIScope = "amazonAdvertisingAPIScope_example";  // string | The identifier of a profile associated with the advertiser account. Use GET method on Profiles resource to list profiles associated with the access token passed in the HTTP Authorization header.
            var sponsoredProductsListSponsoredProductsNegativeKeywordsRequestContent = new SponsoredProductsListSponsoredProductsNegativeKeywordsRequestContent?(); // SponsoredProductsListSponsoredProductsNegativeKeywordsRequestContent? |  (optional) 

            try
            {
                SponsoredProductsListSponsoredProductsNegativeKeywordsResponseContent result = apiInstance.ListSponsoredProductsNegativeKeywords(amazonAdvertisingAPIClientId, amazonAdvertisingAPIScope, sponsoredProductsListSponsoredProductsNegativeKeywordsRequestContent);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NegativeKeywordsApi.ListSponsoredProductsNegativeKeywords: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListSponsoredProductsNegativeKeywordsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<SponsoredProductsListSponsoredProductsNegativeKeywordsResponseContent> response = apiInstance.ListSponsoredProductsNegativeKeywordsWithHttpInfo(amazonAdvertisingAPIClientId, amazonAdvertisingAPIScope, sponsoredProductsListSponsoredProductsNegativeKeywordsRequestContent);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling NegativeKeywordsApi.ListSponsoredProductsNegativeKeywordsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **amazonAdvertisingAPIClientId** | **string** | The identifier of a client associated with a \&quot;Login with Amazon\&quot; account. |  |
| **amazonAdvertisingAPIScope** | **string** | The identifier of a profile associated with the advertiser account. Use GET method on Profiles resource to list profiles associated with the access token passed in the HTTP Authorization header. |  |
| **sponsoredProductsListSponsoredProductsNegativeKeywordsRequestContent** | [**SponsoredProductsListSponsoredProductsNegativeKeywordsRequestContent?**](SponsoredProductsListSponsoredProductsNegativeKeywordsRequestContent?.md) |  | [optional]  |

### Return type

[**SponsoredProductsListSponsoredProductsNegativeKeywordsResponseContent**](SponsoredProductsListSponsoredProductsNegativeKeywordsResponseContent.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/vnd.spNegativeKeyword.v3+json
 - **Accept**: application/vnd.spNegativeKeyword.v3+json, application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | ListSponsoredProductsNegativeKeywords 200 response |  -  |
| **400** | NegativeKeywordAccessException 400 response |  -  |
| **401** | UnauthorizedException 401 response |  -  |
| **500** | InternalServerException 500 response |  -  |
| **403** | AccessDeniedException 403 response |  -  |
| **415** | UnsupportedMediaTypeException 415 response |  -  |
| **429** | ThrottlingException 429 response |  * Retry-After - Delay in seconds, before the next re-try attempt to the operation is recommended <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatesponsoredproductsnegativekeywords"></a>
# **UpdateSponsoredProductsNegativeKeywords**
> SponsoredProductsUpdateSponsoredProductsNegativeKeywordsResponseContent UpdateSponsoredProductsNegativeKeywords (string amazonAdvertisingAPIClientId, string amazonAdvertisingAPIScope, SponsoredProductsUpdateSponsoredProductsNegativeKeywordsRequestContent sponsoredProductsUpdateSponsoredProductsNegativeKeywordsRequestContent, string? prefer = null)



  **Requires one of these permissions**: [\"advertiser_campaign_edit\"]

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Amazon.Advertising.SponsoredProducts.Api;
using Amazon.Advertising.SponsoredProducts.Client;
using Amazon.Advertising.SponsoredProducts.Model;

namespace Example
{
    public class UpdateSponsoredProductsNegativeKeywordsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new NegativeKeywordsApi(config);
            var amazonAdvertisingAPIClientId = "amazonAdvertisingAPIClientId_example";  // string | The identifier of a client associated with a \"Login with Amazon\" account.
            var amazonAdvertisingAPIScope = "amazonAdvertisingAPIScope_example";  // string | The identifier of a profile associated with the advertiser account. Use GET method on Profiles resource to list profiles associated with the access token passed in the HTTP Authorization header.
            var sponsoredProductsUpdateSponsoredProductsNegativeKeywordsRequestContent = new SponsoredProductsUpdateSponsoredProductsNegativeKeywordsRequestContent(); // SponsoredProductsUpdateSponsoredProductsNegativeKeywordsRequestContent | 
            var prefer = "prefer_example";  // string? | The \"Prefer\" header, as defined in [RFC7240], allows clients to request certain behavior from the service. The service ignores preference values that are either not supported or not known by the service. Either multiple Prefer headers are passed or single one with comma separated values, both forms are equivalent Supported preferences: return=representation - return the full object when doing create/update/delete operations instead of ids (optional) 

            try
            {
                SponsoredProductsUpdateSponsoredProductsNegativeKeywordsResponseContent result = apiInstance.UpdateSponsoredProductsNegativeKeywords(amazonAdvertisingAPIClientId, amazonAdvertisingAPIScope, sponsoredProductsUpdateSponsoredProductsNegativeKeywordsRequestContent, prefer);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NegativeKeywordsApi.UpdateSponsoredProductsNegativeKeywords: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateSponsoredProductsNegativeKeywordsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<SponsoredProductsUpdateSponsoredProductsNegativeKeywordsResponseContent> response = apiInstance.UpdateSponsoredProductsNegativeKeywordsWithHttpInfo(amazonAdvertisingAPIClientId, amazonAdvertisingAPIScope, sponsoredProductsUpdateSponsoredProductsNegativeKeywordsRequestContent, prefer);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling NegativeKeywordsApi.UpdateSponsoredProductsNegativeKeywordsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **amazonAdvertisingAPIClientId** | **string** | The identifier of a client associated with a \&quot;Login with Amazon\&quot; account. |  |
| **amazonAdvertisingAPIScope** | **string** | The identifier of a profile associated with the advertiser account. Use GET method on Profiles resource to list profiles associated with the access token passed in the HTTP Authorization header. |  |
| **sponsoredProductsUpdateSponsoredProductsNegativeKeywordsRequestContent** | [**SponsoredProductsUpdateSponsoredProductsNegativeKeywordsRequestContent**](SponsoredProductsUpdateSponsoredProductsNegativeKeywordsRequestContent.md) |  |  |
| **prefer** | **string?** | The \&quot;Prefer\&quot; header, as defined in [RFC7240], allows clients to request certain behavior from the service. The service ignores preference values that are either not supported or not known by the service. Either multiple Prefer headers are passed or single one with comma separated values, both forms are equivalent Supported preferences: return&#x3D;representation - return the full object when doing create/update/delete operations instead of ids | [optional]  |

### Return type

[**SponsoredProductsUpdateSponsoredProductsNegativeKeywordsResponseContent**](SponsoredProductsUpdateSponsoredProductsNegativeKeywordsResponseContent.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/vnd.spNegativeKeyword.v3+json
 - **Accept**: application/json, application/vnd.spNegativeKeyword.v3+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **400** | NegativeKeywordMutationException 400 response |  -  |
| **401** | UnauthorizedException 401 response |  -  |
| **500** | InternalServerException 500 response |  -  |
| **403** | AccessDeniedException 403 response |  -  |
| **415** | UnsupportedMediaTypeException 415 response |  -  |
| **207** | UpdateSponsoredProductsNegativeKeywords 207 response |  * Preference-Applied - Header containing preferences applied while processing API call <br>  |
| **429** | ThrottlingException 429 response |  * Retry-After - Delay in seconds, before the next re-try attempt to the operation is recommended <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

