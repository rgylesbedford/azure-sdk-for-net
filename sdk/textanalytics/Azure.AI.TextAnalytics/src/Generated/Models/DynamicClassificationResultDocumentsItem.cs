// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.AI.TextAnalytics;
using Azure.Core;

namespace Azure.AI.TextAnalytics.Models
{
    /// <summary> The DynamicClassificationResultDocumentsItem. </summary>
    internal partial class DynamicClassificationResultDocumentsItem : DynamicClassificationDocumentResult
    {
        /// <summary> Initializes a new instance of DynamicClassificationResultDocumentsItem. </summary>
        /// <param name="id"> Unique, non-empty document identifier. </param>
        /// <param name="warnings"> Warnings encountered while processing document. </param>
        /// <param name="classifications"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/>, <paramref name="warnings"/> or <paramref name="classifications"/> is null. </exception>
        public DynamicClassificationResultDocumentsItem(string id, IEnumerable<DocumentWarning> warnings, IEnumerable<ClassificationResult> classifications) : base(id, warnings, classifications)
        {
            Argument.AssertNotNull(id, nameof(id));
            Argument.AssertNotNull(warnings, nameof(warnings));
            Argument.AssertNotNull(classifications, nameof(classifications));
        }

        /// <summary> Initializes a new instance of DynamicClassificationResultDocumentsItem. </summary>
        /// <param name="id"> Unique, non-empty document identifier. </param>
        /// <param name="warnings"> Warnings encountered while processing document. </param>
        /// <param name="statistics"> if showStats=true was specified in the request this field will contain information about the document payload. </param>
        /// <param name="classifications"></param>
        internal DynamicClassificationResultDocumentsItem(string id, IList<DocumentWarning> warnings, TextDocumentStatistics? statistics, IList<ClassificationResult> classifications) : base(id, warnings, statistics, classifications)
        {
        }
    }
}
