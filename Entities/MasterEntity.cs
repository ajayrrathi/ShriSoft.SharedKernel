using System.Collections.Generic;

namespace ShriSoft.SharedKernel.Entities
{
    /// <summary>
    /// Master classes can be derived from this class. This class have property as
    /// Id: Primary key, Code: Unique code for the entity which should not be updated for life time once assigned,
    /// Name: Display value for the entity and IsDelete: flag to indicate if value is deleted.
    /// </summary>
    /// <typeparam name="KeyDataType">The data type for the primary key.</typeparam>
    public class MasterEntity<KeyDataType> : BaseEntity<KeyDataType>, IMasterEntity, ISoftDelete
    {
        public virtual string Code { get; set; }
        public virtual string Name { get; set; }
        public virtual bool IsDeleted { get; set; }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return base.GetEqualityComponents();
            yield return Code;
            yield return IsDeleted;
        }
    }
}

