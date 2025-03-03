// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager;
using Azure.ResourceManager.Kusto.Models;

namespace Azure.ResourceManager.Kusto
{
    public partial class Sample_KustoDataConnectionCollection
    {
        // KustoDatabasesListByCluster
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_KustoDatabasesListByCluster()
        {
            // Generated from example definition: specification/azure-kusto/resource-manager/Microsoft.Kusto/stable/2022-07-07/examples/KustoDataConnectionsListByDatabase.json
            // this example is just showing the usage of "DataConnections_ListByDatabase" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this KustoDatabaseResource created on azure
            // for more information of creating KustoDatabaseResource, please refer to the document of KustoDatabaseResource
            string subscriptionId = "12345678-1234-1234-1234-123456789098";
            string resourceGroupName = "kustorptest";
            string clusterName = "kustoCluster";
            string databaseName = "KustoDatabase8";
            ResourceIdentifier kustoDatabaseResourceId = KustoDatabaseResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName, databaseName);
            KustoDatabaseResource kustoDatabase = client.GetKustoDatabaseResource(kustoDatabaseResourceId);

            // get the collection of this KustoDataConnectionResource
            KustoDataConnectionCollection collection = kustoDatabase.GetKustoDataConnections();

            // invoke the operation and iterate over the result
            await foreach (KustoDataConnectionResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                KustoDataConnectionData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // KustoDataConnectionsEventGridGet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_KustoDataConnectionsEventGridGet()
        {
            // Generated from example definition: specification/azure-kusto/resource-manager/Microsoft.Kusto/stable/2022-07-07/examples/KustoDataConnectionsEventGridGet.json
            // this example is just showing the usage of "DataConnections_Get" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this KustoDatabaseResource created on azure
            // for more information of creating KustoDatabaseResource, please refer to the document of KustoDatabaseResource
            string subscriptionId = "12345678-1234-1234-1234-123456789098";
            string resourceGroupName = "kustorptest";
            string clusterName = "kustoCluster";
            string databaseName = "KustoDatabase8";
            ResourceIdentifier kustoDatabaseResourceId = KustoDatabaseResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName, databaseName);
            KustoDatabaseResource kustoDatabase = client.GetKustoDatabaseResource(kustoDatabaseResourceId);

            // get the collection of this KustoDataConnectionResource
            KustoDataConnectionCollection collection = kustoDatabase.GetKustoDataConnections();

            // invoke the operation
            string dataConnectionName = "dataConnectionTest";
            KustoDataConnectionResource result = await collection.GetAsync(dataConnectionName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            KustoDataConnectionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // KustoDataConnectionsEventGridGet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_KustoDataConnectionsEventGridGet()
        {
            // Generated from example definition: specification/azure-kusto/resource-manager/Microsoft.Kusto/stable/2022-07-07/examples/KustoDataConnectionsEventGridGet.json
            // this example is just showing the usage of "DataConnections_Get" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this KustoDatabaseResource created on azure
            // for more information of creating KustoDatabaseResource, please refer to the document of KustoDatabaseResource
            string subscriptionId = "12345678-1234-1234-1234-123456789098";
            string resourceGroupName = "kustorptest";
            string clusterName = "kustoCluster";
            string databaseName = "KustoDatabase8";
            ResourceIdentifier kustoDatabaseResourceId = KustoDatabaseResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName, databaseName);
            KustoDatabaseResource kustoDatabase = client.GetKustoDatabaseResource(kustoDatabaseResourceId);

            // get the collection of this KustoDataConnectionResource
            KustoDataConnectionCollection collection = kustoDatabase.GetKustoDataConnections();

            // invoke the operation
            string dataConnectionName = "dataConnectionTest";
            bool result = await collection.ExistsAsync(dataConnectionName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // KustoDataConnectionsGet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_KustoDataConnectionsGet()
        {
            // Generated from example definition: specification/azure-kusto/resource-manager/Microsoft.Kusto/stable/2022-07-07/examples/KustoDataConnectionsGet.json
            // this example is just showing the usage of "DataConnections_Get" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this KustoDatabaseResource created on azure
            // for more information of creating KustoDatabaseResource, please refer to the document of KustoDatabaseResource
            string subscriptionId = "12345678-1234-1234-1234-123456789098";
            string resourceGroupName = "kustorptest";
            string clusterName = "kustoCluster";
            string databaseName = "KustoDatabase8";
            ResourceIdentifier kustoDatabaseResourceId = KustoDatabaseResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName, databaseName);
            KustoDatabaseResource kustoDatabase = client.GetKustoDatabaseResource(kustoDatabaseResourceId);

            // get the collection of this KustoDataConnectionResource
            KustoDataConnectionCollection collection = kustoDatabase.GetKustoDataConnections();

            // invoke the operation
            string dataConnectionName = "dataConnectionTest";
            KustoDataConnectionResource result = await collection.GetAsync(dataConnectionName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            KustoDataConnectionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // KustoDataConnectionsGet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_KustoDataConnectionsGet()
        {
            // Generated from example definition: specification/azure-kusto/resource-manager/Microsoft.Kusto/stable/2022-07-07/examples/KustoDataConnectionsGet.json
            // this example is just showing the usage of "DataConnections_Get" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this KustoDatabaseResource created on azure
            // for more information of creating KustoDatabaseResource, please refer to the document of KustoDatabaseResource
            string subscriptionId = "12345678-1234-1234-1234-123456789098";
            string resourceGroupName = "kustorptest";
            string clusterName = "kustoCluster";
            string databaseName = "KustoDatabase8";
            ResourceIdentifier kustoDatabaseResourceId = KustoDatabaseResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName, databaseName);
            KustoDatabaseResource kustoDatabase = client.GetKustoDatabaseResource(kustoDatabaseResourceId);

            // get the collection of this KustoDataConnectionResource
            KustoDataConnectionCollection collection = kustoDatabase.GetKustoDataConnections();

            // invoke the operation
            string dataConnectionName = "dataConnectionTest";
            bool result = await collection.ExistsAsync(dataConnectionName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // KustoDataConnectionsCreateOrUpdate
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_KustoDataConnectionsCreateOrUpdate()
        {
            // Generated from example definition: specification/azure-kusto/resource-manager/Microsoft.Kusto/stable/2022-07-07/examples/KustoDataConnectionsCreateOrUpdate.json
            // this example is just showing the usage of "DataConnections_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this KustoDatabaseResource created on azure
            // for more information of creating KustoDatabaseResource, please refer to the document of KustoDatabaseResource
            string subscriptionId = "12345678-1234-1234-1234-123456789098";
            string resourceGroupName = "kustorptest";
            string clusterName = "kustoCluster";
            string databaseName = "KustoDatabase8";
            ResourceIdentifier kustoDatabaseResourceId = KustoDatabaseResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName, databaseName);
            KustoDatabaseResource kustoDatabase = client.GetKustoDatabaseResource(kustoDatabaseResourceId);

            // get the collection of this KustoDataConnectionResource
            KustoDataConnectionCollection collection = kustoDatabase.GetKustoDataConnections();

            // invoke the operation
            string dataConnectionName = "dataConnectionTest";
            KustoDataConnectionData data = new KustoDataConnectionData()
            {
                Location = new AzureLocation("westus"),
                Kind = DataConnectionKind.EventHub,
            };
            ArmOperation<KustoDataConnectionResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, dataConnectionName, data);
            KustoDataConnectionResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            KustoDataConnectionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // KustoDataConnectionsEventGridCreateOrUpdate
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_KustoDataConnectionsEventGridCreateOrUpdate()
        {
            // Generated from example definition: specification/azure-kusto/resource-manager/Microsoft.Kusto/stable/2022-07-07/examples/KustoDataConnectionsEventGridCreateOrUpdate.json
            // this example is just showing the usage of "DataConnections_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this KustoDatabaseResource created on azure
            // for more information of creating KustoDatabaseResource, please refer to the document of KustoDatabaseResource
            string subscriptionId = "12345678-1234-1234-1234-123456789098";
            string resourceGroupName = "kustorptest";
            string clusterName = "kustoCluster";
            string databaseName = "KustoDatabase8";
            ResourceIdentifier kustoDatabaseResourceId = KustoDatabaseResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName, databaseName);
            KustoDatabaseResource kustoDatabase = client.GetKustoDatabaseResource(kustoDatabaseResourceId);

            // get the collection of this KustoDataConnectionResource
            KustoDataConnectionCollection collection = kustoDatabase.GetKustoDataConnections();

            // invoke the operation
            string dataConnectionName = "dataConnectionTest";
            KustoDataConnectionData data = new KustoDataConnectionData()
            {
                Location = new AzureLocation("westus"),
                Kind = DataConnectionKind.EventGrid,
            };
            ArmOperation<KustoDataConnectionResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, dataConnectionName, data);
            KustoDataConnectionResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            KustoDataConnectionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
