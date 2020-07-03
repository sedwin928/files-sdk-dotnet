using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Files.Models
{
    public class BundleDownload
    {
        private Dictionary<string, object> attributes;
        private Dictionary<string, object> options;
        public BundleDownload()
        {
            this.attributes = new Dictionary<string, object>();
            this.options = new Dictionary<string, object>();

            this.attributes.Add("download_method", null);
            this.attributes.Add("path", null);
            this.attributes.Add("created_at", null);
        }

        public BundleDownload(Dictionary<string, object> attributes, Dictionary<string, object> options)
        {
            this.attributes = attributes;
            this.options = options;
        }

        /// <summary>
        /// Download method (file or full_zip)
        /// </summary>
        [JsonPropertyName("download_method")]
        public string DownloadMethod
        {
            get { return (string) attributes["download_method"]; }
        }

        /// <summary>
        /// Download path This must be slash-delimited, but it must neither start nor end with a slash. Maximum of 5000 characters.
        /// </summary>
        [JsonPropertyName("path")]
        public string Path
        {
            get { return (string) attributes["path"]; }
        }

        /// <summary>
        /// Download date/time
        /// </summary>
        [JsonPropertyName("created_at")]
        public Nullable<DateTime> CreatedAt
        {
            get { return (Nullable<DateTime>) attributes["created_at"]; }
        }



        /// <summary>
        /// Parameters:
        ///   page - int64 - Current page number.
        ///   per_page - int64 - Number of records to show per page.  (Max: 10,000, 1,000 or less is recommended).
        ///   action - string - Deprecated: If set to `count` returns a count of matching records rather than the records themselves.
        ///   bundle_registration_id (required) - int64 - BundleRegistration ID
        /// </summary>
        public static async Task<BundleDownload[]> List(
            
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
            if (parameters.ContainsKey("bundle_registration_id") && !(parameters["bundle_registration_id"] is Nullable<Int64> ))
            {
                throw new ArgumentException("Bad parameter: bundle_registration_id must be of type Nullable<Int64>", "parameters[\"bundle_registration_id\"]");
            }
            if (!parameters.ContainsKey("bundle_registration_id") || parameters["bundle_registration_id"] == null)
            {
                throw new ArgumentNullException("Parameter missing: bundle_registration_id", "parameters[\"bundle_registration_id\"]");
            }

            string responseJson = await FilesClient.SendRequest($"/bundle_downloads", System.Net.Http.HttpMethod.Get, parameters, options);

            return JsonSerializer.Deserialize<BundleDownload[]>(responseJson);
        }

        public static async Task<BundleDownload[]> All(
            
            Dictionary<string, object> parameters = null,
            Dictionary<string, object> options = null
        )
        {
            return await List(parameters, options);
        }

    }
}
