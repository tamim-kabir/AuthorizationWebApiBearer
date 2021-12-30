using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationData.Models
{
    public class BaseModel : IBaseModel

    {
        public int Id { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsActive { get; set; }
    }
}
