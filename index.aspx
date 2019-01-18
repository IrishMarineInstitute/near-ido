<%@ Page Language="C#" %>
<%@ Import Namespace="System.Net"%>

<script runat="server">
	protected void Page_Load(Object Source, EventArgs E){
		nearIDO thisNIDO = new nearIDO();
		Output.Text = thisNIDO.json;
	}
</script>

<!DOCTYPE html>
<html>
<head runat="server">
    <title>Near Service | DigitalOcean.ie</title>
	<link rel="shortcut icon" href="favicon.ico" type="image/x-icon" />
</head>
<body>
	<div>
		<a href="http://www.digitalocean.ie"><img src="img/IDO_Banner.png" /></a>
	</div>
    <div>
        <asp:Label runat="server" id="Output"></asp:Label>
    </div>
</body>
</html>