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
    /// This analysis is similar to the ml_file.analyses.feature_maliciousness analysis, in that it&#x27;s generated in part by a random forest trained on millions of files. Instead of Manalyze features, this random forest is trained on what we call &#x27;PE features&#x27; - all this means is an array of 1024 numbers that describes a given PE file in a specific way, that the data science team has found useful in training models. The deployed PE model also uses these features. A random forest is just a bunch of slightly different decision trees that all take a set of features (for us, the submitted file&#x27;s PE features), and each decide if how malicious the features look like based of a bunch of if-then statements about the features (\&quot;branches\&quot; in each tree). Basically, the features, depending on their values, end up in a \&quot;leaf-node\&quot; of a given decision tree - and that tree&#x27;s suspiciousness score is based on (for us) the number of malware and benignware samples that ended up in the same leaf during training. If a random forest has 64 decision trees, a sample&#x27;s feature will be fed through each of those trees, and each tree outputs a suspiciousness score based on those features. The random forest&#x27;s score is the average of these results. What we&#x27;ve done, is fed millions of known benignware / malware samples through our random forest, and stored the \&quot;leaf-node\&quot; classifications in our elasticsearch cluster. This allows us to help visualize to customers what our random forest is doing by finding files that ended up in many of the same leaf-nodes as a customer&#x27;s submitted sample. While not a complete view of what&#x27;s going on under the surface, this allows customers to see similar files to theirs, their classes (malware or benign), which were used by our random forest to determine if the submitted file is malicious or not. There are three parts to the output of this analysis: 
    /// </summary>
    [DataContract]
    public partial class ReportMlFileAnalysesGeneticAnalysis : IEquatable<ReportMlFileAnalysesGeneticAnalysis>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReportMlFileAnalysesGeneticAnalysis" /> class.
        /// </summary>
        /// <param name="neighborMatrix">This section is a (jsonified) matrix of the submitted file&#x27;s nearest 6 neighbors, in terms of leaf-node similarity. The rows (keys) are the neighbor file&#x27;s sha256 values, while the columns are the leaf-node keys associated with the customer&#x27;s submitted file. The values are boolean: representing if the given neighbor file ended up in the given leaf-node. **example:** {   \&quot;b739c361be0f8375dbb181175cf5073a9e926ee22aadbd308b2482c632dec3d0\&quot;: {     \&quot;23_17879\&quot;: False, \&quot;14_99157\&quot;: True, \&quot;4_12979\&quot;: False, \&quot;21_22551\&quot;: True, \&quot;27_44214\&quot;: True, \&quot;6_14656\&quot;: False, \&quot;25_27907\&quot;: True, \&quot;29_12754\&quot;: True, \&quot;8_39288\&quot;: True, \&quot;17_47209\&quot;: False, \&quot;0_40699\&quot;: True, \&quot;12_24819\&quot;: False, \&quot;26_43036\&quot;: False, \&quot;30_60354\&quot;: False, \&quot;5_66688\&quot;: False, \&quot;13_82129\&quot;: True, \&quot;2_33574\&quot;: False, \&quot;3_10052\&quot;: True, \&quot;18_37075\&quot;: False, \&quot;24_41843\&quot;: True, \&quot;31_38316\&quot;: True, \&quot;15_36399\&quot;: True, \&quot;9_18225\&quot;: True, \&quot;11_61990\&quot;: True, \&quot;1_69193\&quot;: True, \&quot;7_91483\&quot;: True, \&quot;28_11887\&quot;: False, \&quot;16_14225\&quot;: True, \&quot;22_17376\&quot;: True, \&quot;10_30561\&quot;: True, \&quot;19_23298\&quot;: False, \&quot;20_30334\&quot;: True   },   \&quot;d698133b6f9acf6c2105367f817abaa0e4e54578593e6350492b616ae14a179b\&quot;: {     \&quot;23_17879\&quot;: False, \&quot;14_99157\&quot;: True, \&quot;4_12979\&quot;: True, \&quot;21_22551\&quot;: True, \&quot;27_44214\&quot;: True, \&quot;6_14656\&quot;: True, \&quot;25_27907\&quot;: False, \&quot;29_12754\&quot;: True, \&quot;8_39288\&quot;: True, \&quot;17_47209\&quot;: True, \&quot;0_40699\&quot;: False, \&quot;12_24819\&quot;: True, \&quot;26_43036\&quot;: False, \&quot;30_60354\&quot;: False, \&quot;5_66688\&quot;: False, \&quot;13_82129\&quot;: True, \&quot;2_33574\&quot;: True, \&quot;3_10052\&quot;: False, \&quot;18_37075\&quot;: False, \&quot;24_41843\&quot;: True, \&quot;31_38316\&quot;: True, \&quot;15_36399\&quot;: True, \&quot;9_18225\&quot;: True, \&quot;11_61990\&quot;: True, \&quot;1_69193\&quot;: False, \&quot;7_91483\&quot;: True, \&quot;28_11887\&quot;: False, \&quot;16_14225\&quot;: True, \&quot;22_17376\&quot;: False, \&quot;10_30561\&quot;: True, \&quot;19_23298\&quot;: True, \&quot;20_30334\&quot;: True   },   \&quot;9958476410df80b23f66f8d3d5017371eae3b77bb8d3ccdb89736b32391148a1\&quot;: {     \&quot;23_17879\&quot;: False, \&quot;14_99157\&quot;: True, \&quot;4_12979\&quot;: True, \&quot;21_22551\&quot;: True, \&quot;27_44214\&quot;: True, \&quot;6_14656\&quot;: True, \&quot;25_27907\&quot;: False, \&quot;29_12754\&quot;: True, \&quot;8_39288\&quot;: True, \&quot;17_47209\&quot;: True, \&quot;0_40699\&quot;: False, \&quot;12_24819\&quot;: False, \&quot;26_43036\&quot;: True, \&quot;30_60354\&quot;: False, \&quot;5_66688\&quot;: True, \&quot;13_82129\&quot;: True, \&quot;2_33574\&quot;: True, \&quot;3_10052\&quot;: True, \&quot;18_37075\&quot;: False, \&quot;24_41843\&quot;: True, \&quot;31_38316\&quot;: True, \&quot;15_36399\&quot;: True, \&quot;9_18225\&quot;: True, \&quot;11_61990\&quot;: True, \&quot;1_69193\&quot;: False, \&quot;7_91483\&quot;: True, \&quot;28_11887\&quot;: False, \&quot;16_14225\&quot;: True, \&quot;22_17376\&quot;: True, \&quot;10_30561\&quot;: True, \&quot;19_23298\&quot;: False, \&quot;20_30334\&quot;: True   },   \&quot;26b9d56264aec7fb343fefee94eb1f4000a350385659cecf38f783e3718097cc\&quot;: {     \&quot;23_17879\&quot;: True, \&quot;14_99157\&quot;: True, \&quot;4_12979\&quot;: True, \&quot;21_22551\&quot;: True, \&quot;27_44214\&quot;: True, \&quot;6_14656\&quot;: False, \&quot;25_27907\&quot;: False, \&quot;29_12754\&quot;: True, \&quot;8_39288\&quot;: True, \&quot;17_47209\&quot;: False, \&quot;0_40699\&quot;: False, \&quot;12_24819\&quot;: False, \&quot;26_43036\&quot;: True, \&quot;30_60354\&quot;: False, \&quot;5_66688\&quot;: True, \&quot;13_82129\&quot;: True, \&quot;2_33574\&quot;: True, \&quot;3_10052\&quot;: False, \&quot;18_37075\&quot;: True, \&quot;24_41843\&quot;: False, \&quot;31_38316\&quot;: True, \&quot;15_36399\&quot;: True, \&quot;9_18225\&quot;: True, \&quot;11_61990\&quot;: True, \&quot;1_69193\&quot;: True, \&quot;7_91483\&quot;: True, \&quot;28_11887\&quot;: True, \&quot;16_14225\&quot;: True, \&quot;22_17376\&quot;: True, \&quot;10_30561\&quot;: True, \&quot;19_23298\&quot;: False, \&quot;20_30334\&quot;: True   },   \&quot;f2a8f106a3ce781597c62f622798c25b3a57d8f7544be11a02cc1e80b7a9b0ea\&quot;: {     \&quot;23_17879\&quot;: True, \&quot;14_99157\&quot;: True, \&quot;4_12979\&quot;: True, \&quot;21_22551\&quot;: True, \&quot;27_44214\&quot;: False, \&quot;6_14656\&quot;: True, \&quot;25_27907\&quot;: False, \&quot;29_12754\&quot;: True, \&quot;8_39288\&quot;: True, \&quot;17_47209\&quot;: True, \&quot;0_40699\&quot;: False, \&quot;12_24819\&quot;: True, \&quot;26_43036\&quot;: True, \&quot;30_60354\&quot;: False, \&quot;5_66688\&quot;: True, \&quot;13_82129\&quot;: True, \&quot;2_33574\&quot;: True, \&quot;3_10052\&quot;: True, \&quot;18_37075\&quot;: False, \&quot;24_41843\&quot;: True, \&quot;31_38316\&quot;: True, \&quot;15_36399\&quot;: True, \&quot;9_18225\&quot;: True, \&quot;11_61990\&quot;: True, \&quot;1_69193\&quot;: False, \&quot;7_91483\&quot;: True, \&quot;28_11887\&quot;: True, \&quot;16_14225\&quot;: True, \&quot;22_17376\&quot;: True, \&quot;10_30561\&quot;: True, \&quot;19_23298\&quot;: True, \&quot;20_30334\&quot;: True   },   \&quot;bbe5c543824eb69b6f8b53102da5c9c6e7f9d136ce4f066765c37fe8aa34afd7\&quot;: {     \&quot;23_17879\&quot;: True, \&quot;14_99157\&quot;: True, \&quot;4_12979\&quot;: False, \&quot;21_22551\&quot;: True, \&quot;27_44214\&quot;: True, \&quot;6_14656\&quot;: False, \&quot;25_27907\&quot;: False, \&quot;29_12754\&quot;: True, \&quot;8_39288\&quot;: True, \&quot;17_47209\&quot;: True, \&quot;0_40699\&quot;: False, \&quot;12_24819\&quot;: True, \&quot;26_43036\&quot;: False, \&quot;30_60354\&quot;: False, \&quot;5_66688\&quot;: True, \&quot;13_82129\&quot;: True, \&quot;2_33574\&quot;: True, \&quot;3_10052\&quot;: False, \&quot;18_37075\&quot;: False, \&quot;24_41843\&quot;: True, \&quot;31_38316\&quot;: True, \&quot;15_36399\&quot;: True, \&quot;9_18225\&quot;: True, \&quot;11_61990\&quot;: True, \&quot;1_69193\&quot;: True, \&quot;7_91483\&quot;: True, \&quot;28_11887\&quot;: True, \&quot;16_14225\&quot;: True, \&quot;22_17376\&quot;: True, \&quot;10_30561\&quot;: True, \&quot;19_23298\&quot;: False, \&quot;20_30334\&quot;: True   } }  (required).</param>
        /// <param name="neighborInfo">This section simply offers metadata about the neighbors listed in the neighbor_matrix section above. Specifically, this is a dictionary of key-value pairs, where the keys are the neighbor&#x27;s sha256 values, and the values are dictionaries containing the following values:    * is_malware - boolean, class of the file   * score - float, elasticsearch value indicating how close this file is to the customer&#x27;s submitted file in terms of leaf-node classification. Higher &#x3D; more similar.   * match_percentage - float ranging from 0 to 100: the percentage of leaf nodes that this neighbor had in common with the customer&#x27;s submitted file   * filepath - a filepath associated with this file in our database, if it exists. Warning: much of our data comes from VirusTotal, which generally has NULL filepaths. As such, this will often be NULL.  **example:** {   \&quot;b739c361be0f8375dbb181175cf5073a9e926ee22aadbd308b2482c632dec3d0\&quot;: {     \&quot;is_malware\&quot;: False, \&quot;score\&quot;: 209.69632, \&quot;match_percentage\&quot;: 62.5, \&quot;filepath\&quot;: null   },   \&quot;d698133b6f9acf6c2105367f817abaa0e4e54578593e6350492b616ae14a179b\&quot;: {     \&quot;is_malware\&quot;: False, \&quot;score\&quot;: 218.63892, \&quot;match_percentage\&quot;: 65.625, \&quot;filepath\&quot;: null   },   \&quot;9958476410df80b23f66f8d3d5017371eae3b77bb8d3ccdb89736b32391148a1\&quot;: {     \&quot;is_malware\&quot;: False, \&quot;score\&quot;: 241.20938, \&quot;match_percentage\&quot;: 71.875, \&quot;filepath\&quot;: null   },   \&quot;26b9d56264aec7fb343fefee94eb1f4000a350385659cecf38f783e3718097cc\&quot;: {     \&quot;is_malware\&quot;: False, \&quot;score\&quot;: 236.71375, \&quot;match_percentage\&quot;: 71.875, \&quot;filepath\&quot;: null   },   \&quot;f2a8f106a3ce781597c62f622798c25b3a57d8f7544be11a02cc1e80b7a9b0ea\&quot;: {     \&quot;is_malware\&quot;: False, \&quot;score\&quot;: 272.17804, \&quot;match_percentage\&quot;: 81.25, \&quot;filepath\&quot;: null   },   \&quot;bbe5c543824eb69b6f8b53102da5c9c6e7f9d136ce4f066765c37fe8aa34afd7\&quot;: {     \&quot;is_malware\&quot;: False, \&quot;score\&quot;: 233.91748, \&quot;match_percentage\&quot;: 71.875, \&quot;filepath\&quot;: null   } }  (required).</param>
        public ReportMlFileAnalysesGeneticAnalysis(Object neighborMatrix = default(Object), Dictionary<string, string> neighborInfo = null)
        {
            // to ensure "neighborMatrix" is required (not null)
            if (neighborMatrix == null)
            {
                throw new InvalidDataException("neighborMatrix is a required property for ReportMlFileAnalysesGeneticAnalysis and cannot be null");
            }
            else
            {
                this.NeighborMatrix = neighborMatrix;
            }
            // to ensure "neighborInfo" is required (not null)
            if (neighborInfo == null)
            {
                throw new InvalidDataException("neighborInfo is a required property for ReportMlFileAnalysesGeneticAnalysis and cannot be null");
            }
            else
            {
                this.NeighborInfo = neighborInfo;
            }
        }

        /// <summary>
        /// This section is a (jsonified) matrix of the submitted file&#x27;s nearest 6 neighbors, in terms of leaf-node similarity. The rows (keys) are the neighbor file&#x27;s sha256 values, while the columns are the leaf-node keys associated with the customer&#x27;s submitted file. The values are boolean: representing if the given neighbor file ended up in the given leaf-node. **example:** {   \&quot;b739c361be0f8375dbb181175cf5073a9e926ee22aadbd308b2482c632dec3d0\&quot;: {     \&quot;23_17879\&quot;: False, \&quot;14_99157\&quot;: True, \&quot;4_12979\&quot;: False, \&quot;21_22551\&quot;: True, \&quot;27_44214\&quot;: True, \&quot;6_14656\&quot;: False, \&quot;25_27907\&quot;: True, \&quot;29_12754\&quot;: True, \&quot;8_39288\&quot;: True, \&quot;17_47209\&quot;: False, \&quot;0_40699\&quot;: True, \&quot;12_24819\&quot;: False, \&quot;26_43036\&quot;: False, \&quot;30_60354\&quot;: False, \&quot;5_66688\&quot;: False, \&quot;13_82129\&quot;: True, \&quot;2_33574\&quot;: False, \&quot;3_10052\&quot;: True, \&quot;18_37075\&quot;: False, \&quot;24_41843\&quot;: True, \&quot;31_38316\&quot;: True, \&quot;15_36399\&quot;: True, \&quot;9_18225\&quot;: True, \&quot;11_61990\&quot;: True, \&quot;1_69193\&quot;: True, \&quot;7_91483\&quot;: True, \&quot;28_11887\&quot;: False, \&quot;16_14225\&quot;: True, \&quot;22_17376\&quot;: True, \&quot;10_30561\&quot;: True, \&quot;19_23298\&quot;: False, \&quot;20_30334\&quot;: True   },   \&quot;d698133b6f9acf6c2105367f817abaa0e4e54578593e6350492b616ae14a179b\&quot;: {     \&quot;23_17879\&quot;: False, \&quot;14_99157\&quot;: True, \&quot;4_12979\&quot;: True, \&quot;21_22551\&quot;: True, \&quot;27_44214\&quot;: True, \&quot;6_14656\&quot;: True, \&quot;25_27907\&quot;: False, \&quot;29_12754\&quot;: True, \&quot;8_39288\&quot;: True, \&quot;17_47209\&quot;: True, \&quot;0_40699\&quot;: False, \&quot;12_24819\&quot;: True, \&quot;26_43036\&quot;: False, \&quot;30_60354\&quot;: False, \&quot;5_66688\&quot;: False, \&quot;13_82129\&quot;: True, \&quot;2_33574\&quot;: True, \&quot;3_10052\&quot;: False, \&quot;18_37075\&quot;: False, \&quot;24_41843\&quot;: True, \&quot;31_38316\&quot;: True, \&quot;15_36399\&quot;: True, \&quot;9_18225\&quot;: True, \&quot;11_61990\&quot;: True, \&quot;1_69193\&quot;: False, \&quot;7_91483\&quot;: True, \&quot;28_11887\&quot;: False, \&quot;16_14225\&quot;: True, \&quot;22_17376\&quot;: False, \&quot;10_30561\&quot;: True, \&quot;19_23298\&quot;: True, \&quot;20_30334\&quot;: True   },   \&quot;9958476410df80b23f66f8d3d5017371eae3b77bb8d3ccdb89736b32391148a1\&quot;: {     \&quot;23_17879\&quot;: False, \&quot;14_99157\&quot;: True, \&quot;4_12979\&quot;: True, \&quot;21_22551\&quot;: True, \&quot;27_44214\&quot;: True, \&quot;6_14656\&quot;: True, \&quot;25_27907\&quot;: False, \&quot;29_12754\&quot;: True, \&quot;8_39288\&quot;: True, \&quot;17_47209\&quot;: True, \&quot;0_40699\&quot;: False, \&quot;12_24819\&quot;: False, \&quot;26_43036\&quot;: True, \&quot;30_60354\&quot;: False, \&quot;5_66688\&quot;: True, \&quot;13_82129\&quot;: True, \&quot;2_33574\&quot;: True, \&quot;3_10052\&quot;: True, \&quot;18_37075\&quot;: False, \&quot;24_41843\&quot;: True, \&quot;31_38316\&quot;: True, \&quot;15_36399\&quot;: True, \&quot;9_18225\&quot;: True, \&quot;11_61990\&quot;: True, \&quot;1_69193\&quot;: False, \&quot;7_91483\&quot;: True, \&quot;28_11887\&quot;: False, \&quot;16_14225\&quot;: True, \&quot;22_17376\&quot;: True, \&quot;10_30561\&quot;: True, \&quot;19_23298\&quot;: False, \&quot;20_30334\&quot;: True   },   \&quot;26b9d56264aec7fb343fefee94eb1f4000a350385659cecf38f783e3718097cc\&quot;: {     \&quot;23_17879\&quot;: True, \&quot;14_99157\&quot;: True, \&quot;4_12979\&quot;: True, \&quot;21_22551\&quot;: True, \&quot;27_44214\&quot;: True, \&quot;6_14656\&quot;: False, \&quot;25_27907\&quot;: False, \&quot;29_12754\&quot;: True, \&quot;8_39288\&quot;: True, \&quot;17_47209\&quot;: False, \&quot;0_40699\&quot;: False, \&quot;12_24819\&quot;: False, \&quot;26_43036\&quot;: True, \&quot;30_60354\&quot;: False, \&quot;5_66688\&quot;: True, \&quot;13_82129\&quot;: True, \&quot;2_33574\&quot;: True, \&quot;3_10052\&quot;: False, \&quot;18_37075\&quot;: True, \&quot;24_41843\&quot;: False, \&quot;31_38316\&quot;: True, \&quot;15_36399\&quot;: True, \&quot;9_18225\&quot;: True, \&quot;11_61990\&quot;: True, \&quot;1_69193\&quot;: True, \&quot;7_91483\&quot;: True, \&quot;28_11887\&quot;: True, \&quot;16_14225\&quot;: True, \&quot;22_17376\&quot;: True, \&quot;10_30561\&quot;: True, \&quot;19_23298\&quot;: False, \&quot;20_30334\&quot;: True   },   \&quot;f2a8f106a3ce781597c62f622798c25b3a57d8f7544be11a02cc1e80b7a9b0ea\&quot;: {     \&quot;23_17879\&quot;: True, \&quot;14_99157\&quot;: True, \&quot;4_12979\&quot;: True, \&quot;21_22551\&quot;: True, \&quot;27_44214\&quot;: False, \&quot;6_14656\&quot;: True, \&quot;25_27907\&quot;: False, \&quot;29_12754\&quot;: True, \&quot;8_39288\&quot;: True, \&quot;17_47209\&quot;: True, \&quot;0_40699\&quot;: False, \&quot;12_24819\&quot;: True, \&quot;26_43036\&quot;: True, \&quot;30_60354\&quot;: False, \&quot;5_66688\&quot;: True, \&quot;13_82129\&quot;: True, \&quot;2_33574\&quot;: True, \&quot;3_10052\&quot;: True, \&quot;18_37075\&quot;: False, \&quot;24_41843\&quot;: True, \&quot;31_38316\&quot;: True, \&quot;15_36399\&quot;: True, \&quot;9_18225\&quot;: True, \&quot;11_61990\&quot;: True, \&quot;1_69193\&quot;: False, \&quot;7_91483\&quot;: True, \&quot;28_11887\&quot;: True, \&quot;16_14225\&quot;: True, \&quot;22_17376\&quot;: True, \&quot;10_30561\&quot;: True, \&quot;19_23298\&quot;: True, \&quot;20_30334\&quot;: True   },   \&quot;bbe5c543824eb69b6f8b53102da5c9c6e7f9d136ce4f066765c37fe8aa34afd7\&quot;: {     \&quot;23_17879\&quot;: True, \&quot;14_99157\&quot;: True, \&quot;4_12979\&quot;: False, \&quot;21_22551\&quot;: True, \&quot;27_44214\&quot;: True, \&quot;6_14656\&quot;: False, \&quot;25_27907\&quot;: False, \&quot;29_12754\&quot;: True, \&quot;8_39288\&quot;: True, \&quot;17_47209\&quot;: True, \&quot;0_40699\&quot;: False, \&quot;12_24819\&quot;: True, \&quot;26_43036\&quot;: False, \&quot;30_60354\&quot;: False, \&quot;5_66688\&quot;: True, \&quot;13_82129\&quot;: True, \&quot;2_33574\&quot;: True, \&quot;3_10052\&quot;: False, \&quot;18_37075\&quot;: False, \&quot;24_41843\&quot;: True, \&quot;31_38316\&quot;: True, \&quot;15_36399\&quot;: True, \&quot;9_18225\&quot;: True, \&quot;11_61990\&quot;: True, \&quot;1_69193\&quot;: True, \&quot;7_91483\&quot;: True, \&quot;28_11887\&quot;: True, \&quot;16_14225\&quot;: True, \&quot;22_17376\&quot;: True, \&quot;10_30561\&quot;: True, \&quot;19_23298\&quot;: False, \&quot;20_30334\&quot;: True   } } 
        /// </summary>
        /// <value>This section is a (jsonified) matrix of the submitted file&#x27;s nearest 6 neighbors, in terms of leaf-node similarity. The rows (keys) are the neighbor file&#x27;s sha256 values, while the columns are the leaf-node keys associated with the customer&#x27;s submitted file. The values are boolean: representing if the given neighbor file ended up in the given leaf-node. **example:** {   \&quot;b739c361be0f8375dbb181175cf5073a9e926ee22aadbd308b2482c632dec3d0\&quot;: {     \&quot;23_17879\&quot;: False, \&quot;14_99157\&quot;: True, \&quot;4_12979\&quot;: False, \&quot;21_22551\&quot;: True, \&quot;27_44214\&quot;: True, \&quot;6_14656\&quot;: False, \&quot;25_27907\&quot;: True, \&quot;29_12754\&quot;: True, \&quot;8_39288\&quot;: True, \&quot;17_47209\&quot;: False, \&quot;0_40699\&quot;: True, \&quot;12_24819\&quot;: False, \&quot;26_43036\&quot;: False, \&quot;30_60354\&quot;: False, \&quot;5_66688\&quot;: False, \&quot;13_82129\&quot;: True, \&quot;2_33574\&quot;: False, \&quot;3_10052\&quot;: True, \&quot;18_37075\&quot;: False, \&quot;24_41843\&quot;: True, \&quot;31_38316\&quot;: True, \&quot;15_36399\&quot;: True, \&quot;9_18225\&quot;: True, \&quot;11_61990\&quot;: True, \&quot;1_69193\&quot;: True, \&quot;7_91483\&quot;: True, \&quot;28_11887\&quot;: False, \&quot;16_14225\&quot;: True, \&quot;22_17376\&quot;: True, \&quot;10_30561\&quot;: True, \&quot;19_23298\&quot;: False, \&quot;20_30334\&quot;: True   },   \&quot;d698133b6f9acf6c2105367f817abaa0e4e54578593e6350492b616ae14a179b\&quot;: {     \&quot;23_17879\&quot;: False, \&quot;14_99157\&quot;: True, \&quot;4_12979\&quot;: True, \&quot;21_22551\&quot;: True, \&quot;27_44214\&quot;: True, \&quot;6_14656\&quot;: True, \&quot;25_27907\&quot;: False, \&quot;29_12754\&quot;: True, \&quot;8_39288\&quot;: True, \&quot;17_47209\&quot;: True, \&quot;0_40699\&quot;: False, \&quot;12_24819\&quot;: True, \&quot;26_43036\&quot;: False, \&quot;30_60354\&quot;: False, \&quot;5_66688\&quot;: False, \&quot;13_82129\&quot;: True, \&quot;2_33574\&quot;: True, \&quot;3_10052\&quot;: False, \&quot;18_37075\&quot;: False, \&quot;24_41843\&quot;: True, \&quot;31_38316\&quot;: True, \&quot;15_36399\&quot;: True, \&quot;9_18225\&quot;: True, \&quot;11_61990\&quot;: True, \&quot;1_69193\&quot;: False, \&quot;7_91483\&quot;: True, \&quot;28_11887\&quot;: False, \&quot;16_14225\&quot;: True, \&quot;22_17376\&quot;: False, \&quot;10_30561\&quot;: True, \&quot;19_23298\&quot;: True, \&quot;20_30334\&quot;: True   },   \&quot;9958476410df80b23f66f8d3d5017371eae3b77bb8d3ccdb89736b32391148a1\&quot;: {     \&quot;23_17879\&quot;: False, \&quot;14_99157\&quot;: True, \&quot;4_12979\&quot;: True, \&quot;21_22551\&quot;: True, \&quot;27_44214\&quot;: True, \&quot;6_14656\&quot;: True, \&quot;25_27907\&quot;: False, \&quot;29_12754\&quot;: True, \&quot;8_39288\&quot;: True, \&quot;17_47209\&quot;: True, \&quot;0_40699\&quot;: False, \&quot;12_24819\&quot;: False, \&quot;26_43036\&quot;: True, \&quot;30_60354\&quot;: False, \&quot;5_66688\&quot;: True, \&quot;13_82129\&quot;: True, \&quot;2_33574\&quot;: True, \&quot;3_10052\&quot;: True, \&quot;18_37075\&quot;: False, \&quot;24_41843\&quot;: True, \&quot;31_38316\&quot;: True, \&quot;15_36399\&quot;: True, \&quot;9_18225\&quot;: True, \&quot;11_61990\&quot;: True, \&quot;1_69193\&quot;: False, \&quot;7_91483\&quot;: True, \&quot;28_11887\&quot;: False, \&quot;16_14225\&quot;: True, \&quot;22_17376\&quot;: True, \&quot;10_30561\&quot;: True, \&quot;19_23298\&quot;: False, \&quot;20_30334\&quot;: True   },   \&quot;26b9d56264aec7fb343fefee94eb1f4000a350385659cecf38f783e3718097cc\&quot;: {     \&quot;23_17879\&quot;: True, \&quot;14_99157\&quot;: True, \&quot;4_12979\&quot;: True, \&quot;21_22551\&quot;: True, \&quot;27_44214\&quot;: True, \&quot;6_14656\&quot;: False, \&quot;25_27907\&quot;: False, \&quot;29_12754\&quot;: True, \&quot;8_39288\&quot;: True, \&quot;17_47209\&quot;: False, \&quot;0_40699\&quot;: False, \&quot;12_24819\&quot;: False, \&quot;26_43036\&quot;: True, \&quot;30_60354\&quot;: False, \&quot;5_66688\&quot;: True, \&quot;13_82129\&quot;: True, \&quot;2_33574\&quot;: True, \&quot;3_10052\&quot;: False, \&quot;18_37075\&quot;: True, \&quot;24_41843\&quot;: False, \&quot;31_38316\&quot;: True, \&quot;15_36399\&quot;: True, \&quot;9_18225\&quot;: True, \&quot;11_61990\&quot;: True, \&quot;1_69193\&quot;: True, \&quot;7_91483\&quot;: True, \&quot;28_11887\&quot;: True, \&quot;16_14225\&quot;: True, \&quot;22_17376\&quot;: True, \&quot;10_30561\&quot;: True, \&quot;19_23298\&quot;: False, \&quot;20_30334\&quot;: True   },   \&quot;f2a8f106a3ce781597c62f622798c25b3a57d8f7544be11a02cc1e80b7a9b0ea\&quot;: {     \&quot;23_17879\&quot;: True, \&quot;14_99157\&quot;: True, \&quot;4_12979\&quot;: True, \&quot;21_22551\&quot;: True, \&quot;27_44214\&quot;: False, \&quot;6_14656\&quot;: True, \&quot;25_27907\&quot;: False, \&quot;29_12754\&quot;: True, \&quot;8_39288\&quot;: True, \&quot;17_47209\&quot;: True, \&quot;0_40699\&quot;: False, \&quot;12_24819\&quot;: True, \&quot;26_43036\&quot;: True, \&quot;30_60354\&quot;: False, \&quot;5_66688\&quot;: True, \&quot;13_82129\&quot;: True, \&quot;2_33574\&quot;: True, \&quot;3_10052\&quot;: True, \&quot;18_37075\&quot;: False, \&quot;24_41843\&quot;: True, \&quot;31_38316\&quot;: True, \&quot;15_36399\&quot;: True, \&quot;9_18225\&quot;: True, \&quot;11_61990\&quot;: True, \&quot;1_69193\&quot;: False, \&quot;7_91483\&quot;: True, \&quot;28_11887\&quot;: True, \&quot;16_14225\&quot;: True, \&quot;22_17376\&quot;: True, \&quot;10_30561\&quot;: True, \&quot;19_23298\&quot;: True, \&quot;20_30334\&quot;: True   },   \&quot;bbe5c543824eb69b6f8b53102da5c9c6e7f9d136ce4f066765c37fe8aa34afd7\&quot;: {     \&quot;23_17879\&quot;: True, \&quot;14_99157\&quot;: True, \&quot;4_12979\&quot;: False, \&quot;21_22551\&quot;: True, \&quot;27_44214\&quot;: True, \&quot;6_14656\&quot;: False, \&quot;25_27907\&quot;: False, \&quot;29_12754\&quot;: True, \&quot;8_39288\&quot;: True, \&quot;17_47209\&quot;: True, \&quot;0_40699\&quot;: False, \&quot;12_24819\&quot;: True, \&quot;26_43036\&quot;: False, \&quot;30_60354\&quot;: False, \&quot;5_66688\&quot;: True, \&quot;13_82129\&quot;: True, \&quot;2_33574\&quot;: True, \&quot;3_10052\&quot;: False, \&quot;18_37075\&quot;: False, \&quot;24_41843\&quot;: True, \&quot;31_38316\&quot;: True, \&quot;15_36399\&quot;: True, \&quot;9_18225\&quot;: True, \&quot;11_61990\&quot;: True, \&quot;1_69193\&quot;: True, \&quot;7_91483\&quot;: True, \&quot;28_11887\&quot;: True, \&quot;16_14225\&quot;: True, \&quot;22_17376\&quot;: True, \&quot;10_30561\&quot;: True, \&quot;19_23298\&quot;: False, \&quot;20_30334\&quot;: True   } } </value>
        [DataMember(Name = "neighbor_matrix", EmitDefaultValue = false)]
        public Object NeighborMatrix { get; set; }

        /// <summary>
        /// This section simply offers metadata about the neighbors listed in the neighbor_matrix section above. Specifically, this is a dictionary of key-value pairs, where the keys are the neighbor&#x27;s sha256 values, and the values are dictionaries containing the following values:    * is_malware - boolean, class of the file   * score - float, elasticsearch value indicating how close this file is to the customer&#x27;s submitted file in terms of leaf-node classification. Higher &#x3D; more similar.   * match_percentage - float ranging from 0 to 100: the percentage of leaf nodes that this neighbor had in common with the customer&#x27;s submitted file   * filepath - a filepath associated with this file in our database, if it exists. Warning: much of our data comes from VirusTotal, which generally has NULL filepaths. As such, this will often be NULL.  **example:** {   \&quot;b739c361be0f8375dbb181175cf5073a9e926ee22aadbd308b2482c632dec3d0\&quot;: {     \&quot;is_malware\&quot;: False, \&quot;score\&quot;: 209.69632, \&quot;match_percentage\&quot;: 62.5, \&quot;filepath\&quot;: null   },   \&quot;d698133b6f9acf6c2105367f817abaa0e4e54578593e6350492b616ae14a179b\&quot;: {     \&quot;is_malware\&quot;: False, \&quot;score\&quot;: 218.63892, \&quot;match_percentage\&quot;: 65.625, \&quot;filepath\&quot;: null   },   \&quot;9958476410df80b23f66f8d3d5017371eae3b77bb8d3ccdb89736b32391148a1\&quot;: {     \&quot;is_malware\&quot;: False, \&quot;score\&quot;: 241.20938, \&quot;match_percentage\&quot;: 71.875, \&quot;filepath\&quot;: null   },   \&quot;26b9d56264aec7fb343fefee94eb1f4000a350385659cecf38f783e3718097cc\&quot;: {     \&quot;is_malware\&quot;: False, \&quot;score\&quot;: 236.71375, \&quot;match_percentage\&quot;: 71.875, \&quot;filepath\&quot;: null   },   \&quot;f2a8f106a3ce781597c62f622798c25b3a57d8f7544be11a02cc1e80b7a9b0ea\&quot;: {     \&quot;is_malware\&quot;: False, \&quot;score\&quot;: 272.17804, \&quot;match_percentage\&quot;: 81.25, \&quot;filepath\&quot;: null   },   \&quot;bbe5c543824eb69b6f8b53102da5c9c6e7f9d136ce4f066765c37fe8aa34afd7\&quot;: {     \&quot;is_malware\&quot;: False, \&quot;score\&quot;: 233.91748, \&quot;match_percentage\&quot;: 71.875, \&quot;filepath\&quot;: null   } } 
        /// </summary>
        /// <value>This section simply offers metadata about the neighbors listed in the neighbor_matrix section above. Specifically, this is a dictionary of key-value pairs, where the keys are the neighbor&#x27;s sha256 values, and the values are dictionaries containing the following values:    * is_malware - boolean, class of the file   * score - float, elasticsearch value indicating how close this file is to the customer&#x27;s submitted file in terms of leaf-node classification. Higher &#x3D; more similar.   * match_percentage - float ranging from 0 to 100: the percentage of leaf nodes that this neighbor had in common with the customer&#x27;s submitted file   * filepath - a filepath associated with this file in our database, if it exists. Warning: much of our data comes from VirusTotal, which generally has NULL filepaths. As such, this will often be NULL.  **example:** {   \&quot;b739c361be0f8375dbb181175cf5073a9e926ee22aadbd308b2482c632dec3d0\&quot;: {     \&quot;is_malware\&quot;: False, \&quot;score\&quot;: 209.69632, \&quot;match_percentage\&quot;: 62.5, \&quot;filepath\&quot;: null   },   \&quot;d698133b6f9acf6c2105367f817abaa0e4e54578593e6350492b616ae14a179b\&quot;: {     \&quot;is_malware\&quot;: False, \&quot;score\&quot;: 218.63892, \&quot;match_percentage\&quot;: 65.625, \&quot;filepath\&quot;: null   },   \&quot;9958476410df80b23f66f8d3d5017371eae3b77bb8d3ccdb89736b32391148a1\&quot;: {     \&quot;is_malware\&quot;: False, \&quot;score\&quot;: 241.20938, \&quot;match_percentage\&quot;: 71.875, \&quot;filepath\&quot;: null   },   \&quot;26b9d56264aec7fb343fefee94eb1f4000a350385659cecf38f783e3718097cc\&quot;: {     \&quot;is_malware\&quot;: False, \&quot;score\&quot;: 236.71375, \&quot;match_percentage\&quot;: 71.875, \&quot;filepath\&quot;: null   },   \&quot;f2a8f106a3ce781597c62f622798c25b3a57d8f7544be11a02cc1e80b7a9b0ea\&quot;: {     \&quot;is_malware\&quot;: False, \&quot;score\&quot;: 272.17804, \&quot;match_percentage\&quot;: 81.25, \&quot;filepath\&quot;: null   },   \&quot;bbe5c543824eb69b6f8b53102da5c9c6e7f9d136ce4f066765c37fe8aa34afd7\&quot;: {     \&quot;is_malware\&quot;: False, \&quot;score\&quot;: 233.91748, \&quot;match_percentage\&quot;: 71.875, \&quot;filepath\&quot;: null   } } </value>
        [DataMember(Name = "neighbor_info", EmitDefaultValue = false)]
        public Dictionary<string, string> NeighborInfo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReportMlFileAnalysesGeneticAnalysis {\n");
            sb.Append("  NeighborMatrix: ").Append(NeighborMatrix).Append("\n");
            sb.Append("  NeighborInfo: ").Append(NeighborInfo).Append("\n");
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
            return this.Equals(input as ReportMlFileAnalysesGeneticAnalysis);
        }

        /// <summary>
        /// Returns true if ReportMlFileAnalysesGeneticAnalysis instances are equal
        /// </summary>
        /// <param name="input">Instance of ReportMlFileAnalysesGeneticAnalysis to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReportMlFileAnalysesGeneticAnalysis input)
        {
            if (input == null)
                return false;

            return
                (
                    this.NeighborMatrix == input.NeighborMatrix ||
                    (this.NeighborMatrix != null &&
                    this.NeighborMatrix.Equals(input.NeighborMatrix))
                ) &&
                (
                    this.NeighborInfo == input.NeighborInfo ||
                    (this.NeighborInfo != null &&
                    this.NeighborInfo.Equals(input.NeighborInfo))
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
                if (this.NeighborMatrix != null)
                    hashCode = hashCode * 59 + this.NeighborMatrix.GetHashCode();
                if (this.NeighborInfo != null)
                    hashCode = hashCode * 59 + this.NeighborInfo.GetHashCode();
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
