#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Spotify
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct CursorPagingSimplifiedArtistObject : global::System.IEquatable<CursorPagingSimplifiedArtistObject>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Spotify.CursorPagingObject? CursorPagingObject { get; init; }
#else
        public global::Spotify.CursorPagingObject? CursorPagingObject { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CursorPagingObject))]
#endif
        public bool IsCursorPagingObject => CursorPagingObject != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickCursorPagingObject(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Spotify.CursorPagingObject? value)
        {
            value = CursorPagingObject;
            return IsCursorPagingObject;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Spotify.CursorPagingObject PickCursorPagingObject() => IsCursorPagingObject
            ? CursorPagingObject!
            : throw new global::System.InvalidOperationException($"Expected union variant 'CursorPagingObject' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Spotify.CursorPagingSimplifiedArtistObjectVariant2? CursorPagingSimplifiedArtistObjectVariant2 { get; init; }
#else
        public global::Spotify.CursorPagingSimplifiedArtistObjectVariant2? CursorPagingSimplifiedArtistObjectVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CursorPagingSimplifiedArtistObjectVariant2))]
#endif
        public bool IsCursorPagingSimplifiedArtistObjectVariant2 => CursorPagingSimplifiedArtistObjectVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickCursorPagingSimplifiedArtistObjectVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Spotify.CursorPagingSimplifiedArtistObjectVariant2? value)
        {
            value = CursorPagingSimplifiedArtistObjectVariant2;
            return IsCursorPagingSimplifiedArtistObjectVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Spotify.CursorPagingSimplifiedArtistObjectVariant2 PickCursorPagingSimplifiedArtistObjectVariant2() => IsCursorPagingSimplifiedArtistObjectVariant2
            ? CursorPagingSimplifiedArtistObjectVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'CursorPagingSimplifiedArtistObjectVariant2' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CursorPagingSimplifiedArtistObject(global::Spotify.CursorPagingObject value) => new CursorPagingSimplifiedArtistObject((global::Spotify.CursorPagingObject?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Spotify.CursorPagingObject?(CursorPagingSimplifiedArtistObject @this) => @this.CursorPagingObject;

        /// <summary>
        /// 
        /// </summary>
        public CursorPagingSimplifiedArtistObject(global::Spotify.CursorPagingObject? value)
        {
            CursorPagingObject = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static CursorPagingSimplifiedArtistObject FromCursorPagingObject(global::Spotify.CursorPagingObject? value) => new CursorPagingSimplifiedArtistObject(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CursorPagingSimplifiedArtistObject(global::Spotify.CursorPagingSimplifiedArtistObjectVariant2 value) => new CursorPagingSimplifiedArtistObject((global::Spotify.CursorPagingSimplifiedArtistObjectVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Spotify.CursorPagingSimplifiedArtistObjectVariant2?(CursorPagingSimplifiedArtistObject @this) => @this.CursorPagingSimplifiedArtistObjectVariant2;

        /// <summary>
        /// 
        /// </summary>
        public CursorPagingSimplifiedArtistObject(global::Spotify.CursorPagingSimplifiedArtistObjectVariant2? value)
        {
            CursorPagingSimplifiedArtistObjectVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static CursorPagingSimplifiedArtistObject FromCursorPagingSimplifiedArtistObjectVariant2(global::Spotify.CursorPagingSimplifiedArtistObjectVariant2? value) => new CursorPagingSimplifiedArtistObject(value);

        /// <summary>
        /// 
        /// </summary>
        public CursorPagingSimplifiedArtistObject(
            global::Spotify.CursorPagingObject? cursorPagingObject,
            global::Spotify.CursorPagingSimplifiedArtistObjectVariant2? cursorPagingSimplifiedArtistObjectVariant2
            )
        {
            CursorPagingObject = cursorPagingObject;
            CursorPagingSimplifiedArtistObjectVariant2 = cursorPagingSimplifiedArtistObjectVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            CursorPagingSimplifiedArtistObjectVariant2 as object ??
            CursorPagingObject as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            CursorPagingObject?.ToString() ??
            CursorPagingSimplifiedArtistObjectVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsCursorPagingObject && IsCursorPagingSimplifiedArtistObjectVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Spotify.CursorPagingObject, TResult>? cursorPagingObject = null,
            global::System.Func<global::Spotify.CursorPagingSimplifiedArtistObjectVariant2, TResult>? cursorPagingSimplifiedArtistObjectVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCursorPagingObject && cursorPagingObject != null)
            {
                return cursorPagingObject(CursorPagingObject!);
            }
            else if (IsCursorPagingSimplifiedArtistObjectVariant2 && cursorPagingSimplifiedArtistObjectVariant2 != null)
            {
                return cursorPagingSimplifiedArtistObjectVariant2(CursorPagingSimplifiedArtistObjectVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Spotify.CursorPagingObject>? cursorPagingObject = null,

            global::System.Action<global::Spotify.CursorPagingSimplifiedArtistObjectVariant2>? cursorPagingSimplifiedArtistObjectVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCursorPagingObject)
            {
                cursorPagingObject?.Invoke(CursorPagingObject!);
            }
            else if (IsCursorPagingSimplifiedArtistObjectVariant2)
            {
                cursorPagingSimplifiedArtistObjectVariant2?.Invoke(CursorPagingSimplifiedArtistObjectVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Spotify.CursorPagingObject>? cursorPagingObject = null,
            global::System.Action<global::Spotify.CursorPagingSimplifiedArtistObjectVariant2>? cursorPagingSimplifiedArtistObjectVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCursorPagingObject)
            {
                cursorPagingObject?.Invoke(CursorPagingObject!);
            }
            else if (IsCursorPagingSimplifiedArtistObjectVariant2)
            {
                cursorPagingSimplifiedArtistObjectVariant2?.Invoke(CursorPagingSimplifiedArtistObjectVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                CursorPagingObject,
                typeof(global::Spotify.CursorPagingObject),
                CursorPagingSimplifiedArtistObjectVariant2,
                typeof(global::Spotify.CursorPagingSimplifiedArtistObjectVariant2),
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
        public bool Equals(CursorPagingSimplifiedArtistObject other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Spotify.CursorPagingObject?>.Default.Equals(CursorPagingObject, other.CursorPagingObject) &&
                global::System.Collections.Generic.EqualityComparer<global::Spotify.CursorPagingSimplifiedArtistObjectVariant2?>.Default.Equals(CursorPagingSimplifiedArtistObjectVariant2, other.CursorPagingSimplifiedArtistObjectVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(CursorPagingSimplifiedArtistObject obj1, CursorPagingSimplifiedArtistObject obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CursorPagingSimplifiedArtistObject>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(CursorPagingSimplifiedArtistObject obj1, CursorPagingSimplifiedArtistObject obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CursorPagingSimplifiedArtistObject o && Equals(o);
        }
    }
}
