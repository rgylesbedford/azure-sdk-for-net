// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.StorageMover.Models;

namespace Azure.ResourceManager.StorageMover
{
    /// <summary>
    /// A Class representing a StorageMoverProject along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="StorageMoverProjectResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetStorageMoverProjectResource method.
    /// Otherwise you can get one from its parent resource <see cref="StorageMoverResource" /> using the GetStorageMoverProject method.
    /// </summary>
    public partial class StorageMoverProjectResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="StorageMoverProjectResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string storageMoverName, string projectName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StorageMover/storageMovers/{storageMoverName}/projects/{projectName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _storageMoverProjectProjectsClientDiagnostics;
        private readonly ProjectsRestOperations _storageMoverProjectProjectsRestClient;
        private readonly StorageMoverProjectData _data;

        /// <summary> Initializes a new instance of the <see cref="StorageMoverProjectResource"/> class for mocking. </summary>
        protected StorageMoverProjectResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "StorageMoverProjectResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal StorageMoverProjectResource(ArmClient client, StorageMoverProjectData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="StorageMoverProjectResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal StorageMoverProjectResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _storageMoverProjectProjectsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.StorageMover", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string storageMoverProjectProjectsApiVersion);
            _storageMoverProjectProjectsRestClient = new ProjectsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, storageMoverProjectProjectsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.StorageMover/storageMovers/projects";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual StorageMoverProjectData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary> Gets a collection of JobDefinitionResources in the StorageMoverProject. </summary>
        /// <returns> An object representing collection of JobDefinitionResources and their operations over a JobDefinitionResource. </returns>
        public virtual JobDefinitionCollection GetJobDefinitions()
        {
            return GetCachedClient(Client => new JobDefinitionCollection(Client, Id));
        }

        /// <summary>
        /// Gets a Job Definition resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StorageMover/storageMovers/{storageMoverName}/projects/{projectName}/jobDefinitions/{jobDefinitionName}
        /// Operation Id: JobDefinitions_Get
        /// </summary>
        /// <param name="jobDefinitionName"> The name of the Job Definition resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="jobDefinitionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="jobDefinitionName"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<JobDefinitionResource>> GetJobDefinitionAsync(string jobDefinitionName, CancellationToken cancellationToken = default)
        {
            return await GetJobDefinitions().GetAsync(jobDefinitionName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets a Job Definition resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StorageMover/storageMovers/{storageMoverName}/projects/{projectName}/jobDefinitions/{jobDefinitionName}
        /// Operation Id: JobDefinitions_Get
        /// </summary>
        /// <param name="jobDefinitionName"> The name of the Job Definition resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="jobDefinitionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="jobDefinitionName"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual Response<JobDefinitionResource> GetJobDefinition(string jobDefinitionName, CancellationToken cancellationToken = default)
        {
            return GetJobDefinitions().Get(jobDefinitionName, cancellationToken);
        }

        /// <summary>
        /// Gets a Project resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StorageMover/storageMovers/{storageMoverName}/projects/{projectName}
        /// Operation Id: Projects_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<StorageMoverProjectResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _storageMoverProjectProjectsClientDiagnostics.CreateScope("StorageMoverProjectResource.Get");
            scope.Start();
            try
            {
                var response = await _storageMoverProjectProjectsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new StorageMoverProjectResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a Project resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StorageMover/storageMovers/{storageMoverName}/projects/{projectName}
        /// Operation Id: Projects_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<StorageMoverProjectResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _storageMoverProjectProjectsClientDiagnostics.CreateScope("StorageMoverProjectResource.Get");
            scope.Start();
            try
            {
                var response = _storageMoverProjectProjectsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new StorageMoverProjectResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes a Project resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StorageMover/storageMovers/{storageMoverName}/projects/{projectName}
        /// Operation Id: Projects_Delete
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _storageMoverProjectProjectsClientDiagnostics.CreateScope("StorageMoverProjectResource.Delete");
            scope.Start();
            try
            {
                var response = await _storageMoverProjectProjectsRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new StorageMoverArmOperation(_storageMoverProjectProjectsClientDiagnostics, Pipeline, _storageMoverProjectProjectsRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes a Project resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StorageMover/storageMovers/{storageMoverName}/projects/{projectName}
        /// Operation Id: Projects_Delete
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _storageMoverProjectProjectsClientDiagnostics.CreateScope("StorageMoverProjectResource.Delete");
            scope.Start();
            try
            {
                var response = _storageMoverProjectProjectsRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new StorageMoverArmOperation(_storageMoverProjectProjectsClientDiagnostics, Pipeline, _storageMoverProjectProjectsRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletionResponse(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Updates properties for a Project resource. Properties not specified in the request body will be unchanged.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StorageMover/storageMovers/{storageMoverName}/projects/{projectName}
        /// Operation Id: Projects_Update
        /// </summary>
        /// <param name="patch"> The StorageMoverProjectPatch to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="patch"/> is null. </exception>
        public virtual async Task<Response<StorageMoverProjectResource>> UpdateAsync(StorageMoverProjectPatch patch, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(patch, nameof(patch));

            using var scope = _storageMoverProjectProjectsClientDiagnostics.CreateScope("StorageMoverProjectResource.Update");
            scope.Start();
            try
            {
                var response = await _storageMoverProjectProjectsRestClient.UpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, patch, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new StorageMoverProjectResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Updates properties for a Project resource. Properties not specified in the request body will be unchanged.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StorageMover/storageMovers/{storageMoverName}/projects/{projectName}
        /// Operation Id: Projects_Update
        /// </summary>
        /// <param name="patch"> The StorageMoverProjectPatch to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="patch"/> is null. </exception>
        public virtual Response<StorageMoverProjectResource> Update(StorageMoverProjectPatch patch, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(patch, nameof(patch));

            using var scope = _storageMoverProjectProjectsClientDiagnostics.CreateScope("StorageMoverProjectResource.Update");
            scope.Start();
            try
            {
                var response = _storageMoverProjectProjectsRestClient.Update(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, patch, cancellationToken);
                return Response.FromValue(new StorageMoverProjectResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
