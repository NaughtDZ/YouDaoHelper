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
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        Label3 = New Label()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        Button1 = New Button()
        Button2 = New Button()
        TextBox5 = New TextBox()
        TextBox6 = New TextBox()
        Label4 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(68, 17)
        Label1.TabIndex = 0
        Label1.Text = "左上角坐标"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 94)
        Label2.Name = "Label2"
        Label2.Size = New Size(68, 17)
        Label2.TabIndex = 1
        Label2.Text = "右下角坐标"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(12, 26)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(49, 23)
        TextBox1.TabIndex = 2
        TextBox1.Text = "380"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(86, 26)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(49, 23)
        TextBox2.TabIndex = 3
        TextBox2.Text = "780"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(150, 24)
        Label3.Name = "Label3"
        Label3.Size = New Size(116, 136)
        Label3.TabIndex = 4
        Label3.Text = "坐标格式为X和Y" & vbCrLf & "默认你的有道快捷键" & vbCrLf & "Ctrl+Alt+D" & vbCrLf & "本程序快捷键" & vbCrLf & "Alt+S" & vbCrLf & "聪明的你一定会从" & vbCrLf & "源代码修改快捷键的" & vbCrLf & "对吧"
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(12, 114)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(49, 23)
        TextBox3.TabIndex = 2
        TextBox3.Text = "1550"
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(86, 114)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(49, 23)
        TextBox4.TabIndex = 3
        TextBox4.Text = "1020"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(11, 55)
        Button1.Name = "Button1"
        Button1.Size = New Size(124, 24)
        Button1.TabIndex = 5
        Button1.Text = "3秒后获取A坐标"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(12, 143)
        Button2.Name = "Button2"
        Button2.Size = New Size(123, 27)
        Button2.TabIndex = 6
        Button2.Text = "3秒后获取A坐标"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(11, 216)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(100, 23)
        TextBox5.TabIndex = 7
        TextBox5.Text = "300"
        ' 
        ' TextBox6
        ' 
        TextBox6.Location = New Point(150, 216)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(100, 23)
        TextBox6.TabIndex = 8
        TextBox6.Text = "100"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(11, 179)
        Label4.Name = "Label4"
        Label4.Size = New Size(224, 34)
        Label4.TabIndex = 9
        Label4.Text = "两个延时：按下左键延时、移动鼠标延时" & vbCrLf & "防止卡机子有道没反应过来"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 17F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(273, 251)
        Controls.Add(Label4)
        Controls.Add(TextBox6)
        Controls.Add(TextBox5)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label3)
        Controls.Add(TextBox4)
        Controls.Add(TextBox2)
        Controls.Add(TextBox3)
        Controls.Add(TextBox1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "有道截图翻译懒人帮手"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label4 As Label

End Class
