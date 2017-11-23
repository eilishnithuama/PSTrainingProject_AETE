<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ApplyForCreditCard.aspx.cs" Inherits="BankingSite.Pages.ApplyForCreditCard" %>

<!DOCTYPE html>


<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Credit Card Application</title>
    <link href="styles/site.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Credit Card Application</h1>
        <fieldset>
            <legend>Personal Details</legend>

            <label for="FistName">First Name</label>
            <asp:TextBox runat="server" ID="FirstName"/>
            
            <label for="SecondName">Second Name</label>
            <asp:TextBox runat="server" ID="SecondName"/>
            
            <label for="EmailAddress">Email Address</label>
            <asp:TextBox runat="server" ID="EmailAddress"/>
        </fieldset>
        
        <fieldset>
            <legend>Financial Information</legend>
            
            <label for="AnnualIncome">Annual Income</label>
            <asp:TextBox runat="server" ID="AnnualIncome"/>
            
            <h3>Existing Credit Cards</h3>
            <div id="existingCards">
                <label for="CCLimit1">Card 1 Credit Limit</label>
                <asp:TextBox runat="server" ID="CCLimit1"/>
                
                <label for="CCLimit2">Card 2 Credit Limit</label>
                <asp:TextBox runat="server" ID="CCLimit2"/>

                <label for="CCLimit3">Card 3 Credit Limit</label>
                <asp:TextBox runat="server" ID="CCLimit3"/>

            </div>


        </fieldset>
        
        
          <fieldset>
            <legend>Other Information</legend>                
                <label for="AirlineRewardNumber">Airline Rewards Membership Number</label>              
                <asp:TextBox runat="server" ID="AirlineRewardNumber"/>
           </fieldset>
        
        <asp:Button runat="server" ID="ApplyNow" Text="Apply Now!" OnClick="ApplyNow_OnClick"></asp:Button>

    </div>
    </form>
</body>
</html>

