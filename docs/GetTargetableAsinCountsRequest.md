# Amazon.Advertising.SponsoredProducts.Model.GetTargetableAsinCountsRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AgeRanges** | [**List&lt;AgeRange&gt;**](AgeRange.md) | List of Age Ranges. Use the GetRefinementsForCategory to retrieve Age Ranges. Age Ranges are only available for categories related to children&#39;s toys and games. | [optional] 
**Brands** | [**List&lt;Brand&gt;**](Brand.md) | List of Brands. | [optional] 
**Genres** | [**List&lt;Genre&gt;**](Genre.md) | List of Genres. Use the GetRefinementsForCategory to retrieve Genre Node IDs. Genres are only available for categories related to books. | [optional] 
**IsPrimeShipping** | **bool** | Indicates if products have prime shipping | [optional] 
**RatingRange** | [**RatingRange**](RatingRange.md) |  | [optional] 
**Category** | **string** | The category node id. Please use the GetTargetableCategories API or GetCategoryRecommendationsForASINs API to retrieve category IDs. | 
**PriceRange** | [**PriceRange**](PriceRange.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

