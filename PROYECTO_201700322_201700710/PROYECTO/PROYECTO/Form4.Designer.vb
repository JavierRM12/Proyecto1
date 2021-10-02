<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ENOMBRE = New System.Windows.Forms.TextBox()
        Me.EDIRECCION = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ETELEFONO = New System.Windows.Forms.TextBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtid = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(30, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(30, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Dirección"
        '
        'ENOMBRE
        '
        Me.ENOMBRE.Location = New System.Drawing.Point(98, 52)
        Me.ENOMBRE.Name = "ENOMBRE"
        Me.ENOMBRE.Size = New System.Drawing.Size(254, 20)
        Me.ENOMBRE.TabIndex = 2
        '
        'EDIRECCION
        '
        Me.EDIRECCION.Location = New System.Drawing.Point(98, 92)
        Me.EDIRECCION.Name = "EDIRECCION"
        Me.EDIRECCION.Size = New System.Drawing.Size(254, 20)
        Me.EDIRECCION.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(43, 188)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(90, 28)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Agregar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(523, 188)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(98, 28)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Modificar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(632, 188)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(90, 28)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "Eliminar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Button4.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Button4.Location = New System.Drawing.Point(632, 469)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(90, 28)
        Me.Button4.TabIndex = 7
        Me.Button4.Text = "Regresar"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(33, 265)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(659, 150)
        Me.DataGridView1.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(30, 127)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 18)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Telefono"
        '
        'ETELEFONO
        '
        Me.ETELEFONO.Location = New System.Drawing.Point(102, 125)
        Me.ETELEFONO.Name = "ETELEFONO"
        Me.ETELEFONO.Size = New System.Drawing.Size(254, 20)
        Me.ETELEFONO.TabIndex = 10
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(179, 188)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(98, 28)
        Me.Button5.TabIndex = 11
        Me.Button5.Text = "Limpiar"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(494, 54)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(22, 18)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "ID"
        '
        'txtid
        '
        Me.txtid.Location = New System.Drawing.Point(564, 55)
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(128, 20)
        Me.txtid.TabIndex = 13
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(791, 512)
        Me.Controls.Add(Me.txtid)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.ETELEFONO)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.EDIRECCION)
        Me.Controls.Add(Me.ENOMBRE)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form4"
        Me.Text = "Gestionar Editoriales"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ENOMBRE As TextBox
    Friend WithEvents EDIRECCION As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents ETELEFONO As TextBox
    Friend WithEvents Button5 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents txtid As TextBox
End Class
