/*
 * OpenAPI definition
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: v0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using SwiftConductor.Client;
using SwiftConductor.Api;

namespace SwiftConductor.Test.Api
{
    /// <summary>
    ///  Class for testing QueueAdminResourceApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class QueueAdminResourceApiTests : IDisposable
    {
        private QueueAdminResourceApi instance;

        public QueueAdminResourceApiTests()
        {
            instance = new QueueAdminResourceApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of QueueAdminResourceApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' QueueAdminResourceApi
            //Assert.IsType<QueueAdminResourceApi>(instance);
        }

        /// <summary>
        /// Test Names
        /// </summary>
        [Fact]
        public void NamesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.Names();
            //Assert.IsType<Dictionary<string, string>>(response);
        }

        /// <summary>
        /// Test Size1
        /// </summary>
        [Fact]
        public void Size1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.Size1();
            //Assert.IsType<Dictionary<string, long>>(response);
        }

        /// <summary>
        /// Test Update1
        /// </summary>
        [Fact]
        public void Update1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string workflowId = null;
            //string taskRefName = null;
            //string status = null;
            //Dictionary<string, Object> requestBody = null;
            //instance.Update1(workflowId, taskRefName, status, requestBody);
        }

        /// <summary>
        /// Test UpdateByTaskId
        /// </summary>
        [Fact]
        public void UpdateByTaskIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string workflowId = null;
            //string taskId = null;
            //string status = null;
            //Dictionary<string, Object> requestBody = null;
            //instance.UpdateByTaskId(workflowId, taskId, status, requestBody);
        }
    }
}
