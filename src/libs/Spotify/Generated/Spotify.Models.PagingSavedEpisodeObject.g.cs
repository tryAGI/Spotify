#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Spotify
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct PagingSavedEpisodeObject : global::System.IEquatable<PagingSavedEpisodeObject>
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
        public global::Spotify.PagingSavedEpisodeObjectVariant2? PagingSavedEpisodeObjectVariant2 { get; init; }
#else
        public global::Spotify.PagingSavedEpisodeObjectVariant2? PagingSavedEpisodeObjectVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PagingSavedEpisodeObjectVariant2))]
#endif
        public bool IsPagingSavedEpisodeObjectVariant2 => PagingSavedEpisodeObjectVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickPagingSavedEpisodeObjectVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Spotify.PagingSavedEpisodeObjectVariant2? value)
        {
            value = PagingSavedEpisodeObjectVariant2;
            return IsPagingSavedEpisodeObjectVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Spotify.PagingSavedEpisodeObjectVariant2 PickPagingSavedEpisodeObjectVariant2() => IsPagingSavedEpisodeObjectVariant2
            ? PagingSavedEpisodeObjectVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'PagingSavedEpisodeObjectVariant2' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PagingSavedEpisodeObject(global::Spotify.PagingObject value) => new PagingSavedEpisodeObject((global::Spotify.PagingObject?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Spotify.PagingObject?(PagingSavedEpisodeObject @this) => @this.PagingObject;

        /// <summary>
        /// 
        /// </summary>
        public PagingSavedEpisodeObject(global::Spotify.PagingObject? value)
        {
            PagingObject = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static PagingSavedEpisodeObject FromPagingObject(global::Spotify.PagingObject? value) => new PagingSavedEpisodeObject(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PagingSavedEpisodeObject(global::Spotify.PagingSavedEpisodeObjectVariant2 value) => new PagingSavedEpisodeObject((global::Spotify.PagingSavedEpisodeObjectVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Spotify.PagingSavedEpisodeObjectVariant2?(PagingSavedEpisodeObject @this) => @this.PagingSavedEpisodeObjectVariant2;

        /// <summary>
        /// 
        /// </summary>
        public PagingSavedEpisodeObject(global::Spotify.PagingSavedEpisodeObjectVariant2? value)
        {
            PagingSavedEpisodeObjectVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static PagingSavedEpisodeObject FromPagingSavedEpisodeObjectVariant2(global::Spotify.PagingSavedEpisodeObjectVariant2? value) => new PagingSavedEpisodeObject(value);

        /// <summary>
        /// 
        /// </summary>
        public PagingSavedEpisodeObject(
            global::Spotify.PagingObject? pagingObject,
            global::Spotify.PagingSavedEpisodeObjectVariant2? pagingSavedEpisodeObjectVariant2
            )
        {
            PagingObject = pagingObject;
            PagingSavedEpisodeObjectVariant2 = pagingSavedEpisodeObjectVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            PagingSavedEpisodeObjectVariant2 as object ??
            PagingObject as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            PagingObject?.ToString() ??
            PagingSavedEpisodeObjectVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsPagingObject && IsPagingSavedEpisodeObjectVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Spotify.PagingObject, TResult>? pagingObject = null,
            global::System.Func<global::Spotify.PagingSavedEpisodeObjectVariant2, TResult>? pagingSavedEpisodeObjectVariant2 = null,
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
            else if (IsPagingSavedEpisodeObjectVariant2 && pagingSavedEpisodeObjectVariant2 != null)
            {
                return pagingSavedEpisodeObjectVariant2(PagingSavedEpisodeObjectVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Spotify.PagingObject>? pagingObject = null,

            global::System.Action<global::Spotify.PagingSavedEpisodeObjectVariant2>? pagingSavedEpisodeObjectVariant2 = null,
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
            else if (IsPagingSavedEpisodeObjectVariant2)
            {
                pagingSavedEpisodeObjectVariant2?.Invoke(PagingSavedEpisodeObjectVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Spotify.PagingObject>? pagingObject = null,
            global::System.Action<global::Spotify.PagingSavedEpisodeObjectVariant2>? pagingSavedEpisodeObjectVariant2 = null,
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
            else if (IsPagingSavedEpisodeObjectVariant2)
            {
                pagingSavedEpisodeObjectVariant2?.Invoke(PagingSavedEpisodeObjectVariant2!);
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
                PagingSavedEpisodeObjectVariant2,
                typeof(global::Spotify.PagingSavedEpisodeObjectVariant2),
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
        public bool Equals(PagingSavedEpisodeObject other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Spotify.PagingObject?>.Default.Equals(PagingObject, other.PagingObject) &&
                global::System.Collections.Generic.EqualityComparer<global::Spotify.PagingSavedEpisodeObjectVariant2?>.Default.Equals(PagingSavedEpisodeObjectVariant2, other.PagingSavedEpisodeObjectVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(PagingSavedEpisodeObject obj1, PagingSavedEpisodeObject obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<PagingSavedEpisodeObject>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(PagingSavedEpisodeObject obj1, PagingSavedEpisodeObject obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is PagingSavedEpisodeObject o && Equals(o);
        }
    }
}
