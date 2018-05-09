using System;

namespace Prototype
{
    public class Book : ICloneable<Book>
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public override string ToString() => $"Book [id={Id}, Name={Name}]";

        public Book(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }

        #region Prototype
        /// <remarks>
        /// Of course that, for now, we have only value types and this kind
        /// of approach for the deep clone is not necessary. But it is here
        /// just for a matter of example and pattern.
        /// </remarks>
        public Book DeepClone() => new Book(this.Id, this.Name);
        object ICloneable.Clone() => this.MemberwiseClone();
        #endregion
    }
}