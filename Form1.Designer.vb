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
        btnGreeting = New Button()
        strHomeLanguage = New Label()
        txtLanguage = New TextBox()
        SuspendLayout()
        ' 
        ' btnGreeting
        ' 
        btnGreeting.Location = New Point(187, 238)
        btnGreeting.Name = "btnGreeting"
        btnGreeting.Size = New Size(112, 34)
        btnGreeting.TabIndex = 0
        btnGreeting.Text = "Greeting"
        btnGreeting.UseVisualStyleBackColor = True
        ' 
        ' strHomeLanguage
        ' 
        strHomeLanguage.AutoSize = True
        strHomeLanguage.Location = New Point(132, 75)
        strHomeLanguage.Name = "strHomeLanguage"
        strHomeLanguage.Size = New Size(143, 25)
        strHomeLanguage.TabIndex = 1
        strHomeLanguage.Text = "Home Language"
        ' 
        ' txtLanguage
        ' 
        txtLanguage.Location = New Point(380, 75)
        txtLanguage.Name = "txtLanguage"
        txtLanguage.Size = New Size(150, 31)
        txtLanguage.TabIndex = 2
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(txtLanguage)
        Controls.Add(strHomeLanguage)
        Controls.Add(btnGreeting)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnGreeting As Button
    Friend WithEvents strHomeLanguage As Label
    Friend WithEvents txtLanguage As TextBox
End Class
