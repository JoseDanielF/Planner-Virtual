<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim NovoToolStripButton As System.Windows.Forms.ToolStripButton
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.GrupoPrincipal = New System.Windows.Forms.GroupBox()
        Me.Descrição = New System.Windows.Forms.Label()
        Me.Data = New System.Windows.Forms.Label()
        Me.TextDescricao = New System.Windows.Forms.TextBox()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.MaskedTextData = New System.Windows.Forms.MaskedTextBox()
        Me.ComboBoxTipo = New System.Windows.Forms.ComboBox()
        Me.Tipo = New System.Windows.Forms.Label()
        Me.Status = New System.Windows.Forms.Label()
        Me.LabelStatus = New System.Windows.Forms.Label()
        Me.Agendamentos = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TextComplemento = New System.Windows.Forms.TextBox()
        Me.Complemento = New System.Windows.Forms.Label()
        Me.Agendar = New System.Windows.Forms.Label()
        Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.SalvarToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.RecortarToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.Ferramentas = New System.Windows.Forms.ToolStrip()
        NovoToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.GrupoPrincipal.SuspendLayout()
        Me.Ferramentas.SuspendLayout()
        Me.SuspendLayout()
        '
        'GrupoPrincipal
        '
        Me.GrupoPrincipal.Controls.Add(Me.TextComplemento)
        Me.GrupoPrincipal.Controls.Add(Me.Complemento)
        Me.GrupoPrincipal.Controls.Add(Me.LabelStatus)
        Me.GrupoPrincipal.Controls.Add(Me.Status)
        Me.GrupoPrincipal.Controls.Add(Me.ComboBoxTipo)
        Me.GrupoPrincipal.Controls.Add(Me.Tipo)
        Me.GrupoPrincipal.Controls.Add(Me.MaskedTextData)
        Me.GrupoPrincipal.Controls.Add(Me.TextDescricao)
        Me.GrupoPrincipal.Controls.Add(Me.Data)
        Me.GrupoPrincipal.Controls.Add(Me.Descrição)
        Me.GrupoPrincipal.Location = New System.Drawing.Point(182, 12)
        Me.GrupoPrincipal.Name = "GrupoPrincipal"
        Me.GrupoPrincipal.Size = New System.Drawing.Size(543, 216)
        Me.GrupoPrincipal.TabIndex = 1
        Me.GrupoPrincipal.TabStop = False
        '
        'Descrição
        '
        Me.Descrição.AutoSize = True
        Me.Descrição.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Descrição.Location = New System.Drawing.Point(43, 31)
        Me.Descrição.Name = "Descrição"
        Me.Descrição.Size = New System.Drawing.Size(71, 17)
        Me.Descrição.TabIndex = 0
        Me.Descrição.Text = "Descrição"
        '
        'Data
        '
        Me.Data.AutoSize = True
        Me.Data.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Data.Location = New System.Drawing.Point(76, 90)
        Me.Data.Name = "Data"
        Me.Data.Size = New System.Drawing.Size(38, 17)
        Me.Data.TabIndex = 2
        Me.Data.Text = "Data"
        '
        'TextDescricao
        '
        Me.TextDescricao.Location = New System.Drawing.Point(120, 28)
        Me.TextDescricao.Name = "TextDescricao"
        Me.TextDescricao.Size = New System.Drawing.Size(372, 20)
        Me.TextDescricao.TabIndex = 4
        '
        'MaskedTextData
        '
        Me.MaskedTextData.Location = New System.Drawing.Point(120, 87)
        Me.MaskedTextData.Mask = "00/00/0000 00:00"
        Me.MaskedTextData.Name = "MaskedTextData"
        Me.MaskedTextData.Size = New System.Drawing.Size(103, 20)
        Me.MaskedTextData.TabIndex = 6
        '
        'ComboBoxTipo
        '
        Me.ComboBoxTipo.BackColor = System.Drawing.Color.White
        Me.ComboBoxTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxTipo.FormattingEnabled = True
        Me.ComboBoxTipo.Items.AddRange(New Object() {"1 - Tarefa", "2 - Metas", "3 - Lembrete", ""})
        Me.ComboBoxTipo.Location = New System.Drawing.Point(120, 60)
        Me.ComboBoxTipo.Name = "ComboBoxTipo"
        Me.ComboBoxTipo.Size = New System.Drawing.Size(372, 21)
        Me.ComboBoxTipo.TabIndex = 9
        '
        'Tipo
        '
        Me.Tipo.AutoSize = True
        Me.Tipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tipo.Location = New System.Drawing.Point(78, 60)
        Me.Tipo.Name = "Tipo"
        Me.Tipo.Size = New System.Drawing.Size(36, 17)
        Me.Tipo.TabIndex = 8
        Me.Tipo.Text = "Tipo"
        '
        'Status
        '
        Me.Status.AutoSize = True
        Me.Status.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Status.Location = New System.Drawing.Point(66, 148)
        Me.Status.Name = "Status"
        Me.Status.Size = New System.Drawing.Size(48, 17)
        Me.Status.TabIndex = 10
        Me.Status.Text = "Status"
        '
        'LabelStatus
        '
        Me.LabelStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelStatus.Location = New System.Drawing.Point(120, 148)
        Me.LabelStatus.Name = "LabelStatus"
        Me.LabelStatus.Size = New System.Drawing.Size(372, 16)
        Me.LabelStatus.TabIndex = 11
        '
        'Agendamentos
        '
        Me.Agendamentos.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6})
        Me.Agendamentos.HideSelection = False
        Me.Agendamentos.Location = New System.Drawing.Point(12, 245)
        Me.Agendamentos.Name = "Agendamentos"
        Me.Agendamentos.Size = New System.Drawing.Size(713, 204)
        Me.Agendamentos.TabIndex = 3
        Me.Agendamentos.UseCompatibleStateImageBehavior = False
        Me.Agendamentos.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Item"
        Me.ColumnHeader1.Width = 40
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Descrição da tarefa"
        Me.ColumnHeader2.Width = 200
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Data e horário"
        Me.ColumnHeader3.Width = 110
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Tipo"
        Me.ColumnHeader4.Width = 45
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Complemento"
        Me.ColumnHeader5.Width = 120
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Status"
        Me.ColumnHeader6.Width = 100
        '
        'TextComplemento
        '
        Me.TextComplemento.Location = New System.Drawing.Point(120, 116)
        Me.TextComplemento.Name = "TextComplemento"
        Me.TextComplemento.Size = New System.Drawing.Size(372, 20)
        Me.TextComplemento.TabIndex = 13
        '
        'Complemento
        '
        Me.Complemento.AutoSize = True
        Me.Complemento.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Complemento.Location = New System.Drawing.Point(20, 119)
        Me.Complemento.Name = "Complemento"
        Me.Complemento.Size = New System.Drawing.Size(94, 17)
        Me.Complemento.TabIndex = 12
        Me.Complemento.Text = "Complemento"
        '
        'Agendar
        '
        Me.Agendar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Agendar.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agendar.Image = Global.plp.My.Resources.Resources.calendar_macos_bigsur_icon_189482__1_
        Me.Agendar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Agendar.Location = New System.Drawing.Point(22, 24)
        Me.Agendar.Name = "Agendar"
        Me.Agendar.Size = New System.Drawing.Size(133, 48)
        Me.Agendar.TabIndex = 2
        Me.Agendar.Text = "Agenda"
        Me.Agendar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'NovoToolStripButton
        '
        NovoToolStripButton.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        NovoToolStripButton.Image = CType(resources.GetObject("NovoToolStripButton.Image"), System.Drawing.Image)
        NovoToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        NovoToolStripButton.Name = "NovoToolStripButton"
        NovoToolStripButton.Size = New System.Drawing.Size(111, 39)
        NovoToolStripButton.Text = "Novo"
        NovoToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'toolStripSeparator1
        '
        Me.toolStripSeparator1.AutoSize = False
        Me.toolStripSeparator1.Name = "toolStripSeparator1"
        Me.toolStripSeparator1.Size = New System.Drawing.Size(112, 6)
        '
        'SalvarToolStripButton
        '
        Me.SalvarToolStripButton.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.SalvarToolStripButton.Image = CType(resources.GetObject("SalvarToolStripButton.Image"), System.Drawing.Image)
        Me.SalvarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SalvarToolStripButton.Name = "SalvarToolStripButton"
        Me.SalvarToolStripButton.Size = New System.Drawing.Size(111, 39)
        Me.SalvarToolStripButton.Text = "Salvar"
        Me.SalvarToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'toolStripSeparator
        '
        Me.toolStripSeparator.Name = "toolStripSeparator"
        Me.toolStripSeparator.Size = New System.Drawing.Size(111, 6)
        '
        'RecortarToolStripButton
        '
        Me.RecortarToolStripButton.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.RecortarToolStripButton.Image = CType(resources.GetObject("RecortarToolStripButton.Image"), System.Drawing.Image)
        Me.RecortarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.RecortarToolStripButton.Name = "RecortarToolStripButton"
        Me.RecortarToolStripButton.Size = New System.Drawing.Size(111, 39)
        Me.RecortarToolStripButton.Text = "Excluir"
        Me.RecortarToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'Ferramentas
        '
        Me.Ferramentas.Dock = System.Windows.Forms.DockStyle.None
        Me.Ferramentas.Items.AddRange(New System.Windows.Forms.ToolStripItem() {NovoToolStripButton, Me.toolStripSeparator1, Me.SalvarToolStripButton, Me.toolStripSeparator, Me.RecortarToolStripButton})
        Me.Ferramentas.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.Ferramentas.Location = New System.Drawing.Point(31, 82)
        Me.Ferramentas.Name = "Ferramentas"
        Me.Ferramentas.Size = New System.Drawing.Size(113, 149)
        Me.Ferramentas.TabIndex = 4
        Me.Ferramentas.Text = "ToolStrip1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Ferramentas)
        Me.Controls.Add(Me.Agendamentos)
        Me.Controls.Add(Me.Agendar)
        Me.Controls.Add(Me.GrupoPrincipal)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Calendario"
        Me.GrupoPrincipal.ResumeLayout(False)
        Me.GrupoPrincipal.PerformLayout()
        Me.Ferramentas.ResumeLayout(False)
        Me.Ferramentas.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GrupoPrincipal As GroupBox
    Friend WithEvents Descrição As Label
    Friend WithEvents Data As Label
    Friend WithEvents TextDescricao As TextBox
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents MaskedTextData As MaskedTextBox
    Friend WithEvents ComboBoxTipo As ComboBox
    Friend WithEvents Tipo As Label
    Friend WithEvents Status As Label
    Friend WithEvents LabelStatus As Label
    Friend WithEvents Agendar As Label
    Friend WithEvents Agendamentos As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents TextComplemento As TextBox
    Friend WithEvents Complemento As Label
    Friend WithEvents toolStripSeparator1 As ToolStripSeparator
    Friend WithEvents SalvarToolStripButton As ToolStripButton
    Friend WithEvents toolStripSeparator As ToolStripSeparator
    Friend WithEvents RecortarToolStripButton As ToolStripButton
    Friend WithEvents Ferramentas As ToolStrip
End Class
