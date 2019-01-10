namespace EFTest
{
    public class DataProvider : IDataProvider
    {
        public string Name { get; set; }
        public void Create(dynamic customer) { }
        public void Delete(dynamic customer) { }
        public dynamic Read(string name) { return "Some Customer record"; }
        public void Update(dynamic customer) { }
    }
}
