@Webservice
Feature: CreateCase through WebService
	#In order to verify the UM request through webservice
	#As a Automation tester
	#I want to verify the Inpatient and outpatient scenarios

@Webservice
Scenario: Create Case - Outpatient - Hospital Claim
	Given I set up and Create Case Instance for UMcase WebService
	When I fill in all the below resources
	| ResourceType                       | ResourceValue                    |
	| ExternalMemberId                   | 140651                           |
	| ExternalSystemId                   | 2                                |
	| ShouldReturnBrsActions             | true                             |
	| CareTypeDescription                | Elective                         |
	| CareId                             | 1                                |
	| CasePriorityDescription            | Medium                           |
	| CasePriorityId                     | 3                                |
	| CaseSettingDescription             | Outpatient                       |
	| CaseSettingId                      | 2                                |
	| CaseTypeId                         | 1                                |
	| CaseTypeDescription                | Medical/Surgical                 |
	| IsUrgent                           | false                            |
	| PlaceOfServiceId                   | 33                               |
	| PlaceOfServiceDescription          | Custodial Care Facility          |
	| RequesterId                        | 300343434                        |
	| RequesterName                      | Terry Biggs                      |
	| RequesterPhone                     | 8888881212                       |
	| RequesterTypeId                    | 1                                |
	| RequesterTypeDescription           | Web Physician Submission         |
	| ReviewTypeId                       | 2                                |
	| ReviewTypeDescription              | Pre-Authorization                |
	| AuthorizationUnits                 | 008                              |
	| RequestedUnits                     | 50                               |
	| DiagnosisCode                      | 428.1                            |
	| DiagnosisId                        | DiagnosisCodeSet                 |
	| DiagnosissetID                     | ICD9,ICD10                       |
	| DiagnosisDescription               | LEFT HEART FAILURE(ICD9 428.1)   |
	| IsPrimary                          | true                             |
	| ProcedureCode                      | 12001                            |
	| ProcedureCodeSetId                 | ProcedureCodeSet.CPT             |
	| ProcedureDescription               | SMPL RPR SUPFC S/N/AX/G/T 2.5CM/ |
	| RequestingProviderExternalId       | IHMPRAC00012                     |
	| RequestingProviderName             | Reeves, Anthony                  |
	| ProviderAddressExternalId          | IHMPRAC00012                     |
	| ProviderAddressExternalAddressType | 001                              |
	| ProviderAddressStreet              | 1021 CVS Drive                   |
	| ProviderAddressCity                | Flemington                       |
	| ProviderAddressState               | NJ                               |
	| ProviderAddressZip                 | 08822                            |
	| ProviderIsPrimary                  | false                            |
	| ServiceTypeId                      | 33                               |
	| ServiceTypeDescription             | Acupuncture                      |
	| TreatingProviderExternalId         | IHMPRAC00012                     |
	| TreatingProviderName               | Reeves, Anthony                  |
	| ProviderAddressExternalId          | IHMPRAC00012                     |
	| ProviderAddressExternalAddressType | 001                              |
	| ProviderAddressStreet              | 1021 CVS Drive                   |
	| ProviderAddressCity                | Flemington                       |
	| ProviderAddressState               | NJ                               |
	| ProviderAddressZip                 | 08822                            |
	And I verify that UM Case Id is created through response
	#Then I verify the DB with the UM Case created

