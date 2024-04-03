using System.ComponentModel.DataAnnotations.Schema;

namespace CoffeeShop.Application.Common.Entities
{
    public class BaseEntity
    {
        [Column("CREATE_BY")]
        public string? CreateBy { get; set; }
        [Column("CREATE_DATE")]
        public DateTime? CreateDate { get; set; }
        [Column("LT_UPDATE_DATE")]
        public DateTime? LastUpdateDate { get; set; }
        [Column("LT_UPDATE_BY")]
        public string? LasttUpdateBy { get; set; }

        public void SetUpdateInformation(string userId)
        {
            LasttUpdateBy = userId;
            LastUpdateDate = DateTime.UtcNow;
        }

        public void SetCreateInformation(string userId)
        {
            CreateBy = userId;
            CreateDate = DateTime.UtcNow;
        }
    }
}
