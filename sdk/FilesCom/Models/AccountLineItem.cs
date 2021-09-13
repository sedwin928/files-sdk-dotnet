using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace FilesCom.Models
{
    public class AccountLineItem
    {
        private Dictionary<string, object> attributes;
        private Dictionary<string, object> options;
        public AccountLineItem() : this(null, null) { }

        public AccountLineItem(Dictionary<string, object> attributes, Dictionary<string, object> options)
        {
            this.attributes = attributes;
            this.options = options;

            if (this.attributes == null)
            {
                this.attributes = new Dictionary<string, object>();
            }

            if (this.options == null)
            {
                this.options = new Dictionary<string, object>();
            }

            if (!this.attributes.ContainsKey("id"))
            {
                this.attributes.Add("id", null);
            }
            if (!this.attributes.ContainsKey("amount"))
            {
                this.attributes.Add("amount", null);
            }
            if (!this.attributes.ContainsKey("balance"))
            {
                this.attributes.Add("balance", null);
            }
            if (!this.attributes.ContainsKey("created_at"))
            {
                this.attributes.Add("created_at", null);
            }
            if (!this.attributes.ContainsKey("currency"))
            {
                this.attributes.Add("currency", null);
            }
            if (!this.attributes.ContainsKey("download_uri"))
            {
                this.attributes.Add("download_uri", null);
            }
            if (!this.attributes.ContainsKey("invoice_line_items"))
            {
                this.attributes.Add("invoice_line_items", null);
            }
            if (!this.attributes.ContainsKey("method"))
            {
                this.attributes.Add("method", null);
            }
            if (!this.attributes.ContainsKey("payment_line_items"))
            {
                this.attributes.Add("payment_line_items", null);
            }
            if (!this.attributes.ContainsKey("payment_reversed_at"))
            {
                this.attributes.Add("payment_reversed_at", null);
            }
            if (!this.attributes.ContainsKey("payment_type"))
            {
                this.attributes.Add("payment_type", null);
            }
            if (!this.attributes.ContainsKey("site_name"))
            {
                this.attributes.Add("site_name", null);
            }
            if (!this.attributes.ContainsKey("type"))
            {
                this.attributes.Add("type", null);
            }
            if (!this.attributes.ContainsKey("updated_at"))
            {
                this.attributes.Add("updated_at", null);
            }
        }

        public Dictionary<string, object> getAttributes()
        {
            return new Dictionary<string, object>(this.attributes);
        }

        public object GetOption(string name)
        {
            return (this.options.ContainsKey(name) ? this.options[name] : null);
        }

        public void SetOption(string name, object value)
        {
            this.options[name] = value;
        }


        /// <summary>
        /// Line item Id
        /// </summary>
        [JsonPropertyName("id")]
        public Nullable<Int64> Id
        {
            
            get;
            set;
        }

        /// <summary>
        /// Line item amount
        /// </summary>
        [JsonPropertyName("amount")]
        public double Amount
        {
            
            get;
            set;
        }

        /// <summary>
        /// Line item balance
        /// </summary>
        [JsonPropertyName("balance")]
        public double Balance
        {
            
            get;
            set;
        }

        /// <summary>
        /// Line item created at
        /// </summary>
        [JsonPropertyName("created_at")]
        public Nullable<DateTime> CreatedAt
        {
            
            get;
            set;
        }

        /// <summary>
        /// Line item currency
        /// </summary>
        [JsonPropertyName("currency")]
        public string Currency
        {
            
            get;
            set;
        }

        /// <summary>
        /// Line item download uri
        /// </summary>
        [JsonPropertyName("download_uri")]
        public string DownloadUri
        {
            
            get;
            set;
        }

        /// <summary>
        /// Associated invoice line items
        /// </summary>
        [JsonPropertyName("invoice_line_items")]
        public object InvoiceLineItems
        {
            
            get;
            set;
        }

        /// <summary>
        /// Line item payment method
        /// </summary>
        [JsonPropertyName("method")]
        public string Method
        {
            
            get;
            set;
        }

        /// <summary>
        /// Associated payment line items
        /// </summary>
        [JsonPropertyName("payment_line_items")]
        public object PaymentLineItems
        {
            
            get;
            set;
        }

        /// <summary>
        /// Date/time payment was reversed if applicable
        /// </summary>
        [JsonPropertyName("payment_reversed_at")]
        public Nullable<DateTime> PaymentReversedAt
        {
            
            get;
            set;
        }

        /// <summary>
        /// Type of payment if applicable
        /// </summary>
        [JsonPropertyName("payment_type")]
        public string PaymentType
        {
            
            get;
            set;
        }

        /// <summary>
        /// Site name this line item is for
        /// </summary>
        [JsonPropertyName("site_name")]
        public string SiteName
        {
            
            get;
            set;
        }

        /// <summary>
        /// Type of line item, either payment or invoice
        /// </summary>
        [JsonPropertyName("type")]
        public string Type
        {
            
            get;
            set;
        }

        /// <summary>
        /// Line item updated at
        /// </summary>
        [JsonPropertyName("updated_at")]
        public Nullable<DateTime> UpdatedAt
        {
            
            get;
            set;
        }



    }
}

