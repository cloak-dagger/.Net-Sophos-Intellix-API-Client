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
    /// ReportPeAnalysisDigisig
    /// </summary>
    [DataContract]
        public partial class ReportPeAnalysisDigisig :  IEquatable<ReportPeAnalysisDigisig>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReportPeAnalysisDigisig" /> class.
        /// </summary>
        /// <param name="certificateSource">certificateSource (required).</param>
        /// <param name="signer">signer (required).</param>
        /// <param name="timescert">timescert (required).</param>
        /// <param name="verified">verified (required).</param>
        public ReportPeAnalysisDigisig(string certificateSource = default(string), List<ReportPeAnalysisDigisigSigner> signer = default(List<ReportPeAnalysisDigisigSigner>), ReportPeAnalysisDigisigTimescert timescert = default(ReportPeAnalysisDigisigTimescert), string verified = default(string))
        {
            // to ensure "certificateSource" is required (not null)
            if (certificateSource == null)
            {
                throw new InvalidDataException("certificateSource is a required property for ReportPeAnalysisDigisig and cannot be null");
            }
            else
            {
                this.CertificateSource = certificateSource;
            }
            // to ensure "signer" is required (not null)
            if (signer == null)
            {
                throw new InvalidDataException("signer is a required property for ReportPeAnalysisDigisig and cannot be null");
            }
            else
            {
                this.Signer = signer;
            }
            // to ensure "timescert" is required (not null)
            if (timescert == null)
            {
                throw new InvalidDataException("timescert is a required property for ReportPeAnalysisDigisig and cannot be null");
            }
            else
            {
                this.Timescert = timescert;
            }
            // to ensure "verified" is required (not null)
            if (verified == null)
            {
                throw new InvalidDataException("verified is a required property for ReportPeAnalysisDigisig and cannot be null");
            }
            else
            {
                this.Verified = verified;
            }
        }
        
        /// <summary>
        /// Gets or Sets CertificateSource
        /// </summary>
        [DataMember(Name="certificate_source", EmitDefaultValue=false)]
        public string CertificateSource { get; set; }

        /// <summary>
        /// Gets or Sets Signer
        /// </summary>
        [DataMember(Name="signer", EmitDefaultValue=false)]
        public List<ReportPeAnalysisDigisigSigner> Signer { get; set; }

        /// <summary>
        /// Gets or Sets Timescert
        /// </summary>
        [DataMember(Name="timescert", EmitDefaultValue=false)]
        public ReportPeAnalysisDigisigTimescert Timescert { get; set; }

        /// <summary>
        /// Gets or Sets Verified
        /// </summary>
        [DataMember(Name="verified", EmitDefaultValue=false)]
        public string Verified { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReportPeAnalysisDigisig {\n");
            sb.Append("  CertificateSource: ").Append(CertificateSource).Append("\n");
            sb.Append("  Signer: ").Append(Signer).Append("\n");
            sb.Append("  Timescert: ").Append(Timescert).Append("\n");
            sb.Append("  Verified: ").Append(Verified).Append("\n");
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
            return this.Equals(input as ReportPeAnalysisDigisig);
        }

        /// <summary>
        /// Returns true if ReportPeAnalysisDigisig instances are equal
        /// </summary>
        /// <param name="input">Instance of ReportPeAnalysisDigisig to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReportPeAnalysisDigisig input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CertificateSource == input.CertificateSource ||
                    (this.CertificateSource != null &&
                    this.CertificateSource.Equals(input.CertificateSource))
                ) && 
                (
                    this.Signer == input.Signer ||
                    this.Signer != null &&
                    input.Signer != null &&
                    this.Signer.SequenceEqual(input.Signer)
                ) && 
                (
                    this.Timescert == input.Timescert ||
                    (this.Timescert != null &&
                    this.Timescert.Equals(input.Timescert))
                ) && 
                (
                    this.Verified == input.Verified ||
                    (this.Verified != null &&
                    this.Verified.Equals(input.Verified))
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
                if (this.CertificateSource != null)
                    hashCode = hashCode * 59 + this.CertificateSource.GetHashCode();
                if (this.Signer != null)
                    hashCode = hashCode * 59 + this.Signer.GetHashCode();
                if (this.Timescert != null)
                    hashCode = hashCode * 59 + this.Timescert.GetHashCode();
                if (this.Verified != null)
                    hashCode = hashCode * 59 + this.Verified.GetHashCode();
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