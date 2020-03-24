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

        /// <summary>
        /// Serves as the default hash function.
        /// </summary>
        /// <returns>Instance hash code</returns>
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        /// <summary>
        ///  Determines whether the specified object is equal to the current object.
        /// </summary>
        /// <param name="obj">The object to compare with the current object.</param>
        /// <returns>'true' if the specified object is equal to the current object; otherwise, 'false'.</returns>
        public override bool Equals(object obj)
        {
            if (obj.GetType() != this.GetType())
                return false;

            var compare = (BaseRefItem)obj;

            return this.Reference == compare.Reference;
        }
    }
}
