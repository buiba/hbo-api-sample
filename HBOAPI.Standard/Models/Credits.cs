// <copyright file="Credits.cs" company="APIMatic">
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
    /// Credits.
    /// </summary>
    [XmlRootAttribute("Credits")]
    public class Credits
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Credits"/> class.
        /// </summary>
        public Credits()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Credits"/> class.
        /// </summary>
        /// <param name="cast">cast.</param>
        /// <param name="directors">directors.</param>
        /// <param name="producers">producers.</param>
        /// <param name="writers">writers.</param>
        public Credits(
            List<Models.Cast> cast = null,
            List<Models.Director> directors = null,
            List<Models.Producer> producers = null,
            List<Models.Writer> writers = null)
        {
            this.Cast = cast;
            this.Directors = directors;
            this.Producers = producers;
            this.Writers = writers;
        }

        /// <summary>
        /// Gets or sets Cast.
        /// </summary>
        [JsonProperty("cast", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("Cast")]
        public List<Models.Cast> Cast { get; set; }

        /// <summary>
        /// Gets or sets Directors.
        /// </summary>
        [JsonProperty("directors", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("Director")]
        public List<Models.Director> Directors { get; set; }

        /// <summary>
        /// Gets or sets Producers.
        /// </summary>
        [JsonProperty("producers", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("Producer")]
        public List<Models.Producer> Producers { get; set; }

        /// <summary>
        /// Gets or sets Writers.
        /// </summary>
        [JsonProperty("writers", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("Writer")]
        public List<Models.Writer> Writers { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Credits : ({string.Join(", ", toStringOutput)})";
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

            return obj is Credits other &&
                ((this.Cast == null && other.Cast == null) || (this.Cast?.Equals(other.Cast) == true)) &&
                ((this.Directors == null && other.Directors == null) || (this.Directors?.Equals(other.Directors) == true)) &&
                ((this.Producers == null && other.Producers == null) || (this.Producers?.Equals(other.Producers) == true)) &&
                ((this.Writers == null && other.Writers == null) || (this.Writers?.Equals(other.Writers) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Cast = {(this.Cast == null ? "null" : $"[{string.Join(", ", this.Cast)} ]")}");
            toStringOutput.Add($"this.Directors = {(this.Directors == null ? "null" : $"[{string.Join(", ", this.Directors)} ]")}");
            toStringOutput.Add($"this.Producers = {(this.Producers == null ? "null" : $"[{string.Join(", ", this.Producers)} ]")}");
            toStringOutput.Add($"this.Writers = {(this.Writers == null ? "null" : $"[{string.Join(", ", this.Writers)} ]")}");
        }
    }
}