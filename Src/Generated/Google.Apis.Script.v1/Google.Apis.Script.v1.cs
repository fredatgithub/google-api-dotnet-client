// Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file except in compliance with
// the License. You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software distributed under the License is distributed on
// an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the License for the
// specific language governing permissions and limitations under the License.

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by google-apis-code-generator 1.5.1
//     C# generator version: 1.16.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

/**
 * \brief
 *   Google Apps Script Execution API Version v1
 *
 * \section ApiInfo API Version Information
 *    <table>
 *      <tr><th>API
 *          <td><a href='https://developers.google.com/apps-script/execution/rest/v1/scripts/run'>Google Apps Script Execution API</a>
 *      <tr><th>API Version<td>v1
 *      <tr><th>API Rev<td>20160801 (578)
 *      <tr><th>API Docs
 *          <td><a href='https://developers.google.com/apps-script/execution/rest/v1/scripts/run'>
 *              https://developers.google.com/apps-script/execution/rest/v1/scripts/run</a>
 *      <tr><th>Discovery Name<td>script
 *    </table>
 *
 * \section ForMoreInfo For More Information
 *
 * The complete API documentation for using Google Apps Script Execution API can be found at
 * <a href='https://developers.google.com/apps-script/execution/rest/v1/scripts/run'>https://developers.google.com/apps-script/execution/rest/v1/scripts/run</a>.
 *
 * For more information about the Google APIs Client Library for .NET, see
 * <a href='https://developers.google.com/api-client-library/dotnet/get_started'>
 * https://developers.google.com/api-client-library/dotnet/get_started</a>
 */

namespace Google.Apis.Script.v1
{
    /// <summary>The Script Service.</summary>
    public class ScriptService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed =
            Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public ScriptService() :
            this(new Google.Apis.Services.BaseClientService.Initializer()) {}

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public ScriptService(Google.Apis.Services.BaseClientService.Initializer initializer)
            : base(initializer)
        {
            scripts = new ScriptsResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features
        {
            get { return new string[0]; }
        }

        /// <summary>Gets the service name.</summary>
        public override string Name
        {
            get { return "script"; }
        }

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri
        {
            get { return "https://script.googleapis.com/"; }
        }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath
        {
            get { return ""; }
        }

        /// <summary>Available OAuth 2.0 scopes for use with the Google Apps Script Execution API.</summary>
        public class Scope
        {
            /// <summary>View and manage your mail</summary>
            public static string MailGoogleCom = "https://mail.google.com/";

            /// <summary>Manage your calendars</summary>
            public static string WwwGoogleComCalendarFeeds = "https://www.google.com/calendar/feeds";

            /// <summary>Manage your contacts</summary>
            public static string WwwGoogleComM8Feeds = "https://www.google.com/m8/feeds";

            /// <summary>View and manage the provisioning of groups on your domain</summary>
            public static string AdminDirectoryGroup = "https://www.googleapis.com/auth/admin.directory.group";

            /// <summary>View and manage the provisioning of users on your domain</summary>
            public static string AdminDirectoryUser = "https://www.googleapis.com/auth/admin.directory.user";

            /// <summary>View and manage the files in your Google Drive</summary>
            public static string Drive = "https://www.googleapis.com/auth/drive";

            /// <summary>View and manage your forms in Google Drive</summary>
            public static string Forms = "https://www.googleapis.com/auth/forms";

            /// <summary>View and manage forms that this application has been installed in</summary>
            public static string FormsCurrentonly = "https://www.googleapis.com/auth/forms.currentonly";

            /// <summary>View and manage your Google Groups</summary>
            public static string Groups = "https://www.googleapis.com/auth/groups";

            /// <summary>View and manage your spreadsheets in Google Drive</summary>
            public static string Spreadsheets = "https://www.googleapis.com/auth/spreadsheets";

            /// <summary>View your email address</summary>
            public static string UserinfoEmail = "https://www.googleapis.com/auth/userinfo.email";

        }



        private readonly ScriptsResource scripts;

        /// <summary>Gets the Scripts resource.</summary>
        public virtual ScriptsResource Scripts
        {
            get { return scripts; }
        }
    }

    ///<summary>A base abstract class for Script requests.</summary>
    public abstract class ScriptBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        ///<summary>Constructs a new ScriptBaseServiceRequest instance.</summary>
        protected ScriptBaseServiceRequest(Google.Apis.Services.IClientService service)
            : base(service)
        {
        }

        /// <summary>V1 error format.</summary>
        [Google.Apis.Util.RequestParameterAttribute("$.xgafv", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string Xgafv { get; set; }

        /// <summary>OAuth access token.</summary>
        [Google.Apis.Util.RequestParameterAttribute("access_token", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string AccessToken { get; set; }

        /// <summary>Data format for response.</summary>
        /// [default: json]
        [Google.Apis.Util.RequestParameterAttribute("alt", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string Alt { get; set; }

        /// <summary>OAuth bearer token.</summary>
        [Google.Apis.Util.RequestParameterAttribute("bearer_token", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string BearerToken { get; set; }

        /// <summary>JSONP</summary>
        [Google.Apis.Util.RequestParameterAttribute("callback", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string Callback { get; set; }

        /// <summary>Selector specifying which fields to include in a partial response.</summary>
        [Google.Apis.Util.RequestParameterAttribute("fields", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string Fields { get; set; }

        /// <summary>API key. Your API key identifies your project and provides you with API access, quota, and reports.
        /// Required unless you provide an OAuth 2.0 token.</summary>
        [Google.Apis.Util.RequestParameterAttribute("key", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string Key { get; set; }

        /// <summary>OAuth 2.0 token for the current user.</summary>
        [Google.Apis.Util.RequestParameterAttribute("oauth_token", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string OauthToken { get; set; }

        /// <summary>Pretty-print response.</summary>
        /// [default: true]
        [Google.Apis.Util.RequestParameterAttribute("pp", Google.Apis.Util.RequestParameterType.Query)]
        public virtual System.Nullable<bool> Pp { get; set; }

        /// <summary>Returns response with indentations and line breaks.</summary>
        /// [default: true]
        [Google.Apis.Util.RequestParameterAttribute("prettyPrint", Google.Apis.Util.RequestParameterType.Query)]
        public virtual System.Nullable<bool> PrettyPrint { get; set; }

        /// <summary>Available to use for quota purposes for server-side applications. Can be any arbitrary string
        /// assigned to a user, but should not exceed 40 characters.</summary>
        [Google.Apis.Util.RequestParameterAttribute("quotaUser", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string QuotaUser { get; set; }

        /// <summary>Legacy upload protocol for media (e.g. "media", "multipart").</summary>
        [Google.Apis.Util.RequestParameterAttribute("uploadType", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string UploadType { get; set; }

        /// <summary>Upload protocol for media (e.g. "raw", "multipart").</summary>
        [Google.Apis.Util.RequestParameterAttribute("upload_protocol", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string UploadProtocol { get; set; }

        /// <summary>Initializes Script parameter list.</summary>
        protected override void InitParameters()
        {
            base.InitParameters();

            RequestParameters.Add(
                "$.xgafv", new Google.Apis.Discovery.Parameter
                {
                    Name = "$.xgafv",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "access_token", new Google.Apis.Discovery.Parameter
                {
                    Name = "access_token",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "alt", new Google.Apis.Discovery.Parameter
                {
                    Name = "alt",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "json",
                    Pattern = null,
                });
            RequestParameters.Add(
                "bearer_token", new Google.Apis.Discovery.Parameter
                {
                    Name = "bearer_token",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "callback", new Google.Apis.Discovery.Parameter
                {
                    Name = "callback",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "fields", new Google.Apis.Discovery.Parameter
                {
                    Name = "fields",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "key", new Google.Apis.Discovery.Parameter
                {
                    Name = "key",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "oauth_token", new Google.Apis.Discovery.Parameter
                {
                    Name = "oauth_token",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "pp", new Google.Apis.Discovery.Parameter
                {
                    Name = "pp",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "true",
                    Pattern = null,
                });
            RequestParameters.Add(
                "prettyPrint", new Google.Apis.Discovery.Parameter
                {
                    Name = "prettyPrint",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "true",
                    Pattern = null,
                });
            RequestParameters.Add(
                "quotaUser", new Google.Apis.Discovery.Parameter
                {
                    Name = "quotaUser",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "uploadType", new Google.Apis.Discovery.Parameter
                {
                    Name = "uploadType",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "upload_protocol", new Google.Apis.Discovery.Parameter
                {
                    Name = "upload_protocol",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
        }
    }

    /// <summary>The "scripts" collection of methods.</summary>
    public class ScriptsResource
    {
        private const string Resource = "scripts";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public ScriptsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;

        }


        /// <summary>Runs a function in an Apps Script project that has been deployed for use with the Apps Script
        /// Execution API. This method requires authorization with an OAuth 2.0 token that includes at least one of the
        /// scopes listed in the [Authentication](#authentication) section; script projects that do not require
        /// authorization cannot be executed through this API. To find the correct scopes to include in the
        /// authentication token, open the project in the script editor, then select **File > Project properties** and
        /// click the **Scopes** tab.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="scriptId">The project key of the script to be executed. To find the project key, open the project in
        /// the script editor, then select **File > Project properties**.</param>
        public virtual RunRequest Run(Google.Apis.Script.v1.Data.ExecutionRequest body, string scriptId)
        {
            return new RunRequest(service, body, scriptId);
        }

        /// <summary>Runs a function in an Apps Script project that has been deployed for use with the Apps Script
        /// Execution API. This method requires authorization with an OAuth 2.0 token that includes at least one of the
        /// scopes listed in the [Authentication](#authentication) section; script projects that do not require
        /// authorization cannot be executed through this API. To find the correct scopes to include in the
        /// authentication token, open the project in the script editor, then select **File > Project properties** and
        /// click the **Scopes** tab.</summary>
        public class RunRequest : ScriptBaseServiceRequest<Google.Apis.Script.v1.Data.Operation>
        {
            /// <summary>Constructs a new Run request.</summary>
            public RunRequest(Google.Apis.Services.IClientService service, Google.Apis.Script.v1.Data.ExecutionRequest body, string scriptId)
                : base(service)
            {
                ScriptId = scriptId;
                Body = body;
                InitParameters();
            }


            /// <summary>The project key of the script to be executed. To find the project key, open the project in the
            /// script editor, then select **File > Project properties**.</summary>
            [Google.Apis.Util.RequestParameterAttribute("scriptId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ScriptId { get; private set; }


            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Script.v1.Data.ExecutionRequest Body { get; set; }

            ///<summary>Returns the body of the request.</summary>
            protected override object GetBody() { return Body; }

            ///<summary>Gets the method name.</summary>
            public override string MethodName
            {
                get { return "run"; }
            }

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod
            {
                get { return "POST"; }
            }

            ///<summary>Gets the REST path.</summary>
            public override string RestPath
            {
                get { return "v1/scripts/{scriptId}:run"; }
            }

            /// <summary>Initializes Run parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "scriptId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "scriptId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }
    }
}

namespace Google.Apis.Script.v1.Data
{    

    /// <summary>An object that provides information about the nature of an error in the Apps Script Execution API. If
    /// an `run` call succeeds but the script function (or Apps Script itself) throws an exception, the response body's
    /// `error` field will contain a `Status` object. The `Status` object's `details` field will contain an array with a
    /// single one of these `ExecutionError` objects.</summary>
    public class ExecutionError : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The error message thrown by Apps Script, usually localized into the user's language.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errorMessage")]
        public virtual string ErrorMessage { get; set; } 

        /// <summary>The error type, for example `TypeError` or `ReferenceError`. If the error type is unavailable, this
        /// field is not included.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errorType")]
        public virtual string ErrorType { get; set; } 

        /// <summary>An array of objects that provide a stack trace through the script to show where the execution
        /// failed, with the deepest call first.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scriptStackTraceElements")]
        public virtual System.Collections.Generic.IList<ScriptStackTraceElement> ScriptStackTraceElements { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A request to run the function in a script. The script is identified by the specified `script_id`.
    /// Executing a function on a script will return results based on the implementation of the script.</summary>
    public class ExecutionRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>If `true` and the user is an owner of the script, the script runs at the most recently saved
        /// version rather than the version deployed for use with the Execution API. Optional; default is
        /// `false`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("devMode")]
        public virtual System.Nullable<bool> DevMode { get; set; } 

        /// <summary>The name of the function to execute in the given script. The name does not include parentheses or
        /// parameters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("function")]
        public virtual string Function { get; set; } 

        /// <summary>The parameters to be passed to the function being executed. The type for each parameter should
        /// match the expected type in Apps Script. Parameters cannot be Apps Script-specific objects (such as a
        /// `Document` or `Calendar`); they can only be primitive types such as a `string`, `number`, `array`, `object`,
        /// or `boolean`. Optional.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parameters")]
        public virtual System.Collections.Generic.IList<object> Parameters { get; set; } 

        /// <summary>This field is not used.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sessionState")]
        public virtual string SessionState { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>An object that provides the return value of a function executed through the Apps Script Execution API.
    /// If an `run` call succeeds and the script function returns successfully, the response body's `response` field
    /// will contain this `ExecutionResponse` object.</summary>
    public class ExecutionResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The return value of the script function. The type will match the type returned in Apps Script.
        /// Functions called through the Execution API cannot return Apps Script-specific objects (such as a `Document`
        /// or `Calendar`); they can only return primitive types such as a `string`, `number`, `array`, `object`, or
        /// `boolean`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("result")]
        public virtual object Result { get; set; } 

        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual string Status { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>The response will not arrive until the function finishes executing. The maximum runtime is listed in
    /// the guide to [limitations in Apps Script](https://developers.google.com/apps-
    /// script/guides/services/quotas#current_limitations). If the script function returns successfully, the `response`
    /// field will contain an `ExecutionResponse` object with the function's return value in the object's `result`
    /// field.
    ///
    /// If the script function (or Apps Script itself) throws an exception, the `error` field will contain a `Status`
    /// object. The `Status` object's `details` field will contain an array with a single `ExecutionError` object that
    /// provides information about the nature of the error.
    ///
    /// If the `run` call itself fails (for example, because of a malformed request or an authorization error), the
    /// method will return an HTTP response code in the 4XX range with a different format for the response body. Client
    /// libraries will automatically convert a 4XX response into an exception class.</summary>
    public class Operation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>This field is not used.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("done")]
        public virtual System.Nullable<bool> Done { get; set; } 

        /// <summary>If a `run` call succeeds but the script function (or Apps Script itself) throws an exception, this
        /// field will contain a `Status` object. The `Status` object's `details` field will contain an array with a
        /// single `ExecutionError` object that provides information about the nature of the error.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("error")]
        public virtual Status Error { get; set; } 

        /// <summary>This field is not used.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual System.Collections.Generic.IDictionary<string,object> Metadata { get; set; } 

        /// <summary>This field is not used.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; } 

        /// <summary>If the script function returns successfully, this field will contain an `ExecutionResponse` object
        /// with the function's return value as the object's `result` field.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("response")]
        public virtual System.Collections.Generic.IDictionary<string,object> Response { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A stack trace through the script that shows where the execution failed.</summary>
    public class ScriptStackTraceElement : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The name of the function that failed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("function")]
        public virtual string Function { get; set; } 

        /// <summary>The line number where the script failed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lineNumber")]
        public virtual System.Nullable<int> LineNumber { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>If a `run` call succeeds but the script function (or Apps Script itself) throws an exception, the
    /// response body's `error` field will contain this `Status` object.</summary>
    public class Status : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The status code, which should be an enum value of google.rpc.Code.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("code")]
        public virtual System.Nullable<int> Code { get; set; } 

        /// <summary>An array that contains a single `ExecutionError` object that provides information about the nature
        /// of the error.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("details")]
        public virtual System.Collections.Generic.IList<System.Collections.Generic.IDictionary<string,object>> Details { get; set; } 

        /// <summary>A developer-facing error message, which should be in English. Any user-facing error message should
        /// be localized and sent in the google.rpc.Status.details field, or localized by the client.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("message")]
        public virtual string Message { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
