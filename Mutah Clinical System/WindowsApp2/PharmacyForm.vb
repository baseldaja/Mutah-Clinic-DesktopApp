Imports System.Data.SqlClient
Public Class PharmacyForm
    Function reset()
        medidtb.Text = ""
        mednametb.Text = ""
        medamounttb.Text = ""
        meddosetb.Text = ""
    End Function
    Private Sub showmedb_Click(sender As Object, e As EventArgs) Handles showmedb.Click
        con.Open()
        Try
            Dim ad As New SqlDataAdapter($"select med_id as [رقم الدواء],med_name as [اسم الدواء] ,amount as [الكمية المتوفرة],dose as [الجرعة ] from pharmacy", con)
            Dim ds As New DataSet
            ad.Fill(ds)
            dgv1.DataSource = ds
            dgv1.DataMember = ds.Tables(0).ToString
            reset()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub addmedb_Click(sender As Object, e As EventArgs) Handles addmedb.Click
        con.Open()
        Try
            Dim cmd As New SqlCommand($"insert into pharmacy(med_id,med_name,amount,dose) values('{Trim(medidtb.Text)}','{Trim(mednametb.Text)}','{Trim(medamounttb.Text)}','{Trim(meddosetb.Text)}')", con)
            cmd.ExecuteNonQuery()
            MsgBox("تم اضافة الدواء بنجاح")
            reset()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub editmedb_Click(sender As Object, e As EventArgs) Handles editmedb.Click
        con.Open()
        Try
            Dim cmd As New SqlCommand($"update pharmacy set med_name='{Trim(mednametb.Text)}' ,amount='{Trim(medamounttb.Text)}',dose='{Trim(meddosetb.Text)}' where med_id='{Trim(medidtb.Text)}'", con)
            cmd.ExecuteNonQuery()
            MsgBox("تم التعديل بنجاح")
            reset()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()

        End Try
    End Sub

    Private Sub dgv1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv1.CellClick
        Dim i As Integer
        i = e.RowIndex
        Dim sr As New DataGridViewRow
        sr = dgv1.Rows(i)
        medidtb.Text = sr.Cells(0).Value.ToString()
        mednametb.Text = sr.Cells(1).Value.ToString()
        medamounttb.Text = sr.Cells(2).Value.ToString()
        meddosetb.Text = sr.Cells(3).Value.ToString()
    End Sub


    Private Sub removemedb_Click(sender As Object, e As EventArgs) Handles removemedb.Click
        con.Open()
        Try
            Dim cmd As New SqlCommand($"delete from pharmacy where med_id={medidtb.Text}", con)
            cmd.ExecuteNonQuery()
            MsgBox("Medicine Removed Succesfuly!")
            reset()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub


End Class