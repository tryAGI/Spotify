#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Spotify
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct ChapterObject : global::System.IEquatable<ChapterObject>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Spotify.ChapterBase? Base { get; init; }
#else
        public global::Spotify.ChapterBase? Base { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Base))]
#endif
        public bool IsBase => Base != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBase(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Spotify.ChapterBase? value)
        {
            value = Base;
            return IsBase;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Spotify.ChapterBase PickBase() => IsBase
            ? Base!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Base' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Spotify.ChapterObjectVariant2? ChapterObjectVariant2 { get; init; }
#else
        public global::Spotify.ChapterObjectVariant2? ChapterObjectVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ChapterObjectVariant2))]
#endif
        public bool IsChapterObjectVariant2 => ChapterObjectVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickChapterObjectVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Spotify.ChapterObjectVariant2? value)
        {
            value = ChapterObjectVariant2;
            return IsChapterObjectVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Spotify.ChapterObjectVariant2 PickChapterObjectVariant2() => IsChapterObjectVariant2
            ? ChapterObjectVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ChapterObjectVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator ChapterObject(global::Spotify.ChapterBase value) => new ChapterObject((global::Spotify.ChapterBase?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Spotify.ChapterBase?(ChapterObject @this) => @this.Base;

        /// <summary>
        ///
        /// </summary>
        public ChapterObject(global::Spotify.ChapterBase? value)
        {
            Base = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ChapterObject FromBase(global::Spotify.ChapterBase? value) => new ChapterObject(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ChapterObject(global::Spotify.ChapterObjectVariant2 value) => new ChapterObject((global::Spotify.ChapterObjectVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Spotify.ChapterObjectVariant2?(ChapterObject @this) => @this.ChapterObjectVariant2;

        /// <summary>
        ///
        /// </summary>
        public ChapterObject(global::Spotify.ChapterObjectVariant2? value)
        {
            ChapterObjectVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ChapterObject FromChapterObjectVariant2(global::Spotify.ChapterObjectVariant2? value) => new ChapterObject(value);

        /// <summary>
        ///
        /// </summary>
        public ChapterObject(
            global::Spotify.ChapterBase? @base,
            global::Spotify.ChapterObjectVariant2? chapterObjectVariant2
            )
        {
            Base = @base;
            ChapterObjectVariant2 = chapterObjectVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            ChapterObjectVariant2 as object ??
            Base as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            ChapterObjectVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsChapterObjectVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Spotify.ChapterBase, TResult>? @base = null,
            global::System.Func<global::Spotify.ChapterObjectVariant2, TResult>? chapterObjectVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBase && @base != null)
            {
                return @base(Base!);
            }
            else if (IsChapterObjectVariant2 && chapterObjectVariant2 != null)
            {
                return chapterObjectVariant2(ChapterObjectVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Spotify.ChapterBase>? @base = null,

            global::System.Action<global::Spotify.ChapterObjectVariant2>? chapterObjectVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBase)
            {
                @base?.Invoke(Base!);
            }
            else if (IsChapterObjectVariant2)
            {
                chapterObjectVariant2?.Invoke(ChapterObjectVariant2!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Spotify.ChapterBase>? @base = null,
            global::System.Action<global::Spotify.ChapterObjectVariant2>? chapterObjectVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBase)
            {
                @base?.Invoke(Base!);
            }
            else if (IsChapterObjectVariant2)
            {
                chapterObjectVariant2?.Invoke(ChapterObjectVariant2!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Base,
                typeof(global::Spotify.ChapterBase),
                ChapterObjectVariant2,
                typeof(global::Spotify.ChapterObjectVariant2),
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
        public bool Equals(ChapterObject other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Spotify.ChapterBase?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<global::Spotify.ChapterObjectVariant2?>.Default.Equals(ChapterObjectVariant2, other.ChapterObjectVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(ChapterObject obj1, ChapterObject obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ChapterObject>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ChapterObject obj1, ChapterObject obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ChapterObject o && Equals(o);
        }
    }
}
