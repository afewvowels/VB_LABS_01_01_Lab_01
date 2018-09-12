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
        Me.MainLabel = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Saying1Button = New System.Windows.Forms.Button()
        Me.Saying2Button = New System.Windows.Forms.Button()
        Me.Saying3Button = New System.Windows.Forms.Button()
        Me.Saying4Button = New System.Windows.Forms.Button()
        Me.PrintButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.ProgrammedByLabel = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MainLabel
        '
        Me.MainLabel.Font = New System.Drawing.Font("Mathematica7", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainLabel.Location = New System.Drawing.Point(12, 9)
        Me.MainLabel.Name = "MainLabel"
        Me.MainLabel.Size = New System.Drawing.Size(460, 120)
        Me.MainLabel.TabIndex = 0
        Me.MainLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Saying1Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Saying2Button, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Saying3Button, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Saying4Button, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.PrintButton, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.ExitButton, 2, 1)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(61, 137)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(362, 66)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'Saying1Button
        '
        Me.Saying1Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Saying1Button.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Saying1Button.Location = New System.Drawing.Point(3, 3)
        Me.Saying1Button.Name = "Saying1Button"
        Me.Saying1Button.Size = New System.Drawing.Size(75, 23)
        Me.Saying1Button.TabIndex = 0
        Me.Saying1Button.Text = "Saying #1"
        Me.Saying1Button.UseVisualStyleBackColor = True
        '
        'Saying2Button
        '
        Me.Saying2Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Saying2Button.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Saying2Button.Location = New System.Drawing.Point(93, 3)
        Me.Saying2Button.Name = "Saying2Button"
        Me.Saying2Button.Size = New System.Drawing.Size(75, 23)
        Me.Saying2Button.TabIndex = 1
        Me.Saying2Button.Text = "Saying #2"
        Me.Saying2Button.UseVisualStyleBackColor = True
        '
        'Saying3Button
        '
        Me.Saying3Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Saying3Button.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Saying3Button.Location = New System.Drawing.Point(183, 3)
        Me.Saying3Button.Name = "Saying3Button"
        Me.Saying3Button.Size = New System.Drawing.Size(75, 23)
        Me.Saying3Button.TabIndex = 2
        Me.Saying3Button.Text = "Saying #3"
        Me.Saying3Button.UseVisualStyleBackColor = True
        '
        'Saying4Button
        '
        Me.Saying4Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Saying4Button.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Saying4Button.Location = New System.Drawing.Point(273, 3)
        Me.Saying4Button.Name = "Saying4Button"
        Me.Saying4Button.Size = New System.Drawing.Size(75, 23)
        Me.Saying4Button.TabIndex = 3
        Me.Saying4Button.Text = "Saying #4"
        Me.Saying4Button.UseVisualStyleBackColor = True
        '
        'PrintButton
        '
        Me.PrintButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PrintButton.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrintButton.Location = New System.Drawing.Point(93, 36)
        Me.PrintButton.Name = "PrintButton"
        Me.PrintButton.Size = New System.Drawing.Size(75, 23)
        Me.PrintButton.TabIndex = 4
        Me.PrintButton.Text = "Print"
        Me.PrintButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ExitButton.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitButton.Location = New System.Drawing.Point(183, 36)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(75, 23)
        Me.ExitButton.TabIndex = 5
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'ProgrammedByLabel
        '
        Me.ProgrammedByLabel.AutoSize = True
        Me.ProgrammedByLabel.Location = New System.Drawing.Point(13, 237)
        Me.ProgrammedByLabel.Name = "ProgrammedByLabel"
        Me.ProgrammedByLabel.Size = New System.Drawing.Size(152, 13)
        Me.ProgrammedByLabel.TabIndex = 2
        Me.ProgrammedByLabel.Text = "Programmed by: Keith B. Smith"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 262)
        Me.Controls.Add(Me.ProgrammedByLabel)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.MainLabel)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CSIS 3726 - Lab #001"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MainLabel As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Saying1Button As System.Windows.Forms.Button
    Friend WithEvents Saying2Button As System.Windows.Forms.Button
    Friend WithEvents Saying3Button As System.Windows.Forms.Button
    Friend WithEvents Saying4Button As System.Windows.Forms.Button
    Friend WithEvents PrintButton As System.Windows.Forms.Button
    Friend WithEvents ExitButton As System.Windows.Forms.Button
    Friend WithEvents ProgrammedByLabel As System.Windows.Forms.Label

End Class
