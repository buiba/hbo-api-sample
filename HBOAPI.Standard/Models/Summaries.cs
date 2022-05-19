// <copyright file="Summaries.cs" company="APIMatic">
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
    /// Summaries.
    /// </summary>
    [XmlRootAttribute("Summaries")]
    public class Summaries
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Summaries"/> class.
        /// </summary>
        public Summaries()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Summaries"/> class.
        /// </summary>
        /// <param name="mShort">short.</param>
        /// <param name="full">full.</param>
        public Summaries(
            string mShort,
            string full)
        {
            this.MShort = mShort;
            this.Full = full;
        }

        /// <summary>
        /// Gets or sets MShort.
        /// </summary>
        [JsonProperty("short")]
        [XmlElement("short")]
        public string MShort { get; set; }

        /// <summary>
        /// Gets or sets Full.
        /// </summary>
        [JsonProperty("full")]
        [XmlElement("full")]
        public string Full { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Summaries : ({string.Join(", ", toStringOutput)})";
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

            return obj is Summaries other &&
                ((this.MShort == null && other.MShort == null) || (this.MShort?.Equals(other.MShort) == true)) &&
                ((this.Full == null && other.Full == null) || (this.Full?.Equals(other.Full) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.MShort = {(this.MShort == null ? "null" : this.MShort == string.Empty ? "" : this.MShort)}");
            toStringOutput.Add($"this.Full = {(this.Full == null ? "null" : this.Full == string.Empty ? "" : this.Full)}");
        }
    }
}