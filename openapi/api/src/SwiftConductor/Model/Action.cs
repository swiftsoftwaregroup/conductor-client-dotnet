/*
 * OpenAPI definition
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: v0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = SwiftConductor.Client.OpenAPIDateConverter;

namespace SwiftConductor.Model
{
    /// <summary>
    /// Action
    /// </summary>
    [DataContract(Name = "Action")]
    public partial class Action : IValidatableObject
    {
        /// <summary>
        /// Defines VarAction
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ActionEnum
        {
            /// <summary>
            /// Enum StartWorkflow for value: start_workflow
            /// </summary>
            [EnumMember(Value = "start_workflow")]
            StartWorkflow = 1,

            /// <summary>
            /// Enum CompleteTask for value: complete_task
            /// </summary>
            [EnumMember(Value = "complete_task")]
            CompleteTask = 2,

            /// <summary>
            /// Enum FailTask for value: fail_task
            /// </summary>
            [EnumMember(Value = "fail_task")]
            FailTask = 3
        }


        /// <summary>
        /// Gets or Sets VarAction
        /// </summary>
        [DataMember(Name = "action", EmitDefaultValue = false)]
        public ActionEnum? VarAction { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Action" /> class.
        /// </summary>
        /// <param name="varAction">varAction.</param>
        /// <param name="startWorkflow">startWorkflow.</param>
        /// <param name="completeTask">completeTask.</param>
        /// <param name="failTask">failTask.</param>
        /// <param name="expandInlineJSON">expandInlineJSON.</param>
        public Action(ActionEnum? varAction = default(ActionEnum?), StartWorkflow startWorkflow = default(StartWorkflow), TaskDetails completeTask = default(TaskDetails), TaskDetails failTask = default(TaskDetails), bool expandInlineJSON = default(bool))
        {
            this.VarAction = varAction;
            this.StartWorkflow = startWorkflow;
            this.CompleteTask = completeTask;
            this.FailTask = failTask;
            this.ExpandInlineJSON = expandInlineJSON;
        }

        /// <summary>
        /// Gets or Sets StartWorkflow
        /// </summary>
        [DataMember(Name = "start_workflow", EmitDefaultValue = false)]
        public StartWorkflow StartWorkflow { get; set; }

        /// <summary>
        /// Gets or Sets CompleteTask
        /// </summary>
        [DataMember(Name = "complete_task", EmitDefaultValue = false)]
        public TaskDetails CompleteTask { get; set; }

        /// <summary>
        /// Gets or Sets FailTask
        /// </summary>
        [DataMember(Name = "fail_task", EmitDefaultValue = false)]
        public TaskDetails FailTask { get; set; }

        /// <summary>
        /// Gets or Sets ExpandInlineJSON
        /// </summary>
        [DataMember(Name = "expandInlineJSON", EmitDefaultValue = true)]
        public bool ExpandInlineJSON { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Action {\n");
            sb.Append("  VarAction: ").Append(VarAction).Append("\n");
            sb.Append("  StartWorkflow: ").Append(StartWorkflow).Append("\n");
            sb.Append("  CompleteTask: ").Append(CompleteTask).Append("\n");
            sb.Append("  FailTask: ").Append(FailTask).Append("\n");
            sb.Append("  ExpandInlineJSON: ").Append(ExpandInlineJSON).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
