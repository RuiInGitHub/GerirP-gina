Imports System.Data.SQLite
Imports System.IO
Imports System.Text

Public Class frmGerirDadosPágina

    Private connectionString As String

    Private Sub frmGerirDadosPágina_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadSettings()
        ConfigureListView()
        LoadPhotos()
        ConfigureSQLiteConnection()
        LoadDataAndSetupBindings()
    End Sub

    Private Sub lstView_FotosNoPC_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstView_FotosNoPC.SelectedIndexChanged
        If lstView_FotosNoPC.SelectedItems.Count > 0 Then
            Dim selectedImagePath As String = lstView_FotosNoPC.SelectedItems(0).Text
            LoadDataFromImage(selectedImagePath)
            Dim fullPath As String = Path.Combine(txtPastaFotosPC.Text, selectedImagePath)
            Me.PicBoxImgWeb_Grande.ImageLocation = fullPath
        End If
    End Sub

    Private Sub btnSaveBD_Click(sender As Object, e As EventArgs) Handles btnSaveBD.Click
        Using conn As New SQLiteConnection(connectionString)
            conn.Open()

            ' Verifica se é uma atualização ou nova inserção
            Dim imagePath As String = lstView_FotosNoPC.SelectedItems(0).Text
            Dim fullPath As String = Path.Combine(txtPastaFotosPC.Text, imagePath)

            ' Verificar se o registro já existe
            Dim query As String = "SELECT COUNT(*) FROM tblAlimentarWeb WHERE Imagem = @Imagem"
            Dim cmd As New SQLiteCommand(query, conn)
            cmd.Parameters.AddWithValue("@Imagem", fullPath)

            Dim exists As Boolean = Convert.ToInt32(cmd.ExecuteScalar()) > 0

            If exists Then
                ' Atualizar registro existente
                query = "UPDATE tblAlimentarWeb SET Legenda = @Legenda, Descritivo = @Descritivo, Eliminar = @Eliminar, IncluirWeb = @IncluirWeb WHERE Imagem = @Imagem"
            Else
                ' Inserir novo registro
                query = "INSERT INTO tblAlimentarWeb (Imagem, Legenda, Descritivo, Eliminar, IncluirWeb) VALUES (@Imagem, @Legenda, @Descritivo, @Eliminar, @IncluirWeb)"
            End If

            Using cmdUpdateOrInsert As New SQLiteCommand(query, conn)
                cmdUpdateOrInsert.Parameters.AddWithValue("@Imagem", fullPath)
                cmdUpdateOrInsert.Parameters.AddWithValue("@Legenda", txtLegenda.Text)
                cmdUpdateOrInsert.Parameters.AddWithValue("@Descritivo", txtDescritivo.Text)
                cmdUpdateOrInsert.Parameters.AddWithValue("@Eliminar", chkEliminar.Checked)
                cmdUpdateOrInsert.Parameters.AddWithValue("@IncluirWeb", chkIncluirWeb.Checked)
                Dim affectedRows As Integer = cmdUpdateOrInsert.ExecuteNonQuery()

                If affectedRows > 0 Then
                    AppendTextToTextBox("Dados salvos com sucesso!")
                Else
                    AppendTextToTextBox("Nenhuma alteração foi realizada.")
                End If
            End Using
        End Using

        ' Após salvar os dados, recarregue o HTML no navegador (usando o Chrome)
        SaveAndOpenHtmlInChrome()

        AppendTextToTextBox("Dados salvos e HTML atualizado com sucesso!")
    End Sub

    '******************* Settings **********************************************************************

    Dim contadorDeSettingsPreenchidos As Integer

    Private Sub LoadSettings() '(sender As Object, e As EventArgs) Handles MyBase.Load
        txtPastaFotosDispMovel.Text = My.Settings.PastaFotosDispMovel
        txtPastaFotosPC.Text = My.Settings.PastaFotosPC
        txtPastaBD_SQLite.Text = My.Settings.PastaBD_SQLite
        txtNomeBd_SQLite.Text = My.Settings.NomeBD_SQLite
        VerificarCamposPreenchidos()
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        My.Settings.PastaFotosDispMovel = txtPastaFotosDispMovel.Text
        My.Settings.PastaFotosPC = txtPastaFotosPC.Text
        My.Settings.PastaBD_SQLite = txtPastaBD_SQLite.Text
        My.Settings.NomeBD_SQLite = txtNomeBd_SQLite.Text
        My.Settings.Save() ' Salva as configurações
        VerificarCamposPreenchidos()
    End Sub
    Private Sub VerificarCamposPreenchidos()
        contadorDeSettingsPreenchidos = 0
        If Len(txtPastaFotosDispMovel.Text) > 0 Then contadorDeSettingsPreenchidos = contadorDeSettingsPreenchidos + 1
        If Len(txtPastaFotosPC.Text) > 0 Then contadorDeSettingsPreenchidos = contadorDeSettingsPreenchidos + 1
        If Len(txtPastaBD_SQLite.Text) > 0 Then contadorDeSettingsPreenchidos = contadorDeSettingsPreenchidos + 1
        If Len(txtNomeBd_SQLite.Text) > 0 Then contadorDeSettingsPreenchidos = contadorDeSettingsPreenchidos + 1

        If contadorDeSettingsPreenchidos = 4 Then
            txtLegenda.BackColor = Color.White
            txtLegenda.Enabled = True
            txtDescritivo.BackColor = Color.White
            txtDescritivo.Enabled = True
            chkIncluirWeb.Enabled = True
            chkEliminar.Enabled = True
            btnSaveBD.Visible = True
        Else
            txtLegenda.BackColor = Color.WhiteSmoke
            txtLegenda.Enabled = False
            txtDescritivo.BackColor = Color.WhiteSmoke
            txtDescritivo.Enabled = False
            chkIncluirWeb.Enabled = False
            chkEliminar.Enabled = False
            btnSaveBD.Visible = False
        End If

        lblConfiguraçõesPreenchidas.Text = "Configurações preenchidas: " & contadorDeSettingsPreenchidos & " de 4"
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

    '*********************************************** ROTINAS *******************************************************************************

    Private Sub ConfigureSQLiteConnection()

        If String.IsNullOrEmpty(txtPastaBD_SQLite.Text) OrElse String.IsNullOrEmpty(txtNomeBd_SQLite.Text) Then
            MessageBox.Show("Por favor, preencha todos os campos de configuração do banco de dados antes de continuar.")
            Exit Sub
        End If

        Dim dbPath As String = txtPastaBD_SQLite.Text
        Dim dbName As String = txtNomeBd_SQLite.Text
        connectionString = $"Data Source={Path.Combine(dbPath, dbName)};Version=3;"

        ' Testar a conexão
        Try
            Using conn As New SQLiteConnection(connectionString)
                conn.Open()
                AppendTextToTextBox("Conexão com o banco de dados estabelecida com sucesso!")
            End Using
        Catch ex As Exception
            AppendTextToTextBox("Erro ao conectar com o banco de dados: " & ex.Message)
        End Try
    End Sub
    Private Sub LoadDataAndSetupBindings()
        Dim dataTable As New DataTable()
        Using conn As New SQLiteConnection(connectionString)
            conn.Open()
            Dim cmd As New SQLiteCommand("SELECT * FROM tblAlimentarWeb", conn)
            Using adapter As New SQLiteDataAdapter(cmd)
                adapter.Fill(dataTable)
            End Using
        End Using

        If dataTable.Rows.Count > 0 Then
            ' Configurar bindings
            txtLegenda.DataBindings.Clear()
            txtDescritivo.DataBindings.Clear()
            chkEliminar.DataBindings.Clear()
            chkIncluirWeb.DataBindings.Clear()

            txtLegenda.DataBindings.Add("Text", dataTable, "Legenda")
            txtDescritivo.DataBindings.Add("Text", dataTable, "Descritivo")
            chkEliminar.DataBindings.Add("Checked", dataTable, "Eliminar", True, DataSourceUpdateMode.OnPropertyChanged, False, "False")
            chkIncluirWeb.DataBindings.Add("Checked", dataTable, "IncluirWeb", True, DataSourceUpdateMode.OnPropertyChanged, False, "False")

            ' Carregar imagem
            Dim imagePath As String = dataTable.Rows(0)("Imagem").ToString()
            If File.Exists(imagePath) Then
                picBoxImgWeb.Image = Image.FromFile(imagePath)
                PicBoxImgWeb_Grande.Image = Image.FromFile(imagePath)
            End If
        Else
            AppendTextToTextBox("Base de dados está vazia. Verifique o caminho indicado em: ""Pasta que contem a base de dados"" e o valor indicado em: ""Nome da base de dados""")
        End If
    End Sub

    Private Sub ConfigureListView()
        ' Configurar para mostrar ícones grandes
        lstView_FotosNoPC.View = View.LargeIcon

        ' Criar uma lista de imagens para armazenar os ícones das fotos
        lstView_FotosNoPC.LargeImageList = New ImageList()
        lstView_FotosNoPC.LargeImageList.ImageSize = New Size(64, 64)  ' Define o tamanho dos ícones

        ' Limpar itens existentes (se necessário)
        lstView_FotosNoPC.Items.Clear()
    End Sub
    Private Sub LoadPhotos()
        Dim folderPath As String = txtPastaFotosPC.Text
        If Directory.Exists(folderPath) Then
            Dim fileEntries As String() = Directory.GetFiles(folderPath, "*.jpg")  ' Assume que são arquivos JPG

            ' Limpar imagens existentes
            lstView_FotosNoPC.LargeImageList.Images.Clear()

            ' Adicionar cada arquivo encontrado à ListView
            For Each fileName In fileEntries
                Dim image As Image = Image.FromFile(fileName)
                lstView_FotosNoPC.LargeImageList.Images.Add(fileName, image)

                Dim item As New ListViewItem(Path.GetFileName(fileName), fileName)
                lstView_FotosNoPC.Items.Add(item)
            Next
        Else
            AppendTextToTextBox("Pasta do windows " & folderPath & " não encontrada")
        End If
    End Sub
    Private Sub LoadDataFromImage(imageName As String)
        Dim baseImagePath As String = txtPastaFotosPC.Text ' Supondo que este seja o diretório base
        Dim fullPath As String = Path.Combine(baseImagePath, imageName)

        Using conn As New SQLiteConnection(connectionString)
            conn.Open()
            Dim query As String = "SELECT * FROM tblAlimentarWeb WHERE Imagem LIKE @ImagePath"
            Using cmd As New SQLiteCommand(query, conn)
                cmd.Parameters.AddWithValue("@ImagePath", "%" & imageName & "%")
                Using reader As SQLiteDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        ' A imagem existe, carregar dados para os controles
                        txtLegenda.Text = reader("Legenda").ToString()
                        txtDescritivo.Text = reader("Descritivo").ToString()
                        chkEliminar.Checked = Convert.ToBoolean(reader("Eliminar"))
                        chkIncluirWeb.Checked = Convert.ToBoolean(reader("IncluirWeb"))
                        picBoxImgWeb.Image = Image.FromFile(fullPath)
                    Else
                        ' Novo registro, resetar campos e mostrar a imagem
                        txtLegenda.Text = ""
                        txtDescritivo.Text = ""
                        chkEliminar.Checked = False
                        chkIncluirWeb.Checked = False
                        Try
                            ' Carregar as imagens nos PictureBox
                            picBoxImgWeb.Image = Image.FromFile(fullPath) ' Carregar a imagem no PictureBox
                            PicBoxImgWeb_Grande.Image = Image.FromFile(fullPath)
                        Catch ex As Exception
                            AppendTextToTextBox("Erro ao carregar a imagem: " & ex.Message)
                            picBoxImgWeb.Image = Nothing
                            PicBoxImgWeb_Grande.Image = Nothing
                        End Try
                    End If
                End Using
            End Using
        End Using
    End Sub
    Private Function GenerateHTML() As String
        Dim html As New StringBuilder()
        html.AppendLine("<!DOCTYPE html>")
        html.AppendLine("<html lang='en'>")
        html.AppendLine("<head>")
        html.AppendLine("    <meta charset='UTF-8'>")
        html.AppendLine("    <meta name='viewport' content='width=device-width, initial-scale=1.0'>")
        html.AppendLine("    <title>Loja da Fátima</title>")
        html.AppendLine("    <style>")
        html.AppendLine("        html, body { height: 100%; margin: 0; overflow-y: auto; }")
        html.AppendLine("        body { font-family: Arial, sans-serif; padding: 20px; }")
        html.AppendLine("        img { max-width: 100%; height: auto; }")
        html.AppendLine("        p { word-wrap: break-word; max-width: 800px; }")
        html.AppendLine("    </style>")
        html.AppendLine("</head>")
        html.AppendLine("<body>")
        html.AppendLine("    <h1>Loja da Fátima</h1>")
        html.AppendLine("    <script>")
        html.AppendLine("      window.onload = function() {")
        html.AppendLine("        console.log('Página carregada completamente.');")
        html.AppendLine("      };")
        html.AppendLine("    </script>")

        Using conn As New SQLiteConnection(connectionString)
            conn.Open()
            Dim cmd As New SQLiteCommand("SELECT * FROM tblAlimentarWeb", conn)
            Using reader As SQLiteDataReader = cmd.ExecuteReader()
                While reader.Read()
                    'Dim imagePath As String = reader("Imagem").ToString()
                    Dim imagePath As String = GetHtmlImageSrc(reader("Imagem").ToString())
                    Dim legenda As String = reader("Legenda").ToString()
                    Dim descritivo As String = reader("Descritivo").ToString()
                    html.AppendLine($"    <img src='{imagePath}' alt='Imagem'>")
                    html.AppendLine($"    <h2>{legenda}</h2>")
                    html.AppendLine($"    <p>{descritivo}</p>")
                End While
            End Using
        End Using

        html.AppendLine("</body>")
        html.AppendLine("</html>")

        Return html.ToString()
    End Function
    Private Function GetHtmlImageSrc(imagePath As String) As String
        ' Converte o caminho do arquivo em um URI que pode ser usado em HTML
        Dim a As String = New Uri(imagePath).AbsoluteUri
        Return New Uri(imagePath).AbsoluteUri
    End Function

    Private Sub SaveAndOpenHtmlInChrome()
        Dim htmlContent As String = GenerateHTML()
        Dim filePath As String = Path.Combine(Application.StartupPath, "tempHtml.html")

        ' Escreve o conteúdo HTML no arquivo
        File.WriteAllText(filePath, htmlContent)

        ' Abrir o arquivo HTML no Google Chrome
        OpenHtmlInChrome(filePath)
    End Sub

    Private Sub OpenHtmlInChrome(filePath As String)
        Dim chromePath As String = "C:\Program Files\Google\Chrome\Application\chrome.exe"

        ' Verifica se o Chrome está instalado no caminho padrão
        If File.Exists(chromePath) Then
            Process.Start(chromePath, filePath)
        Else
            ' Se o Chrome não estiver no caminho padrão, tenta abrir o arquivo HTML com o navegador padrão
            Process.Start("explorer.exe", filePath)
        End If
    End Sub




    ' Método auxiliar para adicionar texto ao TextBox de maneira segura
    Private Sub AppendTextToTextBox(text As String)
        ' Verifica se a chamada vem de um thread diferente do thread da UI
        If TextBox1.InvokeRequired Then
            TextBox1.Invoke(Sub() AppendTextToTextBox(text))
        Else
            TextBox1.AppendText(text & Environment.NewLine)
        End If
    End Sub

End Class
