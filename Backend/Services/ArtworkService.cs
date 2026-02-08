using System.Text.Json;
using backend.Interfaces;
using backend.Models;
using backend.Models.digitalLouvreDTO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.WebUtilities;

namespace backend.Services;

public class ArtworkService(ILogger<ArtworkService> logger, IHttpClientFactory httpClientFactory)
    : IArtworkService
{
    private readonly HttpClient _httpClient = httpClientFactory.CreateClient("ArtworkClient");

    #region GetArtworks

    public async Task<ResponseDto?> GetArtworks(int? id, int page, int limit)
    {
        var responseObj = new ResponseDto();

        try
        {
            var finalisedAddress = id <= 0 ? $"{_httpClient.BaseAddress}" : $"{_httpClient.BaseAddress}/{id}";

            var paramsUsed = new Dictionary<string, int>()
            {
                { "page", page },
                { "limit", limit }
            };

            var filteredParams = paramsUsed
                .Where(x => x.Value > 0)
                .ToDictionary(x => x.Key, x => x.Value.ToString());

            finalisedAddress = QueryHelpers.AddQueryString(finalisedAddress, filteredParams!);

            var response = await _httpClient.GetAsync(finalisedAddress);

            var content = await response.Content.ReadAsStringAsync();

            if (!response.IsSuccessStatusCode)
            {
                responseObj = responseObj with
                {
                    IsSuccess = false
                };
                return responseObj;
            }

            var jsonContent = JsonSerializer.Deserialize<MuseumApiDto>(content);
            responseObj = new ResponseDto { Data = jsonContent, IsSuccess = true };
        }
        catch (Exception ex)
        {
            logger.LogError(ex, ex.Message);
            responseObj = new ResponseDto()
            {
                IsSuccess = false
            };
        }

        return responseObj;
    }

    #endregion

    #region SearchArtwork

    public async Task<ResponseDto?> SearchArtwork([FromQuery] string query)
    {
        var responseObj = new ResponseDto();

        try
        {
            var finalisedAddress = $"{_httpClient.BaseAddress}/search";

            var paramsUsed = new Dictionary<string, string?>()
            {
                { "q", query },
            };
            
            var filteredParams = paramsUsed.
                Where(x => !string.IsNullOrEmpty(x.Value))
                .ToDictionary(x => x.Key, x => x.Value);

            finalisedAddress = QueryHelpers.AddQueryString(finalisedAddress, filteredParams);

            var response = await _httpClient.GetAsync(finalisedAddress);

            var content = await response.Content.ReadAsStringAsync();

            if (!response.IsSuccessStatusCode)
            {
                responseObj = responseObj with
                {
                    IsSuccess = false
                };
                return responseObj;
            }

            var jsonContent = JsonSerializer.Deserialize<MuseumApiDto>(content);
            responseObj = new ResponseDto { Data = jsonContent, IsSuccess = true };
        }
        catch (Exception ex)
        {
            logger.LogError(ex, ex.Message);
            responseObj = new ResponseDto()
            {
                IsSuccess = false
            };
        }

        return responseObj;
    }

    #endregion
}