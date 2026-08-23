#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Spotify
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct PagingPlaylistTrackObject : global::System.IEquatable<PagingPlaylistTrackObject>
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
        public global::Spotify.PagingPlaylistTrackObjectVariant2? PagingPlaylistTrackObjectVariant2 { get; init; }
#else
        public global::Spotify.PagingPlaylistTrackObjectVariant2? PagingPlaylistTrackObjectVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PagingPlaylistTrackObjectVariant2))]
#endif
        public bool IsPagingPlaylistTrackObjectVariant2 => PagingPlaylistTrackObjectVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickPagingPlaylistTrackObjectVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Spotify.PagingPlaylistTrackObjectVariant2? value)
        {
            value = PagingPlaylistTrackObjectVariant2;
            return IsPagingPlaylistTrackObjectVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Spotify.PagingPlaylistTrackObjectVariant2 PickPagingPlaylistTrackObjectVariant2() => IsPagingPlaylistTrackObjectVariant2
            ? PagingPlaylistTrackObjectVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'PagingPlaylistTrackObjectVariant2' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PagingPlaylistTrackObject(global::Spotify.PagingObject value) => new PagingPlaylistTrackObject((global::Spotify.PagingObject?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Spotify.PagingObject?(PagingPlaylistTrackObject @this) => @this.PagingObject;

        /// <summary>
        /// 
        /// </summary>
        public PagingPlaylistTrackObject(global::Spotify.PagingObject? value)
        {
            PagingObject = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static PagingPlaylistTrackObject FromPagingObject(global::Spotify.PagingObject? value) => new PagingPlaylistTrackObject(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PagingPlaylistTrackObject(global::Spotify.PagingPlaylistTrackObjectVariant2 value) => new PagingPlaylistTrackObject((global::Spotify.PagingPlaylistTrackObjectVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Spotify.PagingPlaylistTrackObjectVariant2?(PagingPlaylistTrackObject @this) => @this.PagingPlaylistTrackObjectVariant2;

        /// <summary>
        /// 
        /// </summary>
        public PagingPlaylistTrackObject(global::Spotify.PagingPlaylistTrackObjectVariant2? value)
        {
            PagingPlaylistTrackObjectVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static PagingPlaylistTrackObject FromPagingPlaylistTrackObjectVariant2(global::Spotify.PagingPlaylistTrackObjectVariant2? value) => new PagingPlaylistTrackObject(value);

        /// <summary>
        /// 
        /// </summary>
        public PagingPlaylistTrackObject(
            global::Spotify.PagingObject? pagingObject,
            global::Spotify.PagingPlaylistTrackObjectVariant2? pagingPlaylistTrackObjectVariant2
            )
        {
            PagingObject = pagingObject;
            PagingPlaylistTrackObjectVariant2 = pagingPlaylistTrackObjectVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            PagingPlaylistTrackObjectVariant2 as object ??
            PagingObject as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            PagingObject?.ToString() ??
            PagingPlaylistTrackObjectVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsPagingObject && IsPagingPlaylistTrackObjectVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Spotify.PagingObject, TResult>? pagingObject = null,
            global::System.Func<global::Spotify.PagingPlaylistTrackObjectVariant2, TResult>? pagingPlaylistTrackObjectVariant2 = null,
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
            else if (IsPagingPlaylistTrackObjectVariant2 && pagingPlaylistTrackObjectVariant2 != null)
            {
                return pagingPlaylistTrackObjectVariant2(PagingPlaylistTrackObjectVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Spotify.PagingObject>? pagingObject = null,

            global::System.Action<global::Spotify.PagingPlaylistTrackObjectVariant2>? pagingPlaylistTrackObjectVariant2 = null,
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
            else if (IsPagingPlaylistTrackObjectVariant2)
            {
                pagingPlaylistTrackObjectVariant2?.Invoke(PagingPlaylistTrackObjectVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Spotify.PagingObject>? pagingObject = null,
            global::System.Action<global::Spotify.PagingPlaylistTrackObjectVariant2>? pagingPlaylistTrackObjectVariant2 = null,
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
            else if (IsPagingPlaylistTrackObjectVariant2)
            {
                pagingPlaylistTrackObjectVariant2?.Invoke(PagingPlaylistTrackObjectVariant2!);
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
                PagingPlaylistTrackObjectVariant2,
                typeof(global::Spotify.PagingPlaylistTrackObjectVariant2),
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
        public bool Equals(PagingPlaylistTrackObject other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Spotify.PagingObject?>.Default.Equals(PagingObject, other.PagingObject) &&
                global::System.Collections.Generic.EqualityComparer<global::Spotify.PagingPlaylistTrackObjectVariant2?>.Default.Equals(PagingPlaylistTrackObjectVariant2, other.PagingPlaylistTrackObjectVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(PagingPlaylistTrackObject obj1, PagingPlaylistTrackObject obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<PagingPlaylistTrackObject>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(PagingPlaylistTrackObject obj1, PagingPlaylistTrackObject obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is PagingPlaylistTrackObject o && Equals(o);
        }
    }
}
