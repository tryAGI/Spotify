#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Spotify
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct PagingTrackObject : global::System.IEquatable<PagingTrackObject>
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
        public global::Spotify.PagingTrackObjectVariant2? PagingTrackObjectVariant2 { get; init; }
#else
        public global::Spotify.PagingTrackObjectVariant2? PagingTrackObjectVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PagingTrackObjectVariant2))]
#endif
        public bool IsPagingTrackObjectVariant2 => PagingTrackObjectVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickPagingTrackObjectVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Spotify.PagingTrackObjectVariant2? value)
        {
            value = PagingTrackObjectVariant2;
            return IsPagingTrackObjectVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Spotify.PagingTrackObjectVariant2 PickPagingTrackObjectVariant2() => IsPagingTrackObjectVariant2
            ? PagingTrackObjectVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'PagingTrackObjectVariant2' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PagingTrackObject(global::Spotify.PagingObject value) => new PagingTrackObject((global::Spotify.PagingObject?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Spotify.PagingObject?(PagingTrackObject @this) => @this.PagingObject;

        /// <summary>
        /// 
        /// </summary>
        public PagingTrackObject(global::Spotify.PagingObject? value)
        {
            PagingObject = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static PagingTrackObject FromPagingObject(global::Spotify.PagingObject? value) => new PagingTrackObject(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PagingTrackObject(global::Spotify.PagingTrackObjectVariant2 value) => new PagingTrackObject((global::Spotify.PagingTrackObjectVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Spotify.PagingTrackObjectVariant2?(PagingTrackObject @this) => @this.PagingTrackObjectVariant2;

        /// <summary>
        /// 
        /// </summary>
        public PagingTrackObject(global::Spotify.PagingTrackObjectVariant2? value)
        {
            PagingTrackObjectVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static PagingTrackObject FromPagingTrackObjectVariant2(global::Spotify.PagingTrackObjectVariant2? value) => new PagingTrackObject(value);

        /// <summary>
        /// 
        /// </summary>
        public PagingTrackObject(
            global::Spotify.PagingObject? pagingObject,
            global::Spotify.PagingTrackObjectVariant2? pagingTrackObjectVariant2
            )
        {
            PagingObject = pagingObject;
            PagingTrackObjectVariant2 = pagingTrackObjectVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            PagingTrackObjectVariant2 as object ??
            PagingObject as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            PagingObject?.ToString() ??
            PagingTrackObjectVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsPagingObject && IsPagingTrackObjectVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Spotify.PagingObject, TResult>? pagingObject = null,
            global::System.Func<global::Spotify.PagingTrackObjectVariant2, TResult>? pagingTrackObjectVariant2 = null,
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
            else if (IsPagingTrackObjectVariant2 && pagingTrackObjectVariant2 != null)
            {
                return pagingTrackObjectVariant2(PagingTrackObjectVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Spotify.PagingObject>? pagingObject = null,

            global::System.Action<global::Spotify.PagingTrackObjectVariant2>? pagingTrackObjectVariant2 = null,
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
            else if (IsPagingTrackObjectVariant2)
            {
                pagingTrackObjectVariant2?.Invoke(PagingTrackObjectVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Spotify.PagingObject>? pagingObject = null,
            global::System.Action<global::Spotify.PagingTrackObjectVariant2>? pagingTrackObjectVariant2 = null,
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
            else if (IsPagingTrackObjectVariant2)
            {
                pagingTrackObjectVariant2?.Invoke(PagingTrackObjectVariant2!);
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
                PagingTrackObjectVariant2,
                typeof(global::Spotify.PagingTrackObjectVariant2),
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
        public bool Equals(PagingTrackObject other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Spotify.PagingObject?>.Default.Equals(PagingObject, other.PagingObject) &&
                global::System.Collections.Generic.EqualityComparer<global::Spotify.PagingTrackObjectVariant2?>.Default.Equals(PagingTrackObjectVariant2, other.PagingTrackObjectVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(PagingTrackObject obj1, PagingTrackObject obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<PagingTrackObject>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(PagingTrackObject obj1, PagingTrackObject obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is PagingTrackObject o && Equals(o);
        }
    }
}
