#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Spotify
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct SimplifiedShowObject : global::System.IEquatable<SimplifiedShowObject>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Spotify.ShowBase? Base { get; init; }
#else
        public global::Spotify.ShowBase? Base { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Base))]
#endif
        public bool IsBase => Base != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBase(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Spotify.ShowBase? value)
        {
            value = Base;
            return IsBase;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Spotify.ShowBase PickBase() => IsBase
            ? Base!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Base' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public object? SimplifiedShowObjectVariant2 { get; init; }
#else
        public object? SimplifiedShowObjectVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SimplifiedShowObjectVariant2))]
#endif
        public bool IsSimplifiedShowObjectVariant2 => SimplifiedShowObjectVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSimplifiedShowObjectVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out object? value)
        {
            value = SimplifiedShowObjectVariant2;
            return IsSimplifiedShowObjectVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object PickSimplifiedShowObjectVariant2() => IsSimplifiedShowObjectVariant2
            ? SimplifiedShowObjectVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'SimplifiedShowObjectVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator SimplifiedShowObject(global::Spotify.ShowBase value) => new SimplifiedShowObject((global::Spotify.ShowBase?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Spotify.ShowBase?(SimplifiedShowObject @this) => @this.Base;

        /// <summary>
        ///
        /// </summary>
        public SimplifiedShowObject(global::Spotify.ShowBase? value)
        {
            Base = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static SimplifiedShowObject FromBase(global::Spotify.ShowBase? value) => new SimplifiedShowObject(value);

        /// <summary>
        ///
        /// </summary>
        public SimplifiedShowObject(
            global::Spotify.ShowBase? @base,
            object? simplifiedShowObjectVariant2
            )
        {
            Base = @base;
            SimplifiedShowObjectVariant2 = simplifiedShowObjectVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            SimplifiedShowObjectVariant2 as object ??
            Base as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            SimplifiedShowObjectVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsSimplifiedShowObjectVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Spotify.ShowBase, TResult>? @base = null,
            global::System.Func<object, TResult>? simplifiedShowObjectVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBase && @base != null)
            {
                return @base(Base!);
            }
            else if (IsSimplifiedShowObjectVariant2 && simplifiedShowObjectVariant2 != null)
            {
                return simplifiedShowObjectVariant2(SimplifiedShowObjectVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Spotify.ShowBase>? @base = null,

            global::System.Action<object>? simplifiedShowObjectVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBase)
            {
                @base?.Invoke(Base!);
            }
            else if (IsSimplifiedShowObjectVariant2)
            {
                simplifiedShowObjectVariant2?.Invoke(SimplifiedShowObjectVariant2!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Spotify.ShowBase>? @base = null,
            global::System.Action<object>? simplifiedShowObjectVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBase)
            {
                @base?.Invoke(Base!);
            }
            else if (IsSimplifiedShowObjectVariant2)
            {
                simplifiedShowObjectVariant2?.Invoke(SimplifiedShowObjectVariant2!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Base,
                typeof(global::Spotify.ShowBase),
                SimplifiedShowObjectVariant2,
                typeof(object),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        ///
        /// </summary>
        public bool Equals(SimplifiedShowObject other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Spotify.ShowBase?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<object?>.Default.Equals(SimplifiedShowObjectVariant2, other.SimplifiedShowObjectVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(SimplifiedShowObject obj1, SimplifiedShowObject obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<SimplifiedShowObject>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(SimplifiedShowObject obj1, SimplifiedShowObject obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is SimplifiedShowObject o && Equals(o);
        }
    }
}
