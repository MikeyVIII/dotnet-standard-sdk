/**
* Copyright 2018 IBM Corp. All Rights Reserved.
*
* Licensed under the Apache License, Version 2.0 (the "License");
* you may not use this file except in compliance with the License.
* You may obtain a copy of the License at
*
*      http://www.apache.org/licenses/LICENSE-2.0
*
* Unless required by applicable law or agreed to in writing, software
* distributed under the License is distributed on an "AS IS" BASIS,
* WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
* See the License for the specific language governing permissions and
* limitations under the License.
*
*/

using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace IBM.WatsonDeveloperCloud.CompareComply.v1.Model
{
    /// <summary>
    /// A JSON object describing the batch-request status.
    /// </summary>
    public class BatchStatusModel : BaseModel
    {
        /// <summary>
        /// Gets or Sets Function
        /// </summary>
        [JsonProperty("function", NullValueHandling = NullValueHandling.Ignore)]
        public string Function { get; set; }
        /// <summary>
        /// Gets or Sets InputBucketLocation
        /// </summary>
        [JsonProperty("input_bucket_location", NullValueHandling = NullValueHandling.Ignore)]
        public string InputBucketLocation { get; set; }
        /// <summary>
        /// Gets or Sets InputBucketName
        /// </summary>
        [JsonProperty("input_bucket_name", NullValueHandling = NullValueHandling.Ignore)]
        public string InputBucketName { get; set; }
        /// <summary>
        /// Gets or Sets OutputBucketLocation
        /// </summary>
        [JsonProperty("output_bucket_location", NullValueHandling = NullValueHandling.Ignore)]
        public string OutputBucketLocation { get; set; }
        /// <summary>
        /// Gets or Sets OutputBucketName
        /// </summary>
        [JsonProperty("output_bucket_name", NullValueHandling = NullValueHandling.Ignore)]
        public string OutputBucketName { get; set; }
        /// <summary>
        /// Gets or Sets BatchId
        /// </summary>
        [JsonProperty("batch_id", NullValueHandling = NullValueHandling.Ignore)]
        public string BatchId { get; set; }
        /// <summary>
        /// Gets or Sets DocumentCounts
        /// </summary>
        [JsonProperty("document_counts", NullValueHandling = NullValueHandling.Ignore)]
        public List<DocCounts> DocumentCounts { get; set; }
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }
        /// <summary>
        /// Gets or Sets Created
        /// </summary>
        [JsonProperty("created", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? Created { get; set; }
        /// <summary>
        /// Gets or Sets Updated
        /// </summary>
        [JsonProperty("updated", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? Updated { get; set; }
    }

}
