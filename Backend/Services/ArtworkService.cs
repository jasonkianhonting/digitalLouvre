using System.Net;
using System.Text.Json;
using backend.Interfaces;
using backend.Models;
using backend.Models.digitalLouvreDTO;
using Microsoft.AspNetCore.Mvc;

namespace backend.Services;

public class ArtworkService(ILogger<ArtworkService> logger, IHttpClientFactory httpClientFactory)
    : IArtworkService
{
    private readonly HttpClient _httpClient = httpClientFactory.CreateClient("ArtworkClient");

    #region GetRandomArtworks

    public async Task<ResponseDto?> GetRandomArtworks()
    {
        var responseObj = new ResponseDto();

        try
        {
            var response = await _httpClient.GetAsync(_httpClient.BaseAddress);

            var content = await response.Content.ReadAsStringAsync();

            if (!response.IsSuccessStatusCode)
            {
                responseObj = responseObj with
                {
                    IsSuccess = false,
                    ErrorMessage = response.ReasonPhrase,
                    StatusCode = response.StatusCode
                };
                return responseObj;
            }

            var jsonContent = JsonSerializer.Deserialize<MuseumApiDto>(content);
            responseObj = responseObj with
            {
                Data = jsonContent,
                IsSuccess = true,
                StatusCode = response.StatusCode
            };
        }
        catch (Exception ex)
        {
            logger.LogError(ex, ex.Message);
            responseObj = new ResponseDto()
            {
                IsSuccess = false,
                ErrorMessage = ex.Message,
                StatusCode = HttpStatusCode.InternalServerError
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

            var finalisedAddress = $"{_httpClient.BaseAddress}/search?q={query}";
            
            var response = await _httpClient.GetAsync(finalisedAddress);

            var content = await response.Content.ReadAsStringAsync();

            if (!response.IsSuccessStatusCode)
            {
                responseObj = responseObj with
                {
                    IsSuccess = false,
                    ErrorMessage = response.ReasonPhrase,
                    StatusCode = response.StatusCode
                };
                return responseObj;
            }

            var jsonContent = JsonSerializer.Deserialize<MuseumApiDto>(content);
            responseObj = responseObj with
            {
                Data = jsonContent,
                IsSuccess = true,
                StatusCode = response.StatusCode
            };
        }
        catch (Exception ex)
        {
            logger.LogError(ex, ex.Message);
            responseObj = new ResponseDto()
            {
                IsSuccess = false,
                ErrorMessage = ex.Message,
                StatusCode = HttpStatusCode.InternalServerError
            };
        }

        return responseObj;
    }
    
    #endregion
    
}