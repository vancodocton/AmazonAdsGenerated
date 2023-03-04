# Amazon.Advertising.SponsoredProducts.Model.SponsoredProductsTargetCampaignAttributes

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**MarketplaceId** | **string** | The identifier of the target marketplace. | 
**EndDate** | **DateTime** | The end date for the campaign in formats according to https://tools.ietf.org/html/rfc3339#section-5.6. | [optional] 
**NameSuffix** | **string** | The name to be appended to the campaign. If new name already exists, a number will be appended i.e. if \&quot;Campaign Name Copy\&quot; exist, we will name it \&quot;Campaign Name Copy 1\&quot; | 
**StartDate** | **DateTime** | The start date of the campaign in formats according to https://tools.ietf.org/html/rfc3339#section-5.6. | [optional] 
**AdvertiserId** | **string** | The advertiser id per the targeted marketplace. Advertiser id per marketplace can fetched through /v2/profiles API. | 
**Budget** | **double** | The budget for the campaign. | [optional] 
**Status** | **SponsoredProductsCreateOrUpdateEntityState** |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

