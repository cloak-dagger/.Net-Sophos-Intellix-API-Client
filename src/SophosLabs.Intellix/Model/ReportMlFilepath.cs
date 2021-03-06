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
    /// ReportMlFilepath
    /// </summary>
    [DataContract]
        public partial class ReportMlFilepath :  IEquatable<ReportMlFilepath>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReportMlFilepath" /> class.
        /// </summary>
        /// <param name="analyses">analyses (required).</param>
        /// <param name="analyzedCounts">analyzedCounts (required).</param>
        /// <param name="overallScores">overallScores (required).</param>
        /// <param name="overallScore">The overall score for the filepath analyses. Currently just a weighted average of the ml_filepath.overall_scores values, heavily weighted in favor of the neighbor_maliciousness score (as this is what&#x27;s shown in the UI and has higher accuracy).  (required).</param>
        public ReportMlFilepath(ReportMlFilepathAnalyses analyses = default(ReportMlFilepathAnalyses), ReportMlFilepathAnalyzedCounts analyzedCounts = default(ReportMlFilepathAnalyzedCounts), ReportMlFilepathOverallScores overallScores = default(ReportMlFilepathOverallScores), decimal? overallScore = default(decimal?))
        {
            // to ensure "analyses" is required (not null)
            if (analyses == null)
            {
                throw new InvalidDataException("analyses is a required property for ReportMlFilepath and cannot be null");
            }
            else
            {
                this.Analyses = analyses;
            }
            // to ensure "analyzedCounts" is required (not null)
            if (analyzedCounts == null)
            {
                throw new InvalidDataException("analyzedCounts is a required property for ReportMlFilepath and cannot be null");
            }
            else
            {
                this.AnalyzedCounts = analyzedCounts;
            }
            // to ensure "overallScores" is required (not null)
            if (overallScores == null)
            {
                throw new InvalidDataException("overallScores is a required property for ReportMlFilepath and cannot be null");
            }
            else
            {
                this.OverallScores = overallScores;
            }
            // to ensure "overallScore" is required (not null)
            if (overallScore == null)
            {
                throw new InvalidDataException("overallScore is a required property for ReportMlFilepath and cannot be null");
            }
            else
            {
                this.OverallScore = overallScore;
            }
        }
        
        /// <summary>
        /// Gets or Sets Analyses
        /// </summary>
        [DataMember(Name="analyses", EmitDefaultValue=false)]
        public ReportMlFilepathAnalyses Analyses { get; set; }

        /// <summary>
        /// Gets or Sets AnalyzedCounts
        /// </summary>
        [DataMember(Name="analyzed_counts", EmitDefaultValue=false)]
        public ReportMlFilepathAnalyzedCounts AnalyzedCounts { get; set; }

        /// <summary>
        /// Gets or Sets OverallScores
        /// </summary>
        [DataMember(Name="overall_scores", EmitDefaultValue=false)]
        public ReportMlFilepathOverallScores OverallScores { get; set; }

        /// <summary>
        /// The overall score for the filepath analyses. Currently just a weighted average of the ml_filepath.overall_scores values, heavily weighted in favor of the neighbor_maliciousness score (as this is what&#x27;s shown in the UI and has higher accuracy). 
        /// </summary>
        /// <value>The overall score for the filepath analyses. Currently just a weighted average of the ml_filepath.overall_scores values, heavily weighted in favor of the neighbor_maliciousness score (as this is what&#x27;s shown in the UI and has higher accuracy). </value>
        [DataMember(Name="overall_score", EmitDefaultValue=false)]
        public decimal? OverallScore { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReportMlFilepath {\n");
            sb.Append("  Analyses: ").Append(Analyses).Append("\n");
            sb.Append("  AnalyzedCounts: ").Append(AnalyzedCounts).Append("\n");
            sb.Append("  OverallScores: ").Append(OverallScores).Append("\n");
            sb.Append("  OverallScore: ").Append(OverallScore).Append("\n");
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
            return this.Equals(input as ReportMlFilepath);
        }

        /// <summary>
        /// Returns true if ReportMlFilepath instances are equal
        /// </summary>
        /// <param name="input">Instance of ReportMlFilepath to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReportMlFilepath input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Analyses == input.Analyses ||
                    (this.Analyses != null &&
                    this.Analyses.Equals(input.Analyses))
                ) && 
                (
                    this.AnalyzedCounts == input.AnalyzedCounts ||
                    (this.AnalyzedCounts != null &&
                    this.AnalyzedCounts.Equals(input.AnalyzedCounts))
                ) && 
                (
                    this.OverallScores == input.OverallScores ||
                    (this.OverallScores != null &&
                    this.OverallScores.Equals(input.OverallScores))
                ) && 
                (
                    this.OverallScore == input.OverallScore ||
                    (this.OverallScore != null &&
                    this.OverallScore.Equals(input.OverallScore))
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
                if (this.Analyses != null)
                    hashCode = hashCode * 59 + this.Analyses.GetHashCode();
                if (this.AnalyzedCounts != null)
                    hashCode = hashCode * 59 + this.AnalyzedCounts.GetHashCode();
                if (this.OverallScores != null)
                    hashCode = hashCode * 59 + this.OverallScores.GetHashCode();
                if (this.OverallScore != null)
                    hashCode = hashCode * 59 + this.OverallScore.GetHashCode();
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
