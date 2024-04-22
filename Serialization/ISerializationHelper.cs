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

namespace Baroque.NovaPoshta.Client.Serialization
{
    /// <summary>
    /// Represents the serialization helper interface
    /// </summary>
    public interface ISerializationHelper
    {
        /// <summary>
        /// Gets serialization content type for http header
        /// </summary>
        string ContentType { get; }

        /// <summary>
        /// Gets content type for request
        /// </summary>
        string Type { get; }

        /// <summary>
        /// Serialize object reference
        /// </summary>
        /// <typeparam name="T">Object type</typeparam>
        /// <param name="data">Object reference</param>
        /// <returns>Serialized object</returns>
        string Serialize<T>(T data);

        /// <summary>
        /// Deserialize object
        /// </summary>
        /// <typeparam name="T">Object type</typeparam>
        /// <param name="data">Data for deserialization</param>
        /// <returns>Deserialized object</returns>
        T Deserialize<T>(string data);
    }
}
