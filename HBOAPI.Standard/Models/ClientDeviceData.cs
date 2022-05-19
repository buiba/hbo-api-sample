// <copyright file="ClientDeviceData.cs" company="APIMatic">
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
    /// ClientDeviceData.
    /// </summary>
    [XmlRootAttribute("ClientDeviceData")]
    public class ClientDeviceData
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientDeviceData"/> class.
        /// </summary>
        public ClientDeviceData()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientDeviceData"/> class.
        /// </summary>
        /// <param name="paymentProviderCode">paymentProviderCode.</param>
        public ClientDeviceData(
            string paymentProviderCode)
        {
            this.PaymentProviderCode = paymentProviderCode;
        }

        /// <summary>
        /// Gets or sets PaymentProviderCode.
        /// </summary>
        [JsonProperty("paymentProviderCode")]
        [XmlElement("paymentProviderCode")]
        public string PaymentProviderCode { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ClientDeviceData : ({string.Join(", ", toStringOutput)})";
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

            return obj is ClientDeviceData other &&
                ((this.PaymentProviderCode == null && other.PaymentProviderCode == null) || (this.PaymentProviderCode?.Equals(other.PaymentProviderCode) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.PaymentProviderCode = {(this.PaymentProviderCode == null ? "null" : this.PaymentProviderCode == string.Empty ? "" : this.PaymentProviderCode)}");
        }
    }
}