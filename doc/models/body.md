
# Body

## Structure

`Body`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Titles` | [`Models.Titles`](../../doc/models/titles.md) | Optional | - |
| `AttributionIcon` | [`Models.AttributionIcon`](../../doc/models/attribution-icon.md) | Optional | - |
| `Summaries` | [`Models.Summaries`](../../doc/models/summaries.md) | Optional | - |
| `Images` | [`Models.Images`](../../doc/models/images.md) | Optional | - |
| `IsFree` | `bool?` | Optional | - |
| `EndDate` | `long?` | Optional | - |
| `ReleaseYear` | `int?` | Optional | - |
| `RatingCode` | `string` | Optional | - |
| `NormalizedRating` | [`Models.NormalizedRating`](../../doc/models/normalized-rating.md) | Optional | - |
| `LocalizedRating` | [`Models.LocalizedRating`](../../doc/models/localized-rating.md) | Optional | - |
| `Duration` | `int` | Required | - |
| `Credits` | [`Models.Credits`](../../doc/models/credits.md) | Optional | - |
| `FirstOfferedDate` | `string` | Optional | - |
| `DisplayBrand` | `string` | Optional | - |
| `AnalyticsId` | `string` | Required | - |
| `SeriesTitles` | [`Models.SeriesTitles`](../../doc/models/series-titles.md) | Optional | - |
| `SeasonTitles` | [`Models.SeasonTitles`](../../doc/models/season-titles.md) | Optional | - |
| `NumberInSeason` | `int?` | Optional | - |
| `SeasonNumber` | `int?` | Optional | - |
| `PlaybackMarkerId` | `string` | Required | - |
| `ShouldUseEpisodePrefix` | `bool?` | Optional | - |
| `References` | [`Models.References`](../../doc/models/references.md) | Required | - |
| `OriginalAudioLanguage` | `string` | Optional | - |
| `AudioTracks` | [`List<Models.AudioTrack>`](../../doc/models/audio-track.md) | Optional | - |
| `TextTracks` | [`List<Models.TextTrack>`](../../doc/models/text-track.md) | Optional | - |
| `CreditsStartTime` | `int?` | Optional | - |
| `Quality` | `string` | Optional | - |
| `DynamicRanges` | `List<string>` | Optional | - |
| `Genres` | `List<string>` | Optional | - |
| `ExtraType` | `string` | Optional | - |

## Example (as JSON)

```json
{
  "titles": {
    "short": "Pilot",
    "full": "Pilot"
  },
  "attributionIcon": {
    "uri": "urn:warnermedia:brand:hbo",
    "alternateText": "HBO"
  },
  "summaries": {
    "short": "Series premiere. Seventeen-year-old Rue returns home from rehab with no plans to stay clean.",
    "full": "Series premiere. Seventeen-year-old Rue returns home from rehab with no plans to stay clean. She meets Jules, who's new in town, at a party at McKay's house. Nate gets in McKay's head when McKay takes an interest in Cassie. Nate and Maddy, who have broken up once again, attempt to make each other jealous. Meanwhile, Kat is pressured to lose something."
  },
  "images": {
    "tile": "https://artist.api.cdn.hbo.com/images/GXKOAMQ3qNcJzwwEAAAAU/tile?v=3c08eaa0b9102627dc0267de3f6135df&size={{size}}&compression={{compression}}&protection={{protection}}&scaleDownToFit={{scaleDownToFit}}&productCode=hboMax&overlayImage=urn:warnermedia:brand:bhm2021",
    "tilezoom": "https://artist.api.cdn.hbo.com/images/GXKOAMQ3qNcJzwwEAAAAU/tilezoom?v=fa143800fd216986ae85806a97c62e6c&size={{size}}&compression={{compression}}&protection={{protection}}&scaleDownToFit={{scaleDownToFit}}&productCode=hboMax&overlayImage=urn:warnermedia:brand:bhm2021",
    "tileburnedin": "https://artist.api.cdn.hbo.com/images/GXKOAMQ3qNcJzwwEAAAAU/tileburnedin?v=fa143800fd216986ae85806a97c62e6c&size={{size}}&compression={{compression}}&protection={{protection}}&scaleDownToFit={{scaleDownToFit}}&productCode=hboMax&overlayImage=urn:warnermedia:brand:bhm2021"
  },
  "isFree": true,
  "endDate": 1711879140000,
  "releaseYear": 2019,
  "ratingCode": "TV-MA",
  "normalizedRating": {
    "value": 18,
    "type": "TV"
  },
  "localizedRating": {
    "value": "TV-MA",
    "a11yText": "TV-MA"
  },
  "duration": 3218,
  "credits": {
    "cast": [
      {
        "role": "Rue Bennett",
        "person": "Zendaya"
      },
      {
        "role": "Lexi Howard",
        "person": "Maude Apatow"
      },
      {
        "role": "Fezco",
        "person": "Angus Cloud"
      },
      {
        "role": "Cal Jacobs",
        "person": "Eric Dane"
      },
      {
        "role": "Maddy Perez",
        "person": "Alexa Demie"
      },
      {
        "role": "Nate Jacobs",
        "person": "Jacob Elordi"
      },
      {
        "role": "Kat Hernandez",
        "person": "Barbie Ferreira"
      },
      {
        "role": "Leslie Bennett",
        "person": "Nika King"
      },
      {
        "role": "Gia Bennett",
        "person": "Storm Reid"
      },
      {
        "role": "Jules Vaughn",
        "person": "Hunter Schafer"
      },
      {
        "role": "Chris McKay",
        "person": "Algee Smith"
      },
      {
        "role": "Cassie Howard",
        "person": "Sydney Sweeney"
      },
      {
        "role": "Suze",
        "person": "Alanna Ubach"
      },
      {
        "role": "Tyler",
        "person": "Lukas Gage"
      },
      {
        "role": "David",
        "person": "John Ales"
      }
    ],
    "directors": [
      {
        "role": "Directed By",
        "person": "Augustine Frizzell"
      }
    ],
    "producers": [
      {
        "role": "Executive Producer",
        "person": "Sam Levinson"
      },
      {
        "role": "Executive Producer",
        "person": "Kevin Turen"
      },
      {
        "role": "Executive Producer",
        "person": "Ravi Nandan"
      },
      {
        "role": "Executive Producer",
        "person": "Drake"
      },
      {
        "role": "Executive Producer",
        "person": "Adel \"Future\" Nur"
      },
      {
        "role": "Executive Producer",
        "person": "Ron Leshem"
      },
      {
        "role": "Executive Producer",
        "person": "Daphna Levin"
      },
      {
        "role": "Executive Producer",
        "person": "Hadas Mozes Lichtenstein"
      },
      {
        "role": "Executive Producer",
        "person": "Gary Lennon"
      },
      {
        "role": "Executive Producer",
        "person": "Mirit Toovi"
      },
      {
        "role": "Executive Producer",
        "person": "Tmira Yardeni"
      },
      {
        "role": "Executive Producer",
        "person": "Yoram Mokady"
      },
      {
        "role": "Producer",
        "person": "Tyler Romary"
      },
      {
        "role": "Co-Executive Producer",
        "person": "Augustine Frizzell"
      }
    ],
    "writers": [
      {
        "role": "Teleplay by",
        "person": "Sam Levinson"
      },
      {
        "role": "Based on the Israeli Series from HOT that was created by",
        "person": "Ron Leshem"
      },
      {
        "role": "Based on the Israeli Series from HOT that was created by",
        "person": "Daphna Levin"
      }
    ]
  },
  "firstOfferedDate": "2019-06-17T02:00:00.000Z",
  "displayBrand": "HBO",
  "analyticsId": "GXKOAMQ3qNcJzwwEAAAAU",
  "seriesTitles": {
    "short": "Euphoria",
    "full": "Euphoria"
  },
  "seasonTitles": {
    "ultraShort": "1",
    "short": "Sn 1",
    "full": "Season 1"
  },
  "numberInSeason": 1,
  "seasonNumber": 1,
  "playbackMarkerId": "GXKOAMQ3qNcJzwwEAAAAU",
  "shouldUseEpisodePrefix": true,
  "references": {
    "edits": [
      "urn:hbo:edit:GXlggQgsftSLCHAEAAANg:episode:GXKOAMQ3qNcJzwwEAAAAU"
    ],
    "extras": [
      "urn:hbo:extra:GXQFNBgXPmsPDWAEAAAAZ",
      "urn:hbo:extra:GYRacIwR7sTdFwwEAAAAa",
      "urn:hbo:extra:GYRabRgwVMBqjwgEAAAAn"
    ],
    "previews": [
      "urn:hbo:edit:GXl1OdgepEp4_wwEAABpp:preview:GX5bpmwV_S5c2vAEAAAAJ:episode:GXKOAMQ3qNcJzwwEAAAAU"
    ],
    "series": "urn:hbo:series:GXKN_xQX5csPDwwEAAABj",
    "season": "urn:hbo:season:GXKOAAAg46sJzwwEAAAAT",
    "next": "urn:hbo:episode:GXNGrcQjxSMLDwgEAAAFw"
  }
}
```

