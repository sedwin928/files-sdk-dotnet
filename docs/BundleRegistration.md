# Files.Models.BundleRegistration

## Example BundleRegistration Object

```
{
  "code": "abc123",
  "name": "account",
  "company": "Action Verb",
  "email": "john.doe@files.com",
  "inbox_code": "abc123",
  "form_field_set_id": 1,
  "form_field_data": ""
}
```

* `code` / `Code`  (string): Registration cookie code
* `name` / `Name`  (string): Registrant name
* `company` / `Company`  (string): Registrant company name
* `email` / `Email`  (string): Registrant email address
* `inbox_code` / `InboxCode`  (string): InboxRegistration cookie code, if there is an associated InboxRegistration
* `form_field_set_id` / `FormFieldSetId`  (Nullable<Int64>): Id of associated form field set
* `form_field_data` / `FormFieldData`  (string): Data for form field set with form field ids as keys and user data as values