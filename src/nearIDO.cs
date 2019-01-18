using System;
using System.Net;

using csErddapClass;

public class nearIDO{
	public string url;
	public string json;
	public nearIDO(){
			csErddap thisErddap = new csErddap("https://erddap.marine.ie");
			thisErddap.isTable = true;
			thisErddap.isDistinct = true;
			thisErddap.format = "json";
			thisErddap.dataset = "IMI-TidePrediction_epa";
			thisErddap.fields = new String[] {"latitude","longitude","stationID"};
			url = thisErddap.buildURL();
			using (WebClient wc = new WebClient())
			{
   				json = wc.DownloadString(url);
			}
		}
}