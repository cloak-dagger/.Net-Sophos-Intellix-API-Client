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
    /// Summary information of the file. 
    /// </summary>
    [DataContract]
        public partial class AnalysisSubject :  IEquatable<AnalysisSubject>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AnalysisSubject" /> class.
        /// </summary>
        /// <param name="sha1">The sha1 hash of the file.  (required).</param>
        /// <param name="sha256">The SHA256 hash of the file. (required).</param>
        /// <param name="mimeType">The detected type of the file. .</param>
        public AnalysisSubject(string sha1 = default(string), string sha256 = default(string), string mimeType = default(string))
        {
            // to ensure "sha1" is required (not null)
            if (sha1 == null)
            {
                throw new InvalidDataException("sha1 is a required property for AnalysisSubject and cannot be null");
            }
            else
            {
                this.Sha1 = sha1;
            }
            // to ensure "sha256" is required (not null)
            if (sha256 == null)
            {
                throw new InvalidDataException("sha256 is a required property for AnalysisSubject and cannot be null");
            }
            else
            {
                this.Sha256 = sha256;
            }
            this.MimeType = mimeType;
        }
        
        /// <summary>
        /// The sha1 hash of the file. 
        /// </summary>
        /// <value>The sha1 hash of the file. </value>
        [DataMember(Name="sha1", EmitDefaultValue=false)]
        public string Sha1 { get; set; }

        /// <summary>
        /// The SHA256 hash of the file.
        /// </summary>
        /// <value>The SHA256 hash of the file.</value>
        [DataMember(Name="sha256", EmitDefaultValue=false)]
        public string Sha256 { get; set; }

        /// <summary>
        /// The detected type of the file. 
        /// </summary>
        /// <value>The detected type of the file. </value>
        [DataMember(Name="mimeType", EmitDefaultValue=false)]
        public string MimeType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AnalysisSubject {\n");
            sb.Append("  Sha1: ").Append(Sha1).Append("\n");
            sb.Append("  Sha256: ").Append(Sha256).Append("\n");
            sb.Append("  MimeType: ").Append(MimeType).Append("\n");
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
            return this.Equals(input as AnalysisSubject);
        }

        /// <summary>
        /// Returns true if AnalysisSubject instances are equal
        /// </summary>
        /// <param name="input">Instance of AnalysisSubject to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AnalysisSubject input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Sha1 == input.Sha1 ||
                    (this.Sha1 != null &&
                    this.Sha1.Equals(input.Sha1))
                ) && 
                (
                    this.Sha256 == input.Sha256 ||
                    (this.Sha256 != null &&
                    this.Sha256.Equals(input.Sha256))
                ) && 
                (
                    this.MimeType == input.MimeType ||
                    (this.MimeType != null &&
                    this.MimeType.Equals(input.MimeType))
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
                if (this.Sha1 != null)
                    hashCode = hashCode * 59 + this.Sha1.GetHashCode();
                if (this.Sha256 != null)
                    hashCode = hashCode * 59 + this.Sha256.GetHashCode();
                if (this.MimeType != null)
                    hashCode = hashCode * 59 + this.MimeType.GetHashCode();
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