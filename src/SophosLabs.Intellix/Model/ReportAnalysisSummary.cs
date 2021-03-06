/* 
 * Static File Analysis API
 *
 * Use this easy service to understand the characteristics of the file your application or service is interacting with. Allowing you to block malware including those in files previously unseen. Helping you avoid zero day attacks.  SophosLabs Intelix passes each submitted file through an array of granular threat detection analyzers composed  of threat deterministic and machine learning models to derive a threat verdict and an intelligence report. Examples of analysis include:  File genetic similarity intersection machine learning analysis, suspicious file attributes machine learning identification, Deep Anti-Virus scanning, industry detection coverage, and a lot more.  The results are available in JSON format, for easy parsing with any programming language, as well as a visually appealing HTML report, ideal for human reading.  You can read more about [SophosLabs Intelix APIs here](/doc/index.html).  #### Billing  You are billed for getting a report. This might happen in the following ways:  * You request a report by file hash. You are billed if SophosLabs can provide you a report. * You submit a file for analysis. You are billed for the submission (pre-paying for the report). You get a job id for the submission.  NOTE: Requests for a report by job id are not billed when the report is provided, as you have already paid at file submit. 
 *
 * OpenAPI spec version: 1.1.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = SophosLabs.Intellix.Client.SwaggerDateConverter;

namespace SophosLabs.Intellix.Model
{
    /// <summary>
    /// ReportAnalysisSummary
    /// </summary>
    [DataContract]
        public partial class ReportAnalysisSummary :  IEquatable<ReportAnalysisSummary>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReportAnalysisSummary" /> class.
        /// </summary>
        /// <param name="name">Name of the rule that matched (required).</param>
        /// <param name="description">Default human readable description in English (required).</param>
        /// <param name="severity">How malicious like this behavior is (0:Clean, 1:Unknown, 2:Suspicious, 3:Malicious)  (required).</param>
        public ReportAnalysisSummary(string name = default(string), string description = default(string), int? severity = default(int?))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for ReportAnalysisSummary and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            // to ensure "description" is required (not null)
            if (description == null)
            {
                throw new InvalidDataException("description is a required property for ReportAnalysisSummary and cannot be null");
            }
            else
            {
                this.Description = description;
            }
            // to ensure "severity" is required (not null)
            if (severity == null)
            {
                throw new InvalidDataException("severity is a required property for ReportAnalysisSummary and cannot be null");
            }
            else
            {
                this.Severity = severity;
            }
        }
        
        /// <summary>
        /// Name of the rule that matched
        /// </summary>
        /// <value>Name of the rule that matched</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Default human readable description in English
        /// </summary>
        /// <value>Default human readable description in English</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// How malicious like this behavior is (0:Clean, 1:Unknown, 2:Suspicious, 3:Malicious) 
        /// </summary>
        /// <value>How malicious like this behavior is (0:Clean, 1:Unknown, 2:Suspicious, 3:Malicious) </value>
        [DataMember(Name="severity", EmitDefaultValue=false)]
        public int? Severity { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReportAnalysisSummary {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Severity: ").Append(Severity).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ReportAnalysisSummary);
        }

        /// <summary>
        /// Returns true if ReportAnalysisSummary instances are equal
        /// </summary>
        /// <param name="input">Instance of ReportAnalysisSummary to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReportAnalysisSummary input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Severity == input.Severity ||
                    (this.Severity != null &&
                    this.Severity.Equals(input.Severity))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Severity != null)
                    hashCode = hashCode * 59 + this.Severity.GetHashCode();
                return hashCode;
            }
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
