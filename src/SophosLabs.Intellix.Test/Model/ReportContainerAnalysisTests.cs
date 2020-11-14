/* 
 * Static File Analysis API
 *
 * Use this easy service to understand the characteristics of the file your application or service is interacting with. Allowing you to block malware including those in files previously unseen. Helping you avoid zero day attacks.  SophosLabs Intelix passes each submitted file through an array of granular threat detection analyzers composed  of threat deterministic and machine learning models to derive a threat verdict and an intelligence report. Examples of analysis include:  File genetic similarity intersection machine learning analysis, suspicious file attributes machine learning identification, Deep Anti-Virus scanning, industry detection coverage, and a lot more.  The results are available in JSON format, for easy parsing with any programming language, as well as a visually appealing HTML report, ideal for human reading.  You can read more about [SophosLabs Intelix APIs here](/doc/index.html).  #### Billing  You are billed for getting a report. This might happen in the following ways:  * You request a report by file hash. You are billed if SophosLabs can provide you a report. * You submit a file for analysis. You are billed for the submission (pre-paying for the report). You get a job id for the submission.  NOTE: Requests for a report by job id are not billed when the report is provided, as you have already paid at file submit. 
 *
 * OpenAPI spec version: 1.1.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using NUnit.Framework;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using SophosLabs.Intellix.Api;
using SophosLabs.Intellix.Model;
using SophosLabs.Intellix.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace SophosLabs.Intellix.Test
{
    /// <summary>
    ///  Class for testing ReportContainerAnalysis
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class ReportContainerAnalysisTests
    {
        // TODO uncomment below to declare an instance variable for ReportContainerAnalysis
        //private ReportContainerAnalysis instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of ReportContainerAnalysis
            //instance = new ReportContainerAnalysis();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ReportContainerAnalysis
        /// </summary>
        [Test]
        public void ReportContainerAnalysisInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" ReportContainerAnalysis
            //Assert.IsInstanceOfType<ReportContainerAnalysis> (instance, "variable 'instance' is a ReportContainerAnalysis");
        }


        /// <summary>
        /// Test the property 'ChildrenCount'
        /// </summary>
        [Test]
        public void ChildrenCountTest()
        {
            // TODO unit test for the property 'ChildrenCount'
        }

    }

}
