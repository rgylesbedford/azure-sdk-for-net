// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.WebSites.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The configuration settings of the custom Open ID Connect provider.
    /// </summary>
    public partial class CustomOpenIdConnectProvider
    {
        /// <summary>
        /// Initializes a new instance of the CustomOpenIdConnectProvider
        /// class.
        /// </summary>
        public CustomOpenIdConnectProvider()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CustomOpenIdConnectProvider
        /// class.
        /// </summary>
        /// <param name="enabled">&lt;code&gt;false&lt;/code&gt; if the custom
        /// Open ID provider provider should not be enabled; otherwise,
        /// &lt;code&gt;true&lt;/code&gt;.</param>
        /// <param name="registration">The configuration settings of the app
        /// registration for the custom Open ID Connect provider.</param>
        /// <param name="login">The configuration settings of the login flow of
        /// the custom Open ID Connect provider.</param>
        public CustomOpenIdConnectProvider(bool? enabled = default(bool?), OpenIdConnectRegistration registration = default(OpenIdConnectRegistration), OpenIdConnectLogin login = default(OpenIdConnectLogin))
        {
            Enabled = enabled;
            Registration = registration;
            Login = login;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets &amp;lt;code&amp;gt;false&amp;lt;/code&amp;gt; if the
        /// custom Open ID provider provider should not be enabled; otherwise,
        /// &amp;lt;code&amp;gt;true&amp;lt;/code&amp;gt;.
        /// </summary>
        [JsonProperty(PropertyName = "enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Gets or sets the configuration settings of the app registration for
        /// the custom Open ID Connect provider.
        /// </summary>
        [JsonProperty(PropertyName = "registration")]
        public OpenIdConnectRegistration Registration { get; set; }

        /// <summary>
        /// Gets or sets the configuration settings of the login flow of the
        /// custom Open ID Connect provider.
        /// </summary>
        [JsonProperty(PropertyName = "login")]
        public OpenIdConnectLogin Login { get; set; }

    }
}
