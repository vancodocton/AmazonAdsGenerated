# Amazon.Advertising.SponsoredProducts.Api.CampaignsApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateSponsoredProductsCampaigns**](CampaignsApi.md#createsponsoredproductscampaigns) | **POST** /sp/campaigns |  |
| [**DeleteSponsoredProductsCampaigns**](CampaignsApi.md#deletesponsoredproductscampaigns) | **POST** /sp/campaigns/delete |  |
| [**ListSponsoredProductsCampaigns**](CampaignsApi.md#listsponsoredproductscampaigns) | **POST** /sp/campaigns/list |  |
| [**UpdateSponsoredProductsCampaigns**](CampaignsApi.md#updatesponsoredproductscampaigns) | **PUT** /sp/campaigns |  |

<a name="createsponsoredproductscampaigns"></a>
# **CreateSponsoredProductsCampaigns**
> SponsoredProductsCreateSponsoredProductsCampaignsResponseContent CreateSponsoredProductsCampaigns (string amazonAdvertisingAPIClientId, string amazonAdvertisingAPIScope, SponsoredProductsCreateSponsoredProductsCampaignsRequestContent sponsoredProductsCreateSponsoredProductsCampaignsRequestContent, string? prefer = null)



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
    public class CreateSponsoredProductsCampaignsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new CampaignsApi(config);
            var amazonAdvertisingAPIClientId = "amazonAdvertisingAPIClientId_example";  // string | The identifier of a client associated with a \"Login with Amazon\" account.
            var amazonAdvertisingAPIScope = "amazonAdvertisingAPIScope_example";  // string | The identifier of a profile associated with the advertiser account. Use GET method on Profiles resource to list profiles associated with the access token passed in the HTTP Authorization header.
            var sponsoredProductsCreateSponsoredProductsCampaignsRequestContent = new SponsoredProductsCreateSponsoredProductsCampaignsRequestContent(); // SponsoredProductsCreateSponsoredProductsCampaignsRequestContent | 
            var prefer = "prefer_example";  // string? | The \"Prefer\" header, as defined in [RFC7240], allows clients to request certain behavior from the service. The service ignores preference values that are either not supported or not known by the service. Either multiple Prefer headers are passed or single one with comma separated values, both forms are equivalent Supported preferences: return=representation - return the full object when doing create/update/delete operations instead of ids (optional) 

            try
            {
                SponsoredProductsCreateSponsoredProductsCampaignsResponseContent result = apiInstance.CreateSponsoredProductsCampaigns(amazonAdvertisingAPIClientId, amazonAdvertisingAPIScope, sponsoredProductsCreateSponsoredProductsCampaignsRequestContent, prefer);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CampaignsApi.CreateSponsoredProductsCampaigns: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateSponsoredProductsCampaignsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<SponsoredProductsCreateSponsoredProductsCampaignsResponseContent> response = apiInstance.CreateSponsoredProductsCampaignsWithHttpInfo(amazonAdvertisingAPIClientId, amazonAdvertisingAPIScope, sponsoredProductsCreateSponsoredProductsCampaignsRequestContent, prefer);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CampaignsApi.CreateSponsoredProductsCampaignsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **amazonAdvertisingAPIClientId** | **string** | The identifier of a client associated with a \&quot;Login with Amazon\&quot; account. |  |
| **amazonAdvertisingAPIScope** | **string** | The identifier of a profile associated with the advertiser account. Use GET method on Profiles resource to list profiles associated with the access token passed in the HTTP Authorization header. |  |
| **sponsoredProductsCreateSponsoredProductsCampaignsRequestContent** | [**SponsoredProductsCreateSponsoredProductsCampaignsRequestContent**](SponsoredProductsCreateSponsoredProductsCampaignsRequestContent.md) |  |  |
| **prefer** | **string?** | The \&quot;Prefer\&quot; header, as defined in [RFC7240], allows clients to request certain behavior from the service. The service ignores preference values that are either not supported or not known by the service. Either multiple Prefer headers are passed or single one with comma separated values, both forms are equivalent Supported preferences: return&#x3D;representation - return the full object when doing create/update/delete operations instead of ids | [optional]  |

### Return type

[**SponsoredProductsCreateSponsoredProductsCampaignsResponseContent**](SponsoredProductsCreateSponsoredProductsCampaignsResponseContent.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/vnd.spCampaign.v3+json
 - **Accept**: application/json, application/vnd.spCampaign.v3+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **400** | CampaignMutationException 400 response |  -  |
| **401** | UnauthorizedException 401 response |  -  |
| **500** | InternalServerException 500 response |  -  |
| **403** | AccessDeniedException 403 response |  -  |
| **415** | UnsupportedMediaTypeException 415 response |  -  |
| **207** | CreateSponsoredProductsCampaigns 207 response |  * Preference-Applied - Header containing preferences applied while processing API call <br>  |
| **429** | ThrottlingException 429 response |  * Retry-After - Delay in seconds, before the next re-try attempt to the operation is recommended <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletesponsoredproductscampaigns"></a>
# **DeleteSponsoredProductsCampaigns**
> SponsoredProductsDeleteSponsoredProductsCampaignsResponseContent DeleteSponsoredProductsCampaigns (string amazonAdvertisingAPIClientId, string amazonAdvertisingAPIScope, SponsoredProductsDeleteSponsoredProductsCampaignsRequestContent sponsoredProductsDeleteSponsoredProductsCampaignsRequestContent)



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
    public class DeleteSponsoredProductsCampaignsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new CampaignsApi(config);
            var amazonAdvertisingAPIClientId = "amazonAdvertisingAPIClientId_example";  // string | The identifier of a client associated with a \"Login with Amazon\" account.
            var amazonAdvertisingAPIScope = "amazonAdvertisingAPIScope_example";  // string | The identifier of a profile associated with the advertiser account. Use GET method on Profiles resource to list profiles associated with the access token passed in the HTTP Authorization header.
            var sponsoredProductsDeleteSponsoredProductsCampaignsRequestContent = new SponsoredProductsDeleteSponsoredProductsCampaignsRequestContent(); // SponsoredProductsDeleteSponsoredProductsCampaignsRequestContent | 

            try
            {
                SponsoredProductsDeleteSponsoredProductsCampaignsResponseContent result = apiInstance.DeleteSponsoredProductsCampaigns(amazonAdvertisingAPIClientId, amazonAdvertisingAPIScope, sponsoredProductsDeleteSponsoredProductsCampaignsRequestContent);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CampaignsApi.DeleteSponsoredProductsCampaigns: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteSponsoredProductsCampaignsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<SponsoredProductsDeleteSponsoredProductsCampaignsResponseContent> response = apiInstance.DeleteSponsoredProductsCampaignsWithHttpInfo(amazonAdvertisingAPIClientId, amazonAdvertisingAPIScope, sponsoredProductsDeleteSponsoredProductsCampaignsRequestContent);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CampaignsApi.DeleteSponsoredProductsCampaignsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **amazonAdvertisingAPIClientId** | **string** | The identifier of a client associated with a \&quot;Login with Amazon\&quot; account. |  |
| **amazonAdvertisingAPIScope** | **string** | The identifier of a profile associated with the advertiser account. Use GET method on Profiles resource to list profiles associated with the access token passed in the HTTP Authorization header. |  |
| **sponsoredProductsDeleteSponsoredProductsCampaignsRequestContent** | [**SponsoredProductsDeleteSponsoredProductsCampaignsRequestContent**](SponsoredProductsDeleteSponsoredProductsCampaignsRequestContent.md) |  |  |

### Return type

[**SponsoredProductsDeleteSponsoredProductsCampaignsResponseContent**](SponsoredProductsDeleteSponsoredProductsCampaignsResponseContent.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/vnd.spCampaign.v3+json
 - **Accept**: application/json, application/vnd.spCampaign.v3+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **400** | CampaignMutationException 400 response |  -  |
| **401** | UnauthorizedException 401 response |  -  |
| **500** | InternalServerException 500 response |  -  |
| **403** | AccessDeniedException 403 response |  -  |
| **415** | UnsupportedMediaTypeException 415 response |  -  |
| **207** | DeleteSponsoredProductsCampaigns 207 response |  -  |
| **429** | ThrottlingException 429 response |  * Retry-After - Delay in seconds, before the next re-try attempt to the operation is recommended <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listsponsoredproductscampaigns"></a>
# **ListSponsoredProductsCampaigns**
> SponsoredProductsListSponsoredProductsCampaignsResponseContent ListSponsoredProductsCampaigns (string amazonAdvertisingAPIClientId, string amazonAdvertisingAPIScope, SponsoredProductsListSponsoredProductsCampaignsRequestContent? sponsoredProductsListSponsoredProductsCampaignsRequestContent = null)



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
    public class ListSponsoredProductsCampaignsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new CampaignsApi(config);
            var amazonAdvertisingAPIClientId = "amazonAdvertisingAPIClientId_example";  // string | The identifier of a client associated with a \"Login with Amazon\" account.
            var amazonAdvertisingAPIScope = "amazonAdvertisingAPIScope_example";  // string | The identifier of a profile associated with the advertiser account. Use GET method on Profiles resource to list profiles associated with the access token passed in the HTTP Authorization header.
            var sponsoredProductsListSponsoredProductsCampaignsRequestContent = new SponsoredProductsListSponsoredProductsCampaignsRequestContent?(); // SponsoredProductsListSponsoredProductsCampaignsRequestContent? |  (optional) 

            try
            {
                SponsoredProductsListSponsoredProductsCampaignsResponseContent result = apiInstance.ListSponsoredProductsCampaigns(amazonAdvertisingAPIClientId, amazonAdvertisingAPIScope, sponsoredProductsListSponsoredProductsCampaignsRequestContent);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CampaignsApi.ListSponsoredProductsCampaigns: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListSponsoredProductsCampaignsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<SponsoredProductsListSponsoredProductsCampaignsResponseContent> response = apiInstance.ListSponsoredProductsCampaignsWithHttpInfo(amazonAdvertisingAPIClientId, amazonAdvertisingAPIScope, sponsoredProductsListSponsoredProductsCampaignsRequestContent);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CampaignsApi.ListSponsoredProductsCampaignsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **amazonAdvertisingAPIClientId** | **string** | The identifier of a client associated with a \&quot;Login with Amazon\&quot; account. |  |
| **amazonAdvertisingAPIScope** | **string** | The identifier of a profile associated with the advertiser account. Use GET method on Profiles resource to list profiles associated with the access token passed in the HTTP Authorization header. |  |
| **sponsoredProductsListSponsoredProductsCampaignsRequestContent** | [**SponsoredProductsListSponsoredProductsCampaignsRequestContent?**](SponsoredProductsListSponsoredProductsCampaignsRequestContent?.md) |  | [optional]  |

### Return type

[**SponsoredProductsListSponsoredProductsCampaignsResponseContent**](SponsoredProductsListSponsoredProductsCampaignsResponseContent.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/vnd.spCampaign.v3+json
 - **Accept**: application/vnd.spCampaign.v3+json, application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | ListSponsoredProductsCampaigns 200 response |  -  |
| **400** | CampaignAccessException 400 response |  -  |
| **401** | UnauthorizedException 401 response |  -  |
| **500** | InternalServerException 500 response |  -  |
| **403** | AccessDeniedException 403 response |  -  |
| **415** | UnsupportedMediaTypeException 415 response |  -  |
| **429** | ThrottlingException 429 response |  * Retry-After - Delay in seconds, before the next re-try attempt to the operation is recommended <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatesponsoredproductscampaigns"></a>
# **UpdateSponsoredProductsCampaigns**
> SponsoredProductsUpdateSponsoredProductsCampaignsResponseContent UpdateSponsoredProductsCampaigns (string amazonAdvertisingAPIClientId, string amazonAdvertisingAPIScope, SponsoredProductsUpdateSponsoredProductsCampaignsRequestContent sponsoredProductsUpdateSponsoredProductsCampaignsRequestContent, string? prefer = null)



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
    public class UpdateSponsoredProductsCampaignsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new CampaignsApi(config);
            var amazonAdvertisingAPIClientId = "amazonAdvertisingAPIClientId_example";  // string | The identifier of a client associated with a \"Login with Amazon\" account.
            var amazonAdvertisingAPIScope = "amazonAdvertisingAPIScope_example";  // string | The identifier of a profile associated with the advertiser account. Use GET method on Profiles resource to list profiles associated with the access token passed in the HTTP Authorization header.
            var sponsoredProductsUpdateSponsoredProductsCampaignsRequestContent = new SponsoredProductsUpdateSponsoredProductsCampaignsRequestContent(); // SponsoredProductsUpdateSponsoredProductsCampaignsRequestContent | 
            var prefer = "prefer_example";  // string? | The \"Prefer\" header, as defined in [RFC7240], allows clients to request certain behavior from the service. The service ignores preference values that are either not supported or not known by the service. Either multiple Prefer headers are passed or single one with comma separated values, both forms are equivalent Supported preferences: return=representation - return the full object when doing create/update/delete operations instead of ids (optional) 

            try
            {
                SponsoredProductsUpdateSponsoredProductsCampaignsResponseContent result = apiInstance.UpdateSponsoredProductsCampaigns(amazonAdvertisingAPIClientId, amazonAdvertisingAPIScope, sponsoredProductsUpdateSponsoredProductsCampaignsRequestContent, prefer);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CampaignsApi.UpdateSponsoredProductsCampaigns: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateSponsoredProductsCampaignsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<SponsoredProductsUpdateSponsoredProductsCampaignsResponseContent> response = apiInstance.UpdateSponsoredProductsCampaignsWithHttpInfo(amazonAdvertisingAPIClientId, amazonAdvertisingAPIScope, sponsoredProductsUpdateSponsoredProductsCampaignsRequestContent, prefer);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CampaignsApi.UpdateSponsoredProductsCampaignsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **amazonAdvertisingAPIClientId** | **string** | The identifier of a client associated with a \&quot;Login with Amazon\&quot; account. |  |
| **amazonAdvertisingAPIScope** | **string** | The identifier of a profile associated with the advertiser account. Use GET method on Profiles resource to list profiles associated with the access token passed in the HTTP Authorization header. |  |
| **sponsoredProductsUpdateSponsoredProductsCampaignsRequestContent** | [**SponsoredProductsUpdateSponsoredProductsCampaignsRequestContent**](SponsoredProductsUpdateSponsoredProductsCampaignsRequestContent.md) |  |  |
| **prefer** | **string?** | The \&quot;Prefer\&quot; header, as defined in [RFC7240], allows clients to request certain behavior from the service. The service ignores preference values that are either not supported or not known by the service. Either multiple Prefer headers are passed or single one with comma separated values, both forms are equivalent Supported preferences: return&#x3D;representation - return the full object when doing create/update/delete operations instead of ids | [optional]  |

### Return type

[**SponsoredProductsUpdateSponsoredProductsCampaignsResponseContent**](SponsoredProductsUpdateSponsoredProductsCampaignsResponseContent.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/vnd.spCampaign.v3+json
 - **Accept**: application/json, application/vnd.spCampaign.v3+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **400** | CampaignMutationException 400 response |  -  |
| **401** | UnauthorizedException 401 response |  -  |
| **500** | InternalServerException 500 response |  -  |
| **403** | AccessDeniedException 403 response |  -  |
| **415** | UnsupportedMediaTypeException 415 response |  -  |
| **207** | UpdateSponsoredProductsCampaigns 207 response |  * Preference-Applied - Header containing preferences applied while processing API call <br>  |
| **429** | ThrottlingException 429 response |  * Retry-After - Delay in seconds, before the next re-try attempt to the operation is recommended <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

