﻿#Region "Microsoft.VisualBasic::492c864bd363d90fd4e5615a588d4511, ..\httpd\HTTP_SERVER\demo\DemoWebApp\ExampleApp.vb"

    ' Author:
    ' 
    '       asuka (amethyst.asuka@gcmodeller.org)
    '       xieguigang (xie.guigang@live.com)
    '       xie (genetics@smrucc.org)
    ' 
    ' Copyright (c) 2016 GPL3 Licensed
    ' 
    ' 
    ' GNU GENERAL PUBLIC LICENSE (GPL3)
    ' 
    ' This program is free software: you can redistribute it and/or modify
    ' it under the terms of the GNU General Public License as published by
    ' the Free Software Foundation, either version 3 of the License, or
    ' (at your option) any later version.
    ' 
    ' This program is distributed in the hope that it will be useful,
    ' but WITHOUT ANY WARRANTY; without even the implied warranty of
    ' MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    ' GNU General Public License for more details.
    ' 
    ' You should have received a copy of the GNU General Public License
    ' along with this program. If not, see <http://www.gnu.org/licenses/>.

#End Region

Imports Microsoft.VisualBasic.CommandLine.Reflection
Imports Microsoft.VisualBasic.Serialization.JSON
Imports SMRUCC.WebCloud.HTTPInternal.AppEngine.APIMethods
Imports SMRUCC.WebCloud.HTTPInternal.AppEngine.APIMethods.Arguments
Imports SMRUCC.WebCloud.HTTPInternal.Platform

<[Namespace]("Example")>
Public Class ExampleApp : Inherits SMRUCC.WebCloud.HTTPInternal.AppEngine.WebApp

    Public Sub New(main As PlatformEngine)
        MyBase.New(main)
    End Sub

    <[GET](GetType(Integer()))>
    <ExportAPI("/example/test.json")>
    Public Function JsonExample(req As HttpRequest, response As HttpResponse) As Boolean
        Dim test As Integer() = {1, 2, 3, 4, 5, 6, 11, 2, 3, 689, 3453, 4}  ' replace this with your operation code, something like sql query result.
        Call response.WriteJSON(test)
        Call response.WriteHTML("<br/>")
        Call response.WriteJSON(req)
        Return True
    End Function

    <[POST](GetType(Integer()))>
    <ExportAPI("/example/post.html")>
    Public Function PostTest(req As HttpPOSTRequest, response As HttpResponse) As Boolean
        Call response.Write(req.POSTData.Form.ToDictionary.GetJson)
        Return True
    End Function

    <[GET](GetType(String))>
    <ExportAPI("/example/redirect.vb")>
    Public Function redirectTest(req As HttpRequest, response As HttpResponse) As Boolean
        Return response <= "./form.vb"
    End Function

    <[GET](GetType(String))>
    <ExportAPI("/example/form.vb")>
    Public Function GetwebForm(req As HttpRequest, response As HttpResponse) As Boolean
        response.WriteHTML(<form method="POST" action="./post.html">
First name:<br/>
                               <input type="text" name="firstname" value="Mickey"/>
                               <br/>
Last name:<br/>
                               <input type="text" name="lastname" value="Mouse"/>
                               <br/><br/>
                               <input type="submit" value="Submit"/>
                           </form>)

        Return True
    End Function

    Public Overrides Function Page404() As String
        Return ""
    End Function
End Class

