// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.AI.AnomalyDetector
{
    /// <summary> Model status. </summary>
    public partial class ModelState
    {
        /// <summary> Initializes a new instance of ModelState. </summary>
        public ModelState()
        {
            EpochIds = new ChangeTrackingList<int>();
            TrainLosses = new ChangeTrackingList<float>();
            ValidationLosses = new ChangeTrackingList<float>();
            LatenciesInSeconds = new ChangeTrackingList<float>();
        }

        /// <summary> Initializes a new instance of ModelState. </summary>
        /// <param name="epochIds"></param>
        /// <param name="trainLosses"></param>
        /// <param name="validationLosses"></param>
        /// <param name="latenciesInSeconds"></param>
        internal ModelState(IList<int> epochIds, IList<float> trainLosses, IList<float> validationLosses, IList<float> latenciesInSeconds)
        {
            EpochIds = epochIds.ToList();
            TrainLosses = trainLosses.ToList();
            ValidationLosses = validationLosses.ToList();
            LatenciesInSeconds = latenciesInSeconds.ToList();
        }

        /// <summary> Gets the epoch ids. </summary>
        public IList<int> EpochIds { get; }
        /// <summary> Gets the train losses. </summary>
        public IList<float> TrainLosses { get; }
        /// <summary> Gets the validation losses. </summary>
        public IList<float> ValidationLosses { get; }
        /// <summary> Gets the latencies in seconds. </summary>
        public IList<float> LatenciesInSeconds { get; }
    }
}
