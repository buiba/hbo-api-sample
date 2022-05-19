// <copyright file="MPD.cs" company="APIMatic">
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
    /// MPD.
    /// </summary>
    [XmlRootAttribute("MPD")]
    public class MPD
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MPD"/> class.
        /// </summary>
        public MPD()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MPD"/> class.
        /// </summary>
        /// <param name="profiles">profiles.</param>
        /// <param name="type">type.</param>
        /// <param name="mediaPresentationDuration">mediaPresentationDuration.</param>
        /// <param name="minBufferTime">minBufferTime.</param>
        /// <param name="baseURL">BaseURL.</param>
        /// <param name="period">Period.</param>
        public MPD(
            string profiles,
            string type,
            string mediaPresentationDuration,
            string minBufferTime,
            string baseURL,
            Models.Period period)
        {
            this.Profiles = profiles;
            this.Type = type;
            this.MediaPresentationDuration = mediaPresentationDuration;
            this.MinBufferTime = minBufferTime;
            this.BaseURL = baseURL;
            this.Period = period;
        }

        /// <summary>
        /// Gets or sets Profiles.
        /// </summary>
        [JsonProperty("profiles")]
        [XmlAttribute("profiles")]
        public string Profiles { get; set; }

        /// <summary>
        /// Gets or sets Type.
        /// </summary>
        [JsonProperty("type")]
        [XmlAttribute("type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets MediaPresentationDuration.
        /// </summary>
        [JsonProperty("mediaPresentationDuration")]
        [XmlAttribute("mediaPresentationDuration")]
        public string MediaPresentationDuration { get; set; }

        /// <summary>
        /// Gets or sets MinBufferTime.
        /// </summary>
        [JsonProperty("minBufferTime")]
        [XmlAttribute("minBufferTime")]
        public string MinBufferTime { get; set; }

        /// <summary>
        /// Gets or sets BaseURL.
        /// </summary>
        [JsonProperty("BaseURL")]
        [XmlElement("BaseURL")]
        public string BaseURL { get; set; }

        /// <summary>
        /// Gets or sets Period.
        /// </summary>
        [JsonProperty("Period")]
        [XmlElement("Period")]
        public Models.Period Period { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"MPD : ({string.Join(", ", toStringOutput)})";
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

            return obj is MPD other &&
                ((this.Profiles == null && other.Profiles == null) || (this.Profiles?.Equals(other.Profiles) == true)) &&
                ((this.Type == null && other.Type == null) || (this.Type?.Equals(other.Type) == true)) &&
                ((this.MediaPresentationDuration == null && other.MediaPresentationDuration == null) || (this.MediaPresentationDuration?.Equals(other.MediaPresentationDuration) == true)) &&
                ((this.MinBufferTime == null && other.MinBufferTime == null) || (this.MinBufferTime?.Equals(other.MinBufferTime) == true)) &&
                ((this.BaseURL == null && other.BaseURL == null) || (this.BaseURL?.Equals(other.BaseURL) == true)) &&
                ((this.Period == null && other.Period == null) || (this.Period?.Equals(other.Period) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Profiles = {(this.Profiles == null ? "null" : this.Profiles == string.Empty ? "" : this.Profiles)}");
            toStringOutput.Add($"this.Type = {(this.Type == null ? "null" : this.Type == string.Empty ? "" : this.Type)}");
            toStringOutput.Add($"this.MediaPresentationDuration = {(this.MediaPresentationDuration == null ? "null" : this.MediaPresentationDuration == string.Empty ? "" : this.MediaPresentationDuration)}");
            toStringOutput.Add($"this.MinBufferTime = {(this.MinBufferTime == null ? "null" : this.MinBufferTime == string.Empty ? "" : this.MinBufferTime)}");
            toStringOutput.Add($"this.BaseURL = {(this.BaseURL == null ? "null" : this.BaseURL == string.Empty ? "" : this.BaseURL)}");
            toStringOutput.Add($"this.Period = {(this.Period == null ? "null" : this.Period.ToString())}");
        }
    }
}