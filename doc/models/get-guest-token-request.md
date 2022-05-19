
# Get Guest Token Request

## Structure

`GetGuestTokenRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ClientId` | `string` | Required | - |
| `ClientSecret` | `string` | Required | - |
| `Scope` | `string` | Required | - |
| `GrantType` | `string` | Required | - |
| `DeviceSerialNumber` | `string` | Required | - |
| `ClientDeviceData` | [`Models.ClientDeviceData`](../../doc/models/client-device-data.md) | Required | - |

## Example (as JSON)

```json
{
  "client_id": "585b02c8-dbe1-432f-b1bb-11cf670fbeb0",
  "client_secret": "585b02c8-dbe1-432f-b1bb-11cf670fbeb0",
  "scope": "browse video_playback_free",
  "grant_type": "client_credentials",
  "deviceSerialNumber": "cf7e5801-9962-4219-b14f-65648cee11f2",
  "clientDeviceData": {
    "paymentProviderCode": "blackmarket"
  }
}
```

