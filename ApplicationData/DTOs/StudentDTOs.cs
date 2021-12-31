using ApplicationData.Interfaces;

namespace ApplicationData.DTOs
{
    public class StudentDTO : IBaseModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsActive { get; set; }
        public string Age { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string StudentID { get; set; }
    }
}
