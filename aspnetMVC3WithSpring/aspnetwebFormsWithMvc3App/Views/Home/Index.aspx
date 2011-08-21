<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>The MVC Page using ASPX Syntax</title>
</head>
<body>
    <h1>This is a page that is rendered via MVC3.  Hello <%= ViewBag.UserName%> Welcome to MVC3!</h1>
</body>
</html>
