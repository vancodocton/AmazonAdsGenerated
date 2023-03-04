# Amazon.Advertising.SponsoredProducts.Model.BiddingStrategyRecommendation
Contains suggested recommendation for the campaign bidding strategy.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SuggestedBiddingStrategy** | **string** | The suggested bidding strategy value for the campaign. | Value | Strategy name | Description | |- -- -- -- -- -- -- -- -|- -- -- -- -- -- -- --|- -- -- -- -- -- --| | &#x60;LEGACY_FOR_SALES&#x60; | Dynamic bids - down only | Lowers your bids in real time when your ad may be less likely to convert to a sale. Campaigns created before the release of the bidding controls feature used this setting by default. | | &#x60;AUTO_FOR_SALES&#x60; | Dynamic bids - up and down | Increases or decreases your bids in real time by a maximum of 100%. With this setting bids increase when your ad is more likely to convert to a sale, and bids decrease when less likely to convert to a sale. | | &#x60;MANUAL&#x60; | Fixed bid | Uses your exact bid and any placement adjustments you set, and is not subject to dynamic bidding. | | [optional] 
**Action** | **string** | Type of suggested action. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

