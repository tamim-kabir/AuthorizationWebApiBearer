using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ApplicationData.Models
{
    public interface IBaseModel
    {
        [Key]
        int Id { get; set; }
        bool IsDeleted { get; set; }
        bool IsActive { get; set; }

    }
}
