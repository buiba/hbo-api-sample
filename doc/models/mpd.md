
# MPD

## Structure

`MPD`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Profiles` | `string` | Required | - |
| `Type` | `string` | Required | - |
| `MediaPresentationDuration` | `string` | Required | - |
| `MinBufferTime` | `string` | Required | - |
| `BaseURL` | `string` | Required | - |
| `Period` | [`Models.Period`](../../doc/models/period.md) | Required | - |

## Example (as XML)

```xml
<MPD profiles="profiles8" type="type0" mediaPresentationDuration="mediaPresentationDuration8" minBufferTime="minBufferTime8">
  <BaseURL>BaseURL4</BaseURL>
  <Period id="162" duration="duration8" start="start6">
    <BaseURL>BaseURL6</BaseURL>
    <AdaptationSet subsegmentAlignment="" subsegmentStartsWithSAP="" id="" lang="" contentType="" frameRate="" par="" maxWidth="" maxHeight="">
      <ContentProtection schemeIdUri="" cenc:default_KID="" value="" xmlns:cenc="urn:mpeg:dash:schema:mpd:2011" />
      <Representation mimeType="" audioSamplingRate="" bandwidth="" codecs="" id="" sar="" height="" width="">
        <AudioChannelConfiguration />
        <BaseURL>BaseURL8</BaseURL>
        <SegmentBase timescale="" indexRange="">
          <Initialization range="range4" />
        </SegmentBase>
      </Representation>
      <Role />
      <Accessibility />
      <SupplementalProperty />
    </AdaptationSet>
    <AdaptationSet subsegmentAlignment="" subsegmentStartsWithSAP="" id="" lang="" contentType="" frameRate="" par="" maxWidth="" maxHeight="">
      <ContentProtection schemeIdUri="" cenc:default_KID="" value="" xmlns:cenc="urn:mpeg:dash:schema:mpd:2011" />
      <ContentProtection schemeIdUri="" cenc:default_KID="" value="" xmlns:cenc="urn:mpeg:dash:schema:mpd:2011" />
      <ContentProtection schemeIdUri="" cenc:default_KID="" value="" xmlns:cenc="urn:mpeg:dash:schema:mpd:2011" />
      <Representation mimeType="" audioSamplingRate="" bandwidth="" codecs="" id="" sar="" height="" width="">
        <AudioChannelConfiguration />
        <BaseURL>BaseURL7</BaseURL>
        <SegmentBase timescale="" indexRange="">
          <Initialization range="range5" />
        </SegmentBase>
      </Representation>
      <Role />
      <Accessibility />
      <SupplementalProperty />
    </AdaptationSet>
    <AdaptationSet subsegmentAlignment="" subsegmentStartsWithSAP="" id="" lang="" contentType="" frameRate="" par="" maxWidth="" maxHeight="">
      <ContentProtection schemeIdUri="" cenc:default_KID="" value="" xmlns:cenc="urn:mpeg:dash:schema:mpd:2011" />
      <ContentProtection schemeIdUri="" cenc:default_KID="" value="" xmlns:cenc="urn:mpeg:dash:schema:mpd:2011" />
      <Representation mimeType="" audioSamplingRate="" bandwidth="" codecs="" id="" sar="" height="" width="">
        <AudioChannelConfiguration />
        <BaseURL>BaseURL6</BaseURL>
        <SegmentBase timescale="" indexRange="">
          <Initialization range="range6" />
        </SegmentBase>
      </Representation>
      <Role />
      <Accessibility />
      <SupplementalProperty />
    </AdaptationSet>
  </Period>
</MPD>
```

