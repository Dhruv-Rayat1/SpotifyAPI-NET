using System.Threading.Tasks;

namespace SpotifyAPI.Web
{
  public interface IPlaylistsClient
  {
    Task<SnapshotResponse> RemoveItems(string playlistId, PlaylistRemoveItemsRequest request);

    Task<SnapshotResponse> AddItems(string playlistId, PlaylistAddItemsRequest request);

    Task<Paging<PlaylistTrack<IPlaylistItem>>> GetItems(string playlistId);
    Task<Paging<PlaylistTrack<IPlaylistItem>>> GetItems(string playlistId, PlaylistGetItemsRequest request);

    Task<FullPlaylist> Create(string userId, PlaylistCreateRequest request);
  }
}
