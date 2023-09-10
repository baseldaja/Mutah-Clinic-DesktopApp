Imports System.Data.SqlClient
Public Class receiptForm
    Private Sub medsearchb_Click(sender As Object, e As EventArgs) Handles medsearchb.Click
        If mednamsearchetb.Text = Nothing Then
            con.Open()
            Try
                Dim ad As New SqlDataAdapter($"select med_id as [رقم الدواء],med_name as [اسم الدواء] ,amount as [الكمية المتوفرة],dose as [الجرعة ] from pharmacy", con)
                Dim ds As New DataSet
                ad.Fill(ds)
                dgv1.DataSource = ds
                dgv1.DataMember = ds.Tables(0).ToString
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                con.Close()
            End Try
        Else
            con.Open()
            Try
                Dim ad As New SqlDataAdapter($"select med_id as [رقم الدواء],med_name as [اسم الدواء] ,amount as [الكمية المتوفرة],dose as [الجرعة ] from pharmacy where med_name='{mednamsearchetb.Text}'", con)
                Dim ds As New DataSet
                ad.Fill(ds)
                dgv1.DataSource = ds
                dgv1.DataMember = ds.Tables(0).ToString
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                con.Close()
            End Try
        End If

    End Sub

    Private Sub dgv1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv1.CellClick
        Dim i As Integer
        i = e.RowIndex
        Dim sr As New DataGridViewRow
        sr = dgv1.Rows(i)
        mednametb.Text = sr.Cells(1).Value.ToString()
        meddosetb.Text = sr.Cells(3).Value.ToString()
        mednametb.ReadOnly = True
        meddosetb.ReadOnly = True

    End Sub

    Private Sub addresb_Click(sender As Object, e As EventArgs) Handles addrecb.Click
        con.Open()
        Try
            Dim cmd As New SqlCommand($"insert into receipt values('{Trim(residtb.Text)}','{Trim(patnametb.Text)}','{Trim(mednametb.Text)}','{Trim(medamounttb.Text)}','{Trim(meddailydosetb.Text)}','{Trim(mednotetb.Text)}')", con)
            Dim amt As New SqlCommand($"select amount from pharmacy where med_name='{mednametb.Text}'", con)
            Dim amount = amt.ExecuteScalar
            cmd.ExecuteNonQuery()
            Dim newamt As Integer
            newamt = Val(amount.ToString) - Val(medamounttb.Text)
            Dim updateamt As New SqlCommand($"update pharmacy set amount ='{newamt}' where med_name='{mednametb.Text}'", con)
            updateamt.ExecuteNonQuery()
            MsgBox("تم اضافة الوصفة الطبية بنجاح")
            MsgBox(newamt)
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub showrecb_Click(sender As Object, e As EventArgs) Handles showrecb.Click
        con.Open()
        Try
            Dim ad As New SqlDataAdapter($"select id as [رقم الوصفة],pat_name as [اسم المريض] ,med_name as [اسم الدواء],amount as [الكمية],daily_dose as [الجرعة اليومية],note as [الملاحظات] from receipt where pat_name='{patnametb.Text}'", con)
            Dim ds As New DataSet
            ad.Fill(ds)
            dgv1.DataSource = ds
            dgv1.DataMember = ds.Tables(0).ToString
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

End Class