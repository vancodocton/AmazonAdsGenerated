# Amazon.Advertising.SponsoredProducts.Api.CampaignNegativeTargetingClausesApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateSponsoredProductsCampaignNegativeTargetingClauses**](CampaignNegativeTargetingClausesApi.md#createsponsoredproductscampaignnegativetargetingclauses) | **POST** /sp/campaignNegativeTargets |  |
| [**DeleteSponsoredProductsCampaignNegativeTargetingClauses**](CampaignNegativeTargetingClausesApi.md#deletesponsoredproductscampaignnegativetargetingclauses) | **POST** /sp/campaignNegativeTargets/delete |  |
| [**ListSponsoredProductsCampaignNegativeTargetingClauses**](CampaignNegativeTargetingClausesApi.md#listsponsoredproductscampaignnegativetargetingclauses) | **POST** /sp/campaignNegativeTargets/list |  |
| [**UpdateSponsoredProductsCampaignNegativeTargetingClauses**](CampaignNegativeTargetingClausesApi.md#updatesponsoredproductscampaignnegativetargetingclauses) | **PUT** /sp/campaignNegativeTargets |  |

<a name="createsponsoredproductscampaignnegativetargetingclauses"></a>
# **CreateSponsoredProductsCampaignNegativeTargetingClauses**
> SponsoredProductsCreateSponsoredProductsCampaignNegativeTargetingClausesResponseContent CreateSponsoredProductsCampaignNegativeTargetingClauses (string amazonAdvertisingAPIClientId, string amazonAdvertisingAPIScope, SponsoredProductsCreateSponsoredProductsCampaignNegativeTargetingClausesRequestContent sponsoredProductsCreateSponsoredProductsCampaignNegativeTargetingClausesRequestContent, string? prefer = null)



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
    public class CreateSponsoredProductsCampaignNegativeTargetingClausesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new CampaignNegativeTargetingClausesApi(config);
            var amazonAdvertisingAPIClientId = "amazonAdvertisingAPIClientId_example";  // string | The identifier of a client associated with a \"Login with Amazon\" account.
            var amazonAdvertisingAPIScope = "amazonAdvertisingAPIScope_example";  // string | The identifier of a profile associated with the advertiser account. Use GET method on Profiles resource to list profiles associated with the access token passed in the HTTP Authorization header.
            var sponsoredProductsCreateSponsoredProductsCampaignNegativeTargetingClausesRequestContent = new SponsoredProductsCreateSponsoredProductsCampaignNegativeTargetingClausesRequestContent(); // SponsoredProductsCreateSponsoredProductsCampaignNegativeTargetingClausesRequestContent | 
            var prefer = "prefer_example";  // string? | The \"Prefer\" header, as defined in [RFC7240], allows clients to request certain behavior from the service. The service ignores preference values that are either not supported or not known by the service. Either multiple Prefer headers are passed or single one with comma separated values, both forms are equivalent Supported preferences: return=representation - return the full object when doing create/update/delete operations instead of ids (optional) 

            try
            {
                SponsoredProductsCreateSponsoredProductsCampaignNegativeTargetingClausesResponseContent result = apiInstance.CreateSponsoredProductsCampaignNegativeTargetingClauses(amazonAdvertisingAPIClientId, amazonAdvertisingAPIScope, sponsoredProductsCreateSponsoredProductsCampaignNegativeTargetingClausesRequestContent, prefer);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CampaignNegativeTargetingClausesApi.CreateSponsoredProductsCampaignNegativeTargetingClauses: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateSponsoredProductsCampaignNegativeTargetingClausesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<SponsoredProductsCreateSponsoredProductsCampaignNegativeTargetingClausesResponseContent> response = apiInstance.CreateSponsoredProductsCampaignNegativeTargetingClausesWithHttpInfo(amazonAdvertisingAPIClientId, amazonAdvertisingAPIScope, sponsoredProductsCreateSponsoredProductsCampaignNegativeTargetingClausesRequestContent, prefer);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CampaignNegativeTargetingClausesApi.CreateSponsoredProductsCampaignNegativeTargetingClausesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **amazonAdvertisingAPIClientId** | **string** | The identifier of a client associated with a \&quot;Login with Amazon\&quot; account. |  |
| **amazonAdvertisingAPIScope** | **string** | The identifier of a profile associated with the advertiser account. Use GET method on Profiles resource to list profiles associated with the access token passed in the HTTP Authorization header. |  |
| **sponsoredProductsCreateSponsoredProductsCampaignNegativeTargetingClausesRequestContent** | [**SponsoredProductsCreateSponsoredProductsCampaignNegativeTargetingClausesRequestContent**](SponsoredProductsCreateSponsoredProductsCampaignNegativeTargetingClausesRequestContent.md) |  |  |
| **prefer** | **string?** | The \&quot;Prefer\&quot; header, as defined in [RFC7240], allows clients to request certain behavior from the service. The service ignores preference values that are either not supported or not known by the service. Either multiple Prefer headers are passed or single one with comma separated values, both forms are equivalent Supported preferences: return&#x3D;representation - return the full object when doing create/update/delete operations instead of ids | [optional]  |

### Return type

[**SponsoredProductsCreateSponsoredProductsCampaignNegativeTargetingClausesResponseContent**](SponsoredProductsCreateSponsoredProductsCampaignNegativeTargetingClausesResponseContent.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/vnd.spCampaignNegativeTargetingClause.v3+json
 - **Accept**: application/json, application/vnd.spCampaignNegativeTargetingClause.v3+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **400** | CampaignNegativeTargetsMutationException 400 response |  -  |
| **401** | UnauthorizedException 401 response |  -  |
| **500** | InternalServerException 500 response |  -  |
| **403** | AccessDeniedException 403 response |  -  |
| **415** | UnsupportedMediaTypeException 415 response |  -  |
| **207** | CreateSponsoredProductsCampaignNegativeTargetingClauses 207 response |  * Preference-Applied - Header containing preferences applied while processing API call <br>  |
| **429** | ThrottlingException 429 response |  * Retry-After - Delay in seconds, before the next re-try attempt to the operation is recommended <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletesponsoredproductscampaignnegativetargetingclauses"></a>
# **DeleteSponsoredProductsCampaignNegativeTargetingClauses**
> SponsoredProductsDeleteSponsoredProductsCampaignNegativeTargetingClausesResponseContent DeleteSponsoredProductsCampaignNegativeTargetingClauses (string amazonAdvertisingAPIClientId, string amazonAdvertisingAPIScope, SponsoredProductsDeleteSponsoredProductsCampaignNegativeTargetingClausesRequestContent sponsoredProductsDeleteSponsoredProductsCampaignNegativeTargetingClausesRequestContent)



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
    public class DeleteSponsoredProductsCampaignNegativeTargetingClausesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new CampaignNegativeTargetingClausesApi(config);
            var amazonAdvertisingAPIClientId = "amazonAdvertisingAPIClientId_example";  // string | The identifier of a client associated with a \"Login with Amazon\" account.
            var amazonAdvertisingAPIScope = "amazonAdvertisingAPIScope_example";  // string | The identifier of a profile associated with the advertiser account. Use GET method on Profiles resource to list profiles associated with the access token passed in the HTTP Authorization header.
            var sponsoredProductsDeleteSponsoredProductsCampaignNegativeTargetingClausesRequestContent = new SponsoredProductsDeleteSponsoredProductsCampaignNegativeTargetingClausesRequestContent(); // SponsoredProductsDeleteSponsoredProductsCampaignNegativeTargetingClausesRequestContent | 

            try
            {
                SponsoredProductsDeleteSponsoredProductsCampaignNegativeTargetingClausesResponseContent result = apiInstance.DeleteSponsoredProductsCampaignNegativeTargetingClauses(amazonAdvertisingAPIClientId, amazonAdvertisingAPIScope, sponsoredProductsDeleteSponsoredProductsCampaignNegativeTargetingClausesRequestContent);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CampaignNegativeTargetingClausesApi.DeleteSponsoredProductsCampaignNegativeTargetingClauses: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteSponsoredProductsCampaignNegativeTargetingClausesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<SponsoredProductsDeleteSponsoredProductsCampaignNegativeTargetingClausesResponseContent> response = apiInstance.DeleteSponsoredProductsCampaignNegativeTargetingClausesWithHttpInfo(amazonAdvertisingAPIClientId, amazonAdvertisingAPIScope, sponsoredProductsDeleteSponsoredProductsCampaignNegativeTargetingClausesRequestContent);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CampaignNegativeTargetingClausesApi.DeleteSponsoredProductsCampaignNegativeTargetingClausesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **amazonAdvertisingAPIClientId** | **string** | The identifier of a client associated with a \&quot;Login with Amazon\&quot; account. |  |
| **amazonAdvertisingAPIScope** | **string** | The identifier of a profile associated with the advertiser account. Use GET method on Profiles resource to list profiles associated with the access token passed in the HTTP Authorization header. |  |
| **sponsoredProductsDeleteSponsoredProductsCampaignNegativeTargetingClausesRequestContent** | [**SponsoredProductsDeleteSponsoredProductsCampaignNegativeTargetingClausesRequestContent**](SponsoredProductsDeleteSponsoredProductsCampaignNegativeTargetingClausesRequestContent.md) |  |  |

### Return type

[**SponsoredProductsDeleteSponsoredProductsCampaignNegativeTargetingClausesResponseContent**](SponsoredProductsDeleteSponsoredProductsCampaignNegativeTargetingClausesResponseContent.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/vnd.spCampaignNegativeTargetingClause.v3+json
 - **Accept**: application/json, application/vnd.spCampaignNegativeTargetingClause.v3+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **400** | CampaignNegativeTargetsMutationException 400 response |  -  |
| **401** | UnauthorizedException 401 response |  -  |
| **500** | InternalServerException 500 response |  -  |
| **403** | AccessDeniedException 403 response |  -  |
| **415** | UnsupportedMediaTypeException 415 response |  -  |
| **207** | DeleteSponsoredProductsCampaignNegativeTargetingClauses 207 response |  -  |
| **429** | ThrottlingException 429 response |  * Retry-After - Delay in seconds, before the next re-try attempt to the operation is recommended <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listsponsoredproductscampaignnegativetargetingclauses"></a>
# **ListSponsoredProductsCampaignNegativeTargetingClauses**
> SponsoredProductsListSponsoredProductsCampaignNegativeTargetingClausesResponseContent ListSponsoredProductsCampaignNegativeTargetingClauses (string amazonAdvertisingAPIClientId, string amazonAdvertisingAPIScope, SponsoredProductsListSponsoredProductsCampaignNegativeTargetingClausesRequestContent? sponsoredProductsListSponsoredProductsCampaignNegativeTargetingClausesRequestContent = null)



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
    public class ListSponsoredProductsCampaignNegativeTargetingClausesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new CampaignNegativeTargetingClausesApi(config);
            var amazonAdvertisingAPIClientId = "amazonAdvertisingAPIClientId_example";  // string | The identifier of a client associated with a \"Login with Amazon\" account.
            var amazonAdvertisingAPIScope = "amazonAdvertisingAPIScope_example";  // string | The identifier of a profile associated with the advertiser account. Use GET method on Profiles resource to list profiles associated with the access token passed in the HTTP Authorization header.
            var sponsoredProductsListSponsoredProductsCampaignNegativeTargetingClausesRequestContent = new SponsoredProductsListSponsoredProductsCampaignNegativeTargetingClausesRequestContent?(); // SponsoredProductsListSponsoredProductsCampaignNegativeTargetingClausesRequestContent? |  (optional) 

            try
            {
                SponsoredProductsListSponsoredProductsCampaignNegativeTargetingClausesResponseContent result = apiInstance.ListSponsoredProductsCampaignNegativeTargetingClauses(amazonAdvertisingAPIClientId, amazonAdvertisingAPIScope, sponsoredProductsListSponsoredProductsCampaignNegativeTargetingClausesRequestContent);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CampaignNegativeTargetingClausesApi.ListSponsoredProductsCampaignNegativeTargetingClauses: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListSponsoredProductsCampaignNegativeTargetingClausesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<SponsoredProductsListSponsoredProductsCampaignNegativeTargetingClausesResponseContent> response = apiInstance.ListSponsoredProductsCampaignNegativeTargetingClausesWithHttpInfo(amazonAdvertisingAPIClientId, amazonAdvertisingAPIScope, sponsoredProductsListSponsoredProductsCampaignNegativeTargetingClausesRequestContent);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CampaignNegativeTargetingClausesApi.ListSponsoredProductsCampaignNegativeTargetingClausesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **amazonAdvertisingAPIClientId** | **string** | The identifier of a client associated with a \&quot;Login with Amazon\&quot; account. |  |
| **amazonAdvertisingAPIScope** | **string** | The identifier of a profile associated with the advertiser account. Use GET method on Profiles resource to list profiles associated with the access token passed in the HTTP Authorization header. |  |
| **sponsoredProductsListSponsoredProductsCampaignNegativeTargetingClausesRequestContent** | [**SponsoredProductsListSponsoredProductsCampaignNegativeTargetingClausesRequestContent?**](SponsoredProductsListSponsoredProductsCampaignNegativeTargetingClausesRequestContent?.md) |  | [optional]  |

### Return type

[**SponsoredProductsListSponsoredProductsCampaignNegativeTargetingClausesResponseContent**](SponsoredProductsListSponsoredProductsCampaignNegativeTargetingClausesResponseContent.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/vnd.spCampaignNegativeTargetingClause.v3+json
 - **Accept**: application/vnd.spCampaignNegativeTargetingClause.v3+json, application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | ListSponsoredProductsCampaignNegativeTargetingClauses 200 response |  -  |
| **400** | CampaignNegativeTargetsAccessException 400 response |  -  |
| **401** | UnauthorizedException 401 response |  -  |
| **500** | InternalServerException 500 response |  -  |
| **403** | AccessDeniedException 403 response |  -  |
| **415** | UnsupportedMediaTypeException 415 response |  -  |
| **429** | ThrottlingException 429 response |  * Retry-After - Delay in seconds, before the next re-try attempt to the operation is recommended <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatesponsoredproductscampaignnegativetargetingclauses"></a>
# **UpdateSponsoredProductsCampaignNegativeTargetingClauses**
> SponsoredProductsUpdateSponsoredProductsCampaignNegativeTargetingClausesResponseContent UpdateSponsoredProductsCampaignNegativeTargetingClauses (string amazonAdvertisingAPIClientId, string amazonAdvertisingAPIScope, SponsoredProductsUpdateSponsoredProductsCampaignNegativeTargetingClausesRequestContent sponsoredProductsUpdateSponsoredProductsCampaignNegativeTargetingClausesRequestContent, string? prefer = null)



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
    public class UpdateSponsoredProductsCampaignNegativeTargetingClausesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new CampaignNegativeTargetingClausesApi(config);
            var amazonAdvertisingAPIClientId = "amazonAdvertisingAPIClientId_example";  // string | The identifier of a client associated with a \"Login with Amazon\" account.
            var amazonAdvertisingAPIScope = "amazonAdvertisingAPIScope_example";  // string | The identifier of a profile associated with the advertiser account. Use GET method on Profiles resource to list profiles associated with the access token passed in the HTTP Authorization header.
            var sponsoredProductsUpdateSponsoredProductsCampaignNegativeTargetingClausesRequestContent = new SponsoredProductsUpdateSponsoredProductsCampaignNegativeTargetingClausesRequestContent(); // SponsoredProductsUpdateSponsoredProductsCampaignNegativeTargetingClausesRequestContent | 
            var prefer = "prefer_example";  // string? | The \"Prefer\" header, as defined in [RFC7240], allows clients to request certain behavior from the service. The service ignores preference values that are either not supported or not known by the service. Either multiple Prefer headers are passed or single one with comma separated values, both forms are equivalent Supported preferences: return=representation - return the full object when doing create/update/delete operations instead of ids (optional) 

            try
            {
                SponsoredProductsUpdateSponsoredProductsCampaignNegativeTargetingClausesResponseContent result = apiInstance.UpdateSponsoredProductsCampaignNegativeTargetingClauses(amazonAdvertisingAPIClientId, amazonAdvertisingAPIScope, sponsoredProductsUpdateSponsoredProductsCampaignNegativeTargetingClausesRequestContent, prefer);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CampaignNegativeTargetingClausesApi.UpdateSponsoredProductsCampaignNegativeTargetingClauses: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateSponsoredProductsCampaignNegativeTargetingClausesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<SponsoredProductsUpdateSponsoredProductsCampaignNegativeTargetingClausesResponseContent> response = apiInstance.UpdateSponsoredProductsCampaignNegativeTargetingClausesWithHttpInfo(amazonAdvertisingAPIClientId, amazonAdvertisingAPIScope, sponsoredProductsUpdateSponsoredProductsCampaignNegativeTargetingClausesRequestContent, prefer);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CampaignNegativeTargetingClausesApi.UpdateSponsoredProductsCampaignNegativeTargetingClausesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **amazonAdvertisingAPIClientId** | **string** | The identifier of a client associated with a \&quot;Login with Amazon\&quot; account. |  |
| **amazonAdvertisingAPIScope** | **string** | The identifier of a profile associated with the advertiser account. Use GET method on Profiles resource to list profiles associated with the access token passed in the HTTP Authorization header. |  |
| **sponsoredProductsUpdateSponsoredProductsCampaignNegativeTargetingClausesRequestContent** | [**SponsoredProductsUpdateSponsoredProductsCampaignNegativeTargetingClausesRequestContent**](SponsoredProductsUpdateSponsoredProductsCampaignNegativeTargetingClausesRequestContent.md) |  |  |
| **prefer** | **string?** | The \&quot;Prefer\&quot; header, as defined in [RFC7240], allows clients to request certain behavior from the service. The service ignores preference values that are either not supported or not known by the service. Either multiple Prefer headers are passed or single one with comma separated values, both forms are equivalent Supported preferences: return&#x3D;representation - return the full object when doing create/update/delete operations instead of ids | [optional]  |

### Return type

[**SponsoredProductsUpdateSponsoredProductsCampaignNegativeTargetingClausesResponseContent**](SponsoredProductsUpdateSponsoredProductsCampaignNegativeTargetingClausesResponseContent.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/vnd.spCampaignNegativeTargetingClause.v3+json
 - **Accept**: application/json, application/vnd.spCampaignNegativeTargetingClause.v3+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **400** | CampaignNegativeTargetsMutationException 400 response |  -  |
| **401** | UnauthorizedException 401 response |  -  |
| **500** | InternalServerException 500 response |  -  |
| **403** | AccessDeniedException 403 response |  -  |
| **415** | UnsupportedMediaTypeException 415 response |  -  |
| **207** | UpdateSponsoredProductsCampaignNegativeTargetingClauses 207 response |  * Preference-Applied - Header containing preferences applied while processing API call <br>  |
| **429** | ThrottlingException 429 response |  * Retry-After - Delay in seconds, before the next re-try attempt to the operation is recommended <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

