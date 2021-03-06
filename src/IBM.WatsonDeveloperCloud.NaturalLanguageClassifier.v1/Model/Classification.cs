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

using System.Collections.Generic;
using Newtonsoft.Json;

namespace IBM.WatsonDeveloperCloud.NaturalLanguageClassifier.v1.Model
{
    /// <summary>
    /// Response from the classifier for a phrase.
    /// </summary>
    public class Classification : BaseModel
    {
        /// <summary>
        /// Unique identifier for this classifier.
        /// </summary>
        [JsonProperty("classifier_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ClassifierId { get; set; }
        /// <summary>
        /// Link to the classifier.
        /// </summary>
        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }
        /// <summary>
        /// The submitted phrase.
        /// </summary>
        [JsonProperty("text", NullValueHandling = NullValueHandling.Ignore)]
        public string Text { get; set; }
        /// <summary>
        /// The class with the highest confidence.
        /// </summary>
        [JsonProperty("top_class", NullValueHandling = NullValueHandling.Ignore)]
        public string TopClass { get; set; }
        /// <summary>
        /// An array of up to ten class-confidence pairs sorted in descending order of confidence.
        /// </summary>
        [JsonProperty("classes", NullValueHandling = NullValueHandling.Ignore)]
        public List<ClassifiedClass> Classes { get; set; }
    }

}
