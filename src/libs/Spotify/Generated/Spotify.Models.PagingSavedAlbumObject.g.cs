#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Spotify
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct PagingSavedAlbumObject : global::System.IEquatable<PagingSavedAlbumObject>
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
        public global::Spotify.PagingSavedAlbumObjectVariant2? PagingSavedAlbumObjectVariant2 { get; init; }
#else
        public global::Spotify.PagingSavedAlbumObjectVariant2? PagingSavedAlbumObjectVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PagingSavedAlbumObjectVariant2))]
#endif
        public bool IsPagingSavedAlbumObjectVariant2 => PagingSavedAlbumObjectVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickPagingSavedAlbumObjectVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Spotify.PagingSavedAlbumObjectVariant2? value)
        {
            value = PagingSavedAlbumObjectVariant2;
            return IsPagingSavedAlbumObjectVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Spotify.PagingSavedAlbumObjectVariant2 PickPagingSavedAlbumObjectVariant2() => IsPagingSavedAlbumObjectVariant2
            ? PagingSavedAlbumObjectVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'PagingSavedAlbumObjectVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator PagingSavedAlbumObject(global::Spotify.PagingObject value) => new PagingSavedAlbumObject((global::Spotify.PagingObject?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Spotify.PagingObject?(PagingSavedAlbumObject @this) => @this.PagingObject;

        /// <summary>
        ///
        /// </summary>
        public PagingSavedAlbumObject(global::Spotify.PagingObject? value)
        {
            PagingObject = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static PagingSavedAlbumObject FromPagingObject(global::Spotify.PagingObject? value) => new PagingSavedAlbumObject(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator PagingSavedAlbumObject(global::Spotify.PagingSavedAlbumObjectVariant2 value) => new PagingSavedAlbumObject((global::Spotify.PagingSavedAlbumObjectVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Spotify.PagingSavedAlbumObjectVariant2?(PagingSavedAlbumObject @this) => @this.PagingSavedAlbumObjectVariant2;

        /// <summary>
        ///
        /// </summary>
        public PagingSavedAlbumObject(global::Spotify.PagingSavedAlbumObjectVariant2? value)
        {
            PagingSavedAlbumObjectVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static PagingSavedAlbumObject FromPagingSavedAlbumObjectVariant2(global::Spotify.PagingSavedAlbumObjectVariant2? value) => new PagingSavedAlbumObject(value);

        /// <summary>
        ///
        /// </summary>
        public PagingSavedAlbumObject(
            global::Spotify.PagingObject? pagingObject,
            global::Spotify.PagingSavedAlbumObjectVariant2? pagingSavedAlbumObjectVariant2
            )
        {
            PagingObject = pagingObject;
            PagingSavedAlbumObjectVariant2 = pagingSavedAlbumObjectVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            PagingSavedAlbumObjectVariant2 as object ??
            PagingObject as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            PagingObject?.ToString() ??
            PagingSavedAlbumObjectVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsPagingObject && IsPagingSavedAlbumObjectVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Spotify.PagingObject, TResult>? pagingObject = null,
            global::System.Func<global::Spotify.PagingSavedAlbumObjectVariant2, TResult>? pagingSavedAlbumObjectVariant2 = null,
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
            else if (IsPagingSavedAlbumObjectVariant2 && pagingSavedAlbumObjectVariant2 != null)
            {
                return pagingSavedAlbumObjectVariant2(PagingSavedAlbumObjectVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Spotify.PagingObject>? pagingObject = null,

            global::System.Action<global::Spotify.PagingSavedAlbumObjectVariant2>? pagingSavedAlbumObjectVariant2 = null,
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
            else if (IsPagingSavedAlbumObjectVariant2)
            {
                pagingSavedAlbumObjectVariant2?.Invoke(PagingSavedAlbumObjectVariant2!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Spotify.PagingObject>? pagingObject = null,
            global::System.Action<global::Spotify.PagingSavedAlbumObjectVariant2>? pagingSavedAlbumObjectVariant2 = null,
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
            else if (IsPagingSavedAlbumObjectVariant2)
            {
                pagingSavedAlbumObjectVariant2?.Invoke(PagingSavedAlbumObjectVariant2!);
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
                PagingSavedAlbumObjectVariant2,
                typeof(global::Spotify.PagingSavedAlbumObjectVariant2),
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
        public bool Equals(PagingSavedAlbumObject other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Spotify.PagingObject?>.Default.Equals(PagingObject, other.PagingObject) &&
                global::System.Collections.Generic.EqualityComparer<global::Spotify.PagingSavedAlbumObjectVariant2?>.Default.Equals(PagingSavedAlbumObjectVariant2, other.PagingSavedAlbumObjectVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(PagingSavedAlbumObject obj1, PagingSavedAlbumObject obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<PagingSavedAlbumObject>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(PagingSavedAlbumObject obj1, PagingSavedAlbumObject obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is PagingSavedAlbumObject o && Equals(o);
        }
    }
}
