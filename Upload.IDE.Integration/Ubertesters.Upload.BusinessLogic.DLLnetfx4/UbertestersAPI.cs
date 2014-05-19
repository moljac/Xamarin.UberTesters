using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ubertesters.Upload.BusinessLogic
{
	/// <summary>
	/// http://ubertesters.com/upload-api/
	/// http://curl.haxx.se/docs/manpage.html
	/// http://requestmaker.com/
	/// http://www.hurl.it/
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
	///			
	/// 
	/// 
	///		http://requestmaker.com/
	///		url:				http://beta.ubertesters.com/api/client/upload_build.json
	///		Request headers:	
	///			X-UbertestersApiKey:ubertestersspikey012345677890abc
	///		Request data:
	///			file=@upload.apk&title=build title
	///			
	/// 
	///		Request headers sent:
	///			POST /api/client/upload_build.json HTTP/1.1
	///			Host: beta.ubertesters.com
	///			Accept: */*
	///			Content-Type: text/html
	///			X-UbertestersApiKey: ubertestersspikey012345677890abc
	///			Content-Length: 34
	///			
	///		Response headers:
	///			Date: Tue, 06 May 2014 13:41:37 GMT
	///			Content-Type: application/json; charset=utf-8
	///			Content-Length: 80
	///			Connection: keep-alive
	///			Status: 200 OK
	///			X-Request-Id: e8f758ec4c7ec464b4414a7437fa9f35
	///			X-Runtime: 0.027076
	///			X-Rack-Cache: invalidate, pass
	///			
	///		Response body:
	///			{"success":false,"message":"Invalid file type. Please upload .IPA or .APK file"}	
	/// </summary>
	public partial class UbertestersAPI
	{
		public string Url { get; set; }
		public string HttpVerb { get; set; }
		public string PersonalAPIKey { get; set; }
		public string File { get; set; }
		public string Title { get; set; }
		public string Notes { get; set; }
		public string Status { get; set; }
		public bool StopPrevious { get; set; }

		public UbertestersAPI()
		{
			this.HttpVerb	= @"POST";
			this.Url		= @"http://beta.ubertesters.com/api/client/upload_build.json";


			return;
		}
	}
}
