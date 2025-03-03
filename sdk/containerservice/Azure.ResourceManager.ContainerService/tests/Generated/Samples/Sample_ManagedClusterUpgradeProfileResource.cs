// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager;

namespace Azure.ResourceManager.ContainerService
{
    public partial class Sample_ManagedClusterUpgradeProfileResource
    {
        // Get Upgrade Profile for Managed Cluster
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetUpgradeProfileForManagedCluster()
        {
            // Generated from example definition: specification/containerservice/resource-manager/Microsoft.ContainerService/stable/2022-04-01/examples/ManagedClustersGetUpgradeProfile.json
            // this example is just showing the usage of "ManagedClusters_GetUpgradeProfile" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this ManagedClusterUpgradeProfileResource created on azure
            // for more information of creating ManagedClusterUpgradeProfileResource, please refer to the document of ManagedClusterUpgradeProfileResource
            string subscriptionId = "subid1";
            string resourceGroupName = "rg1";
            string resourceName = "clustername1";
            ResourceIdentifier managedClusterUpgradeProfileResourceId = ManagedClusterUpgradeProfileResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, resourceName);
            ManagedClusterUpgradeProfileResource managedClusterUpgradeProfile = client.GetManagedClusterUpgradeProfileResource(managedClusterUpgradeProfileResourceId);

            // invoke the operation
            ManagedClusterUpgradeProfileResource result = await managedClusterUpgradeProfile.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ManagedClusterUpgradeProfileData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
