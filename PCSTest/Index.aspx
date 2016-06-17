<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="PCSTest.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div id="EmployeeList"> 
            <asp:GridView ID="gdvEmployeeList" runat="server">

            </asp:GridView>
        </div>
        <div id="EmployeeAddDiv">
            <table>
                <tr>
                    <td>
                        <label>Name*: </label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtEmpName" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <label>Gender*</label>
                    </td>
                    <td>
                        <asp:RadioButtonList ID="rdoGenderList" runat="server" >
                            <asp:ListItem Text="Male" Value="Male"></asp:ListItem>
                            <asp:ListItem Text="Female" Value="Female"></asp:ListItem> 
                            <asp:ListItem Text="Third Sex" Value="Third Sex"></asp:ListItem> 
                        </asp:RadioButtonList>
                    </td>
                </tr>
                <tr>
                    <td>
                        <label>DOB*</label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtDOB" runat="server"></asp:TextBox>
                        <asp:RegularExpressionValidator ID="validateDOB" ErrorMessage="Date Format(yyyy/mm/dd)" ControlToValidate="txtDOB" runat="server" ValidationExpression="\d{4}(?:/\d{1,2}){2}"></asp:RegularExpressionValidator> 
                    </td>
                </tr>
                <tr>
                    <td>
                        <label>Salary*</label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtSalary" runat="server"></asp:TextBox>
                        <asp:RegularExpressionValidator ID="validateSalary" ErrorMessage="Accepts integer only" runat="server" ControlToValidate="txtSalary" ValidationExpression="^[0-9]*$"></asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <table border="1">
                            <tr>
                                <td colspan="5">
                                    <label>Employee Qualification</label>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <label>Qualification: </label>
                                </td>
                                <td>
                                    <asp:DropDownList ID="empQualificationDropDown" runat="server"></asp:DropDownList>
                                </td>
                                <td>
                                    <label>Marks</label>
                                </td>
                                <td>
                                    <asp:TextBox ID="txtMarks" runat="server"></asp:TextBox>
                                </td>
                                <td>
                                    <asp:Button ID="btnAddEmpQualification"  runat="server" Text="Add" OnClick="btnAddEmpQualification_Click"/>
                                </td>
                            </tr>
                            <tr>
                                <td colspan="5">
                                   <asp:GridView ID="gdvEmployeeQualification" runat="server">
                                      
                                   </asp:GridView>
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button runat="server" ID="btnSubmit" Text="Submit" OnClick="btnSubmit_Click" />
                        <asp:Button runat="server" ID="btnCancel" Text="Cancel" />
                    </td>
                </tr>
            </table>
        </div>
    </div>
    </form>
</body>
</html>
