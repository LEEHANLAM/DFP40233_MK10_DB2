<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        txtIdKelas = New TextBox()
        txtNamaKelas = New TextBox()
        btnAddKelas = New Button()
        btnUpdateKelas = New Button()
        btnDeleteKelas = New Button()
        dataGridViewKelas = New DataGridView()
        Timer1 = New Timer(components)
        CType(dataGridViewKelas, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtIdKelas
        ' 
        txtIdKelas.Location = New Point(20, 23)
        txtIdKelas.Name = "txtIdKelas"
        txtIdKelas.PlaceholderText = "Enter ID Kelas"
        txtIdKelas.Size = New Size(194, 27)
        txtIdKelas.TabIndex = 0
        ' 
        ' txtNamaKelas
        ' 
        txtNamaKelas.Location = New Point(20, 63)
        txtNamaKelas.Name = "txtNamaKelas"
        txtNamaKelas.PlaceholderText = "Enter Nama Kelas"
        txtNamaKelas.Size = New Size(194, 27)
        txtNamaKelas.TabIndex = 1
        ' 
        ' btnAddKelas
        ' 
        btnAddKelas.Location = New Point(255, 21)
        btnAddKelas.Name = "btnAddKelas"
        btnAddKelas.Size = New Size(122, 30)
        btnAddKelas.TabIndex = 2
        btnAddKelas.Text = "Add"
        btnAddKelas.UseVisualStyleBackColor = True
        ' 
        ' btnUpdateKelas
        ' 
        btnUpdateKelas.Location = New Point(255, 61)
        btnUpdateKelas.Name = "btnUpdateKelas"
        btnUpdateKelas.Size = New Size(122, 30)
        btnUpdateKelas.TabIndex = 3
        btnUpdateKelas.Text = "Update"
        btnUpdateKelas.UseVisualStyleBackColor = True
        ' 
        ' btnDeleteKelas
        ' 
        btnDeleteKelas.Location = New Point(255, 101)
        btnDeleteKelas.Name = "btnDeleteKelas"
        btnDeleteKelas.Size = New Size(122, 30)
        btnDeleteKelas.TabIndex = 4
        btnDeleteKelas.Text = "Delete"
        btnDeleteKelas.UseVisualStyleBackColor = True
        ' 
        ' dataGridViewKelas
        ' 
        dataGridViewKelas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dataGridViewKelas.Location = New Point(20, 150)
        dataGridViewKelas.Name = "dataGridViewKelas"
        dataGridViewKelas.RowHeadersWidth = 51
        dataGridViewKelas.Size = New Size(357, 221)
        dataGridViewKelas.TabIndex = 5
        ' 
        ' Timer1
        ' 
        Timer1.Enabled = True
        Timer1.Interval = 5000
        ' 
        ' Form1
        ' 
        ClientSize = New Size(389, 379)
        Controls.Add(dataGridViewKelas)
        Controls.Add(btnDeleteKelas)
        Controls.Add(btnUpdateKelas)
        Controls.Add(btnAddKelas)
        Controls.Add(txtNamaKelas)
        Controls.Add(txtIdKelas)
        MaximizeBox = False
        MinimizeBox = False
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Kelas Management"
        CType(dataGridViewKelas, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtIdKelas As TextBox
    Friend WithEvents txtNamaKelas As TextBox
    Friend WithEvents btnAddKelas As Button
    Friend WithEvents btnUpdateKelas As Button
    Friend WithEvents btnDeleteKelas As Button
    Friend WithEvents dataGridViewKelas As DataGridView
    Friend WithEvents Timer1 As Timer
End Class