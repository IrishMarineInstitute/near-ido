namespace csErddapClass{
public class csErddap {
	
	public string baseURL{get; set;}
	public bool isTable{get; set;}
	public string dataset{get; set;}
	public string format{get; set;}
	public string[] fields{get; set;}
	public bool isDistinct {get; set;}
	
	public csErddap(string thisBaseURL){
		baseURL = thisBaseURL;
	}
	
	public string buildURL(){
		bool queryMade = false;
		string thisErddapUrl = baseURL + "/erddap/";
		if(isTable){
			thisErddapUrl += "tabledap/";
		}
		else
		{
			thisErddapUrl += "griddap/";
		}
		thisErddapUrl += dataset + "." + format;
		for (int i = 0; i < fields.Length; i++ ) {
		    if(i == 0){
				thisErddapUrl += "?";
			}
			else{
				thisErddapUrl += "%2C";
			}
			thisErddapUrl += fields[i];
			queryMade = true;
		}
		if(isDistinct){
			if(queryMade){
				thisErddapUrl += "&distinct()";
			} else {
				thisErddapUrl += "?distinct()";
				queryMade = true;
			}
		}
		return thisErddapUrl;
	}
}
}