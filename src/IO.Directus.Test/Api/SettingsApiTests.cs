/* 
 * directus.io
 *
 * API for directus.io
 *
 * OpenAPI spec version: 1.1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using IO.Directus.Client;
using IO.Directus.Api;
using IO.Directus.Model;

namespace IO.Directus.Test
{
    /// <summary>
    ///  Class for testing SettingsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class SettingsApiTests
    {
        private SettingsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new SettingsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of SettingsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' SettingsApi
            //Assert.IsInstanceOfType(typeof(SettingsApi), instance, "instance is a SettingsApi");
        }

        
        /// <summary>
        /// Test GetSettings
        /// </summary>
        [Test]
        public void GetSettingsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetSettings();
            //Assert.IsInstanceOf<GetSettings> (response, "response is GetSettings");
        }
        
        /// <summary>
        /// Test GetSettingsFor
        /// </summary>
        [Test]
        public void GetSettingsForTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? collectionName = null;
            //var response = instance.GetSettingsFor(collectionName);
            //Assert.IsInstanceOf<GetSettingsFor> (response, "response is GetSettingsFor");
        }
        
        /// <summary>
        /// Test UpdateSettings
        /// </summary>
        [Test]
        public void UpdateSettingsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? collectionName = null;
            //string customData = null;
            //instance.UpdateSettings(collectionName, customData);
            
        }
        
    }

}
