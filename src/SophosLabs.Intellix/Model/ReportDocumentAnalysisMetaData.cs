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
    /// Document metadata produced by document specific analyzers. the same format is used for Office, PDF and RTF files. The fields unsupported by a particular file will be missing 
    /// </summary>
    [DataContract]
        public partial class ReportDocumentAnalysisMetaData :  IEquatable<ReportDocumentAnalysisMetaData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReportDocumentAnalysisMetaData" /> class.
        /// </summary>
        /// <param name="author">Document&#x27;s Author.</param>
        /// <param name="bytes">Total number of bytes.</param>
        /// <param name="category">Document category.</param>
        /// <param name="codepage">CodePage of the document.</param>
        /// <param name="comments">Comments related to the document.</param>
        /// <param name="company">Author&#x27;s company.</param>
        /// <param name="contentStatus">contentStatus.</param>
        /// <param name="contentType">contentType.</param>
        /// <param name="createTime">The date the document was created (EPOCH).</param>
        /// <param name="creatingApplication">Application that created the file.</param>
        /// <param name="digisig">Document&#x27;s digital signature.</param>
        /// <param name="encryption">Encryption method.</param>
        /// <param name="hiddenSlides">Total number of hidden slides.</param>
        /// <param name="keywords">Keywords that describe the document.</param>
        /// <param name="language">Primary language of the document.</param>
        /// <param name="lastBackup">The date the document was last backed up.</param>
        /// <param name="lastPrinted">The date the document was last printed (EPOCH).</param>
        /// <param name="lastSavedBy">Name of the last user to save the file.</param>
        /// <param name="lastSavedTime">The date the document was last saved (EPOCH).</param>
        /// <param name="lines">Total number of lines.</param>
        /// <param name="linkBase">linkBase.</param>
        /// <param name="manager">Author&#x27;s manager.</param>
        /// <param name="notes">Total number of notes.</param>
        /// <param name="numChars">Total number of character.</param>
        /// <param name="numPages">Total number of pages.</param>
        /// <param name="numWords">Total number of words.</param>
        /// <param name="paragraphs">Total number of paragraphs.</param>
        /// <param name="presentationTarget">Target recipient for Presentation.</param>
        /// <param name="revisionNumber">Revision of the document.</param>
        /// <param name="sharedDoc">Has the document been shared?.</param>
        /// <param name="slides">Total number of slide.</param>
        /// <param name="subject">Document&#x27;s Subject.</param>
        /// <param name="template">Template the document was based on.</param>
        /// <param name="title">Document&#x27;s Title.</param>
        /// <param name="totalEditTime">Total number of minutes editing the file.</param>
        /// <param name="version">Document version.</param>
        public ReportDocumentAnalysisMetaData(string author = default(string), int? bytes = default(int?), string category = default(string), int? codepage = default(int?), string comments = default(string), string company = default(string), string contentStatus = default(string), string contentType = default(string), DateTime? createTime = default(DateTime?), string creatingApplication = default(string), string digisig = default(string), string encryption = default(string), int? hiddenSlides = default(int?), string keywords = default(string), string language = default(string), DateTime? lastBackup = default(DateTime?), DateTime? lastPrinted = default(DateTime?), string lastSavedBy = default(string), DateTime? lastSavedTime = default(DateTime?), int? lines = default(int?), string linkBase = default(string), string manager = default(string), int? notes = default(int?), int? numChars = default(int?), int? numPages = default(int?), int? numWords = default(int?), int? paragraphs = default(int?), string presentationTarget = default(string), string revisionNumber = default(string), bool? sharedDoc = default(bool?), int? slides = default(int?), string subject = default(string), string template = default(string), string title = default(string), int? totalEditTime = default(int?), decimal? version = default(decimal?))
        {
            this.Author = author;
            this.Bytes = bytes;
            this.Category = category;
            this.Codepage = codepage;
            this.Comments = comments;
            this.Company = company;
            this.ContentStatus = contentStatus;
            this.ContentType = contentType;
            this.CreateTime = createTime;
            this.CreatingApplication = creatingApplication;
            this.Digisig = digisig;
            this.Encryption = encryption;
            this.HiddenSlides = hiddenSlides;
            this.Keywords = keywords;
            this.Language = language;
            this.LastBackup = lastBackup;
            this.LastPrinted = lastPrinted;
            this.LastSavedBy = lastSavedBy;
            this.LastSavedTime = lastSavedTime;
            this.Lines = lines;
            this.LinkBase = linkBase;
            this.Manager = manager;
            this.Notes = notes;
            this.NumChars = numChars;
            this.NumPages = numPages;
            this.NumWords = numWords;
            this.Paragraphs = paragraphs;
            this.PresentationTarget = presentationTarget;
            this.RevisionNumber = revisionNumber;
            this.SharedDoc = sharedDoc;
            this.Slides = slides;
            this.Subject = subject;
            this.Template = template;
            this.Title = title;
            this.TotalEditTime = totalEditTime;
            this.Version = version;
        }
        
        /// <summary>
        /// Document&#x27;s Author
        /// </summary>
        /// <value>Document&#x27;s Author</value>
        [DataMember(Name="author", EmitDefaultValue=false)]
        public string Author { get; set; }

        /// <summary>
        /// Total number of bytes
        /// </summary>
        /// <value>Total number of bytes</value>
        [DataMember(Name="bytes", EmitDefaultValue=false)]
        public int? Bytes { get; set; }

        /// <summary>
        /// Document category
        /// </summary>
        /// <value>Document category</value>
        [DataMember(Name="category", EmitDefaultValue=false)]
        public string Category { get; set; }

        /// <summary>
        /// CodePage of the document
        /// </summary>
        /// <value>CodePage of the document</value>
        [DataMember(Name="codepage", EmitDefaultValue=false)]
        public int? Codepage { get; set; }

        /// <summary>
        /// Comments related to the document
        /// </summary>
        /// <value>Comments related to the document</value>
        [DataMember(Name="comments", EmitDefaultValue=false)]
        public string Comments { get; set; }

        /// <summary>
        /// Author&#x27;s company
        /// </summary>
        /// <value>Author&#x27;s company</value>
        [DataMember(Name="company", EmitDefaultValue=false)]
        public string Company { get; set; }

        /// <summary>
        /// Gets or Sets ContentStatus
        /// </summary>
        [DataMember(Name="content_status", EmitDefaultValue=false)]
        public string ContentStatus { get; set; }

        /// <summary>
        /// Gets or Sets ContentType
        /// </summary>
        [DataMember(Name="content_type", EmitDefaultValue=false)]
        public string ContentType { get; set; }

        /// <summary>
        /// The date the document was created (EPOCH)
        /// </summary>
        /// <value>The date the document was created (EPOCH)</value>
        [DataMember(Name="create_time", EmitDefaultValue=false)]
        public DateTime? CreateTime { get; set; }

        /// <summary>
        /// Application that created the file
        /// </summary>
        /// <value>Application that created the file</value>
        [DataMember(Name="creating_application", EmitDefaultValue=false)]
        public string CreatingApplication { get; set; }

        /// <summary>
        /// Document&#x27;s digital signature
        /// </summary>
        /// <value>Document&#x27;s digital signature</value>
        [DataMember(Name="digisig", EmitDefaultValue=false)]
        public string Digisig { get; set; }

        /// <summary>
        /// Encryption method
        /// </summary>
        /// <value>Encryption method</value>
        [DataMember(Name="encryption", EmitDefaultValue=false)]
        public string Encryption { get; set; }

        /// <summary>
        /// Total number of hidden slides
        /// </summary>
        /// <value>Total number of hidden slides</value>
        [DataMember(Name="hidden_slides", EmitDefaultValue=false)]
        public int? HiddenSlides { get; set; }

        /// <summary>
        /// Keywords that describe the document
        /// </summary>
        /// <value>Keywords that describe the document</value>
        [DataMember(Name="keywords", EmitDefaultValue=false)]
        public string Keywords { get; set; }

        /// <summary>
        /// Primary language of the document
        /// </summary>
        /// <value>Primary language of the document</value>
        [DataMember(Name="language", EmitDefaultValue=false)]
        public string Language { get; set; }

        /// <summary>
        /// The date the document was last backed up
        /// </summary>
        /// <value>The date the document was last backed up</value>
        [DataMember(Name="last_backup", EmitDefaultValue=false)]
        public DateTime? LastBackup { get; set; }

        /// <summary>
        /// The date the document was last printed (EPOCH)
        /// </summary>
        /// <value>The date the document was last printed (EPOCH)</value>
        [DataMember(Name="last_printed", EmitDefaultValue=false)]
        public DateTime? LastPrinted { get; set; }

        /// <summary>
        /// Name of the last user to save the file
        /// </summary>
        /// <value>Name of the last user to save the file</value>
        [DataMember(Name="last_saved_by", EmitDefaultValue=false)]
        public string LastSavedBy { get; set; }

        /// <summary>
        /// The date the document was last saved (EPOCH)
        /// </summary>
        /// <value>The date the document was last saved (EPOCH)</value>
        [DataMember(Name="last_saved_time", EmitDefaultValue=false)]
        public DateTime? LastSavedTime { get; set; }

        /// <summary>
        /// Total number of lines
        /// </summary>
        /// <value>Total number of lines</value>
        [DataMember(Name="lines", EmitDefaultValue=false)]
        public int? Lines { get; set; }

        /// <summary>
        /// Gets or Sets LinkBase
        /// </summary>
        [DataMember(Name="link_base", EmitDefaultValue=false)]
        public string LinkBase { get; set; }

        /// <summary>
        /// Author&#x27;s manager
        /// </summary>
        /// <value>Author&#x27;s manager</value>
        [DataMember(Name="manager", EmitDefaultValue=false)]
        public string Manager { get; set; }

        /// <summary>
        /// Total number of notes
        /// </summary>
        /// <value>Total number of notes</value>
        [DataMember(Name="notes", EmitDefaultValue=false)]
        public int? Notes { get; set; }

        /// <summary>
        /// Total number of character
        /// </summary>
        /// <value>Total number of character</value>
        [DataMember(Name="num_chars", EmitDefaultValue=false)]
        public int? NumChars { get; set; }

        /// <summary>
        /// Total number of pages
        /// </summary>
        /// <value>Total number of pages</value>
        [DataMember(Name="num_pages", EmitDefaultValue=false)]
        public int? NumPages { get; set; }

        /// <summary>
        /// Total number of words
        /// </summary>
        /// <value>Total number of words</value>
        [DataMember(Name="num_words", EmitDefaultValue=false)]
        public int? NumWords { get; set; }

        /// <summary>
        /// Total number of paragraphs
        /// </summary>
        /// <value>Total number of paragraphs</value>
        [DataMember(Name="paragraphs", EmitDefaultValue=false)]
        public int? Paragraphs { get; set; }

        /// <summary>
        /// Target recipient for Presentation
        /// </summary>
        /// <value>Target recipient for Presentation</value>
        [DataMember(Name="presentation_target", EmitDefaultValue=false)]
        public string PresentationTarget { get; set; }

        /// <summary>
        /// Revision of the document
        /// </summary>
        /// <value>Revision of the document</value>
        [DataMember(Name="revision_number", EmitDefaultValue=false)]
        public string RevisionNumber { get; set; }

        /// <summary>
        /// Has the document been shared?
        /// </summary>
        /// <value>Has the document been shared?</value>
        [DataMember(Name="shared_doc", EmitDefaultValue=false)]
        public bool? SharedDoc { get; set; }

        /// <summary>
        /// Total number of slide
        /// </summary>
        /// <value>Total number of slide</value>
        [DataMember(Name="slides", EmitDefaultValue=false)]
        public int? Slides { get; set; }

        /// <summary>
        /// Document&#x27;s Subject
        /// </summary>
        /// <value>Document&#x27;s Subject</value>
        [DataMember(Name="subject", EmitDefaultValue=false)]
        public string Subject { get; set; }

        /// <summary>
        /// Template the document was based on
        /// </summary>
        /// <value>Template the document was based on</value>
        [DataMember(Name="template", EmitDefaultValue=false)]
        public string Template { get; set; }

        /// <summary>
        /// Document&#x27;s Title
        /// </summary>
        /// <value>Document&#x27;s Title</value>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }

        /// <summary>
        /// Total number of minutes editing the file
        /// </summary>
        /// <value>Total number of minutes editing the file</value>
        [DataMember(Name="total_edit_time", EmitDefaultValue=false)]
        public int? TotalEditTime { get; set; }

        /// <summary>
        /// Document version
        /// </summary>
        /// <value>Document version</value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public decimal? Version { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReportDocumentAnalysisMetaData {\n");
            sb.Append("  Author: ").Append(Author).Append("\n");
            sb.Append("  Bytes: ").Append(Bytes).Append("\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  Codepage: ").Append(Codepage).Append("\n");
            sb.Append("  Comments: ").Append(Comments).Append("\n");
            sb.Append("  Company: ").Append(Company).Append("\n");
            sb.Append("  ContentStatus: ").Append(ContentStatus).Append("\n");
            sb.Append("  ContentType: ").Append(ContentType).Append("\n");
            sb.Append("  CreateTime: ").Append(CreateTime).Append("\n");
            sb.Append("  CreatingApplication: ").Append(CreatingApplication).Append("\n");
            sb.Append("  Digisig: ").Append(Digisig).Append("\n");
            sb.Append("  Encryption: ").Append(Encryption).Append("\n");
            sb.Append("  HiddenSlides: ").Append(HiddenSlides).Append("\n");
            sb.Append("  Keywords: ").Append(Keywords).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  LastBackup: ").Append(LastBackup).Append("\n");
            sb.Append("  LastPrinted: ").Append(LastPrinted).Append("\n");
            sb.Append("  LastSavedBy: ").Append(LastSavedBy).Append("\n");
            sb.Append("  LastSavedTime: ").Append(LastSavedTime).Append("\n");
            sb.Append("  Lines: ").Append(Lines).Append("\n");
            sb.Append("  LinkBase: ").Append(LinkBase).Append("\n");
            sb.Append("  Manager: ").Append(Manager).Append("\n");
            sb.Append("  Notes: ").Append(Notes).Append("\n");
            sb.Append("  NumChars: ").Append(NumChars).Append("\n");
            sb.Append("  NumPages: ").Append(NumPages).Append("\n");
            sb.Append("  NumWords: ").Append(NumWords).Append("\n");
            sb.Append("  Paragraphs: ").Append(Paragraphs).Append("\n");
            sb.Append("  PresentationTarget: ").Append(PresentationTarget).Append("\n");
            sb.Append("  RevisionNumber: ").Append(RevisionNumber).Append("\n");
            sb.Append("  SharedDoc: ").Append(SharedDoc).Append("\n");
            sb.Append("  Slides: ").Append(Slides).Append("\n");
            sb.Append("  Subject: ").Append(Subject).Append("\n");
            sb.Append("  Template: ").Append(Template).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  TotalEditTime: ").Append(TotalEditTime).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
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
            return this.Equals(input as ReportDocumentAnalysisMetaData);
        }

        /// <summary>
        /// Returns true if ReportDocumentAnalysisMetaData instances are equal
        /// </summary>
        /// <param name="input">Instance of ReportDocumentAnalysisMetaData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReportDocumentAnalysisMetaData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Author == input.Author ||
                    (this.Author != null &&
                    this.Author.Equals(input.Author))
                ) && 
                (
                    this.Bytes == input.Bytes ||
                    (this.Bytes != null &&
                    this.Bytes.Equals(input.Bytes))
                ) && 
                (
                    this.Category == input.Category ||
                    (this.Category != null &&
                    this.Category.Equals(input.Category))
                ) && 
                (
                    this.Codepage == input.Codepage ||
                    (this.Codepage != null &&
                    this.Codepage.Equals(input.Codepage))
                ) && 
                (
                    this.Comments == input.Comments ||
                    (this.Comments != null &&
                    this.Comments.Equals(input.Comments))
                ) && 
                (
                    this.Company == input.Company ||
                    (this.Company != null &&
                    this.Company.Equals(input.Company))
                ) && 
                (
                    this.ContentStatus == input.ContentStatus ||
                    (this.ContentStatus != null &&
                    this.ContentStatus.Equals(input.ContentStatus))
                ) && 
                (
                    this.ContentType == input.ContentType ||
                    (this.ContentType != null &&
                    this.ContentType.Equals(input.ContentType))
                ) && 
                (
                    this.CreateTime == input.CreateTime ||
                    (this.CreateTime != null &&
                    this.CreateTime.Equals(input.CreateTime))
                ) && 
                (
                    this.CreatingApplication == input.CreatingApplication ||
                    (this.CreatingApplication != null &&
                    this.CreatingApplication.Equals(input.CreatingApplication))
                ) && 
                (
                    this.Digisig == input.Digisig ||
                    (this.Digisig != null &&
                    this.Digisig.Equals(input.Digisig))
                ) && 
                (
                    this.Encryption == input.Encryption ||
                    (this.Encryption != null &&
                    this.Encryption.Equals(input.Encryption))
                ) && 
                (
                    this.HiddenSlides == input.HiddenSlides ||
                    (this.HiddenSlides != null &&
                    this.HiddenSlides.Equals(input.HiddenSlides))
                ) && 
                (
                    this.Keywords == input.Keywords ||
                    (this.Keywords != null &&
                    this.Keywords.Equals(input.Keywords))
                ) && 
                (
                    this.Language == input.Language ||
                    (this.Language != null &&
                    this.Language.Equals(input.Language))
                ) && 
                (
                    this.LastBackup == input.LastBackup ||
                    (this.LastBackup != null &&
                    this.LastBackup.Equals(input.LastBackup))
                ) && 
                (
                    this.LastPrinted == input.LastPrinted ||
                    (this.LastPrinted != null &&
                    this.LastPrinted.Equals(input.LastPrinted))
                ) && 
                (
                    this.LastSavedBy == input.LastSavedBy ||
                    (this.LastSavedBy != null &&
                    this.LastSavedBy.Equals(input.LastSavedBy))
                ) && 
                (
                    this.LastSavedTime == input.LastSavedTime ||
                    (this.LastSavedTime != null &&
                    this.LastSavedTime.Equals(input.LastSavedTime))
                ) && 
                (
                    this.Lines == input.Lines ||
                    (this.Lines != null &&
                    this.Lines.Equals(input.Lines))
                ) && 
                (
                    this.LinkBase == input.LinkBase ||
                    (this.LinkBase != null &&
                    this.LinkBase.Equals(input.LinkBase))
                ) && 
                (
                    this.Manager == input.Manager ||
                    (this.Manager != null &&
                    this.Manager.Equals(input.Manager))
                ) && 
                (
                    this.Notes == input.Notes ||
                    (this.Notes != null &&
                    this.Notes.Equals(input.Notes))
                ) && 
                (
                    this.NumChars == input.NumChars ||
                    (this.NumChars != null &&
                    this.NumChars.Equals(input.NumChars))
                ) && 
                (
                    this.NumPages == input.NumPages ||
                    (this.NumPages != null &&
                    this.NumPages.Equals(input.NumPages))
                ) && 
                (
                    this.NumWords == input.NumWords ||
                    (this.NumWords != null &&
                    this.NumWords.Equals(input.NumWords))
                ) && 
                (
                    this.Paragraphs == input.Paragraphs ||
                    (this.Paragraphs != null &&
                    this.Paragraphs.Equals(input.Paragraphs))
                ) && 
                (
                    this.PresentationTarget == input.PresentationTarget ||
                    (this.PresentationTarget != null &&
                    this.PresentationTarget.Equals(input.PresentationTarget))
                ) && 
                (
                    this.RevisionNumber == input.RevisionNumber ||
                    (this.RevisionNumber != null &&
                    this.RevisionNumber.Equals(input.RevisionNumber))
                ) && 
                (
                    this.SharedDoc == input.SharedDoc ||
                    (this.SharedDoc != null &&
                    this.SharedDoc.Equals(input.SharedDoc))
                ) && 
                (
                    this.Slides == input.Slides ||
                    (this.Slides != null &&
                    this.Slides.Equals(input.Slides))
                ) && 
                (
                    this.Subject == input.Subject ||
                    (this.Subject != null &&
                    this.Subject.Equals(input.Subject))
                ) && 
                (
                    this.Template == input.Template ||
                    (this.Template != null &&
                    this.Template.Equals(input.Template))
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.TotalEditTime == input.TotalEditTime ||
                    (this.TotalEditTime != null &&
                    this.TotalEditTime.Equals(input.TotalEditTime))
                ) && 
                (
                    this.Version == input.Version ||
                    (this.Version != null &&
                    this.Version.Equals(input.Version))
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
                if (this.Author != null)
                    hashCode = hashCode * 59 + this.Author.GetHashCode();
                if (this.Bytes != null)
                    hashCode = hashCode * 59 + this.Bytes.GetHashCode();
                if (this.Category != null)
                    hashCode = hashCode * 59 + this.Category.GetHashCode();
                if (this.Codepage != null)
                    hashCode = hashCode * 59 + this.Codepage.GetHashCode();
                if (this.Comments != null)
                    hashCode = hashCode * 59 + this.Comments.GetHashCode();
                if (this.Company != null)
                    hashCode = hashCode * 59 + this.Company.GetHashCode();
                if (this.ContentStatus != null)
                    hashCode = hashCode * 59 + this.ContentStatus.GetHashCode();
                if (this.ContentType != null)
                    hashCode = hashCode * 59 + this.ContentType.GetHashCode();
                if (this.CreateTime != null)
                    hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.CreatingApplication != null)
                    hashCode = hashCode * 59 + this.CreatingApplication.GetHashCode();
                if (this.Digisig != null)
                    hashCode = hashCode * 59 + this.Digisig.GetHashCode();
                if (this.Encryption != null)
                    hashCode = hashCode * 59 + this.Encryption.GetHashCode();
                if (this.HiddenSlides != null)
                    hashCode = hashCode * 59 + this.HiddenSlides.GetHashCode();
                if (this.Keywords != null)
                    hashCode = hashCode * 59 + this.Keywords.GetHashCode();
                if (this.Language != null)
                    hashCode = hashCode * 59 + this.Language.GetHashCode();
                if (this.LastBackup != null)
                    hashCode = hashCode * 59 + this.LastBackup.GetHashCode();
                if (this.LastPrinted != null)
                    hashCode = hashCode * 59 + this.LastPrinted.GetHashCode();
                if (this.LastSavedBy != null)
                    hashCode = hashCode * 59 + this.LastSavedBy.GetHashCode();
                if (this.LastSavedTime != null)
                    hashCode = hashCode * 59 + this.LastSavedTime.GetHashCode();
                if (this.Lines != null)
                    hashCode = hashCode * 59 + this.Lines.GetHashCode();
                if (this.LinkBase != null)
                    hashCode = hashCode * 59 + this.LinkBase.GetHashCode();
                if (this.Manager != null)
                    hashCode = hashCode * 59 + this.Manager.GetHashCode();
                if (this.Notes != null)
                    hashCode = hashCode * 59 + this.Notes.GetHashCode();
                if (this.NumChars != null)
                    hashCode = hashCode * 59 + this.NumChars.GetHashCode();
                if (this.NumPages != null)
                    hashCode = hashCode * 59 + this.NumPages.GetHashCode();
                if (this.NumWords != null)
                    hashCode = hashCode * 59 + this.NumWords.GetHashCode();
                if (this.Paragraphs != null)
                    hashCode = hashCode * 59 + this.Paragraphs.GetHashCode();
                if (this.PresentationTarget != null)
                    hashCode = hashCode * 59 + this.PresentationTarget.GetHashCode();
                if (this.RevisionNumber != null)
                    hashCode = hashCode * 59 + this.RevisionNumber.GetHashCode();
                if (this.SharedDoc != null)
                    hashCode = hashCode * 59 + this.SharedDoc.GetHashCode();
                if (this.Slides != null)
                    hashCode = hashCode * 59 + this.Slides.GetHashCode();
                if (this.Subject != null)
                    hashCode = hashCode * 59 + this.Subject.GetHashCode();
                if (this.Template != null)
                    hashCode = hashCode * 59 + this.Template.GetHashCode();
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.TotalEditTime != null)
                    hashCode = hashCode * 59 + this.TotalEditTime.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
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
