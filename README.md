# Unified API

FSMB simplifies the licensure process for state boards by providing applicants license portability via UA and primary-source verified information via FCVS. Participating boards can use the Unified API to retrieve information about applicants who have submitted to them via the UA and FCVS applications.

Refer to the [Getting Started with FSMB APIs](https://github.com/fsmb/api-docs) guide to learn more general information about FSMB APIs - terminology, authentication, error handling, FSMB codes, and more.
For more information or to begin using this API, please contact FSMB [here](mailto:fcvs@fsmb.org).

- URL
  - Demo: `https://services-fcvsua-demo.fsmb.org`
  - Production: `https://services-fcvsua.fsmb.org`
- Authentication URL `{baseUrl}/connect/token`
- [Postman Workspace](https://www.postman.com/crimson-shadow-2749/workspace/public-fsmb/collection/2253881-edafbbdc-6f3c-40aa-a3e3-20eb7390d0e6?action=share&creator=2253881&active-environment=2253881-aad2b7f8-bf4b-4f97-810a-0b5f47bb9068)
- [OpenAPI Specification](https://services-fcvsua-demo.fsmb.org/swagger/v1/swagger.json)


[<img src="https://run.pstmn.io/button.svg" alt="Run In Postman" style="width: 128px; height: 32px;">](https://app.getpostman.com/run-collection/2253881-edafbbdc-6f3c-40aa-a3e3-20eb7390d0e6?action=collection%2Ffork&source=rip_markdown&collection-url=entityId%3D2253881-edafbbdc-6f3c-40aa-a3e3-20eb7390d0e6%26entityType%3Dcollection%26workspaceId%3D58240218-129c-4c2c-a71a-139a2efabdb2#?env%5BUnified%20(Demo)%5D=W3sia2V5IjoiYmFzZVVybCIsInZhbHVlIjoiaHR0cHM6Ly9zZXJ2aWNlcy1mY3ZzdWEtZGVtby5mc21iLm9yZyIsImVuYWJsZWQiOnRydWUsInNlc3Npb25WYWx1ZSI6Imh0dHBzOi8vc2VydmljZXMtZmN2c3VhLWRlbW8uZnNtYi5vcmciLCJzZXNzaW9uSW5kZXgiOjB9LHsia2V5IjoiY2xpZW50SWQiLCJ2YWx1ZSI6IkRPX05PVF9TRVRfSEVSRSIsImVuYWJsZWQiOnRydWUsInR5cGUiOiJzZWNyZXQiLCJzZXNzaW9uVmFsdWUiOiJET19OT1RfU0VUX0hFUkUiLCJzZXNzaW9uSW5kZXgiOjF9LHsia2V5IjoiY2xpZW50U2VjcmV0IiwidmFsdWUiOiJET19OT1RfU0VUX0hFUkUiLCJlbmFibGVkIjp0cnVlLCJ0eXBlIjoic2VjcmV0Iiwic2Vzc2lvblZhbHVlIjoiRE9fTk9UX1NFVF9IRVJFIiwic2Vzc2lvbkluZGV4IjoyfV0=)


## Change Log

| Date | Release Notes |
| - | - |
| 2024 | Initial version |

## Security

### Scopes

| Scope | Description |
| - | - |
| fcvs.read | Grants the ability to read applicant information. |

## Resources

- [Applicants](docs/applicants-v1/readme.md)