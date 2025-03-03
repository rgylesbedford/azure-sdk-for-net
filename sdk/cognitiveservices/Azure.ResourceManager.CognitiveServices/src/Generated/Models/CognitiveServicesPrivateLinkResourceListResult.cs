// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.CognitiveServices.Models
{
    /// <summary> A list of private link resources. </summary>
    internal partial class CognitiveServicesPrivateLinkResourceListResult
    {
        /// <summary> Initializes a new instance of CognitiveServicesPrivateLinkResourceListResult. </summary>
        internal CognitiveServicesPrivateLinkResourceListResult()
        {
            Value = new ChangeTrackingList<CognitiveServicesPrivateLinkResource>();
        }

        /// <summary> Initializes a new instance of CognitiveServicesPrivateLinkResourceListResult. </summary>
        /// <param name="value"> Array of private link resources. </param>
        internal CognitiveServicesPrivateLinkResourceListResult(IReadOnlyList<CognitiveServicesPrivateLinkResource> value)
        {
            Value = value;
        }

        /// <summary> Array of private link resources. </summary>
        public IReadOnlyList<CognitiveServicesPrivateLinkResource> Value { get; }
    }
}
