
# Get Episode

## Structure

`GetEpisode`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Required | - |
| `StatusCode` | `int` | Required | - |
| `Headers` | [`Models.Headers`](../../doc/models/headers.md) | Required | - |
| `Body` | [`Models.Body`](../../doc/models/body.md) | Required | - |

## Example (as JSON)

```json
{
  "id": "urn:hbo:episode:GXKOAMQ3qNcJzwwEAAAAU",
  "statusCode": 200,
  "headers": {
    "ETag": "\"1d29-wj+/pd7bKScL5FJUnK1aQw\"",
    "intent": "navigation",
    "graphId": "13f503168db2bc41437506cefde8123a"
  },
  "body": {
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
}
```

