#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Spotify
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct GetUsersTopArtistsAndTracksResponseItem : global::System.IEquatable<GetUsersTopArtistsAndTracksResponseItem>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.GetUsersTopArtistsAndTracksResponseItemDiscriminatorType? Type { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Spotify.ArtistObject? Artist { get; init; }
#else
        public global::Spotify.ArtistObject? Artist { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Artist))]
#endif
        public bool IsArtist => Artist != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickArtist(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Spotify.ArtistObject? value)
        {
            value = Artist;
            return IsArtist;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Spotify.ArtistObject PickArtist() => IsArtist
            ? Artist!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Artist' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Spotify.TrackObject? Track { get; init; }
#else
        public global::Spotify.TrackObject? Track { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Track))]
#endif
        public bool IsTrack => Track != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickTrack(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Spotify.TrackObject? value)
        {
            value = Track;
            return IsTrack;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Spotify.TrackObject PickTrack() => IsTrack
            ? Track!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Track' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator GetUsersTopArtistsAndTracksResponseItem(global::Spotify.ArtistObject value) => new GetUsersTopArtistsAndTracksResponseItem((global::Spotify.ArtistObject?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Spotify.ArtistObject?(GetUsersTopArtistsAndTracksResponseItem @this) => @this.Artist;

        /// <summary>
        ///
        /// </summary>
        public GetUsersTopArtistsAndTracksResponseItem(global::Spotify.ArtistObject? value)
        {
            Artist = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static GetUsersTopArtistsAndTracksResponseItem FromArtist(global::Spotify.ArtistObject? value) => new GetUsersTopArtistsAndTracksResponseItem(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator GetUsersTopArtistsAndTracksResponseItem(global::Spotify.TrackObject value) => new GetUsersTopArtistsAndTracksResponseItem((global::Spotify.TrackObject?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Spotify.TrackObject?(GetUsersTopArtistsAndTracksResponseItem @this) => @this.Track;

        /// <summary>
        ///
        /// </summary>
        public GetUsersTopArtistsAndTracksResponseItem(global::Spotify.TrackObject? value)
        {
            Track = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static GetUsersTopArtistsAndTracksResponseItem FromTrack(global::Spotify.TrackObject? value) => new GetUsersTopArtistsAndTracksResponseItem(value);

        /// <summary>
        ///
        /// </summary>
        public GetUsersTopArtistsAndTracksResponseItem(
            global::Spotify.GetUsersTopArtistsAndTracksResponseItemDiscriminatorType? type,
            global::Spotify.ArtistObject? artist,
            global::Spotify.TrackObject? track
            )
        {
            Type = type;

            Artist = artist;
            Track = track;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Track as object ??
            Artist as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Artist?.ToString() ??
            Track?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsArtist && !IsTrack || !IsArtist && IsTrack;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Spotify.ArtistObject, TResult>? artist = null,
            global::System.Func<global::Spotify.TrackObject, TResult>? track = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsArtist && artist != null)
            {
                return artist(Artist!);
            }
            else if (IsTrack && track != null)
            {
                return track(Track!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Spotify.ArtistObject>? artist = null,

            global::System.Action<global::Spotify.TrackObject>? track = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsArtist)
            {
                artist?.Invoke(Artist!);
            }
            else if (IsTrack)
            {
                track?.Invoke(Track!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Spotify.ArtistObject>? artist = null,
            global::System.Action<global::Spotify.TrackObject>? track = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsArtist)
            {
                artist?.Invoke(Artist!);
            }
            else if (IsTrack)
            {
                track?.Invoke(Track!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Artist,
                typeof(global::Spotify.ArtistObject),
                Track,
                typeof(global::Spotify.TrackObject),
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
        public bool Equals(GetUsersTopArtistsAndTracksResponseItem other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Spotify.ArtistObject?>.Default.Equals(Artist, other.Artist) &&
                global::System.Collections.Generic.EqualityComparer<global::Spotify.TrackObject?>.Default.Equals(Track, other.Track)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(GetUsersTopArtistsAndTracksResponseItem obj1, GetUsersTopArtistsAndTracksResponseItem obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<GetUsersTopArtistsAndTracksResponseItem>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(GetUsersTopArtistsAndTracksResponseItem obj1, GetUsersTopArtistsAndTracksResponseItem obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is GetUsersTopArtistsAndTracksResponseItem o && Equals(o);
        }
    }
}
