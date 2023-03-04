# Amazon.Advertising.SponsoredProducts.Api.AdGroupsApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateSponsoredProductsAdGroups**](AdGroupsApi.md#createsponsoredproductsadgroups) | **POST** /sp/adGroups |  |
| [**DeleteSponsoredProductsAdGroups**](AdGroupsApi.md#deletesponsoredproductsadgroups) | **POST** /sp/adGroups/delete |  |
| [**ListSponsoredProductsAdGroups**](AdGroupsApi.md#listsponsoredproductsadgroups) | **POST** /sp/adGroups/list |  |
| [**UpdateSponsoredProductsAdGroups**](AdGroupsApi.md#updatesponsoredproductsadgroups) | **PUT** /sp/adGroups |  |

<a name="createsponsoredproductsadgroups"></a>
# **CreateSponsoredProductsAdGroups**
> SponsoredProductsCreateSponsoredProductsAdGroupsResponseContent CreateSponsoredProductsAdGroups (string amazonAdvertisingAPIClientId, string amazonAdvertisingAPIScope, SponsoredProductsCreateSponsoredProductsAdGroupsRequestContent sponsoredProductsCreateSponsoredProductsAdGroupsRequestContent, string? prefer = null)



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
    public class CreateSponsoredProductsAdGroupsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AdGroupsApi(config);
            var amazonAdvertisingAPIClientId = "amazonAdvertisingAPIClientId_example";  // string | The identifier of a client associated with a \"Login with Amazon\" account.
            var amazonAdvertisingAPIScope = "amazonAdvertisingAPIScope_example";  // string | The identifier of a profile associated with the advertiser account. Use GET method on Profiles resource to list profiles associated with the access token passed in the HTTP Authorization header.
            var sponsoredProductsCreateSponsoredProductsAdGroupsRequestContent = new SponsoredProductsCreateSponsoredProductsAdGroupsRequestContent(); // SponsoredProductsCreateSponsoredProductsAdGroupsRequestContent | 
            var prefer = "prefer_example";  // string? | The \"Prefer\" header, as defined in [RFC7240], allows clients to request certain behavior from the service. The service ignores preference values that are either not supported or not known by the service. Either multiple Prefer headers are passed or single one with comma separated values, both forms are equivalent Supported preferences: return=representation - return the full object when doing create/update/delete operations instead of ids (optional) 

            try
            {
                SponsoredProductsCreateSponsoredProductsAdGroupsResponseContent result = apiInstance.CreateSponsoredProductsAdGroups(amazonAdvertisingAPIClientId, amazonAdvertisingAPIScope, sponsoredProductsCreateSponsoredProductsAdGroupsRequestContent, prefer);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AdGroupsApi.CreateSponsoredProductsAdGroups: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateSponsoredProductsAdGroupsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<SponsoredProductsCreateSponsoredProductsAdGroupsResponseContent> response = apiInstance.CreateSponsoredProductsAdGroupsWithHttpInfo(amazonAdvertisingAPIClientId, amazonAdvertisingAPIScope, sponsoredProductsCreateSponsoredProductsAdGroupsRequestContent, prefer);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AdGroupsApi.CreateSponsoredProductsAdGroupsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **amazonAdvertisingAPIClientId** | **string** | The identifier of a client associated with a \&quot;Login with Amazon\&quot; account. |  |
| **amazonAdvertisingAPIScope** | **string** | The identifier of a profile associated with the advertiser account. Use GET method on Profiles resource to list profiles associated with the access token passed in the HTTP Authorization header. |  |
| **sponsoredProductsCreateSponsoredProductsAdGroupsRequestContent** | [**SponsoredProductsCreateSponsoredProductsAdGroupsRequestContent**](SponsoredProductsCreateSponsoredProductsAdGroupsRequestContent.md) |  |  |
| **prefer** | **string?** | The \&quot;Prefer\&quot; header, as defined in [RFC7240], allows clients to request certain behavior from the service. The service ignores preference values that are either not supported or not known by the service. Either multiple Prefer headers are passed or single one with comma separated values, both forms are equivalent Supported preferences: return&#x3D;representation - return the full object when doing create/update/delete operations instead of ids | [optional]  |

### Return type

[**SponsoredProductsCreateSponsoredProductsAdGroupsResponseContent**](SponsoredProductsCreateSponsoredProductsAdGroupsResponseContent.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/vnd.spAdGroup.v3+json
 - **Accept**: application/json, application/vnd.spAdGroup.v3+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **400** | AdGroupMutationException 400 response |  -  |
| **401** | UnauthorizedException 401 response |  -  |
| **500** | InternalServerException 500 response |  -  |
| **403** | AccessDeniedException 403 response |  -  |
| **415** | UnsupportedMediaTypeException 415 response |  -  |
| **207** | CreateSponsoredProductsAdGroups 207 response |  * Preference-Applied - Header containing preferences applied while processing API call <br>  |
| **429** | ThrottlingException 429 response |  * Retry-After - Delay in seconds, before the next re-try attempt to the operation is recommended <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletesponsoredproductsadgroups"></a>
# **DeleteSponsoredProductsAdGroups**
> SponsoredProductsDeleteSponsoredProductsAdGroupsResponseContent DeleteSponsoredProductsAdGroups (string amazonAdvertisingAPIClientId, string amazonAdvertisingAPIScope, SponsoredProductsDeleteSponsoredProductsAdGroupsRequestContent sponsoredProductsDeleteSponsoredProductsAdGroupsRequestContent)



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
    public class DeleteSponsoredProductsAdGroupsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AdGroupsApi(config);
            var amazonAdvertisingAPIClientId = "amazonAdvertisingAPIClientId_example";  // string | The identifier of a client associated with a \"Login with Amazon\" account.
            var amazonAdvertisingAPIScope = "amazonAdvertisingAPIScope_example";  // string | The identifier of a profile associated with the advertiser account. Use GET method on Profiles resource to list profiles associated with the access token passed in the HTTP Authorization header.
            var sponsoredProductsDeleteSponsoredProductsAdGroupsRequestContent = new SponsoredProductsDeleteSponsoredProductsAdGroupsRequestContent(); // SponsoredProductsDeleteSponsoredProductsAdGroupsRequestContent | 

            try
            {
                SponsoredProductsDeleteSponsoredProductsAdGroupsResponseContent result = apiInstance.DeleteSponsoredProductsAdGroups(amazonAdvertisingAPIClientId, amazonAdvertisingAPIScope, sponsoredProductsDeleteSponsoredProductsAdGroupsRequestContent);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AdGroupsApi.DeleteSponsoredProductsAdGroups: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteSponsoredProductsAdGroupsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<SponsoredProductsDeleteSponsoredProductsAdGroupsResponseContent> response = apiInstance.DeleteSponsoredProductsAdGroupsWithHttpInfo(amazonAdvertisingAPIClientId, amazonAdvertisingAPIScope, sponsoredProductsDeleteSponsoredProductsAdGroupsRequestContent);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AdGroupsApi.DeleteSponsoredProductsAdGroupsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **amazonAdvertisingAPIClientId** | **string** | The identifier of a client associated with a \&quot;Login with Amazon\&quot; account. |  |
| **amazonAdvertisingAPIScope** | **string** | The identifier of a profile associated with the advertiser account. Use GET method on Profiles resource to list profiles associated with the access token passed in the HTTP Authorization header. |  |
| **sponsoredProductsDeleteSponsoredProductsAdGroupsRequestContent** | [**SponsoredProductsDeleteSponsoredProductsAdGroupsRequestContent**](SponsoredProductsDeleteSponsoredProductsAdGroupsRequestContent.md) |  |  |

### Return type

[**SponsoredProductsDeleteSponsoredProductsAdGroupsResponseContent**](SponsoredProductsDeleteSponsoredProductsAdGroupsResponseContent.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/vnd.spAdGroup.v3+json
 - **Accept**: application/json, application/vnd.spAdGroup.v3+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **400** | AdGroupMutationException 400 response |  -  |
| **401** | UnauthorizedException 401 response |  -  |
| **500** | InternalServerException 500 response |  -  |
| **403** | AccessDeniedException 403 response |  -  |
| **415** | UnsupportedMediaTypeException 415 response |  -  |
| **207** | DeleteSponsoredProductsAdGroups 207 response |  -  |
| **429** | ThrottlingException 429 response |  * Retry-After - Delay in seconds, before the next re-try attempt to the operation is recommended <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listsponsoredproductsadgroups"></a>
# **ListSponsoredProductsAdGroups**
> SponsoredProductsListSponsoredProductsAdGroupsResponseContent ListSponsoredProductsAdGroups (string amazonAdvertisingAPIClientId, string amazonAdvertisingAPIScope, SponsoredProductsListSponsoredProductsAdGroupsRequestContent? sponsoredProductsListSponsoredProductsAdGroupsRequestContent = null)



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
    public class ListSponsoredProductsAdGroupsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AdGroupsApi(config);
            var amazonAdvertisingAPIClientId = "amazonAdvertisingAPIClientId_example";  // string | The identifier of a client associated with a \"Login with Amazon\" account.
            var amazonAdvertisingAPIScope = "amazonAdvertisingAPIScope_example";  // string | The identifier of a profile associated with the advertiser account. Use GET method on Profiles resource to list profiles associated with the access token passed in the HTTP Authorization header.
            var sponsoredProductsListSponsoredProductsAdGroupsRequestContent = new SponsoredProductsListSponsoredProductsAdGroupsRequestContent?(); // SponsoredProductsListSponsoredProductsAdGroupsRequestContent? |  (optional) 

            try
            {
                SponsoredProductsListSponsoredProductsAdGroupsResponseContent result = apiInstance.ListSponsoredProductsAdGroups(amazonAdvertisingAPIClientId, amazonAdvertisingAPIScope, sponsoredProductsListSponsoredProductsAdGroupsRequestContent);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AdGroupsApi.ListSponsoredProductsAdGroups: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListSponsoredProductsAdGroupsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<SponsoredProductsListSponsoredProductsAdGroupsResponseContent> response = apiInstance.ListSponsoredProductsAdGroupsWithHttpInfo(amazonAdvertisingAPIClientId, amazonAdvertisingAPIScope, sponsoredProductsListSponsoredProductsAdGroupsRequestContent);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AdGroupsApi.ListSponsoredProductsAdGroupsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **amazonAdvertisingAPIClientId** | **string** | The identifier of a client associated with a \&quot;Login with Amazon\&quot; account. |  |
| **amazonAdvertisingAPIScope** | **string** | The identifier of a profile associated with the advertiser account. Use GET method on Profiles resource to list profiles associated with the access token passed in the HTTP Authorization header. |  |
| **sponsoredProductsListSponsoredProductsAdGroupsRequestContent** | [**SponsoredProductsListSponsoredProductsAdGroupsRequestContent?**](SponsoredProductsListSponsoredProductsAdGroupsRequestContent?.md) |  | [optional]  |

### Return type

[**SponsoredProductsListSponsoredProductsAdGroupsResponseContent**](SponsoredProductsListSponsoredProductsAdGroupsResponseContent.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/vnd.spAdGroup.v3+json
 - **Accept**: application/vnd.spAdGroup.v3+json, application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | ListSponsoredProductsAdGroups 200 response |  -  |
| **400** | AdGroupAccessException 400 response |  -  |
| **401** | UnauthorizedException 401 response |  -  |
| **500** | InternalServerException 500 response |  -  |
| **403** | AccessDeniedException 403 response |  -  |
| **415** | UnsupportedMediaTypeException 415 response |  -  |
| **429** | ThrottlingException 429 response |  * Retry-After - Delay in seconds, before the next re-try attempt to the operation is recommended <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatesponsoredproductsadgroups"></a>
# **UpdateSponsoredProductsAdGroups**
> SponsoredProductsUpdateSponsoredProductsAdGroupsResponseContent UpdateSponsoredProductsAdGroups (string amazonAdvertisingAPIClientId, string amazonAdvertisingAPIScope, SponsoredProductsUpdateSponsoredProductsAdGroupsRequestContent sponsoredProductsUpdateSponsoredProductsAdGroupsRequestContent, string? prefer = null)



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
    public class UpdateSponsoredProductsAdGroupsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AdGroupsApi(config);
            var amazonAdvertisingAPIClientId = "amazonAdvertisingAPIClientId_example";  // string | The identifier of a client associated with a \"Login with Amazon\" account.
            var amazonAdvertisingAPIScope = "amazonAdvertisingAPIScope_example";  // string | The identifier of a profile associated with the advertiser account. Use GET method on Profiles resource to list profiles associated with the access token passed in the HTTP Authorization header.
            var sponsoredProductsUpdateSponsoredProductsAdGroupsRequestContent = new SponsoredProductsUpdateSponsoredProductsAdGroupsRequestContent(); // SponsoredProductsUpdateSponsoredProductsAdGroupsRequestContent | 
            var prefer = "prefer_example";  // string? | The \"Prefer\" header, as defined in [RFC7240], allows clients to request certain behavior from the service. The service ignores preference values that are either not supported or not known by the service. Either multiple Prefer headers are passed or single one with comma separated values, both forms are equivalent Supported preferences: return=representation - return the full object when doing create/update/delete operations instead of ids (optional) 

            try
            {
                SponsoredProductsUpdateSponsoredProductsAdGroupsResponseContent result = apiInstance.UpdateSponsoredProductsAdGroups(amazonAdvertisingAPIClientId, amazonAdvertisingAPIScope, sponsoredProductsUpdateSponsoredProductsAdGroupsRequestContent, prefer);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AdGroupsApi.UpdateSponsoredProductsAdGroups: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateSponsoredProductsAdGroupsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<SponsoredProductsUpdateSponsoredProductsAdGroupsResponseContent> response = apiInstance.UpdateSponsoredProductsAdGroupsWithHttpInfo(amazonAdvertisingAPIClientId, amazonAdvertisingAPIScope, sponsoredProductsUpdateSponsoredProductsAdGroupsRequestContent, prefer);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AdGroupsApi.UpdateSponsoredProductsAdGroupsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **amazonAdvertisingAPIClientId** | **string** | The identifier of a client associated with a \&quot;Login with Amazon\&quot; account. |  |
| **amazonAdvertisingAPIScope** | **string** | The identifier of a profile associated with the advertiser account. Use GET method on Profiles resource to list profiles associated with the access token passed in the HTTP Authorization header. |  |
| **sponsoredProductsUpdateSponsoredProductsAdGroupsRequestContent** | [**SponsoredProductsUpdateSponsoredProductsAdGroupsRequestContent**](SponsoredProductsUpdateSponsoredProductsAdGroupsRequestContent.md) |  |  |
| **prefer** | **string?** | The \&quot;Prefer\&quot; header, as defined in [RFC7240], allows clients to request certain behavior from the service. The service ignores preference values that are either not supported or not known by the service. Either multiple Prefer headers are passed or single one with comma separated values, both forms are equivalent Supported preferences: return&#x3D;representation - return the full object when doing create/update/delete operations instead of ids | [optional]  |

### Return type

[**SponsoredProductsUpdateSponsoredProductsAdGroupsResponseContent**](SponsoredProductsUpdateSponsoredProductsAdGroupsResponseContent.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/vnd.spAdGroup.v3+json
 - **Accept**: application/json, application/vnd.spAdGroup.v3+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **400** | AdGroupMutationException 400 response |  -  |
| **401** | UnauthorizedException 401 response |  -  |
| **500** | InternalServerException 500 response |  -  |
| **403** | AccessDeniedException 403 response |  -  |
| **415** | UnsupportedMediaTypeException 415 response |  -  |
| **207** | UpdateSponsoredProductsAdGroups 207 response |  * Preference-Applied - Header containing preferences applied while processing API call <br>  |
| **429** | ThrottlingException 429 response |  * Retry-After - Delay in seconds, before the next re-try attempt to the operation is recommended <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

