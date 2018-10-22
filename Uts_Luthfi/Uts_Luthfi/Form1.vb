Imports System.Data.SqlClient
Public Class Form1
    Dim cmd_gl As SqlCommand
    Dim dr_gl As SqlDataReader
    Dim query_gl As String

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call OpenKoneksi()
        Dim cmd As SqlCommand
        Dim dr As SqlDataReader
        Dim strsql As String


        Try
            strsql = "select * from Transport"
            cmd = New SqlCommand(strsql, conn)
            dr = cmd.ExecuteReader
            cbtrans.Items.Clear()
            Do While dr.Read
                cbtrans.Items.Add(dr("Transport"))
            Loop
            Call CloseKoneksi()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        tampilkan()
        tbid.Visible = False
        tbother.Visible = False


    End Sub

    Private Sub BTsend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btsend.Click
        Dim query As String
        Dim cmd As SqlCommand
        Dim dr As SqlDataReader
        Dim uid As String

        Try
            Call OpenKoneksi()
            Dim query_id As String = "SELECT MAX(RequestId)+1 AS MXID FROM Transportation"
            cmd = New SqlCommand(query_id, conn)
            dr = cmd.ExecuteReader
            dr.Read()
            uid = dr("MXID")
            dr.Close()

            If tbother.Text = "Other               " Then
                query = "INSERT INTO Transportation(RequestId,NameRequestor,RequestorId,Unit,DateIssue,UnitDestination,acRegis,Transportation,Phone,Instruction) VALUES (" & uid & ",'" & tbname.Text & "','" & tbidnum.Text & "','" & tbunit.Text & "','" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "','" & tbto.Text & "','" & tbac.Text & "','" & tbother.Text & "','" & tbphone.Text & "','" & tbinstruc.Text & "')"
            Else

                query = "INSERT INTO Transportation(RequestId,NameRequestor,RequestorId,Unit,DateIssue,UnitDestination,acRegis,Transportation,Phone,Instruction) VALUES (" & uid & ",'" & tbname.Text & "','" & tbidnum.Text & "','" & tbunit.Text & "','" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "','" & tbto.Text & "','" & tbac.Text & "','" & cbtrans.Text & "','" & tbphone.Text & "','" & tbinstruc.Text & "')"
            End If
            cmd = New SqlCommand(query, conn)
            dr = cmd.ExecuteReader
            dr.Close()

            MsgBox("REQUEST DATA '" + tbname.Text + "' ALREADY SAVED ")
            lvrequest.Clear()
            tampilkan()
            Call CloseKoneksi()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub bersih()
        tbname.Text = ""
        tbid.Text = ""
        tbunit.Text = ""
        tbto.Text = ""
        tbac.Text = ""
        cbtrans.Text = ""
        tbphone.Text = ""
        tbinstruc.Text = ""
    End Sub
    Private Sub tampilkan()
        Dim cmd As SqlCommand
        Dim dr As SqlDataReader

        lvrequest.View = View.Details
        lvrequest.Columns.Add("NO", 50)
        lvrequest.Columns.Add("Name of Requestor", 300)
        lvrequest.Columns.Add("Unit From", 150)
        lvrequest.Columns.Add("Unit To", 150)
        lvrequest.Columns.Add("Request Date", 200)
        lvrequest.Columns.Add("Transportation", 150)

        Try
            Call OpenKoneksi()
            Dim query_id As String = "select * from Transportation"
            cmd = New SqlCommand(query_id, conn)
            dr = cmd.ExecuteReader

            Do While dr.Read
                lvrequest.Items.Add(dr("RequestId"))
                lvrequest.Items(lvrequest.Items.Count - 1).SubItems.Add(dr("NameRequestor"))
                lvrequest.Items(lvrequest.Items.Count - 1).SubItems.Add(dr("Unit"))
                lvrequest.Items(lvrequest.Items.Count - 1).SubItems.Add(dr("UnitDestination"))
                lvrequest.Items(lvrequest.Items.Count - 1).SubItems.Add(dr("DateIssue"))
                lvrequest.Items(lvrequest.Items.Count - 1).SubItems.Add(dr("Transportation"))
            Loop
            dr.Close()
            Call CloseKoneksi()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub BTedit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btedit.Click
        Dim cmd As SqlCommand
        Dim dr As SqlDataReader
        Dim requestId As String

        Try
            requestId = lvrequest.SelectedItems(0).Text
            Call OpenKoneksi()
            Dim query As String = "select * from Transportation where RequestId='" + requestId + "'"

            cmd = New SqlCommand(query, conn)
            dr = cmd.ExecuteReader

            dr.Read()
            tbid.Text = dr("RequestId")
            tbname.Text = dr("NameRequestor")
            tbidnum.Text = dr("RequestorId")
            tbunit.Text = dr("Unit")
            tbto.Text = dr("UnitDestination")
            tbac.Text = dr("acRegis")
            cbtrans.Text = dr("Transportation")
            tbphone.Text = dr("Phone")
            tbinstruc.Text = dr("Instruction")
            dr.Close()
            Call CloseKoneksi()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub Lv1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvrequest.SelectedIndexChanged
        btedit.Enabled = True

    End Sub

    Private Sub BTdelet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btdelet.Click
        Dim cmd As SqlCommand
        Dim dr As SqlDataReader
        Dim requestId As String

        Try
            requestId = lvrequest.SelectedItems(0).Text
            Call OpenKoneksi()
            Dim query As String = "delete from Transportation where RequestId='" + requestId + "'"
            cmd = New SqlCommand(query, conn)
            dr = cmd.ExecuteReader
            Call CloseKoneksi()
            dr.Close()
            MsgBox("sudah dihapus")
            lvrequest.Clear()
            tampilkan()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub BTupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btupdate.Click
        Try
            Call OpenKoneksi()
            query_gl = "UPDATE Transportation SET NameRequestor = '" & tbname.Text & "',RequestorId = '" & tbidnum.Text & "',Unit ='" & tbunit.Text & "',UnitDestination = '" & tbto.Text & "',acRegis = '" & tbac.Text & "',Transportation = '" & cbtrans.Text & "',phone = '" & tbphone.Text & "',Instruction = '" & tbinstruc.Text & "' WHERE RequestId = '" & tbid.Text & "'"
            cmd_gl = New SqlCommand(query_gl, conn)
            dr_gl = cmd_gl.ExecuteReader
            dr_gl.Close()
            Call CloseKoneksi()
            bersih()
            lvrequest.Clear()
            tampilkan()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub CBtrans_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbtrans.SelectedIndexChanged
        If cbtrans.Text = "Other               " Then
            tbother.Visible = True
        Else
            tbother.Visible = False
        End If
    End Sub
End Class

