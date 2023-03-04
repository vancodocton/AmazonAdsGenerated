# Amazon.Advertising.SponsoredProducts.Model.SponsoredProductsBiddingStrategy
The bidding strategy. | Value | Strategy name | Description | |- -- -- -- -- -- -- -- -|- -- -- -- -- -- -- --|- -- -- -- -- -- --| | `LEGACY_FOR_SALES` | Dynamic bids - down only | Lowers your bids in real time when your ad may be less likely to convert to a sale. Campaigns created before the release of the bidding controls feature used this setting by default. | | `AUTO_FOR_SALES` | Dynamic bids - up and down | Increases or decreases your bids in real time by a maximum of 100%. With this setting bids increase when your ad is more likely to convert to a sale, and bids decrease when less likely to convert to a sale. | | `MANUAL` | Fixed bid | Uses your exact bid and any placement adjustments you set, and is not subject to dynamic bidding. | | `RULE_BASED` | Rule based bidding | See Rule based bidding documentation https://advertising.amazon.com/API/docs/en-us/sponsored-products/rule-based-bidding/overview |

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

