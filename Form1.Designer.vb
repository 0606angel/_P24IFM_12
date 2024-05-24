<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btn_month_and_ransomware = New System.Windows.Forms.Button()
        Me.grd_ransomware = New UJGrid.UJGrid()
        Me.btn_month_and_incidents = New System.Windows.Forms.Button()
        Me.btn_register_ransomware_info = New System.Windows.Forms.Button()
        Me.btn_calc_total = New System.Windows.Forms.Button()
        Me.btn_calc_average = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btn_month_and_ransomware
        '
        Me.btn_month_and_ransomware.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_month_and_ransomware.Location = New System.Drawing.Point(13, 13)
        Me.btn_month_and_ransomware.Name = "btn_month_and_ransomware"
        Me.btn_month_and_ransomware.Size = New System.Drawing.Size(278, 48)
        Me.btn_month_and_ransomware.TabIndex = 0
        Me.btn_month_and_ransomware.Text = "set grid"
        Me.btn_month_and_ransomware.UseVisualStyleBackColor = True
        '
        'grd_ransomware
        '
        Me.grd_ransomware.FixedCols = 1
        Me.grd_ransomware.FixedRows = 1
        Me.grd_ransomware.Location = New System.Drawing.Point(298, 13)
        Me.grd_ransomware.Margin = New System.Windows.Forms.Padding(4)
        Me.grd_ransomware.Name = "grd_ransomware"
        Me.grd_ransomware.Scrollbars = System.Windows.Forms.ScrollBars.Both
        Me.grd_ransomware.Size = New System.Drawing.Size(980, 405)
        Me.grd_ransomware.TabIndex = 1
        '
        'btn_month_and_incidents
        '
        Me.btn_month_and_incidents.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_month_and_incidents.Location = New System.Drawing.Point(12, 67)
        Me.btn_month_and_incidents.Name = "btn_month_and_incidents"
        Me.btn_month_and_incidents.Size = New System.Drawing.Size(278, 64)
        Me.btn_month_and_incidents.TabIndex = 2
        Me.btn_month_and_incidents.Text = "Register months and incidents"
        Me.btn_month_and_incidents.UseVisualStyleBackColor = True
        '
        'btn_register_ransomware_info
        '
        Me.btn_register_ransomware_info.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_register_ransomware_info.Location = New System.Drawing.Point(12, 137)
        Me.btn_register_ransomware_info.Name = "btn_register_ransomware_info"
        Me.btn_register_ransomware_info.Size = New System.Drawing.Size(278, 45)
        Me.btn_register_ransomware_info.TabIndex = 3
        Me.btn_register_ransomware_info.Text = "register ransomware infomation"
        Me.btn_register_ransomware_info.UseVisualStyleBackColor = True
        '
        'btn_calc_total
        '
        Me.btn_calc_total.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_calc_total.Location = New System.Drawing.Point(13, 188)
        Me.btn_calc_total.Name = "btn_calc_total"
        Me.btn_calc_total.Size = New System.Drawing.Size(278, 51)
        Me.btn_calc_total.TabIndex = 4
        Me.btn_calc_total.Text = "calculate total "
        Me.btn_calc_total.UseVisualStyleBackColor = True
        '
        'btn_calc_average
        '
        Me.btn_calc_average.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_calc_average.Location = New System.Drawing.Point(13, 246)
        Me.btn_calc_average.Name = "btn_calc_average"
        Me.btn_calc_average.Size = New System.Drawing.Size(278, 49)
        Me.btn_calc_average.TabIndex = 5
        Me.btn_calc_average.Text = "Calculate Average"
        Me.btn_calc_average.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1320, 611)
        Me.Controls.Add(Me.btn_calc_average)
        Me.Controls.Add(Me.btn_calc_total)
        Me.Controls.Add(Me.btn_register_ransomware_info)
        Me.Controls.Add(Me.btn_month_and_incidents)
        Me.Controls.Add(Me.grd_ransomware)
        Me.Controls.Add(Me.btn_month_and_ransomware)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_month_and_ransomware As Button
    Friend WithEvents grd_ransomware As UJGrid.UJGrid
    Friend WithEvents btn_month_and_incidents As Button
    Friend WithEvents btn_register_ransomware_info As Button
    Friend WithEvents btn_calc_total As Button
    Friend WithEvents btn_calc_average As Button
End Class
