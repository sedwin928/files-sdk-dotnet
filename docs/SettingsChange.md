# FilesCom.Models.SettingsChange

## Example SettingsChange Object

```
{
  "changes": [
    "example"
  ],
  "created_at": "2000-01-01T01:00:00Z",
  "user_id": 1,
  "user_is_files_support": true,
  "username": "some_user"
}
```

* `changes` / `Changes`  (string[]): Markdown-formatted change messages.
* `created_at` / `CreatedAt`  (Nullable<DateTime>): The time this change was made
* `user_id` / `UserId`  (Nullable<Int64>): The user id responsible for this change
* `user_is_files_support` / `UserIsFilesSupport`  (bool): true if this change was performed by Files.com support.
* `username` / `Username`  (string): The username of the user responsible for this change


---

## List Settings Changes

```
Task<SettingsChange[]> SettingsChange.List(
    
    Dictionary<string, object> parameters = null,
    Dictionary<string, object> options = null
)
```

### Parameters

* `cursor` (string): Used for pagination.  When a list request has more records available, cursors are provided in the response headers `X-Files-Cursor-Next` and `X-Files-Cursor-Prev`.  Send one of those cursor value here to resume an existing list from the next available record.  Note: many of our SDKs have iterator methods that will automatically handle cursor-based pagination.
* `per_page` (Nullable<Int64>): Number of records to show per page.  (Max: 10,000, 1,000 or less is recommended).
* `sort_by` (object): If set, sort records by the specified field in either `asc` or `desc` direction (e.g. `sort_by[api_key_id]=desc`). Valid fields are `api_key_id`, `created_at` or `user_id`.
* `api_key_id` (string): If set, return records where the specified field is equal to the supplied value.
* `user_id` (string): If set, return records where the specified field is equal to the supplied value.
* `filter` (object): If set, return records where the specified field is equal to the supplied value. Valid fields are `api_key_id` and `user_id`.
