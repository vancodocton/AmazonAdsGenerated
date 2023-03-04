# Amazon.Advertising.SponsoredProducts.Api.TargetingClausesApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateSponsoredProductsTargetingClauses**](TargetingClausesApi.md#createsponsoredproductstargetingclauses) | **POST** /sp/targets |  |
| [**DeleteSponsoredProductsTargetingClauses**](TargetingClausesApi.md#deletesponsoredproductstargetingclauses) | **POST** /sp/targets/delete |  |
| [**ListSponsoredProductsTargetingClauses**](TargetingClausesApi.md#listsponsoredproductstargetingclauses) | **POST** /sp/targets/list |  |
| [**UpdateSponsoredProductsTargetingClauses**](TargetingClausesApi.md#updatesponsoredproductstargetingclauses) | **PUT** /sp/targets |  |

<a name="createsponsoredproductstargetingclauses"></a>
# **CreateSponsoredProductsTargetingClauses**
> SponsoredProductsCreateSponsoredProductsTargetingClausesResponseContent CreateSponsoredProductsTargetingClauses (string amazonAdvertisingAPIClientId, string amazonAdvertisingAPIScope, SponsoredProductsCreateSponsoredProductsTargetingClausesRequestContent sponsoredProductsCreateSponsoredProductsTargetingClausesRequestContent, string? prefer = null)



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
    public class CreateSponsoredProductsTargetingClausesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new TargetingClausesApi(config);
            var amazonAdvertisingAPIClientId = "amazonAdvertisingAPIClientId_example";  // string | The identifier of a client associated with a \"Login with Amazon\" account.
            var amazonAdvertisingAPIScope = "amazonAdvertisingAPIScope_example";  // string | The identifier of a profile associated with the advertiser account. Use GET method on Profiles resource to list profiles associated with the access token passed in the HTTP Authorization header.
            var sponsoredProductsCreateSponsoredProductsTargetingClausesRequestContent = new SponsoredProductsCreateSponsoredProductsTargetingClausesRequestContent(); // SponsoredProductsCreateSponsoredProductsTargetingClausesRequestContent | 
            var prefer = "prefer_example";  // string? | The \"Prefer\" header, as defined in [RFC7240], allows clients to request certain behavior from the service. The service ignores preference values that are either not supported or not known by the service. Either multiple Prefer headers are passed or single one with comma separated values, both forms are equivalent Supported preferences: return=representation - return the full object when doing create/update/delete operations instead of ids (optional) 

            try
            {
                SponsoredProductsCreateSponsoredProductsTargetingClausesResponseContent result = apiInstance.CreateSponsoredProductsTargetingClauses(amazonAdvertisingAPIClientId, amazonAdvertisingAPIScope, sponsoredProductsCreateSponsoredProductsTargetingClausesRequestContent, prefer);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TargetingClausesApi.CreateSponsoredProductsTargetingClauses: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateSponsoredProductsTargetingClausesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<SponsoredProductsCreateSponsoredProductsTargetingClausesResponseContent> response = apiInstance.CreateSponsoredProductsTargetingClausesWithHttpInfo(amazonAdvertisingAPIClientId, amazonAdvertisingAPIScope, sponsoredProductsCreateSponsoredProductsTargetingClausesRequestContent, prefer);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TargetingClausesApi.CreateSponsoredProductsTargetingClausesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **amazonAdvertisingAPIClientId** | **string** | The identifier of a client associated with a \&quot;Login with Amazon\&quot; account. |  |
| **amazonAdvertisingAPIScope** | **string** | The identifier of a profile associated with the advertiser account. Use GET method on Profiles resource to list profiles associated with the access token passed in the HTTP Authorization header. |  |
| **sponsoredProductsCreateSponsoredProductsTargetingClausesRequestContent** | [**SponsoredProductsCreateSponsoredProductsTargetingClausesRequestContent**](SponsoredProductsCreateSponsoredProductsTargetingClausesRequestContent.md) |  |  |
| **prefer** | **string?** | The \&quot;Prefer\&quot; header, as defined in [RFC7240], allows clients to request certain behavior from the service. The service ignores preference values that are either not supported or not known by the service. Either multiple Prefer headers are passed or single one with comma separated values, both forms are equivalent Supported preferences: return&#x3D;representation - return the full object when doing create/update/delete operations instead of ids | [optional]  |

### Return type

[**SponsoredProductsCreateSponsoredProductsTargetingClausesResponseContent**](SponsoredProductsCreateSponsoredProductsTargetingClausesResponseContent.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/vnd.spTargetingClause.v3+json
 - **Accept**: application/json, application/vnd.spTargetingClause.v3+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **400** | TargetMutationException 400 response |  -  |
| **401** | UnauthorizedException 401 response |  -  |
| **500** | InternalServerException 500 response |  -  |
| **403** | AccessDeniedException 403 response |  -  |
| **415** | UnsupportedMediaTypeException 415 response |  -  |
| **207** | CreateSponsoredProductsTargetingClauses 207 response |  * Preference-Applied - Header containing preferences applied while processing API call <br>  |
| **429** | ThrottlingException 429 response |  * Retry-After - Delay in seconds, before the next re-try attempt to the operation is recommended <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletesponsoredproductstargetingclauses"></a>
# **DeleteSponsoredProductsTargetingClauses**
> SponsoredProductsDeleteSponsoredProductsTargetingClausesResponseContent DeleteSponsoredProductsTargetingClauses (string amazonAdvertisingAPIClientId, string amazonAdvertisingAPIScope, SponsoredProductsDeleteSponsoredProductsTargetingClausesRequestContent sponsoredProductsDeleteSponsoredProductsTargetingClausesRequestContent)



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
    public class DeleteSponsoredProductsTargetingClausesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new TargetingClausesApi(config);
            var amazonAdvertisingAPIClientId = "amazonAdvertisingAPIClientId_example";  // string | The identifier of a client associated with a \"Login with Amazon\" account.
            var amazonAdvertisingAPIScope = "amazonAdvertisingAPIScope_example";  // string | The identifier of a profile associated with the advertiser account. Use GET method on Profiles resource to list profiles associated with the access token passed in the HTTP Authorization header.
            var sponsoredProductsDeleteSponsoredProductsTargetingClausesRequestContent = new SponsoredProductsDeleteSponsoredProductsTargetingClausesRequestContent(); // SponsoredProductsDeleteSponsoredProductsTargetingClausesRequestContent | 

            try
            {
                SponsoredProductsDeleteSponsoredProductsTargetingClausesResponseContent result = apiInstance.DeleteSponsoredProductsTargetingClauses(amazonAdvertisingAPIClientId, amazonAdvertisingAPIScope, sponsoredProductsDeleteSponsoredProductsTargetingClausesRequestContent);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TargetingClausesApi.DeleteSponsoredProductsTargetingClauses: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteSponsoredProductsTargetingClausesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<SponsoredProductsDeleteSponsoredProductsTargetingClausesResponseContent> response = apiInstance.DeleteSponsoredProductsTargetingClausesWithHttpInfo(amazonAdvertisingAPIClientId, amazonAdvertisingAPIScope, sponsoredProductsDeleteSponsoredProductsTargetingClausesRequestContent);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TargetingClausesApi.DeleteSponsoredProductsTargetingClausesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **amazonAdvertisingAPIClientId** | **string** | The identifier of a client associated with a \&quot;Login with Amazon\&quot; account. |  |
| **amazonAdvertisingAPIScope** | **string** | The identifier of a profile associated with the advertiser account. Use GET method on Profiles resource to list profiles associated with the access token passed in the HTTP Authorization header. |  |
| **sponsoredProductsDeleteSponsoredProductsTargetingClausesRequestContent** | [**SponsoredProductsDeleteSponsoredProductsTargetingClausesRequestContent**](SponsoredProductsDeleteSponsoredProductsTargetingClausesRequestContent.md) |  |  |

### Return type

[**SponsoredProductsDeleteSponsoredProductsTargetingClausesResponseContent**](SponsoredProductsDeleteSponsoredProductsTargetingClausesResponseContent.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/vnd.spTargetingClause.v3+json
 - **Accept**: application/json, application/vnd.spTargetingClause.v3+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **400** | TargetMutationException 400 response |  -  |
| **401** | UnauthorizedException 401 response |  -  |
| **500** | InternalServerException 500 response |  -  |
| **403** | AccessDeniedException 403 response |  -  |
| **415** | UnsupportedMediaTypeException 415 response |  -  |
| **207** | DeleteSponsoredProductsTargetingClauses 207 response |  -  |
| **429** | ThrottlingException 429 response |  * Retry-After - Delay in seconds, before the next re-try attempt to the operation is recommended <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listsponsoredproductstargetingclauses"></a>
# **ListSponsoredProductsTargetingClauses**
> SponsoredProductsListSponsoredProductsTargetingClausesResponseContent ListSponsoredProductsTargetingClauses (string amazonAdvertisingAPIClientId, string amazonAdvertisingAPIScope, SponsoredProductsListSponsoredProductsTargetingClausesRequestContent? sponsoredProductsListSponsoredProductsTargetingClausesRequestContent = null)



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
    public class ListSponsoredProductsTargetingClausesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new TargetingClausesApi(config);
            var amazonAdvertisingAPIClientId = "amazonAdvertisingAPIClientId_example";  // string | The identifier of a client associated with a \"Login with Amazon\" account.
            var amazonAdvertisingAPIScope = "amazonAdvertisingAPIScope_example";  // string | The identifier of a profile associated with the advertiser account. Use GET method on Profiles resource to list profiles associated with the access token passed in the HTTP Authorization header.
            var sponsoredProductsListSponsoredProductsTargetingClausesRequestContent = new SponsoredProductsListSponsoredProductsTargetingClausesRequestContent?(); // SponsoredProductsListSponsoredProductsTargetingClausesRequestContent? |  (optional) 

            try
            {
                SponsoredProductsListSponsoredProductsTargetingClausesResponseContent result = apiInstance.ListSponsoredProductsTargetingClauses(amazonAdvertisingAPIClientId, amazonAdvertisingAPIScope, sponsoredProductsListSponsoredProductsTargetingClausesRequestContent);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TargetingClausesApi.ListSponsoredProductsTargetingClauses: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListSponsoredProductsTargetingClausesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<SponsoredProductsListSponsoredProductsTargetingClausesResponseContent> response = apiInstance.ListSponsoredProductsTargetingClausesWithHttpInfo(amazonAdvertisingAPIClientId, amazonAdvertisingAPIScope, sponsoredProductsListSponsoredProductsTargetingClausesRequestContent);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TargetingClausesApi.ListSponsoredProductsTargetingClausesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **amazonAdvertisingAPIClientId** | **string** | The identifier of a client associated with a \&quot;Login with Amazon\&quot; account. |  |
| **amazonAdvertisingAPIScope** | **string** | The identifier of a profile associated with the advertiser account. Use GET method on Profiles resource to list profiles associated with the access token passed in the HTTP Authorization header. |  |
| **sponsoredProductsListSponsoredProductsTargetingClausesRequestContent** | [**SponsoredProductsListSponsoredProductsTargetingClausesRequestContent?**](SponsoredProductsListSponsoredProductsTargetingClausesRequestContent?.md) |  | [optional]  |

### Return type

[**SponsoredProductsListSponsoredProductsTargetingClausesResponseContent**](SponsoredProductsListSponsoredProductsTargetingClausesResponseContent.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/vnd.spTargetingClause.v3+json
 - **Accept**: application/vnd.spTargetingClause.v3+json, application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | ListSponsoredProductsTargetingClauses 200 response |  -  |
| **400** | TargetAccessException 400 response |  -  |
| **401** | UnauthorizedException 401 response |  -  |
| **500** | InternalServerException 500 response |  -  |
| **403** | AccessDeniedException 403 response |  -  |
| **415** | UnsupportedMediaTypeException 415 response |  -  |
| **429** | ThrottlingException 429 response |  * Retry-After - Delay in seconds, before the next re-try attempt to the operation is recommended <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatesponsoredproductstargetingclauses"></a>
# **UpdateSponsoredProductsTargetingClauses**
> SponsoredProductsUpdateSponsoredProductsTargetingClausesResponseContent UpdateSponsoredProductsTargetingClauses (string amazonAdvertisingAPIClientId, string amazonAdvertisingAPIScope, SponsoredProductsUpdateSponsoredProductsTargetingClausesRequestContent sponsoredProductsUpdateSponsoredProductsTargetingClausesRequestContent, string? prefer = null)



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
    public class UpdateSponsoredProductsTargetingClausesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new TargetingClausesApi(config);
            var amazonAdvertisingAPIClientId = "amazonAdvertisingAPIClientId_example";  // string | The identifier of a client associated with a \"Login with Amazon\" account.
            var amazonAdvertisingAPIScope = "amazonAdvertisingAPIScope_example";  // string | The identifier of a profile associated with the advertiser account. Use GET method on Profiles resource to list profiles associated with the access token passed in the HTTP Authorization header.
            var sponsoredProductsUpdateSponsoredProductsTargetingClausesRequestContent = new SponsoredProductsUpdateSponsoredProductsTargetingClausesRequestContent(); // SponsoredProductsUpdateSponsoredProductsTargetingClausesRequestContent | 
            var prefer = "prefer_example";  // string? | The \"Prefer\" header, as defined in [RFC7240], allows clients to request certain behavior from the service. The service ignores preference values that are either not supported or not known by the service. Either multiple Prefer headers are passed or single one with comma separated values, both forms are equivalent Supported preferences: return=representation - return the full object when doing create/update/delete operations instead of ids (optional) 

            try
            {
                SponsoredProductsUpdateSponsoredProductsTargetingClausesResponseContent result = apiInstance.UpdateSponsoredProductsTargetingClauses(amazonAdvertisingAPIClientId, amazonAdvertisingAPIScope, sponsoredProductsUpdateSponsoredProductsTargetingClausesRequestContent, prefer);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TargetingClausesApi.UpdateSponsoredProductsTargetingClauses: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateSponsoredProductsTargetingClausesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<SponsoredProductsUpdateSponsoredProductsTargetingClausesResponseContent> response = apiInstance.UpdateSponsoredProductsTargetingClausesWithHttpInfo(amazonAdvertisingAPIClientId, amazonAdvertisingAPIScope, sponsoredProductsUpdateSponsoredProductsTargetingClausesRequestContent, prefer);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TargetingClausesApi.UpdateSponsoredProductsTargetingClausesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **amazonAdvertisingAPIClientId** | **string** | The identifier of a client associated with a \&quot;Login with Amazon\&quot; account. |  |
| **amazonAdvertisingAPIScope** | **string** | The identifier of a profile associated with the advertiser account. Use GET method on Profiles resource to list profiles associated with the access token passed in the HTTP Authorization header. |  |
| **sponsoredProductsUpdateSponsoredProductsTargetingClausesRequestContent** | [**SponsoredProductsUpdateSponsoredProductsTargetingClausesRequestContent**](SponsoredProductsUpdateSponsoredProductsTargetingClausesRequestContent.md) |  |  |
| **prefer** | **string?** | The \&quot;Prefer\&quot; header, as defined in [RFC7240], allows clients to request certain behavior from the service. The service ignores preference values that are either not supported or not known by the service. Either multiple Prefer headers are passed or single one with comma separated values, both forms are equivalent Supported preferences: return&#x3D;representation - return the full object when doing create/update/delete operations instead of ids | [optional]  |

### Return type

[**SponsoredProductsUpdateSponsoredProductsTargetingClausesResponseContent**](SponsoredProductsUpdateSponsoredProductsTargetingClausesResponseContent.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/vnd.spTargetingClause.v3+json
 - **Accept**: application/json, application/vnd.spTargetingClause.v3+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **400** | TargetMutationException 400 response |  -  |
| **401** | UnauthorizedException 401 response |  -  |
| **500** | InternalServerException 500 response |  -  |
| **403** | AccessDeniedException 403 response |  -  |
| **415** | UnsupportedMediaTypeException 415 response |  -  |
| **207** | UpdateSponsoredProductsTargetingClauses 207 response |  * Preference-Applied - Header containing preferences applied while processing API call <br>  |
| **429** | ThrottlingException 429 response |  * Retry-After - Delay in seconds, before the next re-try attempt to the operation is recommended <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

