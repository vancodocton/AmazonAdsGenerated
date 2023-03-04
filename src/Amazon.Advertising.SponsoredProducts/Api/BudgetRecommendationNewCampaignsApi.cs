/*
 * Sponsored Products
 *
 *  
 *
 * The version of the OpenAPI document: 3.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using Amazon.Advertising.SponsoredProducts.Client;
using Amazon.Advertising.SponsoredProducts.Model;

namespace Amazon.Advertising.SponsoredProducts.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IBudgetRecommendationNewCampaignsApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Creates daily budget recommendation along with benchmark metrics when creating a new campaign.
        /// </remarks>
        /// <exception cref="Amazon.Advertising.SponsoredProducts.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="amazonAdvertisingAPIClientId">The identifier of a client associated with a \&quot;Login with Amazon\&quot; account.</param>
        /// <param name="amazonAdvertisingAPIScope">The identifier of a profile associated with the advertiser account. Use &#x60;GET&#x60; method on Profiles resource to list profiles associated with the access token passed in the HTTP Authorization header and choose profile id &#x60;profileId&#x60; from the response to pass it as input.</param>
        /// <param name="initialBudgetRecommendationRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>InitialBudgetRecommendationResponse</returns>
        InitialBudgetRecommendationResponse GetBudgetRecommendation(string amazonAdvertisingAPIClientId, string amazonAdvertisingAPIScope, InitialBudgetRecommendationRequest? initialBudgetRecommendationRequest = default(InitialBudgetRecommendationRequest?), int operationIndex = 0);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Creates daily budget recommendation along with benchmark metrics when creating a new campaign.
        /// </remarks>
        /// <exception cref="Amazon.Advertising.SponsoredProducts.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="amazonAdvertisingAPIClientId">The identifier of a client associated with a \&quot;Login with Amazon\&quot; account.</param>
        /// <param name="amazonAdvertisingAPIScope">The identifier of a profile associated with the advertiser account. Use &#x60;GET&#x60; method on Profiles resource to list profiles associated with the access token passed in the HTTP Authorization header and choose profile id &#x60;profileId&#x60; from the response to pass it as input.</param>
        /// <param name="initialBudgetRecommendationRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of InitialBudgetRecommendationResponse</returns>
        ApiResponse<InitialBudgetRecommendationResponse> GetBudgetRecommendationWithHttpInfo(string amazonAdvertisingAPIClientId, string amazonAdvertisingAPIScope, InitialBudgetRecommendationRequest? initialBudgetRecommendationRequest = default(InitialBudgetRecommendationRequest?), int operationIndex = 0);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IBudgetRecommendationNewCampaignsApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Creates daily budget recommendation along with benchmark metrics when creating a new campaign.
        /// </remarks>
        /// <exception cref="Amazon.Advertising.SponsoredProducts.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="amazonAdvertisingAPIClientId">The identifier of a client associated with a \&quot;Login with Amazon\&quot; account.</param>
        /// <param name="amazonAdvertisingAPIScope">The identifier of a profile associated with the advertiser account. Use &#x60;GET&#x60; method on Profiles resource to list profiles associated with the access token passed in the HTTP Authorization header and choose profile id &#x60;profileId&#x60; from the response to pass it as input.</param>
        /// <param name="initialBudgetRecommendationRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of InitialBudgetRecommendationResponse</returns>
        System.Threading.Tasks.Task<InitialBudgetRecommendationResponse> GetBudgetRecommendationAsync(string amazonAdvertisingAPIClientId, string amazonAdvertisingAPIScope, InitialBudgetRecommendationRequest? initialBudgetRecommendationRequest = default(InitialBudgetRecommendationRequest?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Creates daily budget recommendation along with benchmark metrics when creating a new campaign.
        /// </remarks>
        /// <exception cref="Amazon.Advertising.SponsoredProducts.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="amazonAdvertisingAPIClientId">The identifier of a client associated with a \&quot;Login with Amazon\&quot; account.</param>
        /// <param name="amazonAdvertisingAPIScope">The identifier of a profile associated with the advertiser account. Use &#x60;GET&#x60; method on Profiles resource to list profiles associated with the access token passed in the HTTP Authorization header and choose profile id &#x60;profileId&#x60; from the response to pass it as input.</param>
        /// <param name="initialBudgetRecommendationRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (InitialBudgetRecommendationResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<InitialBudgetRecommendationResponse>> GetBudgetRecommendationWithHttpInfoAsync(string amazonAdvertisingAPIClientId, string amazonAdvertisingAPIScope, InitialBudgetRecommendationRequest? initialBudgetRecommendationRequest = default(InitialBudgetRecommendationRequest?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IBudgetRecommendationNewCampaignsApi : IBudgetRecommendationNewCampaignsApiSync, IBudgetRecommendationNewCampaignsApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class BudgetRecommendationNewCampaignsApi : IBudgetRecommendationNewCampaignsApi
    {
        private Amazon.Advertising.SponsoredProducts.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="BudgetRecommendationNewCampaignsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public BudgetRecommendationNewCampaignsApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BudgetRecommendationNewCampaignsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public BudgetRecommendationNewCampaignsApi(string basePath)
        {
            this.Configuration = Amazon.Advertising.SponsoredProducts.Client.Configuration.MergeConfigurations(
                Amazon.Advertising.SponsoredProducts.Client.GlobalConfiguration.Instance,
                new Amazon.Advertising.SponsoredProducts.Client.Configuration { BasePath = basePath }
            );
            this.Client = new Amazon.Advertising.SponsoredProducts.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Amazon.Advertising.SponsoredProducts.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = Amazon.Advertising.SponsoredProducts.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BudgetRecommendationNewCampaignsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public BudgetRecommendationNewCampaignsApi(Amazon.Advertising.SponsoredProducts.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = Amazon.Advertising.SponsoredProducts.Client.Configuration.MergeConfigurations(
                Amazon.Advertising.SponsoredProducts.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new Amazon.Advertising.SponsoredProducts.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Amazon.Advertising.SponsoredProducts.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = Amazon.Advertising.SponsoredProducts.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BudgetRecommendationNewCampaignsApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public BudgetRecommendationNewCampaignsApi(Amazon.Advertising.SponsoredProducts.Client.ISynchronousClient client, Amazon.Advertising.SponsoredProducts.Client.IAsynchronousClient asyncClient, Amazon.Advertising.SponsoredProducts.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = Amazon.Advertising.SponsoredProducts.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public Amazon.Advertising.SponsoredProducts.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public Amazon.Advertising.SponsoredProducts.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public string GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Amazon.Advertising.SponsoredProducts.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Amazon.Advertising.SponsoredProducts.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        ///  Creates daily budget recommendation along with benchmark metrics when creating a new campaign.
        /// </summary>
        /// <exception cref="Amazon.Advertising.SponsoredProducts.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="amazonAdvertisingAPIClientId">The identifier of a client associated with a \&quot;Login with Amazon\&quot; account.</param>
        /// <param name="amazonAdvertisingAPIScope">The identifier of a profile associated with the advertiser account. Use &#x60;GET&#x60; method on Profiles resource to list profiles associated with the access token passed in the HTTP Authorization header and choose profile id &#x60;profileId&#x60; from the response to pass it as input.</param>
        /// <param name="initialBudgetRecommendationRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>InitialBudgetRecommendationResponse</returns>
        public InitialBudgetRecommendationResponse GetBudgetRecommendation(string amazonAdvertisingAPIClientId, string amazonAdvertisingAPIScope, InitialBudgetRecommendationRequest? initialBudgetRecommendationRequest = default(InitialBudgetRecommendationRequest?), int operationIndex = 0)
        {
            Amazon.Advertising.SponsoredProducts.Client.ApiResponse<InitialBudgetRecommendationResponse> localVarResponse = GetBudgetRecommendationWithHttpInfo(amazonAdvertisingAPIClientId, amazonAdvertisingAPIScope, initialBudgetRecommendationRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  Creates daily budget recommendation along with benchmark metrics when creating a new campaign.
        /// </summary>
        /// <exception cref="Amazon.Advertising.SponsoredProducts.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="amazonAdvertisingAPIClientId">The identifier of a client associated with a \&quot;Login with Amazon\&quot; account.</param>
        /// <param name="amazonAdvertisingAPIScope">The identifier of a profile associated with the advertiser account. Use &#x60;GET&#x60; method on Profiles resource to list profiles associated with the access token passed in the HTTP Authorization header and choose profile id &#x60;profileId&#x60; from the response to pass it as input.</param>
        /// <param name="initialBudgetRecommendationRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of InitialBudgetRecommendationResponse</returns>
        public Amazon.Advertising.SponsoredProducts.Client.ApiResponse<InitialBudgetRecommendationResponse> GetBudgetRecommendationWithHttpInfo(string amazonAdvertisingAPIClientId, string amazonAdvertisingAPIScope, InitialBudgetRecommendationRequest? initialBudgetRecommendationRequest = default(InitialBudgetRecommendationRequest?), int operationIndex = 0)
        {
            // verify the required parameter 'amazonAdvertisingAPIClientId' is set
            if (amazonAdvertisingAPIClientId == null)
            {
                throw new Amazon.Advertising.SponsoredProducts.Client.ApiException(400, "Missing required parameter 'amazonAdvertisingAPIClientId' when calling BudgetRecommendationNewCampaignsApi->GetBudgetRecommendation");
            }

            // verify the required parameter 'amazonAdvertisingAPIScope' is set
            if (amazonAdvertisingAPIScope == null)
            {
                throw new Amazon.Advertising.SponsoredProducts.Client.ApiException(400, "Missing required parameter 'amazonAdvertisingAPIScope' when calling BudgetRecommendationNewCampaignsApi->GetBudgetRecommendation");
            }

            Amazon.Advertising.SponsoredProducts.Client.RequestOptions localVarRequestOptions = new Amazon.Advertising.SponsoredProducts.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/vnd.spinitialbudgetrecommendation.v3.4+json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/vnd.spinitialbudgetrecommendation.v3.4+json"
            };

            var localVarContentType = Amazon.Advertising.SponsoredProducts.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Amazon.Advertising.SponsoredProducts.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.HeaderParameters.Add("Amazon-Advertising-API-ClientId", Amazon.Advertising.SponsoredProducts.Client.ClientUtils.ParameterToString(amazonAdvertisingAPIClientId)); // header parameter
            localVarRequestOptions.HeaderParameters.Add("Amazon-Advertising-API-Scope", Amazon.Advertising.SponsoredProducts.Client.ClientUtils.ParameterToString(amazonAdvertisingAPIScope)); // header parameter
            localVarRequestOptions.Data = initialBudgetRecommendationRequest;

            localVarRequestOptions.Operation = "BudgetRecommendationNewCampaignsApi.GetBudgetRecommendation";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = this.Client.Post<InitialBudgetRecommendationResponse>("/sp/campaigns/initialBudgetRecommendation", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetBudgetRecommendation", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  Creates daily budget recommendation along with benchmark metrics when creating a new campaign.
        /// </summary>
        /// <exception cref="Amazon.Advertising.SponsoredProducts.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="amazonAdvertisingAPIClientId">The identifier of a client associated with a \&quot;Login with Amazon\&quot; account.</param>
        /// <param name="amazonAdvertisingAPIScope">The identifier of a profile associated with the advertiser account. Use &#x60;GET&#x60; method on Profiles resource to list profiles associated with the access token passed in the HTTP Authorization header and choose profile id &#x60;profileId&#x60; from the response to pass it as input.</param>
        /// <param name="initialBudgetRecommendationRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of InitialBudgetRecommendationResponse</returns>
        public async System.Threading.Tasks.Task<InitialBudgetRecommendationResponse> GetBudgetRecommendationAsync(string amazonAdvertisingAPIClientId, string amazonAdvertisingAPIScope, InitialBudgetRecommendationRequest? initialBudgetRecommendationRequest = default(InitialBudgetRecommendationRequest?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Amazon.Advertising.SponsoredProducts.Client.ApiResponse<InitialBudgetRecommendationResponse> localVarResponse = await GetBudgetRecommendationWithHttpInfoAsync(amazonAdvertisingAPIClientId, amazonAdvertisingAPIScope, initialBudgetRecommendationRequest, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  Creates daily budget recommendation along with benchmark metrics when creating a new campaign.
        /// </summary>
        /// <exception cref="Amazon.Advertising.SponsoredProducts.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="amazonAdvertisingAPIClientId">The identifier of a client associated with a \&quot;Login with Amazon\&quot; account.</param>
        /// <param name="amazonAdvertisingAPIScope">The identifier of a profile associated with the advertiser account. Use &#x60;GET&#x60; method on Profiles resource to list profiles associated with the access token passed in the HTTP Authorization header and choose profile id &#x60;profileId&#x60; from the response to pass it as input.</param>
        /// <param name="initialBudgetRecommendationRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (InitialBudgetRecommendationResponse)</returns>
        public async System.Threading.Tasks.Task<Amazon.Advertising.SponsoredProducts.Client.ApiResponse<InitialBudgetRecommendationResponse>> GetBudgetRecommendationWithHttpInfoAsync(string amazonAdvertisingAPIClientId, string amazonAdvertisingAPIScope, InitialBudgetRecommendationRequest? initialBudgetRecommendationRequest = default(InitialBudgetRecommendationRequest?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'amazonAdvertisingAPIClientId' is set
            if (amazonAdvertisingAPIClientId == null)
            {
                throw new Amazon.Advertising.SponsoredProducts.Client.ApiException(400, "Missing required parameter 'amazonAdvertisingAPIClientId' when calling BudgetRecommendationNewCampaignsApi->GetBudgetRecommendation");
            }

            // verify the required parameter 'amazonAdvertisingAPIScope' is set
            if (amazonAdvertisingAPIScope == null)
            {
                throw new Amazon.Advertising.SponsoredProducts.Client.ApiException(400, "Missing required parameter 'amazonAdvertisingAPIScope' when calling BudgetRecommendationNewCampaignsApi->GetBudgetRecommendation");
            }


            Amazon.Advertising.SponsoredProducts.Client.RequestOptions localVarRequestOptions = new Amazon.Advertising.SponsoredProducts.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/vnd.spinitialbudgetrecommendation.v3.4+json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/vnd.spinitialbudgetrecommendation.v3.4+json"
            };

            var localVarContentType = Amazon.Advertising.SponsoredProducts.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Amazon.Advertising.SponsoredProducts.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.HeaderParameters.Add("Amazon-Advertising-API-ClientId", Amazon.Advertising.SponsoredProducts.Client.ClientUtils.ParameterToString(amazonAdvertisingAPIClientId)); // header parameter
            localVarRequestOptions.HeaderParameters.Add("Amazon-Advertising-API-Scope", Amazon.Advertising.SponsoredProducts.Client.ClientUtils.ParameterToString(amazonAdvertisingAPIScope)); // header parameter
            localVarRequestOptions.Data = initialBudgetRecommendationRequest;

            localVarRequestOptions.Operation = "BudgetRecommendationNewCampaignsApi.GetBudgetRecommendation";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.PostAsync<InitialBudgetRecommendationResponse>("/sp/campaigns/initialBudgetRecommendation", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetBudgetRecommendation", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}
