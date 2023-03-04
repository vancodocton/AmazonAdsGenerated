# Amazon.Advertising.SponsoredProducts.Api.CampaignOptimizationRulesApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateOptimizationRule**](CampaignOptimizationRulesApi.md#createoptimizationrule) | **POST** /sp/rules/campaignOptimization | Creates a campaign optimization rule. |
| [**DeleteCampaignOptimizationRule**](CampaignOptimizationRulesApi.md#deletecampaignoptimizationrule) | **DELETE** /sp/rules/campaignOptimization/{campaignOptimizationId} | Deletes a campaign optimization rule specified by identifier. |
| [**GetCampaignOptimizationRule**](CampaignOptimizationRulesApi.md#getcampaignoptimizationrule) | **GET** /sp/rules/campaignOptimization/{campaignOptimizationId} | Gets a campaign optimization rule specified by identifier. |
| [**GetOptimizationRuleEligibility**](CampaignOptimizationRulesApi.md#getoptimizationruleeligibility) | **POST** /sp/rules/campaignOptimization/eligibility | Gets a campaign optimization rule recommendation for SP campaigns. |
| [**GetRuleNotification**](CampaignOptimizationRulesApi.md#getrulenotification) | **POST** /sp/rules/campaignOptimization/state | Gets campaign optimization rule state. Recommended refresh frequency is once a day. |
| [**UpdateOptimizationRule**](CampaignOptimizationRulesApi.md#updateoptimizationrule) | **PUT** /sp/rules/campaignOptimization | Updates a campaign optimization rule. |

<a name="createoptimizationrule"></a>
# **CreateOptimizationRule**
> CreateSPCampaignOptimizationRulesResponse CreateOptimizationRule (string amazonAdvertisingAPIClientId, string amazonAdvertisingAPIScope, CreateSPCampaignOptimizationRulesRequest createSPCampaignOptimizationRulesRequest)

Creates a campaign optimization rule.

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
    public class CreateOptimizationRuleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new CampaignOptimizationRulesApi(config);
            var amazonAdvertisingAPIClientId = "amazonAdvertisingAPIClientId_example";  // string | The identifier of a client associated with a \"Login with Amazon\" account. This is a required header for advertisers and integrators using the Advertising API.
            var amazonAdvertisingAPIScope = "amazonAdvertisingAPIScope_example";  // string | The identifier of a profile associated with the advertiser account. Use `GET` method on Profiles resource to list profiles associated with the access token passed in the HTTP Authorization header. This is a required header for advertisers and integrators using the Advertising API.
            var createSPCampaignOptimizationRulesRequest = new CreateSPCampaignOptimizationRulesRequest(); // CreateSPCampaignOptimizationRulesRequest | 

            try
            {
                // Creates a campaign optimization rule.
                CreateSPCampaignOptimizationRulesResponse result = apiInstance.CreateOptimizationRule(amazonAdvertisingAPIClientId, amazonAdvertisingAPIScope, createSPCampaignOptimizationRulesRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CampaignOptimizationRulesApi.CreateOptimizationRule: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateOptimizationRuleWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates a campaign optimization rule.
    ApiResponse<CreateSPCampaignOptimizationRulesResponse> response = apiInstance.CreateOptimizationRuleWithHttpInfo(amazonAdvertisingAPIClientId, amazonAdvertisingAPIScope, createSPCampaignOptimizationRulesRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CampaignOptimizationRulesApi.CreateOptimizationRuleWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **amazonAdvertisingAPIClientId** | **string** | The identifier of a client associated with a \&quot;Login with Amazon\&quot; account. This is a required header for advertisers and integrators using the Advertising API. |  |
| **amazonAdvertisingAPIScope** | **string** | The identifier of a profile associated with the advertiser account. Use &#x60;GET&#x60; method on Profiles resource to list profiles associated with the access token passed in the HTTP Authorization header. This is a required header for advertisers and integrators using the Advertising API. |  |
| **createSPCampaignOptimizationRulesRequest** | [**CreateSPCampaignOptimizationRulesRequest**](CreateSPCampaignOptimizationRulesRequest.md) |  |  |

### Return type

[**CreateSPCampaignOptimizationRulesResponse**](CreateSPCampaignOptimizationRulesResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/vnd.optimizationrules.v1+json
 - **Accept**: application/vnd.optimizationrules.v1+json, application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful Operation. |  -  |
| **400** | Bad Request. |  -  |
| **422** | Unprocessable entity. The server understood the request, but was unable to process the instruction. |  -  |
| **401** | Unauthorized. The request failed because the user is not authenticated or is not allowed to invoke the operation. |  -  |
| **500** | Internal Server Error. Something went wrong on the server. Retry later and report an error if unresolved. |  -  |
| **403** | Forbidden. The request failed because user does not have access to a specified resource. |  -  |
| **429** | Too Many Requests. The request was rate-limited. Retry later. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletecampaignoptimizationrule"></a>
# **DeleteCampaignOptimizationRule**
> DeleteSPCampaignOptimizationRuleResponse DeleteCampaignOptimizationRule (string amazonAdvertisingAPIClientId, string amazonAdvertisingAPIScope, string campaignOptimizationId)

Deletes a campaign optimization rule specified by identifier.

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
    public class DeleteCampaignOptimizationRuleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new CampaignOptimizationRulesApi(config);
            var amazonAdvertisingAPIClientId = "amazonAdvertisingAPIClientId_example";  // string | The identifier of a client associated with a \"Login with Amazon\" account. This is a required header for advertisers and integrators using the Advertising API.
            var amazonAdvertisingAPIScope = "amazonAdvertisingAPIScope_example";  // string | The identifier of a profile associated with the advertiser account. Use `GET` method on Profiles resource to list profiles associated with the access token passed in the HTTP Authorization header. This is a required header for advertisers and integrators using the Advertising API.
            var campaignOptimizationId = "campaignOptimizationId_example";  // string | The sp campaign optimization rule identifier.

            try
            {
                // Deletes a campaign optimization rule specified by identifier.
                DeleteSPCampaignOptimizationRuleResponse result = apiInstance.DeleteCampaignOptimizationRule(amazonAdvertisingAPIClientId, amazonAdvertisingAPIScope, campaignOptimizationId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CampaignOptimizationRulesApi.DeleteCampaignOptimizationRule: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteCampaignOptimizationRuleWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Deletes a campaign optimization rule specified by identifier.
    ApiResponse<DeleteSPCampaignOptimizationRuleResponse> response = apiInstance.DeleteCampaignOptimizationRuleWithHttpInfo(amazonAdvertisingAPIClientId, amazonAdvertisingAPIScope, campaignOptimizationId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CampaignOptimizationRulesApi.DeleteCampaignOptimizationRuleWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **amazonAdvertisingAPIClientId** | **string** | The identifier of a client associated with a \&quot;Login with Amazon\&quot; account. This is a required header for advertisers and integrators using the Advertising API. |  |
| **amazonAdvertisingAPIScope** | **string** | The identifier of a profile associated with the advertiser account. Use &#x60;GET&#x60; method on Profiles resource to list profiles associated with the access token passed in the HTTP Authorization header. This is a required header for advertisers and integrators using the Advertising API. |  |
| **campaignOptimizationId** | **string** | The sp campaign optimization rule identifier. |  |

### Return type

[**DeleteSPCampaignOptimizationRuleResponse**](DeleteSPCampaignOptimizationRuleResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.optimizationrules.v1+json, application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation. |  -  |
| **400** | Bad Request. |  -  |
| **422** | Unprocessable entity. The server understood the request, but was unable to process the instruction. |  -  |
| **401** | Unauthorized. The request failed because the user is not authenticated or is not allowed to invoke the operation. |  -  |
| **500** | Internal Server Error. |  -  |
| **403** | Forbidden. The request failed because user does not have access to a specified resource. |  -  |
| **404** | Resource not found |  -  |
| **429** | Too Many Requests. The request was rate-limited. Retry later. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcampaignoptimizationrule"></a>
# **GetCampaignOptimizationRule**
> GetSPCampaignOptimizationRuleResponse GetCampaignOptimizationRule (string amazonAdvertisingAPIClientId, string amazonAdvertisingAPIScope, string campaignOptimizationId)

Gets a campaign optimization rule specified by identifier.

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
    public class GetCampaignOptimizationRuleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new CampaignOptimizationRulesApi(config);
            var amazonAdvertisingAPIClientId = "amazonAdvertisingAPIClientId_example";  // string | The identifier of a client associated with a \"Login with Amazon\" account. This is a required header for advertisers and integrators using the Advertising API.
            var amazonAdvertisingAPIScope = "amazonAdvertisingAPIScope_example";  // string | The identifier of a profile associated with the advertiser account. Use `GET` method on Profiles resource to list profiles associated with the access token passed in the HTTP Authorization header. This is a required header for advertisers and integrators using the Advertising API.
            var campaignOptimizationId = "campaignOptimizationId_example";  // string | The sp campaign optimization rule identifier.

            try
            {
                // Gets a campaign optimization rule specified by identifier.
                GetSPCampaignOptimizationRuleResponse result = apiInstance.GetCampaignOptimizationRule(amazonAdvertisingAPIClientId, amazonAdvertisingAPIScope, campaignOptimizationId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CampaignOptimizationRulesApi.GetCampaignOptimizationRule: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCampaignOptimizationRuleWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets a campaign optimization rule specified by identifier.
    ApiResponse<GetSPCampaignOptimizationRuleResponse> response = apiInstance.GetCampaignOptimizationRuleWithHttpInfo(amazonAdvertisingAPIClientId, amazonAdvertisingAPIScope, campaignOptimizationId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CampaignOptimizationRulesApi.GetCampaignOptimizationRuleWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **amazonAdvertisingAPIClientId** | **string** | The identifier of a client associated with a \&quot;Login with Amazon\&quot; account. This is a required header for advertisers and integrators using the Advertising API. |  |
| **amazonAdvertisingAPIScope** | **string** | The identifier of a profile associated with the advertiser account. Use &#x60;GET&#x60; method on Profiles resource to list profiles associated with the access token passed in the HTTP Authorization header. This is a required header for advertisers and integrators using the Advertising API. |  |
| **campaignOptimizationId** | **string** | The sp campaign optimization rule identifier. |  |

### Return type

[**GetSPCampaignOptimizationRuleResponse**](GetSPCampaignOptimizationRuleResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.optimizationrules.v1+json, application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation. |  -  |
| **400** | Bad Request. |  -  |
| **422** | Unprocessable entity. The server understood the request, but was unable to process the instruction. |  -  |
| **401** | Unauthorized. The request failed because the user is not authenticated or is not allowed to invoke the operation. |  -  |
| **500** | Internal Server Error. Something went wrong on the server. Retry later and report an error if unresolved. |  -  |
| **403** | Forbidden. The request failed because user does not have access to a specified resource. |  -  |
| **404** | Resource not found |  -  |
| **429** | Too Many Requests. The request was rate-limited. Retry later. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getoptimizationruleeligibility"></a>
# **GetOptimizationRuleEligibility**
> SPCampaignOptimizationRecommendationAPIResponse GetOptimizationRuleEligibility (string amazonAdvertisingAPIClientId, string amazonAdvertisingAPIScope, SPCampaignOptimizationRecommendationsAPIRequest sPCampaignOptimizationRecommendationsAPIRequest)

Gets a campaign optimization rule recommendation for SP campaigns.

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
    public class GetOptimizationRuleEligibilityExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new CampaignOptimizationRulesApi(config);
            var amazonAdvertisingAPIClientId = "amazonAdvertisingAPIClientId_example";  // string | The identifier of a client associated with a \"Login with Amazon\" account. This is a required header for advertisers and integrators using the Advertising API.
            var amazonAdvertisingAPIScope = "amazonAdvertisingAPIScope_example";  // string | The identifier of a profile associated with the advertiser account. Use `GET` method on Profiles resource to list profiles associated with the access token passed in the HTTP Authorization header. This is a required header for advertisers and integrators using the Advertising API.
            var sPCampaignOptimizationRecommendationsAPIRequest = new SPCampaignOptimizationRecommendationsAPIRequest(); // SPCampaignOptimizationRecommendationsAPIRequest | 

            try
            {
                // Gets a campaign optimization rule recommendation for SP campaigns.
                SPCampaignOptimizationRecommendationAPIResponse result = apiInstance.GetOptimizationRuleEligibility(amazonAdvertisingAPIClientId, amazonAdvertisingAPIScope, sPCampaignOptimizationRecommendationsAPIRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CampaignOptimizationRulesApi.GetOptimizationRuleEligibility: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetOptimizationRuleEligibilityWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets a campaign optimization rule recommendation for SP campaigns.
    ApiResponse<SPCampaignOptimizationRecommendationAPIResponse> response = apiInstance.GetOptimizationRuleEligibilityWithHttpInfo(amazonAdvertisingAPIClientId, amazonAdvertisingAPIScope, sPCampaignOptimizationRecommendationsAPIRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CampaignOptimizationRulesApi.GetOptimizationRuleEligibilityWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **amazonAdvertisingAPIClientId** | **string** | The identifier of a client associated with a \&quot;Login with Amazon\&quot; account. This is a required header for advertisers and integrators using the Advertising API. |  |
| **amazonAdvertisingAPIScope** | **string** | The identifier of a profile associated with the advertiser account. Use &#x60;GET&#x60; method on Profiles resource to list profiles associated with the access token passed in the HTTP Authorization header. This is a required header for advertisers and integrators using the Advertising API. |  |
| **sPCampaignOptimizationRecommendationsAPIRequest** | [**SPCampaignOptimizationRecommendationsAPIRequest**](SPCampaignOptimizationRecommendationsAPIRequest.md) |  |  |

### Return type

[**SPCampaignOptimizationRecommendationAPIResponse**](SPCampaignOptimizationRecommendationAPIResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/vnd.optimizationrules.v1+json
 - **Accept**: application/vnd.optimizationrules.v1+json, application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful Operation. |  -  |
| **400** | Bad Request. |  -  |
| **422** | Unprocessable Entity. The server understood the request, but was unable to process the instruction. |  -  |
| **401** | Unauthorized. The request failed because the user is not authenticated or is not allowed to invoke the operation. |  -  |
| **500** | Internal Server Error. |  -  |
| **403** | Forbidden. The request failed because user does not have access to a specified resource. |  -  |
| **429** | Too Many Requests. The request was rate-limited. Retry later. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getrulenotification"></a>
# **GetRuleNotification**
> SPCampaignOptimizationNotificationAPIResponse GetRuleNotification (string amazonAdvertisingAPIClientId, string amazonAdvertisingAPIScope, SPCampaignOptimizationNotificationAPIRequest sPCampaignOptimizationNotificationAPIRequest)

Gets campaign optimization rule state. Recommended refresh frequency is once a day.

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
    public class GetRuleNotificationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new CampaignOptimizationRulesApi(config);
            var amazonAdvertisingAPIClientId = "amazonAdvertisingAPIClientId_example";  // string | The identifier of a client associated with a \"Login with Amazon\" account. This is a required header for advertisers and integrators using the Advertising API.
            var amazonAdvertisingAPIScope = "amazonAdvertisingAPIScope_example";  // string | The identifier of a profile associated with the advertiser account. Use `GET` method on Profiles resource to list profiles associated with the access token passed in the HTTP Authorization header. This is a required header for advertisers and integrators using the Advertising API.
            var sPCampaignOptimizationNotificationAPIRequest = new SPCampaignOptimizationNotificationAPIRequest(); // SPCampaignOptimizationNotificationAPIRequest | 

            try
            {
                // Gets campaign optimization rule state. Recommended refresh frequency is once a day.
                SPCampaignOptimizationNotificationAPIResponse result = apiInstance.GetRuleNotification(amazonAdvertisingAPIClientId, amazonAdvertisingAPIScope, sPCampaignOptimizationNotificationAPIRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CampaignOptimizationRulesApi.GetRuleNotification: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetRuleNotificationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets campaign optimization rule state. Recommended refresh frequency is once a day.
    ApiResponse<SPCampaignOptimizationNotificationAPIResponse> response = apiInstance.GetRuleNotificationWithHttpInfo(amazonAdvertisingAPIClientId, amazonAdvertisingAPIScope, sPCampaignOptimizationNotificationAPIRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CampaignOptimizationRulesApi.GetRuleNotificationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **amazonAdvertisingAPIClientId** | **string** | The identifier of a client associated with a \&quot;Login with Amazon\&quot; account. This is a required header for advertisers and integrators using the Advertising API. |  |
| **amazonAdvertisingAPIScope** | **string** | The identifier of a profile associated with the advertiser account. Use &#x60;GET&#x60; method on Profiles resource to list profiles associated with the access token passed in the HTTP Authorization header. This is a required header for advertisers and integrators using the Advertising API. |  |
| **sPCampaignOptimizationNotificationAPIRequest** | [**SPCampaignOptimizationNotificationAPIRequest**](SPCampaignOptimizationNotificationAPIRequest.md) |  |  |

### Return type

[**SPCampaignOptimizationNotificationAPIResponse**](SPCampaignOptimizationNotificationAPIResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/vnd.optimizationrules.v1+json
 - **Accept**: application/vnd.optimizationrules.v1+json, application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful Operation. |  -  |
| **400** | Bad Request. |  -  |
| **422** | Unprocessable entity. The server understood the request, but was unable to process the instruction. |  -  |
| **401** | Unauthorized. The request failed because the user is not authenticated or is not allowed to invoke the operation. |  -  |
| **500** | Internal Server Error. |  -  |
| **403** | Forbidden. The request failed because user does not have access to a specified resource. |  -  |
| **429** | Too Many Requests. The request was rate-limited. Retry later. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateoptimizationrule"></a>
# **UpdateOptimizationRule**
> UpdateSPCampaignOptimizationRuleResponse UpdateOptimizationRule (string amazonAdvertisingAPIClientId, string amazonAdvertisingAPIScope, UpdateSPCampaignOptimizationRulesRequest updateSPCampaignOptimizationRulesRequest)

Updates a campaign optimization rule.

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
    public class UpdateOptimizationRuleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new CampaignOptimizationRulesApi(config);
            var amazonAdvertisingAPIClientId = "amazonAdvertisingAPIClientId_example";  // string | The identifier of a client associated with a \"Login with Amazon\" account. This is a required header for advertisers and integrators using the Advertising API.
            var amazonAdvertisingAPIScope = "amazonAdvertisingAPIScope_example";  // string | The identifier of a profile associated with the advertiser account. Use `GET` method on Profiles resource to list profiles associated with the access token passed in the HTTP Authorization header. This is a required header for advertisers and integrators using the Advertising API.
            var updateSPCampaignOptimizationRulesRequest = new UpdateSPCampaignOptimizationRulesRequest(); // UpdateSPCampaignOptimizationRulesRequest | 

            try
            {
                // Updates a campaign optimization rule.
                UpdateSPCampaignOptimizationRuleResponse result = apiInstance.UpdateOptimizationRule(amazonAdvertisingAPIClientId, amazonAdvertisingAPIScope, updateSPCampaignOptimizationRulesRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CampaignOptimizationRulesApi.UpdateOptimizationRule: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateOptimizationRuleWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Updates a campaign optimization rule.
    ApiResponse<UpdateSPCampaignOptimizationRuleResponse> response = apiInstance.UpdateOptimizationRuleWithHttpInfo(amazonAdvertisingAPIClientId, amazonAdvertisingAPIScope, updateSPCampaignOptimizationRulesRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CampaignOptimizationRulesApi.UpdateOptimizationRuleWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **amazonAdvertisingAPIClientId** | **string** | The identifier of a client associated with a \&quot;Login with Amazon\&quot; account. This is a required header for advertisers and integrators using the Advertising API. |  |
| **amazonAdvertisingAPIScope** | **string** | The identifier of a profile associated with the advertiser account. Use &#x60;GET&#x60; method on Profiles resource to list profiles associated with the access token passed in the HTTP Authorization header. This is a required header for advertisers and integrators using the Advertising API. |  |
| **updateSPCampaignOptimizationRulesRequest** | [**UpdateSPCampaignOptimizationRulesRequest**](UpdateSPCampaignOptimizationRulesRequest.md) |  |  |

### Return type

[**UpdateSPCampaignOptimizationRuleResponse**](UpdateSPCampaignOptimizationRuleResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/vnd.optimizationrules.v1+json
 - **Accept**: application/vnd.optimizationrules.v1+json, application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully updated |  -  |
| **400** | Bad Request. |  -  |
| **422** | Unprocessable entity. The server understood the request, but was unable to process the instruction. |  -  |
| **401** | Unauthorized. The request failed because the user is not authenticated or is not allowed to invoke the operation. |  -  |
| **500** | Internal Server Error.  |  -  |
| **403** | Forbidden. The request failed because user does not have access to a specified resource. |  -  |
| **429** | Too Many Requests. The request was rate-limited. Retry later. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

