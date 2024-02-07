# Get

Gets an applicant, by its FID.

```HTTP
GET {baseUrl}/v1/{board}/applicants/{fid}
```

## URI Parameters

| Name | In | Required | Type | Description |
| - |-|-|-|-|
| baseUrl | path | True | string | The API URL. |
| board | path | True | string | The board code or `me`. |
| fid | path | True | string | The practitioner's FID. |

## Responses

| Name | Type | Description |
| - |-|-|
| 200 OK | [Applicant](/docs/definitions/applicant.md) | Success |
| 204 No Content | | Applicant does not exist for board or is invalid. |
| 400 Bad request | | FID is invalid. |
| 404 Not Found | | Board code is missing or invalid. |

## Security

### Scopes

| Scope | Description |
| -|-|
| fcvs.read | Grants the ability to read Applicant information. |

## Examples

[Get applicant](#get-applicant)

***

### Get applicant

#### Sample Request

```HTTP
GET {baseUrl}/v1/me/applicants/999999915
```

#### Sample Response

Status code: 200

*Note: Output is elided. Refer to [Applicant](/docs/definitions/applicant.md) for a complete example.*

```json
{
    "fid": "999999915",
    "application": {
        "boardName": "Texas Medical Board",
        "licenseType": "MD",
        
        "licenseSubtypeDetails": {
          "code": "FULL",
          "description": "Permanent Medical License"
        }
    },
    "names": {
        "legalName": {
            "firstName": "Philip",
            "middleName": "James",
            "lastName": "Testman",
            "suffix": "Jr"
        }
    },
    ...
}
```

For more examples, go to [samples](/samples/).