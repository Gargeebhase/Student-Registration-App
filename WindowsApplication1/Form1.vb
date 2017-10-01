Imports System.Data.SqlClient
Imports System.Configuration
Imports CrystalDecisions.CrystalReports.Engine

Public Class Registration_form


    Private Sub Registration_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EducationDataSet.studentinfo3' table. You can move, or remove it, as needed.
        Me.Studentinfo3TableAdapter.Fill(Me.EducationDataSet.studentinfo3)

        Using conn As New SqlConnection(ConfigurationManager.ConnectionStrings("ConnectionString").ConnectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text

                    Dim da As New SqlDataAdapter("select distinct stream from courses", conn)

                    Dim dt As New DataTable
                    da.Fill(dt)

                    Combostream.DisplayMember = "stream"
                    Combostream.DataSource = dt


                End With
                Try
                    conn.Open()
                    'comm.ExecuteNonQuery()
                    'MessageBox.Show("successful")
                Catch ex As SqlException
                    'MessageBox.Show(ex.Message.ToString(), "Error Message")
                End Try
            End Using
        End Using
            
    End Sub

    Private Sub Buttonsubmit_Click(sender As Object, e As EventArgs) Handles Buttonsubmit.Click
        Dim a As Integer
        If RadioXI.Checked Then
            a = 11
        Else : a = 12
        End If
        Dim b As String = String.Empty
        If Chkread.Checked Then
            b &= " reading"
        End If
        If Chksing.Checked Then
            b &= " singing"
        End If
        If Chkmusic.Checked Then
            b &= " music"
        End If
        If Chkdance.Checked Then
            b &= " dance"

        End If

        
        Dim query As String = String.Empty
        'query &= "insert into studentinfo3(name,stream,dob,hobby,class,address,phoneno)"

        'query &= "VALUES (@colName,@colstream, @coldob, @colhobby,@colclass, @coladdress,@colphone)"
        query &= " declare @RowCount int declare @NewID int exec Usp_AddStudent @strname =@colName ,@strstream =@colstream,@strhobby =@colhobby,@intclass =@colclass,@straddress =@coladdress,@intphoneno=@colphone,@datedob =@coldob,@RowCount = @RowCount output,              @NewID =@NewID 	output"



        Using conn As New SqlConnection(ConfigurationManager.ConnectionStrings("ConnectionString").ConnectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@colName", Txtbname.Text)
                    .Parameters.AddWithValue("@colstream", Combostream.SelectedItem)
                    .Parameters.AddWithValue("@coldob", Datedob.Value)
                    .Parameters.AddWithValue("@colhobby", b)
                    .Parameters.AddWithValue("@colclass", a)
                    .Parameters.AddWithValue("@coladdress", Txtbaddress.Text)
                    .Parameters.AddWithValue("@colphone", Txtbphone.Text)

                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                    MessageBox.Show("successful")
                Catch ex As SqlException
                    MessageBox.Show(ex.Message.ToString(), "Error Message")
                End Try
            End Using
        End Using

    End Sub



    Private Sub Bttnupdate_Click(sender As Object, e As EventArgs) Handles Bttnupdate.Click
        Dim a1 As Integer
        a1 = Txtupdateroll.Text

        Dim a2 As Integer
        If RadioXI.Checked Then
            a2 = 11
        Else : a2 = 12
        End If
        Dim b2 As String = String.Empty
        If Chkread.Checked Then
            b2 &= " reading"
        End If
        If Chksing.Checked Then
            b2 &= " singing"
        End If
        If Chkmusic.Checked Then
            b2 &= " music"
        End If
        If Chkdance.Checked Then
            b2 &= " dance"

        End If


        Dim query1 As String = String.Empty
        'query1 &= "update studentinfo3 "
        'query1 &= "set name=@n ,stream=@s ,dob=@d ,hobby=@h ,class=@c ,address=@a ,phoneno=@p "
        'query1 &= "where roll_no=@v"
        query1 &= "declare @RowCount int declare @NewID int exec Usp_ModifyStudent  @intID=@v, @strname =@n,@strstream =@s,@strhobby =@h ,@intclass =@c,@straddress=@a ,@intphoneno =@p,@datedob=@d,@RowCount = @RowCount output,   @NewID =@NewID 	output"

        Using conn As New SqlConnection(ConfigurationManager.ConnectionStrings("ConnectionString").ConnectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query1
                    .Parameters.AddWithValue("@n", Txtbname.Text)
                    .Parameters.AddWithValue("@s", Combostream.SelectedItem)
                    .Parameters.AddWithValue("@d", Datedob.Value)
                    .Parameters.AddWithValue("@h", b2)
                    .Parameters.AddWithValue("@c", a2)
                    .Parameters.AddWithValue("@a", Txtbaddress.Text)
                    .Parameters.AddWithValue("@p", Txtbphone.Text)
                    .Parameters.AddWithValue("@v", a1)

                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                    MessageBox.Show("successful")
                Catch ex As SqlException
                    MessageBox.Show(ex.Message.ToString(), "Error Message")
                End Try
            End Using
        End Using


    End Sub

    Private Sub Btndelete_Click(sender As Object, e As EventArgs) Handles Btndelete.Click
        Dim a4 As Integer
        a4 = Txtupdateroll.Text

        Dim query2 As String = String.Empty
        'query2 &= "delete from  studentinfo3 where roll_no=@ras"

        query2 &= "declare @RowCount int exec Usp_DeleteStudent @intID=@ras,@RowCount = @RowCount output  "

        Using conn As New SqlConnection(ConfigurationManager.ConnectionStrings("ConnectionString").ConnectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query2
                    .Parameters.AddWithValue("@ras", a4)
                    

                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                    MessageBox.Show("successful")
                Catch ex As SqlException
                    MessageBox.Show(ex.Message.ToString(), "Error Message")
                End Try
            End Using
        End Using


    End Sub

    Private Sub dtgridview_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dtgridview.CellClick
        Try
            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow
                row = Me.Dtgridview.Rows(e.RowIndex)

                Txtbaddress.Text = row.Cells("address").Value.ToString

                Txtbphone.Text = row.Cells("phoneno").Value.ToString
                Txtupdateroll.Text = row.Cells("roll_no").Value.ToString
                Txtbname.Text = row.Cells("name1").Value.ToString
                If (row.Cells("class1").Value.ToString() = "11") Then
                    RadioXI.Checked = True
                Else : RadioXII.Checked = True
                End If
                Chkdance.Checked = False
                Chksing.Checked = False
                Chkmusic.Checked = False
                Chkread.Checked = False
                If (row.Cells("hobby").Value.ToString.Contains("dance")) Then
                    Chkdance.Checked = True
                End If

                If (row.Cells("hobby").Value.ToString.Contains("singing")) Then
                    Chksing.Checked = True
                End If
                If (row.Cells("hobby").Value.ToString.Contains("music")) Then
                    Chkmusic.Checked = True
                End If
                If (row.Cells("hobby").Value.ToString.Contains("reading")) Then
                    Chkread.Checked = True
                End If
                Combostream.SelectedItem = row.Cells("stream").Value.ToString
                Datedob.Value = row.Cells("dob").Value.ToString
            End If
        Catch ex1 As NullReferenceException
        End Try
    End Sub
    
    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        'Dtgridview.Update()
        Me.Studentinfo3TableAdapter.Fill(Me.EducationDataSet.studentinfo3)
    End Sub
End Class
