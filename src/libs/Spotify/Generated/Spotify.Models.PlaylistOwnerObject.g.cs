#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Spotify
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct PlaylistOwnerObject : global::System.IEquatable<PlaylistOwnerObject>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Spotify.PlaylistUserObject? User { get; init; }
#else
        public global::Spotify.PlaylistUserObject? User { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(User))]
#endif
        public bool IsUser => User != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickUser(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Spotify.PlaylistUserObject? value)
        {
            value = User;
            return IsUser;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Spotify.PlaylistUserObject PickUser() => IsUser
            ? User!
            : throw new global::System.InvalidOperationException($"Expected union variant 'User' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Spotify.PlaylistOwnerObjectVariant2? PlaylistOwnerObjectVariant2 { get; init; }
#else
        public global::Spotify.PlaylistOwnerObjectVariant2? PlaylistOwnerObjectVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PlaylistOwnerObjectVariant2))]
#endif
        public bool IsPlaylistOwnerObjectVariant2 => PlaylistOwnerObjectVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickPlaylistOwnerObjectVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Spotify.PlaylistOwnerObjectVariant2? value)
        {
            value = PlaylistOwnerObjectVariant2;
            return IsPlaylistOwnerObjectVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Spotify.PlaylistOwnerObjectVariant2 PickPlaylistOwnerObjectVariant2() => IsPlaylistOwnerObjectVariant2
            ? PlaylistOwnerObjectVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'PlaylistOwnerObjectVariant2' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PlaylistOwnerObject(global::Spotify.PlaylistUserObject value) => new PlaylistOwnerObject((global::Spotify.PlaylistUserObject?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Spotify.PlaylistUserObject?(PlaylistOwnerObject @this) => @this.User;

        /// <summary>
        /// 
        /// </summary>
        public PlaylistOwnerObject(global::Spotify.PlaylistUserObject? value)
        {
            User = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static PlaylistOwnerObject FromUser(global::Spotify.PlaylistUserObject? value) => new PlaylistOwnerObject(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PlaylistOwnerObject(global::Spotify.PlaylistOwnerObjectVariant2 value) => new PlaylistOwnerObject((global::Spotify.PlaylistOwnerObjectVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Spotify.PlaylistOwnerObjectVariant2?(PlaylistOwnerObject @this) => @this.PlaylistOwnerObjectVariant2;

        /// <summary>
        /// 
        /// </summary>
        public PlaylistOwnerObject(global::Spotify.PlaylistOwnerObjectVariant2? value)
        {
            PlaylistOwnerObjectVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static PlaylistOwnerObject FromPlaylistOwnerObjectVariant2(global::Spotify.PlaylistOwnerObjectVariant2? value) => new PlaylistOwnerObject(value);

        /// <summary>
        /// 
        /// </summary>
        public PlaylistOwnerObject(
            global::Spotify.PlaylistUserObject? user,
            global::Spotify.PlaylistOwnerObjectVariant2? playlistOwnerObjectVariant2
            )
        {
            User = user;
            PlaylistOwnerObjectVariant2 = playlistOwnerObjectVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            PlaylistOwnerObjectVariant2 as object ??
            User as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            User?.ToString() ??
            PlaylistOwnerObjectVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsUser && IsPlaylistOwnerObjectVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Spotify.PlaylistUserObject, TResult>? user = null,
            global::System.Func<global::Spotify.PlaylistOwnerObjectVariant2, TResult>? playlistOwnerObjectVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsUser && user != null)
            {
                return user(User!);
            }
            else if (IsPlaylistOwnerObjectVariant2 && playlistOwnerObjectVariant2 != null)
            {
                return playlistOwnerObjectVariant2(PlaylistOwnerObjectVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Spotify.PlaylistUserObject>? user = null,

            global::System.Action<global::Spotify.PlaylistOwnerObjectVariant2>? playlistOwnerObjectVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsUser)
            {
                user?.Invoke(User!);
            }
            else if (IsPlaylistOwnerObjectVariant2)
            {
                playlistOwnerObjectVariant2?.Invoke(PlaylistOwnerObjectVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Spotify.PlaylistUserObject>? user = null,
            global::System.Action<global::Spotify.PlaylistOwnerObjectVariant2>? playlistOwnerObjectVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsUser)
            {
                user?.Invoke(User!);
            }
            else if (IsPlaylistOwnerObjectVariant2)
            {
                playlistOwnerObjectVariant2?.Invoke(PlaylistOwnerObjectVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                User,
                typeof(global::Spotify.PlaylistUserObject),
                PlaylistOwnerObjectVariant2,
                typeof(global::Spotify.PlaylistOwnerObjectVariant2),
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
        public bool Equals(PlaylistOwnerObject other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Spotify.PlaylistUserObject?>.Default.Equals(User, other.User) &&
                global::System.Collections.Generic.EqualityComparer<global::Spotify.PlaylistOwnerObjectVariant2?>.Default.Equals(PlaylistOwnerObjectVariant2, other.PlaylistOwnerObjectVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(PlaylistOwnerObject obj1, PlaylistOwnerObject obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<PlaylistOwnerObject>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(PlaylistOwnerObject obj1, PlaylistOwnerObject obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is PlaylistOwnerObject o && Equals(o);
        }
    }
}
