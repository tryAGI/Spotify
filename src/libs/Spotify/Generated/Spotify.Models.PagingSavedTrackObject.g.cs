#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Spotify
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct PagingSavedTrackObject : global::System.IEquatable<PagingSavedTrackObject>
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
        public global::Spotify.PagingSavedTrackObjectVariant2? PagingSavedTrackObjectVariant2 { get; init; }
#else
        public global::Spotify.PagingSavedTrackObjectVariant2? PagingSavedTrackObjectVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PagingSavedTrackObjectVariant2))]
#endif
        public bool IsPagingSavedTrackObjectVariant2 => PagingSavedTrackObjectVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickPagingSavedTrackObjectVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Spotify.PagingSavedTrackObjectVariant2? value)
        {
            value = PagingSavedTrackObjectVariant2;
            return IsPagingSavedTrackObjectVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Spotify.PagingSavedTrackObjectVariant2 PickPagingSavedTrackObjectVariant2() => IsPagingSavedTrackObjectVariant2
            ? PagingSavedTrackObjectVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'PagingSavedTrackObjectVariant2' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PagingSavedTrackObject(global::Spotify.PagingObject value) => new PagingSavedTrackObject((global::Spotify.PagingObject?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Spotify.PagingObject?(PagingSavedTrackObject @this) => @this.PagingObject;

        /// <summary>
        /// 
        /// </summary>
        public PagingSavedTrackObject(global::Spotify.PagingObject? value)
        {
            PagingObject = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static PagingSavedTrackObject FromPagingObject(global::Spotify.PagingObject? value) => new PagingSavedTrackObject(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PagingSavedTrackObject(global::Spotify.PagingSavedTrackObjectVariant2 value) => new PagingSavedTrackObject((global::Spotify.PagingSavedTrackObjectVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Spotify.PagingSavedTrackObjectVariant2?(PagingSavedTrackObject @this) => @this.PagingSavedTrackObjectVariant2;

        /// <summary>
        /// 
        /// </summary>
        public PagingSavedTrackObject(global::Spotify.PagingSavedTrackObjectVariant2? value)
        {
            PagingSavedTrackObjectVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static PagingSavedTrackObject FromPagingSavedTrackObjectVariant2(global::Spotify.PagingSavedTrackObjectVariant2? value) => new PagingSavedTrackObject(value);

        /// <summary>
        /// 
        /// </summary>
        public PagingSavedTrackObject(
            global::Spotify.PagingObject? pagingObject,
            global::Spotify.PagingSavedTrackObjectVariant2? pagingSavedTrackObjectVariant2
            )
        {
            PagingObject = pagingObject;
            PagingSavedTrackObjectVariant2 = pagingSavedTrackObjectVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            PagingSavedTrackObjectVariant2 as object ??
            PagingObject as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            PagingObject?.ToString() ??
            PagingSavedTrackObjectVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsPagingObject && IsPagingSavedTrackObjectVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Spotify.PagingObject, TResult>? pagingObject = null,
            global::System.Func<global::Spotify.PagingSavedTrackObjectVariant2, TResult>? pagingSavedTrackObjectVariant2 = null,
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
            else if (IsPagingSavedTrackObjectVariant2 && pagingSavedTrackObjectVariant2 != null)
            {
                return pagingSavedTrackObjectVariant2(PagingSavedTrackObjectVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Spotify.PagingObject>? pagingObject = null,

            global::System.Action<global::Spotify.PagingSavedTrackObjectVariant2>? pagingSavedTrackObjectVariant2 = null,
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
            else if (IsPagingSavedTrackObjectVariant2)
            {
                pagingSavedTrackObjectVariant2?.Invoke(PagingSavedTrackObjectVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Spotify.PagingObject>? pagingObject = null,
            global::System.Action<global::Spotify.PagingSavedTrackObjectVariant2>? pagingSavedTrackObjectVariant2 = null,
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
            else if (IsPagingSavedTrackObjectVariant2)
            {
                pagingSavedTrackObjectVariant2?.Invoke(PagingSavedTrackObjectVariant2!);
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
                PagingSavedTrackObjectVariant2,
                typeof(global::Spotify.PagingSavedTrackObjectVariant2),
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
        public bool Equals(PagingSavedTrackObject other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Spotify.PagingObject?>.Default.Equals(PagingObject, other.PagingObject) &&
                global::System.Collections.Generic.EqualityComparer<global::Spotify.PagingSavedTrackObjectVariant2?>.Default.Equals(PagingSavedTrackObjectVariant2, other.PagingSavedTrackObjectVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(PagingSavedTrackObject obj1, PagingSavedTrackObject obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<PagingSavedTrackObject>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(PagingSavedTrackObject obj1, PagingSavedTrackObject obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is PagingSavedTrackObject o && Equals(o);
        }
    }
}
