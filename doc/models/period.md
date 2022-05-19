
# Period

## Structure

`Period`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `int` | Required | - |
| `Duration` | `string` | Required | - |
| `Start` | `string` | Required | - |
| `BaseURL` | `string` | Required | - |
| `AdaptationSet` | [`List<Models.AdaptationSet>`](../../doc/models/adaptation-set.md) | Required | - |

## Example (as XML)

```xml
<Period id="112" duration="duration6" start="start4">
  <BaseURL>BaseURL4</BaseURL>
  <AdaptationSet subsegmentAlignment="" subsegmentStartsWithSAP="" id="" lang="" contentType="" frameRate="" par="" maxWidth="" maxHeight="">
    <ContentProtection schemeIdUri="" cenc:default_KID="" value="" xmlns:cenc="urn:mpeg:dash:schema:mpd:2011" />
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
```

