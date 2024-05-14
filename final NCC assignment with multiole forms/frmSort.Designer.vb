<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSort
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.btnSort = New System.Windows.Forms.Button()
        Me.btnMain = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(199, 173)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(253, 35)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Click me to insertion sort"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 16
        Me.ListBox1.Location = New System.Drawing.Point(539, 53)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(189, 292)
        Me.ListBox1.TabIndex = 4
        '
        'btnSort
        '
        Me.btnSort.Location = New System.Drawing.Point(193, 89)
        Me.btnSort.Name = "btnSort"
        Me.btnSort.Size = New System.Drawing.Size(259, 40)
        Me.btnSort.TabIndex = 3
        Me.btnSort.Text = "click me to bubble sort"
        Me.btnSort.UseVisualStyleBackColor = True
        '
        'btnMain
        '
        Me.btnMain.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.btnMain.Font = New System.Drawing.Font("Microsoft YaHei", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMain.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnMain.Location = New System.Drawing.Point(199, 315)
        Me.btnMain.Name = "btnMain"
        Me.btnMain.Size = New System.Drawing.Size(210, 58)
        Me.btnMain.TabIndex = 6
        Me.btnMain.Text = "Main Menu"
        Me.btnMain.UseVisualStyleBackColor = False
        '
        'frmSort
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnMain)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.btnSort)
        Me.Name = "frmSort"
        Me.Text = "frmSort"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents btnSort As Button
    Friend WithEvents btnMain As Button
End Class
