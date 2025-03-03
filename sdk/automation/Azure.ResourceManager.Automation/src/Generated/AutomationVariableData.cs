// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Automation
{
    /// <summary> A class representing the AutomationVariable data model. </summary>
    public partial class AutomationVariableData : ResourceData
    {
        /// <summary> Initializes a new instance of AutomationVariableData. </summary>
        public AutomationVariableData()
        {
        }

        /// <summary> Initializes a new instance of AutomationVariableData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="value"> Gets or sets the value of the variable. </param>
        /// <param name="isEncrypted"> Gets or sets the encrypted flag of the variable. </param>
        /// <param name="createdOn"> Gets or sets the creation time. </param>
        /// <param name="lastModifiedOn"> Gets or sets the last modified time. </param>
        /// <param name="description"> Gets or sets the description. </param>
        internal AutomationVariableData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string value, bool? isEncrypted, DateTimeOffset? createdOn, DateTimeOffset? lastModifiedOn, string description) : base(id, name, resourceType, systemData)
        {
            Value = value;
            IsEncrypted = isEncrypted;
            CreatedOn = createdOn;
            LastModifiedOn = lastModifiedOn;
            Description = description;
        }

        /// <summary> Gets or sets the value of the variable. </summary>
        public string Value { get; set; }
        /// <summary> Gets or sets the encrypted flag of the variable. </summary>
        public bool? IsEncrypted { get; set; }
        /// <summary> Gets or sets the creation time. </summary>
        public DateTimeOffset? CreatedOn { get; set; }
        /// <summary> Gets or sets the last modified time. </summary>
        public DateTimeOffset? LastModifiedOn { get; set; }
        /// <summary> Gets or sets the description. </summary>
        public string Description { get; set; }
    }
}
