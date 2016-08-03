<%@ Page Title="" Language="C#" MasterPageFile="~/Presentacion/Master.Master" AutoEventWireup="true" CodeBehind="Search.aspx.cs" Inherits="Suspendidos.Search" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder" runat="server">
    <form id ="form1" runat="server">
    <div class="row"></div>
    <div class="row">
        <div class="row">
            <div class="input-field col s3">
                <i class="material-icons prefix">account_circle</i>
                <input id="boletaInput" type="text" class="validate" runat="server">
                <label for="boletaInput">No. de Boleta</label>

            </div>
            <div class="switch col s2">
                <label>
                    Off
                     <asp:CheckBox ID="checkBoleta" runat ="server" AutoPostBack="true" OnCheckedChanged="checkBoleta_CheckedChanged"/>
                    <span class="lever"></span>
                    On
                </label>
            </div>
            <div class="input-field col s3">
                <i class="material-icons prefix">account_circle</i>
                <input id="DpiInput" type="tel" class="validate" runat="server">
                <label for="DpiInput">No. DPI</label>
            </div>
     
            <div class="switch col s2" runat="server">
                <label onserverclick="dpiChanged" runat="server">
                    Off
                    <asp:CheckBox ID="checkDpi" runat ="server" AutoPostBack="true"  OnCheckedChanged="checkDpi_CheckedChanged"  />
                    <span class="lever"></span>
                    On
                </label>
            </div>
            <div>
                <a class="waves-effect waves-light btn-large" runat="server" onserverclick="searchEvent">Buscar</a>
            </div>
        </div>
    </div>
    <div class="divider"></div>
    <div class="container" runat="server">
        <div class="row">
            <h5>Datos del Ciudadano</h5>
            <div class="input-field col s1">

                <input disabled id="Estado" type="text" class="validate" runat="server">
                <label for="Estado">Estado</label>
            </div>

            <div class="input-field col s3">
                <input disabled id="Boleta" type="text" class="validate" runat="server">
                <label for="Boleta">N&uacute;mero de Boleta</label>
            </div>
            <div class="input-field col s3">
                <input disabled id="Dpi" type="text" class="validate" runat="server">
                <label for="Dpi">DPI</label>
            </div>
        </div>

        <div class="divider"></div>

        <div class="row">
            <div class="input-field col s2">
                <input disabled  id="firstName" type="text" class="validate" runat="server">
                <label for="disabled">Primer Nombre</label>
            </div>
            <div class="input-field col s2">
                <input disabled  id="SecondName" type="text" class="validate" runat="server">
                <label for="disabled">Segundo Nombre</label>
            </div>
            <div class="input-field col s2">
                <input disabled  id="LastName1" type="text" class="validate" runat="server">
                <label for="disabled">Primer apellido</label>
            </div>
            <div class="input-field col s2">
                <input disabled id="LastName2" type="text" class="validate" runat="server">
                <label for="disabled">Segundo apellido</label>
            </div>
            <div class="input-field col s2">
                <input disabled id="LastName3" type="text" class="validate" runat="server">
                <label for="disabled">Tercer apellido</label>
            </div>
        </div>
        <div class="divider"></div>
        <div class="row">
            <div class="input-field col s3 offset-s2">
                <input disabled id="Departamento" type="text" class="validate" runat="server">
                <label for="disabled">Departamento</label>
            </div>
            <div class="input-field col s3">
                <input disabled id="Municipio" type="text" class="validate" runat="server">
                <label for="disabled">Municipio</label>
            </div>
        </div>
    </div>
    <div class="fixed-action-btn horizontal" style="bottom: 45px; right: 24px;">
        <a class="btn-floating btn-large red">
            <i class="large material-icons">mode_edit</i>
        </a>
        <ul>
            <li><a class="btn-floating blue"><i class="material-icons">clear_all</i></a></li>
            <li><a class="btn-floating green" id="float_enable" runat="server" onserverclick="float_enable_ServerClick"><i class="material-icons">thumb_up</i></a></li>
            <li><a class="btn-floating red" id="float_suspend" runat="server" onserverclick="float_suspend_ServerClick"><i class="material-icons">thumb_down</i></a></li>
        </ul>
    </div>
       
    <asp:ScriptManager ID="ScriptManager1" runat="server" EnablePageMethods="true" />
         </form>
    <script>
        function showToast(message) {
            Materialize.toast(message, 3000, "rounded");
        }
    </script>
</asp:Content>

