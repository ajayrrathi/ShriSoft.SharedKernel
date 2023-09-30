using System.ComponentModel.DataAnnotations;

namespace ShriSoft.SharedKernel.Entities
{
    /// <summary>
    /// Primary key for the entities.
    /// </summary>
    /// <typeparam name="TKeyDataType">Data type for the key field</typeparam>
    public abstract class PrimaryKey<TKeyDataType> : ValueObject
    {
        [Key]
        public TKeyDataType Key { get; set; }
    }
}

