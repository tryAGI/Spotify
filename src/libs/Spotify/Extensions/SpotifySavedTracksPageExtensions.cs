using System.Text.Json;

namespace Spotify;

/// <summary>Helpers for consuming the saved-tracks paging schema.</summary>
public static class SpotifySavedTracksPageExtensions
{
    /// <summary>
    /// Returns the typed saved-track items, including responses represented by the paging half of
    /// Spotify's <c>allOf</c> schema.
    /// </summary>
    public static IReadOnlyList<SavedTrackObject> GetItems(this PagingSavedTrackObject page)
    {
        if (page.PagingSavedTrackObjectVariant2?.Items is { } typedItems)
            return typedItems as IReadOnlyList<SavedTrackObject> ?? typedItems.ToArray();

        if (page.PagingObject?.AdditionalProperties.TryGetValue("items", out var rawItems) != true)
            return [];

        return JsonSerializer.Deserialize(
                   rawItems,
                   typeof(List<SavedTrackObject>),
                   SourceGenerationContext.Default) as IReadOnlyList<SavedTrackObject>
               ?? [];
    }

    /// <summary>Returns the total number of saved tracks reported by Spotify.</summary>
    public static int GetTotal(this PagingSavedTrackObject page) =>
        page.PagingObject?.Total
        ?? (page.PagingSavedTrackObjectVariant2?.AdditionalProperties.TryGetValue("total", out var total) == true &&
            total.TryGetInt32(out var value)
                ? value
                : 0);
}
