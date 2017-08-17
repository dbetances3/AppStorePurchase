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
        Me.lblAppTitle = New System.Windows.Forms.Label()
        Me.cboPackages = New System.Windows.Forms.ComboBox()
        Me.btnFinalTotal = New System.Windows.Forms.Button()
        Me.btnClearForm = New System.Windows.Forms.Button()
        Me.btnDailyTotal = New System.Windows.Forms.Button()
        Me.lblCreditCardNumber = New System.Windows.Forms.Label()
        Me.lblExpirationDate = New System.Windows.Forms.Label()
        Me.lblCosts = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.chkStudent = New System.Windows.Forms.CheckBox()
        Me.txtCreditCard = New System.Windows.Forms.TextBox()
        Me.txtExpirationDate = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblAppTitle
        '
        Me.lblAppTitle.AutoSize = True
        Me.lblAppTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAppTitle.Location = New System.Drawing.Point(172, 222)
        Me.lblAppTitle.Name = "lblAppTitle"
        Me.lblAppTitle.Size = New System.Drawing.Size(67, 15)
        Me.lblAppTitle.TabIndex = 0
        Me.lblAppTitle.Text = "App Title:"
        '
        'cboPackages
        '
        Me.cboPackages.FormattingEnabled = True
        Me.cboPackages.Items.AddRange(New Object() {"Speed Up the Internet, $1.99", "A Writer's Writer, $0.99", "Distance Personnel Management, $2.99", "Email Photo Manager, $4.99", "Keyboard SpeedLearner, $1.99"})
        Me.cboPackages.Location = New System.Drawing.Point(245, 221)
        Me.cboPackages.Name = "cboPackages"
        Me.cboPackages.Size = New System.Drawing.Size(220, 21)
        Me.cboPackages.TabIndex = 1
        Me.cboPackages.Text = "Select Title"
        '
        'btnFinalTotal
        '
        Me.btnFinalTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFinalTotal.Location = New System.Drawing.Point(80, 332)
        Me.btnFinalTotal.Name = "btnFinalTotal"
        Me.btnFinalTotal.Size = New System.Drawing.Size(119, 31)
        Me.btnFinalTotal.TabIndex = 2
        Me.btnFinalTotal.Text = "Final Total"
        Me.btnFinalTotal.UseVisualStyleBackColor = True
        '
        'btnClearForm
        '
        Me.btnClearForm.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearForm.Location = New System.Drawing.Point(245, 332)
        Me.btnClearForm.Name = "btnClearForm"
        Me.btnClearForm.Size = New System.Drawing.Size(119, 31)
        Me.btnClearForm.TabIndex = 3
        Me.btnClearForm.Text = "Clear"
        Me.btnClearForm.UseVisualStyleBackColor = True
        '
        'btnDailyTotal
        '
        Me.btnDailyTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDailyTotal.Location = New System.Drawing.Point(415, 332)
        Me.btnDailyTotal.Name = "btnDailyTotal"
        Me.btnDailyTotal.Size = New System.Drawing.Size(119, 31)
        Me.btnDailyTotal.TabIndex = 4
        Me.btnDailyTotal.Text = "Daily Total"
        Me.btnDailyTotal.UseVisualStyleBackColor = True
        '
        'lblCreditCardNumber
        '
        Me.lblCreditCardNumber.AutoSize = True
        Me.lblCreditCardNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCreditCardNumber.Location = New System.Drawing.Point(101, 150)
        Me.lblCreditCardNumber.Name = "lblCreditCardNumber"
        Me.lblCreditCardNumber.Size = New System.Drawing.Size(138, 15)
        Me.lblCreditCardNumber.TabIndex = 5
        Me.lblCreditCardNumber.Text = "Credit Card Number:"
        '
        'lblExpirationDate
        '
        Me.lblExpirationDate.AutoSize = True
        Me.lblExpirationDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExpirationDate.Location = New System.Drawing.Point(84, 187)
        Me.lblExpirationDate.Name = "lblExpirationDate"
        Me.lblExpirationDate.Size = New System.Drawing.Size(156, 15)
        Me.lblExpirationDate.TabIndex = 6
        Me.lblExpirationDate.Text = "Expiration Date(05/12):"
        '
        'lblCosts
        '
        Me.lblCosts.AutoSize = True
        Me.lblCosts.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCosts.Location = New System.Drawing.Point(193, 394)
        Me.lblCosts.Name = "lblCosts"
        Me.lblCosts.Size = New System.Drawing.Size(238, 16)
        Me.lblCosts.TabIndex = 8
        Me.lblCosts.Text = "Your total App Purchase is: $X.XX"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(152, 77)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 25)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "App Store"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.AppStorePurchase.My.Resources.Resources.app
        Me.PictureBox1.Location = New System.Drawing.Point(335, 49)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(130, 76)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'chkStudent
        '
        Me.chkStudent.AutoSize = True
        Me.chkStudent.Location = New System.Drawing.Point(87, 274)
        Me.chkStudent.Name = "chkStudent"
        Me.chkStudent.Size = New System.Drawing.Size(152, 17)
        Me.chkStudent.TabIndex = 11
        Me.chkStudent.Text = "Check if you are a Student"
        Me.chkStudent.UseVisualStyleBackColor = True
        '
        'txtCreditCard
        '
        Me.txtCreditCard.Location = New System.Drawing.Point(245, 149)
        Me.txtCreditCard.Name = "txtCreditCard"
        Me.txtCreditCard.Size = New System.Drawing.Size(220, 20)
        Me.txtCreditCard.TabIndex = 12
        '
        'txtExpirationDate
        '
        Me.txtExpirationDate.Location = New System.Drawing.Point(245, 186)
        Me.txtExpirationDate.Name = "txtExpirationDate"
        Me.txtExpirationDate.Size = New System.Drawing.Size(220, 20)
        Me.txtExpirationDate.TabIndex = 13
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleTurquoise
        Me.ClientSize = New System.Drawing.Size(615, 448)
        Me.Controls.Add(Me.txtExpirationDate)
        Me.Controls.Add(Me.txtCreditCard)
        Me.Controls.Add(Me.chkStudent)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblCosts)
        Me.Controls.Add(Me.lblExpirationDate)
        Me.Controls.Add(Me.lblCreditCardNumber)
        Me.Controls.Add(Me.btnDailyTotal)
        Me.Controls.Add(Me.btnClearForm)
        Me.Controls.Add(Me.btnFinalTotal)
        Me.Controls.Add(Me.cboPackages)
        Me.Controls.Add(Me.lblAppTitle)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblAppTitle As System.Windows.Forms.Label
    Friend WithEvents cboPackages As System.Windows.Forms.ComboBox
    Friend WithEvents btnFinalTotal As System.Windows.Forms.Button
    Friend WithEvents btnClearForm As System.Windows.Forms.Button
    Friend WithEvents btnDailyTotal As System.Windows.Forms.Button
    Friend WithEvents lblCreditCardNumber As System.Windows.Forms.Label
    Friend WithEvents lblExpirationDate As System.Windows.Forms.Label
    Friend WithEvents lblCosts As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents chkStudent As System.Windows.Forms.CheckBox
    Friend WithEvents txtCreditCard As System.Windows.Forms.TextBox
    Friend WithEvents txtExpirationDate As System.Windows.Forms.TextBox

End Class
