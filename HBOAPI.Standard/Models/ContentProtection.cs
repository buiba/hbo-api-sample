// <copyright file="ContentProtection.cs" company="APIMatic">
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
    /// ContentProtection.
    /// </summary>
    [XmlRootAttribute("ContentProtection")]
    public class ContentProtection
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContentProtection"/> class.
        /// </summary>
        public ContentProtection()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContentProtection"/> class.
        /// </summary>
        /// <param name="schemeIdUri">schemeIdUri.</param>
        /// <param name="urnMpegCenc2013DefaultKID">{urn:mpeg:cenc:2013}default_KID.</param>
        /// <param name="mValue">value.</param>
        /// <param name="pssh">pssh.</param>
        public ContentProtection(
            string schemeIdUri = null,
            string urnMpegCenc2013DefaultKID = null,
            string mValue = null,
            string pssh = null)
        {
            this.SchemeIdUri = schemeIdUri;
            this.UrnMpegCenc2013DefaultKID = urnMpegCenc2013DefaultKID;
            this.MValue = mValue;
            this.Pssh = pssh;
        }

        /// <summary>
        /// Gets or sets SchemeIdUri.
        /// </summary>
        [JsonProperty("schemeIdUri", NullValueHandling = NullValueHandling.Ignore)]
        [XmlAttribute("schemeIdUri")]
        public string SchemeIdUri { get; set; }

        /// <summary>
        /// Gets or sets UrnMpegCenc2013DefaultKID.
        /// </summary>
        [JsonProperty("{urn:mpeg:cenc:2013}default_KID", NullValueHandling = NullValueHandling.Ignore)]
        [XmlAttribute("default_KID")]
        public string UrnMpegCenc2013DefaultKID { get; set; }

        /// <summary>
        /// Gets or sets MValue.
        /// </summary>
        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        [XmlAttribute("value")]
        public string MValue { get; set; }

        /// <summary>
        /// Gets or sets Pssh.
        /// </summary>
        [JsonProperty("pssh", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("pssh")]
        public string Pssh { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ContentProtection : ({string.Join(", ", toStringOutput)})";
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

            return obj is ContentProtection other &&
                ((this.SchemeIdUri == null && other.SchemeIdUri == null) || (this.SchemeIdUri?.Equals(other.SchemeIdUri) == true)) &&
                ((this.UrnMpegCenc2013DefaultKID == null && other.UrnMpegCenc2013DefaultKID == null) || (this.UrnMpegCenc2013DefaultKID?.Equals(other.UrnMpegCenc2013DefaultKID) == true)) &&
                ((this.MValue == null && other.MValue == null) || (this.MValue?.Equals(other.MValue) == true)) &&
                ((this.Pssh == null && other.Pssh == null) || (this.Pssh?.Equals(other.Pssh) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.SchemeIdUri = {(this.SchemeIdUri == null ? "null" : this.SchemeIdUri == string.Empty ? "" : this.SchemeIdUri)}");
            toStringOutput.Add($"this.UrnMpegCenc2013DefaultKID = {(this.UrnMpegCenc2013DefaultKID == null ? "null" : this.UrnMpegCenc2013DefaultKID == string.Empty ? "" : this.UrnMpegCenc2013DefaultKID)}");
            toStringOutput.Add($"this.MValue = {(this.MValue == null ? "null" : this.MValue == string.Empty ? "" : this.MValue)}");
            toStringOutput.Add($"this.Pssh = {(this.Pssh == null ? "null" : this.Pssh == string.Empty ? "" : this.Pssh)}");
        }
    }
}