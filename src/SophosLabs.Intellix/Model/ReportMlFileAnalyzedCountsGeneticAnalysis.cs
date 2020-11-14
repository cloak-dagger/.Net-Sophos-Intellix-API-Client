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
    /// ReportMlFileAnalyzedCountsGeneticAnalysis
    /// </summary>
    [DataContract]
        public partial class ReportMlFileAnalyzedCountsGeneticAnalysis :  IEquatable<ReportMlFileAnalyzedCountsGeneticAnalysis>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReportMlFileAnalyzedCountsGeneticAnalysis" /> class.
        /// </summary>
        /// <param name="benign">Number of benign files used in this analysis (required).</param>
        /// <param name="malware">Number of malicious files used in this analysis (required).</param>
        public ReportMlFileAnalyzedCountsGeneticAnalysis(int? benign = default(int?), int? malware = default(int?))
        {
            // to ensure "benign" is required (not null)
            if (benign == null)
            {
                throw new InvalidDataException("benign is a required property for ReportMlFileAnalyzedCountsGeneticAnalysis and cannot be null");
            }
            else
            {
                this.Benign = benign;
            }
            // to ensure "malware" is required (not null)
            if (malware == null)
            {
                throw new InvalidDataException("malware is a required property for ReportMlFileAnalyzedCountsGeneticAnalysis and cannot be null");
            }
            else
            {
                this.Malware = malware;
            }
        }
        
        /// <summary>
        /// Number of benign files used in this analysis
        /// </summary>
        /// <value>Number of benign files used in this analysis</value>
        [DataMember(Name="benign", EmitDefaultValue=false)]
        public int? Benign { get; set; }

        /// <summary>
        /// Number of malicious files used in this analysis
        /// </summary>
        /// <value>Number of malicious files used in this analysis</value>
        [DataMember(Name="malware", EmitDefaultValue=false)]
        public int? Malware { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReportMlFileAnalyzedCountsGeneticAnalysis {\n");
            sb.Append("  Benign: ").Append(Benign).Append("\n");
            sb.Append("  Malware: ").Append(Malware).Append("\n");
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
            return this.Equals(input as ReportMlFileAnalyzedCountsGeneticAnalysis);
        }

        /// <summary>
        /// Returns true if ReportMlFileAnalyzedCountsGeneticAnalysis instances are equal
        /// </summary>
        /// <param name="input">Instance of ReportMlFileAnalyzedCountsGeneticAnalysis to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReportMlFileAnalyzedCountsGeneticAnalysis input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Benign == input.Benign ||
                    (this.Benign != null &&
                    this.Benign.Equals(input.Benign))
                ) && 
                (
                    this.Malware == input.Malware ||
                    (this.Malware != null &&
                    this.Malware.Equals(input.Malware))
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
                if (this.Benign != null)
                    hashCode = hashCode * 59 + this.Benign.GetHashCode();
                if (this.Malware != null)
                    hashCode = hashCode * 59 + this.Malware.GetHashCode();
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
