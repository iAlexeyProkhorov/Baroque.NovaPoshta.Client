using System;
using System.Runtime.Serialization;

namespace Baroque.NovaPoshta.Client.Domain
{
    /// <summary>
    /// Represents base item with reference key
    /// </summary>
    [DataContract]
    public abstract class BaseRefItem
    {
        /// <summary>
        /// Gets or sets  item unique reference key
        /// </summary>
        [DataMember(Name = "Ref")]
        public Guid Reference { get; set; }
    }
}
