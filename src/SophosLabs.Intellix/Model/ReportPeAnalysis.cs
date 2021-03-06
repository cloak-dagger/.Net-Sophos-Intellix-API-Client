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
    /// Analysis of a PE file&#x27;s structure, produced by Labs Research - keep all the pe-specific analysis in its own section, in future releases we will have non-pe analysis sections as well 
    /// </summary>
    [DataContract]
        public partial class ReportPeAnalysis :  IEquatable<ReportPeAnalysis>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReportPeAnalysis" /> class.
        /// </summary>
        /// <param name="digisig">digisig (required).</param>
        /// <param name="export">export (required).</param>
        /// <param name="filesize">filesize (required).</param>
        /// <param name="imagebase">imagebase (required).</param>
        /// <param name="imagesize">imagesize (required).</param>
        /// <param name="import">import (required).</param>
        /// <param name="languages">languages (required).</param>
        /// <param name="machineid">machineid (required).</param>
        /// <param name="numberofsections">numberofsections (required).</param>
        /// <param name="pdbstring">pdbstring.</param>
        /// <param name="peflags">peflags (required).</param>
        /// <param name="resources">resources (required).</param>
        /// <param name="sections">sections (required).</param>
        /// <param name="subsystem">subsystem (required).</param>
        /// <param name="timedate">timedate (required).</param>
        /// <param name="versioninfo">versioninfo (required).</param>
        public ReportPeAnalysis(ReportPeAnalysisDigisig digisig = default(ReportPeAnalysisDigisig), ReportPeAnalysisExport export = default(ReportPeAnalysisExport), int? filesize = default(int?), int? imagebase = default(int?), int? imagesize = default(int?), List<ReportPeAnalysisImport> import = default(List<ReportPeAnalysisImport>), List<string> languages = default(List<string>), string machineid = default(string), int? numberofsections = default(int?), string pdbstring = default(string), string peflags = default(string), List<ReportPeAnalysisResources> resources = default(List<ReportPeAnalysisResources>), List<ReportPeAnalysisSections> sections = default(List<ReportPeAnalysisSections>), string subsystem = default(string), DateTime? timedate = default(DateTime?), ReportPeAnalysisVersioninfo versioninfo = default(ReportPeAnalysisVersioninfo))
        {
            // to ensure "digisig" is required (not null)
            if (digisig == null)
            {
                throw new InvalidDataException("digisig is a required property for ReportPeAnalysis and cannot be null");
            }
            else
            {
                this.Digisig = digisig;
            }
            // to ensure "export" is required (not null)
            if (export == null)
            {
                throw new InvalidDataException("export is a required property for ReportPeAnalysis and cannot be null");
            }
            else
            {
                this.Export = export;
            }
            // to ensure "filesize" is required (not null)
            if (filesize == null)
            {
                throw new InvalidDataException("filesize is a required property for ReportPeAnalysis and cannot be null");
            }
            else
            {
                this.Filesize = filesize;
            }
            // to ensure "imagebase" is required (not null)
            if (imagebase == null)
            {
                throw new InvalidDataException("imagebase is a required property for ReportPeAnalysis and cannot be null");
            }
            else
            {
                this.Imagebase = imagebase;
            }
            // to ensure "imagesize" is required (not null)
            if (imagesize == null)
            {
                throw new InvalidDataException("imagesize is a required property for ReportPeAnalysis and cannot be null");
            }
            else
            {
                this.Imagesize = imagesize;
            }
            // to ensure "import" is required (not null)
            if (import == null)
            {
                throw new InvalidDataException("import is a required property for ReportPeAnalysis and cannot be null");
            }
            else
            {
                this.Import = import;
            }
            // to ensure "languages" is required (not null)
            if (languages == null)
            {
                throw new InvalidDataException("languages is a required property for ReportPeAnalysis and cannot be null");
            }
            else
            {
                this.Languages = languages;
            }
            // to ensure "machineid" is required (not null)
            if (machineid == null)
            {
                throw new InvalidDataException("machineid is a required property for ReportPeAnalysis and cannot be null");
            }
            else
            {
                this.Machineid = machineid;
            }
            // to ensure "numberofsections" is required (not null)
            if (numberofsections == null)
            {
                throw new InvalidDataException("numberofsections is a required property for ReportPeAnalysis and cannot be null");
            }
            else
            {
                this.Numberofsections = numberofsections;
            }
            // to ensure "peflags" is required (not null)
            if (peflags == null)
            {
                throw new InvalidDataException("peflags is a required property for ReportPeAnalysis and cannot be null");
            }
            else
            {
                this.Peflags = peflags;
            }
            // to ensure "resources" is required (not null)
            if (resources == null)
            {
                throw new InvalidDataException("resources is a required property for ReportPeAnalysis and cannot be null");
            }
            else
            {
                this.Resources = resources;
            }
            // to ensure "sections" is required (not null)
            if (sections == null)
            {
                throw new InvalidDataException("sections is a required property for ReportPeAnalysis and cannot be null");
            }
            else
            {
                this.Sections = sections;
            }
            // to ensure "subsystem" is required (not null)
            if (subsystem == null)
            {
                throw new InvalidDataException("subsystem is a required property for ReportPeAnalysis and cannot be null");
            }
            else
            {
                this.Subsystem = subsystem;
            }
            // to ensure "timedate" is required (not null)
            if (timedate == null)
            {
                throw new InvalidDataException("timedate is a required property for ReportPeAnalysis and cannot be null");
            }
            else
            {
                this.Timedate = timedate;
            }
            // to ensure "versioninfo" is required (not null)
            if (versioninfo == null)
            {
                throw new InvalidDataException("versioninfo is a required property for ReportPeAnalysis and cannot be null");
            }
            else
            {
                this.Versioninfo = versioninfo;
            }
            this.Pdbstring = pdbstring;
        }
        
        /// <summary>
        /// Gets or Sets Digisig
        /// </summary>
        [DataMember(Name="digisig", EmitDefaultValue=false)]
        public ReportPeAnalysisDigisig Digisig { get; set; }

        /// <summary>
        /// Gets or Sets Export
        /// </summary>
        [DataMember(Name="export", EmitDefaultValue=false)]
        public ReportPeAnalysisExport Export { get; set; }

        /// <summary>
        /// Gets or Sets Filesize
        /// </summary>
        [DataMember(Name="filesize", EmitDefaultValue=false)]
        public int? Filesize { get; set; }

        /// <summary>
        /// Gets or Sets Imagebase
        /// </summary>
        [DataMember(Name="imagebase", EmitDefaultValue=false)]
        public int? Imagebase { get; set; }

        /// <summary>
        /// Gets or Sets Imagesize
        /// </summary>
        [DataMember(Name="imagesize", EmitDefaultValue=false)]
        public int? Imagesize { get; set; }

        /// <summary>
        /// Gets or Sets Import
        /// </summary>
        [DataMember(Name="import", EmitDefaultValue=false)]
        public List<ReportPeAnalysisImport> Import { get; set; }

        /// <summary>
        /// Gets or Sets Languages
        /// </summary>
        [DataMember(Name="languages", EmitDefaultValue=false)]
        public List<string> Languages { get; set; }

        /// <summary>
        /// Gets or Sets Machineid
        /// </summary>
        [DataMember(Name="machineid", EmitDefaultValue=false)]
        public string Machineid { get; set; }

        /// <summary>
        /// Gets or Sets Numberofsections
        /// </summary>
        [DataMember(Name="numberofsections", EmitDefaultValue=false)]
        public int? Numberofsections { get; set; }

        /// <summary>
        /// Gets or Sets Pdbstring
        /// </summary>
        [DataMember(Name="pdbstring", EmitDefaultValue=false)]
        public string Pdbstring { get; set; }

        /// <summary>
        /// Gets or Sets Peflags
        /// </summary>
        [DataMember(Name="peflags", EmitDefaultValue=false)]
        public string Peflags { get; set; }

        /// <summary>
        /// Gets or Sets Resources
        /// </summary>
        [DataMember(Name="resources", EmitDefaultValue=false)]
        public List<ReportPeAnalysisResources> Resources { get; set; }

        /// <summary>
        /// Gets or Sets Sections
        /// </summary>
        [DataMember(Name="sections", EmitDefaultValue=false)]
        public List<ReportPeAnalysisSections> Sections { get; set; }

        /// <summary>
        /// Gets or Sets Subsystem
        /// </summary>
        [DataMember(Name="subsystem", EmitDefaultValue=false)]
        public string Subsystem { get; set; }

        /// <summary>
        /// Gets or Sets Timedate
        /// </summary>
        [DataMember(Name="timedate", EmitDefaultValue=false)]
        public DateTime? Timedate { get; set; }

        /// <summary>
        /// Gets or Sets Versioninfo
        /// </summary>
        [DataMember(Name="versioninfo", EmitDefaultValue=false)]
        public ReportPeAnalysisVersioninfo Versioninfo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReportPeAnalysis {\n");
            sb.Append("  Digisig: ").Append(Digisig).Append("\n");
            sb.Append("  Export: ").Append(Export).Append("\n");
            sb.Append("  Filesize: ").Append(Filesize).Append("\n");
            sb.Append("  Imagebase: ").Append(Imagebase).Append("\n");
            sb.Append("  Imagesize: ").Append(Imagesize).Append("\n");
            sb.Append("  Import: ").Append(Import).Append("\n");
            sb.Append("  Languages: ").Append(Languages).Append("\n");
            sb.Append("  Machineid: ").Append(Machineid).Append("\n");
            sb.Append("  Numberofsections: ").Append(Numberofsections).Append("\n");
            sb.Append("  Pdbstring: ").Append(Pdbstring).Append("\n");
            sb.Append("  Peflags: ").Append(Peflags).Append("\n");
            sb.Append("  Resources: ").Append(Resources).Append("\n");
            sb.Append("  Sections: ").Append(Sections).Append("\n");
            sb.Append("  Subsystem: ").Append(Subsystem).Append("\n");
            sb.Append("  Timedate: ").Append(Timedate).Append("\n");
            sb.Append("  Versioninfo: ").Append(Versioninfo).Append("\n");
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
            return this.Equals(input as ReportPeAnalysis);
        }

        /// <summary>
        /// Returns true if ReportPeAnalysis instances are equal
        /// </summary>
        /// <param name="input">Instance of ReportPeAnalysis to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReportPeAnalysis input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Digisig == input.Digisig ||
                    (this.Digisig != null &&
                    this.Digisig.Equals(input.Digisig))
                ) && 
                (
                    this.Export == input.Export ||
                    (this.Export != null &&
                    this.Export.Equals(input.Export))
                ) && 
                (
                    this.Filesize == input.Filesize ||
                    (this.Filesize != null &&
                    this.Filesize.Equals(input.Filesize))
                ) && 
                (
                    this.Imagebase == input.Imagebase ||
                    (this.Imagebase != null &&
                    this.Imagebase.Equals(input.Imagebase))
                ) && 
                (
                    this.Imagesize == input.Imagesize ||
                    (this.Imagesize != null &&
                    this.Imagesize.Equals(input.Imagesize))
                ) && 
                (
                    this.Import == input.Import ||
                    this.Import != null &&
                    input.Import != null &&
                    this.Import.SequenceEqual(input.Import)
                ) && 
                (
                    this.Languages == input.Languages ||
                    this.Languages != null &&
                    input.Languages != null &&
                    this.Languages.SequenceEqual(input.Languages)
                ) && 
                (
                    this.Machineid == input.Machineid ||
                    (this.Machineid != null &&
                    this.Machineid.Equals(input.Machineid))
                ) && 
                (
                    this.Numberofsections == input.Numberofsections ||
                    (this.Numberofsections != null &&
                    this.Numberofsections.Equals(input.Numberofsections))
                ) && 
                (
                    this.Pdbstring == input.Pdbstring ||
                    (this.Pdbstring != null &&
                    this.Pdbstring.Equals(input.Pdbstring))
                ) && 
                (
                    this.Peflags == input.Peflags ||
                    (this.Peflags != null &&
                    this.Peflags.Equals(input.Peflags))
                ) && 
                (
                    this.Resources == input.Resources ||
                    this.Resources != null &&
                    input.Resources != null &&
                    this.Resources.SequenceEqual(input.Resources)
                ) && 
                (
                    this.Sections == input.Sections ||
                    this.Sections != null &&
                    input.Sections != null &&
                    this.Sections.SequenceEqual(input.Sections)
                ) && 
                (
                    this.Subsystem == input.Subsystem ||
                    (this.Subsystem != null &&
                    this.Subsystem.Equals(input.Subsystem))
                ) && 
                (
                    this.Timedate == input.Timedate ||
                    (this.Timedate != null &&
                    this.Timedate.Equals(input.Timedate))
                ) && 
                (
                    this.Versioninfo == input.Versioninfo ||
                    (this.Versioninfo != null &&
                    this.Versioninfo.Equals(input.Versioninfo))
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
                if (this.Digisig != null)
                    hashCode = hashCode * 59 + this.Digisig.GetHashCode();
                if (this.Export != null)
                    hashCode = hashCode * 59 + this.Export.GetHashCode();
                if (this.Filesize != null)
                    hashCode = hashCode * 59 + this.Filesize.GetHashCode();
                if (this.Imagebase != null)
                    hashCode = hashCode * 59 + this.Imagebase.GetHashCode();
                if (this.Imagesize != null)
                    hashCode = hashCode * 59 + this.Imagesize.GetHashCode();
                if (this.Import != null)
                    hashCode = hashCode * 59 + this.Import.GetHashCode();
                if (this.Languages != null)
                    hashCode = hashCode * 59 + this.Languages.GetHashCode();
                if (this.Machineid != null)
                    hashCode = hashCode * 59 + this.Machineid.GetHashCode();
                if (this.Numberofsections != null)
                    hashCode = hashCode * 59 + this.Numberofsections.GetHashCode();
                if (this.Pdbstring != null)
                    hashCode = hashCode * 59 + this.Pdbstring.GetHashCode();
                if (this.Peflags != null)
                    hashCode = hashCode * 59 + this.Peflags.GetHashCode();
                if (this.Resources != null)
                    hashCode = hashCode * 59 + this.Resources.GetHashCode();
                if (this.Sections != null)
                    hashCode = hashCode * 59 + this.Sections.GetHashCode();
                if (this.Subsystem != null)
                    hashCode = hashCode * 59 + this.Subsystem.GetHashCode();
                if (this.Timedate != null)
                    hashCode = hashCode * 59 + this.Timedate.GetHashCode();
                if (this.Versioninfo != null)
                    hashCode = hashCode * 59 + this.Versioninfo.GetHashCode();
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
