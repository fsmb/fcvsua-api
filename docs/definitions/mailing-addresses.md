# MailingAddresses

List of mailing addresses.

| Name | Type | Required | Description |
| - | - | - | - |
| forPublic | [MailingAddress](mailing-address.md) | Yes | Public address. |
| forBoard | [MailingAddress](mailing-address.md) | Yes | Board address. |
| primary | [MailingAddress](mailing-address.md) | Yes | Primary address. |
| other | [MailingAddress](mailing-address.md)[] | No | Other addresses. |

*Note: Any fields marked as deprecated will be removed in a future version of the API. New code should not rely on these fields. Existing code should be updated to use alternative fields.*
