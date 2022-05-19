
# Representation

## Structure

`Representation`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `MimeType` | `string` | Optional | - |
| `AudioSamplingRate` | `int?` | Optional | - |
| `Bandwidth` | `int?` | Optional | - |
| `Codecs` | `string` | Optional | - |
| `Id` | `string` | Optional | - |
| `AudioChannelConfiguration` | [`Models.AudioChannelConfiguration`](../../doc/models/audio-channel-configuration.md) | Optional | - |
| `BaseURL` | `string` | Required | - |
| `SegmentBase` | [`Models.SegmentBase`](../../doc/models/segment-base.md) | Required | - |
| `Sar` | `string` | Optional | - |
| `Height` | `int?` | Optional | - |
| `Width` | `int?` | Optional | - |

## Example (as XML)

```xml
<Representation mimeType="" audioSamplingRate="" bandwidth="" codecs="" id="" sar="" height="" width="">
  <AudioChannelConfiguration />
  <BaseURL>BaseURL4</BaseURL>
  <SegmentBase timescale="" indexRange="">
    <Initialization range="range8" />
  </SegmentBase>
</Representation>
```

