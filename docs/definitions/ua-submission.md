# UaSubmission

UA Submission.

| Name | Type | Required | Description |
| - | - | - | - |
| submissionId | integer | Yes | Submission ID |
| submissionStatus | string ([UaStatus](ua-status.md)) | Yes | UA status |
| submissionDateUtc | string (date-time) | Yes | Date/time the UA was submitted (in UTC) |

*Note: Any fields marked as deprecated will be removed in a future version of the API. New code should not rely on these fields. Existing code should be updated to use alternative fields.*