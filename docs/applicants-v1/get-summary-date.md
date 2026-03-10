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
| 200 OK | [Summary[]](/docs/definitions/summary.md) | Success |
| 204 No Content | | There are no results that match the criteria. |
| 400 Bad request | | Criteria is bad. |
| 404 Not Found | | Board code is missing or invalid. |

## Security

### Scopes

| Scope | Description |
| -|-|
| fcvs.read | Grants the ability to read Applicant information. |

## Examples

[Get Summary for Three Months](#get-summary-for-three-months)

***

### Get Summary for Three Months

#### Sample Request

```HTTP
GET {baseUrl}/v1/me/applicants/summary?fromDate=2025-10-01&toDate=2025-12-31
```

#### Sample Response

Status code: 200

```json
[
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
    },
    {
        "fid": "999999956",
        "name": {
            "firstName": "Jess",
            "middleName": "Chris",
            "lastName": "Samphone",
            "suffix": ""
        },
        "isFcvsAvailable": true,
        "fcvsReleaseDateUtc": "2025-10-23T22:25:40.99Z",
        "isUaAvailable": false,
        "releaseDateUtc": "2025-10-23T22:25:40.99Z"
    }
    {
        "fid": "999999949",
        "name": {
            "firstName": "Robert",
            "middleName": "More",
            "lastName": "Finaling-Final",
            "suffix": "Jr"
        },
        "isFcvsAvailable": true,
        "fcvsReleaseDateUtc": "2025-10-09T22:25:46.887Z",
        "isUaAvailable": false,
        "releaseDateUtc": "2025-10-09T22:25:46.887Z"
    }
]
```

For more examples, go to [samples](/samples/).
