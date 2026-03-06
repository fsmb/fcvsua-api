# Get Summary By Date Range

Gets a summary of FCVS and UA released in a given date range.

```http
GET {baseUrl}/v1/{board}/applicants/summary?fromDate={fromDate}&toDate={toDate}
```

## URI Parameters

| Name | In | Required | Type | Description |
| - |-|-|-|-|
| baseUrl | path | True | string | The API URL. |
| board | path | True | string | The board code or `me`. |
| fromDate | query | True | DateTime (format: `yyyy-mm-dd`) | The start date for FCVS and UA released. |
| toDate | query | True | DateTime (format: `yyyy-mm-dd`) | The end date for FCVS and UA released.

## Responses

| Name | Type | Description |
| - |-|-|
| 200 OK | [Summary](/docs/definitions/summary.md) | Success |
| 204 No Content | | There are no results that match the criteria. |
| 400 Bad request | | Criteria is bad. |
| 404 Not Found | | Board code is missing or invalid. |

## Security

### Scopes

| Scope | Description |
| -|-|
| fcvs.read | Grants the ability to read Applicant information. |

## Examples

[Get summary by date range](#get-summary-date)

***

### Get Summary by Date Range

#### Sample Request

```HTTP
GET {baseUrl}/v1/me/applicants/summary?fromDate=2025-06-01&toDate=2025-12-31
```

#### Sample Response

Status code: 200

*Note: Output is elided. Refer to [Applicant](/docs/definitions/summary.md) for a complete example.*

```json
[
    {
        "fid": "307532069",
        "name": {
            "firstName": "Mungu",
            "middleName": "",
            "lastName": "Patel",
            "suffix": ""
        },
        "isFcvsAvailable": false,
        "isUaAvailable": true,
        "uaReleaseDate": "2025-12-11T17:25:47.887",
        "releaseDate": "2025-12-11T17:25:47.887"
    },
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
    },
    ...
]
```

For more examples, go to [samples](/samples/).
