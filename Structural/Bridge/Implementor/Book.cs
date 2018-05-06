namespace Bridge.Implementor
{
    public class Book : IExhibitionResource
    {
        private string _name;
        public string Name { get { return _name; } set { _name = value; } }
        public string ShortDescription => $"{Author} | {Genre}";
        public string LongDescription => Sinopse;

        public string Author { get; set; }
        public string Sinopse { get; set; }
        public string Genre { get; set; }
        public int OtherPropertyNotUsedByTheBridge { get; set; }
    }
}