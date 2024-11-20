namespace LinqToDB.Scaffold
{
	public class ProviderOptions
	{
		public string ProviderName { get; set; } = "";
		public string? ProviderLocation { get; set; }
		public string? ProviderDetectorClass { get; set; }
		public string? ProviderDetectorMethod { get; set; }
	}
}
