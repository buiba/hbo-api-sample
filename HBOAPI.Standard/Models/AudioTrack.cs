// <copyright file="AudioTrack.cs" company="APIMatic">
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
    /// AudioTrack.
    /// </summary>
    [XmlRootAttribute("AudioTrack")]
    public class AudioTrack
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AudioTrack"/> class.
        /// </summary>
        public AudioTrack()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioTrack"/> class.
        /// </summary>
        /// <param name="language">language.</param>
        /// <param name="output">output.</param>
        /// <param name="displayName">displayName.</param>
        public AudioTrack(
            string language,
            string output,
            string displayName)
        {
            this.Language = language;
            this.Output = output;
            this.DisplayName = displayName;
        }

        /// <summary>
        /// Gets or sets Language.
        /// </summary>
        [JsonProperty("language")]
        [XmlElement("language")]
        public string Language { get; set; }

        /// <summary>
        /// Gets or sets Output.
        /// </summary>
        [JsonProperty("output")]
        [XmlElement("output")]
        public string Output { get; set; }

        /// <summary>
        /// Gets or sets DisplayName.
        /// </summary>
        [JsonProperty("displayName")]
        [XmlElement("displayName")]
        public string DisplayName { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"AudioTrack : ({string.Join(", ", toStringOutput)})";
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

            return obj is AudioTrack other &&
                ((this.Language == null && other.Language == null) || (this.Language?.Equals(other.Language) == true)) &&
                ((this.Output == null && other.Output == null) || (this.Output?.Equals(other.Output) == true)) &&
                ((this.DisplayName == null && other.DisplayName == null) || (this.DisplayName?.Equals(other.DisplayName) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Language = {(this.Language == null ? "null" : this.Language == string.Empty ? "" : this.Language)}");
            toStringOutput.Add($"this.Output = {(this.Output == null ? "null" : this.Output == string.Empty ? "" : this.Output)}");
            toStringOutput.Add($"this.DisplayName = {(this.DisplayName == null ? "null" : this.DisplayName == string.Empty ? "" : this.DisplayName)}");
        }
    }
}