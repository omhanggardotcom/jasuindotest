<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="defaults.aspx.cs" Inherits="jasukupon.defaults" %>

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
    <title>Generate Coupons</title>
</head>
<body>
<div class="container">
<header class="justify-content-center py-3 mb-4 border-bottom">
      <a href="/" class="d-flex align-items-center mb-3 mb-md-0 me-md-auto text-dark text-decoration-none">
      <img width="225" src="images/logo-jasuindo-color.png" />
        <span class="fs-4"></span>
      </a>
    </header>
</div>
<main>
    <div class="container body-content">
     <div class="py-1 text-center">
        <h2>Generate Coupons Application</h2>
     </div>
    </div>
    <form class="card p-2 container" id="form1" runat="server">
    <div class="row g-5">
        <div class="col-md-5 col-lg-4">
        
        <asp:Label runat="server" ID="lblstatus" style="color: white;"/>
          <div class="input-group">
          <div class="col-12">
          <asp:TextBox ID="numberCp" runat="server" class="form-control" placeholder="Maksimum Number of Coupons" required></asp:TextBox>
          </div>
          <div class="col-12">
          <asp:TextBox ID="box" runat="server" class="form-control" placeholder="How Many Box" required></asp:TextBox>
          </div>
          <div class="col-12">
            <asp:Button ID="btnGen" runat="server" Text="Generate" class="btn btn-secondary" onclick="btnGen_Click"></asp:Button>
          </div>
          </div>
        </div>
        <div class="col-md-7 col-lg-8">
            <div class="table-responsive">
            <asp:GridView ID="GridView1" runat="server" class="table table-striped table-sm" data-search="true"></asp:GridView>
            </div>
            
        </div>
    </div>
    </form>
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
</body>
</html>
