using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace FilesCom.Models
{
    public class Automation
    {
        private Dictionary<string, object> attributes;
        private Dictionary<string, object> options;
        public Automation() : this(null, null) { }

        public Automation(Dictionary<string, object> attributes, Dictionary<string, object> options)
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
            if (!this.attributes.ContainsKey("automation"))
            {
                this.attributes.Add("automation", null);
            }
            if (!this.attributes.ContainsKey("deleted"))
            {
                this.attributes.Add("deleted", null);
            }
            if (!this.attributes.ContainsKey("disabled"))
            {
                this.attributes.Add("disabled", null);
            }
            if (!this.attributes.ContainsKey("trigger"))
            {
                this.attributes.Add("trigger", null);
            }
            if (!this.attributes.ContainsKey("interval"))
            {
                this.attributes.Add("interval", null);
            }
            if (!this.attributes.ContainsKey("last_modified_at"))
            {
                this.attributes.Add("last_modified_at", null);
            }
            if (!this.attributes.ContainsKey("name"))
            {
                this.attributes.Add("name", null);
            }
            if (!this.attributes.ContainsKey("schedule"))
            {
                this.attributes.Add("schedule", null);
            }
            if (!this.attributes.ContainsKey("source"))
            {
                this.attributes.Add("source", null);
            }
            if (!this.attributes.ContainsKey("destinations"))
            {
                this.attributes.Add("destinations", new string[0]);
            }
            if (!this.attributes.ContainsKey("destination_replace_from"))
            {
                this.attributes.Add("destination_replace_from", null);
            }
            if (!this.attributes.ContainsKey("destination_replace_to"))
            {
                this.attributes.Add("destination_replace_to", null);
            }
            if (!this.attributes.ContainsKey("description"))
            {
                this.attributes.Add("description", null);
            }
            if (!this.attributes.ContainsKey("recurring_day"))
            {
                this.attributes.Add("recurring_day", null);
            }
            if (!this.attributes.ContainsKey("path"))
            {
                this.attributes.Add("path", null);
            }
            if (!this.attributes.ContainsKey("user_id"))
            {
                this.attributes.Add("user_id", null);
            }
            if (!this.attributes.ContainsKey("sync_ids"))
            {
                this.attributes.Add("sync_ids", new Nullable<Int64>[0]);
            }
            if (!this.attributes.ContainsKey("user_ids"))
            {
                this.attributes.Add("user_ids", new Nullable<Int64>[0]);
            }
            if (!this.attributes.ContainsKey("group_ids"))
            {
                this.attributes.Add("group_ids", new Nullable<Int64>[0]);
            }
            if (!this.attributes.ContainsKey("webhook_url"))
            {
                this.attributes.Add("webhook_url", null);
            }
            if (!this.attributes.ContainsKey("trigger_actions"))
            {
                this.attributes.Add("trigger_actions", new string[0]);
            }
            if (!this.attributes.ContainsKey("value"))
            {
                this.attributes.Add("value", null);
            }
            if (!this.attributes.ContainsKey("destination"))
            {
                this.attributes.Add("destination", null);
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
        /// Automation ID
        /// </summary>
        [JsonPropertyName("id")]
        public Nullable<Int64> Id
        {
            get { return (Nullable<Int64>)attributes["id"]; }
            set { attributes["id"] = value; }
        }

        /// <summary>
        /// Automation type
        /// </summary>
        [JsonPropertyName("automation")]
        public string AutomationType
        {
            get { return (string)attributes["automation"]; }
            set { attributes["automation"] = value; }
        }

        /// <summary>
        /// Indicates if the automation has been deleted.
        /// </summary>
        [JsonPropertyName("deleted")]
        public bool Deleted
        {
            get { return (bool)attributes["deleted"]; }
            set { attributes["deleted"] = value; }
        }

        /// <summary>
        /// If true, this automation will not run.
        /// </summary>
        [JsonPropertyName("disabled")]
        public bool Disabled
        {
            get { return (bool)attributes["disabled"]; }
            set { attributes["disabled"] = value; }
        }

        /// <summary>
        /// How this automation is triggered to run. One of: `realtime`, `daily`, `custom_schedule`, `webhook`, `email`, or `action`.
        /// </summary>
        [JsonPropertyName("trigger")]
        public string Trigger
        {
            get { return (string)attributes["trigger"]; }
            set { attributes["trigger"] = value; }
        }

        /// <summary>
        /// If trigger is `daily`, this specifies how often to run this automation.  One of: `day`, `week`, `week_end`, `month`, `month_end`, `quarter`, `quarter_end`, `year`, `year_end`
        /// </summary>
        [JsonPropertyName("interval")]
        public string Interval
        {
            get { return (string)attributes["interval"]; }
            set { attributes["interval"] = value; }
        }

        /// <summary>
        /// Time when automation was last modified. Does not change for name or description updates.
        /// </summary>
        [JsonPropertyName("last_modified_at")]
        public Nullable<DateTime> LastModifiedAt
        {
            get { return (Nullable<DateTime>)attributes["last_modified_at"]; }
            set { attributes["last_modified_at"] = value; }
        }

        /// <summary>
        /// Name for this automation.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name
        {
            get { return (string)attributes["name"]; }
            set { attributes["name"] = value; }
        }

        /// <summary>
        /// If trigger is `custom_schedule`, Custom schedule description for when the automation should be run.
        /// </summary>
        [JsonPropertyName("schedule")]
        public object Schedule
        {
            get { return (object)attributes["schedule"]; }
            set { attributes["schedule"] = value; }
        }

        /// <summary>
        /// Source Path
        /// </summary>
        [JsonPropertyName("source")]
        public string Source
        {
            get { return (string)attributes["source"]; }
            set { attributes["source"] = value; }
        }

        /// <summary>
        /// Destination Path
        /// </summary>
        [JsonPropertyName("destinations")]
        public string[] Destinations
        {
            get { return (string[])attributes["destinations"]; }
            set { attributes["destinations"] = value; }
        }

        /// <summary>
        /// If set, this string in the destination path will be replaced with the value in `destination_replace_to`.
        /// </summary>
        [JsonPropertyName("destination_replace_from")]
        public string DestinationReplaceFrom
        {
            get { return (string)attributes["destination_replace_from"]; }
            set { attributes["destination_replace_from"] = value; }
        }

        /// <summary>
        /// If set, this string will replace the value `destination_replace_from` in the destination filename. You can use special patterns here.
        /// </summary>
        [JsonPropertyName("destination_replace_to")]
        public string DestinationReplaceTo
        {
            get { return (string)attributes["destination_replace_to"]; }
            set { attributes["destination_replace_to"] = value; }
        }

        /// <summary>
        /// Description for the this Automation.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description
        {
            get { return (string)attributes["description"]; }
            set { attributes["description"] = value; }
        }

        /// <summary>
        /// If trigger type is `daily`, this specifies a day number to run in one of the supported intervals: `week`, `month`, `quarter`, `year`.
        /// </summary>
        [JsonPropertyName("recurring_day")]
        public Nullable<Int64> RecurringDay
        {
            get { return (Nullable<Int64>)attributes["recurring_day"]; }
            set { attributes["recurring_day"] = value; }
        }

        /// <summary>
        /// Path on which this Automation runs.  Supports globs. This must be slash-delimited, but it must neither start nor end with a slash. Maximum of 5000 characters.
        /// </summary>
        [JsonPropertyName("path")]
        public string Path
        {
            get { return (string)attributes["path"]; }
            set { attributes["path"] = value; }
        }

        /// <summary>
        /// User ID of the Automation's creator.
        /// </summary>
        [JsonPropertyName("user_id")]
        public Nullable<Int64> UserId
        {
            get { return (Nullable<Int64>)attributes["user_id"]; }
            set { attributes["user_id"] = value; }
        }

        /// <summary>
        /// IDs of remote sync folder behaviors to run by this Automation
        /// </summary>
        [JsonPropertyName("sync_ids")]
        public Nullable<Int64>[] SyncIds
        {
            get { return (Nullable<Int64>[])attributes["sync_ids"]; }
            set { attributes["sync_ids"] = value; }
        }

        /// <summary>
        /// IDs of Users for the Automation (i.e. who to Request File from)
        /// </summary>
        [JsonPropertyName("user_ids")]
        public Nullable<Int64>[] UserIds
        {
            get { return (Nullable<Int64>[])attributes["user_ids"]; }
            set { attributes["user_ids"] = value; }
        }

        /// <summary>
        /// IDs of Groups for the Automation (i.e. who to Request File from)
        /// </summary>
        [JsonPropertyName("group_ids")]
        public Nullable<Int64>[] GroupIds
        {
            get { return (Nullable<Int64>[])attributes["group_ids"]; }
            set { attributes["group_ids"] = value; }
        }

        /// <summary>
        /// If trigger is `webhook`, this is the URL of the webhook to trigger the Automation.
        /// </summary>
        [JsonPropertyName("webhook_url")]
        public string WebhookUrl
        {
            get { return (string)attributes["webhook_url"]; }
            set { attributes["webhook_url"] = value; }
        }

        /// <summary>
        /// If trigger is `action`, this is the list of action types on which to trigger the automation. Valid actions are create, read, update, destroy, move, copy
        /// </summary>
        [JsonPropertyName("trigger_actions")]
        public string[] TriggerActions
        {
            get { return (string[])attributes["trigger_actions"]; }
            set { attributes["trigger_actions"] = value; }
        }

        /// <summary>
        /// A Hash of attributes specific to the automation type.
        /// </summary>
        [JsonPropertyName("value")]
        public object Value
        {
            get { return (object)attributes["value"]; }
            set { attributes["value"] = value; }
        }

        /// <summary>
        /// DEPRECATED: Destination Path. Use `destinations` instead.
        /// </summary>
        [JsonPropertyName("destination")]
        public string Destination
        {
            get { return (string)attributes["destination"]; }
            set { attributes["destination"] = value; }
        }

        /// <summary>
        /// Parameters:
        ///   source - string - Source Path
        ///   destination - string - DEPRECATED: Destination Path. Use `destinations` instead.
        ///   destinations - array(string) - A list of String destination paths or Hash of folder_path and optional file_path.
        ///   destination_replace_from - string - If set, this string in the destination path will be replaced with the value in `destination_replace_to`.
        ///   destination_replace_to - string - If set, this string will replace the value `destination_replace_from` in the destination filename. You can use special patterns here.
        ///   interval - string - How often to run this automation? One of: `day`, `week`, `week_end`, `month`, `month_end`, `quarter`, `quarter_end`, `year`, `year_end`
        ///   path - string - Path on which this Automation runs.  Supports globs.
        ///   sync_ids - string - A list of sync IDs the automation is associated with. If sent as a string, it should be comma-delimited.
        ///   user_ids - string - A list of user IDs the automation is associated with. If sent as a string, it should be comma-delimited.
        ///   group_ids - string - A list of group IDs the automation is associated with. If sent as a string, it should be comma-delimited.
        ///   schedule - object - Custom schedule for running this automation.
        ///   description - string - Description for the this Automation.
        ///   disabled - boolean - If true, this automation will not run.
        ///   name - string - Name for this automation.
        ///   trigger - string - How this automation is triggered to run. One of: `realtime`, `daily`, `custom_schedule`, `webhook`, `email`, or `action`.
        ///   trigger_actions - array(string) - If trigger is `action`, this is the list of action types on which to trigger the automation. Valid actions are create, read, update, destroy, move, copy
        ///   value - object - A Hash of attributes specific to the automation type.
        ///   recurring_day - int64 - If trigger type is `daily`, this specifies a day number to run in one of the supported intervals: `week`, `month`, `quarter`, `year`.
        ///   automation - string - Automation type
        /// </summary>
        public async Task<Automation> Update(Dictionary<string, object> parameters)
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
            if (parameters.ContainsKey("source") && !(parameters["source"] is string))
            {
                throw new ArgumentException("Bad parameter: source must be of type string", "parameters[\"source\"]");
            }
            if (parameters.ContainsKey("destination") && !(parameters["destination"] is string))
            {
                throw new ArgumentException("Bad parameter: destination must be of type string", "parameters[\"destination\"]");
            }
            if (parameters.ContainsKey("destinations") && !(parameters["destinations"] is string[]))
            {
                throw new ArgumentException("Bad parameter: destinations must be of type string[]", "parameters[\"destinations\"]");
            }
            if (parameters.ContainsKey("destination_replace_from") && !(parameters["destination_replace_from"] is string))
            {
                throw new ArgumentException("Bad parameter: destination_replace_from must be of type string", "parameters[\"destination_replace_from\"]");
            }
            if (parameters.ContainsKey("destination_replace_to") && !(parameters["destination_replace_to"] is string))
            {
                throw new ArgumentException("Bad parameter: destination_replace_to must be of type string", "parameters[\"destination_replace_to\"]");
            }
            if (parameters.ContainsKey("interval") && !(parameters["interval"] is string))
            {
                throw new ArgumentException("Bad parameter: interval must be of type string", "parameters[\"interval\"]");
            }
            if (parameters.ContainsKey("path") && !(parameters["path"] is string))
            {
                throw new ArgumentException("Bad parameter: path must be of type string", "parameters[\"path\"]");
            }
            if (parameters.ContainsKey("sync_ids") && !(parameters["sync_ids"] is string))
            {
                throw new ArgumentException("Bad parameter: sync_ids must be of type string", "parameters[\"sync_ids\"]");
            }
            if (parameters.ContainsKey("user_ids") && !(parameters["user_ids"] is string))
            {
                throw new ArgumentException("Bad parameter: user_ids must be of type string", "parameters[\"user_ids\"]");
            }
            if (parameters.ContainsKey("group_ids") && !(parameters["group_ids"] is string))
            {
                throw new ArgumentException("Bad parameter: group_ids must be of type string", "parameters[\"group_ids\"]");
            }
            if (parameters.ContainsKey("schedule") && !(parameters["schedule"] is object))
            {
                throw new ArgumentException("Bad parameter: schedule must be of type object", "parameters[\"schedule\"]");
            }
            if (parameters.ContainsKey("description") && !(parameters["description"] is string))
            {
                throw new ArgumentException("Bad parameter: description must be of type string", "parameters[\"description\"]");
            }
            if (parameters.ContainsKey("disabled") && !(parameters["disabled"] is bool))
            {
                throw new ArgumentException("Bad parameter: disabled must be of type bool", "parameters[\"disabled\"]");
            }
            if (parameters.ContainsKey("name") && !(parameters["name"] is string))
            {
                throw new ArgumentException("Bad parameter: name must be of type string", "parameters[\"name\"]");
            }
            if (parameters.ContainsKey("trigger") && !(parameters["trigger"] is string))
            {
                throw new ArgumentException("Bad parameter: trigger must be of type string", "parameters[\"trigger\"]");
            }
            if (parameters.ContainsKey("trigger_actions") && !(parameters["trigger_actions"] is string[]))
            {
                throw new ArgumentException("Bad parameter: trigger_actions must be of type string[]", "parameters[\"trigger_actions\"]");
            }
            if (parameters.ContainsKey("value") && !(parameters["value"] is object))
            {
                throw new ArgumentException("Bad parameter: value must be of type object", "parameters[\"value\"]");
            }
            if (parameters.ContainsKey("recurring_day") && !(parameters["recurring_day"] is Nullable<Int64>))
            {
                throw new ArgumentException("Bad parameter: recurring_day must be of type Nullable<Int64>", "parameters[\"recurring_day\"]");
            }
            if (parameters.ContainsKey("automation") && !(parameters["automation"] is string))
            {
                throw new ArgumentException("Bad parameter: automation must be of type string", "parameters[\"automation\"]");
            }
            if (!parameters.ContainsKey("id") || parameters["id"] == null)
            {
                throw new ArgumentNullException("Parameter missing: id", "parameters[\"id\"]");
            }

            string responseJson = await FilesClient.SendRequest($"/automations/{System.Uri.EscapeDataString(attributes["id"].ToString())}", new HttpMethod("PATCH"), parameters, options);

            return JsonSerializer.Deserialize<Automation>(responseJson);
        }


        /// <summary>
        /// </summary>
        public async Task<Automation> Delete(Dictionary<string, object> parameters)
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

            string responseJson = await FilesClient.SendRequest($"/automations/{System.Uri.EscapeDataString(attributes["id"].ToString())}", System.Net.Http.HttpMethod.Delete, parameters, options);

            return JsonSerializer.Deserialize<Automation>(responseJson);
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
                var newObj = await Automation.Create(this.attributes, this.options);
                this.attributes = newObj.getAttributes();
            }
        }

        /// <summary>
        /// Parameters:
        ///   cursor - string - Used for pagination.  When a list request has more records available, cursors are provided in the response headers `X-Files-Cursor-Next` and `X-Files-Cursor-Prev`.  Send one of those cursor value here to resume an existing list from the next available record.  Note: many of our SDKs have iterator methods that will automatically handle cursor-based pagination.
        ///   per_page - int64 - Number of records to show per page.  (Max: 10,000, 1,000 or less is recommended).
        ///   sort_by - object - If set, sort records by the specified field in either `asc` or `desc` direction (e.g. `sort_by[automation]=desc`). Valid fields are `automation`, `disabled`, `last_modified_at` or `name`.
        ///   automation - string - If set, return records where the specified field is equal to the supplied value.
        ///   filter - object - If set, return records where the specified field is equal to the supplied value. Valid fields are `disabled`, `last_modified_at` or `automation`. Valid field combinations are `[ automation, disabled ]` and `[ disabled, automation ]`.
        ///   filter_gt - object - If set, return records where the specified field is greater than the supplied value. Valid fields are `last_modified_at`.
        ///   filter_gteq - object - If set, return records where the specified field is greater than or equal the supplied value. Valid fields are `last_modified_at`.
        ///   filter_lt - object - If set, return records where the specified field is less than the supplied value. Valid fields are `last_modified_at`.
        ///   filter_lteq - object - If set, return records where the specified field is less than or equal the supplied value. Valid fields are `last_modified_at`.
        ///   with_deleted - boolean - Set to true to include deleted automations in the results.
        /// </summary>
        public static async Task<Automation[]> List(

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
            if (parameters.ContainsKey("sort_by") && !(parameters["sort_by"] is object))
            {
                throw new ArgumentException("Bad parameter: sort_by must be of type object", "parameters[\"sort_by\"]");
            }
            if (parameters.ContainsKey("automation") && !(parameters["automation"] is string))
            {
                throw new ArgumentException("Bad parameter: automation must be of type string", "parameters[\"automation\"]");
            }
            if (parameters.ContainsKey("filter") && !(parameters["filter"] is object))
            {
                throw new ArgumentException("Bad parameter: filter must be of type object", "parameters[\"filter\"]");
            }
            if (parameters.ContainsKey("filter_gt") && !(parameters["filter_gt"] is object))
            {
                throw new ArgumentException("Bad parameter: filter_gt must be of type object", "parameters[\"filter_gt\"]");
            }
            if (parameters.ContainsKey("filter_gteq") && !(parameters["filter_gteq"] is object))
            {
                throw new ArgumentException("Bad parameter: filter_gteq must be of type object", "parameters[\"filter_gteq\"]");
            }
            if (parameters.ContainsKey("filter_lt") && !(parameters["filter_lt"] is object))
            {
                throw new ArgumentException("Bad parameter: filter_lt must be of type object", "parameters[\"filter_lt\"]");
            }
            if (parameters.ContainsKey("filter_lteq") && !(parameters["filter_lteq"] is object))
            {
                throw new ArgumentException("Bad parameter: filter_lteq must be of type object", "parameters[\"filter_lteq\"]");
            }
            if (parameters.ContainsKey("with_deleted") && !(parameters["with_deleted"] is bool))
            {
                throw new ArgumentException("Bad parameter: with_deleted must be of type bool", "parameters[\"with_deleted\"]");
            }

            string responseJson = await FilesClient.SendRequest($"/automations", System.Net.Http.HttpMethod.Get, parameters, options);

            return JsonSerializer.Deserialize<Automation[]>(responseJson);
        }

        public static async Task<Automation[]> All(

            Dictionary<string, object> parameters = null,
            Dictionary<string, object> options = null
        )
        {
            return await List(parameters, options);
        }

        /// <summary>
        /// Parameters:
        ///   id (required) - int64 - Automation ID.
        /// </summary>
        public static async Task<Automation> Find(
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

            string responseJson = await FilesClient.SendRequest($"/automations/{System.Uri.EscapeDataString(parameters["id"].ToString())}", System.Net.Http.HttpMethod.Get, parameters, options);

            return JsonSerializer.Deserialize<Automation>(responseJson);
        }

        public static async Task<Automation> Get(
            Nullable<Int64> id,
            Dictionary<string, object> parameters = null,
            Dictionary<string, object> options = null
        )
        {
            return await Find(id, parameters, options);
        }

        /// <summary>
        /// Parameters:
        ///   source - string - Source Path
        ///   destination - string - DEPRECATED: Destination Path. Use `destinations` instead.
        ///   destinations - array(string) - A list of String destination paths or Hash of folder_path and optional file_path.
        ///   destination_replace_from - string - If set, this string in the destination path will be replaced with the value in `destination_replace_to`.
        ///   destination_replace_to - string - If set, this string will replace the value `destination_replace_from` in the destination filename. You can use special patterns here.
        ///   interval - string - How often to run this automation? One of: `day`, `week`, `week_end`, `month`, `month_end`, `quarter`, `quarter_end`, `year`, `year_end`
        ///   path - string - Path on which this Automation runs.  Supports globs.
        ///   sync_ids - string - A list of sync IDs the automation is associated with. If sent as a string, it should be comma-delimited.
        ///   user_ids - string - A list of user IDs the automation is associated with. If sent as a string, it should be comma-delimited.
        ///   group_ids - string - A list of group IDs the automation is associated with. If sent as a string, it should be comma-delimited.
        ///   schedule - object - Custom schedule for running this automation.
        ///   description - string - Description for the this Automation.
        ///   disabled - boolean - If true, this automation will not run.
        ///   name - string - Name for this automation.
        ///   trigger - string - How this automation is triggered to run. One of: `realtime`, `daily`, `custom_schedule`, `webhook`, `email`, or `action`.
        ///   trigger_actions - array(string) - If trigger is `action`, this is the list of action types on which to trigger the automation. Valid actions are create, read, update, destroy, move, copy
        ///   value - object - A Hash of attributes specific to the automation type.
        ///   recurring_day - int64 - If trigger type is `daily`, this specifies a day number to run in one of the supported intervals: `week`, `month`, `quarter`, `year`.
        ///   automation (required) - string - Automation type
        /// </summary>
        public static async Task<Automation> Create(

            Dictionary<string, object> parameters = null,
            Dictionary<string, object> options = null
        )
        {
            parameters = parameters != null ? parameters : new Dictionary<string, object>();
            options = options != null ? options : new Dictionary<string, object>();

            if (parameters.ContainsKey("source") && !(parameters["source"] is string))
            {
                throw new ArgumentException("Bad parameter: source must be of type string", "parameters[\"source\"]");
            }
            if (parameters.ContainsKey("destination") && !(parameters["destination"] is string))
            {
                throw new ArgumentException("Bad parameter: destination must be of type string", "parameters[\"destination\"]");
            }
            if (parameters.ContainsKey("destinations") && !(parameters["destinations"] is string[]))
            {
                throw new ArgumentException("Bad parameter: destinations must be of type string[]", "parameters[\"destinations\"]");
            }
            if (parameters.ContainsKey("destination_replace_from") && !(parameters["destination_replace_from"] is string))
            {
                throw new ArgumentException("Bad parameter: destination_replace_from must be of type string", "parameters[\"destination_replace_from\"]");
            }
            if (parameters.ContainsKey("destination_replace_to") && !(parameters["destination_replace_to"] is string))
            {
                throw new ArgumentException("Bad parameter: destination_replace_to must be of type string", "parameters[\"destination_replace_to\"]");
            }
            if (parameters.ContainsKey("interval") && !(parameters["interval"] is string))
            {
                throw new ArgumentException("Bad parameter: interval must be of type string", "parameters[\"interval\"]");
            }
            if (parameters.ContainsKey("path") && !(parameters["path"] is string))
            {
                throw new ArgumentException("Bad parameter: path must be of type string", "parameters[\"path\"]");
            }
            if (parameters.ContainsKey("sync_ids") && !(parameters["sync_ids"] is string))
            {
                throw new ArgumentException("Bad parameter: sync_ids must be of type string", "parameters[\"sync_ids\"]");
            }
            if (parameters.ContainsKey("user_ids") && !(parameters["user_ids"] is string))
            {
                throw new ArgumentException("Bad parameter: user_ids must be of type string", "parameters[\"user_ids\"]");
            }
            if (parameters.ContainsKey("group_ids") && !(parameters["group_ids"] is string))
            {
                throw new ArgumentException("Bad parameter: group_ids must be of type string", "parameters[\"group_ids\"]");
            }
            if (parameters.ContainsKey("schedule") && !(parameters["schedule"] is object))
            {
                throw new ArgumentException("Bad parameter: schedule must be of type object", "parameters[\"schedule\"]");
            }
            if (parameters.ContainsKey("description") && !(parameters["description"] is string))
            {
                throw new ArgumentException("Bad parameter: description must be of type string", "parameters[\"description\"]");
            }
            if (parameters.ContainsKey("disabled") && !(parameters["disabled"] is bool))
            {
                throw new ArgumentException("Bad parameter: disabled must be of type bool", "parameters[\"disabled\"]");
            }
            if (parameters.ContainsKey("name") && !(parameters["name"] is string))
            {
                throw new ArgumentException("Bad parameter: name must be of type string", "parameters[\"name\"]");
            }
            if (parameters.ContainsKey("trigger") && !(parameters["trigger"] is string))
            {
                throw new ArgumentException("Bad parameter: trigger must be of type string", "parameters[\"trigger\"]");
            }
            if (parameters.ContainsKey("trigger_actions") && !(parameters["trigger_actions"] is string[]))
            {
                throw new ArgumentException("Bad parameter: trigger_actions must be of type string[]", "parameters[\"trigger_actions\"]");
            }
            if (parameters.ContainsKey("value") && !(parameters["value"] is object))
            {
                throw new ArgumentException("Bad parameter: value must be of type object", "parameters[\"value\"]");
            }
            if (parameters.ContainsKey("recurring_day") && !(parameters["recurring_day"] is Nullable<Int64>))
            {
                throw new ArgumentException("Bad parameter: recurring_day must be of type Nullable<Int64>", "parameters[\"recurring_day\"]");
            }
            if (parameters.ContainsKey("automation") && !(parameters["automation"] is string))
            {
                throw new ArgumentException("Bad parameter: automation must be of type string", "parameters[\"automation\"]");
            }
            if (!parameters.ContainsKey("automation") || parameters["automation"] == null)
            {
                throw new ArgumentNullException("Parameter missing: automation", "parameters[\"automation\"]");
            }

            string responseJson = await FilesClient.SendRequest($"/automations", System.Net.Http.HttpMethod.Post, parameters, options);

            return JsonSerializer.Deserialize<Automation>(responseJson);
        }


        /// <summary>
        /// Parameters:
        ///   source - string - Source Path
        ///   destination - string - DEPRECATED: Destination Path. Use `destinations` instead.
        ///   destinations - array(string) - A list of String destination paths or Hash of folder_path and optional file_path.
        ///   destination_replace_from - string - If set, this string in the destination path will be replaced with the value in `destination_replace_to`.
        ///   destination_replace_to - string - If set, this string will replace the value `destination_replace_from` in the destination filename. You can use special patterns here.
        ///   interval - string - How often to run this automation? One of: `day`, `week`, `week_end`, `month`, `month_end`, `quarter`, `quarter_end`, `year`, `year_end`
        ///   path - string - Path on which this Automation runs.  Supports globs.
        ///   sync_ids - string - A list of sync IDs the automation is associated with. If sent as a string, it should be comma-delimited.
        ///   user_ids - string - A list of user IDs the automation is associated with. If sent as a string, it should be comma-delimited.
        ///   group_ids - string - A list of group IDs the automation is associated with. If sent as a string, it should be comma-delimited.
        ///   schedule - object - Custom schedule for running this automation.
        ///   description - string - Description for the this Automation.
        ///   disabled - boolean - If true, this automation will not run.
        ///   name - string - Name for this automation.
        ///   trigger - string - How this automation is triggered to run. One of: `realtime`, `daily`, `custom_schedule`, `webhook`, `email`, or `action`.
        ///   trigger_actions - array(string) - If trigger is `action`, this is the list of action types on which to trigger the automation. Valid actions are create, read, update, destroy, move, copy
        ///   value - object - A Hash of attributes specific to the automation type.
        ///   recurring_day - int64 - If trigger type is `daily`, this specifies a day number to run in one of the supported intervals: `week`, `month`, `quarter`, `year`.
        ///   automation - string - Automation type
        /// </summary>
        public static async Task<Automation> Update(
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
            if (parameters.ContainsKey("source") && !(parameters["source"] is string))
            {
                throw new ArgumentException("Bad parameter: source must be of type string", "parameters[\"source\"]");
            }
            if (parameters.ContainsKey("destination") && !(parameters["destination"] is string))
            {
                throw new ArgumentException("Bad parameter: destination must be of type string", "parameters[\"destination\"]");
            }
            if (parameters.ContainsKey("destinations") && !(parameters["destinations"] is string[]))
            {
                throw new ArgumentException("Bad parameter: destinations must be of type string[]", "parameters[\"destinations\"]");
            }
            if (parameters.ContainsKey("destination_replace_from") && !(parameters["destination_replace_from"] is string))
            {
                throw new ArgumentException("Bad parameter: destination_replace_from must be of type string", "parameters[\"destination_replace_from\"]");
            }
            if (parameters.ContainsKey("destination_replace_to") && !(parameters["destination_replace_to"] is string))
            {
                throw new ArgumentException("Bad parameter: destination_replace_to must be of type string", "parameters[\"destination_replace_to\"]");
            }
            if (parameters.ContainsKey("interval") && !(parameters["interval"] is string))
            {
                throw new ArgumentException("Bad parameter: interval must be of type string", "parameters[\"interval\"]");
            }
            if (parameters.ContainsKey("path") && !(parameters["path"] is string))
            {
                throw new ArgumentException("Bad parameter: path must be of type string", "parameters[\"path\"]");
            }
            if (parameters.ContainsKey("sync_ids") && !(parameters["sync_ids"] is string))
            {
                throw new ArgumentException("Bad parameter: sync_ids must be of type string", "parameters[\"sync_ids\"]");
            }
            if (parameters.ContainsKey("user_ids") && !(parameters["user_ids"] is string))
            {
                throw new ArgumentException("Bad parameter: user_ids must be of type string", "parameters[\"user_ids\"]");
            }
            if (parameters.ContainsKey("group_ids") && !(parameters["group_ids"] is string))
            {
                throw new ArgumentException("Bad parameter: group_ids must be of type string", "parameters[\"group_ids\"]");
            }
            if (parameters.ContainsKey("schedule") && !(parameters["schedule"] is object))
            {
                throw new ArgumentException("Bad parameter: schedule must be of type object", "parameters[\"schedule\"]");
            }
            if (parameters.ContainsKey("description") && !(parameters["description"] is string))
            {
                throw new ArgumentException("Bad parameter: description must be of type string", "parameters[\"description\"]");
            }
            if (parameters.ContainsKey("disabled") && !(parameters["disabled"] is bool))
            {
                throw new ArgumentException("Bad parameter: disabled must be of type bool", "parameters[\"disabled\"]");
            }
            if (parameters.ContainsKey("name") && !(parameters["name"] is string))
            {
                throw new ArgumentException("Bad parameter: name must be of type string", "parameters[\"name\"]");
            }
            if (parameters.ContainsKey("trigger") && !(parameters["trigger"] is string))
            {
                throw new ArgumentException("Bad parameter: trigger must be of type string", "parameters[\"trigger\"]");
            }
            if (parameters.ContainsKey("trigger_actions") && !(parameters["trigger_actions"] is string[]))
            {
                throw new ArgumentException("Bad parameter: trigger_actions must be of type string[]", "parameters[\"trigger_actions\"]");
            }
            if (parameters.ContainsKey("value") && !(parameters["value"] is object))
            {
                throw new ArgumentException("Bad parameter: value must be of type object", "parameters[\"value\"]");
            }
            if (parameters.ContainsKey("recurring_day") && !(parameters["recurring_day"] is Nullable<Int64>))
            {
                throw new ArgumentException("Bad parameter: recurring_day must be of type Nullable<Int64>", "parameters[\"recurring_day\"]");
            }
            if (parameters.ContainsKey("automation") && !(parameters["automation"] is string))
            {
                throw new ArgumentException("Bad parameter: automation must be of type string", "parameters[\"automation\"]");
            }
            if (!parameters.ContainsKey("id") || parameters["id"] == null)
            {
                throw new ArgumentNullException("Parameter missing: id", "parameters[\"id\"]");
            }

            string responseJson = await FilesClient.SendRequest($"/automations/{System.Uri.EscapeDataString(parameters["id"].ToString())}", new HttpMethod("PATCH"), parameters, options);

            return JsonSerializer.Deserialize<Automation>(responseJson);
        }


        /// <summary>
        /// </summary>
        public static async Task<Automation> Delete(
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

            string responseJson = await FilesClient.SendRequest($"/automations/{System.Uri.EscapeDataString(parameters["id"].ToString())}", System.Net.Http.HttpMethod.Delete, parameters, options);

            return JsonSerializer.Deserialize<Automation>(responseJson);
        }

        public static async Task<Automation> Destroy(
            Nullable<Int64> id,
            Dictionary<string, object> parameters = null,
            Dictionary<string, object> options = null
        )
        {
            return await Delete(id, parameters, options);
        }

    }
}