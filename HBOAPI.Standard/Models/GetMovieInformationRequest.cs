// <copyright file="GetMovieInformationRequest.cs" company="APIMatic">
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
    /// GetMovieInformationRequest.
    /// </summary>
    [XmlRootAttribute("Get Movie Information Request")]
    public class GetMovieInformationRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetMovieInformationRequest"/> class.
        /// </summary>
        public GetMovieInformationRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetMovieInformationRequest"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="headers">headers.</param>
        public GetMovieInformationRequest(
            string id,
            Models.Headers1 headers)
        {
            this.Id = id;
            this.Headers = headers;
        }

        /// <summary>
        /// Gets or sets Id.
        /// </summary>
        [JsonProperty("id")]
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets Headers.
        /// </summary>
        [JsonProperty("headers")]
        [XmlElement("Headers1")]
        public Models.Headers1 Headers { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"GetMovieInformationRequest : ({string.Join(", ", toStringOutput)})";
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

            return obj is GetMovieInformationRequest other &&
                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.Headers == null && other.Headers == null) || (this.Headers?.Equals(other.Headers) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id == string.Empty ? "" : this.Id)}");
            toStringOutput.Add($"this.Headers = {(this.Headers == null ? "null" : this.Headers.ToString())}");
        }
    }
}