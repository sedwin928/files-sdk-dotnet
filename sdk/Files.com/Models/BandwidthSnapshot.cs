using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Files.Models
{
    public class BandwidthSnapshot
    {
        private Dictionary<string, object> attributes;
        private Dictionary<string, object> options;
        public BandwidthSnapshot() : this(null, null) { }

        public BandwidthSnapshot(Dictionary<string, object> attributes, Dictionary<string, object> options)
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
            if (!this.attributes.ContainsKey("bytes_received"))
            {
                this.attributes.Add("bytes_received", null);
            }
            if (!this.attributes.ContainsKey("bytes_sent"))
            {
                this.attributes.Add("bytes_sent", null);
            }
            if (!this.attributes.ContainsKey("requests_get"))
            {
                this.attributes.Add("requests_get", null);
            }
            if (!this.attributes.ContainsKey("requests_put"))
            {
                this.attributes.Add("requests_put", null);
            }
            if (!this.attributes.ContainsKey("requests_other"))
            {
                this.attributes.Add("requests_other", null);
            }
            if (!this.attributes.ContainsKey("logged_at"))
            {
                this.attributes.Add("logged_at", null);
            }
            if (!this.attributes.ContainsKey("created_at"))
            {
                this.attributes.Add("created_at", null);
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
        /// Site bandwidth ID
        /// </summary>
        [JsonPropertyName("id")]
        public Nullable<Int64> Id
        {
            get { return (Nullable<Int64>) attributes["id"]; }
        }

        /// <summary>
        /// Site bandwidth report bytes received
        /// </summary>
        [JsonPropertyName("bytes_received")]
        public double BytesReceived
        {
            get { return (double) attributes["bytes_received"]; }
        }

        /// <summary>
        /// Site bandwidth report bytes sent
        /// </summary>
        [JsonPropertyName("bytes_sent")]
        public double BytesSent
        {
            get { return (double) attributes["bytes_sent"]; }
        }

        /// <summary>
        /// Site bandwidth report get requests
        /// </summary>
        [JsonPropertyName("requests_get")]
        public double RequestsGet
        {
            get { return (double) attributes["requests_get"]; }
        }

        /// <summary>
        /// Site bandwidth report put requests
        /// </summary>
        [JsonPropertyName("requests_put")]
        public double RequestsPut
        {
            get { return (double) attributes["requests_put"]; }
        }

        /// <summary>
        /// Site bandwidth report other requests
        /// </summary>
        [JsonPropertyName("requests_other")]
        public double RequestsOther
        {
            get { return (double) attributes["requests_other"]; }
        }

        /// <summary>
        /// Time the site bandwidth report was logged
        /// </summary>
        [JsonPropertyName("logged_at")]
        public Nullable<DateTime> LoggedAt
        {
            get { return (Nullable<DateTime>) attributes["logged_at"]; }
        }

        /// <summary>
        /// Site bandwidth report created at date/time
        /// </summary>
        [JsonPropertyName("created_at")]
        public Nullable<DateTime> CreatedAt
        {
            get { return (Nullable<DateTime>) attributes["created_at"]; }
        }

        /// <summary>
        /// The last time this site bandwidth report was updated
        /// </summary>
        [JsonPropertyName("updated_at")]
        public Nullable<DateTime> UpdatedAt
        {
            get { return (Nullable<DateTime>) attributes["updated_at"]; }
        }



        /// <summary>
        /// Parameters:
        ///   page - int64 - Current page number.
        ///   per_page - int64 - Number of records to show per page.  (Max: 10,000, 1,000 or less is recommended).
        ///   action - string - Deprecated: If set to `count` returns a count of matching records rather than the records themselves.
        /// </summary>
        public static async Task<BandwidthSnapshot[]> List(
            
            Dictionary<string, object> parameters = null,
            Dictionary<string, object> options = null
        )
        {
            parameters = parameters != null ? parameters : new Dictionary<string, object>();
            options = options != null ? options : new Dictionary<string, object>();

            if (parameters.ContainsKey("page") && !(parameters["page"] is Nullable<Int64> ))
            {
                throw new ArgumentException("Bad parameter: page must be of type Nullable<Int64>", "parameters[\"page\"]");
            }
            if (parameters.ContainsKey("per_page") && !(parameters["per_page"] is Nullable<Int64> ))
            {
                throw new ArgumentException("Bad parameter: per_page must be of type Nullable<Int64>", "parameters[\"per_page\"]");
            }
            if (parameters.ContainsKey("action") && !(parameters["action"] is string ))
            {
                throw new ArgumentException("Bad parameter: action must be of type string", "parameters[\"action\"]");
            }

            string responseJson = await FilesClient.SendRequest($"/bandwidth_snapshots", System.Net.Http.HttpMethod.Get, parameters, options);

            return JsonSerializer.Deserialize<BandwidthSnapshot[]>(responseJson);
        }

        public static async Task<BandwidthSnapshot[]> All(
            
            Dictionary<string, object> parameters = null,
            Dictionary<string, object> options = null
        )
        {
            return await List(parameters, options);
        }

    }
}
