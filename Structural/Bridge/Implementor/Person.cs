namespace Bridge.Implementor
{
    public class Person : IExhibitionResource
    {
        private string _name;
        public string Name { get { return _name; } set { _name = value; } }

        public string ShortDescription => LastJobTitle;
        public string LongDescription => Resume;

        public string LastJobTitle { get; set; }
        public string Resume { get; set; }
    }
}