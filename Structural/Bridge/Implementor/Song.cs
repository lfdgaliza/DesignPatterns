namespace Bridge.Implementor
{
    public class Song : IExhibitionResource
    {
        private string _name;
        public string Name { get { return _name; } set { _name = value; } }

        public string ShortDescription => $"\"{Artist}\" - {Genre}";
        public string LongDescription => Lyrics;

        public string Artist { get; set; }
        public string Lyrics { get; set; }
        public string Genre { get; set; }
        public int OtherPropertyNotUsedByTheBridge { get; set; }
    }
}