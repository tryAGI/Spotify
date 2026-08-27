#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Spotify
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct PagingSimplifiedTrackObject : global::System.IEquatable<PagingSimplifiedTrackObject>
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
        public global::Spotify.PagingSimplifiedTrackObjectVariant2? PagingSimplifiedTrackObjectVariant2 { get; init; }
#else
        public global::Spotify.PagingSimplifiedTrackObjectVariant2? PagingSimplifiedTrackObjectVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PagingSimplifiedTrackObjectVariant2))]
#endif
        public bool IsPagingSimplifiedTrackObjectVariant2 => PagingSimplifiedTrackObjectVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickPagingSimplifiedTrackObjectVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Spotify.PagingSimplifiedTrackObjectVariant2? value)
        {
            value = PagingSimplifiedTrackObjectVariant2;
            return IsPagingSimplifiedTrackObjectVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Spotify.PagingSimplifiedTrackObjectVariant2 PickPagingSimplifiedTrackObjectVariant2() => IsPagingSimplifiedTrackObjectVariant2
            ? PagingSimplifiedTrackObjectVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'PagingSimplifiedTrackObjectVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator PagingSimplifiedTrackObject(global::Spotify.PagingObject value) => new PagingSimplifiedTrackObject((global::Spotify.PagingObject?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Spotify.PagingObject?(PagingSimplifiedTrackObject @this) => @this.PagingObject;

        /// <summary>
        ///
        /// </summary>
        public PagingSimplifiedTrackObject(global::Spotify.PagingObject? value)
        {
            PagingObject = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static PagingSimplifiedTrackObject FromPagingObject(global::Spotify.PagingObject? value) => new PagingSimplifiedTrackObject(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator PagingSimplifiedTrackObject(global::Spotify.PagingSimplifiedTrackObjectVariant2 value) => new PagingSimplifiedTrackObject((global::Spotify.PagingSimplifiedTrackObjectVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Spotify.PagingSimplifiedTrackObjectVariant2?(PagingSimplifiedTrackObject @this) => @this.PagingSimplifiedTrackObjectVariant2;

        /// <summary>
        ///
        /// </summary>
        public PagingSimplifiedTrackObject(global::Spotify.PagingSimplifiedTrackObjectVariant2? value)
        {
            PagingSimplifiedTrackObjectVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static PagingSimplifiedTrackObject FromPagingSimplifiedTrackObjectVariant2(global::Spotify.PagingSimplifiedTrackObjectVariant2? value) => new PagingSimplifiedTrackObject(value);

        /// <summary>
        ///
        /// </summary>
        public PagingSimplifiedTrackObject(
            global::Spotify.PagingObject? pagingObject,
            global::Spotify.PagingSimplifiedTrackObjectVariant2? pagingSimplifiedTrackObjectVariant2
            )
        {
            PagingObject = pagingObject;
            PagingSimplifiedTrackObjectVariant2 = pagingSimplifiedTrackObjectVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            PagingSimplifiedTrackObjectVariant2 as object ??
            PagingObject as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            PagingObject?.ToString() ??
            PagingSimplifiedTrackObjectVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsPagingObject && IsPagingSimplifiedTrackObjectVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Spotify.PagingObject, TResult>? pagingObject = null,
            global::System.Func<global::Spotify.PagingSimplifiedTrackObjectVariant2, TResult>? pagingSimplifiedTrackObjectVariant2 = null,
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
            else if (IsPagingSimplifiedTrackObjectVariant2 && pagingSimplifiedTrackObjectVariant2 != null)
            {
                return pagingSimplifiedTrackObjectVariant2(PagingSimplifiedTrackObjectVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Spotify.PagingObject>? pagingObject = null,

            global::System.Action<global::Spotify.PagingSimplifiedTrackObjectVariant2>? pagingSimplifiedTrackObjectVariant2 = null,
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
            else if (IsPagingSimplifiedTrackObjectVariant2)
            {
                pagingSimplifiedTrackObjectVariant2?.Invoke(PagingSimplifiedTrackObjectVariant2!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Spotify.PagingObject>? pagingObject = null,
            global::System.Action<global::Spotify.PagingSimplifiedTrackObjectVariant2>? pagingSimplifiedTrackObjectVariant2 = null,
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
            else if (IsPagingSimplifiedTrackObjectVariant2)
            {
                pagingSimplifiedTrackObjectVariant2?.Invoke(PagingSimplifiedTrackObjectVariant2!);
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
                PagingSimplifiedTrackObjectVariant2,
                typeof(global::Spotify.PagingSimplifiedTrackObjectVariant2),
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
        public bool Equals(PagingSimplifiedTrackObject other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Spotify.PagingObject?>.Default.Equals(PagingObject, other.PagingObject) &&
                global::System.Collections.Generic.EqualityComparer<global::Spotify.PagingSimplifiedTrackObjectVariant2?>.Default.Equals(PagingSimplifiedTrackObjectVariant2, other.PagingSimplifiedTrackObjectVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(PagingSimplifiedTrackObject obj1, PagingSimplifiedTrackObject obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<PagingSimplifiedTrackObject>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(PagingSimplifiedTrackObject obj1, PagingSimplifiedTrackObject obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is PagingSimplifiedTrackObject o && Equals(o);
        }
    }
}
