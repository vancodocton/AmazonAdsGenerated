# Amazon.Advertising.SponsoredProducts.Model.SevenDaysMissedOpportunities

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EstimatedMissedSalesLower** | **decimal** | Lower bound estimate of the additional sales the campaign might have generated if it had not run out of budget during the {startDate} to {endDate} period. Provided in local currency. | [optional] 
**EstimatedMissedSalesUpper** | **decimal** | Upper bound estimate of the additional sales the campaign might have generated if it had not run out of budget during the {startDate} to {endDate} period. Provided in local currency. | [optional] 
**EndDate** | **string** | End date of the date range for which missed opportunity metrics are provided (YYYYMMDD). Local time | [optional] 
**EstimatedMissedImpressionsLower** | **int** | Lower bound estimate of the additional impressions the campaign might have generated if it had not run out of budget during the {startDate} to {endDate} period. | [optional] 
**EstimatedMissedClicksLower** | **int** | Lower bound estimate of the additional clicks the campaign might have generated if it had not run out of budget during the {startDate} to {endDate} period. | [optional] 
**EstimatedMissedClicksUpper** | **int** | Upper bound estimate of the additional clicks the campaign might have generated if it had not run out of budget during the {startDate} to {endDate} period. | [optional] 
**EstimatedMissedImpressionsUpper** | **int** | Upper bound estimate of the additional impressions the campaign might have generated if it had not run out of budget during the {startDate} to {endDate} period. | [optional] 
**StartDate** | **string** | Starting date of the date range for which missed opportunity metrics are provided (YYYYMMDD). Local time | [optional] 
**PercentTimeInBudget** | **decimal** | percentage of time the campaign is active with a budget. Provided as a decimal ranging from 0 to 1 (e.g. 0.76 means the campaign was in budget for 76% of the time between the startDate and endDate period) | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

