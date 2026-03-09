# Summary

Applicant summary details. Release dates are in local time

| Name | Type | Required | Description |
| - | - | - | - |
| fid | string (format: digits, len: 9) | Yes | FID of the physician. |
| name | [Name](name.md) | Yes | Name of the physician. |
| isFcvsAvailable | boolean | Yes | Indicates if the physician has FCVS. |
| fcvsReleaseDate | string (datetime) | No | Date/time of FCVS profile released, if available. |
| isUaAvailable | boolean | Yes | Indicates if the physician has UA. |
| uaReleaseDate | string (datetime) | No | Date/time of UA released, if available. |
| releaseDate | string (datetime) | No | Date/time of newer release, between FCVS/UA, if available. |

## Example

```json
{
    "fid": "209856897",
    "name": {
        "firstName": "Fedon",
        "middleName": "",
        "lastName": "Mavromatis",
        "suffix": ""
    },
    "isFcvsAvailable": true,
    "fcvsReleaseDate": "2025-11-06T17:25:40.43",
    "isUaAvailable": true,
    "uaReleaseDate": "2025-11-05T17:25:48.903",
    "releaseDate": "2025-11-06T17:25:40.43"
}
```
