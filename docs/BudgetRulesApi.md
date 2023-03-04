# Amazon.Advertising.SponsoredProducts.Api.BudgetRulesApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateAssociatedBudgetRulesForSPCampaigns**](BudgetRulesApi.md#createassociatedbudgetrulesforspcampaigns) | **POST** /sp/campaigns/{campaignId}/budgetRules | Associates one or more budget rules to a campaign specified by identifer. |
| [**CreateBudgetRulesForSPCampaigns**](BudgetRulesApi.md#createbudgetrulesforspcampaigns) | **POST** /sp/budgetRules | Creates one or more budget rules. |
| [**DisassociateAssociatedBudgetRuleForSPCampaigns**](BudgetRulesApi.md#disassociateassociatedbudgetruleforspcampaigns) | **DELETE** /sp/campaigns/{campaignId}/budgetRules/{budgetRuleId} | Disassociates a budget rule specified by identifier from a campaign specified by identifier. |
| [**GetBudgetRuleByRuleIdForSPCampaigns**](BudgetRulesApi.md#getbudgetrulebyruleidforspcampaigns) | **GET** /sp/budgetRules/{budgetRuleId} | Gets a budget rule specified by identifier. |
| [**GetCampaignsAssociatedWithSPBudgetRule**](BudgetRulesApi.md#getcampaignsassociatedwithspbudgetrule) | **GET** /sp/budgetRules/{budgetRuleId}/campaigns | Gets all the campaigns associated with a budget rule |
| [**GetRuleBasedBudgetHistoryForSPCampaigns**](BudgetRulesApi.md#getrulebasedbudgethistoryforspcampaigns) | **GET** /sp/campaigns/{campaignId}/budgetRules/budgetHistory | Gets the budget history for a campaign specified by identifier. |
| [**GetSPBudgetRulesForAdvertiser**](BudgetRulesApi.md#getspbudgetrulesforadvertiser) | **GET** /sp/budgetRules | Get all budget rules created by an advertiser |
| [**ListAssociatedBudgetRulesForSPCampaigns**](BudgetRulesApi.md#listassociatedbudgetrulesforspcampaigns) | **GET** /sp/campaigns/{campaignId}/budgetRules | Gets a list of budget rules associated to a campaign specified by identifier. |
| [**UpdateBudgetRulesForSPCampaigns**](BudgetRulesApi.md#updatebudgetrulesforspcampaigns) | **PUT** /sp/budgetRules | Updates one or more budget rules. |

<a name="createassociatedbudgetrulesforspcampaigns"></a>
# **CreateAssociatedBudgetRulesForSPCampaigns**
> CreateAssociatedBudgetRulesResponse CreateAssociatedBudgetRulesForSPCampaigns (string amazonAdvertisingAPIClientId, string amazonAdvertisingAPIScope, decimal campaignId, CreateAssociatedBudgetRulesRequest createAssociatedBudgetRulesRequest)

Associates one or more budget rules to a campaign specified by identifer.

A maximum of 250 rules can be associated to a campaign. Note that the name of each rule associated to a campaign is required to be unique.  **Requires one of these permissions**: [\"advertiser_campaign_edit\"]

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Amazon.Advertising.SponsoredProducts.Api;
using Amazon.Advertising.SponsoredProducts.Client;
using Amazon.Advertising.SponsoredProducts.Model;

namespace Example
{
    public class CreateAssociatedBudgetRulesForSPCampaignsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new BudgetRulesApi(config);
            var amazonAdvertisingAPIClientId = "amazonAdvertisingAPIClientId_example";  // string | The identifier of a client associated with a Login with Amazon account. This is a required header for advertisers and integrators using the Advertising API.
            var amazonAdvertisingAPIScope = "amazonAdvertisingAPIScope_example";  // string | The identifier of a profile associated with the advertiser account. Use `GET` method on Profiles resource to list profiles associated with the access token passed in the HTTP Authorization header. This is a required header for advertisers and integrators using the Advertising API.
            var campaignId = 8.14D;  // decimal | The campaign identifier.
            var createAssociatedBudgetRulesRequest = new CreateAssociatedBudgetRulesRequest(); // CreateAssociatedBudgetRulesRequest | 

            try
            {
                // Associates one or more budget rules to a campaign specified by identifer.
                CreateAssociatedBudgetRulesResponse result = apiInstance.CreateAssociatedBudgetRulesForSPCampaigns(amazonAdvertisingAPIClientId, amazonAdvertisingAPIScope, campaignId, createAssociatedBudgetRulesRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BudgetRulesApi.CreateAssociatedBudgetRulesForSPCampaigns: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateAssociatedBudgetRulesForSPCampaignsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Associates one or more budget rules to a campaign specified by identifer.
    ApiResponse<CreateAssociatedBudgetRulesResponse> response = apiInstance.CreateAssociatedBudgetRulesForSPCampaignsWithHttpInfo(amazonAdvertisingAPIClientId, amazonAdvertisingAPIScope, campaignId, createAssociatedBudgetRulesRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BudgetRulesApi.CreateAssociatedBudgetRulesForSPCampaignsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **amazonAdvertisingAPIClientId** | **string** | The identifier of a client associated with a Login with Amazon account. This is a required header for advertisers and integrators using the Advertising API. |  |
| **amazonAdvertisingAPIScope** | **string** | The identifier of a profile associated with the advertiser account. Use &#x60;GET&#x60; method on Profiles resource to list profiles associated with the access token passed in the HTTP Authorization header. This is a required header for advertisers and integrators using the Advertising API. |  |
| **campaignId** | **decimal** | The campaign identifier. |  |
| **createAssociatedBudgetRulesRequest** | [**CreateAssociatedBudgetRulesRequest**](CreateAssociatedBudgetRulesRequest.md) |  |  |

### Return type

[**CreateAssociatedBudgetRulesResponse**](CreateAssociatedBudgetRulesResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **400** | Bad Request. |  -  |
| **422** | Unprocessable entity. The server understood the request, but was unable to process the instruction. |  -  |
| **401** | Unauthorized. The request failed because the user is not authenticated or is not allowed to invoke the operation. |  -  |
| **500** | Internal Server Error. Something went wrong on the server. Retry later and report an error if unresolved. |  -  |
| **403** | Forbidden. The request failed because user does not have access to a specified resource. |  -  |
| **207** | Multi-status. An object containing a list of associated budget rule response objects reflecting the same order as the input. |  -  |
| **429** | Too Many Requests. The request was rate-limited. Retry later. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createbudgetrulesforspcampaigns"></a>
# **CreateBudgetRulesForSPCampaigns**
> CreateBudgetRulesResponse CreateBudgetRulesForSPCampaigns (string amazonAdvertisingAPIClientId, string amazonAdvertisingAPIScope, CreateSPBudgetRulesRequest createSPBudgetRulesRequest)

Creates one or more budget rules.

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
    public class CreateBudgetRulesForSPCampaignsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new BudgetRulesApi(config);
            var amazonAdvertisingAPIClientId = "amazonAdvertisingAPIClientId_example";  // string | The identifier of a client associated with a \"Login with Amazon\" account. This is a required header for advertisers and integrators using the Advertising API.
            var amazonAdvertisingAPIScope = "amazonAdvertisingAPIScope_example";  // string | The identifier of a profile associated with the advertiser account. Use `GET` method on Profiles resource to list profiles associated with the access token passed in the HTTP Authorization header. This is a required header for advertisers and integrators using the Advertising API.
            var createSPBudgetRulesRequest = new CreateSPBudgetRulesRequest(); // CreateSPBudgetRulesRequest | 

            try
            {
                // Creates one or more budget rules.
                CreateBudgetRulesResponse result = apiInstance.CreateBudgetRulesForSPCampaigns(amazonAdvertisingAPIClientId, amazonAdvertisingAPIScope, createSPBudgetRulesRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BudgetRulesApi.CreateBudgetRulesForSPCampaigns: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateBudgetRulesForSPCampaignsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates one or more budget rules.
    ApiResponse<CreateBudgetRulesResponse> response = apiInstance.CreateBudgetRulesForSPCampaignsWithHttpInfo(amazonAdvertisingAPIClientId, amazonAdvertisingAPIScope, createSPBudgetRulesRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BudgetRulesApi.CreateBudgetRulesForSPCampaignsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **amazonAdvertisingAPIClientId** | **string** | The identifier of a client associated with a \&quot;Login with Amazon\&quot; account. This is a required header for advertisers and integrators using the Advertising API. |  |
| **amazonAdvertisingAPIScope** | **string** | The identifier of a profile associated with the advertiser account. Use &#x60;GET&#x60; method on Profiles resource to list profiles associated with the access token passed in the HTTP Authorization header. This is a required header for advertisers and integrators using the Advertising API. |  |
| **createSPBudgetRulesRequest** | [**CreateSPBudgetRulesRequest**](CreateSPBudgetRulesRequest.md) |  |  |

### Return type

[**CreateBudgetRulesResponse**](CreateBudgetRulesResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **400** | Bad Request. |  -  |
| **422** | Unprocessable entity. The server understood the request, but was unable to process the instruction. |  -  |
| **401** | Unauthorized. The request failed because the user is not authenticated or is not allowed to invoke the operation. |  -  |
| **500** | Internal Server Error. Something went wrong on the server. Retry later and report an error if unresolved. |  -  |
| **403** | Forbidden. The request failed because user does not have access to a specified resource. |  -  |
| **207** | Multi-status. An object containing a list of budget rule response objects reflecting the same order as the input. |  -  |
| **429** | Too Many Requests. The request was rate-limited. Retry later. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="disassociateassociatedbudgetruleforspcampaigns"></a>
# **DisassociateAssociatedBudgetRuleForSPCampaigns**
> Object DisassociateAssociatedBudgetRuleForSPCampaigns (string amazonAdvertisingAPIClientId, string amazonAdvertisingAPIScope, decimal campaignId, string budgetRuleId)

Disassociates a budget rule specified by identifier from a campaign specified by identifier.

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
    public class DisassociateAssociatedBudgetRuleForSPCampaignsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new BudgetRulesApi(config);
            var amazonAdvertisingAPIClientId = "amazonAdvertisingAPIClientId_example";  // string | The identifier of a client associated with a \"Login with Amazon\" account. This is a required header for advertisers and integrators using the Advertising API.
            var amazonAdvertisingAPIScope = "amazonAdvertisingAPIScope_example";  // string | The identifier of a profile associated with the advertiser account. Use `GET` method on Profiles resource to list profiles associated with the access token passed in the HTTP Authorization header. This is a required header for advertisers and integrators using the Advertising API.
            var campaignId = 8.14D;  // decimal | The campaign identifier.
            var budgetRuleId = "budgetRuleId_example";  // string | The budget rule identifier.

            try
            {
                // Disassociates a budget rule specified by identifier from a campaign specified by identifier.
                Object result = apiInstance.DisassociateAssociatedBudgetRuleForSPCampaigns(amazonAdvertisingAPIClientId, amazonAdvertisingAPIScope, campaignId, budgetRuleId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BudgetRulesApi.DisassociateAssociatedBudgetRuleForSPCampaigns: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DisassociateAssociatedBudgetRuleForSPCampaignsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Disassociates a budget rule specified by identifier from a campaign specified by identifier.
    ApiResponse<Object> response = apiInstance.DisassociateAssociatedBudgetRuleForSPCampaignsWithHttpInfo(amazonAdvertisingAPIClientId, amazonAdvertisingAPIScope, campaignId, budgetRuleId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BudgetRulesApi.DisassociateAssociatedBudgetRuleForSPCampaignsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **amazonAdvertisingAPIClientId** | **string** | The identifier of a client associated with a \&quot;Login with Amazon\&quot; account. This is a required header for advertisers and integrators using the Advertising API. |  |
| **amazonAdvertisingAPIScope** | **string** | The identifier of a profile associated with the advertiser account. Use &#x60;GET&#x60; method on Profiles resource to list profiles associated with the access token passed in the HTTP Authorization header. This is a required header for advertisers and integrators using the Advertising API. |  |
| **campaignId** | **decimal** | The campaign identifier. |  |
| **budgetRuleId** | **string** | The budget rule identifier. |  |

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation. |  -  |
| **400** | Bad Request |  -  |
| **422** | Unprocessable entity. The server understood the request, but was unable to process the instruction. |  -  |
| **401** | Unauthorized. The request failed because user is not authenticated or is not allowed to invoke the operation. |  -  |
| **500** | Internal Server Error. Something went wrong on the server. Retry later and report an error if unresolved. |  -  |
| **403** | Forbidden. The request failed because user does not have access to a specified resource. |  -  |
| **429** | Too Many Requests. The request was rate-limited. Retry later. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getbudgetrulebyruleidforspcampaigns"></a>
# **GetBudgetRuleByRuleIdForSPCampaigns**
> GetSPBudgetRuleResponse GetBudgetRuleByRuleIdForSPCampaigns (string amazonAdvertisingAPIClientId, string amazonAdvertisingAPIScope, string budgetRuleId)

Gets a budget rule specified by identifier.

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
    public class GetBudgetRuleByRuleIdForSPCampaignsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new BudgetRulesApi(config);
            var amazonAdvertisingAPIClientId = "amazonAdvertisingAPIClientId_example";  // string | The identifier of a client associated with a \"Login with Amazon\" account. This is a required header for advertisers and integrators using the Advertising API.
            var amazonAdvertisingAPIScope = "amazonAdvertisingAPIScope_example";  // string | The identifier of a profile associated with the advertiser account. Use `GET` method on Profiles resource to list profiles associated with the access token passed in the HTTP Authorization header. This is a required header for advertisers and integrators using the Advertising API.
            var budgetRuleId = "budgetRuleId_example";  // string | The budget rule identifier.

            try
            {
                // Gets a budget rule specified by identifier.
                GetSPBudgetRuleResponse result = apiInstance.GetBudgetRuleByRuleIdForSPCampaigns(amazonAdvertisingAPIClientId, amazonAdvertisingAPIScope, budgetRuleId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BudgetRulesApi.GetBudgetRuleByRuleIdForSPCampaigns: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetBudgetRuleByRuleIdForSPCampaignsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets a budget rule specified by identifier.
    ApiResponse<GetSPBudgetRuleResponse> response = apiInstance.GetBudgetRuleByRuleIdForSPCampaignsWithHttpInfo(amazonAdvertisingAPIClientId, amazonAdvertisingAPIScope, budgetRuleId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BudgetRulesApi.GetBudgetRuleByRuleIdForSPCampaignsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **amazonAdvertisingAPIClientId** | **string** | The identifier of a client associated with a \&quot;Login with Amazon\&quot; account. This is a required header for advertisers and integrators using the Advertising API. |  |
| **amazonAdvertisingAPIScope** | **string** | The identifier of a profile associated with the advertiser account. Use &#x60;GET&#x60; method on Profiles resource to list profiles associated with the access token passed in the HTTP Authorization header. This is a required header for advertisers and integrators using the Advertising API. |  |
| **budgetRuleId** | **string** | The budget rule identifier. |  |

### Return type

[**GetSPBudgetRuleResponse**](GetSPBudgetRuleResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation. |  -  |
| **400** | Bad Request. |  -  |
| **422** | Unprocessable entity. The server understood the request, but was unable to process the instruction. |  -  |
| **401** | Unauthorized. The request failed because the user is not authenticated or is not allowed to invoke the operation. |  -  |
| **500** | Internal Server Error. Something went wrong on the server. Retry later and report an error if unresolved. |  -  |
| **403** | Forbidden. The request failed because user does not have access to a specified resource. |  -  |
| **429** | Too Many Requests. The request was rate-limited. Retry later. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcampaignsassociatedwithspbudgetrule"></a>
# **GetCampaignsAssociatedWithSPBudgetRule**
> SPGetAssociatedCampaignsResponse GetCampaignsAssociatedWithSPBudgetRule (string amazonAdvertisingAPIClientId, string amazonAdvertisingAPIScope, string budgetRuleId, decimal pageSize, string? nextToken = null)

Gets all the campaigns associated with a budget rule

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Amazon.Advertising.SponsoredProducts.Api;
using Amazon.Advertising.SponsoredProducts.Client;
using Amazon.Advertising.SponsoredProducts.Model;

namespace Example
{
    public class GetCampaignsAssociatedWithSPBudgetRuleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new BudgetRulesApi(config);
            var amazonAdvertisingAPIClientId = "amazonAdvertisingAPIClientId_example";  // string | The identifier of a client associated with a \"Login with Amazon\" account. This is a required header for advertisers and integrators using the Advertising API.
            var amazonAdvertisingAPIScope = "amazonAdvertisingAPIScope_example";  // string | The identifier of a profile associated with the advertiser account. Use `GET` method on Profiles resource to list profiles associated with the access token passed in the HTTP Authorization header. This is a required header for advertisers and integrators using the Advertising API.
            var budgetRuleId = "budgetRuleId_example";  // string | The budget rule identifier.
            var pageSize = 8.14D;  // decimal | Sets a limit on the number of results returned. Maximum limit of `pageSize` is 30.
            var nextToken = "nextToken_example";  // string? | To retrieve the next page of results, call the same operation and specify this token in the request. If the `nextToken` field is empty, there are no further results. (optional) 

            try
            {
                // Gets all the campaigns associated with a budget rule
                SPGetAssociatedCampaignsResponse result = apiInstance.GetCampaignsAssociatedWithSPBudgetRule(amazonAdvertisingAPIClientId, amazonAdvertisingAPIScope, budgetRuleId, pageSize, nextToken);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BudgetRulesApi.GetCampaignsAssociatedWithSPBudgetRule: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCampaignsAssociatedWithSPBudgetRuleWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets all the campaigns associated with a budget rule
    ApiResponse<SPGetAssociatedCampaignsResponse> response = apiInstance.GetCampaignsAssociatedWithSPBudgetRuleWithHttpInfo(amazonAdvertisingAPIClientId, amazonAdvertisingAPIScope, budgetRuleId, pageSize, nextToken);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BudgetRulesApi.GetCampaignsAssociatedWithSPBudgetRuleWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **amazonAdvertisingAPIClientId** | **string** | The identifier of a client associated with a \&quot;Login with Amazon\&quot; account. This is a required header for advertisers and integrators using the Advertising API. |  |
| **amazonAdvertisingAPIScope** | **string** | The identifier of a profile associated with the advertiser account. Use &#x60;GET&#x60; method on Profiles resource to list profiles associated with the access token passed in the HTTP Authorization header. This is a required header for advertisers and integrators using the Advertising API. |  |
| **budgetRuleId** | **string** | The budget rule identifier. |  |
| **pageSize** | **decimal** | Sets a limit on the number of results returned. Maximum limit of &#x60;pageSize&#x60; is 30. |  |
| **nextToken** | **string?** | To retrieve the next page of results, call the same operation and specify this token in the request. If the &#x60;nextToken&#x60; field is empty, there are no further results. | [optional]  |

### Return type

[**SPGetAssociatedCampaignsResponse**](SPGetAssociatedCampaignsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation. |  -  |
| **400** | Bad Request. |  -  |
| **422** | Unprocessable entity. The server understood the request, but was unable to process the instruction. |  -  |
| **401** | Unauthorized. The request failed because the user is not authenticated or is not allowed to invoke the operation. |  -  |
| **500** | Internal Server Error. Something went wrong on the server. Retry later and report an error if unresolved. |  -  |
| **403** | Forbidden. The request failed because user does not have access to a specified resource. |  -  |
| **429** | Too Many Requests. The request was rate-limited. Retry later. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getrulebasedbudgethistoryforspcampaigns"></a>
# **GetRuleBasedBudgetHistoryForSPCampaigns**
> SPBudgetHistory GetRuleBasedBudgetHistoryForSPCampaigns (string amazonAdvertisingAPIClientId, string amazonAdvertisingAPIScope, decimal campaignId, decimal pageSize, string startDate, string endDate, string? nextToken = null)

Gets the budget history for a campaign specified by identifier.

The budget history is returned for the time period specified in the required startDate and endDate parameters. The maximum time period is 90 days.  **Requires one of these permissions**: [\"advertiser_campaign_edit\",\"advertiser_campaign_view\"]

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Amazon.Advertising.SponsoredProducts.Api;
using Amazon.Advertising.SponsoredProducts.Client;
using Amazon.Advertising.SponsoredProducts.Model;

namespace Example
{
    public class GetRuleBasedBudgetHistoryForSPCampaignsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new BudgetRulesApi(config);
            var amazonAdvertisingAPIClientId = "amazonAdvertisingAPIClientId_example";  // string | The identifier of a client associated with a Login with Amazon account. This is a required header for advertisers and integrators using the Advertising API.
            var amazonAdvertisingAPIScope = "amazonAdvertisingAPIScope_example";  // string | The identifier of a profile associated with the advertiser account. Use `GET` method on Profiles resource to list profiles associated with the access token passed in the HTTP Authorization header. This is a required header for advertisers and integrators using the Advertising API.
            var campaignId = 8.14D;  // decimal | The campaign identifier.
            var pageSize = 8.14D;  // decimal | Sets a limit on the number of results returned. Maximum limit of `pageSize` is 30.
            var startDate = "startDate_example";  // string | The start date of the budget history in YYYYMMDD format.
            var endDate = "endDate_example";  // string | The end date of the budget history in YYYYMMDD format.
            var nextToken = "nextToken_example";  // string? | To retrieve the next page of results, call the same operation and specify this token in the request. If the `nextToken` field is empty, there are no further results. (optional) 

            try
            {
                // Gets the budget history for a campaign specified by identifier.
                SPBudgetHistory result = apiInstance.GetRuleBasedBudgetHistoryForSPCampaigns(amazonAdvertisingAPIClientId, amazonAdvertisingAPIScope, campaignId, pageSize, startDate, endDate, nextToken);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BudgetRulesApi.GetRuleBasedBudgetHistoryForSPCampaigns: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetRuleBasedBudgetHistoryForSPCampaignsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets the budget history for a campaign specified by identifier.
    ApiResponse<SPBudgetHistory> response = apiInstance.GetRuleBasedBudgetHistoryForSPCampaignsWithHttpInfo(amazonAdvertisingAPIClientId, amazonAdvertisingAPIScope, campaignId, pageSize, startDate, endDate, nextToken);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BudgetRulesApi.GetRuleBasedBudgetHistoryForSPCampaignsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **amazonAdvertisingAPIClientId** | **string** | The identifier of a client associated with a Login with Amazon account. This is a required header for advertisers and integrators using the Advertising API. |  |
| **amazonAdvertisingAPIScope** | **string** | The identifier of a profile associated with the advertiser account. Use &#x60;GET&#x60; method on Profiles resource to list profiles associated with the access token passed in the HTTP Authorization header. This is a required header for advertisers and integrators using the Advertising API. |  |
| **campaignId** | **decimal** | The campaign identifier. |  |
| **pageSize** | **decimal** | Sets a limit on the number of results returned. Maximum limit of &#x60;pageSize&#x60; is 30. |  |
| **startDate** | **string** | The start date of the budget history in YYYYMMDD format. |  |
| **endDate** | **string** | The end date of the budget history in YYYYMMDD format. |  |
| **nextToken** | **string?** | To retrieve the next page of results, call the same operation and specify this token in the request. If the &#x60;nextToken&#x60; field is empty, there are no further results. | [optional]  |

### Return type

[**SPBudgetHistory**](SPBudgetHistory.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation. |  -  |
| **400** | Bad Request. |  -  |
| **422** | Unprocessable entity. The server understood the request, but was unable to process the instruction. |  -  |
| **401** | Unauthorized. The request failed because user is not authenticated or is not allowed to invoke the operation. |  -  |
| **500** | Internal Server Error. Something went wrong on the server. Retry later and report an error if unresolved. |  -  |
| **403** | Forbidden. The request failed because user does not have access to a specified resource. |  -  |
| **429** | Too Many Requests. The request was rate-limited. Retry later. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getspbudgetrulesforadvertiser"></a>
# **GetSPBudgetRulesForAdvertiser**
> GetSPBudgetRulesForAdvertiserResponse GetSPBudgetRulesForAdvertiser (string amazonAdvertisingAPIClientId, string amazonAdvertisingAPIScope, decimal pageSize, string? nextToken = null)

Get all budget rules created by an advertiser

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Amazon.Advertising.SponsoredProducts.Api;
using Amazon.Advertising.SponsoredProducts.Client;
using Amazon.Advertising.SponsoredProducts.Model;

namespace Example
{
    public class GetSPBudgetRulesForAdvertiserExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new BudgetRulesApi(config);
            var amazonAdvertisingAPIClientId = "amazonAdvertisingAPIClientId_example";  // string | The identifier of a client associated with a \"Login with Amazon\" account. This is a required header for advertisers and integrators using the Advertising API.
            var amazonAdvertisingAPIScope = "amazonAdvertisingAPIScope_example";  // string | The identifier of a profile associated with the advertiser account. Use `GET` method on Profiles resource to list profiles associated with the access token passed in the HTTP Authorization header. This is a required header for advertisers and integrators using the Advertising API.
            var pageSize = 8.14D;  // decimal | Sets a limit on the number of results returned. Maximum limit of `pageSize` is 30.
            var nextToken = "nextToken_example";  // string? | To retrieve the next page of results, call the same operation and specify this token in the request. If the `nextToken` field is empty, there are no further results. (optional) 

            try
            {
                // Get all budget rules created by an advertiser
                GetSPBudgetRulesForAdvertiserResponse result = apiInstance.GetSPBudgetRulesForAdvertiser(amazonAdvertisingAPIClientId, amazonAdvertisingAPIScope, pageSize, nextToken);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BudgetRulesApi.GetSPBudgetRulesForAdvertiser: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetSPBudgetRulesForAdvertiserWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get all budget rules created by an advertiser
    ApiResponse<GetSPBudgetRulesForAdvertiserResponse> response = apiInstance.GetSPBudgetRulesForAdvertiserWithHttpInfo(amazonAdvertisingAPIClientId, amazonAdvertisingAPIScope, pageSize, nextToken);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BudgetRulesApi.GetSPBudgetRulesForAdvertiserWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **amazonAdvertisingAPIClientId** | **string** | The identifier of a client associated with a \&quot;Login with Amazon\&quot; account. This is a required header for advertisers and integrators using the Advertising API. |  |
| **amazonAdvertisingAPIScope** | **string** | The identifier of a profile associated with the advertiser account. Use &#x60;GET&#x60; method on Profiles resource to list profiles associated with the access token passed in the HTTP Authorization header. This is a required header for advertisers and integrators using the Advertising API. |  |
| **pageSize** | **decimal** | Sets a limit on the number of results returned. Maximum limit of &#x60;pageSize&#x60; is 30. |  |
| **nextToken** | **string?** | To retrieve the next page of results, call the same operation and specify this token in the request. If the &#x60;nextToken&#x60; field is empty, there are no further results. | [optional]  |

### Return type

[**GetSPBudgetRulesForAdvertiserResponse**](GetSPBudgetRulesForAdvertiserResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation. |  -  |
| **400** | Bad Request. |  -  |
| **422** | Unprocessable entity. The server understood the request, but was unable to process the instruction. |  -  |
| **401** | Unauthorized. The request failed because the user is not authenticated or is not allowed to invoke the operation. |  -  |
| **500** | Internal Server Error. Something went wrong on the server. Retry later and report an error if unresolved. |  -  |
| **403** | Forbidden. The request failed because user does not have access to a specified resource. |  -  |
| **429** | Too Many Requests. The request was rate-limited. Retry later. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listassociatedbudgetrulesforspcampaigns"></a>
# **ListAssociatedBudgetRulesForSPCampaigns**
> SPListAssociatedBudgetRulesResponse ListAssociatedBudgetRulesForSPCampaigns (string amazonAdvertisingAPIClientId, string amazonAdvertisingAPIScope, decimal campaignId)

Gets a list of budget rules associated to a campaign specified by identifier.

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
    public class ListAssociatedBudgetRulesForSPCampaignsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new BudgetRulesApi(config);
            var amazonAdvertisingAPIClientId = "amazonAdvertisingAPIClientId_example";  // string | The identifier of a client associated with a \"Login with Amazon\" account. This is a required header for advertisers and integrators using the Advertising API.
            var amazonAdvertisingAPIScope = "amazonAdvertisingAPIScope_example";  // string | The identifier of a profile associated with the advertiser account. Use `GET` method on Profiles resource to list profiles associated with the access token passed in the HTTP Authorization header. This is a required header for advertisers and integrators using the Advertising API.
            var campaignId = 8.14D;  // decimal | The campaign identifier.

            try
            {
                // Gets a list of budget rules associated to a campaign specified by identifier.
                SPListAssociatedBudgetRulesResponse result = apiInstance.ListAssociatedBudgetRulesForSPCampaigns(amazonAdvertisingAPIClientId, amazonAdvertisingAPIScope, campaignId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BudgetRulesApi.ListAssociatedBudgetRulesForSPCampaigns: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListAssociatedBudgetRulesForSPCampaignsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets a list of budget rules associated to a campaign specified by identifier.
    ApiResponse<SPListAssociatedBudgetRulesResponse> response = apiInstance.ListAssociatedBudgetRulesForSPCampaignsWithHttpInfo(amazonAdvertisingAPIClientId, amazonAdvertisingAPIScope, campaignId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BudgetRulesApi.ListAssociatedBudgetRulesForSPCampaignsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **amazonAdvertisingAPIClientId** | **string** | The identifier of a client associated with a \&quot;Login with Amazon\&quot; account. This is a required header for advertisers and integrators using the Advertising API. |  |
| **amazonAdvertisingAPIScope** | **string** | The identifier of a profile associated with the advertiser account. Use &#x60;GET&#x60; method on Profiles resource to list profiles associated with the access token passed in the HTTP Authorization header. This is a required header for advertisers and integrators using the Advertising API. |  |
| **campaignId** | **decimal** | The campaign identifier. |  |

### Return type

[**SPListAssociatedBudgetRulesResponse**](SPListAssociatedBudgetRulesResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation. |  -  |
| **400** | Bad Request |  -  |
| **422** | Unprocessable entity. The server understood the request, but was unable to process the instruction. |  -  |
| **401** | Unauthorized. The request failed because the user is not authenticated or is not allowed to invoke the operation. |  -  |
| **500** | Internal Server Error. Something went wrong on the server. Retry later and report an error if unresolved. |  -  |
| **403** | Forbidden. The request failed because user does not have access to a specified resource. |  -  |
| **429** | Too Many Requests. The request was rate-limited. Retry later. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatebudgetrulesforspcampaigns"></a>
# **UpdateBudgetRulesForSPCampaigns**
> UpdateBudgetRulesResponse UpdateBudgetRulesForSPCampaigns (string amazonAdvertisingAPIClientId, string amazonAdvertisingAPIScope, UpdateSPBudgetRulesRequest updateSPBudgetRulesRequest)

Updates one or more budget rules.

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
    public class UpdateBudgetRulesForSPCampaignsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new BudgetRulesApi(config);
            var amazonAdvertisingAPIClientId = "amazonAdvertisingAPIClientId_example";  // string | The identifier of a client associated with a \"Login with Amazon\" account. This is a required header for advertisers and integrators using the Advertising API.
            var amazonAdvertisingAPIScope = "amazonAdvertisingAPIScope_example";  // string | The identifier of a profile associated with the advertiser account. Use `GET` method on Profiles resource to list profiles associated with the access token passed in the HTTP Authorization header. This is a required header for advertisers and integrators using the Advertising API.
            var updateSPBudgetRulesRequest = new UpdateSPBudgetRulesRequest(); // UpdateSPBudgetRulesRequest | 

            try
            {
                // Updates one or more budget rules.
                UpdateBudgetRulesResponse result = apiInstance.UpdateBudgetRulesForSPCampaigns(amazonAdvertisingAPIClientId, amazonAdvertisingAPIScope, updateSPBudgetRulesRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BudgetRulesApi.UpdateBudgetRulesForSPCampaigns: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateBudgetRulesForSPCampaignsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Updates one or more budget rules.
    ApiResponse<UpdateBudgetRulesResponse> response = apiInstance.UpdateBudgetRulesForSPCampaignsWithHttpInfo(amazonAdvertisingAPIClientId, amazonAdvertisingAPIScope, updateSPBudgetRulesRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BudgetRulesApi.UpdateBudgetRulesForSPCampaignsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **amazonAdvertisingAPIClientId** | **string** | The identifier of a client associated with a \&quot;Login with Amazon\&quot; account. This is a required header for advertisers and integrators using the Advertising API. |  |
| **amazonAdvertisingAPIScope** | **string** | The identifier of a profile associated with the advertiser account. Use &#x60;GET&#x60; method on Profiles resource to list profiles associated with the access token passed in the HTTP Authorization header. This is a required header for advertisers and integrators using the Advertising API. |  |
| **updateSPBudgetRulesRequest** | [**UpdateSPBudgetRulesRequest**](UpdateSPBudgetRulesRequest.md) |  |  |

### Return type

[**UpdateBudgetRulesResponse**](UpdateBudgetRulesResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **400** | Bad Request. |  -  |
| **422** | Unprocessable entity. The server understood the request, but was unable to process the instruction. |  -  |
| **401** | Unauthorized. The request failed because the user is not authenticated or is not allowed to invoke the operation. |  -  |
| **500** | Internal Server Error. Something went wrong on the server. Retry later and report an error if unresolved. |  -  |
| **403** | Forbidden. The request failed because user does not have access to a specified resource. |  -  |
| **207** | Multi-status. An object containing a list of budget rule response objects reflecting the same order as the input. |  -  |
| **429** | Too Many Requests. The request was rate-limited. Retry later. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

