//Copyright 2020 Alexey Prokhorov

//Licensed under the Apache License, Version 2.0 (the "License");
//you may not use this file except in compliance with the License.
//You may obtain a copy of the License at

//    http://www.apache.org/licenses/LICENSE-2.0

//Unless required by applicable law or agreed to in writing, software
//distributed under the License is distributed on an "AS IS" BASIS,
//WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//See the License for the specific language governing permissions and
//limitations under the License.

using Newtonsoft.Json;

namespace Baroque.NovaPoshta.Client.Serialization
{
    /// <summary>
    /// Represents JSON serialization helper
    /// </summary>
    public class JsonSerializationHelper : ISerializationHelper
    {
        /// <summary>
        /// Gets serialization content type for http header
        /// </summary>
        public string ContentType { get; protected set; } = "application/json";

        /// <summary>
        /// Gets content type for request
        /// </summary>
        public string Type { get; protected set; } = "json";

        /// <summary>
        /// Serialize object reference
        /// </summary>
        /// <typeparam name="T">Object type</typeparam>
        /// <param name="data">Object reference</param>
        /// <returns>Serialized object</returns>
        public virtual string Serialize<T>(T data)
        {
            var serialized = JsonConvert.SerializeObject(data);
            return serialized;
        }

        /// <summary>
        /// Deserialize object
        /// </summary>
        /// <typeparam name="T">Object type</typeparam>
        /// <param name="data">Data for deserialization</param>
        /// <returns>Deserialized object</returns>
        public virtual T Deserialize<T>(string data)
        {
            var deserialized = JsonConvert.DeserializeObject<T>(data);
            return deserialized;
        }
    }
}
