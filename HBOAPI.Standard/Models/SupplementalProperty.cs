// <copyright file="SupplementalProperty.cs" company="APIMatic">
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
    /// SupplementalProperty.
    /// </summary>
    [XmlRootAttribute("SupplementalProperty")]
    public class SupplementalProperty
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SupplementalProperty"/> class.
        /// </summary>
        public SupplementalProperty()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SupplementalProperty"/> class.
        /// </summary>
        /// <param name="schemeIdUri">schemeIdUri.</param>
        /// <param name="mValue">value.</param>
        public SupplementalProperty(
            string schemeIdUri,
            string mValue)
        {
            this.SchemeIdUri = schemeIdUri;
            this.MValue = mValue;
        }

        /// <summary>
        /// Gets or sets SchemeIdUri.
        /// </summary>
        [JsonProperty("schemeIdUri")]
        [XmlAttribute("schemeIdUri")]
        public string SchemeIdUri { get; set; }

        /// <summary>
        /// Gets or sets MValue.
        /// </summary>
        [JsonProperty("value")]
        [XmlAttribute("value")]
        public string MValue { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"SupplementalProperty : ({string.Join(", ", toStringOutput)})";
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

            return obj is SupplementalProperty other &&
                ((this.SchemeIdUri == null && other.SchemeIdUri == null) || (this.SchemeIdUri?.Equals(other.SchemeIdUri) == true)) &&
                ((this.MValue == null && other.MValue == null) || (this.MValue?.Equals(other.MValue) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.SchemeIdUri = {(this.SchemeIdUri == null ? "null" : this.SchemeIdUri == string.Empty ? "" : this.SchemeIdUri)}");
            toStringOutput.Add($"this.MValue = {(this.MValue == null ? "null" : this.MValue == string.Empty ? "" : this.MValue)}");
        }
    }
}