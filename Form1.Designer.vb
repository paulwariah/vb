<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTempConverter
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
        Me.IBLHeader = New System.Windows.Forms.Label()
        Me.txtFarenheit = New System.Windows.Forms.TextBox()
        Me.txtCelsius = New System.Windows.Forms.TextBox()
        Me.IblFarenheit = New System.Windows.Forms.Label()
        Me.IblCelsius = New System.Windows.Forms.Label()
        Me.hsbScroller = New System.Windows.Forms.HScrollBar()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'IBLHeader
        '
        Me.IBLHeader.AutoSize = True
        Me.IBLHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IBLHeader.Location = New System.Drawing.Point(41, 33)
        Me.IBLHeader.Name = "IBLHeader"
        Me.IBLHeader.Size = New System.Drawing.Size(339, 33)
        Me.IBLHeader.TabIndex = 0
        Me.IBLHeader.Text = "Temperature Converter"
        '
        'txtFarenheit
        '
        Me.txtFarenheit.BackColor = System.Drawing.Color.White
        Me.txtFarenheit.Location = New System.Drawing.Point(47, 89)
        Me.txtFarenheit.Name = "txtFarenheit"
        Me.txtFarenheit.ReadOnly = True
        Me.txtFarenheit.Size = New System.Drawing.Size(100, 20)
        Me.txtFarenheit.TabIndex = 1
        Me.txtFarenheit.Text = "32.0"
        Me.txtFarenheit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCelsius
        '
        Me.txtCelsius.BackColor = System.Drawing.Color.White
        Me.txtCelsius.Location = New System.Drawing.Point(254, 89)
        Me.txtCelsius.Name = "txtCelsius"
        Me.txtCelsius.ReadOnly = True
        Me.txtCelsius.Size = New System.Drawing.Size(100, 20)
        Me.txtCelsius.TabIndex = 2
        Me.txtCelsius.Text = "0"
        Me.txtCelsius.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'IblFarenheit
        '
        Me.IblFarenheit.AutoSize = True
        Me.IblFarenheit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IblFarenheit.Location = New System.Drawing.Point(53, 147)
        Me.IblFarenheit.Name = "IblFarenheit"
        Me.IblFarenheit.Size = New System.Drawing.Size(96, 20)
        Me.IblFarenheit.TabIndex = 3
        Me.IblFarenheit.Text = "Fahrenheit"
        '
        'IblCelsius
        '
        Me.IblCelsius.AutoSize = True
        Me.IblCelsius.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IblCelsius.Location = New System.Drawing.Point(258, 138)
        Me.IblCelsius.Name = "IblCelsius"
        Me.IblCelsius.Size = New System.Drawing.Size(64, 20)
        Me.IblCelsius.TabIndex = 4
        Me.IblCelsius.Text = "celsius"
        '
        'hsbScroller
        '
        Me.hsbScroller.Location = New System.Drawing.Point(41, 201)
        Me.hsbScroller.Maximum = 300
        Me.hsbScroller.Minimum = -100
        Me.hsbScroller.Name = "hsbScroller"
        Me.hsbScroller.Size = New System.Drawing.Size(313, 28)
        Me.hsbScroller.TabIndex = 5
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(262, 270)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(92, 31)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmTempConverter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.hsbScroller)
        Me.Controls.Add(Me.IblCelsius)
        Me.Controls.Add(Me.IblFarenheit)
        Me.Controls.Add(Me.txtCelsius)
        Me.Controls.Add(Me.txtFarenheit)
        Me.Controls.Add(Me.IBLHeader)
        Me.Name = "frmTempConverter"
        Me.Text = "Temperature Converter"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents IBLHeader As Label
    Friend WithEvents txtFarenheit As TextBox
    Friend WithEvents txtCelsius As TextBox
    Friend WithEvents IblFarenheit As Label
    Friend WithEvents IblCelsius As Label
    Friend WithEvents hsbScroller As HScrollBar
    Friend WithEvents btnExit As Button
End Class
