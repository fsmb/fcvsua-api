# Application

Application information.

| Name | Type | Required | Description |
| - | - | - | - |
| boardName | string (len: 100) | Yes | Board name. |
| licenseType | string (len: 5) | No | Type of license (e.g. `MD`, `DO`, `PA`). Refer to [codes](https://github.com/fsmb/api-docs/tree/master/docs/codes) for more information. |
| licenseSubtypeDetails | [LicenseSubtype](license-subtype.md) | No | Subtype of license. |

*Note: Any fields marked as deprecated will be removed in a future version of the API. New code should not rely on these fields. Existing code should be updated to use alternative fields.*
