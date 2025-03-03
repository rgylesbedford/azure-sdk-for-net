// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary>
    /// Enum to determine the job distribution type.
    /// Serialized Name: DistributionType
    /// </summary>
    internal readonly partial struct DistributionType : IEquatable<DistributionType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="DistributionType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DistributionType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string PyTorchValue = "PyTorch";
        private const string TensorFlowValue = "TensorFlow";
        private const string MpiValue = "Mpi";

        /// <summary>
        /// PyTorch
        /// Serialized Name: DistributionType.PyTorch
        /// </summary>
        public static DistributionType PyTorch { get; } = new DistributionType(PyTorchValue);
        /// <summary>
        /// TensorFlow
        /// Serialized Name: DistributionType.TensorFlow
        /// </summary>
        public static DistributionType TensorFlow { get; } = new DistributionType(TensorFlowValue);
        /// <summary>
        /// Mpi
        /// Serialized Name: DistributionType.Mpi
        /// </summary>
        public static DistributionType Mpi { get; } = new DistributionType(MpiValue);
        /// <summary> Determines if two <see cref="DistributionType"/> values are the same. </summary>
        public static bool operator ==(DistributionType left, DistributionType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DistributionType"/> values are not the same. </summary>
        public static bool operator !=(DistributionType left, DistributionType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="DistributionType"/>. </summary>
        public static implicit operator DistributionType(string value) => new DistributionType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DistributionType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DistributionType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
