// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Fsmb.Api.FcvsUa.Client.Models.Addendum
{
    /// <summary>
    /// State addendum question.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.22.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class StateAddendumQuestion
    {
        /// <summary>
        /// Question name
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "name", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = false)]
        public System.String Name { get; set; }

        /// <summary>
        /// Answer
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "answer", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.String Answer { get; set; }
    }
}
