<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="DataGridview_Add_Dynamic.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table border="1">
             <asp:gridview ID="Gridview1" runat="server" ShowFooter="true" AutoGenerateColumns="false"  OnRowDeleting="GridView1_RowDeleting">
                
                 <Columns>
                     <asp:BoundField DataField="ID_Row" HeaderText="ID" />
                     <asp:BoundField DataField="Name" HeaderText="Name" />
                     <asp:BoundField DataField="Gender" HeaderText="Gender" />
                     <asp:BoundField DataField="Country" HeaderText="Country" />

                     <asp:TemplateField HeaderText="Action">
                         <ItemTemplate>
                             <asp:Button runat="server" Text="Delete" CommandName="Delete" />
                         </ItemTemplate>

                     </asp:TemplateField>
                </Columns>

            </asp:gridview>
        </table>

        <table border="1">
            <tr>
                <td>
                    Name
                </td>
                <td>
                    <asp:TextBox id="txtName" runat="server" />
                </td>
            </tr> 

            <tr>
                <td>
                    Gender
                </td>
                <td>
                    <asp:TextBox id="txtGender" runat="server" />
                </td>
            </tr> 
            <tr>
                <td>
                    Country
                </td>
                <td>
                    <asp:TextBox id="txtCountry" runat="server" />
                </td>
            </tr> 
             
             <tr>
                <td>
                    <asp:Button id="btnSubmit" Text="Submit" runat="server" OnClick="btnSubmit_Click" />
                </td>
            </tr> 
        

        </table>
       

    </div>
    </form>
</body>
</html>
