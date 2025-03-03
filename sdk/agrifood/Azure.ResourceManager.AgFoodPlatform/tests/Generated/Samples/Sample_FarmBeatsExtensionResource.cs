// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager;

namespace Azure.ResourceManager.AgFoodPlatform
{
    public partial class Sample_FarmBeatsExtensionResource
    {
        // FarmBeatsExtensions_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_FarmBeatsExtensionsGet()
        {
            // Generated from example definition: specification/agrifood/resource-manager/Microsoft.AgFoodPlatform/preview/2021-09-01-preview/examples/FarmBeatsExtensions_Get.json
            // this example is just showing the usage of "FarmBeatsExtensions_Get" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this FarmBeatsExtensionResource created on azure
            // for more information of creating FarmBeatsExtensionResource, please refer to the document of FarmBeatsExtensionResource
            string farmBeatsExtensionId = "DTN.ContentServices";
            ResourceIdentifier farmBeatsExtensionResourceId = FarmBeatsExtensionResource.CreateResourceIdentifier(farmBeatsExtensionId);
            FarmBeatsExtensionResource farmBeatsExtension = client.GetFarmBeatsExtensionResource(farmBeatsExtensionResourceId);

            // invoke the operation
            FarmBeatsExtensionResource result = await farmBeatsExtension.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            FarmBeatsExtensionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
