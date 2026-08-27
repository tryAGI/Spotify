#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Spotify
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct PagingSimplifiedEpisodeObject : global::System.IEquatable<PagingSimplifiedEpisodeObject>
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
        public global::Spotify.PagingSimplifiedEpisodeObjectVariant2? PagingSimplifiedEpisodeObjectVariant2 { get; init; }
#else
        public global::Spotify.PagingSimplifiedEpisodeObjectVariant2? PagingSimplifiedEpisodeObjectVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PagingSimplifiedEpisodeObjectVariant2))]
#endif
        public bool IsPagingSimplifiedEpisodeObjectVariant2 => PagingSimplifiedEpisodeObjectVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickPagingSimplifiedEpisodeObjectVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Spotify.PagingSimplifiedEpisodeObjectVariant2? value)
        {
            value = PagingSimplifiedEpisodeObjectVariant2;
            return IsPagingSimplifiedEpisodeObjectVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Spotify.PagingSimplifiedEpisodeObjectVariant2 PickPagingSimplifiedEpisodeObjectVariant2() => IsPagingSimplifiedEpisodeObjectVariant2
            ? PagingSimplifiedEpisodeObjectVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'PagingSimplifiedEpisodeObjectVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator PagingSimplifiedEpisodeObject(global::Spotify.PagingObject value) => new PagingSimplifiedEpisodeObject((global::Spotify.PagingObject?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Spotify.PagingObject?(PagingSimplifiedEpisodeObject @this) => @this.PagingObject;

        /// <summary>
        ///
        /// </summary>
        public PagingSimplifiedEpisodeObject(global::Spotify.PagingObject? value)
        {
            PagingObject = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static PagingSimplifiedEpisodeObject FromPagingObject(global::Spotify.PagingObject? value) => new PagingSimplifiedEpisodeObject(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator PagingSimplifiedEpisodeObject(global::Spotify.PagingSimplifiedEpisodeObjectVariant2 value) => new PagingSimplifiedEpisodeObject((global::Spotify.PagingSimplifiedEpisodeObjectVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Spotify.PagingSimplifiedEpisodeObjectVariant2?(PagingSimplifiedEpisodeObject @this) => @this.PagingSimplifiedEpisodeObjectVariant2;

        /// <summary>
        ///
        /// </summary>
        public PagingSimplifiedEpisodeObject(global::Spotify.PagingSimplifiedEpisodeObjectVariant2? value)
        {
            PagingSimplifiedEpisodeObjectVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static PagingSimplifiedEpisodeObject FromPagingSimplifiedEpisodeObjectVariant2(global::Spotify.PagingSimplifiedEpisodeObjectVariant2? value) => new PagingSimplifiedEpisodeObject(value);

        /// <summary>
        ///
        /// </summary>
        public PagingSimplifiedEpisodeObject(
            global::Spotify.PagingObject? pagingObject,
            global::Spotify.PagingSimplifiedEpisodeObjectVariant2? pagingSimplifiedEpisodeObjectVariant2
            )
        {
            PagingObject = pagingObject;
            PagingSimplifiedEpisodeObjectVariant2 = pagingSimplifiedEpisodeObjectVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            PagingSimplifiedEpisodeObjectVariant2 as object ??
            PagingObject as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            PagingObject?.ToString() ??
            PagingSimplifiedEpisodeObjectVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsPagingObject && IsPagingSimplifiedEpisodeObjectVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Spotify.PagingObject, TResult>? pagingObject = null,
            global::System.Func<global::Spotify.PagingSimplifiedEpisodeObjectVariant2, TResult>? pagingSimplifiedEpisodeObjectVariant2 = null,
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
            else if (IsPagingSimplifiedEpisodeObjectVariant2 && pagingSimplifiedEpisodeObjectVariant2 != null)
            {
                return pagingSimplifiedEpisodeObjectVariant2(PagingSimplifiedEpisodeObjectVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Spotify.PagingObject>? pagingObject = null,

            global::System.Action<global::Spotify.PagingSimplifiedEpisodeObjectVariant2>? pagingSimplifiedEpisodeObjectVariant2 = null,
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
            else if (IsPagingSimplifiedEpisodeObjectVariant2)
            {
                pagingSimplifiedEpisodeObjectVariant2?.Invoke(PagingSimplifiedEpisodeObjectVariant2!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Spotify.PagingObject>? pagingObject = null,
            global::System.Action<global::Spotify.PagingSimplifiedEpisodeObjectVariant2>? pagingSimplifiedEpisodeObjectVariant2 = null,
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
            else if (IsPagingSimplifiedEpisodeObjectVariant2)
            {
                pagingSimplifiedEpisodeObjectVariant2?.Invoke(PagingSimplifiedEpisodeObjectVariant2!);
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
                PagingSimplifiedEpisodeObjectVariant2,
                typeof(global::Spotify.PagingSimplifiedEpisodeObjectVariant2),
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
        public bool Equals(PagingSimplifiedEpisodeObject other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Spotify.PagingObject?>.Default.Equals(PagingObject, other.PagingObject) &&
                global::System.Collections.Generic.EqualityComparer<global::Spotify.PagingSimplifiedEpisodeObjectVariant2?>.Default.Equals(PagingSimplifiedEpisodeObjectVariant2, other.PagingSimplifiedEpisodeObjectVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(PagingSimplifiedEpisodeObject obj1, PagingSimplifiedEpisodeObject obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<PagingSimplifiedEpisodeObject>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(PagingSimplifiedEpisodeObject obj1, PagingSimplifiedEpisodeObject obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is PagingSimplifiedEpisodeObject o && Equals(o);
        }
    }
}
