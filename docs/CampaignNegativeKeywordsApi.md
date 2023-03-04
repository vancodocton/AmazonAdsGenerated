# Amazon.Advertising.SponsoredProducts.Api.CampaignNegativeKeywordsApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateSponsoredProductsCampaignNegativeKeywords**](CampaignNegativeKeywordsApi.md#createsponsoredproductscampaignnegativekeywords) | **POST** /sp/campaignNegativeKeywords |  |
| [**DeleteSponsoredProductsCampaignNegativeKeywords**](CampaignNegativeKeywordsApi.md#deletesponsoredproductscampaignnegativekeywords) | **POST** /sp/campaignNegativeKeywords/delete |  |
| [**ListSponsoredProductsCampaignNegativeKeywords**](CampaignNegativeKeywordsApi.md#listsponsoredproductscampaignnegativekeywords) | **POST** /sp/campaignNegativeKeywords/list |  |
| [**UpdateSponsoredProductsCampaignNegativeKeywords**](CampaignNegativeKeywordsApi.md#updatesponsoredproductscampaignnegativekeywords) | **PUT** /sp/campaignNegativeKeywords |  |

<a name="createsponsoredproductscampaignnegativekeywords"></a>
# **CreateSponsoredProductsCampaignNegativeKeywords**
> SponsoredProductsCreateSponsoredProductsCampaignNegativeKeywordsResponseContent CreateSponsoredProductsCampaignNegativeKeywords (string amazonAdvertisingAPIClientId, string amazonAdvertisingAPIScope, SponsoredProductsCreateSponsoredProductsCampaignNegativeKeywordsRequestContent sponsoredProductsCreateSponsoredProductsCampaignNegativeKeywordsRequestContent, string? prefer = null)



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
    public class CreateSponsoredProductsCampaignNegativeKeywordsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new CampaignNegativeKeywordsApi(config);
            var amazonAdvertisingAPIClientId = "amazonAdvertisingAPIClientId_example";  // string | The identifier of a client associated with a \"Login with Amazon\" account.
            var amazonAdvertisingAPIScope = "amazonAdvertisingAPIScope_example";  // string | The identifier of a profile associated with the advertiser account. Use GET method on Profiles resource to list profiles associated with the access token passed in the HTTP Authorization header.
            var sponsoredProductsCreateSponsoredProductsCampaignNegativeKeywordsRequestContent = new SponsoredProductsCreateSponsoredProductsCampaignNegativeKeywordsRequestContent(); // SponsoredProductsCreateSponsoredProductsCampaignNegativeKeywordsRequestContent | 
            var prefer = "prefer_example";  // string? | The \"Prefer\" header, as defined in [RFC7240], allows clients to request certain behavior from the service. The service ignores preference values that are either not supported or not known by the service. Either multiple Prefer headers are passed or single one with comma separated values, both forms are equivalent Supported preferences: return=representation - return the full object when doing create/update/delete operations instead of ids (optional) 

            try
            {
                SponsoredProductsCreateSponsoredProductsCampaignNegativeKeywordsResponseContent result = apiInstance.CreateSponsoredProductsCampaignNegativeKeywords(amazonAdvertisingAPIClientId, amazonAdvertisingAPIScope, sponsoredProductsCreateSponsoredProductsCampaignNegativeKeywordsRequestContent, prefer);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CampaignNegativeKeywordsApi.CreateSponsoredProductsCampaignNegativeKeywords: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateSponsoredProductsCampaignNegativeKeywordsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<SponsoredProductsCreateSponsoredProductsCampaignNegativeKeywordsResponseContent> response = apiInstance.CreateSponsoredProductsCampaignNegativeKeywordsWithHttpInfo(amazonAdvertisingAPIClientId, amazonAdvertisingAPIScope, sponsoredProductsCreateSponsoredProductsCampaignNegativeKeywordsRequestContent, prefer);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CampaignNegativeKeywordsApi.CreateSponsoredProductsCampaignNegativeKeywordsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **amazonAdvertisingAPIClientId** | **string** | The identifier of a client associated with a \&quot;Login with Amazon\&quot; account. |  |
| **amazonAdvertisingAPIScope** | **string** | The identifier of a profile associated with the advertiser account. Use GET method on Profiles resource to list profiles associated with the access token passed in the HTTP Authorization header. |  |
| **sponsoredProductsCreateSponsoredProductsCampaignNegativeKeywordsRequestContent** | [**SponsoredProductsCreateSponsoredProductsCampaignNegativeKeywordsRequestContent**](SponsoredProductsCreateSponsoredProductsCampaignNegativeKeywordsRequestContent.md) |  |  |
| **prefer** | **string?** | The \&quot;Prefer\&quot; header, as defined in [RFC7240], allows clients to request certain behavior from the service. The service ignores preference values that are either not supported or not known by the service. Either multiple Prefer headers are passed or single one with comma separated values, both forms are equivalent Supported preferences: return&#x3D;representation - return the full object when doing create/update/delete operations instead of ids | [optional]  |

### Return type

[**SponsoredProductsCreateSponsoredProductsCampaignNegativeKeywordsResponseContent**](SponsoredProductsCreateSponsoredProductsCampaignNegativeKeywordsResponseContent.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/vnd.spCampaignNegativeKeyword.v3+json
 - **Accept**: application/json, application/vnd.spCampaignNegativeKeyword.v3+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **400** | CampaignNegativeKeywordMutationException 400 response |  -  |
| **401** | UnauthorizedException 401 response |  -  |
| **500** | InternalServerException 500 response |  -  |
| **403** | AccessDeniedException 403 response |  -  |
| **415** | UnsupportedMediaTypeException 415 response |  -  |
| **207** | CreateSponsoredProductsCampaignNegativeKeywords 207 response |  * Preference-Applied - Header containing preferences applied while processing API call <br>  |
| **429** | ThrottlingException 429 response |  * Retry-After - Delay in seconds, before the next re-try attempt to the operation is recommended <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletesponsoredproductscampaignnegativekeywords"></a>
# **DeleteSponsoredProductsCampaignNegativeKeywords**
> SponsoredProductsDeleteSponsoredProductsCampaignNegativeKeywordsResponseContent DeleteSponsoredProductsCampaignNegativeKeywords (string amazonAdvertisingAPIClientId, string amazonAdvertisingAPIScope, SponsoredProductsDeleteSponsoredProductsCampaignNegativeKeywordsRequestContent sponsoredProductsDeleteSponsoredProductsCampaignNegativeKeywordsRequestContent)



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
    public class DeleteSponsoredProductsCampaignNegativeKeywordsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new CampaignNegativeKeywordsApi(config);
            var amazonAdvertisingAPIClientId = "amazonAdvertisingAPIClientId_example";  // string | The identifier of a client associated with a \"Login with Amazon\" account.
            var amazonAdvertisingAPIScope = "amazonAdvertisingAPIScope_example";  // string | The identifier of a profile associated with the advertiser account. Use GET method on Profiles resource to list profiles associated with the access token passed in the HTTP Authorization header.
            var sponsoredProductsDeleteSponsoredProductsCampaignNegativeKeywordsRequestContent = new SponsoredProductsDeleteSponsoredProductsCampaignNegativeKeywordsRequestContent(); // SponsoredProductsDeleteSponsoredProductsCampaignNegativeKeywordsRequestContent | 

            try
            {
                SponsoredProductsDeleteSponsoredProductsCampaignNegativeKeywordsResponseContent result = apiInstance.DeleteSponsoredProductsCampaignNegativeKeywords(amazonAdvertisingAPIClientId, amazonAdvertisingAPIScope, sponsoredProductsDeleteSponsoredProductsCampaignNegativeKeywordsRequestContent);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CampaignNegativeKeywordsApi.DeleteSponsoredProductsCampaignNegativeKeywords: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteSponsoredProductsCampaignNegativeKeywordsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<SponsoredProductsDeleteSponsoredProductsCampaignNegativeKeywordsResponseContent> response = apiInstance.DeleteSponsoredProductsCampaignNegativeKeywordsWithHttpInfo(amazonAdvertisingAPIClientId, amazonAdvertisingAPIScope, sponsoredProductsDeleteSponsoredProductsCampaignNegativeKeywordsRequestContent);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CampaignNegativeKeywordsApi.DeleteSponsoredProductsCampaignNegativeKeywordsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **amazonAdvertisingAPIClientId** | **string** | The identifier of a client associated with a \&quot;Login with Amazon\&quot; account. |  |
| **amazonAdvertisingAPIScope** | **string** | The identifier of a profile associated with the advertiser account. Use GET method on Profiles resource to list profiles associated with the access token passed in the HTTP Authorization header. |  |
| **sponsoredProductsDeleteSponsoredProductsCampaignNegativeKeywordsRequestContent** | [**SponsoredProductsDeleteSponsoredProductsCampaignNegativeKeywordsRequestContent**](SponsoredProductsDeleteSponsoredProductsCampaignNegativeKeywordsRequestContent.md) |  |  |

### Return type

[**SponsoredProductsDeleteSponsoredProductsCampaignNegativeKeywordsResponseContent**](SponsoredProductsDeleteSponsoredProductsCampaignNegativeKeywordsResponseContent.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/vnd.spCampaignNegativeKeyword.v3+json
 - **Accept**: application/json, application/vnd.spCampaignNegativeKeyword.v3+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **400** | CampaignNegativeKeywordMutationException 400 response |  -  |
| **401** | UnauthorizedException 401 response |  -  |
| **500** | InternalServerException 500 response |  -  |
| **403** | AccessDeniedException 403 response |  -  |
| **415** | UnsupportedMediaTypeException 415 response |  -  |
| **207** | DeleteSponsoredProductsCampaignNegativeKeywords 207 response |  -  |
| **429** | ThrottlingException 429 response |  * Retry-After - Delay in seconds, before the next re-try attempt to the operation is recommended <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listsponsoredproductscampaignnegativekeywords"></a>
# **ListSponsoredProductsCampaignNegativeKeywords**
> SponsoredProductsListSponsoredProductsCampaignNegativeKeywordsResponseContent ListSponsoredProductsCampaignNegativeKeywords (string amazonAdvertisingAPIClientId, string amazonAdvertisingAPIScope, SponsoredProductsListSponsoredProductsCampaignNegativeKeywordsRequestContent? sponsoredProductsListSponsoredProductsCampaignNegativeKeywordsRequestContent = null)



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
    public class ListSponsoredProductsCampaignNegativeKeywordsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new CampaignNegativeKeywordsApi(config);
            var amazonAdvertisingAPIClientId = "amazonAdvertisingAPIClientId_example";  // string | The identifier of a client associated with a \"Login with Amazon\" account.
            var amazonAdvertisingAPIScope = "amazonAdvertisingAPIScope_example";  // string | The identifier of a profile associated with the advertiser account. Use GET method on Profiles resource to list profiles associated with the access token passed in the HTTP Authorization header.
            var sponsoredProductsListSponsoredProductsCampaignNegativeKeywordsRequestContent = new SponsoredProductsListSponsoredProductsCampaignNegativeKeywordsRequestContent?(); // SponsoredProductsListSponsoredProductsCampaignNegativeKeywordsRequestContent? |  (optional) 

            try
            {
                SponsoredProductsListSponsoredProductsCampaignNegativeKeywordsResponseContent result = apiInstance.ListSponsoredProductsCampaignNegativeKeywords(amazonAdvertisingAPIClientId, amazonAdvertisingAPIScope, sponsoredProductsListSponsoredProductsCampaignNegativeKeywordsRequestContent);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CampaignNegativeKeywordsApi.ListSponsoredProductsCampaignNegativeKeywords: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListSponsoredProductsCampaignNegativeKeywordsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<SponsoredProductsListSponsoredProductsCampaignNegativeKeywordsResponseContent> response = apiInstance.ListSponsoredProductsCampaignNegativeKeywordsWithHttpInfo(amazonAdvertisingAPIClientId, amazonAdvertisingAPIScope, sponsoredProductsListSponsoredProductsCampaignNegativeKeywordsRequestContent);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CampaignNegativeKeywordsApi.ListSponsoredProductsCampaignNegativeKeywordsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **amazonAdvertisingAPIClientId** | **string** | The identifier of a client associated with a \&quot;Login with Amazon\&quot; account. |  |
| **amazonAdvertisingAPIScope** | **string** | The identifier of a profile associated with the advertiser account. Use GET method on Profiles resource to list profiles associated with the access token passed in the HTTP Authorization header. |  |
| **sponsoredProductsListSponsoredProductsCampaignNegativeKeywordsRequestContent** | [**SponsoredProductsListSponsoredProductsCampaignNegativeKeywordsRequestContent?**](SponsoredProductsListSponsoredProductsCampaignNegativeKeywordsRequestContent?.md) |  | [optional]  |

### Return type

[**SponsoredProductsListSponsoredProductsCampaignNegativeKeywordsResponseContent**](SponsoredProductsListSponsoredProductsCampaignNegativeKeywordsResponseContent.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/vnd.spCampaignNegativeKeyword.v3+json
 - **Accept**: application/vnd.spCampaignNegativeKeyword.v3+json, application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | ListSponsoredProductsCampaignNegativeKeywords 200 response |  -  |
| **400** | CampaignNegativeKeywordAccessException 400 response |  -  |
| **401** | UnauthorizedException 401 response |  -  |
| **500** | InternalServerException 500 response |  -  |
| **403** | AccessDeniedException 403 response |  -  |
| **415** | UnsupportedMediaTypeException 415 response |  -  |
| **429** | ThrottlingException 429 response |  * Retry-After - Delay in seconds, before the next re-try attempt to the operation is recommended <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatesponsoredproductscampaignnegativekeywords"></a>
# **UpdateSponsoredProductsCampaignNegativeKeywords**
> SponsoredProductsUpdateSponsoredProductsCampaignNegativeKeywordsResponseContent UpdateSponsoredProductsCampaignNegativeKeywords (string amazonAdvertisingAPIClientId, string amazonAdvertisingAPIScope, SponsoredProductsUpdateSponsoredProductsCampaignNegativeKeywordsRequestContent sponsoredProductsUpdateSponsoredProductsCampaignNegativeKeywordsRequestContent, string? prefer = null)



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
    public class UpdateSponsoredProductsCampaignNegativeKeywordsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new CampaignNegativeKeywordsApi(config);
            var amazonAdvertisingAPIClientId = "amazonAdvertisingAPIClientId_example";  // string | The identifier of a client associated with a \"Login with Amazon\" account.
            var amazonAdvertisingAPIScope = "amazonAdvertisingAPIScope_example";  // string | The identifier of a profile associated with the advertiser account. Use GET method on Profiles resource to list profiles associated with the access token passed in the HTTP Authorization header.
            var sponsoredProductsUpdateSponsoredProductsCampaignNegativeKeywordsRequestContent = new SponsoredProductsUpdateSponsoredProductsCampaignNegativeKeywordsRequestContent(); // SponsoredProductsUpdateSponsoredProductsCampaignNegativeKeywordsRequestContent | 
            var prefer = "prefer_example";  // string? | The \"Prefer\" header, as defined in [RFC7240], allows clients to request certain behavior from the service. The service ignores preference values that are either not supported or not known by the service. Either multiple Prefer headers are passed or single one with comma separated values, both forms are equivalent Supported preferences: return=representation - return the full object when doing create/update/delete operations instead of ids (optional) 

            try
            {
                SponsoredProductsUpdateSponsoredProductsCampaignNegativeKeywordsResponseContent result = apiInstance.UpdateSponsoredProductsCampaignNegativeKeywords(amazonAdvertisingAPIClientId, amazonAdvertisingAPIScope, sponsoredProductsUpdateSponsoredProductsCampaignNegativeKeywordsRequestContent, prefer);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CampaignNegativeKeywordsApi.UpdateSponsoredProductsCampaignNegativeKeywords: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateSponsoredProductsCampaignNegativeKeywordsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<SponsoredProductsUpdateSponsoredProductsCampaignNegativeKeywordsResponseContent> response = apiInstance.UpdateSponsoredProductsCampaignNegativeKeywordsWithHttpInfo(amazonAdvertisingAPIClientId, amazonAdvertisingAPIScope, sponsoredProductsUpdateSponsoredProductsCampaignNegativeKeywordsRequestContent, prefer);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CampaignNegativeKeywordsApi.UpdateSponsoredProductsCampaignNegativeKeywordsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **amazonAdvertisingAPIClientId** | **string** | The identifier of a client associated with a \&quot;Login with Amazon\&quot; account. |  |
| **amazonAdvertisingAPIScope** | **string** | The identifier of a profile associated with the advertiser account. Use GET method on Profiles resource to list profiles associated with the access token passed in the HTTP Authorization header. |  |
| **sponsoredProductsUpdateSponsoredProductsCampaignNegativeKeywordsRequestContent** | [**SponsoredProductsUpdateSponsoredProductsCampaignNegativeKeywordsRequestContent**](SponsoredProductsUpdateSponsoredProductsCampaignNegativeKeywordsRequestContent.md) |  |  |
| **prefer** | **string?** | The \&quot;Prefer\&quot; header, as defined in [RFC7240], allows clients to request certain behavior from the service. The service ignores preference values that are either not supported or not known by the service. Either multiple Prefer headers are passed or single one with comma separated values, both forms are equivalent Supported preferences: return&#x3D;representation - return the full object when doing create/update/delete operations instead of ids | [optional]  |

### Return type

[**SponsoredProductsUpdateSponsoredProductsCampaignNegativeKeywordsResponseContent**](SponsoredProductsUpdateSponsoredProductsCampaignNegativeKeywordsResponseContent.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/vnd.spCampaignNegativeKeyword.v3+json
 - **Accept**: application/json, application/vnd.spCampaignNegativeKeyword.v3+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **400** | CampaignNegativeKeywordMutationException 400 response |  -  |
| **401** | UnauthorizedException 401 response |  -  |
| **500** | InternalServerException 500 response |  -  |
| **403** | AccessDeniedException 403 response |  -  |
| **415** | UnsupportedMediaTypeException 415 response |  -  |
| **207** | UpdateSponsoredProductsCampaignNegativeKeywords 207 response |  * Preference-Applied - Header containing preferences applied while processing API call <br>  |
| **429** | ThrottlingException 429 response |  * Retry-After - Delay in seconds, before the next re-try attempt to the operation is recommended <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

