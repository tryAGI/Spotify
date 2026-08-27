#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Spotify
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct PagingArtistDiscographyAlbumObject : global::System.IEquatable<PagingArtistDiscographyAlbumObject>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Spotify.PagingObject? PagingObject { get; init; }
#else
        public global::Spotify.PagingObject? PagingObject { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PagingObject))]
#endif
        public bool IsPagingObject => PagingObject != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickPagingObject(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Spotify.PagingObject? value)
        {
            value = PagingObject;
            return IsPagingObject;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Spotify.PagingObject PickPagingObject() => IsPagingObject
            ? PagingObject!
            : throw new global::System.InvalidOperationException($"Expected union variant 'PagingObject' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Spotify.PagingArtistDiscographyAlbumObjectVariant2? PagingArtistDiscographyAlbumObjectVariant2 { get; init; }
#else
        public global::Spotify.PagingArtistDiscographyAlbumObjectVariant2? PagingArtistDiscographyAlbumObjectVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PagingArtistDiscographyAlbumObjectVariant2))]
#endif
        public bool IsPagingArtistDiscographyAlbumObjectVariant2 => PagingArtistDiscographyAlbumObjectVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickPagingArtistDiscographyAlbumObjectVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Spotify.PagingArtistDiscographyAlbumObjectVariant2? value)
        {
            value = PagingArtistDiscographyAlbumObjectVariant2;
            return IsPagingArtistDiscographyAlbumObjectVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Spotify.PagingArtistDiscographyAlbumObjectVariant2 PickPagingArtistDiscographyAlbumObjectVariant2() => IsPagingArtistDiscographyAlbumObjectVariant2
            ? PagingArtistDiscographyAlbumObjectVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'PagingArtistDiscographyAlbumObjectVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator PagingArtistDiscographyAlbumObject(global::Spotify.PagingObject value) => new PagingArtistDiscographyAlbumObject((global::Spotify.PagingObject?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Spotify.PagingObject?(PagingArtistDiscographyAlbumObject @this) => @this.PagingObject;

        /// <summary>
        ///
        /// </summary>
        public PagingArtistDiscographyAlbumObject(global::Spotify.PagingObject? value)
        {
            PagingObject = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static PagingArtistDiscographyAlbumObject FromPagingObject(global::Spotify.PagingObject? value) => new PagingArtistDiscographyAlbumObject(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator PagingArtistDiscographyAlbumObject(global::Spotify.PagingArtistDiscographyAlbumObjectVariant2 value) => new PagingArtistDiscographyAlbumObject((global::Spotify.PagingArtistDiscographyAlbumObjectVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Spotify.PagingArtistDiscographyAlbumObjectVariant2?(PagingArtistDiscographyAlbumObject @this) => @this.PagingArtistDiscographyAlbumObjectVariant2;

        /// <summary>
        ///
        /// </summary>
        public PagingArtistDiscographyAlbumObject(global::Spotify.PagingArtistDiscographyAlbumObjectVariant2? value)
        {
            PagingArtistDiscographyAlbumObjectVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static PagingArtistDiscographyAlbumObject FromPagingArtistDiscographyAlbumObjectVariant2(global::Spotify.PagingArtistDiscographyAlbumObjectVariant2? value) => new PagingArtistDiscographyAlbumObject(value);

        /// <summary>
        ///
        /// </summary>
        public PagingArtistDiscographyAlbumObject(
            global::Spotify.PagingObject? pagingObject,
            global::Spotify.PagingArtistDiscographyAlbumObjectVariant2? pagingArtistDiscographyAlbumObjectVariant2
            )
        {
            PagingObject = pagingObject;
            PagingArtistDiscographyAlbumObjectVariant2 = pagingArtistDiscographyAlbumObjectVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            PagingArtistDiscographyAlbumObjectVariant2 as object ??
            PagingObject as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            PagingObject?.ToString() ??
            PagingArtistDiscographyAlbumObjectVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsPagingObject && IsPagingArtistDiscographyAlbumObjectVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Spotify.PagingObject, TResult>? pagingObject = null,
            global::System.Func<global::Spotify.PagingArtistDiscographyAlbumObjectVariant2, TResult>? pagingArtistDiscographyAlbumObjectVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPagingObject && pagingObject != null)
            {
                return pagingObject(PagingObject!);
            }
            else if (IsPagingArtistDiscographyAlbumObjectVariant2 && pagingArtistDiscographyAlbumObjectVariant2 != null)
            {
                return pagingArtistDiscographyAlbumObjectVariant2(PagingArtistDiscographyAlbumObjectVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Spotify.PagingObject>? pagingObject = null,

            global::System.Action<global::Spotify.PagingArtistDiscographyAlbumObjectVariant2>? pagingArtistDiscographyAlbumObjectVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPagingObject)
            {
                pagingObject?.Invoke(PagingObject!);
            }
            else if (IsPagingArtistDiscographyAlbumObjectVariant2)
            {
                pagingArtistDiscographyAlbumObjectVariant2?.Invoke(PagingArtistDiscographyAlbumObjectVariant2!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Spotify.PagingObject>? pagingObject = null,
            global::System.Action<global::Spotify.PagingArtistDiscographyAlbumObjectVariant2>? pagingArtistDiscographyAlbumObjectVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPagingObject)
            {
                pagingObject?.Invoke(PagingObject!);
            }
            else if (IsPagingArtistDiscographyAlbumObjectVariant2)
            {
                pagingArtistDiscographyAlbumObjectVariant2?.Invoke(PagingArtistDiscographyAlbumObjectVariant2!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                PagingObject,
                typeof(global::Spotify.PagingObject),
                PagingArtistDiscographyAlbumObjectVariant2,
                typeof(global::Spotify.PagingArtistDiscographyAlbumObjectVariant2),
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
        public bool Equals(PagingArtistDiscographyAlbumObject other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Spotify.PagingObject?>.Default.Equals(PagingObject, other.PagingObject) &&
                global::System.Collections.Generic.EqualityComparer<global::Spotify.PagingArtistDiscographyAlbumObjectVariant2?>.Default.Equals(PagingArtistDiscographyAlbumObjectVariant2, other.PagingArtistDiscographyAlbumObjectVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(PagingArtistDiscographyAlbumObject obj1, PagingArtistDiscographyAlbumObject obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<PagingArtistDiscographyAlbumObject>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(PagingArtistDiscographyAlbumObject obj1, PagingArtistDiscographyAlbumObject obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is PagingArtistDiscographyAlbumObject o && Equals(o);
        }
    }
}
