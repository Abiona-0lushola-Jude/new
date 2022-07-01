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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtEA = New System.Windows.Forms.TextBox()
        Me.txtNB = New System.Windows.Forms.TextBox()
        Me.txtNA = New System.Windows.Forms.TextBox()
        Me.txtEB = New System.Windows.Forms.TextBox()
        Me.btndis = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtans = New System.Windows.Forms.TextBox()
        Me.btnext = New System.Windows.Forms.Button()
        Me.btnclr = New System.Windows.Forms.Button()
        Me.Btnnxt = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(36, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Easting A"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(343, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 21)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Northing A"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(36, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 21)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Easting B"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(343, 72)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 21)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Northing B"
        '
        'txtEA
        '
        Me.txtEA.Location = New System.Drawing.Point(127, 30)
        Me.txtEA.Name = "txtEA"
        Me.txtEA.Size = New System.Drawing.Size(193, 29)
        Me.txtEA.TabIndex = 4
        '
        'txtNB
        '
        Me.txtNB.Location = New System.Drawing.Point(444, 69)
        Me.txtNB.Name = "txtNB"
        Me.txtNB.Size = New System.Drawing.Size(162, 29)
        Me.txtNB.TabIndex = 5
        '
        'txtNA
        '
        Me.txtNA.Location = New System.Drawing.Point(444, 22)
        Me.txtNA.Name = "txtNA"
        Me.txtNA.Size = New System.Drawing.Size(162, 29)
        Me.txtNA.TabIndex = 6
        '
        'txtEB
        '
        Me.txtEB.Location = New System.Drawing.Point(127, 72)
        Me.txtEB.Name = "txtEB"
        Me.txtEB.Size = New System.Drawing.Size(193, 29)
        Me.txtEB.TabIndex = 7
        '
        'btndis
        '
        Me.btndis.Location = New System.Drawing.Point(27, 304)
        Me.btndis.Name = "btndis"
        Me.btndis.Size = New System.Drawing.Size(150, 50)
        Me.btndis.TabIndex = 8
        Me.btndis.Text = "&DISTANCE"
        Me.btndis.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(456, 304)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(150, 50)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "&BEARING"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtans
        '
        Me.txtans.Location = New System.Drawing.Point(209, 155)
        Me.txtans.Multiline = True
        Me.txtans.Name = "txtans"
        Me.txtans.Size = New System.Drawing.Size(229, 117)
        Me.txtans.TabIndex = 11
        '
        'btnext
        '
        Me.btnext.Location = New System.Drawing.Point(26, 399)
        Me.btnext.Name = "btnext"
        Me.btnext.Size = New System.Drawing.Size(95, 50)
        Me.btnext.TabIndex = 12
        Me.btnext.Text = "EXIT"
        Me.btnext.UseVisualStyleBackColor = True
        '
        'btnclr
        '
        Me.btnclr.Location = New System.Drawing.Point(511, 390)
        Me.btnclr.Name = "btnclr"
        Me.btnclr.Size = New System.Drawing.Size(95, 50)
        Me.btnclr.TabIndex = 13
        Me.btnclr.Text = "&CLEAR"
        Me.btnclr.UseVisualStyleBackColor = True
        '
        'Btnnxt
        '
        Me.Btnnxt.Location = New System.Drawing.Point(270, 390)
        Me.Btnnxt.Name = "Btnnxt"
        Me.Btnnxt.Size = New System.Drawing.Size(95, 50)
        Me.Btnnxt.TabIndex = 14
        Me.Btnnxt.Text = "&NEXT"
        Me.Btnnxt.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(684, 461)
        Me.Controls.Add(Me.Btnnxt)
        Me.Controls.Add(Me.btnclr)
        Me.Controls.Add(Me.btnext)
        Me.Controls.Add(Me.txtans)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btndis)
        Me.Controls.Add(Me.txtEB)
        Me.Controls.Add(Me.txtNA)
        Me.Controls.Add(Me.txtNB)
        Me.Controls.Add(Me.txtEA)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "Form1"
        Me.Text = "TRAVERSE BACK-COMPUTATION CALCULATOR"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtEA As TextBox
    Friend WithEvents txtNB As TextBox
    Friend WithEvents txtNA As TextBox
    Friend WithEvents txtEB As TextBox
    Friend WithEvents btndis As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents txtans As TextBox
    Friend WithEvents btnext As Button
    Friend WithEvents btnclr As Button
    Friend WithEvents Btnnxt As Button
End Class
