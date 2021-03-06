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
    /// This section contains the neighbor_maliciousness analysis run on the customer&#x27;s file&#x27;s filepath. There are three components to the output of this analysis, all fairly similar. 
    /// </summary>
    [DataContract]
        public partial class ReportMlFilepathAnalysesNeighborMaliciousness :  IEquatable<ReportMlFilepathAnalysesNeighborMaliciousness>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReportMlFilepathAnalysesNeighborMaliciousness" /> class.
        /// </summary>
        /// <param name="mostSimilarMalware">This section show the 8 closest unique filepaths in our elasticsearch cluster of SXL4 customer filepaths, that are associated with malicious PE files. This is represented by an ordered list of length 8 (most similar filepaths first), where each element in the list contains a dictionary of values representing three pieces of information:    * score - the elasticsearch similarity score in relation to the original customer&#x27;s file.     (The higher the score, the better the match. Should only be used for ordering, as scores     ranges depend on the searched-for-string)   * fs_t - the first-seen time in our SXL4 data, in seconds (UST)   * filepath - the filepath itself  (required).</param>
        /// <param name="mostSimilarBenign">This section is exactly the same as the ml_filepath.analyses.neighbor_maliciousness.most_similar_malware section above, except that the most similar benign filepaths are listed here, instead of malicious ones. To avoid documentation duplication, please view the linked section.  (required).</param>
        /// <param name="mostSimilar">This section is similar to its sisters, but it lists the nearest sixteen most similar filepaths (calibrated in terms of total malware and benign filepath counts). Those may be all malicious, all benign, or some combination of benign and malicious filepaths. This section is structured almost identically to the ml_filepath.analyses.neighbor_maliciousness.most_similar_malware section above, except that an is_malware section is added to each of the dictionary elements, to signify if the filepath is associated with a benign or malicious file in our elasticsearch database:    * score - the elasticsearch similarity score in relation to the original customer&#x27;s file.     (The higher the score, the better the match. Should only be used for ordering, as scores     ranges depend on the searched-for-string)   * fs_t - the first-seen time in our sxl4 data, in seconds (UST)   * filepath - the filepath itself   * is_malware - boolean, if the associated file is malicious or not in our database  (required).</param>
        public ReportMlFilepathAnalysesNeighborMaliciousness(List<ReportMlFilepathAnalysesNeighborMaliciousnessMostSimilarMalware> mostSimilarMalware = default(List<ReportMlFilepathAnalysesNeighborMaliciousnessMostSimilarMalware>), List<ReportMlFilepathAnalysesNeighborMaliciousnessMostSimilarMalware> mostSimilarBenign = default(List<ReportMlFilepathAnalysesNeighborMaliciousnessMostSimilarMalware>), List<ReportMlFilepathAnalysesNeighborMaliciousnessMostSimilar> mostSimilar = default(List<ReportMlFilepathAnalysesNeighborMaliciousnessMostSimilar>))
        {
            // to ensure "mostSimilarMalware" is required (not null)
            if (mostSimilarMalware == null)
            {
                throw new InvalidDataException("mostSimilarMalware is a required property for ReportMlFilepathAnalysesNeighborMaliciousness and cannot be null");
            }
            else
            {
                this.MostSimilarMalware = mostSimilarMalware;
            }
            // to ensure "mostSimilarBenign" is required (not null)
            if (mostSimilarBenign == null)
            {
                throw new InvalidDataException("mostSimilarBenign is a required property for ReportMlFilepathAnalysesNeighborMaliciousness and cannot be null");
            }
            else
            {
                this.MostSimilarBenign = mostSimilarBenign;
            }
            // to ensure "mostSimilar" is required (not null)
            if (mostSimilar == null)
            {
                throw new InvalidDataException("mostSimilar is a required property for ReportMlFilepathAnalysesNeighborMaliciousness and cannot be null");
            }
            else
            {
                this.MostSimilar = mostSimilar;
            }
        }
        
        /// <summary>
        /// This section show the 8 closest unique filepaths in our elasticsearch cluster of SXL4 customer filepaths, that are associated with malicious PE files. This is represented by an ordered list of length 8 (most similar filepaths first), where each element in the list contains a dictionary of values representing three pieces of information:    * score - the elasticsearch similarity score in relation to the original customer&#x27;s file.     (The higher the score, the better the match. Should only be used for ordering, as scores     ranges depend on the searched-for-string)   * fs_t - the first-seen time in our SXL4 data, in seconds (UST)   * filepath - the filepath itself 
        /// </summary>
        /// <value>This section show the 8 closest unique filepaths in our elasticsearch cluster of SXL4 customer filepaths, that are associated with malicious PE files. This is represented by an ordered list of length 8 (most similar filepaths first), where each element in the list contains a dictionary of values representing three pieces of information:    * score - the elasticsearch similarity score in relation to the original customer&#x27;s file.     (The higher the score, the better the match. Should only be used for ordering, as scores     ranges depend on the searched-for-string)   * fs_t - the first-seen time in our SXL4 data, in seconds (UST)   * filepath - the filepath itself </value>
        [DataMember(Name="most_similar_malware", EmitDefaultValue=false)]
        public List<ReportMlFilepathAnalysesNeighborMaliciousnessMostSimilarMalware> MostSimilarMalware { get; set; }

        /// <summary>
        /// This section is exactly the same as the ml_filepath.analyses.neighbor_maliciousness.most_similar_malware section above, except that the most similar benign filepaths are listed here, instead of malicious ones. To avoid documentation duplication, please view the linked section. 
        /// </summary>
        /// <value>This section is exactly the same as the ml_filepath.analyses.neighbor_maliciousness.most_similar_malware section above, except that the most similar benign filepaths are listed here, instead of malicious ones. To avoid documentation duplication, please view the linked section. </value>
        [DataMember(Name="most_similar_benign", EmitDefaultValue=false)]
        public List<ReportMlFilepathAnalysesNeighborMaliciousnessMostSimilarMalware> MostSimilarBenign { get; set; }

        /// <summary>
        /// This section is similar to its sisters, but it lists the nearest sixteen most similar filepaths (calibrated in terms of total malware and benign filepath counts). Those may be all malicious, all benign, or some combination of benign and malicious filepaths. This section is structured almost identically to the ml_filepath.analyses.neighbor_maliciousness.most_similar_malware section above, except that an is_malware section is added to each of the dictionary elements, to signify if the filepath is associated with a benign or malicious file in our elasticsearch database:    * score - the elasticsearch similarity score in relation to the original customer&#x27;s file.     (The higher the score, the better the match. Should only be used for ordering, as scores     ranges depend on the searched-for-string)   * fs_t - the first-seen time in our sxl4 data, in seconds (UST)   * filepath - the filepath itself   * is_malware - boolean, if the associated file is malicious or not in our database 
        /// </summary>
        /// <value>This section is similar to its sisters, but it lists the nearest sixteen most similar filepaths (calibrated in terms of total malware and benign filepath counts). Those may be all malicious, all benign, or some combination of benign and malicious filepaths. This section is structured almost identically to the ml_filepath.analyses.neighbor_maliciousness.most_similar_malware section above, except that an is_malware section is added to each of the dictionary elements, to signify if the filepath is associated with a benign or malicious file in our elasticsearch database:    * score - the elasticsearch similarity score in relation to the original customer&#x27;s file.     (The higher the score, the better the match. Should only be used for ordering, as scores     ranges depend on the searched-for-string)   * fs_t - the first-seen time in our sxl4 data, in seconds (UST)   * filepath - the filepath itself   * is_malware - boolean, if the associated file is malicious or not in our database </value>
        [DataMember(Name="most_similar", EmitDefaultValue=false)]
        public List<ReportMlFilepathAnalysesNeighborMaliciousnessMostSimilar> MostSimilar { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReportMlFilepathAnalysesNeighborMaliciousness {\n");
            sb.Append("  MostSimilarMalware: ").Append(MostSimilarMalware).Append("\n");
            sb.Append("  MostSimilarBenign: ").Append(MostSimilarBenign).Append("\n");
            sb.Append("  MostSimilar: ").Append(MostSimilar).Append("\n");
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
            return this.Equals(input as ReportMlFilepathAnalysesNeighborMaliciousness);
        }

        /// <summary>
        /// Returns true if ReportMlFilepathAnalysesNeighborMaliciousness instances are equal
        /// </summary>
        /// <param name="input">Instance of ReportMlFilepathAnalysesNeighborMaliciousness to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReportMlFilepathAnalysesNeighborMaliciousness input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MostSimilarMalware == input.MostSimilarMalware ||
                    this.MostSimilarMalware != null &&
                    input.MostSimilarMalware != null &&
                    this.MostSimilarMalware.SequenceEqual(input.MostSimilarMalware)
                ) && 
                (
                    this.MostSimilarBenign == input.MostSimilarBenign ||
                    this.MostSimilarBenign != null &&
                    input.MostSimilarBenign != null &&
                    this.MostSimilarBenign.SequenceEqual(input.MostSimilarBenign)
                ) && 
                (
                    this.MostSimilar == input.MostSimilar ||
                    this.MostSimilar != null &&
                    input.MostSimilar != null &&
                    this.MostSimilar.SequenceEqual(input.MostSimilar)
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
                if (this.MostSimilarMalware != null)
                    hashCode = hashCode * 59 + this.MostSimilarMalware.GetHashCode();
                if (this.MostSimilarBenign != null)
                    hashCode = hashCode * 59 + this.MostSimilarBenign.GetHashCode();
                if (this.MostSimilar != null)
                    hashCode = hashCode * 59 + this.MostSimilar.GetHashCode();
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
