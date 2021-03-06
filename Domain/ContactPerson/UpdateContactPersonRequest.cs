﻿using System;
using System.Runtime.Serialization;

namespace Baroque.NovaPoshta.Client.Domain.ContactPerson
{
    /// <summary>
    /// Represents 'update' method request of 'ContactPerson' model.
    /// Documentation: https://devcenter.novaposhta.ua/docs/services/557eb8c8a0fe4f02fc455b2d/operations/558297aca0fe4f0adc08ef28
    /// </summary>
    [DataContract]
    public class UpdateContactPersonRequest : BaseRefItem
    {
        /// <summary>
        /// Gets or sets contact person counterparty reference key
        /// </summary>
        [DataMember]
        public Guid CounterpartyRef { get; set; }

        /// <summary>
        /// Gets or sets contact person first name
        /// </summary>
        [DataMember]
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets contact person last name
        /// </summary>
        [DataMember]
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets contact person middle name
        /// </summary>
        [DataMember]
        public string MiddleName { get; set; }

        /// <summary>
        /// Gets or sets contact person phone number
        /// </summary>
        [DataMember]
        public string Phone { get; set; }
    }
}
