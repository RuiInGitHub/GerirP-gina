<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmGerirDadosPágina
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGerirDadosPágina))
        picBoxNomeBD = New PictureBox()
        picBoxPastaBD = New PictureBox()
        picBoxPastaFotosPC = New PictureBox()
        Label5 = New Label()
        txtNomeBd_SQLite = New TextBox()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        lblConfiguraçõesPreenchidas = New Label()
        btnSave = New Button()
        txtPastaBD_SQLite = New TextBox()
        txtPastaFotosPC = New TextBox()
        txtPastaFotosDispMovel = New TextBox()
        txtLegenda = New TextBox()
        Label6 = New Label()
        picBoxImgWeb = New PictureBox()
        txtDescritivo = New TextBox()
        Label7 = New Label()
        Label8 = New Label()
        Panel1 = New Panel()
        btnSaveBD = New Button()
        chkEliminar = New CheckBox()
        chkIncluirWeb = New CheckBox()
        Panel2 = New Panel()
        lstView_FotosNoPC = New ListView()
        TextBox1 = New TextBox()
        PicBoxImgWeb_Grande = New PictureBox()
        CType(picBoxNomeBD, ComponentModel.ISupportInitialize).BeginInit()
        CType(picBoxPastaBD, ComponentModel.ISupportInitialize).BeginInit()
        CType(picBoxPastaFotosPC, ComponentModel.ISupportInitialize).BeginInit()
        CType(picBoxImgWeb, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(PicBoxImgWeb_Grande, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' picBoxNomeBD
        ' 
        picBoxNomeBD.Image = CType(resources.GetObject("picBoxNomeBD.Image"), Image)
        picBoxNomeBD.Location = New Point(254, 191)
        picBoxNomeBD.Name = "picBoxNomeBD"
        picBoxNomeBD.Size = New Size(25, 26)
        picBoxNomeBD.TabIndex = 27
        picBoxNomeBD.TabStop = False
        ' 
        ' picBoxPastaBD
        ' 
        picBoxPastaBD.Image = CType(resources.GetObject("picBoxPastaBD.Image"), Image)
        picBoxPastaBD.Location = New Point(254, 149)
        picBoxPastaBD.Name = "picBoxPastaBD"
        picBoxPastaBD.Size = New Size(25, 26)
        picBoxPastaBD.TabIndex = 26
        picBoxPastaBD.TabStop = False
        ' 
        ' picBoxPastaFotosPC
        ' 
        picBoxPastaFotosPC.Image = CType(resources.GetObject("picBoxPastaFotosPC.Image"), Image)
        picBoxPastaFotosPC.Location = New Point(254, 106)
        picBoxPastaFotosPC.Name = "picBoxPastaFotosPC"
        picBoxPastaFotosPC.Size = New Size(25, 26)
        picBoxPastaFotosPC.TabIndex = 25
        picBoxPastaFotosPC.TabStop = False
        ' 
        ' Label5
        ' 
        Label5.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label5.Location = New Point(8, 178)
        Label5.Name = "Label5"
        Label5.Size = New Size(140, 14)
        Label5.TabIndex = 24
        Label5.Text = "Nome da base de dados:"
        Label5.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' txtNomeBd_SQLite
        ' 
        txtNomeBd_SQLite.Location = New Point(8, 195)
        txtNomeBd_SQLite.Name = "txtNomeBd_SQLite"
        txtNomeBd_SQLite.Size = New Size(240, 23)
        txtNomeBd_SQLite.TabIndex = 23
        ' 
        ' Label4
        ' 
        Label4.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label4.Location = New Point(8, 136)
        Label4.Name = "Label4"
        Label4.Size = New Size(215, 14)
        Label4.TabIndex = 22
        Label4.Text = "Pasta que contem a base de dados:"
        Label4.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label3
        ' 
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label3.Location = New Point(8, 93)
        Label3.Name = "Label3"
        Label3.Size = New Size(140, 14)
        Label3.TabIndex = 21
        Label3.Text = "Pasta das fotos no PC:"
        Label3.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label2
        ' 
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label2.Location = New Point(8, 45)
        Label2.Name = "Label2"
        Label2.Size = New Size(215, 19)
        Label2.TabIndex = 20
        Label2.Text = "Pasta das fotos no dispositivo móvel:"
        Label2.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label1
        ' 
        Label1.Location = New Point(8, 10)
        Label1.Name = "Label1"
        Label1.Size = New Size(271, 37)
        Label1.TabIndex = 19
        Label1.Text = "Os dados seguintes, são indispensáveis ao funcionamento da aplicação ..."
        ' 
        ' lblConfiguraçõesPreenchidas
        ' 
        lblConfiguraçõesPreenchidas.Location = New Point(8, 249)
        lblConfiguraçõesPreenchidas.Name = "lblConfiguraçõesPreenchidas"
        lblConfiguraçõesPreenchidas.Size = New Size(240, 25)
        lblConfiguraçõesPreenchidas.TabIndex = 18
        lblConfiguraçõesPreenchidas.Text = "Label1"
        lblConfiguraçõesPreenchidas.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btnSave
        ' 
        btnSave.Location = New Point(70, 219)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(104, 25)
        btnSave.TabIndex = 17
        btnSave.Text = "Gravar"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' txtPastaBD_SQLite
        ' 
        txtPastaBD_SQLite.Location = New Point(8, 153)
        txtPastaBD_SQLite.Name = "txtPastaBD_SQLite"
        txtPastaBD_SQLite.Size = New Size(240, 23)
        txtPastaBD_SQLite.TabIndex = 16
        ' 
        ' txtPastaFotosPC
        ' 
        txtPastaFotosPC.Location = New Point(8, 110)
        txtPastaFotosPC.Name = "txtPastaFotosPC"
        txtPastaFotosPC.Size = New Size(240, 23)
        txtPastaFotosPC.TabIndex = 15
        ' 
        ' txtPastaFotosDispMovel
        ' 
        txtPastaFotosDispMovel.Location = New Point(8, 67)
        txtPastaFotosDispMovel.Name = "txtPastaFotosDispMovel"
        txtPastaFotosDispMovel.Size = New Size(240, 23)
        txtPastaFotosDispMovel.TabIndex = 14
        ' 
        ' txtLegenda
        ' 
        txtLegenda.BackColor = SystemColors.ButtonFace
        txtLegenda.Enabled = False
        txtLegenda.Location = New Point(10, 224)
        txtLegenda.Name = "txtLegenda"
        txtLegenda.Size = New Size(271, 23)
        txtLegenda.TabIndex = 28
        ' 
        ' Label6
        ' 
        Label6.Location = New Point(36, 2)
        Label6.Name = "Label6"
        Label6.Size = New Size(224, 18)
        Label6.TabIndex = 29
        Label6.Text = "Escolha a foto a tratar na lista da direita"
        ' 
        ' picBoxImgWeb
        ' 
        picBoxImgWeb.BackColor = Color.Transparent
        picBoxImgWeb.BorderStyle = BorderStyle.FixedSingle
        picBoxImgWeb.Enabled = False
        picBoxImgWeb.Location = New Point(36, 23)
        picBoxImgWeb.Name = "picBoxImgWeb"
        picBoxImgWeb.Size = New Size(224, 172)
        picBoxImgWeb.SizeMode = PictureBoxSizeMode.Zoom
        picBoxImgWeb.TabIndex = 30
        picBoxImgWeb.TabStop = False
        ' 
        ' txtDescritivo
        ' 
        txtDescritivo.BackColor = SystemColors.ButtonFace
        txtDescritivo.Enabled = False
        txtDescritivo.Location = New Point(10, 268)
        txtDescritivo.Multiline = True
        txtDescritivo.Name = "txtDescritivo"
        txtDescritivo.Size = New Size(271, 170)
        txtDescritivo.TabIndex = 31
        ' 
        ' Label7
        ' 
        Label7.Location = New Point(10, 206)
        Label7.Name = "Label7"
        Label7.Size = New Size(271, 15)
        Label7.TabIndex = 32
        Label7.Text = "Legenda"
        Label7.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label8
        ' 
        Label8.Location = New Point(10, 250)
        Label8.Name = "Label8"
        Label8.Size = New Size(271, 15)
        Label8.TabIndex = 33
        Label8.Text = "Descritivo"
        Label8.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.InactiveBorder
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(btnSaveBD)
        Panel1.Controls.Add(chkEliminar)
        Panel1.Controls.Add(chkIncluirWeb)
        Panel1.Controls.Add(Label8)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(txtDescritivo)
        Panel1.Controls.Add(picBoxImgWeb)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(txtLegenda)
        Panel1.Location = New Point(12, 291)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(291, 494)
        Panel1.TabIndex = 34
        ' 
        ' btnSaveBD
        ' 
        btnSaveBD.Location = New Point(88, 464)
        btnSaveBD.Name = "btnSaveBD"
        btnSaveBD.Size = New Size(104, 25)
        btnSaveBD.TabIndex = 36
        btnSaveBD.Text = "Gravar"
        btnSaveBD.UseVisualStyleBackColor = True
        btnSaveBD.Visible = False
        ' 
        ' chkEliminar
        ' 
        chkEliminar.AutoSize = True
        chkEliminar.BackColor = Color.Transparent
        chkEliminar.Enabled = False
        chkEliminar.Location = New Point(210, 442)
        chkEliminar.Name = "chkEliminar"
        chkEliminar.Size = New Size(69, 19)
        chkEliminar.TabIndex = 35
        chkEliminar.Text = "Eliminar"
        chkEliminar.UseVisualStyleBackColor = False
        ' 
        ' chkIncluirWeb
        ' 
        chkIncluirWeb.AutoSize = True
        chkIncluirWeb.BackColor = Color.Transparent
        chkIncluirWeb.Enabled = False
        chkIncluirWeb.Location = New Point(14, 442)
        chkIncluirWeb.Name = "chkIncluirWeb"
        chkIncluirWeb.Size = New Size(98, 19)
        chkIncluirWeb.TabIndex = 34
        chkIncluirWeb.Text = "Incluir Página"
        chkIncluirWeb.UseVisualStyleBackColor = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.InactiveBorder
        Panel2.BorderStyle = BorderStyle.FixedSingle
        Panel2.Controls.Add(picBoxNomeBD)
        Panel2.Controls.Add(picBoxPastaBD)
        Panel2.Controls.Add(picBoxPastaFotosPC)
        Panel2.Controls.Add(Label5)
        Panel2.Controls.Add(txtNomeBd_SQLite)
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(Label1)
        Panel2.Controls.Add(lblConfiguraçõesPreenchidas)
        Panel2.Controls.Add(btnSave)
        Panel2.Controls.Add(txtPastaBD_SQLite)
        Panel2.Controls.Add(txtPastaFotosPC)
        Panel2.Controls.Add(txtPastaFotosDispMovel)
        Panel2.Location = New Point(12, 3)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(291, 282)
        Panel2.TabIndex = 35
        ' 
        ' lstView_FotosNoPC
        ' 
        lstView_FotosNoPC.Location = New Point(316, 3)
        lstView_FotosNoPC.Name = "lstView_FotosNoPC"
        lstView_FotosNoPC.Size = New Size(135, 784)
        lstView_FotosNoPC.TabIndex = 36
        lstView_FotosNoPC.UseCompatibleStateImageBehavior = False
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(12, 793)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.ScrollBars = ScrollBars.Vertical
        TextBox1.Size = New Size(1325, 53)
        TextBox1.TabIndex = 38
        ' 
        ' PicBoxImgWeb_Grande
        ' 
        PicBoxImgWeb_Grande.Location = New Point(478, 87)
        PicBoxImgWeb_Grande.Name = "PicBoxImgWeb_Grande"
        PicBoxImgWeb_Grande.Size = New Size(859, 610)
        PicBoxImgWeb_Grande.TabIndex = 39
        PicBoxImgWeb_Grande.TabStop = False
        ' 
        ' frmGerirDadosPágina
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Window
        ClientSize = New Size(1360, 853)
        Controls.Add(PicBoxImgWeb_Grande)
        Controls.Add(TextBox1)
        Controls.Add(lstView_FotosNoPC)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "frmGerirDadosPágina"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Gerir a página web"
        CType(picBoxNomeBD, ComponentModel.ISupportInitialize).EndInit()
        CType(picBoxPastaBD, ComponentModel.ISupportInitialize).EndInit()
        CType(picBoxPastaFotosPC, ComponentModel.ISupportInitialize).EndInit()
        CType(picBoxImgWeb, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PicBoxImgWeb_Grande, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents picBoxNomeBD As PictureBox
    Friend WithEvents picBoxPastaBD As PictureBox
    Friend WithEvents picBoxPastaFotosPC As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtNomeBd_SQLite As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblConfiguraçõesPreenchidas As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents txtPastaBD_SQLite As TextBox
    Friend WithEvents txtPastaFotosPC As TextBox
    Friend WithEvents txtPastaFotosDispMovel As TextBox
    Friend WithEvents txtLegenda As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents picBoxImgWeb As PictureBox
    Friend WithEvents txtDescritivo As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents chkEliminar As CheckBox
    Friend WithEvents chkIncluirWeb As CheckBox
    Friend WithEvents btnSaveBD As Button
    Friend WithEvents lstView_FotosNoPC As ListView
    Friend WithEvents TextBox1 As TextBox
    'Friend WithEvents WebView21 As Microsoft.Web.WebView2.WinForms.WebView2
    Friend WithEvents PicBoxImgWeb_Grande As PictureBox

End Class
