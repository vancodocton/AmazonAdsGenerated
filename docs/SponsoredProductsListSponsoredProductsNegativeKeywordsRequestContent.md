# Amazon.Advertising.SponsoredProducts.Model.SponsoredProductsListSponsoredProductsNegativeKeywordsRequestContent

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CampaignIdFilter** | [**SponsoredProductsReducedObjectIdFilter**](SponsoredProductsReducedObjectIdFilter.md) |  | [optional] 
**StateFilter** | [**SponsoredProductsEntityStateFilter**](SponsoredProductsEntityStateFilter.md) |  | [optional] 
**NegativeKeywordTextFilter** | [**SponsoredProductsKeywordTextFilter**](SponsoredProductsKeywordTextFilter.md) |  | [optional] 
**MaxResults** | **int** | Number of records to include in the paginated response. Defaults to max page size for given API | [optional] 
**NextToken** | **string** | token value allowing to navigate to the next response page | [optional] 
**AdGroupIdFilter** | [**SponsoredProductsReducedObjectIdFilter**](SponsoredProductsReducedObjectIdFilter.md) |  | [optional] 
**IncludeExtendedDataFields** | **bool** | Whether to get entity with extended data fields such as creationDate, lastUpdateDate, servingStatus | [optional] 
**Locale** | **string** | Restricts results to negativeKeywords that match the specified locale. | [optional] 
**NegativeKeywordIdFilter** | [**SponsoredProductsObjectIdFilter**](SponsoredProductsObjectIdFilter.md) |  | [optional] 
**MatchTypeFilter** | [**List&lt;SponsoredProductsNegativeMatchType&gt;**](SponsoredProductsNegativeMatchType.md) | Only the negativeKeyword with the match type that is in this list will be listed | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

