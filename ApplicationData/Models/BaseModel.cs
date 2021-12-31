using ApplicationData.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace ApplicationData.Models
{
    public class BaseModel : IBaseModel
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsActive { get; set; }
    }
}
