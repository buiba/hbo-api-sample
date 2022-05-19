
# Adaptation Set

## Structure

`AdaptationSet`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `SubsegmentAlignment` | `bool?` | Optional | - |
| `SubsegmentStartsWithSAP` | `int?` | Optional | - |
| `Id` | `int?` | Optional | - |
| `Lang` | `string` | Optional | - |
| `ContentType` | `string` | Optional | - |
| `ContentProtection` | [`List<Models.ContentProtection>`](../../doc/models/content-protection.md) | Required | - |
| `Representation` | [`Models.Representation`](../../doc/models/representation.md) | Required | - |
| `Role` | [`Models.Role`](../../doc/models/role.md) | Optional | - |
| `Accessibility` | [`Models.Accessibility`](../../doc/models/accessibility.md) | Optional | - |
| `FrameRate` | `string` | Optional | - |
| `Par` | `string` | Optional | - |
| `MaxWidth` | `int?` | Optional | - |
| `MaxHeight` | `int?` | Optional | - |
| `SupplementalProperty` | [`Models.SupplementalProperty`](../../doc/models/supplemental-property.md) | Optional | - |

## Example (as XML)

```xml
<AdaptationSet subsegmentAlignment="" subsegmentStartsWithSAP="" id="" lang="" contentType="" frameRate="" par="" maxWidth="" maxHeight="">
  <ContentProtection schemeIdUri="" cenc:default_KID="" value="" xmlns:cenc="urn:mpeg:dash:schema:mpd:2011" />
  <ContentProtection schemeIdUri="" cenc:default_KID="" value="" xmlns:cenc="urn:mpeg:dash:schema:mpd:2011" />
  <ContentProtection schemeIdUri="" cenc:default_KID="" value="" xmlns:cenc="urn:mpeg:dash:schema:mpd:2011" />
  <Representation mimeType="" audioSamplingRate="" bandwidth="" codecs="" id="" sar="" height="" width="">
    <AudioChannelConfiguration />
    <BaseURL>BaseURL2</BaseURL>
    <SegmentBase timescale="" indexRange="">
      <Initialization range="range0" />
    </SegmentBase>
  </Representation>
  <Role />
  <Accessibility />
  <SupplementalProperty />
</AdaptationSet>
```

