// <copyright file="GetGuestTokenRequest.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace HBOAPI.Standard.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Xml.Serialization;
    using HBOAPI.Standard;
    using HBOAPI.Standard.Utilities;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// GetGuestTokenRequest.
    /// </summary>
    [XmlRootAttribute("Get Guest Token Request")]
    public class GetGuestTokenRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetGuestTokenRequest"/> class.
        /// </summary>
        public GetGuestTokenRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetGuestTokenRequest"/> class.
        /// </summary>
        /// <param name="clientId">client_id.</param>
        /// <param name="clientSecret">client_secret.</param>
        /// <param name="scope">scope.</param>
        /// <param name="grantType">grant_type.</param>
        /// <param name="deviceSerialNumber">deviceSerialNumber.</param>
        /// <param name="clientDeviceData">clientDeviceData.</param>
        public GetGuestTokenRequest(
            string clientId,
            string clientSecret,
            string scope,
            string grantType,
            string deviceSerialNumber,
            Models.ClientDeviceData clientDeviceData)
        {
            this.ClientId = clientId;
            this.ClientSecret = clientSecret;
            this.Scope = scope;
            this.GrantType = grantType;
            this.DeviceSerialNumber = deviceSerialNumber;
            this.ClientDeviceData = clientDeviceData;
        }

        /// <summary>
        /// Gets or sets ClientId.
        /// </summary>
        [JsonProperty("client_id")]
        [XmlElement("client_id")]
        public string ClientId { get; set; }

        /// <summary>
        /// Gets or sets ClientSecret.
        /// </summary>
        [JsonProperty("client_secret")]
        [XmlElement("client_secret")]
        public string ClientSecret { get; set; }

        /// <summary>
        /// Gets or sets Scope.
        /// </summary>
        [JsonProperty("scope")]
        [XmlElement("scope")]
        public string Scope { get; set; }

        /// <summary>
        /// Gets or sets GrantType.
        /// </summary>
        [JsonProperty("grant_type")]
        [XmlElement("grant_type")]
        public string GrantType { get; set; }

        /// <summary>
        /// Gets or sets DeviceSerialNumber.
        /// </summary>
        [JsonProperty("deviceSerialNumber")]
        [XmlElement("deviceSerialNumber")]
        public string DeviceSerialNumber { get; set; }

        /// <summary>
        /// Gets or sets ClientDeviceData.
        /// </summary>
        [JsonProperty("clientDeviceData")]
        [XmlElement("ClientDeviceData")]
        public Models.ClientDeviceData ClientDeviceData { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"GetGuestTokenRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (obj == this)
            {
                return true;
            }

            return obj is GetGuestTokenRequest other &&
                ((this.ClientId == null && other.ClientId == null) || (this.ClientId?.Equals(other.ClientId) == true)) &&
                ((this.ClientSecret == null && other.ClientSecret == null) || (this.ClientSecret?.Equals(other.ClientSecret) == true)) &&
                ((this.Scope == null && other.Scope == null) || (this.Scope?.Equals(other.Scope) == true)) &&
                ((this.GrantType == null && other.GrantType == null) || (this.GrantType?.Equals(other.GrantType) == true)) &&
                ((this.DeviceSerialNumber == null && other.DeviceSerialNumber == null) || (this.DeviceSerialNumber?.Equals(other.DeviceSerialNumber) == true)) &&
                ((this.ClientDeviceData == null && other.ClientDeviceData == null) || (this.ClientDeviceData?.Equals(other.ClientDeviceData) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ClientId = {(this.ClientId == null ? "null" : this.ClientId == string.Empty ? "" : this.ClientId)}");
            toStringOutput.Add($"this.ClientSecret = {(this.ClientSecret == null ? "null" : this.ClientSecret == string.Empty ? "" : this.ClientSecret)}");
            toStringOutput.Add($"this.Scope = {(this.Scope == null ? "null" : this.Scope == string.Empty ? "" : this.Scope)}");
            toStringOutput.Add($"this.GrantType = {(this.GrantType == null ? "null" : this.GrantType == string.Empty ? "" : this.GrantType)}");
            toStringOutput.Add($"this.DeviceSerialNumber = {(this.DeviceSerialNumber == null ? "null" : this.DeviceSerialNumber == string.Empty ? "" : this.DeviceSerialNumber)}");
            toStringOutput.Add($"this.ClientDeviceData = {(this.ClientDeviceData == null ? "null" : this.ClientDeviceData.ToString())}");
        }
    }
}