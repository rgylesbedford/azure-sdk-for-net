// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary>
    /// The List Virtual Machine size operation response.
    /// Serialized Name: VirtualMachineSizeListResult
    /// </summary>
    internal partial class VirtualMachineSizeListResult
    {
        /// <summary> Initializes a new instance of VirtualMachineSizeListResult. </summary>
        internal VirtualMachineSizeListResult()
        {
            Value = new ChangeTrackingList<MachineLearningVmSize>();
        }

        /// <summary> Initializes a new instance of VirtualMachineSizeListResult. </summary>
        /// <param name="value">
        /// The list of virtual machine sizes supported by AmlCompute.
        /// Serialized Name: VirtualMachineSizeListResult.value
        /// </param>
        internal VirtualMachineSizeListResult(IReadOnlyList<MachineLearningVmSize> value)
        {
            Value = value;
        }

        /// <summary>
        /// The list of virtual machine sizes supported by AmlCompute.
        /// Serialized Name: VirtualMachineSizeListResult.value
        /// </summary>
        public IReadOnlyList<MachineLearningVmSize> Value { get; }
    }
}
