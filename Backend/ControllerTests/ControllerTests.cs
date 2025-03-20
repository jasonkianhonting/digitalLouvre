using backend.Classes;
using backend.Interfaces;
using Microsoft.Extensions.Logging;
using Moq;

namespace ControllerTests;
public class ControllerTests
{
   private readonly IArtworkServices _artworkServices;
   private readonly ILogger<ArtworkServices> _logger;
   private readonly IHttpClientFactory _httpClientFactory;
   private readonly HttpClient _httpClientMock;

   public ControllerTests()
   {
       _logger = new Mock<ILogger<ArtworkServices>>().Object;
       var _httpClientFactory = new Mock<IHttpClientFactory>();
       var httpClientMock = new HttpClient();
       httpClientMock.BaseAddress = new Uri("https://api.artic.edu/api/v1/artworks?limit=5");
       httpClientMock.DefaultRequestHeaders.Add("user-Agent",
           "Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:134.0) Gecko/20100101 Firefox/134.0");
       _httpClientFactory.Setup(x=>x.CreateClient(It.IsAny<string>())).Returns(httpClientMock);
       _artworkServices = new ArtworkServices(_logger, _httpClientFactory.Object);
   }

    [Fact]
    public void RetrieveArtworks()
    {
        //Act
        var response = _artworkServices.GetArtworks();
        
        //Assert
        Assert.NotNull(response);
        Assert.NotEmpty(new[] { response });
    }
}