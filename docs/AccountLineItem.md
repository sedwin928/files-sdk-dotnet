# FilesCom.Models.AccountLineItem

## Example AccountLineItem Object

```
{
  "id": 1,
  "amount": 1.0,
  "balance": 1.0,
  "created_at": "2000-01-01T01:00:00Z",
  "currency": "USD",
  "download_uri": "https://url...",
  "invoice_line_items": [
    null
  ],
  "method": "paypal",
  "payment_line_items": [
    null
  ],
  "payment_reversed_at": "2000-01-01T01:00:00Z",
  "payment_type": "example",
  "site_name": "My Site",
  "type": "invoice",
  "updated_at": "2000-01-01T01:00:00Z"
}
```

* `id` / `Id`  (Nullable<Int64>): Line item Id
* `amount` / `Amount`  (double): Line item amount
* `balance` / `Balance`  (double): Line item balance
* `created_at` / `CreatedAt`  (Nullable<DateTime>): Line item created at
* `currency` / `Currency`  (string): Line item currency
* `download_uri` / `DownloadUri`  (string): Line item download uri
* `invoice_line_items` / `InvoiceLineItems`  (string[]): Associated invoice line items
* `method` / `Method`  (string): Line item payment method
* `payment_line_items` / `PaymentLineItems`  (string[]): Associated payment line items
* `payment_reversed_at` / `PaymentReversedAt`  (Nullable<DateTime>): Date/time payment was reversed if applicable
* `payment_type` / `PaymentType`  (string): Type of payment if applicable
* `site_name` / `SiteName`  (string): Site name this line item is for
* `type` / `Type`  (string): Type of line item, either payment or invoice
* `updated_at` / `UpdatedAt`  (Nullable<DateTime>): Line item updated at
