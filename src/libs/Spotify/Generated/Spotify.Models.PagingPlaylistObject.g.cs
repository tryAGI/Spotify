#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Spotify
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct PagingPlaylistObject : global::System.IEquatable<PagingPlaylistObject>
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
        public global::Spotify.PagingPlaylistObjectVariant2? PagingPlaylistObjectVariant2 { get; init; }
#else
        public global::Spotify.PagingPlaylistObjectVariant2? PagingPlaylistObjectVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PagingPlaylistObjectVariant2))]
#endif
        public bool IsPagingPlaylistObjectVariant2 => PagingPlaylistObjectVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickPagingPlaylistObjectVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Spotify.PagingPlaylistObjectVariant2? value)
        {
            value = PagingPlaylistObjectVariant2;
            return IsPagingPlaylistObjectVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Spotify.PagingPlaylistObjectVariant2 PickPagingPlaylistObjectVariant2() => IsPagingPlaylistObjectVariant2
            ? PagingPlaylistObjectVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'PagingPlaylistObjectVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator PagingPlaylistObject(global::Spotify.PagingObject value) => new PagingPlaylistObject((global::Spotify.PagingObject?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Spotify.PagingObject?(PagingPlaylistObject @this) => @this.PagingObject;

        /// <summary>
        ///
        /// </summary>
        public PagingPlaylistObject(global::Spotify.PagingObject? value)
        {
            PagingObject = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static PagingPlaylistObject FromPagingObject(global::Spotify.PagingObject? value) => new PagingPlaylistObject(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator PagingPlaylistObject(global::Spotify.PagingPlaylistObjectVariant2 value) => new PagingPlaylistObject((global::Spotify.PagingPlaylistObjectVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Spotify.PagingPlaylistObjectVariant2?(PagingPlaylistObject @this) => @this.PagingPlaylistObjectVariant2;

        /// <summary>
        ///
        /// </summary>
        public PagingPlaylistObject(global::Spotify.PagingPlaylistObjectVariant2? value)
        {
            PagingPlaylistObjectVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static PagingPlaylistObject FromPagingPlaylistObjectVariant2(global::Spotify.PagingPlaylistObjectVariant2? value) => new PagingPlaylistObject(value);

        /// <summary>
        ///
        /// </summary>
        public PagingPlaylistObject(
            global::Spotify.PagingObject? pagingObject,
            global::Spotify.PagingPlaylistObjectVariant2? pagingPlaylistObjectVariant2
            )
        {
            PagingObject = pagingObject;
            PagingPlaylistObjectVariant2 = pagingPlaylistObjectVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            PagingPlaylistObjectVariant2 as object ??
            PagingObject as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            PagingObject?.ToString() ??
            PagingPlaylistObjectVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsPagingObject && IsPagingPlaylistObjectVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Spotify.PagingObject, TResult>? pagingObject = null,
            global::System.Func<global::Spotify.PagingPlaylistObjectVariant2, TResult>? pagingPlaylistObjectVariant2 = null,
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
            else if (IsPagingPlaylistObjectVariant2 && pagingPlaylistObjectVariant2 != null)
            {
                return pagingPlaylistObjectVariant2(PagingPlaylistObjectVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Spotify.PagingObject>? pagingObject = null,

            global::System.Action<global::Spotify.PagingPlaylistObjectVariant2>? pagingPlaylistObjectVariant2 = null,
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
            else if (IsPagingPlaylistObjectVariant2)
            {
                pagingPlaylistObjectVariant2?.Invoke(PagingPlaylistObjectVariant2!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Spotify.PagingObject>? pagingObject = null,
            global::System.Action<global::Spotify.PagingPlaylistObjectVariant2>? pagingPlaylistObjectVariant2 = null,
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
            else if (IsPagingPlaylistObjectVariant2)
            {
                pagingPlaylistObjectVariant2?.Invoke(PagingPlaylistObjectVariant2!);
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
                PagingPlaylistObjectVariant2,
                typeof(global::Spotify.PagingPlaylistObjectVariant2),
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
        public bool Equals(PagingPlaylistObject other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Spotify.PagingObject?>.Default.Equals(PagingObject, other.PagingObject) &&
                global::System.Collections.Generic.EqualityComparer<global::Spotify.PagingPlaylistObjectVariant2?>.Default.Equals(PagingPlaylistObjectVariant2, other.PagingPlaylistObjectVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(PagingPlaylistObject obj1, PagingPlaylistObject obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<PagingPlaylistObject>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(PagingPlaylistObject obj1, PagingPlaylistObject obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is PagingPlaylistObject o && Equals(o);
        }
    }
}
