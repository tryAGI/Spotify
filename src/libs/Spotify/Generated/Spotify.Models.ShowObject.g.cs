#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Spotify
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct ShowObject : global::System.IEquatable<ShowObject>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Spotify.ShowBase? Base { get; init; }
#else
        public global::Spotify.ShowBase? Base { get; }
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
            out global::Spotify.ShowBase? value)
        {
            value = Base;
            return IsBase;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Spotify.ShowBase PickBase() => IsBase
            ? Base!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Base' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Spotify.ShowObjectVariant2? ShowObjectVariant2 { get; init; }
#else
        public global::Spotify.ShowObjectVariant2? ShowObjectVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ShowObjectVariant2))]
#endif
        public bool IsShowObjectVariant2 => ShowObjectVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickShowObjectVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Spotify.ShowObjectVariant2? value)
        {
            value = ShowObjectVariant2;
            return IsShowObjectVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Spotify.ShowObjectVariant2 PickShowObjectVariant2() => IsShowObjectVariant2
            ? ShowObjectVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ShowObjectVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator ShowObject(global::Spotify.ShowBase value) => new ShowObject((global::Spotify.ShowBase?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Spotify.ShowBase?(ShowObject @this) => @this.Base;

        /// <summary>
        ///
        /// </summary>
        public ShowObject(global::Spotify.ShowBase? value)
        {
            Base = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ShowObject FromBase(global::Spotify.ShowBase? value) => new ShowObject(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ShowObject(global::Spotify.ShowObjectVariant2 value) => new ShowObject((global::Spotify.ShowObjectVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Spotify.ShowObjectVariant2?(ShowObject @this) => @this.ShowObjectVariant2;

        /// <summary>
        ///
        /// </summary>
        public ShowObject(global::Spotify.ShowObjectVariant2? value)
        {
            ShowObjectVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ShowObject FromShowObjectVariant2(global::Spotify.ShowObjectVariant2? value) => new ShowObject(value);

        /// <summary>
        ///
        /// </summary>
        public ShowObject(
            global::Spotify.ShowBase? @base,
            global::Spotify.ShowObjectVariant2? showObjectVariant2
            )
        {
            Base = @base;
            ShowObjectVariant2 = showObjectVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            ShowObjectVariant2 as object ??
            Base as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            ShowObjectVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsShowObjectVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Spotify.ShowBase, TResult>? @base = null,
            global::System.Func<global::Spotify.ShowObjectVariant2, TResult>? showObjectVariant2 = null,
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
            else if (IsShowObjectVariant2 && showObjectVariant2 != null)
            {
                return showObjectVariant2(ShowObjectVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Spotify.ShowBase>? @base = null,

            global::System.Action<global::Spotify.ShowObjectVariant2>? showObjectVariant2 = null,
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
            else if (IsShowObjectVariant2)
            {
                showObjectVariant2?.Invoke(ShowObjectVariant2!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Spotify.ShowBase>? @base = null,
            global::System.Action<global::Spotify.ShowObjectVariant2>? showObjectVariant2 = null,
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
            else if (IsShowObjectVariant2)
            {
                showObjectVariant2?.Invoke(ShowObjectVariant2!);
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
                typeof(global::Spotify.ShowBase),
                ShowObjectVariant2,
                typeof(global::Spotify.ShowObjectVariant2),
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
        public bool Equals(ShowObject other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Spotify.ShowBase?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<global::Spotify.ShowObjectVariant2?>.Default.Equals(ShowObjectVariant2, other.ShowObjectVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(ShowObject obj1, ShowObject obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ShowObject>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ShowObject obj1, ShowObject obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ShowObject o && Equals(o);
        }
    }
}
