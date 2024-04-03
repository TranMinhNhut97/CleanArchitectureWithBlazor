using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoffeeShop.Application.Common.Entities.Mssql

{
    [Table("USERS")]
    public class UserEntity : BaseEntity
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(10)]
        [Column("USERID")]
        public string UserId { get; set; }
        [Required]
        [StringLength(63)]
        [Column("USERNAME")]
        public string UserName { get; set; }
        [Column("PASSW")]
        [StringLength(127)]
        public string PassWord { get; set; }
    }
}
