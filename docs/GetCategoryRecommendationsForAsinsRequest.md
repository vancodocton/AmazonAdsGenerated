# Amazon.Advertising.SponsoredProducts.Model.GetCategoryRecommendationsForAsinsRequest
Request object to retrieve Category Recommendations based on the input ASINs.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Asins** | **List&lt;string&gt;** | List of input ASINs. This API does not check if the ASINs are valid ASINs. | [optional] 
**IncludeAncestor** | **bool** | Enable this if you would like to retrieve categories which are ancestor nodes of the original recommended categories. This may increase the number of categories returned, but decrease the relevancy of those categories. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

