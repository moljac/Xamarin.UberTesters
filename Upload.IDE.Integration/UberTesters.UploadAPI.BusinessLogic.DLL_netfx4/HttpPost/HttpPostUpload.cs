using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UberTesters.UploadAPI.BusinessLogic.DLL_netfx45.HttpPost
{
	public partial class HttpPostUpload
	{
		private string paramString;
		private System.IO.Stream paramFileStream;
		private byte[] paramFileBytes;
		private Uri actionUrl;

		public System.IO.Stream UploadToUberTesters02(string url)
		{
			// Using .NET 4.5 (or .NET 4.0 by adding the Microsoft.Net.Http package from NuGet) 
			// there is an easier way to simulate form requests
			// Install-Package Microsoft.Net.Http
			System.Net.Http.HttpContent stringContent = new System.Net.Http.StringContent(paramString);
			System.Net.Http.HttpContent fileStreamContent = new System.Net.Http.StreamContent(paramFileStream);
			System.Net.Http.HttpContent bytesContent = new System.Net.Http.ByteArrayContent(paramFileBytes);
			using (var client = new System.Net.Http.HttpClient())
			using (var formData = new System.Net.Http.MultipartFormDataContent())
			{
				formData.Add(stringContent, "param1", "param1");
				formData.Add(fileStreamContent, "file1", "file1");
				formData.Add(bytesContent, "file2", "file2");
				var response = client.PostAsync(actionUrl, formData).Result;
				if (!response.IsSuccessStatusCode)
				{
					return null;
				}
				return response.Content.ReadAsStreamAsync().Result;
			}
		}
	}
}
