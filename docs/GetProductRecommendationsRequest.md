# Amazon.Advertising.SponsoredProducts.Model.GetProductRecommendationsRequest
Request structure to get ASIN recommendations for a set of input ASINs.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Cursor** | **string** | A optional cursor value that can be used to fetch next or previous set of records. | [optional] 
**AdAsins** | **List&lt;string&gt;** | List of input ASINs. | 
**Count** | **int** | Count of objects requested in the response. The count will be applied on the objects returned under &#x60;recommendations&#x60; array in response body.  &lt;ul&gt; &lt;li&gt;Requesting &#x60;application/vnd.spproductrecommendationresponse.themes.v3+json&#x60; mediatype applies the count on &#x60;ThemeRecommendation&#x60; objects.If no count value is passed a default of &#x60;5&#x60; is assumed. The API will return a maximum of &#x60;10&#x60; themes irrespective of how large the count is set. &lt;/li&gt; &lt;li&gt;Requesting &#x60;application/vnd.spproductrecommendationresponse.asins.v3+json&#x60; mediatype applies count on the &#x60;ProductRecommendation&#x60; objects in response body.If no count value is passed a default of &#x60;100&#x60; is assumed. The API will return a maximum of &#x60;1000&#x60; recommendations irrespective of how large the count is set. &lt;/li&gt; &lt;/ul&gt; Please refer the response Schemas for more info. | [optional] 
**Locale** | **string** | Theme names and descriptions will be provided in the language for your supported locale. Available options are en_US (U.S. English), en_GB (UK English), zh_CN (Chinese), es_ES (Spanish), jp_JP (Japanese), de_DE (German), fr_FR (French), it_IT(Italian). If locale is not provided or unsupported, the theme names and descriptions will be returned in U.S. English (en_US). | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

