<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.mainMenu = New System.Windows.Forms.MenuStrip()
        Me.mMFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mMNew = New System.Windows.Forms.ToolStripMenuItem()
        Me.mMOpen = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.mMSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveAsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.PrintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintPreviewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.mMExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mMEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mMUndo = New System.Windows.Forms.ToolStripMenuItem()
        Me.mMRedo = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.mMCut = New System.Windows.Forms.ToolStripMenuItem()
        Me.mMCopy = New System.Windows.Forms.ToolStripMenuItem()
        Me.mMPaste = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.mMSelectAll = New System.Windows.Forms.ToolStripMenuItem()
        Me.mMTools = New System.Windows.Forms.ToolStripMenuItem()
        Me.mMCustomize = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IndexToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Tools = New System.Windows.Forms.ToolStrip()
        Me.tbNew = New System.Windows.Forms.ToolStripButton()
        Me.tbOpen = New System.Windows.Forms.ToolStripButton()
        Me.tbSave = New System.Windows.Forms.ToolStripButton()
        Me.PrintToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.tbCut = New System.Windows.Forms.ToolStripButton()
        Me.tbCopy = New System.Windows.Forms.ToolStripButton()
        Me.tbPaste = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.HelpToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.tbBold = New System.Windows.Forms.ToolStripButton()
        Me.tbItalic = New System.Windows.Forms.ToolStripButton()
        Me.tbUnderline = New System.Windows.Forms.ToolStripButton()
        Me.tbStrike = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.tbAlignLeft = New System.Windows.Forms.ToolStripButton()
        Me.tbAlignCenter = New System.Windows.Forms.ToolStripButton()
        Me.tbAlignRight = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator10 = New System.Windows.Forms.ToolStripSeparator()
        Me.tbUpper = New System.Windows.Forms.ToolStripButton()
        Me.tbLower = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.tbZoom = New System.Windows.Forms.ToolStripButton()
        Me.tbZoomOut = New System.Windows.Forms.ToolStripButton()
        Me.tbSelectFont = New System.Windows.Forms.ToolStripComboBox()
        Me.tbSelectSize = New System.Windows.Forms.ToolStripComboBox()
        Me.Document = New System.Windows.Forms.RichTextBox()
        Me.rcMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.rcUndo = New System.Windows.Forms.ToolStripMenuItem()
        Me.rcRedo = New System.Windows.Forms.ToolStripMenuItem()
        Me.rcCut = New System.Windows.Forms.ToolStripMenuItem()
        Me.rcCopy = New System.Windows.Forms.ToolStripMenuItem()
        Me.rcPaste = New System.Windows.Forms.ToolStripMenuItem()
        Me.Status = New System.Windows.Forms.StatusStrip()
        Me.lblCharCount = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblZoom = New System.Windows.Forms.ToolStripStatusLabel()
        Me.openWork = New System.Windows.Forms.OpenFileDialog()
        Me.saveWork = New System.Windows.Forms.SaveFileDialog()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.mainMenu.SuspendLayout()
        Me.Tools.SuspendLayout()
        Me.rcMenu.SuspendLayout()
        Me.Status.SuspendLayout()
        Me.SuspendLayout()
        '
        'mainMenu
        '
        Me.mainMenu.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.mainMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mMFile, Me.mMEdit, Me.mMTools, Me.HelpToolStripMenuItem})
        Me.mainMenu.Location = New System.Drawing.Point(0, 0)
        Me.mainMenu.Name = "mainMenu"
        Me.mainMenu.Size = New System.Drawing.Size(777, 28)
        Me.mainMenu.TabIndex = 0
        Me.mainMenu.Text = "MenuStrip1"
        '
        'mMFile
        '
        Me.mMFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mMNew, Me.mMOpen, Me.toolStripSeparator, Me.mMSave, Me.SaveAsToolStripMenuItem, Me.toolStripSeparator1, Me.PrintToolStripMenuItem, Me.PrintPreviewToolStripMenuItem, Me.toolStripSeparator2, Me.mMExit})
        Me.mMFile.Name = "mMFile"
        Me.mMFile.Size = New System.Drawing.Size(44, 24)
        Me.mMFile.Text = "&File"
        '
        'mMNew
        '
        Me.mMNew.Image = CType(resources.GetObject("mMNew.Image"), System.Drawing.Image)
        Me.mMNew.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mMNew.Name = "mMNew"
        Me.mMNew.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.mMNew.Size = New System.Drawing.Size(173, 26)
        Me.mMNew.Text = "&New"
        '
        'mMOpen
        '
        Me.mMOpen.Image = CType(resources.GetObject("mMOpen.Image"), System.Drawing.Image)
        Me.mMOpen.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mMOpen.Name = "mMOpen"
        Me.mMOpen.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.mMOpen.Size = New System.Drawing.Size(173, 26)
        Me.mMOpen.Text = "&Open"
        '
        'toolStripSeparator
        '
        Me.toolStripSeparator.Name = "toolStripSeparator"
        Me.toolStripSeparator.Size = New System.Drawing.Size(170, 6)
        '
        'mMSave
        '
        Me.mMSave.Image = CType(resources.GetObject("mMSave.Image"), System.Drawing.Image)
        Me.mMSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mMSave.Name = "mMSave"
        Me.mMSave.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.mMSave.Size = New System.Drawing.Size(173, 26)
        Me.mMSave.Text = "&Save"
        '
        'SaveAsToolStripMenuItem
        '
        Me.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem"
        Me.SaveAsToolStripMenuItem.Size = New System.Drawing.Size(173, 26)
        Me.SaveAsToolStripMenuItem.Text = "Save &As"
        '
        'toolStripSeparator1
        '
        Me.toolStripSeparator1.Name = "toolStripSeparator1"
        Me.toolStripSeparator1.Size = New System.Drawing.Size(170, 6)
        '
        'PrintToolStripMenuItem
        '
        Me.PrintToolStripMenuItem.Image = CType(resources.GetObject("PrintToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PrintToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem"
        Me.PrintToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.PrintToolStripMenuItem.Size = New System.Drawing.Size(173, 26)
        Me.PrintToolStripMenuItem.Text = "&Print"
        '
        'PrintPreviewToolStripMenuItem
        '
        Me.PrintPreviewToolStripMenuItem.Image = CType(resources.GetObject("PrintPreviewToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PrintPreviewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PrintPreviewToolStripMenuItem.Name = "PrintPreviewToolStripMenuItem"
        Me.PrintPreviewToolStripMenuItem.Size = New System.Drawing.Size(173, 26)
        Me.PrintPreviewToolStripMenuItem.Text = "Print Pre&view"
        '
        'toolStripSeparator2
        '
        Me.toolStripSeparator2.Name = "toolStripSeparator2"
        Me.toolStripSeparator2.Size = New System.Drawing.Size(170, 6)
        '
        'mMExit
        '
        Me.mMExit.Name = "mMExit"
        Me.mMExit.Size = New System.Drawing.Size(173, 26)
        Me.mMExit.Text = "E&xit"
        '
        'mMEdit
        '
        Me.mMEdit.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mMUndo, Me.mMRedo, Me.toolStripSeparator3, Me.mMCut, Me.mMCopy, Me.mMPaste, Me.toolStripSeparator4, Me.mMSelectAll})
        Me.mMEdit.Name = "mMEdit"
        Me.mMEdit.Size = New System.Drawing.Size(47, 24)
        Me.mMEdit.Text = "&Edit"
        '
        'mMUndo
        '
        Me.mMUndo.Name = "mMUndo"
        Me.mMUndo.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Z), System.Windows.Forms.Keys)
        Me.mMUndo.Size = New System.Drawing.Size(171, 26)
        Me.mMUndo.Text = "&Undo"
        '
        'mMRedo
        '
        Me.mMRedo.Name = "mMRedo"
        Me.mMRedo.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Y), System.Windows.Forms.Keys)
        Me.mMRedo.Size = New System.Drawing.Size(171, 26)
        Me.mMRedo.Text = "&Redo"
        '
        'toolStripSeparator3
        '
        Me.toolStripSeparator3.Name = "toolStripSeparator3"
        Me.toolStripSeparator3.Size = New System.Drawing.Size(168, 6)
        '
        'mMCut
        '
        Me.mMCut.Image = CType(resources.GetObject("mMCut.Image"), System.Drawing.Image)
        Me.mMCut.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mMCut.Name = "mMCut"
        Me.mMCut.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.mMCut.Size = New System.Drawing.Size(171, 26)
        Me.mMCut.Text = "Cu&t"
        '
        'mMCopy
        '
        Me.mMCopy.Image = CType(resources.GetObject("mMCopy.Image"), System.Drawing.Image)
        Me.mMCopy.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mMCopy.Name = "mMCopy"
        Me.mMCopy.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.mMCopy.Size = New System.Drawing.Size(171, 26)
        Me.mMCopy.Text = "&Copy"
        '
        'mMPaste
        '
        Me.mMPaste.Image = CType(resources.GetObject("mMPaste.Image"), System.Drawing.Image)
        Me.mMPaste.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mMPaste.Name = "mMPaste"
        Me.mMPaste.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.mMPaste.Size = New System.Drawing.Size(171, 26)
        Me.mMPaste.Text = "&Paste"
        '
        'toolStripSeparator4
        '
        Me.toolStripSeparator4.Name = "toolStripSeparator4"
        Me.toolStripSeparator4.Size = New System.Drawing.Size(168, 6)
        '
        'mMSelectAll
        '
        Me.mMSelectAll.Name = "mMSelectAll"
        Me.mMSelectAll.Size = New System.Drawing.Size(171, 26)
        Me.mMSelectAll.Text = "Select &All"
        '
        'mMTools
        '
        Me.mMTools.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mMCustomize, Me.OptionsToolStripMenuItem})
        Me.mMTools.Name = "mMTools"
        Me.mMTools.Size = New System.Drawing.Size(56, 24)
        Me.mMTools.Text = "&Tools"
        '
        'mMCustomize
        '
        Me.mMCustomize.Name = "mMCustomize"
        Me.mMCustomize.Size = New System.Drawing.Size(153, 26)
        Me.mMCustomize.Text = "&Customize"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(153, 26)
        Me.OptionsToolStripMenuItem.Text = "&Options"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ContentsToolStripMenuItem, Me.IndexToolStripMenuItem, Me.SearchToolStripMenuItem, Me.toolStripSeparator5, Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(53, 24)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'ContentsToolStripMenuItem
        '
        Me.ContentsToolStripMenuItem.Name = "ContentsToolStripMenuItem"
        Me.ContentsToolStripMenuItem.Size = New System.Drawing.Size(142, 26)
        Me.ContentsToolStripMenuItem.Text = "&Contents"
        '
        'IndexToolStripMenuItem
        '
        Me.IndexToolStripMenuItem.Name = "IndexToolStripMenuItem"
        Me.IndexToolStripMenuItem.Size = New System.Drawing.Size(142, 26)
        Me.IndexToolStripMenuItem.Text = "&Index"
        '
        'SearchToolStripMenuItem
        '
        Me.SearchToolStripMenuItem.Name = "SearchToolStripMenuItem"
        Me.SearchToolStripMenuItem.Size = New System.Drawing.Size(142, 26)
        Me.SearchToolStripMenuItem.Text = "&Search"
        '
        'toolStripSeparator5
        '
        Me.toolStripSeparator5.Name = "toolStripSeparator5"
        Me.toolStripSeparator5.Size = New System.Drawing.Size(139, 6)
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(142, 26)
        Me.AboutToolStripMenuItem.Text = "&About..."
        '
        'Tools
        '
        Me.Tools.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.Tools.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tbNew, Me.tbOpen, Me.tbSave, Me.PrintToolStripButton, Me.toolStripSeparator6, Me.tbCut, Me.tbCopy, Me.tbPaste, Me.toolStripSeparator7, Me.HelpToolStripButton, Me.tbBold, Me.tbItalic, Me.tbUnderline, Me.tbStrike, Me.ToolStripSeparator8, Me.tbAlignLeft, Me.tbAlignCenter, Me.tbAlignRight, Me.ToolStripSeparator10, Me.tbUpper, Me.tbLower, Me.ToolStripSeparator9, Me.tbZoom, Me.tbZoomOut, Me.tbSelectFont, Me.tbSelectSize})
        Me.Tools.Location = New System.Drawing.Point(0, 28)
        Me.Tools.Name = "Tools"
        Me.Tools.Size = New System.Drawing.Size(777, 28)
        Me.Tools.TabIndex = 1
        Me.Tools.Text = "ToolStrip1"
        '
        'tbNew
        '
        Me.tbNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tbNew.Image = CType(resources.GetObject("tbNew.Image"), System.Drawing.Image)
        Me.tbNew.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbNew.Name = "tbNew"
        Me.tbNew.Size = New System.Drawing.Size(24, 25)
        Me.tbNew.Text = "&New"
        '
        'tbOpen
        '
        Me.tbOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tbOpen.Image = CType(resources.GetObject("tbOpen.Image"), System.Drawing.Image)
        Me.tbOpen.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbOpen.Name = "tbOpen"
        Me.tbOpen.Size = New System.Drawing.Size(24, 25)
        Me.tbOpen.Text = "&Open"
        '
        'tbSave
        '
        Me.tbSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tbSave.Image = CType(resources.GetObject("tbSave.Image"), System.Drawing.Image)
        Me.tbSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbSave.Name = "tbSave"
        Me.tbSave.Size = New System.Drawing.Size(24, 25)
        Me.tbSave.Text = "&Save"
        '
        'PrintToolStripButton
        '
        Me.PrintToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PrintToolStripButton.Image = CType(resources.GetObject("PrintToolStripButton.Image"), System.Drawing.Image)
        Me.PrintToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PrintToolStripButton.Name = "PrintToolStripButton"
        Me.PrintToolStripButton.Size = New System.Drawing.Size(24, 25)
        Me.PrintToolStripButton.Text = "&Print"
        '
        'toolStripSeparator6
        '
        Me.toolStripSeparator6.Name = "toolStripSeparator6"
        Me.toolStripSeparator6.Size = New System.Drawing.Size(6, 28)
        '
        'tbCut
        '
        Me.tbCut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tbCut.Image = CType(resources.GetObject("tbCut.Image"), System.Drawing.Image)
        Me.tbCut.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbCut.Name = "tbCut"
        Me.tbCut.Size = New System.Drawing.Size(24, 25)
        Me.tbCut.Text = "C&ut"
        '
        'tbCopy
        '
        Me.tbCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tbCopy.Image = CType(resources.GetObject("tbCopy.Image"), System.Drawing.Image)
        Me.tbCopy.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbCopy.Name = "tbCopy"
        Me.tbCopy.Size = New System.Drawing.Size(24, 25)
        Me.tbCopy.Text = "&Copy"
        '
        'tbPaste
        '
        Me.tbPaste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tbPaste.Image = CType(resources.GetObject("tbPaste.Image"), System.Drawing.Image)
        Me.tbPaste.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbPaste.Name = "tbPaste"
        Me.tbPaste.Size = New System.Drawing.Size(24, 25)
        Me.tbPaste.Text = "&Paste"
        '
        'toolStripSeparator7
        '
        Me.toolStripSeparator7.Name = "toolStripSeparator7"
        Me.toolStripSeparator7.Size = New System.Drawing.Size(6, 28)
        '
        'HelpToolStripButton
        '
        Me.HelpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.HelpToolStripButton.Image = CType(resources.GetObject("HelpToolStripButton.Image"), System.Drawing.Image)
        Me.HelpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.HelpToolStripButton.Name = "HelpToolStripButton"
        Me.HelpToolStripButton.Size = New System.Drawing.Size(24, 25)
        Me.HelpToolStripButton.Text = "He&lp"
        '
        'tbBold
        '
        Me.tbBold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tbBold.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbBold.Image = CType(resources.GetObject("tbBold.Image"), System.Drawing.Image)
        Me.tbBold.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbBold.Name = "tbBold"
        Me.tbBold.Size = New System.Drawing.Size(23, 25)
        Me.tbBold.Text = "B"
        '
        'tbItalic
        '
        Me.tbItalic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tbItalic.Font = New System.Drawing.Font("Arial", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbItalic.Image = CType(resources.GetObject("tbItalic.Image"), System.Drawing.Image)
        Me.tbItalic.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbItalic.Name = "tbItalic"
        Me.tbItalic.Size = New System.Drawing.Size(23, 25)
        Me.tbItalic.Text = "I"
        '
        'tbUnderline
        '
        Me.tbUnderline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tbUnderline.Font = New System.Drawing.Font("Arial", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbUnderline.Image = CType(resources.GetObject("tbUnderline.Image"), System.Drawing.Image)
        Me.tbUnderline.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbUnderline.Name = "tbUnderline"
        Me.tbUnderline.Size = New System.Drawing.Size(23, 25)
        Me.tbUnderline.Text = "U"
        '
        'tbStrike
        '
        Me.tbStrike.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tbStrike.Font = New System.Drawing.Font("Arial", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Strikeout), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbStrike.Image = CType(resources.GetObject("tbStrike.Image"), System.Drawing.Image)
        Me.tbStrike.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbStrike.Name = "tbStrike"
        Me.tbStrike.Size = New System.Drawing.Size(23, 25)
        Me.tbStrike.Text = "S"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(6, 28)
        '
        'tbAlignLeft
        '
        Me.tbAlignLeft.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tbAlignLeft.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbAlignLeft.Image = CType(resources.GetObject("tbAlignLeft.Image"), System.Drawing.Image)
        Me.tbAlignLeft.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbAlignLeft.Name = "tbAlignLeft"
        Me.tbAlignLeft.Size = New System.Drawing.Size(23, 25)
        Me.tbAlignLeft.Text = "L"
        '
        'tbAlignCenter
        '
        Me.tbAlignCenter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tbAlignCenter.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbAlignCenter.Image = CType(resources.GetObject("tbAlignCenter.Image"), System.Drawing.Image)
        Me.tbAlignCenter.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbAlignCenter.Name = "tbAlignCenter"
        Me.tbAlignCenter.Size = New System.Drawing.Size(23, 25)
        Me.tbAlignCenter.Text = "C"
        '
        'tbAlignRight
        '
        Me.tbAlignRight.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tbAlignRight.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbAlignRight.Image = CType(resources.GetObject("tbAlignRight.Image"), System.Drawing.Image)
        Me.tbAlignRight.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbAlignRight.Name = "tbAlignRight"
        Me.tbAlignRight.Size = New System.Drawing.Size(23, 25)
        Me.tbAlignRight.Text = "R"
        '
        'ToolStripSeparator10
        '
        Me.ToolStripSeparator10.Name = "ToolStripSeparator10"
        Me.ToolStripSeparator10.Size = New System.Drawing.Size(6, 28)
        '
        'tbUpper
        '
        Me.tbUpper.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tbUpper.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbUpper.Image = CType(resources.GetObject("tbUpper.Image"), System.Drawing.Image)
        Me.tbUpper.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbUpper.Name = "tbUpper"
        Me.tbUpper.Size = New System.Drawing.Size(23, 25)
        Me.tbUpper.Text = "A"
        '
        'tbLower
        '
        Me.tbLower.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tbLower.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbLower.Image = CType(resources.GetObject("tbLower.Image"), System.Drawing.Image)
        Me.tbLower.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbLower.Name = "tbLower"
        Me.tbLower.Size = New System.Drawing.Size(23, 25)
        Me.tbLower.Text = "a"
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(6, 28)
        '
        'tbZoom
        '
        Me.tbZoom.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tbZoom.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbZoom.Image = CType(resources.GetObject("tbZoom.Image"), System.Drawing.Image)
        Me.tbZoom.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbZoom.Name = "tbZoom"
        Me.tbZoom.Size = New System.Drawing.Size(23, 25)
        Me.tbZoom.Text = "+"
        '
        'tbZoomOut
        '
        Me.tbZoomOut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tbZoomOut.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbZoomOut.Image = CType(resources.GetObject("tbZoomOut.Image"), System.Drawing.Image)
        Me.tbZoomOut.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbZoomOut.Name = "tbZoomOut"
        Me.tbZoomOut.Size = New System.Drawing.Size(23, 25)
        Me.tbZoomOut.Text = "-"
        '
        'tbSelectFont
        '
        Me.tbSelectFont.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.tbSelectFont.DropDownWidth = 180
        Me.tbSelectFont.FlatStyle = System.Windows.Forms.FlatStyle.Standard
        Me.tbSelectFont.Name = "tbSelectFont"
        Me.tbSelectFont.Size = New System.Drawing.Size(121, 28)
        '
        'tbSelectSize
        '
        Me.tbSelectSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.tbSelectSize.DropDownWidth = 80
        Me.tbSelectSize.FlatStyle = System.Windows.Forms.FlatStyle.Standard
        Me.tbSelectSize.Name = "tbSelectSize"
        Me.tbSelectSize.Size = New System.Drawing.Size(121, 28)
        '
        'Document
        '
        Me.Document.ContextMenuStrip = Me.rcMenu
        Me.Document.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Document.Location = New System.Drawing.Point(0, 56)
        Me.Document.Name = "Document"
        Me.Document.Size = New System.Drawing.Size(777, 386)
        Me.Document.TabIndex = 2
        Me.Document.Text = ""
        '
        'rcMenu
        '
        Me.rcMenu.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.rcMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.rcUndo, Me.rcRedo, Me.rcCut, Me.rcCopy, Me.rcPaste})
        Me.rcMenu.Name = "rcMenu"
        Me.rcMenu.Size = New System.Drawing.Size(115, 124)
        '
        'rcUndo
        '
        Me.rcUndo.Name = "rcUndo"
        Me.rcUndo.Size = New System.Drawing.Size(175, 24)
        Me.rcUndo.Text = "Undo"
        '
        'rcRedo
        '
        Me.rcRedo.Name = "rcRedo"
        Me.rcRedo.Size = New System.Drawing.Size(175, 24)
        Me.rcRedo.Text = "Redo"
        '
        'rcCut
        '
        Me.rcCut.Name = "rcCut"
        Me.rcCut.Size = New System.Drawing.Size(175, 24)
        Me.rcCut.Text = "Cut"
        '
        'rcCopy
        '
        Me.rcCopy.Name = "rcCopy"
        Me.rcCopy.Size = New System.Drawing.Size(175, 24)
        Me.rcCopy.Text = "Copy"
        '
        'rcPaste
        '
        Me.rcPaste.Name = "rcPaste"
        Me.rcPaste.Size = New System.Drawing.Size(175, 24)
        Me.rcPaste.Text = "Paste"
        '
        'Status
        '
        Me.Status.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.Status.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblCharCount, Me.ToolStripStatusLabel2, Me.lblZoom})
        Me.Status.Location = New System.Drawing.Point(0, 417)
        Me.Status.Name = "Status"
        Me.Status.Size = New System.Drawing.Size(777, 25)
        Me.Status.TabIndex = 3
        Me.Status.Text = "StatusStrip1"
        '
        'lblCharCount
        '
        Me.lblCharCount.Name = "lblCharCount"
        Me.lblCharCount.Size = New System.Drawing.Size(17, 20)
        Me.lblCharCount.Text = "0"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(696, 20)
        Me.ToolStripStatusLabel2.Spring = True
        '
        'lblZoom
        '
        Me.lblZoom.Name = "lblZoom"
        Me.lblZoom.Size = New System.Drawing.Size(49, 20)
        Me.lblZoom.Text = "Zoom"
        '
        'openWork
        '
        Me.openWork.Filter = "Text Files |*.txt|RTF Files|*.rtf"
        Me.openWork.Title = "Open Work"
        '
        'saveWork
        '
        Me.saveWork.Filter = "Text Files |*.txt|RTF Files|*.rtf"
        Me.saveWork.Title = "Save Work"
        '
        'Timer
        '
        Me.Timer.Enabled = True
        Me.Timer.Interval = 1
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(777, 442)
        Me.Controls.Add(Me.Status)
        Me.Controls.Add(Me.Document)
        Me.Controls.Add(Me.Tools)
        Me.Controls.Add(Me.mainMenu)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.mainMenu
        Me.MinimumSize = New System.Drawing.Size(795, 489)
        Me.Name = "frmMain"
        Me.Text = "frmMain"
        Me.mainMenu.ResumeLayout(False)
        Me.mainMenu.PerformLayout()
        Me.Tools.ResumeLayout(False)
        Me.Tools.PerformLayout()
        Me.rcMenu.ResumeLayout(False)
        Me.Status.ResumeLayout(False)
        Me.Status.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mainMenu As MenuStrip
    Friend WithEvents mMFile As ToolStripMenuItem
    Friend WithEvents mMNew As ToolStripMenuItem
    Friend WithEvents mMOpen As ToolStripMenuItem
    Friend WithEvents toolStripSeparator As ToolStripSeparator
    Friend WithEvents mMSave As ToolStripMenuItem
    Friend WithEvents SaveAsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents toolStripSeparator1 As ToolStripSeparator
    Friend WithEvents PrintToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PrintPreviewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents toolStripSeparator2 As ToolStripSeparator
    Friend WithEvents mMExit As ToolStripMenuItem
    Friend WithEvents mMEdit As ToolStripMenuItem
    Friend WithEvents mMUndo As ToolStripMenuItem
    Friend WithEvents mMRedo As ToolStripMenuItem
    Friend WithEvents toolStripSeparator3 As ToolStripSeparator
    Friend WithEvents mMCut As ToolStripMenuItem
    Friend WithEvents mMCopy As ToolStripMenuItem
    Friend WithEvents mMPaste As ToolStripMenuItem
    Friend WithEvents toolStripSeparator4 As ToolStripSeparator
    Friend WithEvents mMSelectAll As ToolStripMenuItem
    Friend WithEvents mMTools As ToolStripMenuItem
    Friend WithEvents mMCustomize As ToolStripMenuItem
    Friend WithEvents OptionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContentsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IndexToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SearchToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents toolStripSeparator5 As ToolStripSeparator
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Tools As ToolStrip
    Friend WithEvents tbNew As ToolStripButton
    Friend WithEvents tbOpen As ToolStripButton
    Friend WithEvents tbSave As ToolStripButton
    Friend WithEvents PrintToolStripButton As ToolStripButton
    Friend WithEvents toolStripSeparator6 As ToolStripSeparator
    Friend WithEvents tbCut As ToolStripButton
    Friend WithEvents tbCopy As ToolStripButton
    Friend WithEvents tbPaste As ToolStripButton
    Friend WithEvents toolStripSeparator7 As ToolStripSeparator
    Friend WithEvents HelpToolStripButton As ToolStripButton
    Friend WithEvents tbBold As ToolStripButton
    Friend WithEvents tbItalic As ToolStripButton
    Friend WithEvents tbUnderline As ToolStripButton
    Friend WithEvents tbStrike As ToolStripButton
    Friend WithEvents ToolStripSeparator8 As ToolStripSeparator
    Friend WithEvents tbAlignLeft As ToolStripButton
    Friend WithEvents tbAlignCenter As ToolStripButton
    Friend WithEvents tbAlignRight As ToolStripButton
    Friend WithEvents ToolStripSeparator10 As ToolStripSeparator
    Friend WithEvents tbUpper As ToolStripButton
    Friend WithEvents tbLower As ToolStripButton
    Friend WithEvents ToolStripSeparator9 As ToolStripSeparator
    Friend WithEvents tbZoom As ToolStripButton
    Friend WithEvents tbZoomOut As ToolStripButton
    Friend WithEvents tbSelectFont As ToolStripComboBox
    Friend WithEvents tbSelectSize As ToolStripComboBox
    Friend WithEvents Document As RichTextBox
    Friend WithEvents rcMenu As ContextMenuStrip
    Friend WithEvents rcUndo As ToolStripMenuItem
    Friend WithEvents rcRedo As ToolStripMenuItem
    Friend WithEvents rcCut As ToolStripMenuItem
    Friend WithEvents rcCopy As ToolStripMenuItem
    Friend WithEvents rcPaste As ToolStripMenuItem
    Friend WithEvents Status As StatusStrip
    Friend WithEvents lblCharCount As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As ToolStripStatusLabel
    Friend WithEvents lblZoom As ToolStripStatusLabel
    Friend WithEvents openWork As OpenFileDialog
    Friend WithEvents saveWork As SaveFileDialog
    Friend WithEvents Timer As Timer
End Class
