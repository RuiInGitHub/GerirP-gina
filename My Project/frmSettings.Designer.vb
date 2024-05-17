<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSettings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSettings))
        txtPastaFotosDispMovel = New TextBox()
        txtPastaFotosPC = New TextBox()
        txtPastaBD_SQLite = New TextBox()
        btnSave = New Button()
        lblConfiguraçõesPreenchidas = New Label()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        txtNomeBd_SQLite = New TextBox()
        picBoxPastaFotosPC = New PictureBox()
        picBoxPastaBD = New PictureBox()
        picBoxNomeBD = New PictureBox()
        OpenFileDialog1 = New OpenFileDialog()
        CType(picBoxPastaFotosPC, ComponentModel.ISupportInitialize).BeginInit()
        CType(picBoxPastaBD, ComponentModel.ISupportInitialize).BeginInit()
        CType(picBoxNomeBD, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtPastaFotosDispMovel
        ' 
        txtPastaFotosDispMovel.Location = New Point(247, 54)
        txtPastaFotosDispMovel.Name = "txtPastaFotosDispMovel"
        txtPastaFotosDispMovel.Size = New Size(429, 23)
        txtPastaFotosDispMovel.TabIndex = 0
        ' 
        ' txtPastaFotosPC
        ' 
        txtPastaFotosPC.Location = New Point(247, 92)
        txtPastaFotosPC.Name = "txtPastaFotosPC"
        txtPastaFotosPC.Size = New Size(429, 23)
        txtPastaFotosPC.TabIndex = 1
        ' 
        ' txtPastaBD_SQLite
        ' 
        txtPastaBD_SQLite.Location = New Point(247, 133)
        txtPastaBD_SQLite.Name = "txtPastaBD_SQLite"
        txtPastaBD_SQLite.Size = New Size(429, 23)
        txtPastaBD_SQLite.TabIndex = 2
        ' 
        ' btnSave
        ' 
        btnSave.Location = New Point(269, 246)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(137, 35)
        btnSave.TabIndex = 3
        btnSave.Text = "Gravar"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' lblConfiguraçõesPreenchidas
        ' 
        lblConfiguraçõesPreenchidas.Location = New Point(12, 324)
        lblConfiguraçõesPreenchidas.Name = "lblConfiguraçõesPreenchidas"
        lblConfiguraçõesPreenchidas.Size = New Size(691, 15)
        lblConfiguraçõesPreenchidas.TabIndex = 4
        lblConfiguraçõesPreenchidas.Text = "Label1"
        lblConfiguraçõesPreenchidas.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(394, 15)
        Label1.TabIndex = 5
        Label1.Text = "Os dados seguintes, são indispensáveis ao funcionamento da aplicação ..."
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label2.Location = New Point(29, 57)
        Label2.Name = "Label2"
        Label2.Size = New Size(209, 15)
        Label2.TabIndex = 6
        Label2.Text = "Pasta das fotos no dispositivo móvel:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label3.Location = New Point(110, 95)
        Label3.Name = "Label3"
        Label3.Size = New Size(126, 15)
        Label3.TabIndex = 7
        Label3.Text = "Pasta das fotos no PC:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label4.Location = New Point(39, 136)
        Label4.Name = "Label4"
        Label4.Size = New Size(198, 15)
        Label4.TabIndex = 8
        Label4.Text = "Pasta que contem a base de dados:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label5.Location = New Point(94, 178)
        Label5.Name = "Label5"
        Label5.Size = New Size(140, 15)
        Label5.TabIndex = 10
        Label5.Text = "Nome da base de dados:"
        ' 
        ' txtNomeBd_SQLite
        ' 
        txtNomeBd_SQLite.Location = New Point(247, 175)
        txtNomeBd_SQLite.Name = "txtNomeBd_SQLite"
        txtNomeBd_SQLite.Size = New Size(429, 23)
        txtNomeBd_SQLite.TabIndex = 9
        ' 
        ' picBoxPastaFotosPC
        ' 
        picBoxPastaFotosPC.Image = CType(resources.GetObject("picBoxPastaFotosPC.Image"), Image)
        picBoxPastaFotosPC.Location = New Point(682, 90)
        picBoxPastaFotosPC.Name = "picBoxPastaFotosPC"
        picBoxPastaFotosPC.Size = New Size(25, 26)
        picBoxPastaFotosPC.TabIndex = 11
        picBoxPastaFotosPC.TabStop = False
        ' 
        ' picBoxPastaBD
        ' 
        picBoxPastaBD.Image = CType(resources.GetObject("picBoxPastaBD.Image"), Image)
        picBoxPastaBD.Location = New Point(682, 131)
        picBoxPastaBD.Name = "picBoxPastaBD"
        picBoxPastaBD.Size = New Size(25, 26)
        picBoxPastaBD.TabIndex = 12
        picBoxPastaBD.TabStop = False
        ' 
        ' picBoxNomeBD
        ' 
        picBoxNomeBD.Image = CType(resources.GetObject("picBoxNomeBD.Image"), Image)
        picBoxNomeBD.Location = New Point(682, 175)
        picBoxNomeBD.Name = "picBoxNomeBD"
        picBoxNomeBD.Size = New Size(25, 26)
        picBoxNomeBD.TabIndex = 13
        picBoxNomeBD.TabStop = False
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' frmSettings
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(719, 351)
        Controls.Add(picBoxNomeBD)
        Controls.Add(picBoxPastaBD)
        Controls.Add(picBoxPastaFotosPC)
        Controls.Add(Label5)
        Controls.Add(txtNomeBd_SQLite)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(lblConfiguraçõesPreenchidas)
        Controls.Add(btnSave)
        Controls.Add(txtPastaBD_SQLite)
        Controls.Add(txtPastaFotosPC)
        Controls.Add(txtPastaFotosDispMovel)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        MinimizeBox = False
        Name = "frmSettings"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Definições"
        TopMost = True
        CType(picBoxPastaFotosPC, ComponentModel.ISupportInitialize).EndInit()
        CType(picBoxPastaBD, ComponentModel.ISupportInitialize).EndInit()
        CType(picBoxNomeBD, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtPastaFotosDispMovel As TextBox
    Friend WithEvents txtPastaFotosPC As TextBox
    Friend WithEvents txtPastaBD_SQLite As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents lblConfiguraçõesPreenchidas As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtNomeBd_SQLite As TextBox
    Friend WithEvents picBoxPastaFotosPC As PictureBox
    Friend WithEvents picBoxPastaBD As PictureBox
    Friend WithEvents picBoxNomeBD As PictureBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
