// <copyright file="GetEpisode.cs" company="APIMatic">
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
    /// GetEpisode.
    /// </summary>
    [XmlRootAttribute("Get episode")]
    public class GetEpisode
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetEpisode"/> class.
        /// </summary>
        public GetEpisode()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetEpisode"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="statusCode">statusCode.</param>
        /// <param name="headers">headers.</param>
        /// <param name="body">body.</param>
        public GetEpisode(
            string id,
            int statusCode,
            Models.Headers headers,
            Models.Body body)
        {
            this.Id = id;
            this.StatusCode = statusCode;
            this.Headers = headers;
            this.Body = body;
        }

        /// <summary>
        /// Gets or sets Id.
        /// </summary>
        [JsonProperty("id")]
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets StatusCode.
        /// </summary>
        [JsonProperty("statusCode")]
        [XmlElement("statusCode")]
        public int StatusCode { get; set; }

        /// <summary>
        /// Gets or sets Headers.
        /// </summary>
        [JsonProperty("headers")]
        [XmlElement("Headers")]
        public Models.Headers Headers { get; set; }

        /// <summary>
        /// Gets or sets Body.
        /// </summary>
        [JsonProperty("body")]
        [XmlElement("Body")]
        public Models.Body Body { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"GetEpisode : ({string.Join(", ", toStringOutput)})";
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

            return obj is GetEpisode other &&
                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                this.StatusCode.Equals(other.StatusCode) &&
                ((this.Headers == null && other.Headers == null) || (this.Headers?.Equals(other.Headers) == true)) &&
                ((this.Body == null && other.Body == null) || (this.Body?.Equals(other.Body) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id == string.Empty ? "" : this.Id)}");
            toStringOutput.Add($"this.StatusCode = {this.StatusCode}");
            toStringOutput.Add($"this.Headers = {(this.Headers == null ? "null" : this.Headers.ToString())}");
            toStringOutput.Add($"this.Body = {(this.Body == null ? "null" : this.Body.ToString())}");
        }
    }
}