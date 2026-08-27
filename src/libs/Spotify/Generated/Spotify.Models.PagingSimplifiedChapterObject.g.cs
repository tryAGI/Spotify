#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Spotify
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct PagingSimplifiedChapterObject : global::System.IEquatable<PagingSimplifiedChapterObject>
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
        public global::Spotify.PagingSimplifiedChapterObjectVariant2? PagingSimplifiedChapterObjectVariant2 { get; init; }
#else
        public global::Spotify.PagingSimplifiedChapterObjectVariant2? PagingSimplifiedChapterObjectVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PagingSimplifiedChapterObjectVariant2))]
#endif
        public bool IsPagingSimplifiedChapterObjectVariant2 => PagingSimplifiedChapterObjectVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickPagingSimplifiedChapterObjectVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Spotify.PagingSimplifiedChapterObjectVariant2? value)
        {
            value = PagingSimplifiedChapterObjectVariant2;
            return IsPagingSimplifiedChapterObjectVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Spotify.PagingSimplifiedChapterObjectVariant2 PickPagingSimplifiedChapterObjectVariant2() => IsPagingSimplifiedChapterObjectVariant2
            ? PagingSimplifiedChapterObjectVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'PagingSimplifiedChapterObjectVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator PagingSimplifiedChapterObject(global::Spotify.PagingObject value) => new PagingSimplifiedChapterObject((global::Spotify.PagingObject?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Spotify.PagingObject?(PagingSimplifiedChapterObject @this) => @this.PagingObject;

        /// <summary>
        ///
        /// </summary>
        public PagingSimplifiedChapterObject(global::Spotify.PagingObject? value)
        {
            PagingObject = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static PagingSimplifiedChapterObject FromPagingObject(global::Spotify.PagingObject? value) => new PagingSimplifiedChapterObject(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator PagingSimplifiedChapterObject(global::Spotify.PagingSimplifiedChapterObjectVariant2 value) => new PagingSimplifiedChapterObject((global::Spotify.PagingSimplifiedChapterObjectVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Spotify.PagingSimplifiedChapterObjectVariant2?(PagingSimplifiedChapterObject @this) => @this.PagingSimplifiedChapterObjectVariant2;

        /// <summary>
        ///
        /// </summary>
        public PagingSimplifiedChapterObject(global::Spotify.PagingSimplifiedChapterObjectVariant2? value)
        {
            PagingSimplifiedChapterObjectVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static PagingSimplifiedChapterObject FromPagingSimplifiedChapterObjectVariant2(global::Spotify.PagingSimplifiedChapterObjectVariant2? value) => new PagingSimplifiedChapterObject(value);

        /// <summary>
        ///
        /// </summary>
        public PagingSimplifiedChapterObject(
            global::Spotify.PagingObject? pagingObject,
            global::Spotify.PagingSimplifiedChapterObjectVariant2? pagingSimplifiedChapterObjectVariant2
            )
        {
            PagingObject = pagingObject;
            PagingSimplifiedChapterObjectVariant2 = pagingSimplifiedChapterObjectVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            PagingSimplifiedChapterObjectVariant2 as object ??
            PagingObject as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            PagingObject?.ToString() ??
            PagingSimplifiedChapterObjectVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsPagingObject && IsPagingSimplifiedChapterObjectVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Spotify.PagingObject, TResult>? pagingObject = null,
            global::System.Func<global::Spotify.PagingSimplifiedChapterObjectVariant2, TResult>? pagingSimplifiedChapterObjectVariant2 = null,
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
            else if (IsPagingSimplifiedChapterObjectVariant2 && pagingSimplifiedChapterObjectVariant2 != null)
            {
                return pagingSimplifiedChapterObjectVariant2(PagingSimplifiedChapterObjectVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Spotify.PagingObject>? pagingObject = null,

            global::System.Action<global::Spotify.PagingSimplifiedChapterObjectVariant2>? pagingSimplifiedChapterObjectVariant2 = null,
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
            else if (IsPagingSimplifiedChapterObjectVariant2)
            {
                pagingSimplifiedChapterObjectVariant2?.Invoke(PagingSimplifiedChapterObjectVariant2!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Spotify.PagingObject>? pagingObject = null,
            global::System.Action<global::Spotify.PagingSimplifiedChapterObjectVariant2>? pagingSimplifiedChapterObjectVariant2 = null,
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
            else if (IsPagingSimplifiedChapterObjectVariant2)
            {
                pagingSimplifiedChapterObjectVariant2?.Invoke(PagingSimplifiedChapterObjectVariant2!);
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
                PagingSimplifiedChapterObjectVariant2,
                typeof(global::Spotify.PagingSimplifiedChapterObjectVariant2),
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
        public bool Equals(PagingSimplifiedChapterObject other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Spotify.PagingObject?>.Default.Equals(PagingObject, other.PagingObject) &&
                global::System.Collections.Generic.EqualityComparer<global::Spotify.PagingSimplifiedChapterObjectVariant2?>.Default.Equals(PagingSimplifiedChapterObjectVariant2, other.PagingSimplifiedChapterObjectVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(PagingSimplifiedChapterObject obj1, PagingSimplifiedChapterObject obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<PagingSimplifiedChapterObject>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(PagingSimplifiedChapterObject obj1, PagingSimplifiedChapterObject obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is PagingSimplifiedChapterObject o && Equals(o);
        }
    }
}
