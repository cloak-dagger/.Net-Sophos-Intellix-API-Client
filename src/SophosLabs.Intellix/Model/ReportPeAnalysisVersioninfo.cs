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
    /// ReportPeAnalysisVersioninfo
    /// </summary>
    [DataContract]
        public partial class ReportPeAnalysisVersioninfo :  IEquatable<ReportPeAnalysisVersioninfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReportPeAnalysisVersioninfo" /> class.
        /// </summary>
        /// <param name="comments">comments (required).</param>
        /// <param name="companyname">companyname (required).</param>
        /// <param name="filedescription">filedescription (required).</param>
        /// <param name="fileversion">fileversion (required).</param>
        /// <param name="internalname">internalname (required).</param>
        /// <param name="legalcopyright">legalcopyright (required).</param>
        /// <param name="legaltrademarks">legaltrademarks (required).</param>
        /// <param name="originalfilename">originalfilename (required).</param>
        /// <param name="privatebuild">privatebuild (required).</param>
        /// <param name="productname">productname (required).</param>
        /// <param name="productversion">productversion (required).</param>
        /// <param name="specialbuild">specialbuild (required).</param>
        public ReportPeAnalysisVersioninfo(string comments = default(string), string companyname = default(string), string filedescription = default(string), string fileversion = default(string), string internalname = default(string), string legalcopyright = default(string), string legaltrademarks = default(string), string originalfilename = default(string), string privatebuild = default(string), string productname = default(string), string productversion = default(string), string specialbuild = default(string))
        {
            // to ensure "comments" is required (not null)
            if (comments == null)
            {
                throw new InvalidDataException("comments is a required property for ReportPeAnalysisVersioninfo and cannot be null");
            }
            else
            {
                this.Comments = comments;
            }
            // to ensure "companyname" is required (not null)
            if (companyname == null)
            {
                throw new InvalidDataException("companyname is a required property for ReportPeAnalysisVersioninfo and cannot be null");
            }
            else
            {
                this.Companyname = companyname;
            }
            // to ensure "filedescription" is required (not null)
            if (filedescription == null)
            {
                throw new InvalidDataException("filedescription is a required property for ReportPeAnalysisVersioninfo and cannot be null");
            }
            else
            {
                this.Filedescription = filedescription;
            }
            // to ensure "fileversion" is required (not null)
            if (fileversion == null)
            {
                throw new InvalidDataException("fileversion is a required property for ReportPeAnalysisVersioninfo and cannot be null");
            }
            else
            {
                this.Fileversion = fileversion;
            }
            // to ensure "internalname" is required (not null)
            if (internalname == null)
            {
                throw new InvalidDataException("internalname is a required property for ReportPeAnalysisVersioninfo and cannot be null");
            }
            else
            {
                this.Internalname = internalname;
            }
            // to ensure "legalcopyright" is required (not null)
            if (legalcopyright == null)
            {
                throw new InvalidDataException("legalcopyright is a required property for ReportPeAnalysisVersioninfo and cannot be null");
            }
            else
            {
                this.Legalcopyright = legalcopyright;
            }
            // to ensure "legaltrademarks" is required (not null)
            if (legaltrademarks == null)
            {
                throw new InvalidDataException("legaltrademarks is a required property for ReportPeAnalysisVersioninfo and cannot be null");
            }
            else
            {
                this.Legaltrademarks = legaltrademarks;
            }
            // to ensure "originalfilename" is required (not null)
            if (originalfilename == null)
            {
                throw new InvalidDataException("originalfilename is a required property for ReportPeAnalysisVersioninfo and cannot be null");
            }
            else
            {
                this.Originalfilename = originalfilename;
            }
            // to ensure "privatebuild" is required (not null)
            if (privatebuild == null)
            {
                throw new InvalidDataException("privatebuild is a required property for ReportPeAnalysisVersioninfo and cannot be null");
            }
            else
            {
                this.Privatebuild = privatebuild;
            }
            // to ensure "productname" is required (not null)
            if (productname == null)
            {
                throw new InvalidDataException("productname is a required property for ReportPeAnalysisVersioninfo and cannot be null");
            }
            else
            {
                this.Productname = productname;
            }
            // to ensure "productversion" is required (not null)
            if (productversion == null)
            {
                throw new InvalidDataException("productversion is a required property for ReportPeAnalysisVersioninfo and cannot be null");
            }
            else
            {
                this.Productversion = productversion;
            }
            // to ensure "specialbuild" is required (not null)
            if (specialbuild == null)
            {
                throw new InvalidDataException("specialbuild is a required property for ReportPeAnalysisVersioninfo and cannot be null");
            }
            else
            {
                this.Specialbuild = specialbuild;
            }
        }
        
        /// <summary>
        /// Gets or Sets Comments
        /// </summary>
        [DataMember(Name="comments", EmitDefaultValue=false)]
        public string Comments { get; set; }

        /// <summary>
        /// Gets or Sets Companyname
        /// </summary>
        [DataMember(Name="companyname", EmitDefaultValue=false)]
        public string Companyname { get; set; }

        /// <summary>
        /// Gets or Sets Filedescription
        /// </summary>
        [DataMember(Name="filedescription", EmitDefaultValue=false)]
        public string Filedescription { get; set; }

        /// <summary>
        /// Gets or Sets Fileversion
        /// </summary>
        [DataMember(Name="fileversion", EmitDefaultValue=false)]
        public string Fileversion { get; set; }

        /// <summary>
        /// Gets or Sets Internalname
        /// </summary>
        [DataMember(Name="internalname", EmitDefaultValue=false)]
        public string Internalname { get; set; }

        /// <summary>
        /// Gets or Sets Legalcopyright
        /// </summary>
        [DataMember(Name="legalcopyright", EmitDefaultValue=false)]
        public string Legalcopyright { get; set; }

        /// <summary>
        /// Gets or Sets Legaltrademarks
        /// </summary>
        [DataMember(Name="legaltrademarks", EmitDefaultValue=false)]
        public string Legaltrademarks { get; set; }

        /// <summary>
        /// Gets or Sets Originalfilename
        /// </summary>
        [DataMember(Name="originalfilename", EmitDefaultValue=false)]
        public string Originalfilename { get; set; }

        /// <summary>
        /// Gets or Sets Privatebuild
        /// </summary>
        [DataMember(Name="privatebuild", EmitDefaultValue=false)]
        public string Privatebuild { get; set; }

        /// <summary>
        /// Gets or Sets Productname
        /// </summary>
        [DataMember(Name="productname", EmitDefaultValue=false)]
        public string Productname { get; set; }

        /// <summary>
        /// Gets or Sets Productversion
        /// </summary>
        [DataMember(Name="productversion", EmitDefaultValue=false)]
        public string Productversion { get; set; }

        /// <summary>
        /// Gets or Sets Specialbuild
        /// </summary>
        [DataMember(Name="specialbuild", EmitDefaultValue=false)]
        public string Specialbuild { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReportPeAnalysisVersioninfo {\n");
            sb.Append("  Comments: ").Append(Comments).Append("\n");
            sb.Append("  Companyname: ").Append(Companyname).Append("\n");
            sb.Append("  Filedescription: ").Append(Filedescription).Append("\n");
            sb.Append("  Fileversion: ").Append(Fileversion).Append("\n");
            sb.Append("  Internalname: ").Append(Internalname).Append("\n");
            sb.Append("  Legalcopyright: ").Append(Legalcopyright).Append("\n");
            sb.Append("  Legaltrademarks: ").Append(Legaltrademarks).Append("\n");
            sb.Append("  Originalfilename: ").Append(Originalfilename).Append("\n");
            sb.Append("  Privatebuild: ").Append(Privatebuild).Append("\n");
            sb.Append("  Productname: ").Append(Productname).Append("\n");
            sb.Append("  Productversion: ").Append(Productversion).Append("\n");
            sb.Append("  Specialbuild: ").Append(Specialbuild).Append("\n");
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
            return this.Equals(input as ReportPeAnalysisVersioninfo);
        }

        /// <summary>
        /// Returns true if ReportPeAnalysisVersioninfo instances are equal
        /// </summary>
        /// <param name="input">Instance of ReportPeAnalysisVersioninfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReportPeAnalysisVersioninfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Comments == input.Comments ||
                    (this.Comments != null &&
                    this.Comments.Equals(input.Comments))
                ) && 
                (
                    this.Companyname == input.Companyname ||
                    (this.Companyname != null &&
                    this.Companyname.Equals(input.Companyname))
                ) && 
                (
                    this.Filedescription == input.Filedescription ||
                    (this.Filedescription != null &&
                    this.Filedescription.Equals(input.Filedescription))
                ) && 
                (
                    this.Fileversion == input.Fileversion ||
                    (this.Fileversion != null &&
                    this.Fileversion.Equals(input.Fileversion))
                ) && 
                (
                    this.Internalname == input.Internalname ||
                    (this.Internalname != null &&
                    this.Internalname.Equals(input.Internalname))
                ) && 
                (
                    this.Legalcopyright == input.Legalcopyright ||
                    (this.Legalcopyright != null &&
                    this.Legalcopyright.Equals(input.Legalcopyright))
                ) && 
                (
                    this.Legaltrademarks == input.Legaltrademarks ||
                    (this.Legaltrademarks != null &&
                    this.Legaltrademarks.Equals(input.Legaltrademarks))
                ) && 
                (
                    this.Originalfilename == input.Originalfilename ||
                    (this.Originalfilename != null &&
                    this.Originalfilename.Equals(input.Originalfilename))
                ) && 
                (
                    this.Privatebuild == input.Privatebuild ||
                    (this.Privatebuild != null &&
                    this.Privatebuild.Equals(input.Privatebuild))
                ) && 
                (
                    this.Productname == input.Productname ||
                    (this.Productname != null &&
                    this.Productname.Equals(input.Productname))
                ) && 
                (
                    this.Productversion == input.Productversion ||
                    (this.Productversion != null &&
                    this.Productversion.Equals(input.Productversion))
                ) && 
                (
                    this.Specialbuild == input.Specialbuild ||
                    (this.Specialbuild != null &&
                    this.Specialbuild.Equals(input.Specialbuild))
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
                if (this.Comments != null)
                    hashCode = hashCode * 59 + this.Comments.GetHashCode();
                if (this.Companyname != null)
                    hashCode = hashCode * 59 + this.Companyname.GetHashCode();
                if (this.Filedescription != null)
                    hashCode = hashCode * 59 + this.Filedescription.GetHashCode();
                if (this.Fileversion != null)
                    hashCode = hashCode * 59 + this.Fileversion.GetHashCode();
                if (this.Internalname != null)
                    hashCode = hashCode * 59 + this.Internalname.GetHashCode();
                if (this.Legalcopyright != null)
                    hashCode = hashCode * 59 + this.Legalcopyright.GetHashCode();
                if (this.Legaltrademarks != null)
                    hashCode = hashCode * 59 + this.Legaltrademarks.GetHashCode();
                if (this.Originalfilename != null)
                    hashCode = hashCode * 59 + this.Originalfilename.GetHashCode();
                if (this.Privatebuild != null)
                    hashCode = hashCode * 59 + this.Privatebuild.GetHashCode();
                if (this.Productname != null)
                    hashCode = hashCode * 59 + this.Productname.GetHashCode();
                if (this.Productversion != null)
                    hashCode = hashCode * 59 + this.Productversion.GetHashCode();
                if (this.Specialbuild != null)
                    hashCode = hashCode * 59 + this.Specialbuild.GetHashCode();
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
