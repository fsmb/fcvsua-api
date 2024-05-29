# Submission

Applicant details

| Name | Type | Required | Description |
| - | - | - | - |
| fid | string (format: digits, len: 9) | Yes | FID of practitioner. |
| application | [Application](application.md) | Yes | Application information. |
| fcvsProfileStatus | string ([FcvsProfileStatus](fcvs-profile-status.md)) | Yes | FCVS profile status. |
| fcvsProfile | [FcvsProfileReport](fcvs-profile-report.md) | No | FCVS profile information, if available. |
| uaStatus | string ([UaStatus](ua-status.md)) | Yes | UA status. |
| uaSubmission | [UaSubmission](ua-submission.md) | No | UA submission information, if available. |
| identity | [Identification](identification.md) | Yes | Identity information. |
| names | [Names](names.md) | Yes | Names |
| addresses | [MailingAddresses](mailing-addresses.md) | Yes | Mailing addresses. |
| emailAddresses | [EmailAddresses](email-addresses.md) | Yes | Email addresses. |
| phones | [Phones](phones.md) | Yes | Phone numbers. |
| medicalEducation | [MedicalEducationTraining](medical-education-training.md) | Yes | Medical education. |
| postGraduateTraining | [PostGraduateTraining](post-graduate-training.md) | No | Postgraduate training. |                    
| exams | [Exam](exam.md)[] | No | Exams. |
| licenses | [License](license.md)[] | No | Licenses. |
| malpractice | [Malpractice](malpractice.md)[] | No | Malpractice information. |
| activities | [Activity](activity.md)[] | No | Chronology of activity. |
| npdbReportStatus | string ([NpdbReportStatus](npdb-report-status.md)) | Yes | NPDB report status. |
| npdbReport | [NpdbReport](npdb-report.md) | No | NPDB report, if available. |

<!-- | pdcReportStatus | string (len: 20) | Yes | Status of PDC report. Refer to [ReportStatus](report-status.md) for possible values. |
| pdc | [PdcReport](pdc/pdc-report.md) | No | PDC information, if available. |
| ama | [AmaReport](ama/ama-report.md) | No | AMA information, if available. |
| amaReportStatus | string ([AmaReportStatus](ama/ama-report-status.md)) | Yes | Status of AMA report. |
| addendum | object | No | | -->

*Note: Any fields marked as deprecated will be removed in a future version of the API. New code should not rely on these fields. Existing code should be updated to use alternative fields.*


## Example

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
    "identity": {
        "ssn": "124561111",
        "ssnLast4": "1111",
        "isUSCitizen": "Y",
        "birthDate": "1978-08-08T00:00:00",
        "birthCity": "Houston",
        "birthStateOrProvince": {
            "code": "TX",
            "description": "Texas",
            "countryCode": "US",
            "countryDescription": "United States"
        },
        "gender": "M"
    },
    "names": {
        "legalName": {
            "firstName": "Philip",
            "middleName": "James",
            "lastName": "Testman"
        }
    },
    "addresses": {
        "forPublic": {
            "addressType": "Business",
            "lines": [
                "9665 Greenway Trail"
            ],
            "city": "Portland",
            "stateOrProvince": {
                "code": "OR",
                "description": "Oregon",
                "countryCode": "US",
                "countryDescription": "United States"
            },
            "postalCode": "89456"
        },
        "forBoard": {
            "addressType": "Business",
            "lines": [
                "9665 Greenway Trail"
            ],
            "city": "Portland",
            "stateOrProvince": {
                "code": "OR",
                "description": "Oregon",
                "countryCode": "US",
                "countryDescription": "United States"
            },
            "postalCode": "89456"
        },
        "primary": {
            "addressType": "Business",
            "lines": [
                "9665 Greenway Trail"
            ],
            "city": "Portland",
            "stateOrProvince": {
                "code": "OR",
                "description": "Oregon",
                "countryCode": "US",
                "countryDescription": "United States"
            },
            "postalCode": "89456"
        }
    },
    "emailAddresses": {
        "forPublic": {
            "email": "FSMBQA@fsmb.org"
        },
        "forBoard": {
            "email": "FSMBQA@fsmb.org"
        },
        "primary": {
            "email": "FSMBQA@fsmb.org"
        }
    },
    "phones": {
        "forPublic": {
            "phoneType": "Business",
            "phoneNumber": "8524567856"
        },
        "forBoard": {
            "phoneType": "Business",
            "phoneNumber": "8524567856"
        },
        "primary": {
            "phoneType": "Business",
            "phoneNumber": "8524567856"
        }
    },
    "medicalEducation": {
        "isInternationalGraduate": false,
        "graduating": {
            "school": {
                "name": "West Virginia University School of Medicine",
                "cibisCode": "049030",
                "schoolType": {
                    "code": "MD",
                    "description": "Doctor of Medicine"
                },
                "city": "Morgantown",
                "stateOrProvince": {
                    "code": "WV",
                    "description": "West Virginia",
                    "countryCode": "US",
                    "countryDescription": "United States"
                }
            },
            "beginDate": "2000-08-01T00:00:00",
            "endDate": "2004-07-01T00:00:00",
            "degree": {
                "code": "DM",
                "description": "Doctor of Medicine"
            },
            "graduationDate": "2004-08-20T00:00:00",
            "unusualCircumstances": {
                "hasInterruptions": false,
                "hasProbation": false,
                "hasInvestigation": false,
                "hasBehavior": false,
                "hasRequirements": false
            }
        }
    },
    "postGraduateTraining": {
        "accreditedTraining": [
            {
                "accreditationType": "ACGME",
                "programCode": "1102500201",
                "program": {
                    "hospitalName": "Trinity Health Muskegon Program",
                    "affiliatedInstitution": "Trinity Health Muskegon",
                    "city": "Muskegon",
                    "stateOrProvince": {
                        "code": "MI",
                        "description": "Michigan",
                        "countryCode": "US",
                        "countryDescription": "United States"
                    }
                },
                "specialty": {
                    "description": "Emergency Medicine"
                },
                "programType": "Residency",
                "trainingStatus": "Completed",
                "beginDate": "2004-07-01T00:00:00",
                "endDate": "2008-06-30T00:00:00",
                "percentageClinical": 50,
                "percentageAdministrative": 50,
                 "unusualCircumstances": {
                    "hasInterruptions": false,
                    "hasProbation": false,
                    "hasInvestigation": false,
                    "hasBehavior": false,
                    "hasRequirements": false
                }
            }
        ]
    },
    "exams": [
        {
            "examType": "USMLE Step 1",
            "examDate": "2002-04-22T00:00:00",
            "numberOfAttempts": 2,
            "passFail": "Pass"
        }
    ],
    "licenses": [
        {
            "licenseType": "Administrative",
            "licensingEntity": {
                "code": "AL",
                "description": "Alabama"
            },
            "status": "Active",
            "licenseNumber": "TEST1111",
            "issueDate": "2010-07-01T00:00:00",
            "expirationDate": "2030-06-30T00:00:00"
        },
        {
            "licenseType": "Full",
            "licensingEntity": {
                "code": "AZ",
                "description": "Arizona"
            },
            "status": "General",
            "licenseNumber": "TEST3333",
            "issueDate": "2010-07-01T00:00:00",
            "expirationDate": "2030-06-30T00:00:00"
        },
        {
            "licenseType": "Full",
            "licensingEntity": {
                "code": "NH",
                "description": "New Hampshire"
            },
            "status": "Active",
            "licenseNumber": "TEST555",
            "issueDate": "2004-07-01T00:00:00",
            "expirationDate": "2030-06-30T00:00:00"
        },
        {
            "licenseType": "Teaching",
            "licensingEntity": {
                "code": "AK",
                "description": "Alaska"
            },
            "status": "Expired",
            "licenseNumber": "TEST2222",
            "issueDate": "2001-07-01T00:00:00",
            "expirationDate": "2012-06-30T00:00:00"
        }
    ],
    "malpractice": [
        {
            "state": {
                "code": "CO",
                "description": "Colorado",
                "countryCode": "US",
                "countryDescription": "United States"
            },
            "eventDate": "2010-01-01T00:00:00",
            "patientName": "Patient Smith",
            "courtName": "County Court",
            "role": "Primary Defendant",
            "lawsuitDate": "2012-01-01T00:00:00",
            "claimStatus": "Closed (Settled)",
            "insuranceName": "InsuranceName",
            "explanation": "Explanation"
        }
    ],
    "activities": [
        {
            "type": "Work",
            "inProgress": false,
            "beginDate": "2008-07-01T00:00:00",
            "endDate": "2024-02-01T00:00:00",
            "description": "Michigan Hospital",
            "addressLines": [
                "400 Main St"
            ],
            "city": "Muskegon",
            "stateOrProvince": {
                "code": "MI",
                "description": "Michigan",
                "countryCode": "US",
                "countryDescription": "United States"
            },
            "position": "ER Physician",
            "department": "ER",
            "wasEmployed": false,
            "hadStaffPrivileges": false,
            "wasAffiliated": false,
            "percentageClinical": 51,
            "percentageAdministrative": 49
        }
    ]
}
```