<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="Website.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">


     <!DOCTYPE html>
  
<head>
 
  <title>About Me</title>
  <meta charset="utf-8">
  <meta name="viewport" content="width=device-width, initial-scale=1">
  <link rel="stylesheet" href="http://maxcdn.bootstrapcdn.com/bootstrap/3.3.6/css/bootstrap.min.css">
  <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.12.2/jquery.min.js"></script>
         
  <script src="http://maxcdn.bootstrapcdn.com/bootstrap/3.3.6/js/bootstrap.min.js"></script>
</head>
<body>
    
    <link rel="stylesheet" type="text/css" href="site.css"/>
 
  


<div class="container">
        <div class="row">
        <div class="row col-md-8">
            
            </div>
            </div>
    <div class="row">
        <div class="col-md-4">
            <div class="panel panel-primary">
  <div class="panel-heading">Contact info</div>
  <div class="panel-body">
 
       <address>
  <strong>Brandon Roy</strong><br>
  17 Newton Barrie<br>
  Barrie,Ontario<br>
 (705) 4444095<br />
  <a href="mailto:#">brandonroycstn@hotmail.com</a>
</address>
      </div>

                </div>
            </div>
        </div>

</div>


 <asp:Form>
    <div class="col-md-6">
     
        <div class="form-group">
           
        <label class="control-label" for="NameTextBox">Name</label>
        <asp:TextBox runat="server" Cssclass="form-control" ID="NameTextBox" placeholder="Name" required="true"></asp:TextBox> 
       <asp:RequiredFieldValidator CssClass="alert-danger" Display="Dynamic" ID="RequiredFieldValidator1" runat="server" ErrorMessage="Name is required" ControlToValidate="NameTextBox" SetFocusOnError="true"></asp:RequiredFieldValidator>  
          
            
         <div class="form-group">
        <label class="control-label" for="emailTextBox">email</label>
        <asp:TextBox runat="server" TextMode="email" Cssclass="form-control" ID="emailTextBox" placeholder="email" required="true"></asp:TextBox> 
             <asp:RequiredFieldValidator Display="Dynamic" ID="RequiredFieldValidator3" runat="server" ErrorMessage="email is required" ControlToValidate="emailTextBox" SetFocusOnError="true"></asp:RequiredFieldValidator>   </div>
          <div class="form-group">
          </div>

                  
         <div class="form-group">
        <label class="control-label" for="SubjectTextBox">Subject</label>
        <asp:TextBox runat="server"  Cssclass="form-control" ID="SubjectTextBox" placeholder="Subject" required="true"></asp:TextBox> 
             <asp:RequiredFieldValidator Display="Dynamic" ID="RequiredFieldValidator2" runat="server" ErrorMessage="Subject is required" ControlToValidate="SubjectTextBox" SetFocusOnError="true"></asp:RequiredFieldValidator>   </div>
          <div class="form-group">
          </div>

         <div class="form-group">
        <asp:TextBox runat="server" TextMode="MultiLine" Columns="12" Rows="12" Cssclass="form-control" ID="MessageTextBox" placeholder="Your message goes here" required="true"></asp:TextBox> 
            
                 <div class="text-left">
          
                   <asp:Button  CssClass="btn btn-primary btn-lg" ID="SubmitButton" Text="Submit" OnClick="Submit_Click"  runat="server" />
                    
   
        <div class="text-right">
            <a ID="CancelButton" Text="Cancel" href="Home page.aspx" />
                   <asp:Button  CssClass="btn btn-primary btn-lg"   Style="margin-left:auto; display:block;" ID="Cancel" Text="Cancel" runat="server" />
             </div>
       
        </div>
</asp:Form>




</body>
        </html>
</asp:Content>
  