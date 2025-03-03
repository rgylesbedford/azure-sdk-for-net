// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.AppContainers.Models
{
    /// <summary> Custom domain analysis. </summary>
    public partial class CustomHostnameAnalysisResult
    {
        /// <summary> Initializes a new instance of CustomHostnameAnalysisResult. </summary>
        internal CustomHostnameAnalysisResult()
        {
            CNameRecords = new ChangeTrackingList<string>();
            TxtRecords = new ChangeTrackingList<string>();
            ARecords = new ChangeTrackingList<string>();
            AlternateCNameRecords = new ChangeTrackingList<string>();
            AlternateTxtRecords = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of CustomHostnameAnalysisResult. </summary>
        /// <param name="hostName"> Host name that was analyzed. </param>
        /// <param name="isHostnameAlreadyVerified"> &lt;code&gt;true&lt;/code&gt; if hostname is already verified; otherwise, &lt;code&gt;false&lt;/code&gt;. </param>
        /// <param name="customDomainVerificationTest"> DNS verification test result. </param>
        /// <param name="customDomainVerificationFailureInfo"> Raw failure information if DNS verification fails. </param>
        /// <param name="hasConflictOnManagedEnvironment"> &lt;code&gt;true&lt;/code&gt; if there is a conflict on the Container App&apos;s managed environment; otherwise, &lt;code&gt;false&lt;/code&gt;. </param>
        /// <param name="conflictWithEnvironmentCustomDomain"> &lt;code&gt;true&lt;/code&gt; if there is a conflict on the Container App&apos;s managed environment level custom domain; otherwise, &lt;code&gt;false&lt;/code&gt;. </param>
        /// <param name="conflictingContainerAppResourceId"> Name of the conflicting Container App on the Managed Environment if it&apos;s within the same subscription. </param>
        /// <param name="cNameRecords"> CName records visible for this hostname. </param>
        /// <param name="txtRecords"> TXT records visible for this hostname. </param>
        /// <param name="aRecords"> A records visible for this hostname. </param>
        /// <param name="alternateCNameRecords"> Alternate CName records visible for this hostname. </param>
        /// <param name="alternateTxtRecords"> Alternate TXT records visible for this hostname. </param>
        internal CustomHostnameAnalysisResult(string hostName, bool? isHostnameAlreadyVerified, DnsVerificationTestResult? customDomainVerificationTest, CustomHostnameAnalysisResultCustomDomainVerificationFailureInfo customDomainVerificationFailureInfo, bool? hasConflictOnManagedEnvironment, bool? conflictWithEnvironmentCustomDomain, string conflictingContainerAppResourceId, IReadOnlyList<string> cNameRecords, IReadOnlyList<string> txtRecords, IReadOnlyList<string> aRecords, IReadOnlyList<string> alternateCNameRecords, IReadOnlyList<string> alternateTxtRecords)
        {
            HostName = hostName;
            IsHostnameAlreadyVerified = isHostnameAlreadyVerified;
            CustomDomainVerificationTest = customDomainVerificationTest;
            CustomDomainVerificationFailureInfo = customDomainVerificationFailureInfo;
            HasConflictOnManagedEnvironment = hasConflictOnManagedEnvironment;
            ConflictWithEnvironmentCustomDomain = conflictWithEnvironmentCustomDomain;
            ConflictingContainerAppResourceId = conflictingContainerAppResourceId;
            CNameRecords = cNameRecords;
            TxtRecords = txtRecords;
            ARecords = aRecords;
            AlternateCNameRecords = alternateCNameRecords;
            AlternateTxtRecords = alternateTxtRecords;
        }

        /// <summary> Host name that was analyzed. </summary>
        public string HostName { get; }
        /// <summary> &lt;code&gt;true&lt;/code&gt; if hostname is already verified; otherwise, &lt;code&gt;false&lt;/code&gt;. </summary>
        public bool? IsHostnameAlreadyVerified { get; }
        /// <summary> DNS verification test result. </summary>
        public DnsVerificationTestResult? CustomDomainVerificationTest { get; }
        /// <summary> Raw failure information if DNS verification fails. </summary>
        public CustomHostnameAnalysisResultCustomDomainVerificationFailureInfo CustomDomainVerificationFailureInfo { get; }
        /// <summary> &lt;code&gt;true&lt;/code&gt; if there is a conflict on the Container App&apos;s managed environment; otherwise, &lt;code&gt;false&lt;/code&gt;. </summary>
        public bool? HasConflictOnManagedEnvironment { get; }
        /// <summary> &lt;code&gt;true&lt;/code&gt; if there is a conflict on the Container App&apos;s managed environment level custom domain; otherwise, &lt;code&gt;false&lt;/code&gt;. </summary>
        public bool? ConflictWithEnvironmentCustomDomain { get; }
        /// <summary> Name of the conflicting Container App on the Managed Environment if it&apos;s within the same subscription. </summary>
        public string ConflictingContainerAppResourceId { get; }
        /// <summary> CName records visible for this hostname. </summary>
        public IReadOnlyList<string> CNameRecords { get; }
        /// <summary> TXT records visible for this hostname. </summary>
        public IReadOnlyList<string> TxtRecords { get; }
        /// <summary> A records visible for this hostname. </summary>
        public IReadOnlyList<string> ARecords { get; }
        /// <summary> Alternate CName records visible for this hostname. </summary>
        public IReadOnlyList<string> AlternateCNameRecords { get; }
        /// <summary> Alternate TXT records visible for this hostname. </summary>
        public IReadOnlyList<string> AlternateTxtRecords { get; }
    }
}
