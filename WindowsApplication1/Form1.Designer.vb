<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registration_form
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Buttonsubmit = New System.Windows.Forms.Button()
        Me.Txtbname = New System.Windows.Forms.TextBox()
        Me.Combostream = New System.Windows.Forms.ComboBox()
        Me.Datedob = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Txtbaddress = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Txtbphone = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Txtupdateroll = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.RadioXII = New System.Windows.Forms.RadioButton()
        Me.RadioXI = New System.Windows.Forms.RadioButton()
        Me.Chkmusic = New System.Windows.Forms.CheckBox()
        Me.Chksing = New System.Windows.Forms.CheckBox()
        Me.Chkdance = New System.Windows.Forms.CheckBox()
        Me.Chkread = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Btndelete = New System.Windows.Forms.Button()
        Me.Bttnupdate = New System.Windows.Forms.Button()
        Me.Dtgridview = New System.Windows.Forms.DataGridView()
        Me.name1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.roll_no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.stream = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dob = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.hobby = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.class1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.address = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.phoneno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Studentinfo3BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EducationDataSet = New WindowsApplication1.educationDataSet()
        Me.Studentinfo3TableAdapter = New WindowsApplication1.educationDataSetTableAdapters.studentinfo3TableAdapter()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.Dtgridview, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Studentinfo3BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EducationDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Buttonsubmit
        '
        Me.Buttonsubmit.Location = New System.Drawing.Point(6, 19)
        Me.Buttonsubmit.Name = "Buttonsubmit"
        Me.Buttonsubmit.Size = New System.Drawing.Size(75, 23)
        Me.Buttonsubmit.TabIndex = 0
        Me.Buttonsubmit.Text = "submit"
        Me.Buttonsubmit.UseVisualStyleBackColor = True
        '
        'Txtbname
        '
        Me.Txtbname.Location = New System.Drawing.Point(101, 24)
        Me.Txtbname.Name = "Txtbname"
        Me.Txtbname.Size = New System.Drawing.Size(148, 20)
        Me.Txtbname.TabIndex = 1
        '
        'Combostream
        '
        Me.Combostream.AllowDrop = True
        Me.Combostream.FormattingEnabled = True
        Me.Combostream.Location = New System.Drawing.Point(385, 25)
        Me.Combostream.Name = "Combostream"
        Me.Combostream.Size = New System.Drawing.Size(121, 21)
        Me.Combostream.TabIndex = 3
        '
        'Datedob
        '
        Me.Datedob.Location = New System.Drawing.Point(101, 74)
        Me.Datedob.Name = "Datedob"
        Me.Datedob.Size = New System.Drawing.Size(148, 20)
        Me.Datedob.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Date of Birth "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(304, 28)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Stream"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(304, 135)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Hobby"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(20, 135)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Address"
        '
        'Txtbaddress
        '
        Me.Txtbaddress.Location = New System.Drawing.Point(101, 132)
        Me.Txtbaddress.Multiline = True
        Me.Txtbaddress.Name = "Txtbaddress"
        Me.Txtbaddress.Size = New System.Drawing.Size(148, 32)
        Me.Txtbaddress.TabIndex = 14
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(304, 67)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(32, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Class"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(20, 193)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(53, 13)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Phone no"
        '
        'Txtbphone
        '
        Me.Txtbphone.Location = New System.Drawing.Point(101, 193)
        Me.Txtbphone.Name = "Txtbphone"
        Me.Txtbphone.Size = New System.Drawing.Size(148, 20)
        Me.Txtbphone.TabIndex = 19
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Txtupdateroll)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.RadioXII)
        Me.GroupBox1.Controls.Add(Me.RadioXI)
        Me.GroupBox1.Controls.Add(Me.Chkmusic)
        Me.GroupBox1.Controls.Add(Me.Chksing)
        Me.GroupBox1.Controls.Add(Me.Chkdance)
        Me.GroupBox1.Controls.Add(Me.Chkread)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Txtbphone)
        Me.GroupBox1.Controls.Add(Me.Txtbname)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Combostream)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Datedob)
        Me.GroupBox1.Controls.Add(Me.Txtbaddress)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(569, 246)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        '
        'Txtupdateroll
        '
        Me.Txtupdateroll.Enabled = False
        Me.Txtupdateroll.Location = New System.Drawing.Point(389, 186)
        Me.Txtupdateroll.Name = "Txtupdateroll"
        Me.Txtupdateroll.Size = New System.Drawing.Size(100, 20)
        Me.Txtupdateroll.TabIndex = 27
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(304, 193)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 13)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Update  Roll no"
        '
        'RadioXII
        '
        Me.RadioXII.AutoSize = True
        Me.RadioXII.Location = New System.Drawing.Point(385, 88)
        Me.RadioXII.Name = "RadioXII"
        Me.RadioXII.Size = New System.Drawing.Size(38, 17)
        Me.RadioXII.TabIndex = 25
        Me.RadioXII.TabStop = True
        Me.RadioXII.Text = "XII"
        Me.RadioXII.UseVisualStyleBackColor = True
        '
        'RadioXI
        '
        Me.RadioXI.AutoSize = True
        Me.RadioXI.Location = New System.Drawing.Point(385, 65)
        Me.RadioXI.Name = "RadioXI"
        Me.RadioXI.Size = New System.Drawing.Size(35, 17)
        Me.RadioXI.TabIndex = 24
        Me.RadioXI.TabStop = True
        Me.RadioXI.Text = "XI"
        Me.RadioXI.UseVisualStyleBackColor = True
        '
        'Chkmusic
        '
        Me.Chkmusic.AutoSize = True
        Me.Chkmusic.Location = New System.Drawing.Point(468, 147)
        Me.Chkmusic.Name = "Chkmusic"
        Me.Chkmusic.Size = New System.Drawing.Size(54, 17)
        Me.Chkmusic.TabIndex = 23
        Me.Chkmusic.Text = "Music"
        Me.Chkmusic.UseVisualStyleBackColor = True
        '
        'Chksing
        '
        Me.Chksing.AutoSize = True
        Me.Chksing.Location = New System.Drawing.Point(467, 124)
        Me.Chksing.Name = "Chksing"
        Me.Chksing.Size = New System.Drawing.Size(61, 17)
        Me.Chksing.TabIndex = 22
        Me.Chksing.Text = "Singing"
        Me.Chksing.UseVisualStyleBackColor = True
        '
        'Chkdance
        '
        Me.Chkdance.AutoSize = True
        Me.Chkdance.Location = New System.Drawing.Point(389, 147)
        Me.Chkdance.Name = "Chkdance"
        Me.Chkdance.Size = New System.Drawing.Size(66, 17)
        Me.Chkdance.TabIndex = 21
        Me.Chkdance.Text = "Dancing"
        Me.Chkdance.UseVisualStyleBackColor = True
        '
        'Chkread
        '
        Me.Chkread.AutoSize = True
        Me.Chkread.Location = New System.Drawing.Point(389, 124)
        Me.Chkread.Name = "Chkread"
        Me.Chkread.Size = New System.Drawing.Size(66, 17)
        Me.Chkread.TabIndex = 20
        Me.Chkread.Text = "Reading"
        Me.Chkread.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Btndelete)
        Me.GroupBox2.Controls.Add(Me.Bttnupdate)
        Me.GroupBox2.Controls.Add(Me.Buttonsubmit)
        Me.GroupBox2.Location = New System.Drawing.Point(113, 264)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(427, 68)
        Me.GroupBox2.TabIndex = 21
        Me.GroupBox2.TabStop = False
        '
        'Btndelete
        '
        Me.Btndelete.Location = New System.Drawing.Point(232, 19)
        Me.Btndelete.Name = "Btndelete"
        Me.Btndelete.Size = New System.Drawing.Size(75, 23)
        Me.Btndelete.TabIndex = 2
        Me.Btndelete.Text = "Delete"
        Me.Btndelete.UseVisualStyleBackColor = True
        '
        'Bttnupdate
        '
        Me.Bttnupdate.Location = New System.Drawing.Point(120, 19)
        Me.Bttnupdate.Name = "Bttnupdate"
        Me.Bttnupdate.Size = New System.Drawing.Size(75, 23)
        Me.Bttnupdate.TabIndex = 1
        Me.Bttnupdate.Text = "Update"
        Me.Bttnupdate.UseVisualStyleBackColor = True
        '
        'Dtgridview
        '
        Me.Dtgridview.AutoGenerateColumns = False
        Me.Dtgridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dtgridview.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.name1, Me.roll_no, Me.stream, Me.dob, Me.hobby, Me.class1, Me.address, Me.phoneno})
        Me.Dtgridview.DataSource = Me.Studentinfo3BindingSource
        Me.Dtgridview.Location = New System.Drawing.Point(615, 12)
        Me.Dtgridview.Name = "Dtgridview"
        Me.Dtgridview.Size = New System.Drawing.Size(259, 246)
        Me.Dtgridview.TabIndex = 22
        '
        'name1
        '
        Me.name1.DataPropertyName = "name"
        Me.name1.HeaderText = "name"
        Me.name1.Name = "name1"
        '
        'roll_no
        '
        Me.roll_no.DataPropertyName = "roll_no"
        Me.roll_no.HeaderText = "roll_no"
        Me.roll_no.Name = "roll_no"
        Me.roll_no.ReadOnly = True
        '
        'stream
        '
        Me.stream.DataPropertyName = "stream"
        Me.stream.HeaderText = "stream"
        Me.stream.Name = "stream"
        '
        'dob
        '
        Me.dob.DataPropertyName = "dob"
        Me.dob.HeaderText = "dob"
        Me.dob.Name = "dob"
        '
        'hobby
        '
        Me.hobby.DataPropertyName = "hobby"
        Me.hobby.HeaderText = "hobby"
        Me.hobby.Name = "hobby"
        '
        'class1
        '
        Me.class1.DataPropertyName = "class"
        Me.class1.HeaderText = "class"
        Me.class1.Name = "class1"
        '
        'address
        '
        Me.address.DataPropertyName = "address"
        Me.address.HeaderText = "address"
        Me.address.Name = "address"
        '
        'phoneno
        '
        Me.phoneno.DataPropertyName = "phoneno"
        Me.phoneno.HeaderText = "phoneno"
        Me.phoneno.Name = "phoneno"
        '
        'Studentinfo3BindingSource
        '
        Me.Studentinfo3BindingSource.DataMember = "studentinfo3"
        Me.Studentinfo3BindingSource.DataSource = Me.EducationDataSet
        '
        'EducationDataSet
        '
        Me.EducationDataSet.DataSetName = "educationDataSet"
        Me.EducationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Studentinfo3TableAdapter
        '
        Me.Studentinfo3TableAdapter.ClearBeforeFill = True
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(443, 283)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(75, 23)
        Me.btnRefresh.TabIndex = 23
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'Registration_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(907, 344)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.Dtgridview)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Registration_form"
        Me.Text = "Registration form"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.Dtgridview, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Studentinfo3BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EducationDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Buttonsubmit As System.Windows.Forms.Button
    Friend WithEvents Txtbname As System.Windows.Forms.TextBox
    Friend WithEvents Combostream As System.Windows.Forms.ComboBox
    Friend WithEvents Datedob As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Txtbaddress As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Txtbphone As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Chkdance As System.Windows.Forms.CheckBox
    Friend WithEvents Chkread As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Chkmusic As System.Windows.Forms.CheckBox
    Friend WithEvents Chksing As System.Windows.Forms.CheckBox
    Friend WithEvents RadioXII As System.Windows.Forms.RadioButton
    Friend WithEvents RadioXI As System.Windows.Forms.RadioButton
    Friend WithEvents Txtupdateroll As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Bttnupdate As System.Windows.Forms.Button
    Friend WithEvents Btndelete As System.Windows.Forms.Button
    Friend WithEvents Dtgridview As System.Windows.Forms.DataGridView
    Friend WithEvents EducationDataSet As WindowsApplication1.educationDataSet
    Friend WithEvents Studentinfo3BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Studentinfo3TableAdapter As WindowsApplication1.educationDataSetTableAdapters.studentinfo3TableAdapter
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents name1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents roll_no As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents stream As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dob As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents hobby As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents class1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents address As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents phoneno As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
