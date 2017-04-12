<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
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

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請勿使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnOri = New System.Windows.Forms.Button()
        Me.btnAddEvent = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnOri
        '
        Me.btnOri.Location = New System.Drawing.Point(108, 55)
        Me.btnOri.Name = "btnOri"
        Me.btnOri.Size = New System.Drawing.Size(75, 37)
        Me.btnOri.TabIndex = 0
        Me.btnOri.Text = "原始按鈕"
        Me.btnOri.UseVisualStyleBackColor = True
        '
        'btnAddEvent
        '
        Me.btnAddEvent.Location = New System.Drawing.Point(108, 150)
        Me.btnAddEvent.Name = "btnAddEvent"
        Me.btnAddEvent.Size = New System.Drawing.Size(75, 33)
        Me.btnAddEvent.TabIndex = 1
        Me.btnAddEvent.Text = "增加Event"
        Me.btnAddEvent.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(331, 271)
        Me.Controls.Add(Me.btnAddEvent)
        Me.Controls.Add(Me.btnOri)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnOri As Button
    Friend WithEvents btnAddEvent As Button
End Class
