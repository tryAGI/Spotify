#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Spotify
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct AudiobookObject : global::System.IEquatable<AudiobookObject>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Spotify.AudiobookBase? Base { get; init; }
#else
        public global::Spotify.AudiobookBase? Base { get; }
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
            out global::Spotify.AudiobookBase? value)
        {
            value = Base;
            return IsBase;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Spotify.AudiobookBase PickBase() => IsBase
            ? Base!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Base' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Spotify.AudiobookObjectVariant2? AudiobookObjectVariant2 { get; init; }
#else
        public global::Spotify.AudiobookObjectVariant2? AudiobookObjectVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AudiobookObjectVariant2))]
#endif
        public bool IsAudiobookObjectVariant2 => AudiobookObjectVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickAudiobookObjectVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Spotify.AudiobookObjectVariant2? value)
        {
            value = AudiobookObjectVariant2;
            return IsAudiobookObjectVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Spotify.AudiobookObjectVariant2 PickAudiobookObjectVariant2() => IsAudiobookObjectVariant2
            ? AudiobookObjectVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AudiobookObjectVariant2' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AudiobookObject(global::Spotify.AudiobookBase value) => new AudiobookObject((global::Spotify.AudiobookBase?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Spotify.AudiobookBase?(AudiobookObject @this) => @this.Base;

        /// <summary>
        /// 
        /// </summary>
        public AudiobookObject(global::Spotify.AudiobookBase? value)
        {
            Base = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static AudiobookObject FromBase(global::Spotify.AudiobookBase? value) => new AudiobookObject(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AudiobookObject(global::Spotify.AudiobookObjectVariant2 value) => new AudiobookObject((global::Spotify.AudiobookObjectVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Spotify.AudiobookObjectVariant2?(AudiobookObject @this) => @this.AudiobookObjectVariant2;

        /// <summary>
        /// 
        /// </summary>
        public AudiobookObject(global::Spotify.AudiobookObjectVariant2? value)
        {
            AudiobookObjectVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static AudiobookObject FromAudiobookObjectVariant2(global::Spotify.AudiobookObjectVariant2? value) => new AudiobookObject(value);

        /// <summary>
        /// 
        /// </summary>
        public AudiobookObject(
            global::Spotify.AudiobookBase? @base,
            global::Spotify.AudiobookObjectVariant2? audiobookObjectVariant2
            )
        {
            Base = @base;
            AudiobookObjectVariant2 = audiobookObjectVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            AudiobookObjectVariant2 as object ??
            Base as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            AudiobookObjectVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsAudiobookObjectVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Spotify.AudiobookBase, TResult>? @base = null,
            global::System.Func<global::Spotify.AudiobookObjectVariant2, TResult>? audiobookObjectVariant2 = null,
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
            else if (IsAudiobookObjectVariant2 && audiobookObjectVariant2 != null)
            {
                return audiobookObjectVariant2(AudiobookObjectVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Spotify.AudiobookBase>? @base = null,

            global::System.Action<global::Spotify.AudiobookObjectVariant2>? audiobookObjectVariant2 = null,
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
            else if (IsAudiobookObjectVariant2)
            {
                audiobookObjectVariant2?.Invoke(AudiobookObjectVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Spotify.AudiobookBase>? @base = null,
            global::System.Action<global::Spotify.AudiobookObjectVariant2>? audiobookObjectVariant2 = null,
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
            else if (IsAudiobookObjectVariant2)
            {
                audiobookObjectVariant2?.Invoke(AudiobookObjectVariant2!);
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
                typeof(global::Spotify.AudiobookBase),
                AudiobookObjectVariant2,
                typeof(global::Spotify.AudiobookObjectVariant2),
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
        public bool Equals(AudiobookObject other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Spotify.AudiobookBase?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<global::Spotify.AudiobookObjectVariant2?>.Default.Equals(AudiobookObjectVariant2, other.AudiobookObjectVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(AudiobookObject obj1, AudiobookObject obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AudiobookObject>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(AudiobookObject obj1, AudiobookObject obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AudiobookObject o && Equals(o);
        }
    }
}
