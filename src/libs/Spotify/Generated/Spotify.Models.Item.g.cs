#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Spotify
{
    /// <summary>
    /// Information about the track or episode.
    /// </summary>
    public readonly partial struct Item : global::System.IEquatable<Item>
    {
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
#if NET6_0_OR_GREATER
        public global::Spotify.EpisodeObject? EpisodeObject { get; init; }
#else
        public global::Spotify.EpisodeObject? EpisodeObject { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(EpisodeObject))]
#endif
        public bool IsEpisodeObject => EpisodeObject != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickEpisodeObject(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Spotify.EpisodeObject? value)
        {
            value = EpisodeObject;
            return IsEpisodeObject;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Spotify.EpisodeObject PickEpisodeObject() => IsEpisodeObject
            ? EpisodeObject!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'EpisodeObject' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator Item(global::Spotify.TrackObject value) => new Item((global::Spotify.TrackObject?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Spotify.TrackObject?(Item @this) => @this.Track;

        /// <summary>
        ///
        /// </summary>
        public Item(global::Spotify.TrackObject? value)
        {
            Track = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Item FromTrack(global::Spotify.TrackObject? value) => new Item(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Item(global::Spotify.EpisodeObject value) => new Item((global::Spotify.EpisodeObject?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Spotify.EpisodeObject?(Item @this) => @this.EpisodeObject;

        /// <summary>
        ///
        /// </summary>
        public Item(global::Spotify.EpisodeObject? value)
        {
            EpisodeObject = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Item FromEpisodeObject(global::Spotify.EpisodeObject? value) => new Item(value);

        /// <summary>
        ///
        /// </summary>
        public Item(
            global::Spotify.TrackObject? track,
            global::Spotify.EpisodeObject? episodeObject
            )
        {
            Track = track;
            EpisodeObject = episodeObject;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            EpisodeObject as object ??
            Track as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Track?.ToString() ??
            EpisodeObject?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsTrack && !IsEpisodeObject || !IsTrack && IsEpisodeObject;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Spotify.TrackObject, TResult>? track = null,
            global::System.Func<global::Spotify.EpisodeObject?, TResult>? episodeObject = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTrack && track != null)
            {
                return track(Track!);
            }
            else if (IsEpisodeObject && episodeObject != null)
            {
                return episodeObject(EpisodeObject!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Spotify.TrackObject>? track = null,

            global::System.Action<global::Spotify.EpisodeObject?>? episodeObject = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTrack)
            {
                track?.Invoke(Track!);
            }
            else if (IsEpisodeObject)
            {
                episodeObject?.Invoke(EpisodeObject!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Spotify.TrackObject>? track = null,
            global::System.Action<global::Spotify.EpisodeObject?>? episodeObject = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTrack)
            {
                track?.Invoke(Track!);
            }
            else if (IsEpisodeObject)
            {
                episodeObject?.Invoke(EpisodeObject!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Track,
                typeof(global::Spotify.TrackObject),
                EpisodeObject,
                typeof(global::Spotify.EpisodeObject),
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
        public bool Equals(Item other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Spotify.TrackObject?>.Default.Equals(Track, other.Track) &&
                global::System.Collections.Generic.EqualityComparer<global::Spotify.EpisodeObject?>.Default.Equals(EpisodeObject, other.EpisodeObject)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(Item obj1, Item obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Item>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(Item obj1, Item obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Item o && Equals(o);
        }
    }
}
