// <copyright file="Period.cs" company="APIMatic">
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
    /// Period.
    /// </summary>
    [XmlRootAttribute("Period")]
    public class Period
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Period"/> class.
        /// </summary>
        public Period()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Period"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="duration">duration.</param>
        /// <param name="start">start.</param>
        /// <param name="baseURL">BaseURL.</param>
        /// <param name="adaptationSet">AdaptationSet.</param>
        public Period(
            int id,
            string duration,
            string start,
            string baseURL,
            List<Models.AdaptationSet> adaptationSet)
        {
            this.Id = id;
            this.Duration = duration;
            this.Start = start;
            this.BaseURL = baseURL;
            this.AdaptationSet = adaptationSet;
        }

        /// <summary>
        /// Gets or sets Id.
        /// </summary>
        [JsonProperty("id")]
        [XmlAttribute("id")]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets Duration.
        /// </summary>
        [JsonProperty("duration")]
        [XmlAttribute("duration")]
        public string Duration { get; set; }

        /// <summary>
        /// Gets or sets Start.
        /// </summary>
        [JsonProperty("start")]
        [XmlAttribute("start")]
        public string Start { get; set; }

        /// <summary>
        /// Gets or sets BaseURL.
        /// </summary>
        [JsonProperty("BaseURL")]
        [XmlElement("BaseURL")]
        public string BaseURL { get; set; }

        /// <summary>
        /// Gets or sets AdaptationSet.
        /// </summary>
        [JsonProperty("AdaptationSet")]
        [XmlElement("AdaptationSet")]
        public List<Models.AdaptationSet> AdaptationSet { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Period : ({string.Join(", ", toStringOutput)})";
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

            return obj is Period other &&
                this.Id.Equals(other.Id) &&
                ((this.Duration == null && other.Duration == null) || (this.Duration?.Equals(other.Duration) == true)) &&
                ((this.Start == null && other.Start == null) || (this.Start?.Equals(other.Start) == true)) &&
                ((this.BaseURL == null && other.BaseURL == null) || (this.BaseURL?.Equals(other.BaseURL) == true)) &&
                ((this.AdaptationSet == null && other.AdaptationSet == null) || (this.AdaptationSet?.Equals(other.AdaptationSet) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Id = {this.Id}");
            toStringOutput.Add($"this.Duration = {(this.Duration == null ? "null" : this.Duration == string.Empty ? "" : this.Duration)}");
            toStringOutput.Add($"this.Start = {(this.Start == null ? "null" : this.Start == string.Empty ? "" : this.Start)}");
            toStringOutput.Add($"this.BaseURL = {(this.BaseURL == null ? "null" : this.BaseURL == string.Empty ? "" : this.BaseURL)}");
            toStringOutput.Add($"this.AdaptationSet = {(this.AdaptationSet == null ? "null" : $"[{string.Join(", ", this.AdaptationSet)} ]")}");
        }
    }
}