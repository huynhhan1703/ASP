<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DonDatHang.aspx.cs" Inherits="ASPBT03.DonDatHang" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .btnInDon {
            background-color:#4cff00 ;
           
        }
        .colorxanhchuoi {
          color:#106c34;
          
        }
       
        .auto-style4 {
            height: 35px;
        }
        .auto-style8 {
            width: 409px;
            text-align: center;
        }
        .auto-style9 {
            color: #106c34;
            width: 409px;
        }
        .auto-style10 {
            width: 243px;
        }
        .auto-style11 {
            width: 409px;
            text-align: center;
            margin-left: 120px;
        }
    </style>
    <link href="Content/bootstrap.min.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="container w-50">
            <table cellpadding="5" class="border border-success w-100">
                <tr>
                    <td colspan="2"class="text-center alert alert-primary fw-bold border border-success h1">ĐƠN ĐẶT HÀNG</td>
                </tr>
                <tr>
                    <td class="auto-style10">Khách hàng</td>
                    <td class="auto-style4">
                        <asp:TextBox ID="txtKhachHang" runat="server" CssClass="form-control"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style10">Địa chỉ</td>
                    <td>
                        <asp:TextBox ID="txtDiaChi" runat="server" CssClass="form-control"></asp:TextBox>
                    </td>
                </tr>
                <tr class="border-bottom border-success">
                    <td class="auto-style10">Mã số thuế</td>
                    <td>
                        <asp:TextBox ID="txtMSThue" runat="server" OnTextChanged="TextBox3_TextChanged" CssClass="form-control" ></asp:TextBox>
                    </td>
                </tr>
               </table>
                <table  cellpadding="5" class="border border-success  w-100">
                <tr>
                    <td class="auto-style9 h3" ><strong>Chọn các loại bánh sau:</strong></td>
                    <td class="text-center  border-start  border-success colorxanhchuoi h3"><strong>Danh sách bánh được đặt:</strong></td>
                </tr>
                
                <tr>
                    <td class="auto-style8">
                        <asp:DropDownList ID="ddlLoaiBanh" runat="server" CssClass="form-select " Width="403px">
                        </asp:DropDownList>
                    </td>
                    <td rowspan="3" class="text-center border-start  border-success">
                        <asp:ListBox ID="lstDanhSach" runat="server" SelectionMode="Multiple" CssClass="form-control mb-2"></asp:ListBox>
                        <asp:Button ID="btnXoa" runat="server" Text="Xóa" OnClick="btnXoa_Click" />
                    </td>
                </tr>
                <tr >
                    <td class="auto-style8">Số lượng:
                     <asp:TextBox ID="txtSoLuong" runat="server"  requied=""  Width="185px"></asp:TextBox> 
                        cái</td>
                
                </tr>
                <tr >
                    <td class="auto-style11">
                        <asp:Label ID="lblErrorMessage" runat="server"></asp:Label>
                          <br />
                        <asp:Button ID="btnNext" runat="server" Text=">" OnClick="btnNext_Click" />
                    </td>
                </tr>
                      
                <tr>
                    <td colspan="2" class="text-center  border border-success pb-0">
                        <strong>    
                        <asp:Button ID="btnInDon" runat="server" Text="In đơn đặt hàng" CssClass="btnInDon border border-success h3 pb-1" style="font-weight: bold" OnClick="btnInDon_Click" />
                        </strong>
                    </td>
                </tr>
                 
                </table>
                 <tr>
                    <td  colspan="2">
                        <asp:Label ID="lbInDon" runat="server"></asp:Label>
                          </td>
                </tr>
          
        </div>
    </form>
</body>
</html>
