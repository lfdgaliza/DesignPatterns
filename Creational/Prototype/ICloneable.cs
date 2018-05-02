using System;

namespace Prototype
{
    /// <summary>
    /// The default dotnet ICloneable always return an object
    /// So this interface is to avoid casts
    /// </summary>
    public interface ICloneable<T> : ICloneable
    {
         T DeepClone();
    }
}