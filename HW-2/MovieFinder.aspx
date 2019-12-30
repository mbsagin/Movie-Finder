<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MovieFinder.aspx.cs" Inherits="HW_2.WebForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Movie Finder</title>
    <style>
        h1, h2, h3, p {
            display: inline;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>     
            <h1>Enter a movie : </h1><input type="text" name="Title" id="movieTitle" runat="server" /><br />
            <h3>Movie Title : </h3>
            <p id="ttl" runat="server">-</p><br />
            <h3>Year : </h3>
            <p id="year" runat="server"></p><br />
            <h3>Released Date : </h3>
            <p id="release" runat="server">-</p><br />
            <h3>Genre : </h3>
            <p id="genre" runat="server">-</p><br />
            <h3>Director : </h3>
            <p id="director" runat="server">-</p><br />
            <h3>Actors : </h3>
            <p id="actors" runat="server">-</p><br />
            <h3>Language : </h3>
            <p id="lang" runat="server">-</p><br />
            <h3>Country : </h3>
            <p id="country" runat="server">-</p><br />
        </div>
    </form>
</body>
</html>
