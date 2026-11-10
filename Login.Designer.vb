<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        btnproses = New Button()
        txtpass = New TextBox()
        Label2 = New Label()
        txtUsername = New TextBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.Action_lock_icon
        PictureBox1.Location = New Point(96, 55)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(123, 128)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(262, 100)
        Label1.Name = "Label1"
        Label1.Size = New Size(60, 15)
        Label1.TabIndex = 1
        Label1.Text = "Password:"
        ' 
        ' btnproses
        ' 
        btnproses.Location = New Point(373, 176)
        btnproses.Name = "btnproses"
        btnproses.Size = New Size(75, 23)
        btnproses.TabIndex = 2
        btnproses.Text = "Proses"
        btnproses.UseVisualStyleBackColor = True
        ' 
        ' txtpass
        ' 
        txtpass.Location = New Point(362, 97)
        txtpass.Name = "txtpass"
        txtpass.PasswordChar = "*"c
        txtpass.Size = New Size(100, 23)
        txtpass.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(262, 58)
        Label2.Name = "Label2"
        Label2.Size = New Size(63, 15)
        Label2.TabIndex = 4
        Label2.Text = "Username:"
        ' 
        ' txtUsername
        ' 
        txtUsername.Location = New Point(362, 55)
        txtUsername.Name = "txtUsername"
        txtUsername.PasswordChar = "*"c
        txtUsername.Size = New Size(100, 23)
        txtUsername.TabIndex = 5
        ' 
        ' Login
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(563, 293)
        Controls.Add(txtUsername)
        Controls.Add(Label2)
        Controls.Add(txtpass)
        Controls.Add(btnproses)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Name = "Login"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Login"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnproses As Button
    Friend WithEvents txtpass As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtUsername As TextBox
End Class
