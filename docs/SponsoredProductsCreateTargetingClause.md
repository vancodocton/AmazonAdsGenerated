# Amazon.Advertising.SponsoredProducts.Model.SponsoredProductsCreateTargetingClause

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Expression** | [**List&lt;SponsoredProductsCreateTargetingExpressionPredicate&gt;**](SponsoredProductsCreateTargetingExpressionPredicate.md) | The targeting expression. | 
**CampaignId** | **string** | The identifier of the campaign to which this target is associated. | 
**ExpressionType** | **SponsoredProductsCreateExpressionType** |  | 
**State** | **SponsoredProductsCreateOrUpdateEntityState** |  | 
**Bid** | **double?** | The bid for ads sourced using the target. Targets that do not have bid values in listTargetingClauses will inherit the defaultBid from the adGroup level. This table details the maximum allowable bid (in local currency) for keywords by marketplace: | Marketplace | Currency | Min / Max bid for SP | | - -- | - -- | - -- | | US | USD | 0.02 / 1000 | | CA | CAD | 0.02 / 1000 | | UK | GBP | 0.02 / 1000 | | DE | EUR | 0.02 / 1000 | | FR | EUR | 0.02 / 1000 | | ES | EUR | 0.02 / 1000 | | IT | EUR | 0.02 / 1000 | | JP | JPY | 2.0 / 100000 | | AU | AUD | 0.10 / 1410 | | AE | AED | 0.24 / 184.0 | | [optional] 
**AdGroupId** | **string** | The identifier of the ad group to which this target is associated. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

