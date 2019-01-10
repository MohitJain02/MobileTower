namespace EFTest
{
    public interface IDataProvider
    {
        string Name { get; set; }
        void Create(dynamic customer);
        dynamic Read(string name);
        void Update(dynamic customer);
        void Delete(dynamic customer);
    }
}
