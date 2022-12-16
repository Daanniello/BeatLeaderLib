using Newtonsoft.Json;

namespace BeatLeaderLib.Endpoints
{
    public abstract class EndpointBase
    {
		readonly string baseURL = "https://api.beatleader.xyz/";

		protected async Task<T> Get<T>(string endpoint)
		{
            try
            {
				using (var client = new HttpClient())
				{
					HttpResponseMessage response = await client.GetAsync($"{baseURL}{endpoint}");
					if (!response.IsSuccessStatusCode)
					{
						return default(T);
					}
					string json = await response.Content.ReadAsStringAsync();
					var model = JsonConvert.DeserializeObject<T>(json);
					return model;
				}
			}
            catch (Exception ex)
            {
				throw ex;
            }
		}
	}
}
