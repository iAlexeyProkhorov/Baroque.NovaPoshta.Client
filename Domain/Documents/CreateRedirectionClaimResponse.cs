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

using System.Runtime.Serialization;

namespace Baroque.NovaPoshta.Client.Domain.Documents
{
    /// <summary>
    /// Represents document redirection claim creation response.
    /// Documentation: https://devcenter.novaposhta.ua/docs/services/58f722b3ff2c200c04673bd1/operations/58f72344ff2c200c04673bd3
    /// </summary>
    [DataContract]
    public class CreateRedirectionClaimResponse : BaseResponseEnvelope<CreateRedirectionClaimResponse.ResponseItem>
    {
        /// <summary>
        /// Gets or sets request processing errors
        /// </summary>
        [DataMember]
        public string[] Errors { get; set; } = new string[0];

        /// <summary>
        /// Represents document redirection claim response item
        /// </summary>
        [DataContract]
        public class ResponseItem : BaseRefItem
        {
            /// <summary>
            /// Gets or sets redirection claim number
            /// </summary>
            [DataMember]
            public string Number { get; set; }
        }
    }
}
