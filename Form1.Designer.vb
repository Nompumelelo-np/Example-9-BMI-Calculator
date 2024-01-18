<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = SystemColors.ActiveCaption
        Label1.Font = New Font("Segoe Print", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(275, 15)
        Label1.Name = "Label1"
        Label1.Size = New Size(131, 28)
        Label1.TabIndex = 0
        Label1.Text = "BMI Calculator"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 11.25F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(140, 78)
        Label2.Name = "Label2"
        Label2.Size = New Size(123, 20)
        Label2.TabIndex = 1
        Label2.Text = "Enter your Weight"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 11.25F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(140, 114)
        Label3.Name = "Label3"
        Label3.Size = New Size(143, 20)
        Label3.TabIndex = 1
        Label3.Text = "Enter your Height(m)"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 11.25F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(140, 149)
        Label4.Name = "Label4"
        Label4.Size = New Size(67, 20)
        Label4.TabIndex = 1
        Label4.Text = "Your BMI"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 11.25F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(140, 178)
        Label5.Name = "Label5"
        Label5.Size = New Size(73, 20)
        Label5.TabIndex = 1
        Label5.Text = "Comment"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(348, 77)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(100, 23)
        TextBox1.TabIndex = 2
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(348, 106)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(100, 23)
        TextBox2.TabIndex = 2
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(348, 135)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(100, 23)
        TextBox3.TabIndex = 2
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(348, 170)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(100, 23)
        TextBox4.TabIndex = 2
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(149, 242)
        Button1.Name = "Button1"
        Button1.Size = New Size(104, 43)
        Button1.TabIndex = 3
        Button1.Text = "Calculate"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(800, 450)
        Controls.Add(Button1)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Determining BMI"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Button1 As Button

End Class
