using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


using System.Net;
using System.IO;

namespace Ubertesters.Application.Upload.ConsoleApp.net4
{
	public partial class Program
	{
		/// <summary>
		/// http://ubertesters.com/upload-api/
		/// http://curl.haxx.se/docs/manpage.html
		/// http://requestmaker.com/
		/// 
		/// API key = ubertestersspikey012345677890abc
		/// 
		///		curl
		///			-X POST
		///			http://beta.ubertesters.com/api/client/upload_build.json
		///			-H "X-UbertestersApiKey:PERSONAL_API_KEY"
		///			-F "file=@upload.ipa"
		///			-F "title=build title"
		///			-F "notes=build notes"
		///			-F "status=in_progress"
		///			-F "stop_previous=true"
		///			
		/// 
		///		curl
		///			-X POST
		///			http://beta.ubertesters.com/api/client/upload_build.json
		///			-H "X-UbertestersApiKey:ubertestersspikey012345677890abc"
		///			-F "file=@upload.apk"
		///			-F "title=build title"
		///			-F "notes=build notes"
		///			-F "status=in_progress"
		///			-F "stop_previous=true"
		/// </summary>
		/// <param name="args"></param>
		static void Main(string[] args)
		{
			try
			{
				string url = "http://beta.ubertesters.com/api/client/upload_build.json";

				UploadToUberTesters01(url);
				WebClient wc = new WebClient();
				byte[] data = new byte[] { };

				wc.UploadData(url, "POST", data);
				wc.Headers.Add("", "");

			}
			catch (System.Exception sexc)
			{
			}

			return;
		}


		public static void UploadToUberTesters01(string url)
		{
			//Identificate separator
			string boundary = "---------------------------" + DateTime.Now.Ticks.ToString("x");
			//Encoding
			byte[] boundarybytes = System.Text.Encoding.ASCII.GetBytes("\r\n--" + boundary + "\r\n");

			//Creation and specification of the request
			HttpWebRequest wr = (HttpWebRequest)WebRequest.Create(url); //sVal is id for the webService
			wr.ContentType = "multipart/form-data; boundary=" + boundary;
			wr.Method = "POST";
			wr.KeepAlive = true;
			wr.Credentials = System.Net.CredentialCache.DefaultCredentials;

			string sAuthorization = "login:password";//AUTHENTIFICATION BEGIN
			byte[] toEncodeAsBytes = System.Text.ASCIIEncoding.ASCII.GetBytes(sAuthorization);
			string returnValue = System.Convert.ToBase64String(toEncodeAsBytes);
			wr.Headers.Add("Authorization: Basic " + returnValue); //AUTHENTIFICATION END
			Stream rs = wr.GetRequestStream();


			string formdataTemplate = "Content-Disposition: form-data; name=\"{0}\"\r\n\r\n{1}"; //For the POST's format

			//Writing of the file
			string file_path = @"..\..\..\bundles\Ubertesters.Application.XamarinAndroid-Signed.apk";
			rs.Write(boundarybytes, 0, boundarybytes.Length);
			byte[] formitembytes = System.Text.Encoding.UTF8.GetBytes(file_path);
			rs.Write(formitembytes, 0, formitembytes.Length);

			rs.Write(boundarybytes, 0, boundarybytes.Length);

			string content_type = "pplication/octet-stream";
			string headerTemplate = "Content-Disposition: form-data; name=\"{0}\"; filename=\"{1}\"\r\nContent-Type: {2}\r\n\r\n";
			string header = string.Format(headerTemplate, "file", "questions.pdf", content_type);
			byte[] headerbytes = System.Text.Encoding.UTF8.GetBytes(header);
			rs.Write(headerbytes, 0, headerbytes.Length);

			FileStream file_stream = new FileStream(file_path, FileMode.Open, FileAccess.Read);
			byte[] buffer = new byte[4096];
			int bytesRead = 0; 
			while ((bytesRead = file_stream.Read(buffer, 0, buffer.Length)) != 0)
			{
				rs.Write(buffer, 0, bytesRead);
			}
			file_stream.Close();

			byte[] trailer = System.Text.Encoding.ASCII.GetBytes("\r\n--" + boundary + "--\r\n");
			rs.Write(trailer, 0, trailer.Length);
			rs.Close();
			rs = null;

			WebResponse wresp = null;
			string response_data = null;
			try
			{
				//Get the response
				wresp = wr.GetResponse();
				Stream stream2 = wresp.GetResponseStream();
				StreamReader reader2 = new StreamReader(stream2);
				response_data = reader2.ReadToEnd();
			}
			catch (Exception ex)
			{
				string s = ex.Message;
			}
			finally
			{
				if (wresp != null)
				{
					wresp.Close();
					wresp = null;
				}
				wr = null;
			}
			return;
		}

	}
}
