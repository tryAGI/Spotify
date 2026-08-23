#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Spotify
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ArtistDiscographyAlbumObject : global::System.IEquatable<ArtistDiscographyAlbumObject>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Spotify.SimplifiedAlbumObject? Simplified { get; init; }
#else
        public global::Spotify.SimplifiedAlbumObject? Simplified { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Simplified))]
#endif
        public bool IsSimplified => Simplified != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickSimplified(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Spotify.SimplifiedAlbumObject? value)
        {
            value = Simplified;
            return IsSimplified;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Spotify.SimplifiedAlbumObject PickSimplified() => IsSimplified
            ? Simplified!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Simplified' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Spotify.ArtistDiscographyAlbumObjectVariant2? ArtistDiscographyAlbumObjectVariant2 { get; init; }
#else
        public global::Spotify.ArtistDiscographyAlbumObjectVariant2? ArtistDiscographyAlbumObjectVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ArtistDiscographyAlbumObjectVariant2))]
#endif
        public bool IsArtistDiscographyAlbumObjectVariant2 => ArtistDiscographyAlbumObjectVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickArtistDiscographyAlbumObjectVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Spotify.ArtistDiscographyAlbumObjectVariant2? value)
        {
            value = ArtistDiscographyAlbumObjectVariant2;
            return IsArtistDiscographyAlbumObjectVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Spotify.ArtistDiscographyAlbumObjectVariant2 PickArtistDiscographyAlbumObjectVariant2() => IsArtistDiscographyAlbumObjectVariant2
            ? ArtistDiscographyAlbumObjectVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ArtistDiscographyAlbumObjectVariant2' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ArtistDiscographyAlbumObject(global::Spotify.SimplifiedAlbumObject value) => new ArtistDiscographyAlbumObject((global::Spotify.SimplifiedAlbumObject?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Spotify.SimplifiedAlbumObject?(ArtistDiscographyAlbumObject @this) => @this.Simplified;

        /// <summary>
        /// 
        /// </summary>
        public ArtistDiscographyAlbumObject(global::Spotify.SimplifiedAlbumObject? value)
        {
            Simplified = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ArtistDiscographyAlbumObject FromSimplified(global::Spotify.SimplifiedAlbumObject? value) => new ArtistDiscographyAlbumObject(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ArtistDiscographyAlbumObject(global::Spotify.ArtistDiscographyAlbumObjectVariant2 value) => new ArtistDiscographyAlbumObject((global::Spotify.ArtistDiscographyAlbumObjectVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Spotify.ArtistDiscographyAlbumObjectVariant2?(ArtistDiscographyAlbumObject @this) => @this.ArtistDiscographyAlbumObjectVariant2;

        /// <summary>
        /// 
        /// </summary>
        public ArtistDiscographyAlbumObject(global::Spotify.ArtistDiscographyAlbumObjectVariant2? value)
        {
            ArtistDiscographyAlbumObjectVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ArtistDiscographyAlbumObject FromArtistDiscographyAlbumObjectVariant2(global::Spotify.ArtistDiscographyAlbumObjectVariant2? value) => new ArtistDiscographyAlbumObject(value);

        /// <summary>
        /// 
        /// </summary>
        public ArtistDiscographyAlbumObject(
            global::Spotify.SimplifiedAlbumObject? simplified,
            global::Spotify.ArtistDiscographyAlbumObjectVariant2? artistDiscographyAlbumObjectVariant2
            )
        {
            Simplified = simplified;
            ArtistDiscographyAlbumObjectVariant2 = artistDiscographyAlbumObjectVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ArtistDiscographyAlbumObjectVariant2 as object ??
            Simplified as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Simplified?.ToString() ??
            ArtistDiscographyAlbumObjectVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsSimplified && IsArtistDiscographyAlbumObjectVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Spotify.SimplifiedAlbumObject?, TResult>? simplified = null,
            global::System.Func<global::Spotify.ArtistDiscographyAlbumObjectVariant2, TResult>? artistDiscographyAlbumObjectVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSimplified && simplified != null)
            {
                return simplified(Simplified!);
            }
            else if (IsArtistDiscographyAlbumObjectVariant2 && artistDiscographyAlbumObjectVariant2 != null)
            {
                return artistDiscographyAlbumObjectVariant2(ArtistDiscographyAlbumObjectVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Spotify.SimplifiedAlbumObject?>? simplified = null,

            global::System.Action<global::Spotify.ArtistDiscographyAlbumObjectVariant2>? artistDiscographyAlbumObjectVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSimplified)
            {
                simplified?.Invoke(Simplified!);
            }
            else if (IsArtistDiscographyAlbumObjectVariant2)
            {
                artistDiscographyAlbumObjectVariant2?.Invoke(ArtistDiscographyAlbumObjectVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Spotify.SimplifiedAlbumObject?>? simplified = null,
            global::System.Action<global::Spotify.ArtistDiscographyAlbumObjectVariant2>? artistDiscographyAlbumObjectVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSimplified)
            {
                simplified?.Invoke(Simplified!);
            }
            else if (IsArtistDiscographyAlbumObjectVariant2)
            {
                artistDiscographyAlbumObjectVariant2?.Invoke(ArtistDiscographyAlbumObjectVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Simplified,
                typeof(global::Spotify.SimplifiedAlbumObject),
                ArtistDiscographyAlbumObjectVariant2,
                typeof(global::Spotify.ArtistDiscographyAlbumObjectVariant2),
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
        public bool Equals(ArtistDiscographyAlbumObject other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Spotify.SimplifiedAlbumObject?>.Default.Equals(Simplified, other.Simplified) &&
                global::System.Collections.Generic.EqualityComparer<global::Spotify.ArtistDiscographyAlbumObjectVariant2?>.Default.Equals(ArtistDiscographyAlbumObjectVariant2, other.ArtistDiscographyAlbumObjectVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ArtistDiscographyAlbumObject obj1, ArtistDiscographyAlbumObject obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ArtistDiscographyAlbumObject>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ArtistDiscographyAlbumObject obj1, ArtistDiscographyAlbumObject obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ArtistDiscographyAlbumObject o && Equals(o);
        }
    }
}
