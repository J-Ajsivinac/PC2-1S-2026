<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        btnReportes = New Button()
        txtNumProducts = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        cmbNumAttributes = New ComboBox()
        Label3 = New Label()
        chkIncludeCosts = New CheckBox()
        Label4 = New Label()
        GroupBox1 = New GroupBox()
        rdbDemoLoad = New RadioButton()
        rdbManualLoad = New RadioButton()
        Label5 = New Label()
        txtProductNames = New TextBox()
        Label6 = New Label()
        txtInventoryData = New TextBox()
        btnLoadData = New Button()
        Panel1 = New Panel()
        Label9 = New Label()
        Button1 = New Button()
        dgvInventory = New DataGridView()
        Label8 = New Label()
        lstProducts = New ListBox()
        Label7 = New Label()
        GroupBox1.SuspendLayout()
        Panel1.SuspendLayout()
        CType(dgvInventory, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnReportes
        ' 
        btnReportes.Location = New Point(12, 730)
        btnReportes.Name = "btnReportes"
        btnReportes.Size = New Size(209, 34)
        btnReportes.TabIndex = 0
        btnReportes.Text = "Ver Reportes"
        btnReportes.UseVisualStyleBackColor = True
        ' 
        ' txtNumProducts
        ' 
        txtNumProducts.Location = New Point(12, 86)
        txtNumProducts.Name = "txtNumProducts"
        txtNumProducts.Size = New Size(235, 27)
        txtNumProducts.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 63)
        Label1.Name = "Label1"
        Label1.Size = New Size(154, 20)
        Label1.TabIndex = 2
        Label1.Text = "Número de Productos"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(271, 63)
        Label2.Name = "Label2"
        Label2.Size = New Size(149, 20)
        Label2.TabIndex = 3
        Label2.Text = "Numero de Atributos"
        ' 
        ' cmbNumAttributes
        ' 
        cmbNumAttributes.FormattingEnabled = True
        cmbNumAttributes.Location = New Point(271, 86)
        cmbNumAttributes.Name = "cmbNumAttributes"
        cmbNumAttributes.Size = New Size(222, 28)
        cmbNumAttributes.TabIndex = 4
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(528, 63)
        Label3.Name = "Label3"
        Label3.Size = New Size(173, 20)
        Label3.TabIndex = 5
        Label3.Text = "Incluyir costos en cálculo"
        ' 
        ' chkIncludeCosts
        ' 
        chkIncludeCosts.AutoSize = True
        chkIncludeCosts.Location = New Point(528, 90)
        chkIncludeCosts.Name = "chkIncludeCosts"
        chkIncludeCosts.Size = New Size(119, 24)
        chkIncludeCosts.TabIndex = 6
        chkIncludeCosts.Text = "Incluir Costos"
        chkIncludeCosts.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Cascadia Code SemiBold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(12, 9)
        Label4.Name = "Label4"
        Label4.Size = New Size(286, 30)
        Label4.TabIndex = 7
        Label4.Text = "Sistema de Inventario"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(rdbDemoLoad)
        GroupBox1.Controls.Add(rdbManualLoad)
        GroupBox1.Location = New Point(12, 133)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(723, 88)
        GroupBox1.TabIndex = 8
        GroupBox1.TabStop = False
        GroupBox1.Text = "Modo de Carga"
        ' 
        ' rdbDemoLoad
        ' 
        rdbDemoLoad.AutoSize = True
        rdbDemoLoad.Location = New Point(150, 39)
        rdbDemoLoad.Name = "rdbDemoLoad"
        rdbDemoLoad.Size = New Size(114, 24)
        rdbDemoLoad.TabIndex = 1
        rdbDemoLoad.TabStop = True
        rdbDemoLoad.Text = "Carga Demo"
        rdbDemoLoad.UseVisualStyleBackColor = True
        ' 
        ' rdbManualLoad
        ' 
        rdbManualLoad.AutoSize = True
        rdbManualLoad.Location = New Point(6, 39)
        rdbManualLoad.Name = "rdbManualLoad"
        rdbManualLoad.Size = New Size(122, 24)
        rdbManualLoad.TabIndex = 0
        rdbManualLoad.TabStop = True
        rdbManualLoad.Text = "Carga Manual"
        rdbManualLoad.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(12, 236)
        Label5.Name = "Label5"
        Label5.Size = New Size(320, 20)
        Label5.TabIndex = 9
        Label5.Text = "Nombres de prodcutos ( separados por coma )"
        ' 
        ' txtProductNames
        ' 
        txtProductNames.Location = New Point(12, 263)
        txtProductNames.Name = "txtProductNames"
        txtProductNames.Size = New Size(723, 27)
        txtProductNames.TabIndex = 10
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(15, 307)
        Label6.Name = "Label6"
        Label6.Size = New Size(397, 20)
        Label6.TabIndex = 11
        Label6.Text = "Datos de Inventario (filas separadas por ; y columnas por ,)"
        ' 
        ' txtInventoryData
        ' 
        txtInventoryData.Location = New Point(12, 341)
        txtInventoryData.Name = "txtInventoryData"
        txtInventoryData.Size = New Size(723, 27)
        txtInventoryData.TabIndex = 12
        ' 
        ' btnLoadData
        ' 
        btnLoadData.Location = New Point(12, 380)
        btnLoadData.Name = "btnLoadData"
        btnLoadData.Size = New Size(723, 29)
        btnLoadData.TabIndex = 13
        btnLoadData.Text = "Cargar Datos"
        btnLoadData.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.Controls.Add(Label9)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(dgvInventory)
        Panel1.Controls.Add(Label8)
        Panel1.Controls.Add(lstProducts)
        Panel1.Controls.Add(Label7)
        Panel1.Location = New Point(17, 415)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(718, 300)
        Panel1.TabIndex = 14
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(218, 258)
        Label9.Name = "Label9"
        Label9.Size = New Size(114, 20)
        Label9.TabIndex = 5
        Label9.Text = "Valor Total: 0.00"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(14, 254)
        Button1.Name = "Button1"
        Button1.Size = New Size(190, 29)
        Button1.TabIndex = 4
        Button1.Text = "Calcular Valor Total"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' dgvInventory
        ' 
        dgvInventory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvInventory.Location = New Point(218, 49)
        dgvInventory.Name = "dgvInventory"
        dgvInventory.RowHeadersWidth = 51
        dgvInventory.Size = New Size(485, 188)
        dgvInventory.TabIndex = 3
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(218, 19)
        Label8.Name = "Label8"
        Label8.Size = New Size(142, 20)
        Label8.TabIndex = 2
        Label8.Text = "Matriz de Inventario"
        ' 
        ' lstProducts
        ' 
        lstProducts.FormattingEnabled = True
        lstProducts.Location = New Point(14, 53)
        lstProducts.Name = "lstProducts"
        lstProducts.Size = New Size(190, 184)
        lstProducts.TabIndex = 1
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(14, 19)
        Label7.Name = "Label7"
        Label7.Size = New Size(142, 20)
        Label7.TabIndex = 0
        Label7.Text = "Productos Cargados"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(747, 771)
        Controls.Add(Panel1)
        Controls.Add(btnLoadData)
        Controls.Add(txtInventoryData)
        Controls.Add(Label6)
        Controls.Add(txtProductNames)
        Controls.Add(Label5)
        Controls.Add(GroupBox1)
        Controls.Add(Label4)
        Controls.Add(chkIncludeCosts)
        Controls.Add(Label3)
        Controls.Add(cmbNumAttributes)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtNumProducts)
        Controls.Add(btnReportes)
        Name = "Form1"
        Text = "Form1"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(dgvInventory, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnReportes As Button
    Friend WithEvents txtNumProducts As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbNumAttributes As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents chkIncludeCosts As CheckBox
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rdbDemoLoad As RadioButton
    Friend WithEvents rdbManualLoad As RadioButton
    Friend WithEvents Label5 As Label
    Friend WithEvents txtProductNames As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtInventoryData As TextBox
    Friend WithEvents btnLoadData As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents dgvInventory As DataGridView
    Friend WithEvents Label8 As Label
    Friend WithEvents lstProducts As ListBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Button1 As Button

End Class
