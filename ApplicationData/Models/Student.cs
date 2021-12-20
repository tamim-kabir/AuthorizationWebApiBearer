using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationData.Models
{
    public class Student:IBaseModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public bool IsDeleted { get; set; }
        public bool IsActive { get; set; }
    }
}
