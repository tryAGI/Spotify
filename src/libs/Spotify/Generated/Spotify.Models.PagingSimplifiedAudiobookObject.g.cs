#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Spotify
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct PagingSimplifiedAudiobookObject : global::System.IEquatable<PagingSimplifiedAudiobookObject>
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
        public global::Spotify.PagingSimplifiedAudiobookObjectVariant2? PagingSimplifiedAudiobookObjectVariant2 { get; init; }
#else
        public global::Spotify.PagingSimplifiedAudiobookObjectVariant2? PagingSimplifiedAudiobookObjectVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PagingSimplifiedAudiobookObjectVariant2))]
#endif
        public bool IsPagingSimplifiedAudiobookObjectVariant2 => PagingSimplifiedAudiobookObjectVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickPagingSimplifiedAudiobookObjectVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Spotify.PagingSimplifiedAudiobookObjectVariant2? value)
        {
            value = PagingSimplifiedAudiobookObjectVariant2;
            return IsPagingSimplifiedAudiobookObjectVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Spotify.PagingSimplifiedAudiobookObjectVariant2 PickPagingSimplifiedAudiobookObjectVariant2() => IsPagingSimplifiedAudiobookObjectVariant2
            ? PagingSimplifiedAudiobookObjectVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'PagingSimplifiedAudiobookObjectVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator PagingSimplifiedAudiobookObject(global::Spotify.PagingObject value) => new PagingSimplifiedAudiobookObject((global::Spotify.PagingObject?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Spotify.PagingObject?(PagingSimplifiedAudiobookObject @this) => @this.PagingObject;

        /// <summary>
        ///
        /// </summary>
        public PagingSimplifiedAudiobookObject(global::Spotify.PagingObject? value)
        {
            PagingObject = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static PagingSimplifiedAudiobookObject FromPagingObject(global::Spotify.PagingObject? value) => new PagingSimplifiedAudiobookObject(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator PagingSimplifiedAudiobookObject(global::Spotify.PagingSimplifiedAudiobookObjectVariant2 value) => new PagingSimplifiedAudiobookObject((global::Spotify.PagingSimplifiedAudiobookObjectVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Spotify.PagingSimplifiedAudiobookObjectVariant2?(PagingSimplifiedAudiobookObject @this) => @this.PagingSimplifiedAudiobookObjectVariant2;

        /// <summary>
        ///
        /// </summary>
        public PagingSimplifiedAudiobookObject(global::Spotify.PagingSimplifiedAudiobookObjectVariant2? value)
        {
            PagingSimplifiedAudiobookObjectVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static PagingSimplifiedAudiobookObject FromPagingSimplifiedAudiobookObjectVariant2(global::Spotify.PagingSimplifiedAudiobookObjectVariant2? value) => new PagingSimplifiedAudiobookObject(value);

        /// <summary>
        ///
        /// </summary>
        public PagingSimplifiedAudiobookObject(
            global::Spotify.PagingObject? pagingObject,
            global::Spotify.PagingSimplifiedAudiobookObjectVariant2? pagingSimplifiedAudiobookObjectVariant2
            )
        {
            PagingObject = pagingObject;
            PagingSimplifiedAudiobookObjectVariant2 = pagingSimplifiedAudiobookObjectVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            PagingSimplifiedAudiobookObjectVariant2 as object ??
            PagingObject as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            PagingObject?.ToString() ??
            PagingSimplifiedAudiobookObjectVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsPagingObject && IsPagingSimplifiedAudiobookObjectVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Spotify.PagingObject, TResult>? pagingObject = null,
            global::System.Func<global::Spotify.PagingSimplifiedAudiobookObjectVariant2, TResult>? pagingSimplifiedAudiobookObjectVariant2 = null,
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
            else if (IsPagingSimplifiedAudiobookObjectVariant2 && pagingSimplifiedAudiobookObjectVariant2 != null)
            {
                return pagingSimplifiedAudiobookObjectVariant2(PagingSimplifiedAudiobookObjectVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Spotify.PagingObject>? pagingObject = null,

            global::System.Action<global::Spotify.PagingSimplifiedAudiobookObjectVariant2>? pagingSimplifiedAudiobookObjectVariant2 = null,
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
            else if (IsPagingSimplifiedAudiobookObjectVariant2)
            {
                pagingSimplifiedAudiobookObjectVariant2?.Invoke(PagingSimplifiedAudiobookObjectVariant2!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Spotify.PagingObject>? pagingObject = null,
            global::System.Action<global::Spotify.PagingSimplifiedAudiobookObjectVariant2>? pagingSimplifiedAudiobookObjectVariant2 = null,
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
            else if (IsPagingSimplifiedAudiobookObjectVariant2)
            {
                pagingSimplifiedAudiobookObjectVariant2?.Invoke(PagingSimplifiedAudiobookObjectVariant2!);
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
                PagingSimplifiedAudiobookObjectVariant2,
                typeof(global::Spotify.PagingSimplifiedAudiobookObjectVariant2),
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
        public bool Equals(PagingSimplifiedAudiobookObject other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Spotify.PagingObject?>.Default.Equals(PagingObject, other.PagingObject) &&
                global::System.Collections.Generic.EqualityComparer<global::Spotify.PagingSimplifiedAudiobookObjectVariant2?>.Default.Equals(PagingSimplifiedAudiobookObjectVariant2, other.PagingSimplifiedAudiobookObjectVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(PagingSimplifiedAudiobookObject obj1, PagingSimplifiedAudiobookObject obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<PagingSimplifiedAudiobookObject>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(PagingSimplifiedAudiobookObject obj1, PagingSimplifiedAudiobookObject obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is PagingSimplifiedAudiobookObject o && Equals(o);
        }
    }
}
