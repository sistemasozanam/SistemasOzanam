<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormConfigUsuarios
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
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tabContabilidad = New System.Windows.Forms.TabPage()
        Me.CheckBoxX2 = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.CheckBoxX1 = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.tabBancos = New System.Windows.Forms.TabPage()
        Me.CheckBoxX3 = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.CheckBoxX4 = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.btn1 = New DevComponents.DotNetBar.ButtonItem()
        Me.btn2 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem13 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem16 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem19 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem7 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem8 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem9 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem11 = New DevComponents.DotNetBar.ButtonItem()
        Me.TabControl1.SuspendLayout()
        Me.tabContabilidad.SuspendLayout()
        Me.tabBancos.SuspendLayout()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(64, 12)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(176, 21)
        Me.ComboBox1.TabIndex = 19
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 15)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(46, 13)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Usuario:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(246, 13)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(87, 20)
        Me.TextBox1.TabIndex = 20
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tabContabilidad)
        Me.TabControl1.Controls.Add(Me.tabBancos)
        Me.TabControl1.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(12, 48)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1008, 445)
        Me.TabControl1.TabIndex = 21
        '
        'tabContabilidad
        '
        Me.tabContabilidad.Controls.Add(Me.CheckBoxX2)
        Me.tabContabilidad.Controls.Add(Me.CheckBoxX1)
        Me.tabContabilidad.Location = New System.Drawing.Point(4, 25)
        Me.tabContabilidad.Name = "tabContabilidad"
        Me.tabContabilidad.Padding = New System.Windows.Forms.Padding(3)
        Me.tabContabilidad.Size = New System.Drawing.Size(1000, 416)
        Me.tabContabilidad.TabIndex = 0
        Me.tabContabilidad.Text = "Contabilidad"
        Me.tabContabilidad.UseVisualStyleBackColor = True
        '
        'CheckBoxX2
        '
        '
        '
        '
        Me.CheckBoxX2.BackgroundStyle.Class = ""
        Me.CheckBoxX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.CheckBoxX2.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxX2.Location = New System.Drawing.Point(6, 35)
        Me.CheckBoxX2.Name = "CheckBoxX2"
        Me.CheckBoxX2.Size = New System.Drawing.Size(100, 23)
        Me.CheckBoxX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.CheckBoxX2.TabIndex = 1
        Me.CheckBoxX2.Text = "Menu 2"
        Me.CheckBoxX2.TextColor = System.Drawing.Color.Blue
        '
        'CheckBoxX1
        '
        '
        '
        '
        Me.CheckBoxX1.BackgroundStyle.Class = ""
        Me.CheckBoxX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.CheckBoxX1.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxX1.Location = New System.Drawing.Point(6, 6)
        Me.CheckBoxX1.Name = "CheckBoxX1"
        Me.CheckBoxX1.Size = New System.Drawing.Size(100, 23)
        Me.CheckBoxX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.CheckBoxX1.TabIndex = 0
        Me.CheckBoxX1.Text = "Menu 1"
        Me.CheckBoxX1.TextColor = System.Drawing.Color.Blue
        '
        'tabBancos
        '
        Me.tabBancos.Controls.Add(Me.CheckBoxX3)
        Me.tabBancos.Controls.Add(Me.CheckBoxX4)
        Me.tabBancos.Location = New System.Drawing.Point(4, 25)
        Me.tabBancos.Name = "tabBancos"
        Me.tabBancos.Padding = New System.Windows.Forms.Padding(3)
        Me.tabBancos.Size = New System.Drawing.Size(1000, 416)
        Me.tabBancos.TabIndex = 1
        Me.tabBancos.Text = "Bancos"
        Me.tabBancos.UseVisualStyleBackColor = True
        '
        'CheckBoxX3
        '
        '
        '
        '
        Me.CheckBoxX3.BackgroundStyle.Class = ""
        Me.CheckBoxX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.CheckBoxX3.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxX3.Location = New System.Drawing.Point(6, 35)
        Me.CheckBoxX3.Name = "CheckBoxX3"
        Me.CheckBoxX3.Size = New System.Drawing.Size(100, 23)
        Me.CheckBoxX3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.CheckBoxX3.TabIndex = 3
        Me.CheckBoxX3.Text = "Menu 2"
        Me.CheckBoxX3.TextColor = System.Drawing.Color.Red
        '
        'CheckBoxX4
        '
        '
        '
        '
        Me.CheckBoxX4.BackgroundStyle.Class = ""
        Me.CheckBoxX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.CheckBoxX4.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxX4.Location = New System.Drawing.Point(6, 6)
        Me.CheckBoxX4.Name = "CheckBoxX4"
        Me.CheckBoxX4.Size = New System.Drawing.Size(100, 23)
        Me.CheckBoxX4.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.CheckBoxX4.TabIndex = 2
        Me.CheckBoxX4.Text = "Menu 1"
        Me.CheckBoxX4.TextColor = System.Drawing.Color.Red
        '
        'btn1
        '
        Me.btn1.Name = "btn1"
        Me.btn1.Text = "btn1"
        '
        'btn2
        '
        Me.btn2.Name = "btn2"
        Me.btn2.Text = "btn2"
        '
        'ButtonItem13
        '
        Me.ButtonItem13.Name = "ButtonItem13"
        Me.ButtonItem13.Text = "ButtonItem13"
        '
        'ButtonItem16
        '
        Me.ButtonItem16.Name = "ButtonItem16"
        Me.ButtonItem16.Text = "ButtonItem16"
        '
        'ButtonItem19
        '
        Me.ButtonItem19.Name = "ButtonItem19"
        Me.ButtonItem19.Text = "ButtonItem16"
        '
        'ButtonItem7
        '
        Me.ButtonItem7.Name = "ButtonItem7"
        Me.ButtonItem7.Text = "btn1"
        '
        'ButtonItem8
        '
        Me.ButtonItem8.Name = "ButtonItem8"
        Me.ButtonItem8.Text = "ButtonItem13"
        '
        'ButtonItem9
        '
        Me.ButtonItem9.Name = "ButtonItem9"
        Me.ButtonItem9.Text = "ButtonItem16"
        '
        'ButtonItem11
        '
        Me.ButtonItem11.Name = "ButtonItem11"
        Me.ButtonItem11.Text = "ButtonItem16"
        '
        'FormConfigUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1032, 505)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label9)
        Me.Name = "FormConfigUsuarios"
        Me.Text = "FormConfigUsuarios"
        Me.TabControl1.ResumeLayout(False)
        Me.tabContabilidad.ResumeLayout(False)
        Me.tabBancos.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tabContabilidad As TabPage
    Friend WithEvents tabBancos As TabPage
    Friend WithEvents btn1 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btn2 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem13 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem16 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem19 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem7 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem8 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem9 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem11 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents CheckBoxX1 As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents CheckBoxX2 As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents CheckBoxX3 As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents CheckBoxX4 As DevComponents.DotNetBar.Controls.CheckBoxX
End Class
