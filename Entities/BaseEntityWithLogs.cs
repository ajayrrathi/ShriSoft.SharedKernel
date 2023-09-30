namespace ShriSoft.SharedKernel.Entities
{
    /// <summary>
    /// This class add logs fields to the entity.
    /// </summary>
    /// <typeparam name="TId">The data type of the created by and updated by fields.</typeparam>
    /// <typeparam name="TOn">The data type of the create on and updated on fields.</typeparam>
    public abstract class BaseEntityWithLogs<TId, TOn> : BaseEntity<TId>,
                                                ILogCreatedByAuditField<TId>,
                                                ILogCreatedOnAuditField<TOn>,
                                                ILogUpdatedByAuditField<TId>,
                                                ILogUpdatedOnAuditField<TOn>
    {
        public virtual TOn CreatedOn { get; set; }
        public virtual PrimaryKey<TId> UpdatedByID { get; set; }
        public virtual TOn UpdatedOn { get; set; }
        public virtual PrimaryKey<TId> CreatedById { get; set; }
    }
}

