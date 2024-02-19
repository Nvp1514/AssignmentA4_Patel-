<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmBurgers
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBurgers))
        lblHeading = New Label()
        picPrime = New PictureBox()
        picVeggie = New PictureBox()
        btnSelectMeal = New Button()
        btnPrime = New Button()
        btnVeggie = New Button()
        btnExit = New Button()
        lblInstructions = New Label()
        lblConfirmation = New Label()
        CType(picPrime, ComponentModel.ISupportInitialize).BeginInit()
        CType(picVeggie, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblHeading
        ' 
        lblHeading.AutoSize = True
        lblHeading.Font = New Font("Tahoma", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblHeading.Location = New Point(298, 26)
        lblHeading.Name = "lblHeading"
        lblHeading.Size = New Size(239, 25)
        lblHeading.TabIndex = 0
        lblHeading.Text = "Farm Burger Specials "
        lblHeading.TextAlign = ContentAlignment.TopCenter
        ' 
        ' picPrime
        ' 
        picPrime.Image = CType(resources.GetObject("picPrime.Image"), Image)
        picPrime.Location = New Point(114, 79)
        picPrime.Name = "picPrime"
        picPrime.Size = New Size(260, 250)
        picPrime.SizeMode = PictureBoxSizeMode.StretchImage
        picPrime.TabIndex = 1
        picPrime.TabStop = False
        ' 
        ' picVeggie
        ' 
        picVeggie.Image = CType(resources.GetObject("picVeggie.Image"), Image)
        picVeggie.Location = New Point(457, 79)
        picVeggie.Name = "picVeggie"
        picVeggie.Size = New Size(260, 250)
        picVeggie.SizeMode = PictureBoxSizeMode.StretchImage
        picVeggie.TabIndex = 2
        picVeggie.TabStop = False
        ' 
        ' btnSelectMeal
        ' 
        btnSelectMeal.Enabled = False
        btnSelectMeal.Font = New Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnSelectMeal.Location = New Point(350, 365)
        btnSelectMeal.Name = "btnSelectMeal"
        btnSelectMeal.Size = New Size(128, 35)
        btnSelectMeal.TabIndex = 3
        btnSelectMeal.Text = "Select Meal"
        btnSelectMeal.UseVisualStyleBackColor = True
        ' 
        ' btnPrime
        ' 
        btnPrime.Font = New Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnPrime.Location = New Point(171, 365)
        btnPrime.Name = "btnPrime"
        btnPrime.Size = New Size(128, 35)
        btnPrime.TabIndex = 4
        btnPrime.Text = "Prime Beef"
        btnPrime.UseVisualStyleBackColor = True
        ' 
        ' btnVeggie
        ' 
        btnVeggie.Font = New Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnVeggie.Location = New Point(543, 365)
        btnVeggie.Name = "btnVeggie"
        btnVeggie.Size = New Size(128, 35)
        btnVeggie.TabIndex = 5
        btnVeggie.Text = "Veggie"
        btnVeggie.UseVisualStyleBackColor = True
        ' 
        ' btnExit
        ' 
        btnExit.Enabled = False
        btnExit.Font = New Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnExit.Location = New Point(350, 504)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(128, 35)
        btnExit.TabIndex = 6
        btnExit.Text = "Exit"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' lblInstructions
        ' 
        lblInstructions.AutoSize = True
        lblInstructions.Font = New Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblInstructions.Location = New Point(269, 422)
        lblInstructions.Name = "lblInstructions"
        lblInstructions.Size = New Size(308, 14)
        lblInstructions.TabIndex = 7
        lblInstructions.Text = "Choose a burger and then click the Select Meal button"
        ' 
        ' lblConfirmation
        ' 
        lblConfirmation.AutoSize = True
        lblConfirmation.Font = New Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblConfirmation.Location = New Point(336, 462)
        lblConfirmation.Name = "lblConfirmation"
        lblConfirmation.Size = New Size(158, 14)
        lblConfirmation.TabIndex = 8
        lblConfirmation.Text = "Enjoy your Burger Special ! "
        lblConfirmation.Visible = False
        ' 
        ' frmBurgers
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(784, 551)
        Controls.Add(lblConfirmation)
        Controls.Add(lblInstructions)
        Controls.Add(btnExit)
        Controls.Add(btnVeggie)
        Controls.Add(btnPrime)
        Controls.Add(btnSelectMeal)
        Controls.Add(picVeggie)
        Controls.Add(picPrime)
        Controls.Add(lblHeading)
        Name = "frmBurgers"
        Text = "Burger Specials "
        CType(picPrime, ComponentModel.ISupportInitialize).EndInit()
        CType(picVeggie, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblHeading As Label
    Friend WithEvents picPrime As PictureBox
    Friend WithEvents picVeggie As PictureBox
    Friend WithEvents btnSelectMeal As Button
    Friend WithEvents btnPrime As Button
    Friend WithEvents btnVeggie As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblInstructions As Label
    Friend WithEvents lblConfirmation As Label

End Class
