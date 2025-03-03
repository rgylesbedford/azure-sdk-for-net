// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.Quota
{
    /// <summary>
    /// A class representing a collection of <see cref="QuotaRequestDetailResource" /> and their operations.
    /// Each <see cref="QuotaRequestDetailResource" /> in the collection will belong to the same instance of <see cref="ArmResource" />.
    /// To get a <see cref="QuotaRequestDetailCollection" /> instance call the GetQuotaRequestDetails method from an instance of <see cref="ArmResource" />.
    /// </summary>
    public partial class QuotaRequestDetailCollection : ArmCollection, IEnumerable<QuotaRequestDetailResource>, IAsyncEnumerable<QuotaRequestDetailResource>
    {
        private readonly ClientDiagnostics _quotaRequestDetailQuotaRequestStatusClientDiagnostics;
        private readonly QuotaRequestStatusRestOperations _quotaRequestDetailQuotaRequestStatusRestClient;

        /// <summary> Initializes a new instance of the <see cref="QuotaRequestDetailCollection"/> class for mocking. </summary>
        protected QuotaRequestDetailCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="QuotaRequestDetailCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal QuotaRequestDetailCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _quotaRequestDetailQuotaRequestStatusClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Quota", QuotaRequestDetailResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(QuotaRequestDetailResource.ResourceType, out string quotaRequestDetailQuotaRequestStatusApiVersion);
            _quotaRequestDetailQuotaRequestStatusRestClient = new QuotaRequestStatusRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, quotaRequestDetailQuotaRequestStatusApiVersion);
        }

        /// <summary>
        /// Get the quota request details and status by quota request ID for the resources of the resource provider at a specific location. The quota request ID **id** is returned in the response of the PUT operation.
        /// Request Path: /{scope}/providers/Microsoft.Quota/quotaRequests/{id}
        /// Operation Id: QuotaRequestStatus_Get
        /// </summary>
        /// <param name="id"> Quota request ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="id"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        public virtual async Task<Response<QuotaRequestDetailResource>> GetAsync(string id, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(id, nameof(id));

            using var scope = _quotaRequestDetailQuotaRequestStatusClientDiagnostics.CreateScope("QuotaRequestDetailCollection.Get");
            scope.Start();
            try
            {
                var response = await _quotaRequestDetailQuotaRequestStatusRestClient.GetAsync(Id, id, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new QuotaRequestDetailResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the quota request details and status by quota request ID for the resources of the resource provider at a specific location. The quota request ID **id** is returned in the response of the PUT operation.
        /// Request Path: /{scope}/providers/Microsoft.Quota/quotaRequests/{id}
        /// Operation Id: QuotaRequestStatus_Get
        /// </summary>
        /// <param name="id"> Quota request ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="id"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        public virtual Response<QuotaRequestDetailResource> Get(string id, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(id, nameof(id));

            using var scope = _quotaRequestDetailQuotaRequestStatusClientDiagnostics.CreateScope("QuotaRequestDetailCollection.Get");
            scope.Start();
            try
            {
                var response = _quotaRequestDetailQuotaRequestStatusRestClient.Get(Id, id, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new QuotaRequestDetailResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// For the specified scope, get the current quota requests for a one year period ending at the time is made. Use the **oData** filter to select quota requests.
        /// Request Path: /{scope}/providers/Microsoft.Quota/quotaRequests
        /// Operation Id: QuotaRequestStatus_List
        /// </summary>
        /// <param name="filter">
        /// | Field                    | Supported operators  
        /// |---------------------|------------------------
        /// 
        /// |requestSubmitTime | ge, le, eq, gt, lt
        ///  |provisioningState eq {QuotaRequestState}
        ///  |resourceName eq {resourceName}
        /// 
        /// </param>
        /// <param name="top"> Number of records to return. </param>
        /// <param name="skiptoken"> The **Skiptoken** parameter is used only if a previous operation returned a partial result. If a previous response contains a **nextLink** element, its value includes a **skiptoken** parameter that specifies a starting point to use for subsequent calls. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="QuotaRequestDetailResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<QuotaRequestDetailResource> GetAllAsync(string filter = null, int? top = null, string skiptoken = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<QuotaRequestDetailResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _quotaRequestDetailQuotaRequestStatusClientDiagnostics.CreateScope("QuotaRequestDetailCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _quotaRequestDetailQuotaRequestStatusRestClient.ListAsync(Id, filter, top, skiptoken, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new QuotaRequestDetailResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<QuotaRequestDetailResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _quotaRequestDetailQuotaRequestStatusClientDiagnostics.CreateScope("QuotaRequestDetailCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _quotaRequestDetailQuotaRequestStatusRestClient.ListNextPageAsync(nextLink, Id, filter, top, skiptoken, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new QuotaRequestDetailResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// For the specified scope, get the current quota requests for a one year period ending at the time is made. Use the **oData** filter to select quota requests.
        /// Request Path: /{scope}/providers/Microsoft.Quota/quotaRequests
        /// Operation Id: QuotaRequestStatus_List
        /// </summary>
        /// <param name="filter">
        /// | Field                    | Supported operators  
        /// |---------------------|------------------------
        /// 
        /// |requestSubmitTime | ge, le, eq, gt, lt
        ///  |provisioningState eq {QuotaRequestState}
        ///  |resourceName eq {resourceName}
        /// 
        /// </param>
        /// <param name="top"> Number of records to return. </param>
        /// <param name="skiptoken"> The **Skiptoken** parameter is used only if a previous operation returned a partial result. If a previous response contains a **nextLink** element, its value includes a **skiptoken** parameter that specifies a starting point to use for subsequent calls. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="QuotaRequestDetailResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<QuotaRequestDetailResource> GetAll(string filter = null, int? top = null, string skiptoken = null, CancellationToken cancellationToken = default)
        {
            Page<QuotaRequestDetailResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _quotaRequestDetailQuotaRequestStatusClientDiagnostics.CreateScope("QuotaRequestDetailCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _quotaRequestDetailQuotaRequestStatusRestClient.List(Id, filter, top, skiptoken, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new QuotaRequestDetailResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<QuotaRequestDetailResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _quotaRequestDetailQuotaRequestStatusClientDiagnostics.CreateScope("QuotaRequestDetailCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _quotaRequestDetailQuotaRequestStatusRestClient.ListNextPage(nextLink, Id, filter, top, skiptoken, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new QuotaRequestDetailResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /{scope}/providers/Microsoft.Quota/quotaRequests/{id}
        /// Operation Id: QuotaRequestStatus_Get
        /// </summary>
        /// <param name="id"> Quota request ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="id"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string id, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(id, nameof(id));

            using var scope = _quotaRequestDetailQuotaRequestStatusClientDiagnostics.CreateScope("QuotaRequestDetailCollection.Exists");
            scope.Start();
            try
            {
                var response = await _quotaRequestDetailQuotaRequestStatusRestClient.GetAsync(Id, id, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /{scope}/providers/Microsoft.Quota/quotaRequests/{id}
        /// Operation Id: QuotaRequestStatus_Get
        /// </summary>
        /// <param name="id"> Quota request ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="id"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        public virtual Response<bool> Exists(string id, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(id, nameof(id));

            using var scope = _quotaRequestDetailQuotaRequestStatusClientDiagnostics.CreateScope("QuotaRequestDetailCollection.Exists");
            scope.Start();
            try
            {
                var response = _quotaRequestDetailQuotaRequestStatusRestClient.Get(Id, id, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<QuotaRequestDetailResource> IEnumerable<QuotaRequestDetailResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<QuotaRequestDetailResource> IAsyncEnumerable<QuotaRequestDetailResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
