

namespace DesignPattern.DependencyInjectionPattern
{
    public class Beer
    {
        private readonly string _name;
        private readonly string _brand;

        public string Name
        {
            get
            {
                return _name;
            }
        }
        public Beer(string name, string brand, int a)
        {
            _name = name;
            _brand = brand;
        }
    }
}
