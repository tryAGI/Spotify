#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Spotify
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct SimplifiedAudiobookObject : global::System.IEquatable<SimplifiedAudiobookObject>
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
        public object? SimplifiedAudiobookObjectVariant2 { get; init; }
#else
        public object? SimplifiedAudiobookObjectVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SimplifiedAudiobookObjectVariant2))]
#endif
        public bool IsSimplifiedAudiobookObjectVariant2 => SimplifiedAudiobookObjectVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSimplifiedAudiobookObjectVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out object? value)
        {
            value = SimplifiedAudiobookObjectVariant2;
            return IsSimplifiedAudiobookObjectVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object PickSimplifiedAudiobookObjectVariant2() => IsSimplifiedAudiobookObjectVariant2
            ? SimplifiedAudiobookObjectVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'SimplifiedAudiobookObjectVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator SimplifiedAudiobookObject(global::Spotify.AudiobookBase value) => new SimplifiedAudiobookObject((global::Spotify.AudiobookBase?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Spotify.AudiobookBase?(SimplifiedAudiobookObject @this) => @this.Base;

        /// <summary>
        ///
        /// </summary>
        public SimplifiedAudiobookObject(global::Spotify.AudiobookBase? value)
        {
            Base = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static SimplifiedAudiobookObject FromBase(global::Spotify.AudiobookBase? value) => new SimplifiedAudiobookObject(value);

        /// <summary>
        ///
        /// </summary>
        public SimplifiedAudiobookObject(
            global::Spotify.AudiobookBase? @base,
            object? simplifiedAudiobookObjectVariant2
            )
        {
            Base = @base;
            SimplifiedAudiobookObjectVariant2 = simplifiedAudiobookObjectVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            SimplifiedAudiobookObjectVariant2 as object ??
            Base as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            SimplifiedAudiobookObjectVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsSimplifiedAudiobookObjectVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Spotify.AudiobookBase, TResult>? @base = null,
            global::System.Func<object, TResult>? simplifiedAudiobookObjectVariant2 = null,
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
            else if (IsSimplifiedAudiobookObjectVariant2 && simplifiedAudiobookObjectVariant2 != null)
            {
                return simplifiedAudiobookObjectVariant2(SimplifiedAudiobookObjectVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Spotify.AudiobookBase>? @base = null,

            global::System.Action<object>? simplifiedAudiobookObjectVariant2 = null,
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
            else if (IsSimplifiedAudiobookObjectVariant2)
            {
                simplifiedAudiobookObjectVariant2?.Invoke(SimplifiedAudiobookObjectVariant2!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Spotify.AudiobookBase>? @base = null,
            global::System.Action<object>? simplifiedAudiobookObjectVariant2 = null,
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
            else if (IsSimplifiedAudiobookObjectVariant2)
            {
                simplifiedAudiobookObjectVariant2?.Invoke(SimplifiedAudiobookObjectVariant2!);
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
                SimplifiedAudiobookObjectVariant2,
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
        public bool Equals(SimplifiedAudiobookObject other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Spotify.AudiobookBase?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<object?>.Default.Equals(SimplifiedAudiobookObjectVariant2, other.SimplifiedAudiobookObjectVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(SimplifiedAudiobookObject obj1, SimplifiedAudiobookObject obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<SimplifiedAudiobookObject>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(SimplifiedAudiobookObject obj1, SimplifiedAudiobookObject obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is SimplifiedAudiobookObject o && Equals(o);
        }
    }
}
