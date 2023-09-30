using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace ShriSoft.SharedKernel.Entities
{
    /// <summary>
    /// Add Created by Audit field to the class.
    /// </summary>
    /// <typeparam name="TForeginKeyDataType">The data type for Id</typeparam>
    public interface ILogCreatedByAuditField<TForeginKeyDataType> {
        /// <summary>
        /// Audit field. This field will store the Id of the user who have added the entity. 
        /// </summary>
        [ScaffoldColumn(false)]
        abstract PrimaryKey<TForeginKeyDataType> CreatedById { get; set; }
    }

    /// <summary>
    /// Added Created on audit field. 
    /// </summary>
    /// <typeparam name="TDateType">Data type for Created on.</typeparam>
    public interface ILogCreatedOnAuditField<TDateType>
    {
        /// <summary>
        /// Audit Field. This field will store the date the entity detials was created.
        /// </summary>
        [ScaffoldColumn(false)]
        abstract TDateType CreatedOn { get; set; }
    }

    public interface ILogUpdatedByAuditField<TForeginKeyDataType> 
    {
        /// <summary>
        /// Audit Field. This field will store Id of the user who have modified it last. 
        /// </summary>
        [ScaffoldColumn(false)]
        abstract PrimaryKey<TForeginKeyDataType> UpdatedByID { get; set; }
        
    }
    public interface ILogUpdatedOnAuditField<TDateType>
    {
        /// <summary>
        /// Audit Field. This field will store the last modified date for the entity record. 
        /// </summary>
        [ScaffoldColumn(false)]
        abstract TDateType UpdatedOn { get; set; }
    }
    
    public interface ISoftDelete {
        [DefaultValue(false)]
        abstract bool IsDeleted { get; set; }
    }
}

