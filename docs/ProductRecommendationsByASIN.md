# Amazon.Advertising.SponsoredProducts.Model.ProductRecommendationsByASIN
Product recommendations supplemented with relevant information.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**NextCursor** | **string** | An identifier to fetch next set of &#x60;ProductRecommendation&#x60; records in the result set if available. This will be null when at the end of result set. | [optional] 
**PreviousCursor** | **string** | Optional parameter that links to the previous result set served. This parameter will be null on the first request. | [optional] 
**Recommendations** | [**List&lt;ProductRecommendation&gt;**](ProductRecommendation.md) | An array of &#x60;ProductRecommendation&#x60; objects. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

