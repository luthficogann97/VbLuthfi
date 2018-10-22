Imports System.Data.SqlClient
Public Class Form1
    Dim bentuk As String

    Private Sub ListView()
        Dim cmd As SqlCommand
        Dim dr As SqlDataReader

        lvpengajuan.View = View.Details
        lvpengajuan.Columns.Add("No", 50)
        lvpengajuan.Columns.Add("Nama Pelaksana", 150)
        lvpengajuan.Columns.Add("Bidang", 100)
        lvpengajuan.Columns.Add("Jml Permintaan", 150)
        lvpengajuan.Columns.Add("Bentuk Dana", 100)
        lvpengajuan.Columns.Add("Keperluan", 200)

        Try
            Call OpenKoneksi()
            Dim query_id As String = "select * from Pengajuan"
            cmd = New SqlCommand(query_id, conn)
            dr = cmd.ExecuteReader
            Do While dr.Read
                lvpengajuan.Items.Add(dr("idPengajuan"))
                lvpengajuan.Items(lvpengajuan.Items.Count - 1).SubItems.Add(dr("NamaPegajuan"))
                lvpengajuan.Items(lvpengajuan.Items.Count - 1).SubItems.Add(dr("Bidang"))
                lvpengajuan.Items(lvpengajuan.Items.Count - 1).SubItems.Add(dr("JmlPermintaan"))
                lvpengajuan.Items(lvpengajuan.Items.Count - 1).SubItems.Add(dr("BentukDana"))
                lvpengajuan.Items(lvpengajuan.Items.Count - 1).SubItems.Add(dr("Keperluan"))
            Loop
            dr.Close()
            Call CloseKoneksi()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub Bersih()
        tbnama.Text = ""
        cbbidang.Text = ""
        tbpermintaab.Text = ""
        tbkeperluan.Text = ""
        RBcek.Checked = False
        RBgiro.Checked = False
        RbTunai.Checked = False
        tbid.Text = ""
        btsave.Text = "Add"

    End Sub
    Private Sub Btapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bthapus.Click
        Dim id As String
        Dim cmd As SqlCommand
        Dim dr As SqlDataReader
        If MsgBox("Apakah Anda Yakin Ingin Menghapusnya?", vbYesNo) = MsgBoxResult.Yes Then

            id = lvpengajuan.SelectedItems(0).Text
            Call OpenKoneksi()
            Dim query As String = "Delete from Pengajuan Where IdPengajuan='" + id + "'"

            cmd = New SqlCommand(query, conn)
            dr = cmd.ExecuteReader
            Bersih()
            dr.Close()
            Call CloseKoneksi()

            lvpengajuan.Clear()
            ListView()

        End If
    End Sub

    Private Sub Form1_Load_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Call ListView()
        tbid.Visible = False
    End Sub

    Private Sub BtSave_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btsave.Click
        Dim cmd As SqlCommand
        Dim dr As SqlDataReader
        Dim uid As String
        Dim query As String = ""

        If btsave.Text = "Add" Then


            Call OpenKoneksi()
            Dim query_id As String = "select MAX(IdPengajuan)+1 AS MXID from Pengajuan"
            cmd = New SqlCommand(query_id, conn)
            dr = cmd.ExecuteReader
            dr.Read()
            uid = dr("MXID")
            dr.Close()


            If RBcek.Checked = True Then
                bentuk = RBcek.Text
            ElseIf RbTunai.Checked = True Then
                bentuk = RbTunai.Text
            ElseIf RBgiro.Checked = True Then
                bentuk = RBgiro.Text
            End If

            query = "Insert into Pengajuan (IdPengajuan,NamaPegajuan,Bidang,JmlPermintaan,BentukDana,Keperluan,Tanggal) Values(" & uid & ",'" & tbnama.Text & "','" & cbbidang.Text & "','" & tbpermintaab.Text & "','" & bentuk & "','" & tbkeperluan.Text & "','" & Format(DateTimePicker1.Value, "yyyy/MM/dd") & "')"
            MsgBox("Selamat '" + tbnama.Text + "' Telah Berhasil Di Simpan ")


        ElseIf btsave.Text = "Update" Then
            Call OpenKoneksi()
            If RBcek.Checked = True Then
                bentuk = RBcek.Text
            ElseIf RbTunai.Checked = True Then
                bentuk = RbTunai.Text
            ElseIf RBgiro.Checked = True Then
                bentuk = RBgiro.Text
            End If
            query = "Update Pengajuan Set NamaPegajuan='" & tbnama.Text & "',Bidang='" & cbbidang.Text & "',JmlPermintaan='" & tbpermintaab.Text & "',BentukDana='" & bentuk & "',Keperluan='" & tbkeperluan.Text & "'Where IdPengajuan='" & tbid.Text & "'"
            MsgBox("Selamat '" + tbnama.Text + "' Telah Berhasil Di Update ")
        End If

        cmd = New SqlCommand(query, conn)
        dr = cmd.ExecuteReader
        dr.Close()


        Call CloseKoneksi()

        Bersih()
        lvpengajuan.Clear()
        ListView()

    End Sub

    Private Sub btedit_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btedit.Click
        Dim cmd As SqlCommand
        Dim dr As SqlDataReader
        Dim query As String
        Dim id As String
        Try
            id = lvpengajuan.SelectedItems(0).Text
            Call OpenKoneksi()
            query = "Select * from Pengajuan Where IdPengajuan='" + id + "'"

            If bentuk = RbTunai.Text Then
                RbTunai.Checked = True
            ElseIf bentuk = RBcek.Text Then
                RBcek.Checked = True
            ElseIf bentuk = RBgiro.Text Then
                RBgiro.Checked = True
            End If
            cmd = New SqlCommand(query, conn)
            dr = cmd.ExecuteReader
            dr.Read()
            tbnama.Text = dr("NamaPegajuan")
            cbbidang.Text = dr("Bidang")
            tbpermintaab.Text = dr("JmlPermintaan")
            bentuk = dr("BentukDana")
            tbkeperluan.Text = dr("Keperluan")
            tbid.Text = dr("IdPengajuan")
            btsave.Text = "Update"
            dr.Close()
            Call CloseKoneksi()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub


    Private Sub Close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btclose.Click
        Bersih()
    End Sub
End Class

