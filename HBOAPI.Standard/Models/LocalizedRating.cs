// <copyright file="LocalizedRating.cs" company="APIMatic">
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
    /// LocalizedRating.
    /// </summary>
    [XmlRootAttribute("LocalizedRating")]
    public class LocalizedRating
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LocalizedRating"/> class.
        /// </summary>
        public LocalizedRating()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LocalizedRating"/> class.
        /// </summary>
        /// <param name="mValue">value.</param>
        /// <param name="a11yText">a11yText.</param>
        public LocalizedRating(
            string mValue,
            string a11yText)
        {
            this.MValue = mValue;
            this.A11yText = a11yText;
        }

        /// <summary>
        /// Gets or sets MValue.
        /// </summary>
        [JsonProperty("value")]
        [XmlElement("value")]
        public string MValue { get; set; }

        /// <summary>
        /// Gets or sets A11yText.
        /// </summary>
        [JsonProperty("a11yText")]
        [XmlElement("a11yText")]
        public string A11yText { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"LocalizedRating : ({string.Join(", ", toStringOutput)})";
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

            return obj is LocalizedRating other &&
                ((this.MValue == null && other.MValue == null) || (this.MValue?.Equals(other.MValue) == true)) &&
                ((this.A11yText == null && other.A11yText == null) || (this.A11yText?.Equals(other.A11yText) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.MValue = {(this.MValue == null ? "null" : this.MValue == string.Empty ? "" : this.MValue)}");
            toStringOutput.Add($"this.A11yText = {(this.A11yText == null ? "null" : this.A11yText == string.Empty ? "" : this.A11yText)}");
        }
    }
}