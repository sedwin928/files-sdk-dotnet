using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace FilesCom.Models
{
    public class As2Partner
    {
        private Dictionary<string, object> attributes;
        private Dictionary<string, object> options;
        public As2Partner() : this(null, null) { }

        public As2Partner(Dictionary<string, object> attributes, Dictionary<string, object> options)
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
            if (!this.attributes.ContainsKey("as2_station_id"))
            {
                this.attributes.Add("as2_station_id", null);
            }
            if (!this.attributes.ContainsKey("name"))
            {
                this.attributes.Add("name", null);
            }
            if (!this.attributes.ContainsKey("uri"))
            {
                this.attributes.Add("uri", null);
            }
            if (!this.attributes.ContainsKey("server_certificate"))
            {
                this.attributes.Add("server_certificate", null);
            }
            if (!this.attributes.ContainsKey("enable_dedicated_ips"))
            {
                this.attributes.Add("enable_dedicated_ips", null);
            }
            if (!this.attributes.ContainsKey("hex_public_certificate_serial"))
            {
                this.attributes.Add("hex_public_certificate_serial", null);
            }
            if (!this.attributes.ContainsKey("public_certificate_md5"))
            {
                this.attributes.Add("public_certificate_md5", null);
            }
            if (!this.attributes.ContainsKey("public_certificate_subject"))
            {
                this.attributes.Add("public_certificate_subject", null);
            }
            if (!this.attributes.ContainsKey("public_certificate_issuer"))
            {
                this.attributes.Add("public_certificate_issuer", null);
            }
            if (!this.attributes.ContainsKey("public_certificate_serial"))
            {
                this.attributes.Add("public_certificate_serial", null);
            }
            if (!this.attributes.ContainsKey("public_certificate_not_before"))
            {
                this.attributes.Add("public_certificate_not_before", null);
            }
            if (!this.attributes.ContainsKey("public_certificate_not_after"))
            {
                this.attributes.Add("public_certificate_not_after", null);
            }
            if (!this.attributes.ContainsKey("public_certificate"))
            {
                this.attributes.Add("public_certificate", null);
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
        /// Id of the AS2 Partner.
        /// </summary>
        [JsonPropertyName("id")]
        public Nullable<Int64> Id
        {
            get { return (Nullable<Int64>)attributes["id"]; }
            set { attributes["id"] = value; }
        }

        /// <summary>
        /// Id of the AS2 Station associated with this partner.
        /// </summary>
        [JsonPropertyName("as2_station_id")]
        public Nullable<Int64> As2StationId
        {
            get { return (Nullable<Int64>)attributes["as2_station_id"]; }
            set { attributes["as2_station_id"] = value; }
        }

        /// <summary>
        /// The partner's formal AS2 name.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name
        {
            get { return (string)attributes["name"]; }
            set { attributes["name"] = value; }
        }

        /// <summary>
        /// Public URI for sending AS2 message to.
        /// </summary>
        [JsonPropertyName("uri")]
        public string Uri
        {
            get { return (string)attributes["uri"]; }
            set { attributes["uri"] = value; }
        }

        /// <summary>
        /// Remote server certificate security setting
        /// </summary>
        [JsonPropertyName("server_certificate")]
        public string ServerCertificate
        {
            get { return (string)attributes["server_certificate"]; }
            set { attributes["server_certificate"] = value; }
        }

        /// <summary>
        /// `true` if remote server only accepts connections from dedicated IPs
        /// </summary>
        [JsonPropertyName("enable_dedicated_ips")]
        public bool EnableDedicatedIps
        {
            get { return (bool)attributes["enable_dedicated_ips"]; }
            set { attributes["enable_dedicated_ips"] = value; }
        }

        /// <summary>
        /// Serial of public certificate used for message security in hex format.
        /// </summary>
        [JsonPropertyName("hex_public_certificate_serial")]
        public string HexPublicCertificateSerial
        {
            get { return (string)attributes["hex_public_certificate_serial"]; }
            set { attributes["hex_public_certificate_serial"] = value; }
        }

        /// <summary>
        /// MD5 hash of public certificate used for message security.
        /// </summary>
        [JsonPropertyName("public_certificate_md5")]
        public string PublicCertificateMd5
        {
            get { return (string)attributes["public_certificate_md5"]; }
            set { attributes["public_certificate_md5"] = value; }
        }

        /// <summary>
        /// Subject of public certificate used for message security.
        /// </summary>
        [JsonPropertyName("public_certificate_subject")]
        public string PublicCertificateSubject
        {
            get { return (string)attributes["public_certificate_subject"]; }
            set { attributes["public_certificate_subject"] = value; }
        }

        /// <summary>
        /// Issuer of public certificate used for message security.
        /// </summary>
        [JsonPropertyName("public_certificate_issuer")]
        public string PublicCertificateIssuer
        {
            get { return (string)attributes["public_certificate_issuer"]; }
            set { attributes["public_certificate_issuer"] = value; }
        }

        /// <summary>
        /// Serial of public certificate used for message security.
        /// </summary>
        [JsonPropertyName("public_certificate_serial")]
        public string PublicCertificateSerial
        {
            get { return (string)attributes["public_certificate_serial"]; }
            set { attributes["public_certificate_serial"] = value; }
        }

        /// <summary>
        /// Not before value of public certificate used for message security.
        /// </summary>
        [JsonPropertyName("public_certificate_not_before")]
        public string PublicCertificateNotBefore
        {
            get { return (string)attributes["public_certificate_not_before"]; }
            set { attributes["public_certificate_not_before"] = value; }
        }

        /// <summary>
        /// Not after value of public certificate used for message security.
        /// </summary>
        [JsonPropertyName("public_certificate_not_after")]
        public string PublicCertificateNotAfter
        {
            get { return (string)attributes["public_certificate_not_after"]; }
            set { attributes["public_certificate_not_after"] = value; }
        }

        /// <summary>
        /// </summary>
        [JsonPropertyName("public_certificate")]
        public string PublicCertificate
        {
            get { return (string)attributes["public_certificate"]; }
            set { attributes["public_certificate"] = value; }
        }

        /// <summary>
        /// Parameters:
        ///   name - string - AS2 Name
        ///   uri - string - URL base for AS2 responses
        ///   server_certificate - string - Remote server certificate security setting
        ///   public_certificate - string
        ///   enable_dedicated_ips - boolean
        /// </summary>
        public async Task<As2Partner> Update(Dictionary<string, object> parameters)
        {
            parameters = parameters != null ? parameters : new Dictionary<string, object>();
            parameters["id"] = attributes["id"];

            if (!attributes.ContainsKey("id"))
            {
                throw new ArgumentException("Current object doesn't have a id");
            }
            if (parameters.ContainsKey("id") && !(parameters["id"] is Nullable<Int64>))
            {
                throw new ArgumentException("Bad parameter: id must be of type Nullable<Int64>", "parameters[\"id\"]");
            }
            if (parameters.ContainsKey("name") && !(parameters["name"] is string))
            {
                throw new ArgumentException("Bad parameter: name must be of type string", "parameters[\"name\"]");
            }
            if (parameters.ContainsKey("uri") && !(parameters["uri"] is string))
            {
                throw new ArgumentException("Bad parameter: uri must be of type string", "parameters[\"uri\"]");
            }
            if (parameters.ContainsKey("server_certificate") && !(parameters["server_certificate"] is string))
            {
                throw new ArgumentException("Bad parameter: server_certificate must be of type string", "parameters[\"server_certificate\"]");
            }
            if (parameters.ContainsKey("public_certificate") && !(parameters["public_certificate"] is string))
            {
                throw new ArgumentException("Bad parameter: public_certificate must be of type string", "parameters[\"public_certificate\"]");
            }
            if (parameters.ContainsKey("enable_dedicated_ips") && !(parameters["enable_dedicated_ips"] is bool))
            {
                throw new ArgumentException("Bad parameter: enable_dedicated_ips must be of type bool", "parameters[\"enable_dedicated_ips\"]");
            }
            if (!parameters.ContainsKey("id") || parameters["id"] == null)
            {
                throw new ArgumentNullException("Parameter missing: id", "parameters[\"id\"]");
            }

            string responseJson = await FilesClient.SendRequest($"/as2_partners/{System.Uri.EscapeDataString(attributes["id"].ToString())}", new HttpMethod("PATCH"), parameters, options);

            return JsonSerializer.Deserialize<As2Partner>(responseJson);
        }


        /// <summary>
        /// </summary>
        public async Task<As2Partner> Delete(Dictionary<string, object> parameters)
        {
            parameters = parameters != null ? parameters : new Dictionary<string, object>();
            parameters["id"] = attributes["id"];

            if (!attributes.ContainsKey("id"))
            {
                throw new ArgumentException("Current object doesn't have a id");
            }
            if (parameters.ContainsKey("id") && !(parameters["id"] is Nullable<Int64>))
            {
                throw new ArgumentException("Bad parameter: id must be of type Nullable<Int64>", "parameters[\"id\"]");
            }
            if (!parameters.ContainsKey("id") || parameters["id"] == null)
            {
                throw new ArgumentNullException("Parameter missing: id", "parameters[\"id\"]");
            }

            string responseJson = await FilesClient.SendRequest($"/as2_partners/{System.Uri.EscapeDataString(attributes["id"].ToString())}", System.Net.Http.HttpMethod.Delete, parameters, options);

            return JsonSerializer.Deserialize<As2Partner>(responseJson);
        }

        public async void Destroy(Dictionary<string, object> parameters)
        {
            Delete(parameters);
        }


        public async Task Save()
        {
            if (this.attributes["id"] != null)
            {
                await this.Update(this.attributes);
            }
            else
            {
                var newObj = await As2Partner.Create(this.attributes, this.options);
                this.attributes = newObj.getAttributes();
            }
        }

        /// <summary>
        /// Parameters:
        ///   cursor - string - Used for pagination.  When a list request has more records available, cursors are provided in the response headers `X-Files-Cursor-Next` and `X-Files-Cursor-Prev`.  Send one of those cursor value here to resume an existing list from the next available record.  Note: many of our SDKs have iterator methods that will automatically handle cursor-based pagination.
        ///   per_page - int64 - Number of records to show per page.  (Max: 10,000, 1,000 or less is recommended).
        /// </summary>
        public static async Task<As2Partner[]> List(

            Dictionary<string, object> parameters = null,
            Dictionary<string, object> options = null
        )
        {
            parameters = parameters != null ? parameters : new Dictionary<string, object>();
            options = options != null ? options : new Dictionary<string, object>();

            if (parameters.ContainsKey("cursor") && !(parameters["cursor"] is string))
            {
                throw new ArgumentException("Bad parameter: cursor must be of type string", "parameters[\"cursor\"]");
            }
            if (parameters.ContainsKey("per_page") && !(parameters["per_page"] is Nullable<Int64>))
            {
                throw new ArgumentException("Bad parameter: per_page must be of type Nullable<Int64>", "parameters[\"per_page\"]");
            }

            string responseJson = await FilesClient.SendRequest($"/as2_partners", System.Net.Http.HttpMethod.Get, parameters, options);

            return JsonSerializer.Deserialize<As2Partner[]>(responseJson);
        }

        public static async Task<As2Partner[]> All(

            Dictionary<string, object> parameters = null,
            Dictionary<string, object> options = null
        )
        {
            return await List(parameters, options);
        }

        /// <summary>
        /// Parameters:
        ///   id (required) - int64 - As2 Partner ID.
        /// </summary>
        public static async Task<As2Partner> Find(
            Nullable<Int64> id,
            Dictionary<string, object> parameters = null,
            Dictionary<string, object> options = null
        )
        {
            parameters = parameters != null ? parameters : new Dictionary<string, object>();
            options = options != null ? options : new Dictionary<string, object>();

            parameters.Add("id", id);
            if (parameters.ContainsKey("id") && !(parameters["id"] is Nullable<Int64>))
            {
                throw new ArgumentException("Bad parameter: id must be of type Nullable<Int64>", "parameters[\"id\"]");
            }
            if (!parameters.ContainsKey("id") || parameters["id"] == null)
            {
                throw new ArgumentNullException("Parameter missing: id", "parameters[\"id\"]");
            }

            string responseJson = await FilesClient.SendRequest($"/as2_partners/{System.Uri.EscapeDataString(parameters["id"].ToString())}", System.Net.Http.HttpMethod.Get, parameters, options);

            return JsonSerializer.Deserialize<As2Partner>(responseJson);
        }

        public static async Task<As2Partner> Get(
            Nullable<Int64> id,
            Dictionary<string, object> parameters = null,
            Dictionary<string, object> options = null
        )
        {
            return await Find(id, parameters, options);
        }

        /// <summary>
        /// Parameters:
        ///   name (required) - string - AS2 Name
        ///   uri (required) - string - URL base for AS2 responses
        ///   public_certificate (required) - string
        ///   as2_station_id (required) - int64 - Id of As2Station for this partner
        ///   server_certificate - string - Remote server certificate security setting
        ///   enable_dedicated_ips - boolean
        /// </summary>
        public static async Task<As2Partner> Create(

            Dictionary<string, object> parameters = null,
            Dictionary<string, object> options = null
        )
        {
            parameters = parameters != null ? parameters : new Dictionary<string, object>();
            options = options != null ? options : new Dictionary<string, object>();

            if (parameters.ContainsKey("name") && !(parameters["name"] is string))
            {
                throw new ArgumentException("Bad parameter: name must be of type string", "parameters[\"name\"]");
            }
            if (parameters.ContainsKey("uri") && !(parameters["uri"] is string))
            {
                throw new ArgumentException("Bad parameter: uri must be of type string", "parameters[\"uri\"]");
            }
            if (parameters.ContainsKey("public_certificate") && !(parameters["public_certificate"] is string))
            {
                throw new ArgumentException("Bad parameter: public_certificate must be of type string", "parameters[\"public_certificate\"]");
            }
            if (parameters.ContainsKey("as2_station_id") && !(parameters["as2_station_id"] is Nullable<Int64>))
            {
                throw new ArgumentException("Bad parameter: as2_station_id must be of type Nullable<Int64>", "parameters[\"as2_station_id\"]");
            }
            if (parameters.ContainsKey("server_certificate") && !(parameters["server_certificate"] is string))
            {
                throw new ArgumentException("Bad parameter: server_certificate must be of type string", "parameters[\"server_certificate\"]");
            }
            if (parameters.ContainsKey("enable_dedicated_ips") && !(parameters["enable_dedicated_ips"] is bool))
            {
                throw new ArgumentException("Bad parameter: enable_dedicated_ips must be of type bool", "parameters[\"enable_dedicated_ips\"]");
            }
            if (!parameters.ContainsKey("name") || parameters["name"] == null)
            {
                throw new ArgumentNullException("Parameter missing: name", "parameters[\"name\"]");
            }
            if (!parameters.ContainsKey("uri") || parameters["uri"] == null)
            {
                throw new ArgumentNullException("Parameter missing: uri", "parameters[\"uri\"]");
            }
            if (!parameters.ContainsKey("public_certificate") || parameters["public_certificate"] == null)
            {
                throw new ArgumentNullException("Parameter missing: public_certificate", "parameters[\"public_certificate\"]");
            }
            if (!parameters.ContainsKey("as2_station_id") || parameters["as2_station_id"] == null)
            {
                throw new ArgumentNullException("Parameter missing: as2_station_id", "parameters[\"as2_station_id\"]");
            }

            string responseJson = await FilesClient.SendRequest($"/as2_partners", System.Net.Http.HttpMethod.Post, parameters, options);

            return JsonSerializer.Deserialize<As2Partner>(responseJson);
        }


        /// <summary>
        /// Parameters:
        ///   name - string - AS2 Name
        ///   uri - string - URL base for AS2 responses
        ///   server_certificate - string - Remote server certificate security setting
        ///   public_certificate - string
        ///   enable_dedicated_ips - boolean
        /// </summary>
        public static async Task<As2Partner> Update(
            Nullable<Int64> id,
            Dictionary<string, object> parameters = null,
            Dictionary<string, object> options = null
        )
        {
            parameters = parameters != null ? parameters : new Dictionary<string, object>();
            options = options != null ? options : new Dictionary<string, object>();

            parameters.Add("id", id);
            if (parameters.ContainsKey("id") && !(parameters["id"] is Nullable<Int64>))
            {
                throw new ArgumentException("Bad parameter: id must be of type Nullable<Int64>", "parameters[\"id\"]");
            }
            if (parameters.ContainsKey("name") && !(parameters["name"] is string))
            {
                throw new ArgumentException("Bad parameter: name must be of type string", "parameters[\"name\"]");
            }
            if (parameters.ContainsKey("uri") && !(parameters["uri"] is string))
            {
                throw new ArgumentException("Bad parameter: uri must be of type string", "parameters[\"uri\"]");
            }
            if (parameters.ContainsKey("server_certificate") && !(parameters["server_certificate"] is string))
            {
                throw new ArgumentException("Bad parameter: server_certificate must be of type string", "parameters[\"server_certificate\"]");
            }
            if (parameters.ContainsKey("public_certificate") && !(parameters["public_certificate"] is string))
            {
                throw new ArgumentException("Bad parameter: public_certificate must be of type string", "parameters[\"public_certificate\"]");
            }
            if (parameters.ContainsKey("enable_dedicated_ips") && !(parameters["enable_dedicated_ips"] is bool))
            {
                throw new ArgumentException("Bad parameter: enable_dedicated_ips must be of type bool", "parameters[\"enable_dedicated_ips\"]");
            }
            if (!parameters.ContainsKey("id") || parameters["id"] == null)
            {
                throw new ArgumentNullException("Parameter missing: id", "parameters[\"id\"]");
            }

            string responseJson = await FilesClient.SendRequest($"/as2_partners/{System.Uri.EscapeDataString(parameters["id"].ToString())}", new HttpMethod("PATCH"), parameters, options);

            return JsonSerializer.Deserialize<As2Partner>(responseJson);
        }


        /// <summary>
        /// </summary>
        public static async Task<As2Partner> Delete(
            Nullable<Int64> id,
            Dictionary<string, object> parameters = null,
            Dictionary<string, object> options = null
        )
        {
            parameters = parameters != null ? parameters : new Dictionary<string, object>();
            options = options != null ? options : new Dictionary<string, object>();

            parameters.Add("id", id);
            if (parameters.ContainsKey("id") && !(parameters["id"] is Nullable<Int64>))
            {
                throw new ArgumentException("Bad parameter: id must be of type Nullable<Int64>", "parameters[\"id\"]");
            }
            if (!parameters.ContainsKey("id") || parameters["id"] == null)
            {
                throw new ArgumentNullException("Parameter missing: id", "parameters[\"id\"]");
            }

            string responseJson = await FilesClient.SendRequest($"/as2_partners/{System.Uri.EscapeDataString(parameters["id"].ToString())}", System.Net.Http.HttpMethod.Delete, parameters, options);

            return JsonSerializer.Deserialize<As2Partner>(responseJson);
        }

        public static async Task<As2Partner> Destroy(
            Nullable<Int64> id,
            Dictionary<string, object> parameters = null,
            Dictionary<string, object> options = null
        )
        {
            return await Delete(id, parameters, options);
        }

    }
}