<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.singleRight = New System.Windows.Forms.Button()
        Me.singleLeft = New System.Windows.Forms.Button()
        Me.allRight = New System.Windows.Forms.Button()
        Me.allLeft = New System.Windows.Forms.Button()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProvider2 = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.AllowDrop = True
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Items.AddRange(New Object() {"aa", "bb", "cc", "dd", "ee", "ff"})
        Me.ListBox1.Location = New System.Drawing.Point(29, 72)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.ListBox1.Size = New System.Drawing.Size(78, 108)
        Me.ListBox1.TabIndex = 0
        '
        'ListBox2
        '
        Me.ListBox2.AllowDrop = True
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Items.AddRange(New Object() {"11", "22", "33", "44", "55", "66"})
        Me.ListBox2.Location = New System.Drawing.Point(194, 72)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.ListBox2.Size = New System.Drawing.Size(78, 108)
        Me.ListBox2.TabIndex = 0
        '
        'singleRight
        '
        Me.singleRight.Location = New System.Drawing.Point(113, 72)
        Me.singleRight.Name = "singleRight"
        Me.singleRight.Size = New System.Drawing.Size(75, 23)
        Me.singleRight.TabIndex = 1
        Me.singleRight.Text = ">"
        Me.singleRight.UseVisualStyleBackColor = True
        '
        'singleLeft
        '
        Me.singleLeft.Location = New System.Drawing.Point(113, 101)
        Me.singleLeft.Name = "singleLeft"
        Me.singleLeft.Size = New System.Drawing.Size(75, 23)
        Me.singleLeft.TabIndex = 1
        Me.singleLeft.Text = "<"
        Me.singleLeft.UseVisualStyleBackColor = True
        '
        'allRight
        '
        Me.allRight.Location = New System.Drawing.Point(113, 130)
        Me.allRight.Name = "allRight"
        Me.allRight.Size = New System.Drawing.Size(75, 23)
        Me.allRight.TabIndex = 1
        Me.allRight.Text = ">>"
        Me.allRight.UseVisualStyleBackColor = True
        '
        'allLeft
        '
        Me.allLeft.Location = New System.Drawing.Point(113, 159)
        Me.allLeft.Name = "allLeft"
        Me.allLeft.Size = New System.Drawing.Size(75, 23)
        Me.allLeft.TabIndex = 1
        Me.allLeft.Text = "<<"
        Me.allLeft.UseVisualStyleBackColor = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        Me.ErrorProvider1.RightToLeft = True
        '
        'ErrorProvider2
        '
        Me.ErrorProvider2.ContainerControl = Me
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(313, 261)
        Me.Controls.Add(Me.allLeft)
        Me.Controls.Add(Me.allRight)
        Me.Controls.Add(Me.singleLeft)
        Me.Controls.Add(Me.singleRight)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.ListBox1)
        Me.Name = "Form1"
        Me.Text = "Ejercicio_DragDrop"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents singleRight As Button
    Friend WithEvents singleLeft As Button
    Friend WithEvents allRight As Button
    Friend WithEvents allLeft As Button
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents ErrorProvider2 As ErrorProvider
End Class
