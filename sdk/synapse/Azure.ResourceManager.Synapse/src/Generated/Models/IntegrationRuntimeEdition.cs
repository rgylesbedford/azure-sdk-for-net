// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Synapse.Models
{
    /// <summary> The edition for the SSIS Integration Runtime. </summary>
    public readonly partial struct IntegrationRuntimeEdition : IEquatable<IntegrationRuntimeEdition>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="IntegrationRuntimeEdition"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public IntegrationRuntimeEdition(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string StandardValue = "Standard";
        private const string EnterpriseValue = "Enterprise";

        /// <summary> Standard. </summary>
        public static IntegrationRuntimeEdition Standard { get; } = new IntegrationRuntimeEdition(StandardValue);
        /// <summary> Enterprise. </summary>
        public static IntegrationRuntimeEdition Enterprise { get; } = new IntegrationRuntimeEdition(EnterpriseValue);
        /// <summary> Determines if two <see cref="IntegrationRuntimeEdition"/> values are the same. </summary>
        public static bool operator ==(IntegrationRuntimeEdition left, IntegrationRuntimeEdition right) => left.Equals(right);
        /// <summary> Determines if two <see cref="IntegrationRuntimeEdition"/> values are not the same. </summary>
        public static bool operator !=(IntegrationRuntimeEdition left, IntegrationRuntimeEdition right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="IntegrationRuntimeEdition"/>. </summary>
        public static implicit operator IntegrationRuntimeEdition(string value) => new IntegrationRuntimeEdition(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is IntegrationRuntimeEdition other && Equals(other);
        /// <inheritdoc />
        public bool Equals(IntegrationRuntimeEdition other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
