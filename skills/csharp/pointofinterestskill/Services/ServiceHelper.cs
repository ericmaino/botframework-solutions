﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license.

using System.Net.Http;
using System.Net.Http.Headers;

namespace PointOfInterestSkill.Services
{
    /// <summary>
    /// Point of Interest skill helper class.
    /// </summary>
    public class ServiceHelper
    {
        private static HttpClient httpClient = new HttpClient();

        /// <summary>
        /// Generate httpClient.
        /// </summary>
        /// <param name="accessToken">API access token.</param>
        /// <returns>Generated httpClient.</returns>
        public static HttpClient GetHttpClient()
        {
            if (!httpClient.DefaultRequestHeaders.Contains("Accept"))
            {
                httpClient.DefaultRequestHeaders.Add("Accept", "application/json");
            }

            return httpClient;
        }
    }
}
