using Bridge.Implementor;

namespace Bridge
{
    public static class DataHelper
    {
        public static Book GetBook() => new Book
        {
            Name = "Design Patterns: Elements of Reusable Object-Oriented Software",
            Author = "Erich Gamma, Richard Helm, Ralph Johnson and John Vlissides",
            Sinopse = "Capturing a wealth of experience about the design of object-oriented software, four top-notch designers present a catalog of simple and succinct solutions to commonly occurring design problems. Previously undocumented, these 23 patterns allow designers to create more flexible, elegant, and ultimately reusable designs without having to rediscover the design solutions themselves.",
            Genre = "Software Reuse"
        };

        public static Person GetPerson() => new Person
        {
            Name = "John Doe",
            LastJobTitle = "Developer",
            Resume = "Bacon ipsum dolor amet meatloaf filet mignon shoulder ground round, turducken bresaola ball tip short loin hamburger. Biltong spare ribs buffalo shoulder, pig capicola short ribs ribeye flank fatback tenderloin ball tip andouille brisket pork belly. Porchetta capicola bacon, flank swine pork chop kielbasa meatball prosciutto brisket andouille jowl buffalo. Meatball doner prosciutto pork belly turkey boudin beef ribs swine kevin biltong."
        };

        public static Song GetSong() => new Song
        {
            Name = "With Or Without You",
            Artist = "U2",
            Genre = "Rock",
            Lyrics = @"See the stone set in your eyes
See the thorn twist in your side
I'll wait for you
Sleight of hand and twist of fate
On a bed of nails she makes me wait
And I wait, without you
With or without you
With or without you
Through the storm we reach the shore
You give it all but I want more
And I'm waiting for you
With or without you
With or without you
I can't live
With or without you
And you give yourself away
And you give yourself away
And you give
And you give
And you give yourself away
My hands are tied
My body bruised, she's got me with
Nothing to win and
Nothing left to lose
And you give yourself away
And you give yourself away
And you give
And you give
And you give yourself away
With or without you
With or without you
I can't live
With or without you
Oh
With or without you
With or without you
I can't live
With or without you
With or without you"
        };

    }
}