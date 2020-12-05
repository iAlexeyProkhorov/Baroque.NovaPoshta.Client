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

using System;
using System.Runtime.Serialization;

namespace Baroque.NovaPoshta.Client.Domain.Documents
{
    /// <summary>
    /// Represents document redirection claim creation request.
    /// Documentation: https://devcenter.novaposhta.ua/docs/services/58f722b3ff2c200c04673bd1/operations/58f72344ff2c200c04673bd3
    /// </summary>
    [DataContract]
    public class CreateRedirectionClaimRequest
    {
        /// <summary>
        /// Gets or sets constant "orderRedirecting"
        /// </summary>
        [DataMember]
        public string OrderType { get; set; } = "orderRedirecting";

        /// <summary>
        /// Gets or sets document tracking number
        /// </summary>
        [DataMember]
        public string IntDocNumber { get; set; }

        /// <summary>
        /// Gets or sets redirection customer reference. 'Sender' - constant.
        /// </summary>
        [DataMember]
        public string Customer { get; set; } = "Sender";

        /// <summary>
        /// Gets or sets service type: DoorsWarehouse or WarehouseWarehouse
        /// </summary>
        [DataMember]
        public string ServiceType { get; set; } = "WarehouseWarehouse";

        /// <summary>
        /// Gets or sets recipeint city reference key
        /// </summary>
        [DataMember]
        public Guid RecipientSettlement { get; set; }

        /// <summary>
        /// Gets or sets recipeint settlement street name
        /// </summary>
        [DataMember]
        public string RecipientSettlementStreet { get; set; }

        /// <summary>
        /// Gets or sets house number
        /// </summary>
        [DataMember]
        public string BuildingNumber { get; set; }

        /// <summary>
        /// Gets or sets address comment
        /// </summary>
        [DataMember]
        public string NoteAddressRecipient { get; set; }

        /// <summary>
        /// Gets or sets recipient warehouse reference key
        /// </summary>
        [DataMember]
        public Guid RecipientWarehouse { get; set; }

        /// <summary>
        /// Gets or sets recipient contractor reference key
        /// </summary>
        [DataMember]
        public Guid Recipient { get; set; }

        /// <summary>
        /// Gets or sets recipeint contact person full name
        /// </summary>
        [DataMember]
        public string RecipientContactName { get; set; }

        /// <summary>
        /// Gets or sets recipeint phone number
        /// </summary>
        [DataMember]
        public string RecipientPhone { get; set; }

        /// <summary>
        /// Gets or sets payer type reference key
        /// </summary>
        [DataMember]
        public string PayerType { get; set; }

        /// <summary>
        /// Gets or sets payment method reference key
        /// </summary>
        [DataMember]
        public string PaymentMethod { get; set; }

        /// <summary>
        /// Gets or sets redirection reason
        /// </summary>
        [DataMember]
        public string Note { get; set; }
    }
}
