﻿#Region "Microsoft.VisualBasic::1341ecae3ee74f50b83fc9b5e2f3dcc1, ..\httpd\WebCloud\SMRUCC.WebCloud.highcharts\Highcharts.vb"

    ' Author:
    ' 
    '       asuka (amethyst.asuka@gcmodeller.org)
    '       xieguigang (xie.guigang@live.com)
    '       xie (genetics@smrucc.org)
    ' 
    ' Copyright (c) 2018 GPL3 Licensed
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

Imports SMRUCC.WebCloud.highcharts.PolarChart

Public MustInherit Class Highcharts(Of T)

    Public Property chart As chart
    Public Property title As title
    Public Property subtitle As title
    Public Property yAxis As Axis
    Public Property xAxis As Axis
    Public Property tooltip As tooltip
    Public Property plotOptions As plotOptions
    Public Property legend As legendOptions
    Public Property series As T()
    Public Property responsiveOptions As responsiveOptions
    Public Property credits As credits

End Class

Public MustInherit Class Highcharts3D(Of T) : Inherits Highcharts(Of T)

    Public Property zAxis As Axis

End Class