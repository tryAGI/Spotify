#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Spotify
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct PagingSimplifiedShowObject : global::System.IEquatable<PagingSimplifiedShowObject>
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
        public global::Spotify.PagingSimplifiedShowObjectVariant2? PagingSimplifiedShowObjectVariant2 { get; init; }
#else
        public global::Spotify.PagingSimplifiedShowObjectVariant2? PagingSimplifiedShowObjectVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PagingSimplifiedShowObjectVariant2))]
#endif
        public bool IsPagingSimplifiedShowObjectVariant2 => PagingSimplifiedShowObjectVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickPagingSimplifiedShowObjectVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Spotify.PagingSimplifiedShowObjectVariant2? value)
        {
            value = PagingSimplifiedShowObjectVariant2;
            return IsPagingSimplifiedShowObjectVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Spotify.PagingSimplifiedShowObjectVariant2 PickPagingSimplifiedShowObjectVariant2() => IsPagingSimplifiedShowObjectVariant2
            ? PagingSimplifiedShowObjectVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'PagingSimplifiedShowObjectVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator PagingSimplifiedShowObject(global::Spotify.PagingObject value) => new PagingSimplifiedShowObject((global::Spotify.PagingObject?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Spotify.PagingObject?(PagingSimplifiedShowObject @this) => @this.PagingObject;

        /// <summary>
        ///
        /// </summary>
        public PagingSimplifiedShowObject(global::Spotify.PagingObject? value)
        {
            PagingObject = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static PagingSimplifiedShowObject FromPagingObject(global::Spotify.PagingObject? value) => new PagingSimplifiedShowObject(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator PagingSimplifiedShowObject(global::Spotify.PagingSimplifiedShowObjectVariant2 value) => new PagingSimplifiedShowObject((global::Spotify.PagingSimplifiedShowObjectVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Spotify.PagingSimplifiedShowObjectVariant2?(PagingSimplifiedShowObject @this) => @this.PagingSimplifiedShowObjectVariant2;

        /// <summary>
        ///
        /// </summary>
        public PagingSimplifiedShowObject(global::Spotify.PagingSimplifiedShowObjectVariant2? value)
        {
            PagingSimplifiedShowObjectVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static PagingSimplifiedShowObject FromPagingSimplifiedShowObjectVariant2(global::Spotify.PagingSimplifiedShowObjectVariant2? value) => new PagingSimplifiedShowObject(value);

        /// <summary>
        ///
        /// </summary>
        public PagingSimplifiedShowObject(
            global::Spotify.PagingObject? pagingObject,
            global::Spotify.PagingSimplifiedShowObjectVariant2? pagingSimplifiedShowObjectVariant2
            )
        {
            PagingObject = pagingObject;
            PagingSimplifiedShowObjectVariant2 = pagingSimplifiedShowObjectVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            PagingSimplifiedShowObjectVariant2 as object ??
            PagingObject as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            PagingObject?.ToString() ??
            PagingSimplifiedShowObjectVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsPagingObject && IsPagingSimplifiedShowObjectVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Spotify.PagingObject, TResult>? pagingObject = null,
            global::System.Func<global::Spotify.PagingSimplifiedShowObjectVariant2, TResult>? pagingSimplifiedShowObjectVariant2 = null,
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
            else if (IsPagingSimplifiedShowObjectVariant2 && pagingSimplifiedShowObjectVariant2 != null)
            {
                return pagingSimplifiedShowObjectVariant2(PagingSimplifiedShowObjectVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Spotify.PagingObject>? pagingObject = null,

            global::System.Action<global::Spotify.PagingSimplifiedShowObjectVariant2>? pagingSimplifiedShowObjectVariant2 = null,
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
            else if (IsPagingSimplifiedShowObjectVariant2)
            {
                pagingSimplifiedShowObjectVariant2?.Invoke(PagingSimplifiedShowObjectVariant2!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Spotify.PagingObject>? pagingObject = null,
            global::System.Action<global::Spotify.PagingSimplifiedShowObjectVariant2>? pagingSimplifiedShowObjectVariant2 = null,
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
            else if (IsPagingSimplifiedShowObjectVariant2)
            {
                pagingSimplifiedShowObjectVariant2?.Invoke(PagingSimplifiedShowObjectVariant2!);
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
                PagingSimplifiedShowObjectVariant2,
                typeof(global::Spotify.PagingSimplifiedShowObjectVariant2),
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
        public bool Equals(PagingSimplifiedShowObject other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Spotify.PagingObject?>.Default.Equals(PagingObject, other.PagingObject) &&
                global::System.Collections.Generic.EqualityComparer<global::Spotify.PagingSimplifiedShowObjectVariant2?>.Default.Equals(PagingSimplifiedShowObjectVariant2, other.PagingSimplifiedShowObjectVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(PagingSimplifiedShowObject obj1, PagingSimplifiedShowObject obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<PagingSimplifiedShowObject>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(PagingSimplifiedShowObject obj1, PagingSimplifiedShowObject obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is PagingSimplifiedShowObject o && Equals(o);
        }
    }
}
