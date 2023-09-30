using System.Collections.Generic;

namespace ShriSoft.SharedKernel.Entities
{
    /// <summary>
    /// This is the base class. All the entities in the project will derive from this class. 
    /// This class will add the primary key column and all the audit columns to entities. 
    /// </summary>
    public abstract class BaseEntity<KeyDataType> : PrimaryKey<KeyDataType>, IBaseEntity
    {
        
        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return base.Key;
        }
    }
}
