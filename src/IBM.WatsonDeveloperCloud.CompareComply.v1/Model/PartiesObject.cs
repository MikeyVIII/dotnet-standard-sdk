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

namespace IBM.WatsonDeveloperCloud.CompareComply.v1.Model
{
    /// <summary>
    /// An object listing a party and its corresponding role, including address and contact information if identified.
    /// </summary>
    public class PartiesObject : BaseModel
    {
        /// <summary>
        /// A string identifying the party.
        /// </summary>
        [JsonProperty("party", NullValueHandling = NullValueHandling.Ignore)]
        public string Party { get; set; }
        /// <summary>
        /// A string identifying the party's role.
        /// </summary>
        [JsonProperty("role", NullValueHandling = NullValueHandling.Ignore)]
        public string Role { get; set; }
        /// <summary>
        /// An array listing party addresses.
        /// </summary>
        [JsonProperty("addresses", NullValueHandling = NullValueHandling.Ignore)]
        public List<AddressObject> Addresses { get; set; }
        /// <summary>
        /// An array listing party contact information.
        /// </summary>
        [JsonProperty("contacts", NullValueHandling = NullValueHandling.Ignore)]
        public List<ContactObject> Contacts { get; set; }
    }

}
