# Amazon.Advertising.SponsoredProducts.Model.RecKeywordTarget

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SearchTermImpressionShare** | **decimal** | The account-level ad-attributed impression share for the search-term/keyword. Provides percentage share of all ad impressions the advertiser has for the keyword in the last 30 days. This metric helps advertisers identify potential opportunities based on their share on relevant keywords. This information is only available for keywords the advertiser targeted with ad impressions. | [optional] 
**Translation** | **string** | The translation of keyword if a locale is passed in | [optional] 
**BidInfo** | [**List&lt;RecKeywordTargetBidInfoInner&gt;**](RecKeywordTargetBidInfoInner.md) | A list of keyword bid info | [optional] 
**SearchTermImpressionRank** | **decimal** | The account-level ad-attributed impression rank for the search-term/keyword. Provides [1:N] place the advertiser ranks among all advertisers for the keyword by ad impressions in a marketplace in the last 30 days. It tells an advertiser how many advertisers had higher share of ad impressions. This information is only available for keywords the advertiser targeted with ad impressions. | [optional] 
**Keyword** | **string** | The keyword value | [optional] 
**UserSelectedKeyword** | **bool** | Flag that tells if keyword was selected by the user or was recommended by KRS | [optional] 
**RecId** | **string** | The recommended keyword target id | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

