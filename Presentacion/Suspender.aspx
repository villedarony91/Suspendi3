<%@ Page Title="" Language="C#" MasterPageFile="~/Presentacion/NestedMaster.master" AutoEventWireup="true" CodeBehind="Suspender.aspx.cs" Inherits="Suspendidos.Presentacion.Suspender" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder" runat="server">
    <form id="form1" runat="server">
        <div class="container">
            <h5>Datos de la Suspensi&oacute;n <i class="material-icons left">thumb_down</i></h5>
            <div style="border: 2px solid #2979ff; margin: 4px 4px 4px 4px">
                <div class="row"></div>
                <div class="row">
                    <div class="input-field col s3 offset-s2">
                        <select runat="server" id="selectDepto" onchange="javascript:form1.submit();" onserverchange="selectDepto_ServerChange" enableviewstate="true">
                            <option value="" disabled selected>Choose one</option>
                        </select>
                        <label>Departamento</label>
                    </div>
                    <div class="input-field col s4">
                        <select id="selectMun" runat="server">
                            <option value="" disabled selected>Escoge uno</option>
                        </select>
                        <label>Municipio</label>
                    </div>
                    <div>
                       <button class="btn-floating waves-effect waves-light btn-large" runat="server" onserverclick="location_Click " id="btn2"><i class="material-icons">done</i></button>
                    </div>
                </div>
            </div>
        </div>
        <div class="container">
            <div class="row">
                <div class="input-field col s2">
                    <select disabled id="TipoSuspension" runat="server">
                        <option value="" disabled selected>Escoge uno</option>
                        <option value="1">Administrativa</option>
                        <option value="2">Penal</option>
                    </select>
                    <label>Tipo Suspension</label>
                </div>
                <div class="input-field col s2">
                    <select disabled id="TipoJuz" runat="server">
                        <option value="1" selected>Tribunal</option>
                        <option value="2">Juzgado</option>
                    </select>
                </div>
                <div class="input-field col s1"">
                    <input id="NoJuzgado" type="text" class="validate" runat="server" required disabled>
                    <label for="NoJuzgado">Juzgado</label>
                </div>
            </div>
            <div class="row">
                <div class="col s2">Fecha de Ingreso</div>
                <div class="col s2">Fecha de Egreso</div>
            </div>
            <div class="row">
                <div class="input-field col s2">
                    <input type="date" id="Ingreso" onchange="showDate(this)" runat="server" required disabled />
                </div>
                <div class="input-field col s2">
                    <input type="date" id="Egreso" onchange="showDate(this)" runat="server" required disabled />
                </div>
                <div class="input-field col s6">
                    <input id="Condena" type="text" class="validate" runat="server" required disabled>
                    <label for="Condena">Condena/Suspensi&oacute;n</label>
                </div>
                <div class="input-field col s2">
                    <input id="Providencia" type="text" class="validate" runat="server" required disabled>
                    <label for="Providencia">Providencia/Ejecutoria</label>
                </div>
                <div class="input-field col s6">
                    <input id="Resolucion" type="text" class="validate" runat="server" required disabled>
                    <label for="Resolucion">Resoluci&oacute;n</label>
                </div>
            </div>
        </div>
        <div class="container">
            <h5>Observaciones</h5>
            <textarea id="TextObservaciones" cols="20" rows="2" runat="server" style="background-color: white" disabled></textarea>
            <h5>Observaciones al Padr&oacute;n</h5>
            <textarea id="TextObservacionesPadron" cols="20" rows="2" runat="server" style="background-color: white" disabled></textarea>
            <div class="row"></div>
            <div class="center-align">
                <a class="waves-effect waves-light btn-large center-align">
                    <input type="submit" runat="server" id="btnSuspend"
                        onserverclick="btnSuspend_ServerClick" value="Suspender" /><i class="material-icons left">thumb_down</i></a>
            </div>
        </div>
    </form>
    <script>
        function showDate(input) {
            validate(input.value);
        }
        function validate(input) {
            var m = input.match(/^\d{4}-\d{1,2}-\d{1,2}$/);
            if (input.match(m)) {
            }
            else {
                alert("Fecha en formato incorrecto");
            }
        }
    </script>
</asp:Content>
