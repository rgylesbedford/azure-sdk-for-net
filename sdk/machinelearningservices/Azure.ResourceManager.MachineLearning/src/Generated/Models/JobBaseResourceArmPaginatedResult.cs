// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.MachineLearning;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary>
    /// A paginated list of JobBase entities.
    /// Serialized Name: JobBaseResourceArmPaginatedResult
    /// </summary>
    internal partial class JobBaseResourceArmPaginatedResult
    {
        /// <summary> Initializes a new instance of JobBaseResourceArmPaginatedResult. </summary>
        internal JobBaseResourceArmPaginatedResult()
        {
            Value = new ChangeTrackingList<MachineLearningJobData>();
        }

        /// <summary> Initializes a new instance of JobBaseResourceArmPaginatedResult. </summary>
        /// <param name="nextLink">
        /// The link to the next page of JobBase objects. If null, there are no additional pages.
        /// Serialized Name: JobBaseResourceArmPaginatedResult.nextLink
        /// </param>
        /// <param name="value">
        /// An array of objects of type JobBase.
        /// Serialized Name: JobBaseResourceArmPaginatedResult.value
        /// </param>
        internal JobBaseResourceArmPaginatedResult(string nextLink, IReadOnlyList<MachineLearningJobData> value)
        {
            NextLink = nextLink;
            Value = value;
        }

        /// <summary>
        /// The link to the next page of JobBase objects. If null, there are no additional pages.
        /// Serialized Name: JobBaseResourceArmPaginatedResult.nextLink
        /// </summary>
        public string NextLink { get; }
        /// <summary>
        /// An array of objects of type JobBase.
        /// Serialized Name: JobBaseResourceArmPaginatedResult.value
        /// </summary>
        public IReadOnlyList<MachineLearningJobData> Value { get; }
    }
}
