// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary>
    /// The MachineLearningOrderString.
    /// Serialized Name: OrderString
    /// </summary>
    public readonly partial struct MachineLearningOrderString : IEquatable<MachineLearningOrderString>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="MachineLearningOrderString"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public MachineLearningOrderString(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string CreatedAtDescValue = "CreatedAtDesc";
        private const string CreatedAtAscValue = "CreatedAtAsc";
        private const string UpdatedAtDescValue = "UpdatedAtDesc";
        private const string UpdatedAtAscValue = "UpdatedAtAsc";

        /// <summary>
        /// CreatedAtDesc
        /// Serialized Name: OrderString.CreatedAtDesc
        /// </summary>
        public static MachineLearningOrderString CreatedAtDesc { get; } = new MachineLearningOrderString(CreatedAtDescValue);
        /// <summary>
        /// CreatedAtAsc
        /// Serialized Name: OrderString.CreatedAtAsc
        /// </summary>
        public static MachineLearningOrderString CreatedAtAsc { get; } = new MachineLearningOrderString(CreatedAtAscValue);
        /// <summary>
        /// UpdatedAtDesc
        /// Serialized Name: OrderString.UpdatedAtDesc
        /// </summary>
        public static MachineLearningOrderString UpdatedAtDesc { get; } = new MachineLearningOrderString(UpdatedAtDescValue);
        /// <summary>
        /// UpdatedAtAsc
        /// Serialized Name: OrderString.UpdatedAtAsc
        /// </summary>
        public static MachineLearningOrderString UpdatedAtAsc { get; } = new MachineLearningOrderString(UpdatedAtAscValue);
        /// <summary> Determines if two <see cref="MachineLearningOrderString"/> values are the same. </summary>
        public static bool operator ==(MachineLearningOrderString left, MachineLearningOrderString right) => left.Equals(right);
        /// <summary> Determines if two <see cref="MachineLearningOrderString"/> values are not the same. </summary>
        public static bool operator !=(MachineLearningOrderString left, MachineLearningOrderString right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="MachineLearningOrderString"/>. </summary>
        public static implicit operator MachineLearningOrderString(string value) => new MachineLearningOrderString(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is MachineLearningOrderString other && Equals(other);
        /// <inheritdoc />
        public bool Equals(MachineLearningOrderString other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
