<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class laporan
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Dgtampil = New System.Windows.Forms.DataGridView()
        Me.tgl_mulai = New System.Windows.Forms.DateTimePicker()
        Me.tgl_sampai = New System.Windows.Forms.DateTimePicker()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.Dgtampil, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(151, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Sampai Tanggal"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(151, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mulai Tanggal"
        '
        'Dgtampil
        '
        Me.Dgtampil.AllowUserToAddRows = False
        Me.Dgtampil.AllowUserToDeleteRows = False
        Me.Dgtampil.AllowUserToResizeColumns = False
        Me.Dgtampil.AllowUserToResizeRows = False
        Me.Dgtampil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgtampil.Location = New System.Drawing.Point(29, 108)
        Me.Dgtampil.Name = "Dgtampil"
        Me.Dgtampil.Size = New System.Drawing.Size(780, 283)
        Me.Dgtampil.TabIndex = 1
        '
        'tgl_mulai
        '
        Me.tgl_mulai.Location = New System.Drawing.Point(144, 34)
        Me.tgl_mulai.Name = "tgl_mulai"
        Me.tgl_mulai.Size = New System.Drawing.Size(200, 20)
        Me.tgl_mulai.TabIndex = 3
        '
        'tgl_sampai
        '
        Me.tgl_sampai.Location = New System.Drawing.Point(144, 82)
        Me.tgl_sampai.Name = "tgl_sampai"
        Me.tgl_sampai.Size = New System.Drawing.Size(200, 20)
        Me.tgl_sampai.TabIndex = 4
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(495, 56)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Tampil"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.Control
        Me.Button2.Location = New System.Drawing.Point(599, 56)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Cetak"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'laporan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(836, 450)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.tgl_sampai)
        Me.Controls.Add(Me.tgl_mulai)
        Me.Controls.Add(Me.Dgtampil)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Name = "laporan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "laporan"
        CType(Me.Dgtampil, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Dgtampil As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents tgl_mulai As DateTimePicker
    Friend WithEvents tgl_sampai As DateTimePicker
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class