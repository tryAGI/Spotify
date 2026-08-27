#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Spotify
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct CursorPagingPlayHistoryObject : global::System.IEquatable<CursorPagingPlayHistoryObject>
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
        public global::Spotify.CursorPagingPlayHistoryObjectVariant2? CursorPagingPlayHistoryObjectVariant2 { get; init; }
#else
        public global::Spotify.CursorPagingPlayHistoryObjectVariant2? CursorPagingPlayHistoryObjectVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CursorPagingPlayHistoryObjectVariant2))]
#endif
        public bool IsCursorPagingPlayHistoryObjectVariant2 => CursorPagingPlayHistoryObjectVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickCursorPagingPlayHistoryObjectVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Spotify.CursorPagingPlayHistoryObjectVariant2? value)
        {
            value = CursorPagingPlayHistoryObjectVariant2;
            return IsCursorPagingPlayHistoryObjectVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Spotify.CursorPagingPlayHistoryObjectVariant2 PickCursorPagingPlayHistoryObjectVariant2() => IsCursorPagingPlayHistoryObjectVariant2
            ? CursorPagingPlayHistoryObjectVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'CursorPagingPlayHistoryObjectVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator CursorPagingPlayHistoryObject(global::Spotify.CursorPagingObject value) => new CursorPagingPlayHistoryObject((global::Spotify.CursorPagingObject?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Spotify.CursorPagingObject?(CursorPagingPlayHistoryObject @this) => @this.CursorPagingObject;

        /// <summary>
        ///
        /// </summary>
        public CursorPagingPlayHistoryObject(global::Spotify.CursorPagingObject? value)
        {
            CursorPagingObject = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CursorPagingPlayHistoryObject FromCursorPagingObject(global::Spotify.CursorPagingObject? value) => new CursorPagingPlayHistoryObject(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator CursorPagingPlayHistoryObject(global::Spotify.CursorPagingPlayHistoryObjectVariant2 value) => new CursorPagingPlayHistoryObject((global::Spotify.CursorPagingPlayHistoryObjectVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Spotify.CursorPagingPlayHistoryObjectVariant2?(CursorPagingPlayHistoryObject @this) => @this.CursorPagingPlayHistoryObjectVariant2;

        /// <summary>
        ///
        /// </summary>
        public CursorPagingPlayHistoryObject(global::Spotify.CursorPagingPlayHistoryObjectVariant2? value)
        {
            CursorPagingPlayHistoryObjectVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CursorPagingPlayHistoryObject FromCursorPagingPlayHistoryObjectVariant2(global::Spotify.CursorPagingPlayHistoryObjectVariant2? value) => new CursorPagingPlayHistoryObject(value);

        /// <summary>
        ///
        /// </summary>
        public CursorPagingPlayHistoryObject(
            global::Spotify.CursorPagingObject? cursorPagingObject,
            global::Spotify.CursorPagingPlayHistoryObjectVariant2? cursorPagingPlayHistoryObjectVariant2
            )
        {
            CursorPagingObject = cursorPagingObject;
            CursorPagingPlayHistoryObjectVariant2 = cursorPagingPlayHistoryObjectVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            CursorPagingPlayHistoryObjectVariant2 as object ??
            CursorPagingObject as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            CursorPagingObject?.ToString() ??
            CursorPagingPlayHistoryObjectVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsCursorPagingObject && IsCursorPagingPlayHistoryObjectVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Spotify.CursorPagingObject, TResult>? cursorPagingObject = null,
            global::System.Func<global::Spotify.CursorPagingPlayHistoryObjectVariant2, TResult>? cursorPagingPlayHistoryObjectVariant2 = null,
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
            else if (IsCursorPagingPlayHistoryObjectVariant2 && cursorPagingPlayHistoryObjectVariant2 != null)
            {
                return cursorPagingPlayHistoryObjectVariant2(CursorPagingPlayHistoryObjectVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Spotify.CursorPagingObject>? cursorPagingObject = null,

            global::System.Action<global::Spotify.CursorPagingPlayHistoryObjectVariant2>? cursorPagingPlayHistoryObjectVariant2 = null,
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
            else if (IsCursorPagingPlayHistoryObjectVariant2)
            {
                cursorPagingPlayHistoryObjectVariant2?.Invoke(CursorPagingPlayHistoryObjectVariant2!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Spotify.CursorPagingObject>? cursorPagingObject = null,
            global::System.Action<global::Spotify.CursorPagingPlayHistoryObjectVariant2>? cursorPagingPlayHistoryObjectVariant2 = null,
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
            else if (IsCursorPagingPlayHistoryObjectVariant2)
            {
                cursorPagingPlayHistoryObjectVariant2?.Invoke(CursorPagingPlayHistoryObjectVariant2!);
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
                CursorPagingPlayHistoryObjectVariant2,
                typeof(global::Spotify.CursorPagingPlayHistoryObjectVariant2),
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
        public bool Equals(CursorPagingPlayHistoryObject other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Spotify.CursorPagingObject?>.Default.Equals(CursorPagingObject, other.CursorPagingObject) &&
                global::System.Collections.Generic.EqualityComparer<global::Spotify.CursorPagingPlayHistoryObjectVariant2?>.Default.Equals(CursorPagingPlayHistoryObjectVariant2, other.CursorPagingPlayHistoryObjectVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(CursorPagingPlayHistoryObject obj1, CursorPagingPlayHistoryObject obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CursorPagingPlayHistoryObject>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(CursorPagingPlayHistoryObject obj1, CursorPagingPlayHistoryObject obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CursorPagingPlayHistoryObject o && Equals(o);
        }
    }
}
