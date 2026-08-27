#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Spotify
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct SimplifiedEpisodeObject : global::System.IEquatable<SimplifiedEpisodeObject>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Spotify.EpisodeBase? Base { get; init; }
#else
        public global::Spotify.EpisodeBase? Base { get; }
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
            out global::Spotify.EpisodeBase? value)
        {
            value = Base;
            return IsBase;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Spotify.EpisodeBase PickBase() => IsBase
            ? Base!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Base' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public object? SimplifiedEpisodeObjectVariant2 { get; init; }
#else
        public object? SimplifiedEpisodeObjectVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SimplifiedEpisodeObjectVariant2))]
#endif
        public bool IsSimplifiedEpisodeObjectVariant2 => SimplifiedEpisodeObjectVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSimplifiedEpisodeObjectVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out object? value)
        {
            value = SimplifiedEpisodeObjectVariant2;
            return IsSimplifiedEpisodeObjectVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object PickSimplifiedEpisodeObjectVariant2() => IsSimplifiedEpisodeObjectVariant2
            ? SimplifiedEpisodeObjectVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'SimplifiedEpisodeObjectVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator SimplifiedEpisodeObject(global::Spotify.EpisodeBase value) => new SimplifiedEpisodeObject((global::Spotify.EpisodeBase?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Spotify.EpisodeBase?(SimplifiedEpisodeObject @this) => @this.Base;

        /// <summary>
        ///
        /// </summary>
        public SimplifiedEpisodeObject(global::Spotify.EpisodeBase? value)
        {
            Base = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static SimplifiedEpisodeObject FromBase(global::Spotify.EpisodeBase? value) => new SimplifiedEpisodeObject(value);

        /// <summary>
        ///
        /// </summary>
        public SimplifiedEpisodeObject(
            global::Spotify.EpisodeBase? @base,
            object? simplifiedEpisodeObjectVariant2
            )
        {
            Base = @base;
            SimplifiedEpisodeObjectVariant2 = simplifiedEpisodeObjectVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            SimplifiedEpisodeObjectVariant2 as object ??
            Base as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            SimplifiedEpisodeObjectVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsSimplifiedEpisodeObjectVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Spotify.EpisodeBase, TResult>? @base = null,
            global::System.Func<object, TResult>? simplifiedEpisodeObjectVariant2 = null,
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
            else if (IsSimplifiedEpisodeObjectVariant2 && simplifiedEpisodeObjectVariant2 != null)
            {
                return simplifiedEpisodeObjectVariant2(SimplifiedEpisodeObjectVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Spotify.EpisodeBase>? @base = null,

            global::System.Action<object>? simplifiedEpisodeObjectVariant2 = null,
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
            else if (IsSimplifiedEpisodeObjectVariant2)
            {
                simplifiedEpisodeObjectVariant2?.Invoke(SimplifiedEpisodeObjectVariant2!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Spotify.EpisodeBase>? @base = null,
            global::System.Action<object>? simplifiedEpisodeObjectVariant2 = null,
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
            else if (IsSimplifiedEpisodeObjectVariant2)
            {
                simplifiedEpisodeObjectVariant2?.Invoke(SimplifiedEpisodeObjectVariant2!);
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
                typeof(global::Spotify.EpisodeBase),
                SimplifiedEpisodeObjectVariant2,
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
        public bool Equals(SimplifiedEpisodeObject other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Spotify.EpisodeBase?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<object?>.Default.Equals(SimplifiedEpisodeObjectVariant2, other.SimplifiedEpisodeObjectVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(SimplifiedEpisodeObject obj1, SimplifiedEpisodeObject obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<SimplifiedEpisodeObject>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(SimplifiedEpisodeObject obj1, SimplifiedEpisodeObject obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is SimplifiedEpisodeObject o && Equals(o);
        }
    }
}
