#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Spotify
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct AlbumObject : global::System.IEquatable<AlbumObject>
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
        public global::Spotify.AlbumObjectVariant2? AlbumObjectVariant2 { get; init; }
#else
        public global::Spotify.AlbumObjectVariant2? AlbumObjectVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AlbumObjectVariant2))]
#endif
        public bool IsAlbumObjectVariant2 => AlbumObjectVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAlbumObjectVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Spotify.AlbumObjectVariant2? value)
        {
            value = AlbumObjectVariant2;
            return IsAlbumObjectVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Spotify.AlbumObjectVariant2 PickAlbumObjectVariant2() => IsAlbumObjectVariant2
            ? AlbumObjectVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AlbumObjectVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator AlbumObject(global::Spotify.AlbumBase value) => new AlbumObject((global::Spotify.AlbumBase?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Spotify.AlbumBase?(AlbumObject @this) => @this.Base;

        /// <summary>
        ///
        /// </summary>
        public AlbumObject(global::Spotify.AlbumBase? value)
        {
            Base = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AlbumObject FromBase(global::Spotify.AlbumBase? value) => new AlbumObject(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AlbumObject(global::Spotify.AlbumObjectVariant2 value) => new AlbumObject((global::Spotify.AlbumObjectVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Spotify.AlbumObjectVariant2?(AlbumObject @this) => @this.AlbumObjectVariant2;

        /// <summary>
        ///
        /// </summary>
        public AlbumObject(global::Spotify.AlbumObjectVariant2? value)
        {
            AlbumObjectVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AlbumObject FromAlbumObjectVariant2(global::Spotify.AlbumObjectVariant2? value) => new AlbumObject(value);

        /// <summary>
        ///
        /// </summary>
        public AlbumObject(
            global::Spotify.AlbumBase? @base,
            global::Spotify.AlbumObjectVariant2? albumObjectVariant2
            )
        {
            Base = @base;
            AlbumObjectVariant2 = albumObjectVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            AlbumObjectVariant2 as object ??
            Base as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            AlbumObjectVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsAlbumObjectVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Spotify.AlbumBase, TResult>? @base = null,
            global::System.Func<global::Spotify.AlbumObjectVariant2, TResult>? albumObjectVariant2 = null,
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
            else if (IsAlbumObjectVariant2 && albumObjectVariant2 != null)
            {
                return albumObjectVariant2(AlbumObjectVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Spotify.AlbumBase>? @base = null,

            global::System.Action<global::Spotify.AlbumObjectVariant2>? albumObjectVariant2 = null,
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
            else if (IsAlbumObjectVariant2)
            {
                albumObjectVariant2?.Invoke(AlbumObjectVariant2!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Spotify.AlbumBase>? @base = null,
            global::System.Action<global::Spotify.AlbumObjectVariant2>? albumObjectVariant2 = null,
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
            else if (IsAlbumObjectVariant2)
            {
                albumObjectVariant2?.Invoke(AlbumObjectVariant2!);
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
                AlbumObjectVariant2,
                typeof(global::Spotify.AlbumObjectVariant2),
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
        public bool Equals(AlbumObject other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Spotify.AlbumBase?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<global::Spotify.AlbumObjectVariant2?>.Default.Equals(AlbumObjectVariant2, other.AlbumObjectVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(AlbumObject obj1, AlbumObject obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AlbumObject>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(AlbumObject obj1, AlbumObject obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AlbumObject o && Equals(o);
        }
    }
}
