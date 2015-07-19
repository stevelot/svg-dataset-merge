Imports System.Data.OleDb

Public Class frmEtiketten



#Region " buttons "

    Private Sub btnFileIn_Click(sender As Object, e As EventArgs) Handles btnFileIn.Click
        Dim filter = "Svg files, Inkscape,... (*.svg)|*.svg" & _
                     "|Xml files (*.xml)|*.xml" & _
                     "|All Files (*.*)|*.*"
        Dim out = OpenFile(txtFileIn.Text, filter)
        If (Not out Is Nothing) Then
            Cursor = Cursors.WaitCursor
            txtFileIn.Text = out
            LoadSvg(txtFileIn.Text, txtXpath.Text, txtXpathSize.Text)
            Cursor = Cursors.Default
        End If
    End Sub

    Private Sub btnConStr_Click(sender As Object, e As EventArgs) Handles btnConStr.Click
        Dim filter = "Excel files (*.xls,*.xlsx)|*.xls;*.xlsx" & _
                     "|All Files (*.*)|*.*"
        Dim out = OpenFile(txtDataFile.Text, filter)
        If (Not out Is Nothing) Then
            Cursor = Cursors.WaitCursor
            txtDataFile.Text = out
            txtDataSource.Text = GenerateConStr(out)
            _DataTable = getTable(txtDataSource.Text, txtQuery.Text)
            btnTestQuery.Enabled = True
            radFile.Checked = True
            Cursor = Cursors.Default
        End If
    End Sub


    Private Sub btnTestQuery_Click(sender As Object, e As EventArgs) Handles btnTestQuery.Click
        Cursor = Cursors.WaitCursor

        _DataTable = getTable(txtDataSource.Text, txtQuery.Text)
        lblRowCount.Text = "Rows found: " & _DataTable.Rows.Count

        If (_DataTable.Columns.Count > 0 And _DataTable.Rows.Count > 0) Then
            btnStart.Enabled = True
        End If

        Cursor = Cursors.Default
    End Sub

    Private Sub btnFileOut_Click(sender As Object, e As EventArgs) Handles btnFileOut.Click
        With SaveFileDialog1
            .Title = "Please Select a File..."
            .Filter = "Svg files, Inkscape,... (*.svg)|*.svg" & _
                     "|Xml files (*.xml)|*.xml" & _
                     "|All Files (*.*)|*.*"
            .FilterIndex = 1

            Dim oFileInfo As System.IO.FileInfo
            Try
                oFileInfo = New System.IO.FileInfo(txtFileOut.Text)
                If (oFileInfo.Directory Is Nothing) Then
                    Throw New Exception()
                End If
            Catch ex As Exception
                oFileInfo = New System.IO.FileInfo(Application.StartupPath & _
                                                   System.IO.Path.DirectorySeparatorChar)
            End Try

            If (oFileInfo.Directory.Exists) Then
                .InitialDirectory = oFileInfo.Directory.FullName
                .FileName = oFileInfo.Name
            End If

            If (.ShowDialog() = Windows.Forms.DialogResult.OK) Then
                oFileInfo = New System.IO.FileInfo(.FileName)
                'If (oFileInfo.Exists) Then
                '    If (MsgBox("File '" & .FileName & "' already exists, overwrite?", _
                '               MsgBoxStyle.YesNo Or MsgBoxStyle.Question Or MsgBoxStyle.DefaultButton2 _
                '               ) = MsgBoxResult.Yes) Then
                '        txtFileOut.Text = .FileName
                '    End If
                'Else
                txtFileOut.Text = .FileName
                'End If
            End If
        End With
    End Sub

    Private Sub btnCalculateCopies_Click(sender As Object, e As EventArgs) Handles btnCalculateCopies.Click
        numX.Value = CDec(Math.Floor(_SvgDimensions.width / _SvgCopyDimensions.width))
        numY.Value = CDec(Math.Floor(_SvgDimensions.height / _SvgCopyDimensions.height))
    End Sub


    Private Sub lnkOutputFile_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkOutputFile.LinkClicked
        Process.Start(lnkOutputFile.Text)
    End Sub


    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        Cursor = Cursors.WaitCursor
        LoadSvg(txtFileIn.Text, txtXpath.Text, txtXpathSize.Text)
        GenerateOutput(_SvgIn, txtXpath.Text, txtXpathSize.Text, txtFileOut.Text, _
                       txtDataSource.Text, txtQuery.Text)


        Cursor = Cursors.Default
    End Sub
#End Region



    Private Function OpenFile(ByVal input As String, filter As String) As String
        With OpenFileDialog1
            .Title = "Please Select a File..."
            .Filter = filter
            .FilterIndex = 1
            .ReadOnlyChecked = True
            .Multiselect = False

            Dim oFileInfo As System.IO.FileInfo
            Try
                oFileInfo = New System.IO.FileInfo(input)
                If (oFileInfo.Directory Is Nothing) Then
                    Throw New Exception()
                End If
            Catch ex As Exception
                oFileInfo = New System.IO.FileInfo(Application.StartupPath & _
                                                   System.IO.Path.DirectorySeparatorChar)
            End Try

            If (oFileInfo.Directory.Exists) Then
                .InitialDirectory = oFileInfo.Directory.FullName
                .FileName = oFileInfo.Name
            End If

            If (.ShowDialog() = Windows.Forms.DialogResult.OK) Then
                oFileInfo = New System.IO.FileInfo(.FileName)
                If (oFileInfo.Exists) Then
                    Return .FileName
                Else
                    MsgBox("File '" & .FileName & "' was not found.", MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation)

                End If
            End If
        End With

        Return Nothing
    End Function

    Private _SvgIn As New System.Xml.XmlDocument(SvgNamespaceManager.NameTable)
    Private _SvgCopyDimensions As New dimension(0.0, 0.0)
    Private _SvgDimensions As New dimension(0.0, 0.0)

    Private _DataTable As DataTable


    Private Sub LoadSvg(ByVal fileIn As String, ByVal copyXpath As String, ByVal sizeXpath As String)
        Dim oNsm = SvgNamespaceManager

        _SvgIn.Load(fileIn)

        Dim oOriginal = _SvgIn.SelectSingleNode(copyXpath, oNsm)
        If (oOriginal Is Nothing) Then
            MsgBox("Copy xpath element not founc.")
            Exit Sub
        End If

        Dim oSize = oOriginal.SelectSingleNode(sizeXpath, oNsm)
        If (oSize Is Nothing) Then
            MsgBox("Size xpath element not found.")
            Exit Sub
        End If

        Dim culture = Globalization.CultureInfo.GetCultureInfo("en-US")
        _SvgCopyDimensions.width = Single.Parse(oSize.Attributes.GetNamedItem("width").Value, culture)
        _SvgCopyDimensions.height = Single.Parse(oSize.Attributes.GetNamedItem("height").Value, culture)

        _SvgDimensions.width = Single.Parse(_SvgIn.DocumentElement.Attributes.GetNamedItem("width").Value, culture)
        _SvgDimensions.height = Single.Parse(_SvgIn.DocumentElement.Attributes.GetNamedItem("height").Value, culture)

        btnCalculateCopies.Enabled = True
    End Sub

    Private Sub GenerateOutput(ByVal oDoc As System.Xml.XmlDocument, _
                               ByVal copyXpath As String, ByVal sizeXpath As String, _
                               ByVal outputFile As String, _
                               connectionString As String, query As String)
        Dim sXpath As String
        Dim oXml As New System.Xml.XmlDocument()
        Dim oNsm = SvgNamespaceManager
        Dim oTmp As Object
        Dim x, y As Integer

        Dim oTmpNode As Xml.XmlNode

        Dim oOriginal = oDoc.SelectSingleNode(copyXpath, oNsm)
        Dim oSize = oOriginal.SelectSingleNode(sizeXpath, oNsm)

        Dim culture = Globalization.CultureInfo.GetCultureInfo("en-US")
        '_SvgCopyDimensions.width = Single.Parse(oSize.Attributes.GetNamedItem("width").Value, culture)
        '_SvgCopyDimensions.height = Single.Parse(oSize.Attributes.GetNamedItem("height").Value, culture)


        _DataTable = getTable(connectionString, query)
        Dim oDt = _DataTable
        Dim iNodes As Integer = CInt(numX.Value * numY.Value)


        If (oDt.Columns.Count > 0 And oDt.Rows.Count > 0) Then
            If (iNodes > oDt.Rows.Count) Then
                iNodes = oDt.Rows.Count
            End If
            Dim oNodes(iNodes - 1) As System.Xml.XmlNode

            For i = 0 To iNodes - 1

                x = CInt(i Mod numX.Value)
                y = CInt((i - x) / numX.Value)

                oNodes(i) = oOriginal.CloneNode(True)
                With oNodes(i)
                    'Vervangen alle teksten (zoals in een mailmerge)
                    For Each oCol As DataColumn In oDt.Columns
                        sXpath = "//*[@id='" & oCol.ColumnName & "']"
                        oTmpNode = .SelectSingleNode(sXpath, oNsm)
                        If (Not oTmpNode Is Nothing) Then
                            oTmp = oDt.Rows(i).Item(CStr(oCol.ColumnName))
                            oTmpNode.InnerText = If(IsDBNull(oTmp), "", CStr(oTmp))
                        End If
                    Next

                    'hernoem alle id's
                    sXpath = "//@id"
                    For Each oTmpNode In .SelectNodes(sXpath)
                        oTmpNode.Value = oTmpNode.Value & "_" & i
                    Next

                    'Verplaats het gegenereerde element
                    Dim oTransform = .OwnerDocument.CreateAttribute("transform")
                    oTransform.Value = "translate(" & (_SvgCopyDimensions.width * x).ToString("0.#####", culture) & "," & _
                                                      (_SvgCopyDimensions.height * y).ToString("0.#####", culture) & ")"
                    .Attributes.Append(oTransform)
                End With

                oOriginal.ParentNode.AppendChild(oNodes(i))
            Next

        Else
            MsgBox("Aantal kolommen of rijen is 0.")
        End If

        oOriginal.ParentNode.RemoveChild(oOriginal)

        oDt.Dispose()

        Dim writer As Xml.XmlTextWriter = New Xml.XmlTextWriter(outputFile, System.Text.Encoding.UTF8)
        writer.Formatting = Xml.Formatting.None
        oDoc.Save(writer)
        writer.Close()
        oDoc.LoadXml("<x/>")


    End Sub

    Private Function getSheets(connectionString As String) As List(Of String)
        Dim out As New List(Of String)

        Using cn As New OleDbConnection With {.ConnectionString = connectionString}
            Try
                cn.Open()
                Dim dt = cn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, Nothing)
                For Each row As DataRow In dt.Rows
                    out.Add(row("TABLE_NAME").ToString())
                Next
            Catch ex As Exception
                MsgBox(ex.ToString())
            Finally
                Try
                    cn.Close()
                Catch ex As Exception
                End Try
            End Try
        End Using

        Return out
    End Function

    Private Function getTable(connectionString As String, query As String) As DataTable
        'http://yoursandmyideas.wordpress.com/2011/02/05/how-to-read-or-write-excel-file-using-ace-oledb-data-provider/

        Dim out As New DataTable
        Dim message As String = Nothing

        Using cn As New OleDbConnection With {.ConnectionString = connectionString}
            ' Beings Excel gives Fn column names when a sheet/range has no column names in
            ' the first row we provide our own names.
            Try
                Dim cmd As New OleDbCommand With {.CommandText = query, .Connection = cn}
                cn.Open()
                out.Load(cmd.ExecuteReader())
            Catch ex As Exception
                message = ex.ToString()
            Finally
                Try
                    cn.Close()
                Catch ex As Exception
                End Try
            End Try
        End Using

        If (message IsNot Nothing) Then
            Dim sTmp As String = ""
            Try
                For Each s In getSheets(connectionString)
                    sTmp &= If(sTmp = "", "", ", ") & s
                Next
                sTmp = "Available tables (excel sheets): " & sTmp
            Catch ex As Exception
                sTmp = "Could not search for tables (excel sheets)..."
            End Try
            MsgBox(message & vbCrLf & vbCrLf & sTmp)
        End If

        Return out
    End Function


    Private Shared _oSvgNamespaceManager As System.Xml.XmlNamespaceManager
    Public Shared ReadOnly Property SvgNamespaceManager As System.Xml.XmlNamespaceManager
        Get
            If (_oSvgNamespaceManager Is Nothing) Then
                Dim oNt As New System.Xml.NameTable()
                Dim oNsm As New System.Xml.XmlNamespaceManager(oNt)
                oNsm.AddNamespace("dc", "http://purl.org/dc/elements/1.1/")
                oNsm.AddNamespace("cc", "http://creativecommons.org/ns#")
                oNsm.AddNamespace("rdf", "http://www.w3.org/1999/02/22-rdf-syntax-ns#")
                oNsm.AddNamespace(String.Empty, "http://www.w3.org/2000/svg")
                oNsm.AddNamespace("svg", "http://www.w3.org/2000/svg")
                oNsm.AddNamespace("xlink", "http://www.w3.org/1999/xlink")
                oNsm.AddNamespace("sodipodi", "http://sodipodi.sourceforge.net/DTD/sodipodi-0.dtd")
                oNsm.AddNamespace("inkscape", "http://www.inkscape.org/namespaces/inkscape")
                'oNsm.AddNamespace("bp", "http://www.bercpro.be/namespaces/svg/printmerge")
                _oSvgNamespaceManager = oNsm
            End If
            Return _oSvgNamespaceManager
        End Get
    End Property


    Private Function GenerateConStr(ByVal file As String) As String
        'http://social.msdn.microsoft.com/Forums/vstudio/en-US/2af3e1cc-57b5-449c-a651-76200a57f170/import-excel-2010-to-datagridview-vb-2008
        Dim sOut As String
        'sFile = txtDataSource.Text
        If (file.EndsWith(".xls")) Then
            sOut = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & file & _
                    ";Extended Properties=""Excel 8.0;HDR=Yex;IMEX=1;"""
        ElseIf (file.EndsWith(".xlsx")) Then
            sOut = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & file & _
                    ";Extended Properties=""Excel 12.0;HDR=YES;IMEX=1;MAXSCANROWS=15;READONLY=TRUE"""
        Else
            sOut = Nothing
        End If
        Return sOut
    End Function

    Private Function DecodeDirReplacements(ByVal path As String) As String
        If (path.Contains("[app]")) Then
            path = path.Replace("[app]", Application.StartupPath)
        End If
        If (path.Contains("[docs]")) Then
            path = path.Replace("[docs]", Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments))
        End If
        If (path.Contains("[temp]")) Then
            path = path.Replace("[temp]", System.IO.Path.GetTempPath())
        End If
        Return path
    End Function

    Private Function EncodeDirReplacements(ByVal path As String) As String
        If (path.Contains(Application.StartupPath)) Then
            path = path.Replace(Application.StartupPath, "[app]")
        End If
        If (path.Contains(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments))) Then
            path = path.Replace(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "[docs]")
        End If
        If (path.Contains(System.IO.Path.GetTempPath())) Then
            path = path.Replace(System.IO.Path.GetTempPath(), "[temp]")
        End If
        Return path
    End Function


    Private Sub frmEtiketten_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        My.Settings.InputFile = EncodeDirReplacements(txtFileIn.Text)
        My.Settings.XpathCopyElement = txtXpath.Text
        My.Settings.XpathSizeElement = txtXpathSize.Text

        If (radFile.Checked) Then
            My.Settings.DataFile = EncodeDirReplacements(txtDataFile.Text)
            My.Settings.DataSource = ""
        ElseIf (radConStr.Checked) Then
            My.Settings.DataSource = EncodeDirReplacements(txtDataSource.Text)
            My.Settings.DataFile = ""
        Else
            My.Settings.DataFile = ""
            My.Settings.DataSource = ""
        End If
        My.Settings.DataQuery = txtQuery.Text

        My.Settings.OutputFile = EncodeDirReplacements(txtFileOut.Text)

    End Sub

    Private Sub frmEtiketten_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadSettings()
    End Sub

    Private newPropertyValue As String
    Public Property NewProperty() As String
        Get
            Return newPropertyValue
        End Get
        Set(ByVal value As String)
            newPropertyValue = value
        End Set
    End Property

    Private Sub LoadSettings()
        txtFileIn.Text = DecodeDirReplacements(My.Settings.InputFile)
        txtXpath.Text = My.Settings.XpathCopyElement
        txtXpathSize.Text = My.Settings.XpathSizeElement

        If (My.Settings.DataFile <> "") Then
            txtDataFile.Text = DecodeDirReplacements(My.Settings.DataFile)
            txtDataSource.Text = GenerateConStr(txtDataFile.Text)
            radFile.Checked = True
        ElseIf (My.Settings.DataSource <> "") Then
            txtDataFile.Text = ""
            txtDataSource.Text = DecodeDirReplacements(My.Settings.DataSource)
            radConStr.Checked = True
        Else
            txtDataFile.Text = ""
            txtDataSource.Text = ""
            radFile.Checked = False
            radConStr.Checked = False
        End If
        txtQuery.Text = My.Settings.DataQuery

        txtFileOut.Text = DecodeDirReplacements(My.Settings.OutputFile)
    End Sub

    Private Sub btnResetSettings_Click(sender As Object, e As EventArgs) Handles btnResetSettings.Click
        If (MsgBox("Are you sure?", MsgBoxStyle.OkCancel, "Reset user settings") = MsgBoxResult.Ok) Then
            My.Settings.Reset()
        End If
        LoadSettings()
    End Sub
End Class
