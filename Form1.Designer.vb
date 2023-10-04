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
        btn_input_count = New Button()
        lb_input_count = New Label()
        btn_add = New Button()
        btn_inputs_arr = New Button()
        btn_getLowest = New Button()
        btn_hightest = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        SuspendLayout()
        ' 
        ' btn_input_count
        ' 
        btn_input_count.Location = New Point(41, 36)
        btn_input_count.Name = "btn_input_count"
        btn_input_count.Size = New Size(132, 30)
        btn_input_count.TabIndex = 0
        btn_input_count.Text = "Enter Input Count"
        btn_input_count.UseVisualStyleBackColor = True
        ' 
        ' lb_input_count
        ' 
        lb_input_count.AutoSize = True
        lb_input_count.Location = New Point(192, 44)
        lb_input_count.Name = "lb_input_count"
        lb_input_count.Size = New Size(328, 15)
        lb_input_count.TabIndex = 1
        lb_input_count.Text = "How many Inputs you want to add in your array of numbers?"
        ' 
        ' btn_add
        ' 
        btn_add.Location = New Point(41, 108)
        btn_add.Name = "btn_add"
        btn_add.Size = New Size(132, 30)
        btn_add.TabIndex = 3
        btn_add.Text = "Get Sum"
        btn_add.UseVisualStyleBackColor = True
        ' 
        ' btn_inputs_arr
        ' 
        btn_inputs_arr.Location = New Point(41, 72)
        btn_inputs_arr.Name = "btn_inputs_arr"
        btn_inputs_arr.Size = New Size(132, 30)
        btn_inputs_arr.TabIndex = 4
        btn_inputs_arr.Text = "Input Numbers"
        btn_inputs_arr.UseVisualStyleBackColor = True
        ' 
        ' btn_getLowest
        ' 
        btn_getLowest.Location = New Point(41, 144)
        btn_getLowest.Name = "btn_getLowest"
        btn_getLowest.Size = New Size(132, 30)
        btn_getLowest.TabIndex = 5
        btn_getLowest.Text = "Get Lowest Number"
        btn_getLowest.UseVisualStyleBackColor = True
        ' 
        ' btn_hightest
        ' 
        btn_hightest.Location = New Point(41, 180)
        btn_hightest.Name = "btn_hightest"
        btn_hightest.Size = New Size(132, 30)
        btn_hightest.TabIndex = 6
        btn_hightest.Text = "Get Highest Number"
        btn_hightest.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(192, 188)
        Label1.Name = "Label1"
        Label1.Size = New Size(164, 15)
        Label1.TabIndex = 7
        Label1.Text = "Get Highest value in the Array"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(192, 152)
        Label2.Name = "Label2"
        Label2.Size = New Size(158, 15)
        Label2.TabIndex = 8
        Label2.Text = "Get Lowest value in the array"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(192, 116)
        Label3.Name = "Label3"
        Label3.Size = New Size(184, 15)
        Label3.TabIndex = 9
        Label3.Text = "Get Sum of the calues in the array"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(192, 80)
        Label4.Name = "Label4"
        Label4.Size = New Size(133, 15)
        Label4.TabIndex = 10
        Label4.Text = "Input values in the array"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(549, 257)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btn_hightest)
        Controls.Add(btn_getLowest)
        Controls.Add(btn_inputs_arr)
        Controls.Add(btn_add)
        Controls.Add(lb_input_count)
        Controls.Add(btn_input_count)
        Name = "Form1"
        Text = "Array Numbers"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btn_input_count As Button
    Friend WithEvents lb_input_count As Label
    Friend WithEvents btn_add As Button
    Friend WithEvents btn_inputs_arr As Button
    Friend WithEvents btn_getLowest As Button
    Friend WithEvents btn_hightest As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
