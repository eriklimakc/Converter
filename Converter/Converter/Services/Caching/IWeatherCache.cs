using Converter.DataContracts;
using System.Collections.Immutable;

namespace Converter.Services.Caching
{
	public interface IWeatherCache
	{
		ValueTask<IImmutableList<WeatherForecast>> GetForecast(CancellationToken token);
	}
}