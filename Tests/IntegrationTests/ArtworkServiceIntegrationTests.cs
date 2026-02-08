using backend.Interfaces;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.Extensions.DependencyInjection;

namespace IntegrationTests;

public class ArtworkServiceIntegrationTests(WebApplicationFactory<Program> factory)
    : IClassFixture<WebApplicationFactory<Program>>
{
    #region GetArtwork_ReturnValidDTOWithSuccess

    [Theory]
    [InlineData(71, 1, 1)]
    [InlineData(null, 1, 5)]
    [InlineData(null, 0, 0)]
    public async Task GetArtwork_ReturnValidDTOWithSuccess(int? id, int pageNumber, int limit)
    {
        await using var scope = factory.Services.CreateAsyncScope();
        var artworkService = scope.ServiceProvider.GetRequiredService<IArtworkService>();

        var result = await artworkService.GetArtworks(id, pageNumber, limit);

        Assert.NotNull(result);
        Assert.True(result.IsSuccess);
        Assert.NotNull(result.Data);
        //For tests that contain valid limit , API shows 12 by default
        Assert.Equal(limit > 0 ? limit : 12, result.Data?.Data?.Count());
    }

    #endregion

    #region GetArtwork_ReturnValidDTOWithFail

    [Theory]
    [InlineData(1, 1, 1)]
    [InlineData(2, 2, 1)]
    [InlineData(2, 1, 1)]
    public async Task GetArtwork_ReturnValidDTOWithFail(int? id, int pageNumber, int limit)
    {
        await using var scope = factory.Services.CreateAsyncScope();
        var artworkService = scope.ServiceProvider.GetRequiredService<IArtworkService>();

        var result = await artworkService.GetArtworks(id, pageNumber, limit);

        Assert.NotNull(result);
        Assert.False(result.IsSuccess);
        Assert.Null(result.Data);
    }

    #endregion

    #region SearchArtwork_ReturnValidDTOWithSuccess

    [Theory]
    [InlineData("Cats")]
    [InlineData("Mouse")]
    [InlineData("Mona Lisa")]
    public async Task SearchArtwork_ReturnValidDTOWithSuccess(string query)
    {
        await using var scope = factory.Services.CreateAsyncScope();
        var artworkService = scope.ServiceProvider.GetRequiredService<IArtworkService>();

        var result = await artworkService.SearchArtwork(query);

        Assert.NotNull(result);
        Assert.True(result.IsSuccess);
        Assert.NotNull(result.Data);
    }

    #endregion

    #region SearchArtwork_ReturnValidDTOWithFail

    [Theory]
    // ReSharper disable once StringLiteralTypo
    [InlineData("testteststest")]
    [InlineData("jkehjriowjiofje")]
    // ReSharper disable once StringLiteralTypo
    [InlineData("typingtypingtyping")]
    public async Task SearchArtwork_ReturnValidDTOWithZeroResult(string query)
    {
        await using var scope = factory.Services.CreateAsyncScope();
        var artworkService = scope.ServiceProvider.GetRequiredService<IArtworkService>();

        var result = await artworkService.SearchArtwork(query);

        Assert.NotNull(result);
        Assert.True(result.IsSuccess);
        Assert.Equal(0, result.Data?.Data?.Count());
    }

    #endregion
}