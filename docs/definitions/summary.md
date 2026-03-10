# Summary

Applicant summary details. Release date/times are in UTC.

| Name | Type | Required | Description |
| - | - | - | - |
| fid | string (format: digits, len: 9) | Yes | FID of the physician. |
| name | [Name](name.md) | Yes | Name of the physician. |
| isFcvsAvailable | boolean | Yes | Indicates if the physician has FCVS. |
| fcvsReleaseDateUtc | string (datetime) | No | Date/time of FCVS profile released, if available. |
| isUaAvailable | boolean | Yes | Indicates if the physician has UA. |
| uaReleaseDateUtc | string (datetime) | No | Date/time of UA released, if available. |
| releaseDateUtc | string (datetime) | No | Date/time of newer release, between FCVS/UA, if available. |

## Example

```json
{
    "fid": "999999915",
    "name": {
        "firstName": "Philip",
        "middleName": "James",
        "lastName": "Testman",
        "suffix": "Jr"
    },
    "isFcvsAvailable": true,
    "fcvsReleaseDateUtc": "2025-11-06T23:25:40.43Z",
    "isUaAvailable": true,
    "uaReleaseDateUtc": "2025-11-05T23:25:48.903Z",
    "releaseDateUtc": "2025-11-06T23:25:40.43Z"
}
```
