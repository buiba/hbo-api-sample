// <copyright file="Headers.cs" company="APIMatic">
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
    /// Headers.
    /// </summary>
    [XmlRootAttribute("Headers")]
    public class Headers
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Headers"/> class.
        /// </summary>
        public Headers()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Headers"/> class.
        /// </summary>
        /// <param name="eTag">ETag.</param>
        /// <param name="intent">intent.</param>
        /// <param name="graphId">graphId.</param>
        public Headers(
            string eTag,
            string intent,
            string graphId)
        {
            this.ETag = eTag;
            this.Intent = intent;
            this.GraphId = graphId;
        }

        /// <summary>
        /// Gets or sets ETag.
        /// </summary>
        [JsonProperty("ETag")]
        [XmlElement("ETag")]
        public string ETag { get; set; }

        /// <summary>
        /// Gets or sets Intent.
        /// </summary>
        [JsonProperty("intent")]
        [XmlElement("intent")]
        public string Intent { get; set; }

        /// <summary>
        /// Gets or sets GraphId.
        /// </summary>
        [JsonProperty("graphId")]
        [XmlElement("graphId")]
        public string GraphId { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Headers : ({string.Join(", ", toStringOutput)})";
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

            return obj is Headers other &&
                ((this.ETag == null && other.ETag == null) || (this.ETag?.Equals(other.ETag) == true)) &&
                ((this.Intent == null && other.Intent == null) || (this.Intent?.Equals(other.Intent) == true)) &&
                ((this.GraphId == null && other.GraphId == null) || (this.GraphId?.Equals(other.GraphId) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ETag = {(this.ETag == null ? "null" : this.ETag == string.Empty ? "" : this.ETag)}");
            toStringOutput.Add($"this.Intent = {(this.Intent == null ? "null" : this.Intent == string.Empty ? "" : this.Intent)}");
            toStringOutput.Add($"this.GraphId = {(this.GraphId == null ? "null" : this.GraphId == string.Empty ? "" : this.GraphId)}");
        }
    }
}