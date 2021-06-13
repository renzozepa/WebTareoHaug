<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebTareoHaug.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=UTF-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1, maximum-scale=1.0, user-scalable=no" />
    <title>Haug Tareo</title>
    <!-- Latest compiled and minified CSS -->
    <link type="text/css" rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.6/css/bootstrap.min.css"
        integrity="sha384-1q8mTJOASx8j1Au+a5WDVnPi2lkFfwwEAa8hDDdjZlpLegxhjVME1fgjWPGmkzs7"
        crossorigin="anonymous" />

    <script type="text/javascript" src="http://code.jquery.com/jquery-1.11.1.min.js"></script>
    <script type="text/javascript" src="http://code.jquery.com/ui/1.11.1/jquery-ui.min.js"></script>
    <link rel="stylesheet" href="https://code.jquery.com/ui/1.11.1/themes/smoothness/jquery-ui.css" />
</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <div class="container">
            <div id="loginbox" style="margin-top: 50px;" class="mainbox col-md-6 col-md-offset-3 col-sm-8 col-sm-offset-2">
                <div class="panel panel-info">
                    <div class="panel-heading">
                        <div class="panel-title">
                            Haug Tareo
                        </div>
                        <div style="float: right; font-size: 80%; position: relative; top: -10px">
                        </div>
                    </div>
                    <div style="padding-top: 30px" class="panel-body">
                        <div style="display: none" id="login-alert" class="alert alert-danger col-sm-12">
                        </div>
                        <div style="margin-bottom: 25px" class="input-group">
                            <span class="input-group-addon"><i class="glyphicon glyphicon-user"></i></span>
                            <asp:TextBox ID="txtusername" runat="server" class="form-control" placeholder="Usuario"></asp:TextBox>
                        </div>
                        <div style="margin-bottom: 25px" class="input-group">
                            <span class="input-group-addon"><i class="glyphicon glyphicon-lock"></i></span>
                            <asp:TextBox ID="txtpassword" runat="server" TextMode="Password" class="form-control"
                                placeholder="Clave"></asp:TextBox>
                        </div>
                        <div style="margin-top: 10px" class="form-group">
                            <div class="col-sm-12 controls">
                                <asp:Button ID="BtnLogin" runat="server" class="btn btn-success" Text="Login" Width="100px" OnClick="BtnLogin_Click" />
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>

        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <div id="dialog" style="display: none">
                </div>
            </ContentTemplate>
        </asp:UpdatePanel>
    </form>  
</body>
</html>
