// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Datadog
{
    /// <summary>
    /// A class representing a collection of <see cref="DatadogMonitorResource" /> and their operations.
    /// Each <see cref="DatadogMonitorResource" /> in the collection will belong to the same instance of <see cref="ResourceGroupResource" />.
    /// To get a <see cref="DatadogMonitorResourceCollection" /> instance call the GetDatadogMonitorResources method from an instance of <see cref="ResourceGroupResource" />.
    /// </summary>
    public partial class DatadogMonitorResourceCollection : ArmCollection, IEnumerable<DatadogMonitorResource>, IAsyncEnumerable<DatadogMonitorResource>
    {
        private readonly ClientDiagnostics _datadogMonitorResourceMonitorsClientDiagnostics;
        private readonly MonitorsRestOperations _datadogMonitorResourceMonitorsRestClient;

        /// <summary> Initializes a new instance of the <see cref="DatadogMonitorResourceCollection"/> class for mocking. </summary>
        protected DatadogMonitorResourceCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="DatadogMonitorResourceCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal DatadogMonitorResourceCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _datadogMonitorResourceMonitorsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Datadog", DatadogMonitorResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(DatadogMonitorResource.ResourceType, out string datadogMonitorResourceMonitorsApiVersion);
            _datadogMonitorResourceMonitorsRestClient = new MonitorsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, datadogMonitorResourceMonitorsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroupResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroupResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create a monitor resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Datadog/monitors/{monitorName}
        /// Operation Id: Monitors_Create
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="monitorName"> Monitor resource name. </param>
        /// <param name="data"> The DatadogMonitorResource to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="monitorName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="monitorName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<DatadogMonitorResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string monitorName, DatadogMonitorResourceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(monitorName, nameof(monitorName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _datadogMonitorResourceMonitorsClientDiagnostics.CreateScope("DatadogMonitorResourceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _datadogMonitorResourceMonitorsRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, monitorName, data, cancellationToken).ConfigureAwait(false);
                var operation = new DatadogArmOperation<DatadogMonitorResource>(new DatadogMonitorResourceOperationSource(Client), _datadogMonitorResourceMonitorsClientDiagnostics, Pipeline, _datadogMonitorResourceMonitorsRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, monitorName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Create a monitor resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Datadog/monitors/{monitorName}
        /// Operation Id: Monitors_Create
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="monitorName"> Monitor resource name. </param>
        /// <param name="data"> The DatadogMonitorResource to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="monitorName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="monitorName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<DatadogMonitorResource> CreateOrUpdate(WaitUntil waitUntil, string monitorName, DatadogMonitorResourceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(monitorName, nameof(monitorName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _datadogMonitorResourceMonitorsClientDiagnostics.CreateScope("DatadogMonitorResourceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _datadogMonitorResourceMonitorsRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, monitorName, data, cancellationToken);
                var operation = new DatadogArmOperation<DatadogMonitorResource>(new DatadogMonitorResourceOperationSource(Client), _datadogMonitorResourceMonitorsClientDiagnostics, Pipeline, _datadogMonitorResourceMonitorsRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, monitorName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the properties of a specific monitor resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Datadog/monitors/{monitorName}
        /// Operation Id: Monitors_Get
        /// </summary>
        /// <param name="monitorName"> Monitor resource name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="monitorName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="monitorName"/> is null. </exception>
        public virtual async Task<Response<DatadogMonitorResource>> GetAsync(string monitorName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(monitorName, nameof(monitorName));

            using var scope = _datadogMonitorResourceMonitorsClientDiagnostics.CreateScope("DatadogMonitorResourceCollection.Get");
            scope.Start();
            try
            {
                var response = await _datadogMonitorResourceMonitorsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, monitorName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DatadogMonitorResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the properties of a specific monitor resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Datadog/monitors/{monitorName}
        /// Operation Id: Monitors_Get
        /// </summary>
        /// <param name="monitorName"> Monitor resource name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="monitorName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="monitorName"/> is null. </exception>
        public virtual Response<DatadogMonitorResource> Get(string monitorName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(monitorName, nameof(monitorName));

            using var scope = _datadogMonitorResourceMonitorsClientDiagnostics.CreateScope("DatadogMonitorResourceCollection.Get");
            scope.Start();
            try
            {
                var response = _datadogMonitorResourceMonitorsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, monitorName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DatadogMonitorResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List all monitors under the specified resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Datadog/monitors
        /// Operation Id: Monitors_ListByResourceGroup
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DatadogMonitorResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DatadogMonitorResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<DatadogMonitorResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _datadogMonitorResourceMonitorsClientDiagnostics.CreateScope("DatadogMonitorResourceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _datadogMonitorResourceMonitorsRestClient.ListByResourceGroupAsync(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new DatadogMonitorResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<DatadogMonitorResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _datadogMonitorResourceMonitorsClientDiagnostics.CreateScope("DatadogMonitorResourceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _datadogMonitorResourceMonitorsRestClient.ListByResourceGroupNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new DatadogMonitorResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// List all monitors under the specified resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Datadog/monitors
        /// Operation Id: Monitors_ListByResourceGroup
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DatadogMonitorResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DatadogMonitorResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<DatadogMonitorResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _datadogMonitorResourceMonitorsClientDiagnostics.CreateScope("DatadogMonitorResourceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _datadogMonitorResourceMonitorsRestClient.ListByResourceGroup(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new DatadogMonitorResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<DatadogMonitorResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _datadogMonitorResourceMonitorsClientDiagnostics.CreateScope("DatadogMonitorResourceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _datadogMonitorResourceMonitorsRestClient.ListByResourceGroupNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new DatadogMonitorResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Datadog/monitors/{monitorName}
        /// Operation Id: Monitors_Get
        /// </summary>
        /// <param name="monitorName"> Monitor resource name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="monitorName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="monitorName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string monitorName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(monitorName, nameof(monitorName));

            using var scope = _datadogMonitorResourceMonitorsClientDiagnostics.CreateScope("DatadogMonitorResourceCollection.Exists");
            scope.Start();
            try
            {
                var response = await _datadogMonitorResourceMonitorsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, monitorName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Datadog/monitors/{monitorName}
        /// Operation Id: Monitors_Get
        /// </summary>
        /// <param name="monitorName"> Monitor resource name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="monitorName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="monitorName"/> is null. </exception>
        public virtual Response<bool> Exists(string monitorName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(monitorName, nameof(monitorName));

            using var scope = _datadogMonitorResourceMonitorsClientDiagnostics.CreateScope("DatadogMonitorResourceCollection.Exists");
            scope.Start();
            try
            {
                var response = _datadogMonitorResourceMonitorsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, monitorName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<DatadogMonitorResource> IEnumerable<DatadogMonitorResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<DatadogMonitorResource> IAsyncEnumerable<DatadogMonitorResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
