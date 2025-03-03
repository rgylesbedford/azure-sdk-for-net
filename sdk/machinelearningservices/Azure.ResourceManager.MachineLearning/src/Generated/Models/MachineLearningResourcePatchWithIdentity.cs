// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary>
    /// Strictly used in update requests.
    /// Serialized Name: PartialMinimalTrackedResourceWithIdentity
    /// </summary>
    public partial class MachineLearningResourcePatchWithIdentity : MachineLearningResourcePatch
    {
        /// <summary> Initializes a new instance of MachineLearningResourcePatchWithIdentity. </summary>
        public MachineLearningResourcePatchWithIdentity()
        {
        }

        /// <summary>
        /// Managed service identity (system assigned and/or user assigned identities)
        /// Serialized Name: PartialMinimalTrackedResourceWithIdentity.identity
        /// </summary>
        public MachineLearningPartialManagedServiceIdentity Identity { get; set; }
    }
}
