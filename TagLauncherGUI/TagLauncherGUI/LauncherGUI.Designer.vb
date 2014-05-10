<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LauncherGUI
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
        Me.CloseBTN = New System.Windows.Forms.Button()
        Me.MinimizeBTN = New System.Windows.Forms.Button()
        Me.OptionsBTN = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'CloseBTN
        '
        Me.CloseBTN.BackColor = System.Drawing.Color.Transparent
        Me.CloseBTN.BackgroundImage = Global.TagLauncherGUI.My.Resources.Resources.ToolBarClose
        Me.CloseBTN.FlatAppearance.BorderSize = 0
        Me.CloseBTN.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.CloseBTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.CloseBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.CloseBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CloseBTN.Location = New System.Drawing.Point(577, 1)
        Me.CloseBTN.Name = "CloseBTN"
        Me.CloseBTN.Size = New System.Drawing.Size(19, 19)
        Me.CloseBTN.TabIndex = 0
        Me.CloseBTN.UseVisualStyleBackColor = False
        '
        'MinimizeBTN
        '
        Me.MinimizeBTN.BackColor = System.Drawing.Color.Transparent
        Me.MinimizeBTN.BackgroundImage = Global.TagLauncherGUI.My.Resources.Resources.ToolBarMinimize
        Me.MinimizeBTN.FlatAppearance.BorderSize = 0
        Me.MinimizeBTN.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.MinimizeBTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.MinimizeBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.MinimizeBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MinimizeBTN.Location = New System.Drawing.Point(556, 1)
        Me.MinimizeBTN.Name = "MinimizeBTN"
        Me.MinimizeBTN.Size = New System.Drawing.Size(19, 19)
        Me.MinimizeBTN.TabIndex = 1
        Me.MinimizeBTN.UseVisualStyleBackColor = False
        '
        'OptionsBTN
        '
        Me.OptionsBTN.BackColor = System.Drawing.Color.Transparent
        Me.OptionsBTN.BackgroundImage = Global.TagLauncherGUI.My.Resources.Resources.ToolBarOptions
        Me.OptionsBTN.FlatAppearance.BorderSize = 0
        Me.OptionsBTN.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.OptionsBTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.OptionsBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.OptionsBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OptionsBTN.Location = New System.Drawing.Point(535, 1)
        Me.OptionsBTN.Name = "OptionsBTN"
        Me.OptionsBTN.Size = New System.Drawing.Size(19, 19)
        Me.OptionsBTN.TabIndex = 2
        Me.OptionsBTN.UseVisualStyleBackColor = False
        '
        'LauncherGUI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImage = Global.TagLauncherGUI.My.Resources.Resources.GUI_Theme_0
        Me.ClientSize = New System.Drawing.Size(599, 449)
        Me.Controls.Add(Me.OptionsBTN)
        Me.Controls.Add(Me.MinimizeBTN)
        Me.Controls.Add(Me.CloseBTN)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.Name = "LauncherGUI"
        Me.Text = "Minecraft Launcher"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CloseBTN As System.Windows.Forms.Button
    Friend WithEvents MinimizeBTN As System.Windows.Forms.Button
    Friend WithEvents OptionsBTN As System.Windows.Forms.Button

End Class
