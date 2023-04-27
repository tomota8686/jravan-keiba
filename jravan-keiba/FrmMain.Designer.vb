<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMain
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMain))
        Me.AxJVLink1 = New AxJVDTLabLib.AxJVLink()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.menuConfig = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuConfJV = New System.Windows.Forms.ToolStripMenuItem()
        Me.LblTitle = New System.Windows.Forms.Label()
        Me.TabMain = New System.Windows.Forms.TabControl()
        Me.TabTop = New System.Windows.Forms.TabPage()
        Me.TabRace = New System.Windows.Forms.TabPage()
        CType(Me.AxJVLink1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.TabMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'AxJVLink1
        '
        Me.AxJVLink1.Enabled = True
        Me.AxJVLink1.Location = New System.Drawing.Point(878, 484)
        Me.AxJVLink1.Name = "AxJVLink1"
        Me.AxJVLink1.OcxState = CType(resources.GetObject("AxJVLink1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxJVLink1.Size = New System.Drawing.Size(80, 51)
        Me.AxJVLink1.TabIndex = 0
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuConfig})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(970, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'menuConfig
        '
        Me.menuConfig.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuConfJV})
        Me.menuConfig.Name = "menuConfig"
        Me.menuConfig.Size = New System.Drawing.Size(58, 20)
        Me.menuConfig.Text = "設定(&C)"
        '
        'menuConfJV
        '
        Me.menuConfJV.Name = "menuConfJV"
        Me.menuConfJV.Size = New System.Drawing.Size(180, 22)
        Me.menuConfJV.Text = "JV-Linkの設定(&J)"
        '
        'LblTitle
        '
        Me.LblTitle.AutoSize = True
        Me.LblTitle.Font = New System.Drawing.Font("MS UI Gothic", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.LblTitle.Location = New System.Drawing.Point(12, 24)
        Me.LblTitle.Name = "LblTitle"
        Me.LblTitle.Size = New System.Drawing.Size(261, 29)
        Me.LblTitle.TabIndex = 2
        Me.LblTitle.Text = "おかえりにゃ競馬情報"
        '
        'TabMain
        '
        Me.TabMain.Controls.Add(Me.TabTop)
        Me.TabMain.Controls.Add(Me.TabRace)
        Me.TabMain.Location = New System.Drawing.Point(12, 56)
        Me.TabMain.Name = "TabMain"
        Me.TabMain.SelectedIndex = 0
        Me.TabMain.Size = New System.Drawing.Size(946, 479)
        Me.TabMain.TabIndex = 3
        '
        'TabTop
        '
        Me.TabTop.Location = New System.Drawing.Point(4, 22)
        Me.TabTop.Name = "TabTop"
        Me.TabTop.Padding = New System.Windows.Forms.Padding(3)
        Me.TabTop.Size = New System.Drawing.Size(938, 453)
        Me.TabTop.TabIndex = 0
        Me.TabTop.Text = "トップ"
        Me.TabTop.UseVisualStyleBackColor = True
        '
        'TabRace
        '
        Me.TabRace.Location = New System.Drawing.Point(4, 22)
        Me.TabRace.Name = "TabRace"
        Me.TabRace.Padding = New System.Windows.Forms.Padding(3)
        Me.TabRace.Size = New System.Drawing.Size(938, 453)
        Me.TabRace.TabIndex = 1
        Me.TabRace.Text = "レース"
        Me.TabRace.UseVisualStyleBackColor = True
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(970, 547)
        Me.Controls.Add(Me.TabMain)
        Me.Controls.Add(Me.LblTitle)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.AxJVLink1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FrmMain"
        Me.Text = "メインメニュー"
        CType(Me.AxJVLink1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.TabMain.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AxJVLink1 As AxJVDTLabLib.AxJVLink
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents menuConfig As ToolStripMenuItem
    Friend WithEvents menuConfJV As ToolStripMenuItem
    Friend WithEvents LblTitle As Label
    Friend WithEvents TabMain As TabControl
    Friend WithEvents TabTop As TabPage
    Friend WithEvents TabRace As TabPage
End Class
