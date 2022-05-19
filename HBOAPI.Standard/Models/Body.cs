// <copyright file="Body.cs" company="APIMatic">
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
    /// Body.
    /// </summary>
    [XmlRootAttribute("Body")]
    public class Body
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Body"/> class.
        /// </summary>
        public Body()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Body"/> class.
        /// </summary>
        /// <param name="duration">duration.</param>
        /// <param name="analyticsId">analyticsId.</param>
        /// <param name="playbackMarkerId">playbackMarkerId.</param>
        /// <param name="references">references.</param>
        /// <param name="titles">titles.</param>
        /// <param name="attributionIcon">attributionIcon.</param>
        /// <param name="summaries">summaries.</param>
        /// <param name="images">images.</param>
        /// <param name="isFree">isFree.</param>
        /// <param name="endDate">endDate.</param>
        /// <param name="releaseYear">releaseYear.</param>
        /// <param name="ratingCode">ratingCode.</param>
        /// <param name="normalizedRating">normalizedRating.</param>
        /// <param name="localizedRating">localizedRating.</param>
        /// <param name="credits">credits.</param>
        /// <param name="firstOfferedDate">firstOfferedDate.</param>
        /// <param name="displayBrand">displayBrand.</param>
        /// <param name="seriesTitles">seriesTitles.</param>
        /// <param name="seasonTitles">seasonTitles.</param>
        /// <param name="numberInSeason">numberInSeason.</param>
        /// <param name="seasonNumber">seasonNumber.</param>
        /// <param name="shouldUseEpisodePrefix">shouldUseEpisodePrefix.</param>
        /// <param name="originalAudioLanguage">originalAudioLanguage.</param>
        /// <param name="audioTracks">audioTracks.</param>
        /// <param name="textTracks">textTracks.</param>
        /// <param name="creditsStartTime">creditsStartTime.</param>
        /// <param name="quality">quality.</param>
        /// <param name="dynamicRanges">dynamicRanges.</param>
        /// <param name="genres">genres.</param>
        /// <param name="extraType">extraType.</param>
        public Body(
            int duration,
            string analyticsId,
            string playbackMarkerId,
            Models.References references,
            Models.Titles titles = null,
            Models.AttributionIcon attributionIcon = null,
            Models.Summaries summaries = null,
            Models.Images images = null,
            bool? isFree = null,
            long? endDate = null,
            int? releaseYear = null,
            string ratingCode = null,
            Models.NormalizedRating normalizedRating = null,
            Models.LocalizedRating localizedRating = null,
            Models.Credits credits = null,
            string firstOfferedDate = null,
            string displayBrand = null,
            Models.SeriesTitles seriesTitles = null,
            Models.SeasonTitles seasonTitles = null,
            int? numberInSeason = null,
            int? seasonNumber = null,
            bool? shouldUseEpisodePrefix = null,
            string originalAudioLanguage = null,
            List<Models.AudioTrack> audioTracks = null,
            List<Models.TextTrack> textTracks = null,
            int? creditsStartTime = null,
            string quality = null,
            List<string> dynamicRanges = null,
            List<string> genres = null,
            string extraType = null)
        {
            this.Titles = titles;
            this.AttributionIcon = attributionIcon;
            this.Summaries = summaries;
            this.Images = images;
            this.IsFree = isFree;
            this.EndDate = endDate;
            this.ReleaseYear = releaseYear;
            this.RatingCode = ratingCode;
            this.NormalizedRating = normalizedRating;
            this.LocalizedRating = localizedRating;
            this.Duration = duration;
            this.Credits = credits;
            this.FirstOfferedDate = firstOfferedDate;
            this.DisplayBrand = displayBrand;
            this.AnalyticsId = analyticsId;
            this.SeriesTitles = seriesTitles;
            this.SeasonTitles = seasonTitles;
            this.NumberInSeason = numberInSeason;
            this.SeasonNumber = seasonNumber;
            this.PlaybackMarkerId = playbackMarkerId;
            this.ShouldUseEpisodePrefix = shouldUseEpisodePrefix;
            this.References = references;
            this.OriginalAudioLanguage = originalAudioLanguage;
            this.AudioTracks = audioTracks;
            this.TextTracks = textTracks;
            this.CreditsStartTime = creditsStartTime;
            this.Quality = quality;
            this.DynamicRanges = dynamicRanges;
            this.Genres = genres;
            this.ExtraType = extraType;
        }

        /// <summary>
        /// Gets or sets Titles.
        /// </summary>
        [JsonProperty("titles", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("Titles")]
        public Models.Titles Titles { get; set; }

        /// <summary>
        /// Gets or sets AttributionIcon.
        /// </summary>
        [JsonProperty("attributionIcon", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("AttributionIcon")]
        public Models.AttributionIcon AttributionIcon { get; set; }

        /// <summary>
        /// Gets or sets Summaries.
        /// </summary>
        [JsonProperty("summaries", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("Summaries")]
        public Models.Summaries Summaries { get; set; }

        /// <summary>
        /// Gets or sets Images.
        /// </summary>
        [JsonProperty("images", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("Images")]
        public Models.Images Images { get; set; }

        /// <summary>
        /// Gets or sets IsFree.
        /// </summary>
        [JsonProperty("isFree", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("isFree")]
        public bool? IsFree { get; set; }

        /// <summary>
        /// Gets or sets EndDate.
        /// </summary>
        [JsonProperty("endDate", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("endDate")]
        public long? EndDate { get; set; }

        /// <summary>
        /// Gets or sets ReleaseYear.
        /// </summary>
        [JsonProperty("releaseYear", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("releaseYear")]
        public int? ReleaseYear { get; set; }

        /// <summary>
        /// Gets or sets RatingCode.
        /// </summary>
        [JsonProperty("ratingCode", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("ratingCode")]
        public string RatingCode { get; set; }

        /// <summary>
        /// Gets or sets NormalizedRating.
        /// </summary>
        [JsonProperty("normalizedRating", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("NormalizedRating")]
        public Models.NormalizedRating NormalizedRating { get; set; }

        /// <summary>
        /// Gets or sets LocalizedRating.
        /// </summary>
        [JsonProperty("localizedRating", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("LocalizedRating")]
        public Models.LocalizedRating LocalizedRating { get; set; }

        /// <summary>
        /// Gets or sets Duration.
        /// </summary>
        [JsonProperty("duration")]
        [XmlElement("duration")]
        public int Duration { get; set; }

        /// <summary>
        /// Gets or sets Credits.
        /// </summary>
        [JsonProperty("credits", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("Credits")]
        public Models.Credits Credits { get; set; }

        /// <summary>
        /// Gets or sets FirstOfferedDate.
        /// </summary>
        [JsonProperty("firstOfferedDate", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("firstOfferedDate")]
        public string FirstOfferedDate { get; set; }

        /// <summary>
        /// Gets or sets DisplayBrand.
        /// </summary>
        [JsonProperty("displayBrand", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("displayBrand")]
        public string DisplayBrand { get; set; }

        /// <summary>
        /// Gets or sets AnalyticsId.
        /// </summary>
        [JsonProperty("analyticsId")]
        [XmlElement("analyticsId")]
        public string AnalyticsId { get; set; }

        /// <summary>
        /// Gets or sets SeriesTitles.
        /// </summary>
        [JsonProperty("seriesTitles", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("SeriesTitles")]
        public Models.SeriesTitles SeriesTitles { get; set; }

        /// <summary>
        /// Gets or sets SeasonTitles.
        /// </summary>
        [JsonProperty("seasonTitles", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("SeasonTitles")]
        public Models.SeasonTitles SeasonTitles { get; set; }

        /// <summary>
        /// Gets or sets NumberInSeason.
        /// </summary>
        [JsonProperty("numberInSeason", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("numberInSeason")]
        public int? NumberInSeason { get; set; }

        /// <summary>
        /// Gets or sets SeasonNumber.
        /// </summary>
        [JsonProperty("seasonNumber", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("seasonNumber")]
        public int? SeasonNumber { get; set; }

        /// <summary>
        /// Gets or sets PlaybackMarkerId.
        /// </summary>
        [JsonProperty("playbackMarkerId")]
        [XmlElement("playbackMarkerId")]
        public string PlaybackMarkerId { get; set; }

        /// <summary>
        /// Gets or sets ShouldUseEpisodePrefix.
        /// </summary>
        [JsonProperty("shouldUseEpisodePrefix", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("shouldUseEpisodePrefix")]
        public bool? ShouldUseEpisodePrefix { get; set; }

        /// <summary>
        /// Gets or sets References.
        /// </summary>
        [JsonProperty("references")]
        [XmlElement("References")]
        public Models.References References { get; set; }

        /// <summary>
        /// Gets or sets OriginalAudioLanguage.
        /// </summary>
        [JsonProperty("originalAudioLanguage", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("originalAudioLanguage")]
        public string OriginalAudioLanguage { get; set; }

        /// <summary>
        /// Gets or sets AudioTracks.
        /// </summary>
        [JsonProperty("audioTracks", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("AudioTrack")]
        public List<Models.AudioTrack> AudioTracks { get; set; }

        /// <summary>
        /// Gets or sets TextTracks.
        /// </summary>
        [JsonProperty("textTracks", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("TextTrack")]
        public List<Models.TextTrack> TextTracks { get; set; }

        /// <summary>
        /// Gets or sets CreditsStartTime.
        /// </summary>
        [JsonProperty("creditsStartTime", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("creditsStartTime")]
        public int? CreditsStartTime { get; set; }

        /// <summary>
        /// Gets or sets Quality.
        /// </summary>
        [JsonProperty("quality", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("quality")]
        public string Quality { get; set; }

        /// <summary>
        /// Gets or sets DynamicRanges.
        /// </summary>
        [JsonProperty("dynamicRanges", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("dynamicRanges")]
        public List<string> DynamicRanges { get; set; }

        /// <summary>
        /// Gets or sets Genres.
        /// </summary>
        [JsonProperty("genres", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("genres")]
        public List<string> Genres { get; set; }

        /// <summary>
        /// Gets or sets ExtraType.
        /// </summary>
        [JsonProperty("extraType", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("extraType")]
        public string ExtraType { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Body : ({string.Join(", ", toStringOutput)})";
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

            return obj is Body other &&
                ((this.Titles == null && other.Titles == null) || (this.Titles?.Equals(other.Titles) == true)) &&
                ((this.AttributionIcon == null && other.AttributionIcon == null) || (this.AttributionIcon?.Equals(other.AttributionIcon) == true)) &&
                ((this.Summaries == null && other.Summaries == null) || (this.Summaries?.Equals(other.Summaries) == true)) &&
                ((this.Images == null && other.Images == null) || (this.Images?.Equals(other.Images) == true)) &&
                ((this.IsFree == null && other.IsFree == null) || (this.IsFree?.Equals(other.IsFree) == true)) &&
                ((this.EndDate == null && other.EndDate == null) || (this.EndDate?.Equals(other.EndDate) == true)) &&
                ((this.ReleaseYear == null && other.ReleaseYear == null) || (this.ReleaseYear?.Equals(other.ReleaseYear) == true)) &&
                ((this.RatingCode == null && other.RatingCode == null) || (this.RatingCode?.Equals(other.RatingCode) == true)) &&
                ((this.NormalizedRating == null && other.NormalizedRating == null) || (this.NormalizedRating?.Equals(other.NormalizedRating) == true)) &&
                ((this.LocalizedRating == null && other.LocalizedRating == null) || (this.LocalizedRating?.Equals(other.LocalizedRating) == true)) &&
                this.Duration.Equals(other.Duration) &&
                ((this.Credits == null && other.Credits == null) || (this.Credits?.Equals(other.Credits) == true)) &&
                ((this.FirstOfferedDate == null && other.FirstOfferedDate == null) || (this.FirstOfferedDate?.Equals(other.FirstOfferedDate) == true)) &&
                ((this.DisplayBrand == null && other.DisplayBrand == null) || (this.DisplayBrand?.Equals(other.DisplayBrand) == true)) &&
                ((this.AnalyticsId == null && other.AnalyticsId == null) || (this.AnalyticsId?.Equals(other.AnalyticsId) == true)) &&
                ((this.SeriesTitles == null && other.SeriesTitles == null) || (this.SeriesTitles?.Equals(other.SeriesTitles) == true)) &&
                ((this.SeasonTitles == null && other.SeasonTitles == null) || (this.SeasonTitles?.Equals(other.SeasonTitles) == true)) &&
                ((this.NumberInSeason == null && other.NumberInSeason == null) || (this.NumberInSeason?.Equals(other.NumberInSeason) == true)) &&
                ((this.SeasonNumber == null && other.SeasonNumber == null) || (this.SeasonNumber?.Equals(other.SeasonNumber) == true)) &&
                ((this.PlaybackMarkerId == null && other.PlaybackMarkerId == null) || (this.PlaybackMarkerId?.Equals(other.PlaybackMarkerId) == true)) &&
                ((this.ShouldUseEpisodePrefix == null && other.ShouldUseEpisodePrefix == null) || (this.ShouldUseEpisodePrefix?.Equals(other.ShouldUseEpisodePrefix) == true)) &&
                ((this.References == null && other.References == null) || (this.References?.Equals(other.References) == true)) &&
                ((this.OriginalAudioLanguage == null && other.OriginalAudioLanguage == null) || (this.OriginalAudioLanguage?.Equals(other.OriginalAudioLanguage) == true)) &&
                ((this.AudioTracks == null && other.AudioTracks == null) || (this.AudioTracks?.Equals(other.AudioTracks) == true)) &&
                ((this.TextTracks == null && other.TextTracks == null) || (this.TextTracks?.Equals(other.TextTracks) == true)) &&
                ((this.CreditsStartTime == null && other.CreditsStartTime == null) || (this.CreditsStartTime?.Equals(other.CreditsStartTime) == true)) &&
                ((this.Quality == null && other.Quality == null) || (this.Quality?.Equals(other.Quality) == true)) &&
                ((this.DynamicRanges == null && other.DynamicRanges == null) || (this.DynamicRanges?.Equals(other.DynamicRanges) == true)) &&
                ((this.Genres == null && other.Genres == null) || (this.Genres?.Equals(other.Genres) == true)) &&
                ((this.ExtraType == null && other.ExtraType == null) || (this.ExtraType?.Equals(other.ExtraType) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Titles = {(this.Titles == null ? "null" : this.Titles.ToString())}");
            toStringOutput.Add($"this.AttributionIcon = {(this.AttributionIcon == null ? "null" : this.AttributionIcon.ToString())}");
            toStringOutput.Add($"this.Summaries = {(this.Summaries == null ? "null" : this.Summaries.ToString())}");
            toStringOutput.Add($"this.Images = {(this.Images == null ? "null" : this.Images.ToString())}");
            toStringOutput.Add($"this.IsFree = {(this.IsFree == null ? "null" : this.IsFree.ToString())}");
            toStringOutput.Add($"this.EndDate = {(this.EndDate == null ? "null" : this.EndDate.ToString())}");
            toStringOutput.Add($"this.ReleaseYear = {(this.ReleaseYear == null ? "null" : this.ReleaseYear.ToString())}");
            toStringOutput.Add($"this.RatingCode = {(this.RatingCode == null ? "null" : this.RatingCode == string.Empty ? "" : this.RatingCode)}");
            toStringOutput.Add($"this.NormalizedRating = {(this.NormalizedRating == null ? "null" : this.NormalizedRating.ToString())}");
            toStringOutput.Add($"this.LocalizedRating = {(this.LocalizedRating == null ? "null" : this.LocalizedRating.ToString())}");
            toStringOutput.Add($"this.Duration = {this.Duration}");
            toStringOutput.Add($"this.Credits = {(this.Credits == null ? "null" : this.Credits.ToString())}");
            toStringOutput.Add($"this.FirstOfferedDate = {(this.FirstOfferedDate == null ? "null" : this.FirstOfferedDate == string.Empty ? "" : this.FirstOfferedDate)}");
            toStringOutput.Add($"this.DisplayBrand = {(this.DisplayBrand == null ? "null" : this.DisplayBrand == string.Empty ? "" : this.DisplayBrand)}");
            toStringOutput.Add($"this.AnalyticsId = {(this.AnalyticsId == null ? "null" : this.AnalyticsId == string.Empty ? "" : this.AnalyticsId)}");
            toStringOutput.Add($"this.SeriesTitles = {(this.SeriesTitles == null ? "null" : this.SeriesTitles.ToString())}");
            toStringOutput.Add($"this.SeasonTitles = {(this.SeasonTitles == null ? "null" : this.SeasonTitles.ToString())}");
            toStringOutput.Add($"this.NumberInSeason = {(this.NumberInSeason == null ? "null" : this.NumberInSeason.ToString())}");
            toStringOutput.Add($"this.SeasonNumber = {(this.SeasonNumber == null ? "null" : this.SeasonNumber.ToString())}");
            toStringOutput.Add($"this.PlaybackMarkerId = {(this.PlaybackMarkerId == null ? "null" : this.PlaybackMarkerId == string.Empty ? "" : this.PlaybackMarkerId)}");
            toStringOutput.Add($"this.ShouldUseEpisodePrefix = {(this.ShouldUseEpisodePrefix == null ? "null" : this.ShouldUseEpisodePrefix.ToString())}");
            toStringOutput.Add($"this.References = {(this.References == null ? "null" : this.References.ToString())}");
            toStringOutput.Add($"this.OriginalAudioLanguage = {(this.OriginalAudioLanguage == null ? "null" : this.OriginalAudioLanguage == string.Empty ? "" : this.OriginalAudioLanguage)}");
            toStringOutput.Add($"this.AudioTracks = {(this.AudioTracks == null ? "null" : $"[{string.Join(", ", this.AudioTracks)} ]")}");
            toStringOutput.Add($"this.TextTracks = {(this.TextTracks == null ? "null" : $"[{string.Join(", ", this.TextTracks)} ]")}");
            toStringOutput.Add($"this.CreditsStartTime = {(this.CreditsStartTime == null ? "null" : this.CreditsStartTime.ToString())}");
            toStringOutput.Add($"this.Quality = {(this.Quality == null ? "null" : this.Quality == string.Empty ? "" : this.Quality)}");
            toStringOutput.Add($"this.DynamicRanges = {(this.DynamicRanges == null ? "null" : $"[{string.Join(", ", this.DynamicRanges)} ]")}");
            toStringOutput.Add($"this.Genres = {(this.Genres == null ? "null" : $"[{string.Join(", ", this.Genres)} ]")}");
            toStringOutput.Add($"this.ExtraType = {(this.ExtraType == null ? "null" : this.ExtraType == string.Empty ? "" : this.ExtraType)}");
        }
    }
}