

'Imports System.Windows.Forms.VisualStyles.VisualStyleElement

'Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class frmSettings
    Dim contadorDeSettingsPreenchidos As Integer
    Private Sub frmSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtPastaFotosDispMovel.Text = My.Settings.PastaFotosDispMovel
        txtPastaFotosPC.Text = My.Settings.PastaFotosPC
        txtPastaBD_SQLite.Text = My.Settings.PastaBD_SQLite
        txtNomeBd_SQLite.Text = My.Settings.NomeBD_SQLite
        VerificarCamposPreenchidos()
        lblConfiguraçõesPreenchidas.Text = "Configurações preenchidas: " & contadorDeSettingsPreenchidos & " de 4"
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        My.Settings.PastaFotosDispMovel = txtPastaFotosDispMovel.Text
        My.Settings.PastaFotosPC = txtPastaFotosPC.Text
        My.Settings.PastaBD_SQLite = txtPastaBD_SQLite.Text
        My.Settings.NomeBD_SQLite = txtNomeBd_SQLite.Text
        My.Settings.Save() ' Salva as configurações

        MessageBox.Show("Configurações salvas com sucesso!")

        VerificarCamposPreenchidos()
        If contadorDeSettingsPreenchidos = 4 Then
            Me.Close() ' Fecha o formulário após salvar as configurações
            'frmGerirDadosPágina.ShowDialog()
        Else
            lblConfiguraçõesPreenchidas.Text = "Configurações preenchidas: " & contadorDeSettingsPreenchidos & " de 4"
        End If
    End Sub
    Private Sub frmSettings_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        VerificarCamposPreenchidos()
        If contadorDeSettingsPreenchidos < 4 Then
            Application.Exit()
        End If
    End Sub
    Private Sub VerificarCamposPreenchidos()
        contadorDeSettingsPreenchidos = 0
        If Len(txtPastaFotosDispMovel.Text) > 0 Then contadorDeSettingsPreenchidos = contadorDeSettingsPreenchidos + 1
        If Len(txtPastaFotosPC.Text) > 0 Then contadorDeSettingsPreenchidos = contadorDeSettingsPreenchidos + 1
        If Len(txtPastaBD_SQLite.Text) > 0 Then contadorDeSettingsPreenchidos = contadorDeSettingsPreenchidos + 1
        If Len(txtNomeBd_SQLite.Text) > 0 Then contadorDeSettingsPreenchidos = contadorDeSettingsPreenchidos + 1
    End Sub

    Private Sub picBoxPastaFotosPC_Click(sender As Object, e As EventArgs) Handles picBoxPastaFotosPC.Click
        PathPasta(txtPastaFotosPC)
    End Sub
    Private Sub picBoxPastaBD_Click(sender As Object, e As EventArgs) Handles picBoxPastaBD.Click
        PathPasta(txtPastaBD_SQLite)
    End Sub
    Private Sub picBoxNomeBD_Click(sender As Object, e As EventArgs) Handles picBoxNomeBD.Click
        PathFile(txtNomeBd_SQLite)
    End Sub
    Sub PathPasta(TextBox As TextBox)
        ' Cria uma instância do FolderBrowserDialog
        Using folderDialog As New FolderBrowserDialog()
            folderDialog.RootFolder = Environment.SpecialFolder.MyComputer  ' Define a pasta raiz na visualização inicial
            folderDialog.Description = "Selecione a pasta"  ' Texto de descrição no diálogo

            ' Mostra o FolderBrowserDialog
            If folderDialog.ShowDialog() = DialogResult.OK Then
                ' Se o usuário selecionar uma pasta e clicar em OK, o caminho da pasta é colocado na TextBox
                TextBox.Text = folderDialog.SelectedPath
            End If
        End Using
    End Sub
    Sub PathFile(TextBox As TextBox)
        Using openFileDialog As New OpenFileDialog()
            openFileDialog.InitialDirectory = "c:\"  ' Define o diretório inicial
            openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*"  ' Define os filtros de arquivo
            openFileDialog.FilterIndex = 2  ' Seleciona o segundo filtro por padrão
            openFileDialog.RestoreDirectory = True  ' Restaura o diretório anterior antes de fechar o diálogo
            openFileDialog.Title = "Selecione um arquivo"  ' Título da janela de diálogo

            ' Mostra o diálogo
            If openFileDialog.ShowDialog() = DialogResult.OK Then
                ' A propriedade FileName contém o caminho do arquivo selecionado
                TextBox.Text = openFileDialog.FileName
            End If
        End Using
    End Sub
End Class