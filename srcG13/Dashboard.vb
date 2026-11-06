Option Strict On
Option Explicit On

Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms.DataVisualization.Charting

Public Class Dashboard

    ' ปรับให้ตรงกับของคุณ หรือใช้ My.Settings หากตั้งไว้ใน Settings
    Private ReadOnly CONN_STR As String =
        My.Settings.DataDictionaryConnectionString
    ' ตัวอย่างแบบกำหนดเอง:
    ' "Server=.\SQLEXPRESS;Database=DataDictionary;Trusted_Connection=True;"

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Wellmeadows Hospital Dashboard"
        InitChartsAppearance()
        LoadCharts()
    End Sub

    ' -------------------- เตรียมหน้าตากราฟ --------------------
    Private Sub InitChartsAppearance()
        ' Pie ต้องมี Legend (ตั้งชื่อเองได้ เช่น "Legend" หรือ "Legend1")
        PrepareChart(chartBedStatus, "Bed Status", SeriesChartType.Pie, legendName:="Legend")
        chartBedStatus.ChartAreas(0).Area3DStyle.Enable3D = True

        ' Column ไม่จำเป็นต้องมี Legend
        PrepareChart(chartBedsPerWard, "Beds per Ward", SeriesChartType.Column)
        chartBedsPerWard.ChartAreas(0).AxisX.LabelStyle.Angle = -20
    End Sub

    ' เคลียร์ของเก่า + สร้าง ChartArea/Legend/Series ใหม่ให้ถูกต้อง
    Private Sub PrepareChart(ch As Chart, title As String, chartType As SeriesChartType, Optional legendName As String = "")
        ch.SuspendLayout()

        ch.Series.Clear()
        ch.ChartAreas.Clear()
        ch.Titles.Clear()
        ch.Legends.Clear()

        ch.ChartAreas.Add(New ChartArea("Area1"))
        ch.Titles.Add(title)

        If legendName <> "" Then
            If ch.Legends.IndexOf(legendName) < 0 Then
                ch.Legends.Add(New Legend(legendName))
            End If
        End If

        Dim s As New Series("S1") With {
            .ChartType = chartType,
            .IsValueShownAsLabel = True
        }
        s.Legend = If(legendName <> "", legendName, String.Empty)

        ch.Series.Add(s)
        ch.ResumeLayout()
    End Sub

    ' -------------------- โหลดข้อมูล + วาดกราฟ --------------------
    Private Sub LoadCharts()
        Try
            Using cn As New SqlConnection(CONN_STR)
                cn.Open()
                BuildBedStatusChart(cn)
                BuildBedsPerWardChart(cn)
            End Using
        Catch ex As Exception
            MessageBox.Show("โหลดกราฟไม่สำเร็จ: " & ex.Message, "Dashboard", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Pie: สถานะเตียง (Available / Occupied / อื่น ๆ)
    Private Sub BuildBedStatusChart(cn As SqlConnection)
        Dim s = chartBedStatus.Series("S1")
        s.Points.Clear()

        Dim sql As String =
"SELECT
    COALESCE(NULLIF(LTRIM(RTRIM(B_Status)), ''), 'Unknown') AS StatusName,
    COUNT(*) AS Cnt
 FROM dbo.Bed
 GROUP BY COALESCE(NULLIF(LTRIM(RTRIM(B_Status)), ''), 'Unknown')
 ORDER BY StatusName;"

        Dim dt = ExecuteDataTable(cn, sql)
        For Each row As DataRow In dt.Rows
            Dim name As String = CStr(row("StatusName"))
            Dim cnt As Integer = CInt(row("Cnt"))
            s.Points.AddXY(name, cnt)
        Next
    End Sub

    ' Column: จำนวนเตียงต่อวอร์ด (ใช้ชื่อวอร์ด ถ้าไม่มีใช้ W_ID)
    Private Sub BuildBedsPerWardChart(cn As SqlConnection)
        Dim s = chartBedsPerWard.Series("S1")
        s.Points.Clear()

        Dim sql As String =
"SELECT 
    COALESCE(NULLIF(LTRIM(RTRIM(w.W_Name)), ''), CONCAT('Ward ', CAST(w.W_ID AS varchar(10)))) AS WardLabel,
    COUNT(*) AS BedCount
 FROM dbo.Bed AS b
 INNER JOIN dbo.Ward AS w ON w.W_ID = b.W_ID
 GROUP BY COALESCE(NULLIF(LTRIM(RTRIM(w.W_Name)), ''), CONCAT('Ward ', CAST(w.W_ID AS varchar(10)))), w.W_ID
 ORDER BY w.W_ID;"

        Dim dt = ExecuteDataTable(cn, sql)
        For Each row As DataRow In dt.Rows
            Dim label As String = CStr(row("WardLabel"))
            Dim countBeds As Integer = CInt(row("BedCount"))
            s.Points.AddXY(label, countBeds)
        Next
    End Sub

    ' -------------------- Utilities --------------------
    Private Function ExecuteDataTable(cn As SqlConnection, sql As String) As DataTable
        Using cmd As New SqlCommand(sql, cn)
            cmd.CommandType = CommandType.Text
            Using da As New SqlDataAdapter(cmd)
                Dim dt As New DataTable()
                da.Fill(dt)
                Return dt
            End Using
        End Using
    End Function

    ' (อีเวนต์คลิก จะมีหรือไม่มีก็ได้)
    Private Sub chartBedStatus_Click(sender As Object, e As EventArgs) Handles chartBedStatus.Click
    End Sub

    Private Sub chartBedsPerWard_Click(sender As Object, e As EventArgs) Handles chartBedsPerWard.Click
    End Sub

    Private Sub PanelDashboard_Paint(sender As Object, e As PaintEventArgs) Handles PanelDashboard.Paint

    End Sub
End Class
