#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Spotify
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct SimplifiedChapterObject : global::System.IEquatable<SimplifiedChapterObject>
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
        public object? SimplifiedChapterObjectVariant2 { get; init; }
#else
        public object? SimplifiedChapterObjectVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SimplifiedChapterObjectVariant2))]
#endif
        public bool IsSimplifiedChapterObjectVariant2 => SimplifiedChapterObjectVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickSimplifiedChapterObjectVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out object? value)
        {
            value = SimplifiedChapterObjectVariant2;
            return IsSimplifiedChapterObjectVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object PickSimplifiedChapterObjectVariant2() => IsSimplifiedChapterObjectVariant2
            ? SimplifiedChapterObjectVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'SimplifiedChapterObjectVariant2' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SimplifiedChapterObject(global::Spotify.ChapterBase value) => new SimplifiedChapterObject((global::Spotify.ChapterBase?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Spotify.ChapterBase?(SimplifiedChapterObject @this) => @this.Base;

        /// <summary>
        /// 
        /// </summary>
        public SimplifiedChapterObject(global::Spotify.ChapterBase? value)
        {
            Base = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static SimplifiedChapterObject FromBase(global::Spotify.ChapterBase? value) => new SimplifiedChapterObject(value);

        /// <summary>
        /// 
        /// </summary>
        public SimplifiedChapterObject(
            global::Spotify.ChapterBase? @base,
            object? simplifiedChapterObjectVariant2
            )
        {
            Base = @base;
            SimplifiedChapterObjectVariant2 = simplifiedChapterObjectVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            SimplifiedChapterObjectVariant2 as object ??
            Base as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            SimplifiedChapterObjectVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsSimplifiedChapterObjectVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Spotify.ChapterBase, TResult>? @base = null,
            global::System.Func<object, TResult>? simplifiedChapterObjectVariant2 = null,
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
            else if (IsSimplifiedChapterObjectVariant2 && simplifiedChapterObjectVariant2 != null)
            {
                return simplifiedChapterObjectVariant2(SimplifiedChapterObjectVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Spotify.ChapterBase>? @base = null,

            global::System.Action<object>? simplifiedChapterObjectVariant2 = null,
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
            else if (IsSimplifiedChapterObjectVariant2)
            {
                simplifiedChapterObjectVariant2?.Invoke(SimplifiedChapterObjectVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Spotify.ChapterBase>? @base = null,
            global::System.Action<object>? simplifiedChapterObjectVariant2 = null,
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
            else if (IsSimplifiedChapterObjectVariant2)
            {
                simplifiedChapterObjectVariant2?.Invoke(SimplifiedChapterObjectVariant2!);
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
                SimplifiedChapterObjectVariant2,
                typeof(object),
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
        public bool Equals(SimplifiedChapterObject other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Spotify.ChapterBase?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<object?>.Default.Equals(SimplifiedChapterObjectVariant2, other.SimplifiedChapterObjectVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(SimplifiedChapterObject obj1, SimplifiedChapterObject obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<SimplifiedChapterObject>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(SimplifiedChapterObject obj1, SimplifiedChapterObject obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is SimplifiedChapterObject o && Equals(o);
        }
    }
}
