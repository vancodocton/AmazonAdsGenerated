# Amazon.Advertising.SponsoredProducts.Model.AdGroupKeywordTargetRankRecommendationRequest
This request type is used to retrieve recommended keyword targets for an existing ad group. Set the recommendationType to KEYWORD_FOR_ADGROUP to use this request type.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CampaignId** | **string** | The identifier of the campaign | 
**RecommendationType** | **string** | The recommendationType to retrieve recommended keyword targets for an existing ad group. | 
**AdGroupId** | **string** | The identifier of the ad group | 
**MaxRecommendations** | **decimal** | The max size of recommended target. Set it to 0 if you only want to rank user-defined keywords. | [optional] [default to 200M]
**SortDimension** | **string** | The ranking metric value. Supported values: CLICKS, CONVERSIONS, DEFAULT. DEFAULT will be applied if no value passed in. | [optional] 
**Locale** | **string** | Translations are for readability and do not affect the targeting of ads. Supported marketplace to locale mappings can be found at the &lt;a href&#x3D;&#39;https://advertising.amazon.com/API/docs/en-us/localization/#/Keyword%20Localization&#39;&gt;POST /keywords/localize&lt;/a&gt; endpoint. Note: Translations will be null if locale is unsupported. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

