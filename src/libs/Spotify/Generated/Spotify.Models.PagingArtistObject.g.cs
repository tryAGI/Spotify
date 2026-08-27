#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Spotify
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct PagingArtistObject : global::System.IEquatable<PagingArtistObject>
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
        public global::Spotify.PagingArtistObjectVariant2? PagingArtistObjectVariant2 { get; init; }
#else
        public global::Spotify.PagingArtistObjectVariant2? PagingArtistObjectVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PagingArtistObjectVariant2))]
#endif
        public bool IsPagingArtistObjectVariant2 => PagingArtistObjectVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickPagingArtistObjectVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Spotify.PagingArtistObjectVariant2? value)
        {
            value = PagingArtistObjectVariant2;
            return IsPagingArtistObjectVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Spotify.PagingArtistObjectVariant2 PickPagingArtistObjectVariant2() => IsPagingArtistObjectVariant2
            ? PagingArtistObjectVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'PagingArtistObjectVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator PagingArtistObject(global::Spotify.PagingObject value) => new PagingArtistObject((global::Spotify.PagingObject?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Spotify.PagingObject?(PagingArtistObject @this) => @this.PagingObject;

        /// <summary>
        ///
        /// </summary>
        public PagingArtistObject(global::Spotify.PagingObject? value)
        {
            PagingObject = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static PagingArtistObject FromPagingObject(global::Spotify.PagingObject? value) => new PagingArtistObject(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator PagingArtistObject(global::Spotify.PagingArtistObjectVariant2 value) => new PagingArtistObject((global::Spotify.PagingArtistObjectVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Spotify.PagingArtistObjectVariant2?(PagingArtistObject @this) => @this.PagingArtistObjectVariant2;

        /// <summary>
        ///
        /// </summary>
        public PagingArtistObject(global::Spotify.PagingArtistObjectVariant2? value)
        {
            PagingArtistObjectVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static PagingArtistObject FromPagingArtistObjectVariant2(global::Spotify.PagingArtistObjectVariant2? value) => new PagingArtistObject(value);

        /// <summary>
        ///
        /// </summary>
        public PagingArtistObject(
            global::Spotify.PagingObject? pagingObject,
            global::Spotify.PagingArtistObjectVariant2? pagingArtistObjectVariant2
            )
        {
            PagingObject = pagingObject;
            PagingArtistObjectVariant2 = pagingArtistObjectVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            PagingArtistObjectVariant2 as object ??
            PagingObject as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            PagingObject?.ToString() ??
            PagingArtistObjectVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsPagingObject && IsPagingArtistObjectVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Spotify.PagingObject, TResult>? pagingObject = null,
            global::System.Func<global::Spotify.PagingArtistObjectVariant2, TResult>? pagingArtistObjectVariant2 = null,
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
            else if (IsPagingArtistObjectVariant2 && pagingArtistObjectVariant2 != null)
            {
                return pagingArtistObjectVariant2(PagingArtistObjectVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Spotify.PagingObject>? pagingObject = null,

            global::System.Action<global::Spotify.PagingArtistObjectVariant2>? pagingArtistObjectVariant2 = null,
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
            else if (IsPagingArtistObjectVariant2)
            {
                pagingArtistObjectVariant2?.Invoke(PagingArtistObjectVariant2!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Spotify.PagingObject>? pagingObject = null,
            global::System.Action<global::Spotify.PagingArtistObjectVariant2>? pagingArtistObjectVariant2 = null,
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
            else if (IsPagingArtistObjectVariant2)
            {
                pagingArtistObjectVariant2?.Invoke(PagingArtistObjectVariant2!);
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
                PagingArtistObjectVariant2,
                typeof(global::Spotify.PagingArtistObjectVariant2),
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
        public bool Equals(PagingArtistObject other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Spotify.PagingObject?>.Default.Equals(PagingObject, other.PagingObject) &&
                global::System.Collections.Generic.EqualityComparer<global::Spotify.PagingArtistObjectVariant2?>.Default.Equals(PagingArtistObjectVariant2, other.PagingArtistObjectVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(PagingArtistObject obj1, PagingArtistObject obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<PagingArtistObject>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(PagingArtistObject obj1, PagingArtistObject obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is PagingArtistObject o && Equals(o);
        }
    }
}
