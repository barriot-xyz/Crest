using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crest
{
    public struct Optional<T>
    {
        private readonly T _value;

        /// <summary> 
        ///     Gets the value for this parameter. 
        /// </summary>
        /// <exception cref="InvalidOperationException" accessor="get">This property has no value set.</exception>
        public T Value
        {
            get
            {
                if (!IsSpecified)
                    throw new InvalidOperationException("This property has no value set.");
                return _value;
            }
        }

        /// <summary> 
        ///     Returns true if this value has been specified. 
        /// </summary>
        public bool IsSpecified { get; }

        /// <summary> 
        ///     Creates a new Parameter with the provided value. 
        /// </summary>
        public Optional(T value)
        {
            _value = value;
            IsSpecified = true;
        }

        public static Optional<T> Unspecified
            => default;

        public T GetValueOrDefault() 
            => _value;

        public T GetValueOrDefault(T defaultValue) 
            => IsSpecified 
            ? _value 
            : defaultValue;

        public override int GetHashCode() 
            => IsSpecified 
            ? _value?.GetHashCode() ?? 0
            : 0;

        public override string ToString()
            => IsSpecified
            ? _value?.ToString() 
            ?? string.Empty
            : string.Empty;

        public static implicit operator Optional<T>(T value) 
            => new(value);

        public static explicit operator T(Optional<T> value) 
            => value.Value;
    }

    public static class Optional
    {
        public static Optional<T> Create<T>() 
            => Optional<T>.Unspecified;

        public static Optional<T> Create<T>(T value) 
            => new(value);

        public static T? ToNullable<T>(this Optional<T> val)
            where T : struct
            => val.IsSpecified ? val.Value : null;
    }
}
