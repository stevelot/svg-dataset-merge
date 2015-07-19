<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEtiketten
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEtiketten))
        Me.txtFileIn = New System.Windows.Forms.TextBox()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtXpath = New System.Windows.Forms.TextBox()
        Me.txtDataSource = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtQuery = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtFileOut = New System.Windows.Forms.TextBox()
        Me.btnFileIn = New System.Windows.Forms.Button()
        Me.btnFileOut = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.btnConStr = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.numY = New System.Windows.Forms.NumericUpDown()
        Me.numX = New System.Windows.Forms.NumericUpDown()
        Me.txtXpathSize = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.radConStr = New System.Windows.Forms.RadioButton()
        Me.radFile = New System.Windows.Forms.RadioButton()
        Me.txtDataFile = New System.Windows.Forms.TextBox()
        Me.lblRowCount = New System.Windows.Forms.Label()
        Me.btnTestQuery = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnCalculateCopies = New System.Windows.Forms.Button()
        Me.lnkOutputFile = New System.Windows.Forms.LinkLabel()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnResetSettings = New System.Windows.Forms.Button()
        CType(Me.numY, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numX, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtFileIn
        '
        Me.txtFileIn.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFileIn.Location = New System.Drawing.Point(91, 19)
        Me.txtFileIn.Name = "txtFileIn"
        Me.txtFileIn.Size = New System.Drawing.Size(634, 20)
        Me.txtFileIn.TabIndex = 0
        Me.txtFileIn.Text = "C:\Users\STEES\Dropbox\Baby & Trouw\Baby kaartjes etiketten\etiket_in01.svg"
        '
        'btnStart
        '
        Me.btnStart.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnStart.Enabled = False
        Me.btnStart.Location = New System.Drawing.Point(699, 386)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(75, 23)
        Me.btnStart.TabIndex = 16
        Me.btnStart.Text = "Generate"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Source"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "xPath element"
        '
        'txtXpath
        '
        Me.txtXpath.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtXpath.Location = New System.Drawing.Point(91, 45)
        Me.txtXpath.Name = "txtXpath"
        Me.txtXpath.Size = New System.Drawing.Size(634, 20)
        Me.txtXpath.TabIndex = 2
        Me.txtXpath.Text = "//*[@id='copy']"
        '
        'txtDataSource
        '
        Me.txtDataSource.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDataSource.Location = New System.Drawing.Point(91, 45)
        Me.txtDataSource.Name = "txtDataSource"
        Me.txtDataSource.Size = New System.Drawing.Size(634, 20)
        Me.txtDataSource.TabIndex = 8
        Me.txtDataSource.Text = "C:\temp\test.xlsx"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 74)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Query"
        '
        'txtQuery
        '
        Me.txtQuery.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtQuery.Location = New System.Drawing.Point(91, 71)
        Me.txtQuery.Name = "txtQuery"
        Me.txtQuery.Size = New System.Drawing.Size(634, 20)
        Me.txtQuery.TabIndex = 9
        Me.txtQuery.Text = "Select * from [Blad1$A1:D110]"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Output file"
        '
        'txtFileOut
        '
        Me.txtFileOut.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFileOut.Location = New System.Drawing.Point(91, 19)
        Me.txtFileOut.Name = "txtFileOut"
        Me.txtFileOut.Size = New System.Drawing.Size(634, 20)
        Me.txtFileOut.TabIndex = 11
        Me.txtFileOut.Text = "C:\temp\out_01.svg"
        '
        'btnFileIn
        '
        Me.btnFileIn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFileIn.Location = New System.Drawing.Point(731, 17)
        Me.btnFileIn.Name = "btnFileIn"
        Me.btnFileIn.Size = New System.Drawing.Size(25, 22)
        Me.btnFileIn.TabIndex = 1
        Me.btnFileIn.Text = "..."
        Me.btnFileIn.UseVisualStyleBackColor = True
        '
        'btnFileOut
        '
        Me.btnFileOut.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFileOut.Location = New System.Drawing.Point(731, 17)
        Me.btnFileOut.Name = "btnFileOut"
        Me.btnFileOut.Size = New System.Drawing.Size(25, 22)
        Me.btnFileOut.TabIndex = 12
        Me.btnFileOut.Text = "..."
        Me.btnFileOut.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'btnConStr
        '
        Me.btnConStr.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnConStr.Location = New System.Drawing.Point(731, 17)
        Me.btnConStr.Name = "btnConStr"
        Me.btnConStr.Size = New System.Drawing.Size(25, 22)
        Me.btnConStr.TabIndex = 6
        Me.btnConStr.Text = "..."
        Me.btnConStr.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 47)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Copies (X * Y)"
        '
        'numY
        '
        Me.numY.Location = New System.Drawing.Point(136, 45)
        Me.numY.Name = "numY"
        Me.numY.Size = New System.Drawing.Size(39, 20)
        Me.numY.TabIndex = 14
        Me.numY.Value = New Decimal(New Integer() {7, 0, 0, 0})
        '
        'numX
        '
        Me.numX.Location = New System.Drawing.Point(91, 45)
        Me.numX.Name = "numX"
        Me.numX.Size = New System.Drawing.Size(39, 20)
        Me.numX.TabIndex = 13
        Me.numX.Value = New Decimal(New Integer() {16, 0, 0, 0})
        '
        'txtXpathSize
        '
        Me.txtXpathSize.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtXpathSize.Location = New System.Drawing.Point(91, 71)
        Me.txtXpathSize.Name = "txtXpathSize"
        Me.txtXpathSize.Size = New System.Drawing.Size(634, 20)
        Me.txtXpathSize.TabIndex = 3
        Me.txtXpathSize.Text = "//*[@id='size']"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 74)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 13)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "size element"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 356)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(216, 53)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 20
        Me.PictureBox1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtFileIn)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtXpathSize)
        Me.GroupBox1.Controls.Add(Me.txtXpath)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.btnFileIn)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(762, 106)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Input file && settings"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.radConStr)
        Me.GroupBox2.Controls.Add(Me.radFile)
        Me.GroupBox2.Controls.Add(Me.txtDataFile)
        Me.GroupBox2.Controls.Add(Me.lblRowCount)
        Me.GroupBox2.Controls.Add(Me.btnTestQuery)
        Me.GroupBox2.Controls.Add(Me.txtDataSource)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtQuery)
        Me.GroupBox2.Controls.Add(Me.btnConStr)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 124)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(762, 133)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Input data"
        '
        'radConStr
        '
        Me.radConStr.AutoSize = True
        Me.radConStr.Location = New System.Drawing.Point(9, 46)
        Me.radConStr.Name = "radConStr"
        Me.radConStr.Size = New System.Drawing.Size(63, 17)
        Me.radConStr.TabIndex = 7
        Me.radConStr.Text = "Con.Str."
        Me.radConStr.UseVisualStyleBackColor = True
        '
        'radFile
        '
        Me.radFile.AutoSize = True
        Me.radFile.Checked = True
        Me.radFile.Location = New System.Drawing.Point(9, 20)
        Me.radFile.Name = "radFile"
        Me.radFile.Size = New System.Drawing.Size(41, 17)
        Me.radFile.TabIndex = 4
        Me.radFile.TabStop = True
        Me.radFile.Text = "File"
        Me.radFile.UseVisualStyleBackColor = True
        '
        'txtDataFile
        '
        Me.txtDataFile.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDataFile.Location = New System.Drawing.Point(91, 19)
        Me.txtDataFile.Name = "txtDataFile"
        Me.txtDataFile.Size = New System.Drawing.Size(634, 20)
        Me.txtDataFile.TabIndex = 5
        Me.txtDataFile.Text = "C:\temp\test.xlsx"
        '
        'lblRowCount
        '
        Me.lblRowCount.AutoSize = True
        Me.lblRowCount.Location = New System.Drawing.Point(88, 102)
        Me.lblRowCount.Name = "lblRowCount"
        Me.lblRowCount.Size = New System.Drawing.Size(79, 13)
        Me.lblRowCount.TabIndex = 15
        Me.lblRowCount.Text = "Rows found: ..."
        '
        'btnTestQuery
        '
        Me.btnTestQuery.Enabled = False
        Me.btnTestQuery.Location = New System.Drawing.Point(209, 97)
        Me.btnTestQuery.Name = "btnTestQuery"
        Me.btnTestQuery.Size = New System.Drawing.Size(50, 23)
        Me.btnTestQuery.TabIndex = 10
        Me.btnTestQuery.Text = "test"
        Me.btnTestQuery.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.btnCalculateCopies)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.txtFileOut)
        Me.GroupBox3.Controls.Add(Me.btnFileOut)
        Me.GroupBox3.Controls.Add(Me.numX)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.numY)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 263)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(762, 82)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Output file & settings"
        '
        'btnCalculateCopies
        '
        Me.btnCalculateCopies.Enabled = False
        Me.btnCalculateCopies.Location = New System.Drawing.Point(181, 42)
        Me.btnCalculateCopies.Name = "btnCalculateCopies"
        Me.btnCalculateCopies.Size = New System.Drawing.Size(116, 23)
        Me.btnCalculateCopies.TabIndex = 15
        Me.btnCalculateCopies.Text = "Calculate max. grid"
        Me.btnCalculateCopies.UseVisualStyleBackColor = True
        '
        'lnkOutputFile
        '
        Me.lnkOutputFile.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lnkOutputFile.AutoSize = True
        Me.lnkOutputFile.Location = New System.Drawing.Point(234, 356)
        Me.lnkOutputFile.Name = "lnkOutputFile"
        Me.lnkOutputFile.Size = New System.Drawing.Size(116, 13)
        Me.lnkOutputFile.TabIndex = 17
        Me.lnkOutputFile.TabStop = True
        Me.lnkOutputFile.Text = "http://www.bercpro.be"
        Me.ToolTip1.SetToolTip(Me.lnkOutputFile, "Large format printing company, located in Halle (near Brussels) in Belgium.")
        '
        'btnResetSettings
        '
        Me.btnResetSettings.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnResetSettings.Location = New System.Drawing.Point(237, 386)
        Me.btnResetSettings.Name = "btnResetSettings"
        Me.btnResetSettings.Size = New System.Drawing.Size(95, 23)
        Me.btnResetSettings.TabIndex = 22
        Me.btnResetSettings.Text = "Reset settings"
        Me.btnResetSettings.UseVisualStyleBackColor = True
        '
        'frmEtiketten
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(786, 421)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lnkOutputFile)
        Me.Controls.Add(Me.btnResetSettings)
        Me.Name = "frmEtiketten"
        Me.Text = "Bercpro - Svg label merge"
        CType(Me.numY, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numX, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtFileIn As System.Windows.Forms.TextBox
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtXpath As System.Windows.Forms.TextBox
    Friend WithEvents txtDataSource As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtQuery As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtFileOut As System.Windows.Forms.TextBox
    Friend WithEvents btnFileIn As System.Windows.Forms.Button
    Friend WithEvents btnFileOut As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents btnConStr As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents numY As System.Windows.Forms.NumericUpDown
    Friend WithEvents numX As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtXpathSize As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btnCalculateCopies As System.Windows.Forms.Button
    Friend WithEvents btnTestQuery As System.Windows.Forms.Button
    Friend WithEvents lblRowCount As System.Windows.Forms.Label
    Friend WithEvents lnkOutputFile As System.Windows.Forms.LinkLabel
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents radConStr As System.Windows.Forms.RadioButton
    Friend WithEvents radFile As System.Windows.Forms.RadioButton
    Friend WithEvents txtDataFile As System.Windows.Forms.TextBox
    Friend WithEvents btnResetSettings As System.Windows.Forms.Button

End Class
