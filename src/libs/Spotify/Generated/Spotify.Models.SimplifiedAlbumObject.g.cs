#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Spotify
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct SimplifiedAlbumObject : global::System.IEquatable<SimplifiedAlbumObject>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Spotify.AlbumBase? Base { get; init; }
#else
        public global::Spotify.AlbumBase? Base { get; }
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
            out global::Spotify.AlbumBase? value)
        {
            value = Base;
            return IsBase;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Spotify.AlbumBase PickBase() => IsBase
            ? Base!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Base' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Spotify.SimplifiedAlbumObjectVariant2? SimplifiedAlbumObjectVariant2 { get; init; }
#else
        public global::Spotify.SimplifiedAlbumObjectVariant2? SimplifiedAlbumObjectVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SimplifiedAlbumObjectVariant2))]
#endif
        public bool IsSimplifiedAlbumObjectVariant2 => SimplifiedAlbumObjectVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickSimplifiedAlbumObjectVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Spotify.SimplifiedAlbumObjectVariant2? value)
        {
            value = SimplifiedAlbumObjectVariant2;
            return IsSimplifiedAlbumObjectVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Spotify.SimplifiedAlbumObjectVariant2 PickSimplifiedAlbumObjectVariant2() => IsSimplifiedAlbumObjectVariant2
            ? SimplifiedAlbumObjectVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'SimplifiedAlbumObjectVariant2' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SimplifiedAlbumObject(global::Spotify.AlbumBase value) => new SimplifiedAlbumObject((global::Spotify.AlbumBase?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Spotify.AlbumBase?(SimplifiedAlbumObject @this) => @this.Base;

        /// <summary>
        /// 
        /// </summary>
        public SimplifiedAlbumObject(global::Spotify.AlbumBase? value)
        {
            Base = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static SimplifiedAlbumObject FromBase(global::Spotify.AlbumBase? value) => new SimplifiedAlbumObject(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SimplifiedAlbumObject(global::Spotify.SimplifiedAlbumObjectVariant2 value) => new SimplifiedAlbumObject((global::Spotify.SimplifiedAlbumObjectVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Spotify.SimplifiedAlbumObjectVariant2?(SimplifiedAlbumObject @this) => @this.SimplifiedAlbumObjectVariant2;

        /// <summary>
        /// 
        /// </summary>
        public SimplifiedAlbumObject(global::Spotify.SimplifiedAlbumObjectVariant2? value)
        {
            SimplifiedAlbumObjectVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static SimplifiedAlbumObject FromSimplifiedAlbumObjectVariant2(global::Spotify.SimplifiedAlbumObjectVariant2? value) => new SimplifiedAlbumObject(value);

        /// <summary>
        /// 
        /// </summary>
        public SimplifiedAlbumObject(
            global::Spotify.AlbumBase? @base,
            global::Spotify.SimplifiedAlbumObjectVariant2? simplifiedAlbumObjectVariant2
            )
        {
            Base = @base;
            SimplifiedAlbumObjectVariant2 = simplifiedAlbumObjectVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            SimplifiedAlbumObjectVariant2 as object ??
            Base as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            SimplifiedAlbumObjectVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsSimplifiedAlbumObjectVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Spotify.AlbumBase, TResult>? @base = null,
            global::System.Func<global::Spotify.SimplifiedAlbumObjectVariant2, TResult>? simplifiedAlbumObjectVariant2 = null,
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
            else if (IsSimplifiedAlbumObjectVariant2 && simplifiedAlbumObjectVariant2 != null)
            {
                return simplifiedAlbumObjectVariant2(SimplifiedAlbumObjectVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Spotify.AlbumBase>? @base = null,

            global::System.Action<global::Spotify.SimplifiedAlbumObjectVariant2>? simplifiedAlbumObjectVariant2 = null,
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
            else if (IsSimplifiedAlbumObjectVariant2)
            {
                simplifiedAlbumObjectVariant2?.Invoke(SimplifiedAlbumObjectVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Spotify.AlbumBase>? @base = null,
            global::System.Action<global::Spotify.SimplifiedAlbumObjectVariant2>? simplifiedAlbumObjectVariant2 = null,
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
            else if (IsSimplifiedAlbumObjectVariant2)
            {
                simplifiedAlbumObjectVariant2?.Invoke(SimplifiedAlbumObjectVariant2!);
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
                typeof(global::Spotify.AlbumBase),
                SimplifiedAlbumObjectVariant2,
                typeof(global::Spotify.SimplifiedAlbumObjectVariant2),
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
        public bool Equals(SimplifiedAlbumObject other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Spotify.AlbumBase?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<global::Spotify.SimplifiedAlbumObjectVariant2?>.Default.Equals(SimplifiedAlbumObjectVariant2, other.SimplifiedAlbumObjectVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(SimplifiedAlbumObject obj1, SimplifiedAlbumObject obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<SimplifiedAlbumObject>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(SimplifiedAlbumObject obj1, SimplifiedAlbumObject obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is SimplifiedAlbumObject o && Equals(o);
        }
    }
}
