//
// This file contains the sample code to use System.Net.HttpClient
// using the HTTP handler selected in the IDE UI (or given to mtouch)
//

using System.Reflection;
using System.Threading.Tasks;
using System.Net.Http;
//using AppDynamics.Agent;

namespace HttpClientSample
{
	public class NetHttp
	{
		AppDelegate ad;

		public NetHttp (AppDelegate ad)
		{
			this.ad = ad;
		}

		public async Task HttpSample (bool secure)
		{
			//var client = new HttpClient ();

			//// Create AppDynamics Tracker
			//var tracker = AppDynamics.Agent.HTTPRequestTracker.Create(new System.Uri(Application.WisdomUrl));

			//// Add AppDynamics Server Correlation Headers
			//foreach (var header in AppDynamics.Agent.ServerCorrelationHeaders.Generate)
			//{
			//	// each header could have multiple values
			//	foreach (var value in header.Value)
			//	{
			//		client.DefaultRequestHeaders.Add(header.Key, value);
			//	}
			//}

			//ad.HandlerType = typeof(HttpMessageInvoker).GetField("handler", BindingFlags.Instance | BindingFlags.NonPublic)?.GetValue (client).GetType ();

			//var response = await client.GetAsync(Application.WisdomUrl);
			//tracker.ResponseCode = (int)response.StatusCode;
			//tracker.StatusLine = response.ReasonPhrase;
			//tracker.ResponseHeaderFields = response.Headers;
			//tracker.ReportDone();



			//ad.RenderResponse(response.ToString());

		}

	}
}

