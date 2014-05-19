using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ubertesters.Application.Upload.ConsoleApp
{
	/// <summary>
	/// 
	/// 
	/// In case someone wants to run this on Mono (linux/Mac), you may want to change Environment.Newline to explicitly use \r\n, since on those platforms Environment.Newline will return \n, and RFC 1867 section 5.9 specifies this should always be CRLF. Haven't tested this though. Thanks for filling a huge gap in the Web API,
	/// </summary>
	/// <see cref=""/>
	/// <see cref="http://stackoverflow.com/questions/1131425/send-a-file-via-http-post-with-c-sharp"/>
	/// <see cref="http://stackoverflow.com/questions/11048258/uploadfile-with-post-values-by-webclient"/>
	/// <see cref=""/>
	/// <see cref=""/>
	/// <see cref=""/>
	/// <see cref=""/>
	/// <see cref=""/>
	/// <see cref=""/>
	/// <see cref=""/>
	/// <see cref=""/>
	/// <see cref=""/>
	/// <see cref="http://www.codeproject.com/Articles/8600/UploadFileEx-C-s-WebClient-UploadFile-with-more-fu"/>
	/// <see cref="http://technet.rapaport.com/info/lotupload/samplecode/full_example.aspx"/>
	/// <see cref="https://technet.rapaport.com/Info/LotUpload/SampleCode/WebClient_file.aspx"/>
	public partial class UberTestersUploadData
	{
		public string Name { get; set; }
		public string Filename { get; set; }
		public string ContentType { get; set; }
		public System.IO.Stream Stream { get; set; }

		public UberTestersUploadData()
		{
			ContentType = "application/octet-stream";
		}

		public byte[] UploadFiles
			(
			  string address
			, IEnumerable<UberTestersUploadData> files
			, System.Collections.Specialized.NameValueCollection values
			)
		{
			var request = System.Net.WebRequest.Create(address);
			request.Method = "POST";
			var boundary = "---------------------------" + DateTime.Now.Ticks.ToString("x", System.Globalization.NumberFormatInfo.InvariantInfo);
			request.ContentType = "multipart/form-data; boundary=" + boundary;
			boundary = "--" + boundary;

			using (var requestStream = request.GetRequestStream())
			{
				// Write the values
				foreach (string name in values.Keys)
				{
					var buffer = Encoding.ASCII.GetBytes(boundary + Environment.NewLine);
					requestStream.Write(buffer, 0, buffer.Length);
					buffer = Encoding.ASCII.GetBytes
									(
									  string.Format("Content-Disposition: form-data; name=\"{0}\"{1}{1}", name, Environment.NewLine)
									);
					requestStream.Write(buffer, 0, buffer.Length);
					buffer = Encoding.UTF8.GetBytes(values[name] + Environment.NewLine);
					requestStream.Write(buffer, 0, buffer.Length);
				}

				// Write the files
				foreach (var file in files)
				{
					var buffer = Encoding.ASCII.GetBytes(boundary + Environment.NewLine);
					requestStream.Write(buffer, 0, buffer.Length);
					buffer = Encoding.UTF8.GetBytes(string.Format("Content-Disposition: form-data; name=\"{0}\"; filename=\"{1}\"{2}", file.Name, file.Filename, Environment.NewLine));
					requestStream.Write(buffer, 0, buffer.Length);
					buffer = Encoding.ASCII.GetBytes(string.Format("Content-Type: {0}{1}{1}", file.ContentType, Environment.NewLine));
					requestStream.Write(buffer, 0, buffer.Length);
					file.Stream.CopyTo(requestStream);
					buffer = Encoding.ASCII.GetBytes(Environment.NewLine);
					requestStream.Write(buffer, 0, buffer.Length);
				}

				var boundaryBuffer = Encoding.ASCII.GetBytes(boundary + "--");
				requestStream.Write(boundaryBuffer, 0, boundaryBuffer.Length);
			}

			using (var response = request.GetResponse())
			using (var responseStream = response.GetResponseStream())
			using (var stream = new System.IO.MemoryStream())
			{
				responseStream.CopyTo(stream);
				return stream.ToArray();
			}
		}

		public void UploadToUberTesters(string url, string file_path)
		{
			using (var stream = System.IO.File.Open(file_path, System.IO.FileMode.Open))
			{
				var files = new[] 
								{
									new UberTestersUploadData
									{
										Name = "file",
										Filename = System.IO.Path.GetFileName(file_path),
										ContentType = "text/plain",
										Stream = stream
									}
								};

				var values = new System.Collections.Specialized.NameValueCollection
								{
									{ "client", "VIP" },
									{ "name", "John Doe" },
								};

				byte[] result = UploadFiles(url, files, values);
			}
		}
	}
}
