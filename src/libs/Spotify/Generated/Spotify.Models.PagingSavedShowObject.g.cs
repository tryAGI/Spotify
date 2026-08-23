#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Spotify
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct PagingSavedShowObject : global::System.IEquatable<PagingSavedShowObject>
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
        public global::Spotify.PagingSavedShowObjectVariant2? PagingSavedShowObjectVariant2 { get; init; }
#else
        public global::Spotify.PagingSavedShowObjectVariant2? PagingSavedShowObjectVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PagingSavedShowObjectVariant2))]
#endif
        public bool IsPagingSavedShowObjectVariant2 => PagingSavedShowObjectVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickPagingSavedShowObjectVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Spotify.PagingSavedShowObjectVariant2? value)
        {
            value = PagingSavedShowObjectVariant2;
            return IsPagingSavedShowObjectVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Spotify.PagingSavedShowObjectVariant2 PickPagingSavedShowObjectVariant2() => IsPagingSavedShowObjectVariant2
            ? PagingSavedShowObjectVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'PagingSavedShowObjectVariant2' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PagingSavedShowObject(global::Spotify.PagingObject value) => new PagingSavedShowObject((global::Spotify.PagingObject?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Spotify.PagingObject?(PagingSavedShowObject @this) => @this.PagingObject;

        /// <summary>
        /// 
        /// </summary>
        public PagingSavedShowObject(global::Spotify.PagingObject? value)
        {
            PagingObject = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static PagingSavedShowObject FromPagingObject(global::Spotify.PagingObject? value) => new PagingSavedShowObject(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PagingSavedShowObject(global::Spotify.PagingSavedShowObjectVariant2 value) => new PagingSavedShowObject((global::Spotify.PagingSavedShowObjectVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Spotify.PagingSavedShowObjectVariant2?(PagingSavedShowObject @this) => @this.PagingSavedShowObjectVariant2;

        /// <summary>
        /// 
        /// </summary>
        public PagingSavedShowObject(global::Spotify.PagingSavedShowObjectVariant2? value)
        {
            PagingSavedShowObjectVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static PagingSavedShowObject FromPagingSavedShowObjectVariant2(global::Spotify.PagingSavedShowObjectVariant2? value) => new PagingSavedShowObject(value);

        /// <summary>
        /// 
        /// </summary>
        public PagingSavedShowObject(
            global::Spotify.PagingObject? pagingObject,
            global::Spotify.PagingSavedShowObjectVariant2? pagingSavedShowObjectVariant2
            )
        {
            PagingObject = pagingObject;
            PagingSavedShowObjectVariant2 = pagingSavedShowObjectVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            PagingSavedShowObjectVariant2 as object ??
            PagingObject as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            PagingObject?.ToString() ??
            PagingSavedShowObjectVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsPagingObject && IsPagingSavedShowObjectVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Spotify.PagingObject, TResult>? pagingObject = null,
            global::System.Func<global::Spotify.PagingSavedShowObjectVariant2, TResult>? pagingSavedShowObjectVariant2 = null,
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
            else if (IsPagingSavedShowObjectVariant2 && pagingSavedShowObjectVariant2 != null)
            {
                return pagingSavedShowObjectVariant2(PagingSavedShowObjectVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Spotify.PagingObject>? pagingObject = null,

            global::System.Action<global::Spotify.PagingSavedShowObjectVariant2>? pagingSavedShowObjectVariant2 = null,
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
            else if (IsPagingSavedShowObjectVariant2)
            {
                pagingSavedShowObjectVariant2?.Invoke(PagingSavedShowObjectVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Spotify.PagingObject>? pagingObject = null,
            global::System.Action<global::Spotify.PagingSavedShowObjectVariant2>? pagingSavedShowObjectVariant2 = null,
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
            else if (IsPagingSavedShowObjectVariant2)
            {
                pagingSavedShowObjectVariant2?.Invoke(PagingSavedShowObjectVariant2!);
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
                PagingSavedShowObjectVariant2,
                typeof(global::Spotify.PagingSavedShowObjectVariant2),
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
        public bool Equals(PagingSavedShowObject other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Spotify.PagingObject?>.Default.Equals(PagingObject, other.PagingObject) &&
                global::System.Collections.Generic.EqualityComparer<global::Spotify.PagingSavedShowObjectVariant2?>.Default.Equals(PagingSavedShowObjectVariant2, other.PagingSavedShowObjectVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(PagingSavedShowObject obj1, PagingSavedShowObject obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<PagingSavedShowObject>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(PagingSavedShowObject obj1, PagingSavedShowObject obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is PagingSavedShowObject o && Equals(o);
        }
    }
}
