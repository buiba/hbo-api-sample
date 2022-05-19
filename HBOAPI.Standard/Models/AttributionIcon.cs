// <copyright file="AttributionIcon.cs" company="APIMatic">
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
    /// AttributionIcon.
    /// </summary>
    [XmlRootAttribute("AttributionIcon")]
    public class AttributionIcon
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AttributionIcon"/> class.
        /// </summary>
        public AttributionIcon()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AttributionIcon"/> class.
        /// </summary>
        /// <param name="uri">uri.</param>
        /// <param name="alternateText">alternateText.</param>
        public AttributionIcon(
            string uri,
            string alternateText)
        {
            this.Uri = uri;
            this.AlternateText = alternateText;
        }

        /// <summary>
        /// Gets or sets Uri.
        /// </summary>
        [JsonProperty("uri")]
        [XmlElement("uri")]
        public string Uri { get; set; }

        /// <summary>
        /// Gets or sets AlternateText.
        /// </summary>
        [JsonProperty("alternateText")]
        [XmlElement("alternateText")]
        public string AlternateText { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"AttributionIcon : ({string.Join(", ", toStringOutput)})";
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

            return obj is AttributionIcon other &&
                ((this.Uri == null && other.Uri == null) || (this.Uri?.Equals(other.Uri) == true)) &&
                ((this.AlternateText == null && other.AlternateText == null) || (this.AlternateText?.Equals(other.AlternateText) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Uri = {(this.Uri == null ? "null" : this.Uri == string.Empty ? "" : this.Uri)}");
            toStringOutput.Add($"this.AlternateText = {(this.AlternateText == null ? "null" : this.AlternateText == string.Empty ? "" : this.AlternateText)}");
        }
    }
}