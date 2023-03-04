# Amazon.Advertising.SponsoredProducts.Api.NegativeTargetingClausesApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateSponsoredProductsNegativeTargetingClauses**](NegativeTargetingClausesApi.md#createsponsoredproductsnegativetargetingclauses) | **POST** /sp/negativeTargets |  |
| [**DeleteSponsoredProductsNegativeTargetingClauses**](NegativeTargetingClausesApi.md#deletesponsoredproductsnegativetargetingclauses) | **POST** /sp/negativeTargets/delete |  |
| [**ListSponsoredProductsNegativeTargetingClauses**](NegativeTargetingClausesApi.md#listsponsoredproductsnegativetargetingclauses) | **POST** /sp/negativeTargets/list |  |
| [**UpdateSponsoredProductsNegativeTargetingClauses**](NegativeTargetingClausesApi.md#updatesponsoredproductsnegativetargetingclauses) | **PUT** /sp/negativeTargets |  |

<a name="createsponsoredproductsnegativetargetingclauses"></a>
# **CreateSponsoredProductsNegativeTargetingClauses**
> SponsoredProductsCreateSponsoredProductsNegativeTargetingClausesResponseContent CreateSponsoredProductsNegativeTargetingClauses (string amazonAdvertisingAPIClientId, string amazonAdvertisingAPIScope, SponsoredProductsCreateSponsoredProductsNegativeTargetingClausesRequestContent sponsoredProductsCreateSponsoredProductsNegativeTargetingClausesRequestContent, string? prefer = null)



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
    public class CreateSponsoredProductsNegativeTargetingClausesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new NegativeTargetingClausesApi(config);
            var amazonAdvertisingAPIClientId = "amazonAdvertisingAPIClientId_example";  // string | The identifier of a client associated with a \"Login with Amazon\" account.
            var amazonAdvertisingAPIScope = "amazonAdvertisingAPIScope_example";  // string | The identifier of a profile associated with the advertiser account. Use GET method on Profiles resource to list profiles associated with the access token passed in the HTTP Authorization header.
            var sponsoredProductsCreateSponsoredProductsNegativeTargetingClausesRequestContent = new SponsoredProductsCreateSponsoredProductsNegativeTargetingClausesRequestContent(); // SponsoredProductsCreateSponsoredProductsNegativeTargetingClausesRequestContent | 
            var prefer = "prefer_example";  // string? | The \"Prefer\" header, as defined in [RFC7240], allows clients to request certain behavior from the service. The service ignores preference values that are either not supported or not known by the service. Either multiple Prefer headers are passed or single one with comma separated values, both forms are equivalent Supported preferences: return=representation - return the full object when doing create/update/delete operations instead of ids (optional) 

            try
            {
                SponsoredProductsCreateSponsoredProductsNegativeTargetingClausesResponseContent result = apiInstance.CreateSponsoredProductsNegativeTargetingClauses(amazonAdvertisingAPIClientId, amazonAdvertisingAPIScope, sponsoredProductsCreateSponsoredProductsNegativeTargetingClausesRequestContent, prefer);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NegativeTargetingClausesApi.CreateSponsoredProductsNegativeTargetingClauses: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateSponsoredProductsNegativeTargetingClausesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<SponsoredProductsCreateSponsoredProductsNegativeTargetingClausesResponseContent> response = apiInstance.CreateSponsoredProductsNegativeTargetingClausesWithHttpInfo(amazonAdvertisingAPIClientId, amazonAdvertisingAPIScope, sponsoredProductsCreateSponsoredProductsNegativeTargetingClausesRequestContent, prefer);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling NegativeTargetingClausesApi.CreateSponsoredProductsNegativeTargetingClausesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **amazonAdvertisingAPIClientId** | **string** | The identifier of a client associated with a \&quot;Login with Amazon\&quot; account. |  |
| **amazonAdvertisingAPIScope** | **string** | The identifier of a profile associated with the advertiser account. Use GET method on Profiles resource to list profiles associated with the access token passed in the HTTP Authorization header. |  |
| **sponsoredProductsCreateSponsoredProductsNegativeTargetingClausesRequestContent** | [**SponsoredProductsCreateSponsoredProductsNegativeTargetingClausesRequestContent**](SponsoredProductsCreateSponsoredProductsNegativeTargetingClausesRequestContent.md) |  |  |
| **prefer** | **string?** | The \&quot;Prefer\&quot; header, as defined in [RFC7240], allows clients to request certain behavior from the service. The service ignores preference values that are either not supported or not known by the service. Either multiple Prefer headers are passed or single one with comma separated values, both forms are equivalent Supported preferences: return&#x3D;representation - return the full object when doing create/update/delete operations instead of ids | [optional]  |

### Return type

[**SponsoredProductsCreateSponsoredProductsNegativeTargetingClausesResponseContent**](SponsoredProductsCreateSponsoredProductsNegativeTargetingClausesResponseContent.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/vnd.spNegativeTargetingClause.v3+json
 - **Accept**: application/json, application/vnd.spNegativeTargetingClause.v3+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **400** | NegativeTargetMutationException 400 response |  -  |
| **401** | UnauthorizedException 401 response |  -  |
| **500** | InternalServerException 500 response |  -  |
| **403** | AccessDeniedException 403 response |  -  |
| **415** | UnsupportedMediaTypeException 415 response |  -  |
| **207** | CreateSponsoredProductsNegativeTargetingClauses 207 response |  * Preference-Applied - Header containing preferences applied while processing API call <br>  |
| **429** | ThrottlingException 429 response |  * Retry-After - Delay in seconds, before the next re-try attempt to the operation is recommended <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletesponsoredproductsnegativetargetingclauses"></a>
# **DeleteSponsoredProductsNegativeTargetingClauses**
> SponsoredProductsDeleteSponsoredProductsNegativeTargetingClausesResponseContent DeleteSponsoredProductsNegativeTargetingClauses (string amazonAdvertisingAPIClientId, string amazonAdvertisingAPIScope, SponsoredProductsDeleteSponsoredProductsNegativeTargetingClausesRequestContent sponsoredProductsDeleteSponsoredProductsNegativeTargetingClausesRequestContent)



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
    public class DeleteSponsoredProductsNegativeTargetingClausesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new NegativeTargetingClausesApi(config);
            var amazonAdvertisingAPIClientId = "amazonAdvertisingAPIClientId_example";  // string | The identifier of a client associated with a \"Login with Amazon\" account.
            var amazonAdvertisingAPIScope = "amazonAdvertisingAPIScope_example";  // string | The identifier of a profile associated with the advertiser account. Use GET method on Profiles resource to list profiles associated with the access token passed in the HTTP Authorization header.
            var sponsoredProductsDeleteSponsoredProductsNegativeTargetingClausesRequestContent = new SponsoredProductsDeleteSponsoredProductsNegativeTargetingClausesRequestContent(); // SponsoredProductsDeleteSponsoredProductsNegativeTargetingClausesRequestContent | 

            try
            {
                SponsoredProductsDeleteSponsoredProductsNegativeTargetingClausesResponseContent result = apiInstance.DeleteSponsoredProductsNegativeTargetingClauses(amazonAdvertisingAPIClientId, amazonAdvertisingAPIScope, sponsoredProductsDeleteSponsoredProductsNegativeTargetingClausesRequestContent);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NegativeTargetingClausesApi.DeleteSponsoredProductsNegativeTargetingClauses: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteSponsoredProductsNegativeTargetingClausesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<SponsoredProductsDeleteSponsoredProductsNegativeTargetingClausesResponseContent> response = apiInstance.DeleteSponsoredProductsNegativeTargetingClausesWithHttpInfo(amazonAdvertisingAPIClientId, amazonAdvertisingAPIScope, sponsoredProductsDeleteSponsoredProductsNegativeTargetingClausesRequestContent);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling NegativeTargetingClausesApi.DeleteSponsoredProductsNegativeTargetingClausesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **amazonAdvertisingAPIClientId** | **string** | The identifier of a client associated with a \&quot;Login with Amazon\&quot; account. |  |
| **amazonAdvertisingAPIScope** | **string** | The identifier of a profile associated with the advertiser account. Use GET method on Profiles resource to list profiles associated with the access token passed in the HTTP Authorization header. |  |
| **sponsoredProductsDeleteSponsoredProductsNegativeTargetingClausesRequestContent** | [**SponsoredProductsDeleteSponsoredProductsNegativeTargetingClausesRequestContent**](SponsoredProductsDeleteSponsoredProductsNegativeTargetingClausesRequestContent.md) |  |  |

### Return type

[**SponsoredProductsDeleteSponsoredProductsNegativeTargetingClausesResponseContent**](SponsoredProductsDeleteSponsoredProductsNegativeTargetingClausesResponseContent.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/vnd.spNegativeTargetingClause.v3+json
 - **Accept**: application/json, application/vnd.spNegativeTargetingClause.v3+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **400** | NegativeTargetMutationException 400 response |  -  |
| **401** | UnauthorizedException 401 response |  -  |
| **500** | InternalServerException 500 response |  -  |
| **403** | AccessDeniedException 403 response |  -  |
| **415** | UnsupportedMediaTypeException 415 response |  -  |
| **207** | DeleteSponsoredProductsNegativeTargetingClauses 207 response |  -  |
| **429** | ThrottlingException 429 response |  * Retry-After - Delay in seconds, before the next re-try attempt to the operation is recommended <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listsponsoredproductsnegativetargetingclauses"></a>
# **ListSponsoredProductsNegativeTargetingClauses**
> SponsoredProductsListSponsoredProductsNegativeTargetingClausesResponseContent ListSponsoredProductsNegativeTargetingClauses (string amazonAdvertisingAPIClientId, string amazonAdvertisingAPIScope, SponsoredProductsListSponsoredProductsNegativeTargetingClausesRequestContent? sponsoredProductsListSponsoredProductsNegativeTargetingClausesRequestContent = null)



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
    public class ListSponsoredProductsNegativeTargetingClausesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new NegativeTargetingClausesApi(config);
            var amazonAdvertisingAPIClientId = "amazonAdvertisingAPIClientId_example";  // string | The identifier of a client associated with a \"Login with Amazon\" account.
            var amazonAdvertisingAPIScope = "amazonAdvertisingAPIScope_example";  // string | The identifier of a profile associated with the advertiser account. Use GET method on Profiles resource to list profiles associated with the access token passed in the HTTP Authorization header.
            var sponsoredProductsListSponsoredProductsNegativeTargetingClausesRequestContent = new SponsoredProductsListSponsoredProductsNegativeTargetingClausesRequestContent?(); // SponsoredProductsListSponsoredProductsNegativeTargetingClausesRequestContent? |  (optional) 

            try
            {
                SponsoredProductsListSponsoredProductsNegativeTargetingClausesResponseContent result = apiInstance.ListSponsoredProductsNegativeTargetingClauses(amazonAdvertisingAPIClientId, amazonAdvertisingAPIScope, sponsoredProductsListSponsoredProductsNegativeTargetingClausesRequestContent);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NegativeTargetingClausesApi.ListSponsoredProductsNegativeTargetingClauses: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListSponsoredProductsNegativeTargetingClausesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<SponsoredProductsListSponsoredProductsNegativeTargetingClausesResponseContent> response = apiInstance.ListSponsoredProductsNegativeTargetingClausesWithHttpInfo(amazonAdvertisingAPIClientId, amazonAdvertisingAPIScope, sponsoredProductsListSponsoredProductsNegativeTargetingClausesRequestContent);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling NegativeTargetingClausesApi.ListSponsoredProductsNegativeTargetingClausesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **amazonAdvertisingAPIClientId** | **string** | The identifier of a client associated with a \&quot;Login with Amazon\&quot; account. |  |
| **amazonAdvertisingAPIScope** | **string** | The identifier of a profile associated with the advertiser account. Use GET method on Profiles resource to list profiles associated with the access token passed in the HTTP Authorization header. |  |
| **sponsoredProductsListSponsoredProductsNegativeTargetingClausesRequestContent** | [**SponsoredProductsListSponsoredProductsNegativeTargetingClausesRequestContent?**](SponsoredProductsListSponsoredProductsNegativeTargetingClausesRequestContent?.md) |  | [optional]  |

### Return type

[**SponsoredProductsListSponsoredProductsNegativeTargetingClausesResponseContent**](SponsoredProductsListSponsoredProductsNegativeTargetingClausesResponseContent.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/vnd.spNegativeTargetingClause.v3+json
 - **Accept**: application/vnd.spNegativeTargetingClause.v3+json, application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | ListSponsoredProductsNegativeTargetingClauses 200 response |  -  |
| **400** | NegativeTargetAccessException 400 response |  -  |
| **401** | UnauthorizedException 401 response |  -  |
| **500** | InternalServerException 500 response |  -  |
| **403** | AccessDeniedException 403 response |  -  |
| **415** | UnsupportedMediaTypeException 415 response |  -  |
| **429** | ThrottlingException 429 response |  * Retry-After - Delay in seconds, before the next re-try attempt to the operation is recommended <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatesponsoredproductsnegativetargetingclauses"></a>
# **UpdateSponsoredProductsNegativeTargetingClauses**
> SponsoredProductsUpdateSponsoredProductsNegativeTargetingClausesResponseContent UpdateSponsoredProductsNegativeTargetingClauses (string amazonAdvertisingAPIClientId, string amazonAdvertisingAPIScope, SponsoredProductsUpdateSponsoredProductsNegativeTargetingClausesRequestContent sponsoredProductsUpdateSponsoredProductsNegativeTargetingClausesRequestContent, string? prefer = null)



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
    public class UpdateSponsoredProductsNegativeTargetingClausesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new NegativeTargetingClausesApi(config);
            var amazonAdvertisingAPIClientId = "amazonAdvertisingAPIClientId_example";  // string | The identifier of a client associated with a \"Login with Amazon\" account.
            var amazonAdvertisingAPIScope = "amazonAdvertisingAPIScope_example";  // string | The identifier of a profile associated with the advertiser account. Use GET method on Profiles resource to list profiles associated with the access token passed in the HTTP Authorization header.
            var sponsoredProductsUpdateSponsoredProductsNegativeTargetingClausesRequestContent = new SponsoredProductsUpdateSponsoredProductsNegativeTargetingClausesRequestContent(); // SponsoredProductsUpdateSponsoredProductsNegativeTargetingClausesRequestContent | 
            var prefer = "prefer_example";  // string? | The \"Prefer\" header, as defined in [RFC7240], allows clients to request certain behavior from the service. The service ignores preference values that are either not supported or not known by the service. Either multiple Prefer headers are passed or single one with comma separated values, both forms are equivalent Supported preferences: return=representation - return the full object when doing create/update/delete operations instead of ids (optional) 

            try
            {
                SponsoredProductsUpdateSponsoredProductsNegativeTargetingClausesResponseContent result = apiInstance.UpdateSponsoredProductsNegativeTargetingClauses(amazonAdvertisingAPIClientId, amazonAdvertisingAPIScope, sponsoredProductsUpdateSponsoredProductsNegativeTargetingClausesRequestContent, prefer);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NegativeTargetingClausesApi.UpdateSponsoredProductsNegativeTargetingClauses: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateSponsoredProductsNegativeTargetingClausesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<SponsoredProductsUpdateSponsoredProductsNegativeTargetingClausesResponseContent> response = apiInstance.UpdateSponsoredProductsNegativeTargetingClausesWithHttpInfo(amazonAdvertisingAPIClientId, amazonAdvertisingAPIScope, sponsoredProductsUpdateSponsoredProductsNegativeTargetingClausesRequestContent, prefer);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling NegativeTargetingClausesApi.UpdateSponsoredProductsNegativeTargetingClausesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **amazonAdvertisingAPIClientId** | **string** | The identifier of a client associated with a \&quot;Login with Amazon\&quot; account. |  |
| **amazonAdvertisingAPIScope** | **string** | The identifier of a profile associated with the advertiser account. Use GET method on Profiles resource to list profiles associated with the access token passed in the HTTP Authorization header. |  |
| **sponsoredProductsUpdateSponsoredProductsNegativeTargetingClausesRequestContent** | [**SponsoredProductsUpdateSponsoredProductsNegativeTargetingClausesRequestContent**](SponsoredProductsUpdateSponsoredProductsNegativeTargetingClausesRequestContent.md) |  |  |
| **prefer** | **string?** | The \&quot;Prefer\&quot; header, as defined in [RFC7240], allows clients to request certain behavior from the service. The service ignores preference values that are either not supported or not known by the service. Either multiple Prefer headers are passed or single one with comma separated values, both forms are equivalent Supported preferences: return&#x3D;representation - return the full object when doing create/update/delete operations instead of ids | [optional]  |

### Return type

[**SponsoredProductsUpdateSponsoredProductsNegativeTargetingClausesResponseContent**](SponsoredProductsUpdateSponsoredProductsNegativeTargetingClausesResponseContent.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/vnd.spNegativeTargetingClause.v3+json
 - **Accept**: application/json, application/vnd.spNegativeTargetingClause.v3+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **400** | NegativeTargetMutationException 400 response |  -  |
| **401** | UnauthorizedException 401 response |  -  |
| **500** | InternalServerException 500 response |  -  |
| **403** | AccessDeniedException 403 response |  -  |
| **415** | UnsupportedMediaTypeException 415 response |  -  |
| **207** | UpdateSponsoredProductsNegativeTargetingClauses 207 response |  * Preference-Applied - Header containing preferences applied while processing API call <br>  |
| **429** | ThrottlingException 429 response |  * Retry-After - Delay in seconds, before the next re-try attempt to the operation is recommended <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

