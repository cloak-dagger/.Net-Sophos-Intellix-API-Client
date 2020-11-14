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
using SophosLabs.Intellix.Model;

namespace SophosLabs.Intellix.Model
{
    /// <summary>
    /// Represent an error which happened during the file analysis. 
    /// </summary>
    [DataContract]
        public partial class AnalysisError : GenericResponse,  IEquatable<AnalysisError>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AnalysisError" /> class.
        /// </summary>
        /// <param name="jobStatus">The status of the analysis job.    * **ERROR**: An error happend during the analysis. An error object is provided.  (required).</param>
        /// <param name="report">report (required).</param>
        /// <param name="jobId">The identifier assigned for this analysis job. .</param>
        public AnalysisError(string jobStatus = default(string), AnalysisErrorReport report = default(AnalysisErrorReport), string jobId = default(string), string correlationId = default(string), string requestId = default(string)) : base(correlationId, requestId)
        {
            // to ensure "jobStatus" is required (not null)
            if (jobStatus == null)
            {
                throw new InvalidDataException("jobStatus is a required property for AnalysisError and cannot be null");
            }
            else
            {
                this.JobStatus = jobStatus;
            }
            // to ensure "report" is required (not null)
            if (report == null)
            {
                throw new InvalidDataException("report is a required property for AnalysisError and cannot be null");
            }
            else
            {
                this.Report = report;
            }
            this.JobId = jobId;
        }
        
        /// <summary>
        /// The status of the analysis job.    * **ERROR**: An error happend during the analysis. An error object is provided. 
        /// </summary>
        /// <value>The status of the analysis job.    * **ERROR**: An error happend during the analysis. An error object is provided. </value>
        [DataMember(Name="jobStatus", EmitDefaultValue=false)]
        public string JobStatus { get; set; }

        /// <summary>
        /// Gets or Sets Report
        /// </summary>
        [DataMember(Name="report", EmitDefaultValue=false)]
        public AnalysisErrorReport Report { get; set; }

        /// <summary>
        /// The identifier assigned for this analysis job. 
        /// </summary>
        /// <value>The identifier assigned for this analysis job. </value>
        [DataMember(Name="jobId", EmitDefaultValue=false)]
        public string JobId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AnalysisError {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  JobStatus: ").Append(JobStatus).Append("\n");
            sb.Append("  Report: ").Append(Report).Append("\n");
            sb.Append("  JobId: ").Append(JobId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
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
            return this.Equals(input as AnalysisError);
        }

        /// <summary>
        /// Returns true if AnalysisError instances are equal
        /// </summary>
        /// <param name="input">Instance of AnalysisError to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AnalysisError input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.JobStatus == input.JobStatus ||
                    (this.JobStatus != null &&
                    this.JobStatus.Equals(input.JobStatus))
                ) && base.Equals(input) && 
                (
                    this.Report == input.Report ||
                    (this.Report != null &&
                    this.Report.Equals(input.Report))
                ) && base.Equals(input) && 
                (
                    this.JobId == input.JobId ||
                    (this.JobId != null &&
                    this.JobId.Equals(input.JobId))
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
                int hashCode = base.GetHashCode();
                if (this.JobStatus != null)
                    hashCode = hashCode * 59 + this.JobStatus.GetHashCode();
                if (this.Report != null)
                    hashCode = hashCode * 59 + this.Report.GetHashCode();
                if (this.JobId != null)
                    hashCode = hashCode * 59 + this.JobId.GetHashCode();
                return hashCode;
            }
        }

        ///// <summary>
        ///// To validate all properties of the instance
        ///// </summary>
        ///// <param name="validationContext">Validation context</param>
        ///// <returns>Validation Result</returns>
        //IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        //{
        //    foreach(var x in BaseValidate(validationContext)) yield return x;
        //    yield break;
        //}
    }
}