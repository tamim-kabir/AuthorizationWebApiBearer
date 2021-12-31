namespace ApplicationData.Interfaces
{
    public interface IBaseModel
    {
        int Id { get; set; }
        string Name { get; set; }
        bool IsDeleted { get; set; }
        bool IsActive { get; set; }
    }
}
