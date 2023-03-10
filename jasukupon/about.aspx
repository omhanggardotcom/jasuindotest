<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="about.aspx.cs" Inherits="jasukupon.about" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta charset="utf-8">
<meta http-equiv="X-UA-Compatible" content="IE=edge">
<meta name="viewport" content="width=device-width, initial-scale=1">
    <link href="css/bootstrap.min.css" rel="stylesheet" type="text/css" />
    <script src="js/bootstrap.min.js" type="text/javascript"></script>
    <script src="js/jquery-3.3.1.min.js" type="text/javascript"></script>
    <script src="js/popper.min.js" type="text/javascript"></script>
    <title>About</title>
</head>
<body class="d-flex h-100 text-center">
<div class="cover-container d-flex w-100 h-100 p-3 mx-auto flex-column">
<div class="container">
<header class="justify-content-center py-3 mb-4 border-bottom">
      <a href="/" class="d-flex align-items-center mb-3 mb-md-0 me-md-auto text-dark text-decoration-none">
      <img width="225" src="images/logo-jasuindo-color.png" />
        <span class="fs-4"></span>
      </a>
    </header>
</div>
<main class="px-3">
    <h2>About This Application</h2>
    <img class="mb-4" src="images/3x4.jpg" />
    <p class="lead">This is an application to test the programming abilities of Mr. Prabowo Hangar Kesuma as a consideration for entering PT. Jasuindo Tiga Perkasa</p>
  </main>
<div class="container">
<footer class="d-flex flex-wrap justify-content-between align-items-center py-3 my-4 border-top">
    <p class="col-md-6 mb-0 text-muted">© 2023 Test Programming Jasuindo Prabowo Hanggar</p>
    <ul class="nav col-md-4 justify-content-end">
      <li class="nav-item"><a href="defaults.aspx" class="nav-link px-2 text-muted">Home</a></li>
      <li class="nav-item"><a href="faq.aspx" class="nav-link px-2 text-muted">FAQs</a></li>
      <li class="nav-item"><a href="about.aspx" class="nav-link px-2 text-muted">About</a></li>
    </ul>
    </footer></div>
</div>
</body>
</html>
