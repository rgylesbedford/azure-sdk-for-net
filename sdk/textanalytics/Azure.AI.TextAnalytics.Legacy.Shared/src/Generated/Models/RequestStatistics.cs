// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.AI.TextAnalytics.Legacy
{
    /// <summary> if showStats=true was specified in the request this field will contain information about the request payload. </summary>
    internal partial class RequestStatistics
    {
        /// <summary> Initializes a new instance of RequestStatistics. </summary>
        /// <param name="documentsCount"> Number of documents submitted in the request. </param>
        /// <param name="validDocumentsCount"> Number of valid documents. This excludes empty, over-size limit or non-supported languages documents. </param>
        /// <param name="erroneousDocumentsCount"> Number of invalid documents. This includes empty, over-size limit or non-supported languages documents. </param>
        /// <param name="transactionsCount"> Number of transactions for the request. </param>
        internal RequestStatistics(int documentsCount, int validDocumentsCount, int erroneousDocumentsCount, long transactionsCount)
        {
            DocumentsCount = documentsCount;
            ValidDocumentsCount = validDocumentsCount;
            ErroneousDocumentsCount = erroneousDocumentsCount;
            TransactionsCount = transactionsCount;
        }

        /// <summary> Number of documents submitted in the request. </summary>
        public int DocumentsCount { get; }
        /// <summary> Number of valid documents. This excludes empty, over-size limit or non-supported languages documents. </summary>
        public int ValidDocumentsCount { get; }
        /// <summary> Number of invalid documents. This includes empty, over-size limit or non-supported languages documents. </summary>
        public int ErroneousDocumentsCount { get; }
        /// <summary> Number of transactions for the request. </summary>
        public long TransactionsCount { get; }
    }
}
