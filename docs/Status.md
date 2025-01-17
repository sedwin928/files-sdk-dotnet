# FilesCom.Models.Status

## Example Status Object

```
{
  "code": 200,
  "message": "example",
  "status": "",
  "data": "example",
  "errors": [
    null
  ],
  "clickwrap_id": 1,
  "clickwrap_body": "example"
}
```

* `code` / `Code`  (Nullable<Int64>): Status HTTP code
* `message` / `Message`  (string): Error message
* `status` / `StatusType`  (string): Status message
* `data` / `Data`  (Auto): Additional data
* `errors` / `Errors`  (string[]): A list of api errors
* `clickwrap_id` / `ClickwrapId`  (Nullable<Int64>): Required Clickwrap id
* `clickwrap_body` / `ClickwrapBody`  (string): Required Clickwrap body
