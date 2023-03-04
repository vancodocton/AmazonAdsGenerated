# Amazon.Advertising.SponsoredProducts.Model.TargetingGroupBidRecommendation
Contains suggested recommendation for the auto targeting group.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SuggestedBid** | **double** | The suggested bid value associated with this targeting. | [optional] 
**TargetId** | **string** | The target identifier. | [optional] 
**TargetingGroupExpression** | **string** | The type of targeting group expression. | Value | Description | | - -- | - -- | | &#x60;LOOSE_MATCH&#x60; | This will show your ad to shoppers who use search terms loosely related to your products.| | &#x60;CLOSE_MATCH&#x60; | This will show your ad to shoppers who use search terms closely related to your products.| | &#x60;COMPLEMENTS&#x60; | This will show your ad to shoppers who view the detail pages of products that complement your product.| | &#x60;SUBSTITUTES&#x60; | This will show your ad to shoppers who use detail pages of products similar to yours.| | [optional] 
**Action** | **string** | Type of suggested action. | [optional] 
**AdGroupId** | **string** | The ad group identifier. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

