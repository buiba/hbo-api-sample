
# Get Movie Information Request

## Structure

`GetMovieInformationRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Required | - |
| `Headers` | [`Models.Headers1`](../../doc/models/headers-1.md) | Required | - |

## Example (as JSON)

```json
{
  "id": "urn:hbo:video:GYbDO8QlR5kF_UwEAAAMg:episode:GYbDO6QCzJb6udwEAAALj",
  "headers": {
    "x-hbo-desired-bitrate": 455,
    "x-hbo-device-model": "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/101.0.4951.67 Safari/537.36",
    "x-hbo-download-quality": "LOWEST",
    "x-hbo-video-features": "server-stitched-playlist,mlp",
    "x-hbo-session-id": "4ec20ee3-0ea2-49bc-90aa-7ae9f4c5683c",
    "x-hbo-video-initiated-time": 1652935000989.5,
    "x-hbo-video-player-version": "undefined/52.20.0.13",
    "x-hbo-device-local-time": "2022-05-19T11:36:40.99+07:00",
    "x-hbo-device-width": 1920,
    "x-hbo-device-height": 1080,
    "x-hbo-player-width": 1920,
    "x-hbo-player-height": 969,
    "x-hbo-device-code-override": "DESKTOP",
    "x-hbo-video-encodes": "H264|DASH|WDV",
    "x-hbo-is-lat": false
  }
}
```

