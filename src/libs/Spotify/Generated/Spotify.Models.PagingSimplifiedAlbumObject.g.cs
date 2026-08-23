#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Spotify
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct PagingSimplifiedAlbumObject : global::System.IEquatable<PagingSimplifiedAlbumObject>
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
        public global::Spotify.PagingSimplifiedAlbumObjectVariant2? PagingSimplifiedAlbumObjectVariant2 { get; init; }
#else
        public global::Spotify.PagingSimplifiedAlbumObjectVariant2? PagingSimplifiedAlbumObjectVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PagingSimplifiedAlbumObjectVariant2))]
#endif
        public bool IsPagingSimplifiedAlbumObjectVariant2 => PagingSimplifiedAlbumObjectVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickPagingSimplifiedAlbumObjectVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Spotify.PagingSimplifiedAlbumObjectVariant2? value)
        {
            value = PagingSimplifiedAlbumObjectVariant2;
            return IsPagingSimplifiedAlbumObjectVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Spotify.PagingSimplifiedAlbumObjectVariant2 PickPagingSimplifiedAlbumObjectVariant2() => IsPagingSimplifiedAlbumObjectVariant2
            ? PagingSimplifiedAlbumObjectVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'PagingSimplifiedAlbumObjectVariant2' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PagingSimplifiedAlbumObject(global::Spotify.PagingObject value) => new PagingSimplifiedAlbumObject((global::Spotify.PagingObject?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Spotify.PagingObject?(PagingSimplifiedAlbumObject @this) => @this.PagingObject;

        /// <summary>
        /// 
        /// </summary>
        public PagingSimplifiedAlbumObject(global::Spotify.PagingObject? value)
        {
            PagingObject = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static PagingSimplifiedAlbumObject FromPagingObject(global::Spotify.PagingObject? value) => new PagingSimplifiedAlbumObject(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PagingSimplifiedAlbumObject(global::Spotify.PagingSimplifiedAlbumObjectVariant2 value) => new PagingSimplifiedAlbumObject((global::Spotify.PagingSimplifiedAlbumObjectVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Spotify.PagingSimplifiedAlbumObjectVariant2?(PagingSimplifiedAlbumObject @this) => @this.PagingSimplifiedAlbumObjectVariant2;

        /// <summary>
        /// 
        /// </summary>
        public PagingSimplifiedAlbumObject(global::Spotify.PagingSimplifiedAlbumObjectVariant2? value)
        {
            PagingSimplifiedAlbumObjectVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static PagingSimplifiedAlbumObject FromPagingSimplifiedAlbumObjectVariant2(global::Spotify.PagingSimplifiedAlbumObjectVariant2? value) => new PagingSimplifiedAlbumObject(value);

        /// <summary>
        /// 
        /// </summary>
        public PagingSimplifiedAlbumObject(
            global::Spotify.PagingObject? pagingObject,
            global::Spotify.PagingSimplifiedAlbumObjectVariant2? pagingSimplifiedAlbumObjectVariant2
            )
        {
            PagingObject = pagingObject;
            PagingSimplifiedAlbumObjectVariant2 = pagingSimplifiedAlbumObjectVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            PagingSimplifiedAlbumObjectVariant2 as object ??
            PagingObject as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            PagingObject?.ToString() ??
            PagingSimplifiedAlbumObjectVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsPagingObject && IsPagingSimplifiedAlbumObjectVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Spotify.PagingObject, TResult>? pagingObject = null,
            global::System.Func<global::Spotify.PagingSimplifiedAlbumObjectVariant2, TResult>? pagingSimplifiedAlbumObjectVariant2 = null,
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
            else if (IsPagingSimplifiedAlbumObjectVariant2 && pagingSimplifiedAlbumObjectVariant2 != null)
            {
                return pagingSimplifiedAlbumObjectVariant2(PagingSimplifiedAlbumObjectVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Spotify.PagingObject>? pagingObject = null,

            global::System.Action<global::Spotify.PagingSimplifiedAlbumObjectVariant2>? pagingSimplifiedAlbumObjectVariant2 = null,
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
            else if (IsPagingSimplifiedAlbumObjectVariant2)
            {
                pagingSimplifiedAlbumObjectVariant2?.Invoke(PagingSimplifiedAlbumObjectVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Spotify.PagingObject>? pagingObject = null,
            global::System.Action<global::Spotify.PagingSimplifiedAlbumObjectVariant2>? pagingSimplifiedAlbumObjectVariant2 = null,
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
            else if (IsPagingSimplifiedAlbumObjectVariant2)
            {
                pagingSimplifiedAlbumObjectVariant2?.Invoke(PagingSimplifiedAlbumObjectVariant2!);
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
                PagingSimplifiedAlbumObjectVariant2,
                typeof(global::Spotify.PagingSimplifiedAlbumObjectVariant2),
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
        public bool Equals(PagingSimplifiedAlbumObject other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Spotify.PagingObject?>.Default.Equals(PagingObject, other.PagingObject) &&
                global::System.Collections.Generic.EqualityComparer<global::Spotify.PagingSimplifiedAlbumObjectVariant2?>.Default.Equals(PagingSimplifiedAlbumObjectVariant2, other.PagingSimplifiedAlbumObjectVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(PagingSimplifiedAlbumObject obj1, PagingSimplifiedAlbumObject obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<PagingSimplifiedAlbumObject>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(PagingSimplifiedAlbumObject obj1, PagingSimplifiedAlbumObject obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is PagingSimplifiedAlbumObject o && Equals(o);
        }
    }
}
