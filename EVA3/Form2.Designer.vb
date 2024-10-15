<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Panel1 = New Panel()
        Label3 = New Label()
        BTINGRESARcliente = New Button()
        Label2 = New Label()
        Label1 = New Label()
        UsuarioCliente = New TextBox()
        ContraseñaCliente = New TextBox()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Gray
        Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), Image)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(BTINGRESARcliente)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(UsuarioCliente)
        Panel1.Controls.Add(ContraseñaCliente)
        Panel1.Location = New Point(70, 36)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(349, 335)
        Panel1.TabIndex = 0
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.White
        Label3.Font = New Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(89, 14)
        Label3.Name = "Label3"
        Label3.Size = New Size(164, 21)
        Label3.TabIndex = 12
        Label3.Text = "INGRESO CLIENTE "
        ' 
        ' BTINGRESARcliente
        ' 
        BTINGRESARcliente.BackgroundImage = CType(resources.GetObject("BTINGRESARcliente.BackgroundImage"), Image)
        BTINGRESARcliente.Cursor = Cursors.IBeam
        BTINGRESARcliente.Location = New Point(257, 225)
        BTINGRESARcliente.Name = "BTINGRESARcliente"
        BTINGRESARcliente.Size = New Size(71, 107)
        BTINGRESARcliente.TabIndex = 11
        BTINGRESARcliente.Text = "INGRESAR"
        BTINGRESARcliente.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Label2.Font = New Font("Yu Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(3, 139)
        Label2.Name = "Label2"
        Label2.Size = New Size(104, 17)
        Label2.TabIndex = 10
        Label2.Text = "CONTRASEÑA:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.White
        Label1.Font = New Font("Yu Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(19, 80)
        Label1.Name = "Label1"
        Label1.Size = New Size(73, 17)
        Label1.TabIndex = 9
        Label1.Text = "USUARIO:"
        ' 
        ' UsuarioCliente
        ' 
        UsuarioCliente.Location = New Point(139, 80)
        UsuarioCliente.Name = "UsuarioCliente"
        UsuarioCliente.Size = New Size(189, 23)
        UsuarioCliente.TabIndex = 7
        ' 
        ' ContraseñaCliente
        ' 
        ContraseñaCliente.Location = New Point(139, 137)
        ContraseñaCliente.Name = "ContraseñaCliente"
        ContraseñaCliente.Size = New Size(189, 23)
        ContraseñaCliente.TabIndex = 8
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Panel1)
        Name = "Form2"
        Text = "Form2"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents BTINGRESARcliente As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents UsuarioCliente As TextBox
    Friend WithEvents ContraseñaCliente As TextBox
    Friend WithEvents Label3 As Label
End Class
