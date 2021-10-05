Imports GMap.NET
Imports GMap.NET.WindowsForms
Imports System
Imports System.IO.Ports

Public Class Form1
    Private copter_lat, copter_lon As Double
    Private WithEvents copter_marker As Markers.GMarkerGoogle
    Private WithEvents copter_layer As GMapOverlay

    Dim comPORT As String
    Dim receivedData As String = ""
    Dim RD_Note As String = ""

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

        Timer1.Enabled = False
        comPORT = ""
        For Each sp As String In My.Computer.Ports.SerialPortNames
            comPort_ComboBox.Items.Add(sp)
        Next


        '-7.2767636,112.7949036   18.3133495,105.9176342,17z/
        copter_lat = 21.0198421
        copter_lon = 105.7974476


        myMap.MinZoom = 5
        myMap.MaxZoom = 20
        myMap.Zoom = 17
        myMap.Position = New PointLatLng(copter_lat, copter_lon)
        myMap.MapProvider = MapProviders.BingSatelliteMapProvider.Instance
        myMap.Manager.Mode = AccessMode.ServerAndCache
        copter_marker = New Markers.GMarkerGoogle(New PointLatLng(copter_lat, copter_lon), Markers.GMarkerGoogleType.red)

        copter_layer = New GMapOverlay()
        copter_layer.Markers.Add(copter_marker)

        myMap.Overlays.Add(copter_layer)
    End Sub

    Private Sub tmr1_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles tmr1.Tick
        Randomize()
        Dim delta_lat As Double = ((100 * Rnd()) + 20) / 10000000.0
        Dim delta_lon As Double = ((100 * Rnd()) + 20) / 10000000.0
        Dim not_lat As Single = Rnd()
        Dim not_lon As Single = Rnd()

        If not_lat >= 0.5 Then
            copter_lat += delta_lat
        Else
            copter_lat -= delta_lat
        End If
        If not_lon >= 0.5 Then
            copter_lon += delta_lon
        Else
            copter_lon -= delta_lon
        End If

        update_map()
    End Sub

    Private Sub btnMove_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnMove.Click
        receivedData = ReceiveSerialData()
        MsgBox(receivedData)
        If tmr1.Enabled Then
            tmr1.Enabled = False
            MsgBox("Random Move stop")
        Else
            tmr1.Enabled = True
            MsgBox("Random Move start")
        End If
    End Sub

    Private Sub myMap_OnMapZoomChanged() Handles myMap.OnMapZoomChanged
        lblInfo.Text = "Info : Lat= " + CStr(copter_lat) + ", Lon= " + CStr(copter_lon) + ", Zoom Level= " + CStr(myMap.Zoom)
    End Sub

    Private Sub update_map()
        copter_marker.Position = New PointLatLng(copter_lat, copter_lon)
        myMap.UpdateMarkerLocalPosition(copter_marker)
        lblInfo.Text = "Info : Lat= " + CStr(copter_lat) + ", Lon= " + CStr(copter_lon) + ", Zoom Level= " + CStr(myMap.Zoom)
    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
    Public Function custom_split(str As String, num As Long, Optional delimeter As String = " ") As String
        Dim substrs() As String
        substrs = Split(str, delimeter)
        If UBound(substrs) < num Then
            custom_split = ""
        Else
            custom_split = Trim(substrs(num))
        End If
    End Function

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        receivedData = ReceiveSerialData()
        If receivedData <> "" Then
            RichTextBox2.Text = receivedData
        End If
        RichTextBox1.Text &= receivedData

    End Sub

    Private Sub connect_BTN_Click(sender As Object, e As EventArgs) Handles connect_BTN.Click
        If (connect_BTN.Text = "Connect") Then
            If (comPORT <> "") Then
                SerialPort1.Close()
                SerialPort1.PortName = comPORT
                SerialPort1.BaudRate = 9600
                SerialPort1.DataBits = 8
                SerialPort1.Parity = Parity.None
                SerialPort1.StopBits = StopBits.One
                SerialPort1.Handshake = Handshake.None
                SerialPort1.Encoding = System.Text.Encoding.Default 'very important!
                SerialPort1.ReadTimeout = 10000

                SerialPort1.Open()
                connect_BTN.Text = "Dis-connect"
                Timer1.Enabled = True
                Timer_LBL.Text = "Timer: ON"
            Else
                MsgBox("Select a COM port first")
            End If
        Else
            SerialPort1.Close()
            connect_BTN.Text = "Connect"
            Timer1.Enabled = False
            Timer_LBL.Text = "Timer: OFF"
        End If
    End Sub
    Function ReceiveSerialData() As String
        Dim Incoming As String
        Try
            Incoming = SerialPort1.ReadExisting()
            If Incoming Is Nothing Then
                Return "nothing" & vbCrLf
            Else
                Return Incoming
            End If
        Catch ex As TimeoutException
            Return "Error: Serial Port read timed out."
        End Try

    End Function
    Private Sub comPort_ComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comPort_ComboBox.SelectedIndexChanged
        If (comPort_ComboBox.SelectedItem <> "") Then
            comPORT = comPort_ComboBox.SelectedItem
        End If
    End Sub

    Private Sub clear_BTN_Click(sender As Object, e As EventArgs) Handles clear_BTN.Click
        RichTextBox1.Text = ""
    End Sub

    Private Sub Tracking_Click(sender As Object, e As EventArgs) Handles Tracking.Click
        copter_lat = TextLAT.Text
        copter_lon = TextLON.Text
        update_map()
    End Sub

    Public Function distance(ByVal lat1 As Double, ByVal lon1 As Double, ByVal lat2 As Double, ByVal lon2 As Double, ByVal unit As Char) As Double
        If lat1 = lat2 And lon1 = lon2 Then
            Return 0
        Else
            Dim theta As Double = lon1 - lon2
            Dim dist As Double = Math.Sin(deg2rad(lat1)) * Math.Sin(deg2rad(lat2)) + Math.Cos(deg2rad(lat1)) * Math.Cos(deg2rad(lat2)) * Math.Cos(deg2rad(theta))
            dist = Math.Acos(dist)
            dist = rad2deg(dist)
            dist = dist * 60 * 1.1515
            If unit = "K" Then
                dist = dist * 1.609344
            ElseIf unit = "N" Then
                dist = dist * 0.8684
            End If
            Return dist
        End If
    End Function

    Private Function deg2rad(ByVal deg As Double) As Double
        Return (deg * Math.PI / 180.0)
    End Function

    Private Function rad2deg(ByVal rad As Double) As Double
        Return rad / Math.PI * 180.0
    End Function

    Private Sub Checklast_Click(sender As Object, e As EventArgs) Handles Checklast.Click
        RichTextBox3.Text = distance(-7.2767636, 112.7949036, copter_lat, copter_lon, "K")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim StrSend As String
        Dim StrSplit() As String
        StrSend = RichTextBox4.Text
        StrSplit = RichTextBox4.Text.Split("|"c)
        For Each s As String In StrSplit
            RichTextBox4.Text = StrSplit(0) + StrSplit(2)
        Next
    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged

    End Sub

    Private Sub myMap_Load(sender As Object, e As EventArgs) Handles myMap.Load

    End Sub

    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub lblInfo_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TênToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TênToolStripMenuItem.Click

    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
End Class