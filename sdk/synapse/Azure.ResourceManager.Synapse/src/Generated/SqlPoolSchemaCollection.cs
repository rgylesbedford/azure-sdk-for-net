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

namespace Azure.ResourceManager.Synapse
{
    /// <summary>
    /// A class representing a collection of <see cref="SqlPoolSchemaResource" /> and their operations.
    /// Each <see cref="SqlPoolSchemaResource" /> in the collection will belong to the same instance of <see cref="SqlPoolResource" />.
    /// To get a <see cref="SqlPoolSchemaCollection" /> instance call the GetSqlPoolSchemas method from an instance of <see cref="SqlPoolResource" />.
    /// </summary>
    public partial class SqlPoolSchemaCollection : ArmCollection, IEnumerable<SqlPoolSchemaResource>, IAsyncEnumerable<SqlPoolSchemaResource>
    {
        private readonly ClientDiagnostics _sqlPoolSchemaClientDiagnostics;
        private readonly SqlPoolSchemasRestOperations _sqlPoolSchemaRestClient;

        /// <summary> Initializes a new instance of the <see cref="SqlPoolSchemaCollection"/> class for mocking. </summary>
        protected SqlPoolSchemaCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SqlPoolSchemaCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SqlPoolSchemaCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _sqlPoolSchemaClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Synapse", SqlPoolSchemaResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SqlPoolSchemaResource.ResourceType, out string sqlPoolSchemaApiVersion);
            _sqlPoolSchemaRestClient = new SqlPoolSchemasRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, sqlPoolSchemaApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SqlPoolResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SqlPoolResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Get Sql Pool schema
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/sqlPools/{sqlPoolName}/schemas/{schemaName}
        /// Operation Id: SqlPoolSchemas_Get
        /// </summary>
        /// <param name="schemaName"> The name of the schema. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="schemaName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="schemaName"/> is null. </exception>
        public virtual async Task<Response<SqlPoolSchemaResource>> GetAsync(string schemaName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(schemaName, nameof(schemaName));

            using var scope = _sqlPoolSchemaClientDiagnostics.CreateScope("SqlPoolSchemaCollection.Get");
            scope.Start();
            try
            {
                var response = await _sqlPoolSchemaRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, schemaName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SqlPoolSchemaResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get Sql Pool schema
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/sqlPools/{sqlPoolName}/schemas/{schemaName}
        /// Operation Id: SqlPoolSchemas_Get
        /// </summary>
        /// <param name="schemaName"> The name of the schema. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="schemaName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="schemaName"/> is null. </exception>
        public virtual Response<SqlPoolSchemaResource> Get(string schemaName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(schemaName, nameof(schemaName));

            using var scope = _sqlPoolSchemaClientDiagnostics.CreateScope("SqlPoolSchemaCollection.Get");
            scope.Start();
            try
            {
                var response = _sqlPoolSchemaRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, schemaName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SqlPoolSchemaResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets schemas of a given SQL pool.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/sqlPools/{sqlPoolName}/schemas
        /// Operation Id: SqlPoolSchemas_List
        /// </summary>
        /// <param name="filter"> An OData filter expression that filters elements in the collection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SqlPoolSchemaResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SqlPoolSchemaResource> GetAllAsync(string filter = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<SqlPoolSchemaResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _sqlPoolSchemaClientDiagnostics.CreateScope("SqlPoolSchemaCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _sqlPoolSchemaRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, filter, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SqlPoolSchemaResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<SqlPoolSchemaResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _sqlPoolSchemaClientDiagnostics.CreateScope("SqlPoolSchemaCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _sqlPoolSchemaRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, filter, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SqlPoolSchemaResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Gets schemas of a given SQL pool.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/sqlPools/{sqlPoolName}/schemas
        /// Operation Id: SqlPoolSchemas_List
        /// </summary>
        /// <param name="filter"> An OData filter expression that filters elements in the collection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SqlPoolSchemaResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SqlPoolSchemaResource> GetAll(string filter = null, CancellationToken cancellationToken = default)
        {
            Page<SqlPoolSchemaResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _sqlPoolSchemaClientDiagnostics.CreateScope("SqlPoolSchemaCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _sqlPoolSchemaRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, filter, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SqlPoolSchemaResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<SqlPoolSchemaResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _sqlPoolSchemaClientDiagnostics.CreateScope("SqlPoolSchemaCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _sqlPoolSchemaRestClient.ListNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, filter, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SqlPoolSchemaResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/sqlPools/{sqlPoolName}/schemas/{schemaName}
        /// Operation Id: SqlPoolSchemas_Get
        /// </summary>
        /// <param name="schemaName"> The name of the schema. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="schemaName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="schemaName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string schemaName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(schemaName, nameof(schemaName));

            using var scope = _sqlPoolSchemaClientDiagnostics.CreateScope("SqlPoolSchemaCollection.Exists");
            scope.Start();
            try
            {
                var response = await _sqlPoolSchemaRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, schemaName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/sqlPools/{sqlPoolName}/schemas/{schemaName}
        /// Operation Id: SqlPoolSchemas_Get
        /// </summary>
        /// <param name="schemaName"> The name of the schema. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="schemaName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="schemaName"/> is null. </exception>
        public virtual Response<bool> Exists(string schemaName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(schemaName, nameof(schemaName));

            using var scope = _sqlPoolSchemaClientDiagnostics.CreateScope("SqlPoolSchemaCollection.Exists");
            scope.Start();
            try
            {
                var response = _sqlPoolSchemaRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, schemaName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SqlPoolSchemaResource> IEnumerable<SqlPoolSchemaResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SqlPoolSchemaResource> IAsyncEnumerable<SqlPoolSchemaResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
