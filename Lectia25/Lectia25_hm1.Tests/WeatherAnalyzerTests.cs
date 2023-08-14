using Moq;
using Xunit;

namespace Lectia25_hm1.Tests
{
    public class WeatherAnalyzerTests
    {
        [Fact]
        public void AnalyzeWeather_TempUnder10_ShouldReturnCold()
        {
            // Arrange
            var weatherServiceMock = new Mock<IWeatherService>();
            
            weatherServiceMock
                .Setup(m => m.GetTemperature("Chisinau"))
                .Returns(5);

            var sut = new WeatherAnalyzer(weatherServiceMock.Object);

            // Act
            var result = sut.AnalyzeWeather("Chisinau");

            // Assert
            weatherServiceMock.Verify(m => m.GetTemperature("Chisinau"), Times.Once);
            Assert.Equal("Cold", result);
        }

        [Fact]
        public void AnalyzeWeather_TempAbove10Under30_ShouldReturnModerate()
        {
            // Arrange
            var weatherServiceMock = new Mock<IWeatherService>();

            weatherServiceMock
                .Setup(m => m.GetTemperature("Chisinau"))
                .Returns(15);

            var sut = new WeatherAnalyzer(weatherServiceMock.Object);

            // Act
            var result = sut.AnalyzeWeather("Chisinau");

            // Assert
            weatherServiceMock.Verify(m => m.GetTemperature("Chisinau"), Times.Once);
            Assert.Equal("Moderate", result);
        }

        [Fact]
        public void AnalyzeWeather_TempAbove30_ShouldReturnHot()
        {
            // Arrange
            var weatherServiceMock = new Mock<IWeatherService>();

            weatherServiceMock
                .Setup(m => m.GetTemperature("Chisinau"))
                .Returns(35);

            var sut = new WeatherAnalyzer(weatherServiceMock.Object);

            // Act
            var result = sut.AnalyzeWeather("Chisinau");

            // Assert
            weatherServiceMock.Verify(m => m.GetTemperature("Chisinau"), Times.Once);
            Assert.Equal("Hot", result);
        }
    }
}
