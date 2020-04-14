using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using Blazor.Extensions.Storage;
using Blazor.Extensions.Storage.Interfaces;
using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace BlazorApp7.Client
{
	public class Program
	{
		public static async Task Main(string[] args)
		{
			var builder = WebAssemblyHostBuilder.CreateDefault(args);
			builder.RootComponents.Add<App>("app");
			builder.Services.AddBlazoredLocalStorage();
			builder.Services.AddBaseAddressHttpClient();

			await builder.Build().RunAsync();
		}
	}
}
