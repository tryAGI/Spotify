#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Spotify
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct EpisodeObject : global::System.IEquatable<EpisodeObject>
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
        public global::Spotify.EpisodeObjectVariant2? EpisodeObjectVariant2 { get; init; }
#else
        public global::Spotify.EpisodeObjectVariant2? EpisodeObjectVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(EpisodeObjectVariant2))]
#endif
        public bool IsEpisodeObjectVariant2 => EpisodeObjectVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickEpisodeObjectVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Spotify.EpisodeObjectVariant2? value)
        {
            value = EpisodeObjectVariant2;
            return IsEpisodeObjectVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Spotify.EpisodeObjectVariant2 PickEpisodeObjectVariant2() => IsEpisodeObjectVariant2
            ? EpisodeObjectVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'EpisodeObjectVariant2' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EpisodeObject(global::Spotify.EpisodeBase value) => new EpisodeObject((global::Spotify.EpisodeBase?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Spotify.EpisodeBase?(EpisodeObject @this) => @this.Base;

        /// <summary>
        /// 
        /// </summary>
        public EpisodeObject(global::Spotify.EpisodeBase? value)
        {
            Base = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static EpisodeObject FromBase(global::Spotify.EpisodeBase? value) => new EpisodeObject(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EpisodeObject(global::Spotify.EpisodeObjectVariant2 value) => new EpisodeObject((global::Spotify.EpisodeObjectVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Spotify.EpisodeObjectVariant2?(EpisodeObject @this) => @this.EpisodeObjectVariant2;

        /// <summary>
        /// 
        /// </summary>
        public EpisodeObject(global::Spotify.EpisodeObjectVariant2? value)
        {
            EpisodeObjectVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static EpisodeObject FromEpisodeObjectVariant2(global::Spotify.EpisodeObjectVariant2? value) => new EpisodeObject(value);

        /// <summary>
        /// 
        /// </summary>
        public EpisodeObject(
            global::Spotify.EpisodeBase? @base,
            global::Spotify.EpisodeObjectVariant2? episodeObjectVariant2
            )
        {
            Base = @base;
            EpisodeObjectVariant2 = episodeObjectVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            EpisodeObjectVariant2 as object ??
            Base as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            EpisodeObjectVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsEpisodeObjectVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Spotify.EpisodeBase, TResult>? @base = null,
            global::System.Func<global::Spotify.EpisodeObjectVariant2, TResult>? episodeObjectVariant2 = null,
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
            else if (IsEpisodeObjectVariant2 && episodeObjectVariant2 != null)
            {
                return episodeObjectVariant2(EpisodeObjectVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Spotify.EpisodeBase>? @base = null,

            global::System.Action<global::Spotify.EpisodeObjectVariant2>? episodeObjectVariant2 = null,
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
            else if (IsEpisodeObjectVariant2)
            {
                episodeObjectVariant2?.Invoke(EpisodeObjectVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Spotify.EpisodeBase>? @base = null,
            global::System.Action<global::Spotify.EpisodeObjectVariant2>? episodeObjectVariant2 = null,
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
            else if (IsEpisodeObjectVariant2)
            {
                episodeObjectVariant2?.Invoke(EpisodeObjectVariant2!);
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
                EpisodeObjectVariant2,
                typeof(global::Spotify.EpisodeObjectVariant2),
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
        public bool Equals(EpisodeObject other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Spotify.EpisodeBase?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<global::Spotify.EpisodeObjectVariant2?>.Default.Equals(EpisodeObjectVariant2, other.EpisodeObjectVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(EpisodeObject obj1, EpisodeObject obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<EpisodeObject>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(EpisodeObject obj1, EpisodeObject obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is EpisodeObject o && Equals(o);
        }
    }
}
