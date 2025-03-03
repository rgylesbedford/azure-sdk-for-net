// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Media.Models
{
    /// <summary>
    /// Base class for content key ID location. A derived class must be used to represent the location.
    /// Please note <see cref="ContentKeyPolicyPlayReadyContentKeyLocation"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="ContentKeyPolicyPlayReadyContentEncryptionKeyFromHeader"/> and <see cref="ContentKeyPolicyPlayReadyContentEncryptionKeyFromKeyIdentifier"/>.
    /// </summary>
    public abstract partial class ContentKeyPolicyPlayReadyContentKeyLocation
    {
        /// <summary> Initializes a new instance of ContentKeyPolicyPlayReadyContentKeyLocation. </summary>
        protected ContentKeyPolicyPlayReadyContentKeyLocation()
        {
        }

        /// <summary> Initializes a new instance of ContentKeyPolicyPlayReadyContentKeyLocation. </summary>
        /// <param name="odataType"> The discriminator for derived types. </param>
        internal ContentKeyPolicyPlayReadyContentKeyLocation(string odataType)
        {
            OdataType = odataType;
        }

        /// <summary> The discriminator for derived types. </summary>
        internal string OdataType { get; set; }
    }
}
