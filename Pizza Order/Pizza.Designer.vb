<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPizza
  Inherits System.Windows.Forms.Form

  'Form overrides dispose to clean up the component list.
  <System.Diagnostics.DebuggerNonUserCode()> _
  Protected Overrides Sub Dispose(ByVal disposing As Boolean)
    If disposing AndAlso components IsNot Nothing Then
      components.Dispose()
    End If
    MyBase.Dispose(disposing)
  End Sub

  'Required by the Windows Form Designer
  Private components As System.ComponentModel.IContainer

  'NOTE: The following procedure is required by the Windows Form Designer
  'It can be modified using the Windows Form Designer.  
  'Do not modify it using the code editor.
  <System.Diagnostics.DebuggerStepThrough()> _
  Private Sub InitializeComponent()
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPizza))
    Me.grpOrder = New System.Windows.Forms.GroupBox
    Me.lblDate = New System.Windows.Forms.Label
    Me.Label3 = New System.Windows.Forms.Label
    Me.grpCustomer = New System.Windows.Forms.GroupBox
    Me.btnCancel = New System.Windows.Forms.Button
    Me.btnSave = New System.Windows.Forms.Button
    Me.btnFind = New System.Windows.Forms.Button
    Me.Label1 = New System.Windows.Forms.Label
    Me.txtPhone = New System.Windows.Forms.MaskedTextBox
    Me.txtComment = New System.Windows.Forms.TextBox
    Me.txtZip = New System.Windows.Forms.TextBox
    Me.txtState = New System.Windows.Forms.TextBox
    Me.txtCity = New System.Windows.Forms.TextBox
    Me.txtAddress = New System.Windows.Forms.TextBox
    Me.txtLastName = New System.Windows.Forms.TextBox
    Me.txtFirstName = New System.Windows.Forms.TextBox
    Me.btnExit = New System.Windows.Forms.Button
    Me.btnBuild = New System.Windows.Forms.Button
    Me.btnComplete = New System.Windows.Forms.Button
    Me.grpSize = New System.Windows.Forms.GroupBox
    Me.rdoLarge = New System.Windows.Forms.RadioButton
    Me.rdoMedium = New System.Windows.Forms.RadioButton
    Me.rdoSmall = New System.Windows.Forms.RadioButton
    Me.grpToppings = New System.Windows.Forms.GroupBox
    Me.chkAnchovies = New System.Windows.Forms.CheckBox
    Me.chkShrimp = New System.Windows.Forms.CheckBox
    Me.chkGroundBeef = New System.Windows.Forms.CheckBox
    Me.chkSausage = New System.Windows.Forms.CheckBox
    Me.chkSalami = New System.Windows.Forms.CheckBox
    Me.chkTomatoes = New System.Windows.Forms.CheckBox
    Me.chkGreenPeppers = New System.Windows.Forms.CheckBox
    Me.chkOnions = New System.Windows.Forms.CheckBox
    Me.chkBlackOlives = New System.Windows.Forms.CheckBox
    Me.chkMushrooms = New System.Windows.Forms.CheckBox
    Me.chkPepperoni = New System.Windows.Forms.CheckBox
    Me.chkCheese = New System.Windows.Forms.CheckBox
    Me.grpDeliver = New System.Windows.Forms.GroupBox
    Me.chkDeliver = New System.Windows.Forms.CheckBox
    Me.txtSpecial = New System.Windows.Forms.TextBox
    Me.Label2 = New System.Windows.Forms.Label
    Me.dlgPreview = New System.Windows.Forms.PrintPreviewDialog
    Me.grpOrder.SuspendLayout()
    Me.grpCustomer.SuspendLayout()
    Me.grpSize.SuspendLayout()
    Me.grpToppings.SuspendLayout()
    Me.grpDeliver.SuspendLayout()
    Me.SuspendLayout()
    '
    'grpOrder
    '
    Me.grpOrder.Controls.Add(Me.lblDate)
    Me.grpOrder.Controls.Add(Me.Label3)
    Me.grpOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.grpOrder.Location = New System.Drawing.Point(12, 1)
    Me.grpOrder.Name = "grpOrder"
    Me.grpOrder.Size = New System.Drawing.Size(188, 41)
    Me.grpOrder.TabIndex = 0
    Me.grpOrder.TabStop = False
    '
    'lblDate
    '
    Me.lblDate.BackColor = System.Drawing.Color.White
    Me.lblDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
    Me.lblDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblDate.Location = New System.Drawing.Point(86, 14)
    Me.lblDate.Name = "lblDate"
    Me.lblDate.Size = New System.Drawing.Size(88, 17)
    Me.lblDate.TabIndex = 5
    Me.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label3.Location = New System.Drawing.Point(6, 18)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(69, 13)
    Me.Label3.TabIndex = 3
    Me.Label3.Text = "Order Date"
    '
    'grpCustomer
    '
    Me.grpCustomer.Controls.Add(Me.btnCancel)
    Me.grpCustomer.Controls.Add(Me.btnSave)
    Me.grpCustomer.Controls.Add(Me.btnFind)
    Me.grpCustomer.Controls.Add(Me.Label1)
    Me.grpCustomer.Controls.Add(Me.txtPhone)
    Me.grpCustomer.Controls.Add(Me.txtComment)
    Me.grpCustomer.Controls.Add(Me.txtZip)
    Me.grpCustomer.Controls.Add(Me.txtState)
    Me.grpCustomer.Controls.Add(Me.txtCity)
    Me.grpCustomer.Controls.Add(Me.txtAddress)
    Me.grpCustomer.Controls.Add(Me.txtLastName)
    Me.grpCustomer.Controls.Add(Me.txtFirstName)
    Me.grpCustomer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.grpCustomer.Location = New System.Drawing.Point(12, 48)
    Me.grpCustomer.Name = "grpCustomer"
    Me.grpCustomer.Size = New System.Drawing.Size(254, 211)
    Me.grpCustomer.TabIndex = 17
    Me.grpCustomer.TabStop = False
    '
    'btnCancel
    '
    Me.btnCancel.Location = New System.Drawing.Point(130, 179)
    Me.btnCancel.Name = "btnCancel"
    Me.btnCancel.Size = New System.Drawing.Size(64, 23)
    Me.btnCancel.TabIndex = 28
    Me.btnCancel.Text = "Cancel"
    Me.btnCancel.UseVisualStyleBackColor = True
    Me.btnCancel.Visible = False
    '
    'btnSave
    '
    Me.btnSave.Location = New System.Drawing.Point(60, 179)
    Me.btnSave.Name = "btnSave"
    Me.btnSave.Size = New System.Drawing.Size(64, 23)
    Me.btnSave.TabIndex = 27
    Me.btnSave.Text = "Save"
    Me.btnSave.UseVisualStyleBackColor = True
    Me.btnSave.Visible = False
    '
    'btnFind
    '
    Me.btnFind.Location = New System.Drawing.Point(152, 14)
    Me.btnFind.Name = "btnFind"
    Me.btnFind.Size = New System.Drawing.Size(88, 23)
    Me.btnFind.TabIndex = 26
    Me.btnFind.Text = "Find Customer"
    Me.btnFind.UseVisualStyleBackColor = True
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label1.Location = New System.Drawing.Point(6, 20)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(43, 13)
    Me.Label1.TabIndex = 25
    Me.Label1.Text = "Phone"
    '
    'txtPhone
    '
    Me.txtPhone.Location = New System.Drawing.Point(55, 17)
    Me.txtPhone.Mask = "(###) ###-####"
    Me.txtPhone.Name = "txtPhone"
    Me.txtPhone.Size = New System.Drawing.Size(91, 20)
    Me.txtPhone.TabIndex = 24
    '
    'txtComment
    '
    Me.txtComment.BackColor = System.Drawing.Color.White
    Me.txtComment.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtComment.Location = New System.Drawing.Point(9, 121)
    Me.txtComment.Multiline = True
    Me.txtComment.Name = "txtComment"
    Me.txtComment.Size = New System.Drawing.Size(231, 52)
    Me.txtComment.TabIndex = 23
    Me.txtComment.Visible = False
    '
    'txtZip
    '
    Me.txtZip.BackColor = System.Drawing.Color.White
    Me.txtZip.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtZip.Location = New System.Drawing.Point(181, 95)
    Me.txtZip.Name = "txtZip"
    Me.txtZip.Size = New System.Drawing.Size(59, 20)
    Me.txtZip.TabIndex = 22
    Me.txtZip.Visible = False
    '
    'txtState
    '
    Me.txtState.BackColor = System.Drawing.Color.White
    Me.txtState.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtState.Location = New System.Drawing.Point(130, 95)
    Me.txtState.Name = "txtState"
    Me.txtState.Size = New System.Drawing.Size(44, 20)
    Me.txtState.TabIndex = 21
    Me.txtState.Visible = False
    '
    'txtCity
    '
    Me.txtCity.BackColor = System.Drawing.Color.White
    Me.txtCity.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtCity.Location = New System.Drawing.Point(9, 95)
    Me.txtCity.Name = "txtCity"
    Me.txtCity.Size = New System.Drawing.Size(115, 20)
    Me.txtCity.TabIndex = 20
    Me.txtCity.Visible = False
    '
    'txtAddress
    '
    Me.txtAddress.BackColor = System.Drawing.Color.White
    Me.txtAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtAddress.Location = New System.Drawing.Point(9, 69)
    Me.txtAddress.Name = "txtAddress"
    Me.txtAddress.Size = New System.Drawing.Size(231, 20)
    Me.txtAddress.TabIndex = 19
    Me.txtAddress.Visible = False
    '
    'txtLastName
    '
    Me.txtLastName.BackColor = System.Drawing.Color.White
    Me.txtLastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtLastName.Location = New System.Drawing.Point(95, 43)
    Me.txtLastName.Name = "txtLastName"
    Me.txtLastName.Size = New System.Drawing.Size(145, 20)
    Me.txtLastName.TabIndex = 18
    Me.txtLastName.Visible = False
    '
    'txtFirstName
    '
    Me.txtFirstName.BackColor = System.Drawing.Color.White
    Me.txtFirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtFirstName.Location = New System.Drawing.Point(9, 43)
    Me.txtFirstName.Name = "txtFirstName"
    Me.txtFirstName.Size = New System.Drawing.Size(80, 20)
    Me.txtFirstName.TabIndex = 17
    Me.txtFirstName.Visible = False
    '
    'btnExit
    '
    Me.btnExit.Location = New System.Drawing.Point(491, 208)
    Me.btnExit.Name = "btnExit"
    Me.btnExit.Size = New System.Drawing.Size(102, 23)
    Me.btnExit.TabIndex = 18
    Me.btnExit.Text = "Exit"
    Me.btnExit.UseVisualStyleBackColor = True
    '
    'btnBuild
    '
    Me.btnBuild.Enabled = False
    Me.btnBuild.Location = New System.Drawing.Point(275, 208)
    Me.btnBuild.Name = "btnBuild"
    Me.btnBuild.Size = New System.Drawing.Size(102, 23)
    Me.btnBuild.TabIndex = 19
    Me.btnBuild.Text = "Build Pizza"
    Me.btnBuild.UseVisualStyleBackColor = True
    '
    'btnComplete
    '
    Me.btnComplete.Enabled = False
    Me.btnComplete.Location = New System.Drawing.Point(383, 208)
    Me.btnComplete.Name = "btnComplete"
    Me.btnComplete.Size = New System.Drawing.Size(102, 23)
    Me.btnComplete.TabIndex = 20
    Me.btnComplete.Text = "Order Complete"
    Me.btnComplete.UseVisualStyleBackColor = True
    '
    'grpSize
    '
    Me.grpSize.Controls.Add(Me.rdoLarge)
    Me.grpSize.Controls.Add(Me.rdoMedium)
    Me.grpSize.Controls.Add(Me.rdoSmall)
    Me.grpSize.Enabled = False
    Me.grpSize.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.grpSize.Location = New System.Drawing.Point(272, 1)
    Me.grpSize.Name = "grpSize"
    Me.grpSize.Size = New System.Drawing.Size(90, 99)
    Me.grpSize.TabIndex = 21
    Me.grpSize.TabStop = False
    Me.grpSize.Text = "Size"
    '
    'rdoLarge
    '
    Me.rdoLarge.AutoSize = True
    Me.rdoLarge.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.rdoLarge.Location = New System.Drawing.Point(15, 69)
    Me.rdoLarge.Name = "rdoLarge"
    Me.rdoLarge.Size = New System.Drawing.Size(52, 17)
    Me.rdoLarge.TabIndex = 2
    Me.rdoLarge.Text = "Large"
    Me.rdoLarge.UseVisualStyleBackColor = True
    '
    'rdoMedium
    '
    Me.rdoMedium.AutoSize = True
    Me.rdoMedium.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.rdoMedium.Location = New System.Drawing.Point(15, 46)
    Me.rdoMedium.Name = "rdoMedium"
    Me.rdoMedium.Size = New System.Drawing.Size(62, 17)
    Me.rdoMedium.TabIndex = 1
    Me.rdoMedium.Text = "Medium"
    Me.rdoMedium.UseVisualStyleBackColor = True
    '
    'rdoSmall
    '
    Me.rdoSmall.AutoSize = True
    Me.rdoSmall.Checked = True
    Me.rdoSmall.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.rdoSmall.Location = New System.Drawing.Point(15, 23)
    Me.rdoSmall.Name = "rdoSmall"
    Me.rdoSmall.Size = New System.Drawing.Size(50, 17)
    Me.rdoSmall.TabIndex = 0
    Me.rdoSmall.TabStop = True
    Me.rdoSmall.Text = "Small"
    Me.rdoSmall.UseVisualStyleBackColor = True
    '
    'grpToppings
    '
    Me.grpToppings.Controls.Add(Me.chkAnchovies)
    Me.grpToppings.Controls.Add(Me.chkShrimp)
    Me.grpToppings.Controls.Add(Me.chkGroundBeef)
    Me.grpToppings.Controls.Add(Me.chkSausage)
    Me.grpToppings.Controls.Add(Me.chkSalami)
    Me.grpToppings.Controls.Add(Me.chkTomatoes)
    Me.grpToppings.Controls.Add(Me.chkGreenPeppers)
    Me.grpToppings.Controls.Add(Me.chkOnions)
    Me.grpToppings.Controls.Add(Me.chkBlackOlives)
    Me.grpToppings.Controls.Add(Me.chkMushrooms)
    Me.grpToppings.Controls.Add(Me.chkPepperoni)
    Me.grpToppings.Controls.Add(Me.chkCheese)
    Me.grpToppings.Enabled = False
    Me.grpToppings.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.grpToppings.Location = New System.Drawing.Point(368, 1)
    Me.grpToppings.Name = "grpToppings"
    Me.grpToppings.Size = New System.Drawing.Size(225, 163)
    Me.grpToppings.TabIndex = 22
    Me.grpToppings.TabStop = False
    Me.grpToppings.Text = "Toppings"
    '
    'chkAnchovies
    '
    Me.chkAnchovies.AutoSize = True
    Me.chkAnchovies.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.chkAnchovies.Location = New System.Drawing.Point(109, 140)
    Me.chkAnchovies.Name = "chkAnchovies"
    Me.chkAnchovies.Size = New System.Drawing.Size(76, 17)
    Me.chkAnchovies.TabIndex = 12
    Me.chkAnchovies.Text = "Anchovies"
    Me.chkAnchovies.UseVisualStyleBackColor = True
    '
    'chkShrimp
    '
    Me.chkShrimp.AutoSize = True
    Me.chkShrimp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.chkShrimp.Location = New System.Drawing.Point(109, 116)
    Me.chkShrimp.Name = "chkShrimp"
    Me.chkShrimp.Size = New System.Drawing.Size(58, 17)
    Me.chkShrimp.TabIndex = 11
    Me.chkShrimp.Text = "Shrimp"
    Me.chkShrimp.UseVisualStyleBackColor = True
    '
    'chkGroundBeef
    '
    Me.chkGroundBeef.AutoSize = True
    Me.chkGroundBeef.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.chkGroundBeef.Location = New System.Drawing.Point(109, 92)
    Me.chkGroundBeef.Name = "chkGroundBeef"
    Me.chkGroundBeef.Size = New System.Drawing.Size(86, 17)
    Me.chkGroundBeef.TabIndex = 10
    Me.chkGroundBeef.Text = "Ground Beef"
    Me.chkGroundBeef.UseVisualStyleBackColor = True
    '
    'chkSausage
    '
    Me.chkSausage.AutoSize = True
    Me.chkSausage.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.chkSausage.Location = New System.Drawing.Point(109, 69)
    Me.chkSausage.Name = "chkSausage"
    Me.chkSausage.Size = New System.Drawing.Size(68, 17)
    Me.chkSausage.TabIndex = 9
    Me.chkSausage.Text = "Sausage"
    Me.chkSausage.UseVisualStyleBackColor = True
    '
    'chkSalami
    '
    Me.chkSalami.AutoSize = True
    Me.chkSalami.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.chkSalami.Location = New System.Drawing.Point(109, 47)
    Me.chkSalami.Name = "chkSalami"
    Me.chkSalami.Size = New System.Drawing.Size(57, 17)
    Me.chkSalami.TabIndex = 8
    Me.chkSalami.Text = "Salami"
    Me.chkSalami.UseVisualStyleBackColor = True
    '
    'chkTomatoes
    '
    Me.chkTomatoes.AutoSize = True
    Me.chkTomatoes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.chkTomatoes.Location = New System.Drawing.Point(6, 140)
    Me.chkTomatoes.Name = "chkTomatoes"
    Me.chkTomatoes.Size = New System.Drawing.Size(73, 17)
    Me.chkTomatoes.TabIndex = 7
    Me.chkTomatoes.Text = "Tomatoes"
    Me.chkTomatoes.UseVisualStyleBackColor = True
    '
    'chkGreenPeppers
    '
    Me.chkGreenPeppers.AutoSize = True
    Me.chkGreenPeppers.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.chkGreenPeppers.Location = New System.Drawing.Point(6, 116)
    Me.chkGreenPeppers.Name = "chkGreenPeppers"
    Me.chkGreenPeppers.Size = New System.Drawing.Size(97, 17)
    Me.chkGreenPeppers.TabIndex = 6
    Me.chkGreenPeppers.Text = "Green Peppers"
    Me.chkGreenPeppers.UseVisualStyleBackColor = True
    '
    'chkOnions
    '
    Me.chkOnions.AutoSize = True
    Me.chkOnions.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.chkOnions.Location = New System.Drawing.Point(6, 92)
    Me.chkOnions.Name = "chkOnions"
    Me.chkOnions.Size = New System.Drawing.Size(59, 17)
    Me.chkOnions.TabIndex = 5
    Me.chkOnions.Text = "Onions"
    Me.chkOnions.UseVisualStyleBackColor = True
    '
    'chkBlackOlives
    '
    Me.chkBlackOlives.AutoSize = True
    Me.chkBlackOlives.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.chkBlackOlives.Location = New System.Drawing.Point(6, 69)
    Me.chkBlackOlives.Name = "chkBlackOlives"
    Me.chkBlackOlives.Size = New System.Drawing.Size(85, 17)
    Me.chkBlackOlives.TabIndex = 4
    Me.chkBlackOlives.Text = "Black Olives"
    Me.chkBlackOlives.UseVisualStyleBackColor = True
    '
    'chkMushrooms
    '
    Me.chkMushrooms.AutoSize = True
    Me.chkMushrooms.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.chkMushrooms.Location = New System.Drawing.Point(6, 46)
    Me.chkMushrooms.Name = "chkMushrooms"
    Me.chkMushrooms.Size = New System.Drawing.Size(80, 17)
    Me.chkMushrooms.TabIndex = 3
    Me.chkMushrooms.Text = "Mushrooms"
    Me.chkMushrooms.UseVisualStyleBackColor = True
    '
    'chkPepperoni
    '
    Me.chkPepperoni.AutoSize = True
    Me.chkPepperoni.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.chkPepperoni.Location = New System.Drawing.Point(109, 23)
    Me.chkPepperoni.Name = "chkPepperoni"
    Me.chkPepperoni.Size = New System.Drawing.Size(74, 17)
    Me.chkPepperoni.TabIndex = 2
    Me.chkPepperoni.Text = "Pepperoni"
    Me.chkPepperoni.UseVisualStyleBackColor = True
    '
    'chkCheese
    '
    Me.chkCheese.AutoSize = True
    Me.chkCheese.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.chkCheese.Location = New System.Drawing.Point(6, 23)
    Me.chkCheese.Name = "chkCheese"
    Me.chkCheese.Size = New System.Drawing.Size(89, 17)
    Me.chkCheese.TabIndex = 1
    Me.chkCheese.Text = "Extra Cheese"
    Me.chkCheese.UseVisualStyleBackColor = True
    '
    'grpDeliver
    '
    Me.grpDeliver.Controls.Add(Me.chkDeliver)
    Me.grpDeliver.Enabled = False
    Me.grpDeliver.Location = New System.Drawing.Point(272, 106)
    Me.grpDeliver.Name = "grpDeliver"
    Me.grpDeliver.Size = New System.Drawing.Size(90, 45)
    Me.grpDeliver.TabIndex = 23
    Me.grpDeliver.TabStop = False
    '
    'chkDeliver
    '
    Me.chkDeliver.AutoSize = True
    Me.chkDeliver.Location = New System.Drawing.Point(15, 19)
    Me.chkDeliver.Name = "chkDeliver"
    Me.chkDeliver.Size = New System.Drawing.Size(59, 17)
    Me.chkDeliver.TabIndex = 0
    Me.chkDeliver.Text = "Deliver"
    Me.chkDeliver.UseVisualStyleBackColor = True
    '
    'txtSpecial
    '
    Me.txtSpecial.BackColor = System.Drawing.Color.White
    Me.txtSpecial.Enabled = False
    Me.txtSpecial.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtSpecial.Location = New System.Drawing.Point(275, 170)
    Me.txtSpecial.Multiline = True
    Me.txtSpecial.Name = "txtSpecial"
    Me.txtSpecial.Size = New System.Drawing.Size(318, 32)
    Me.txtSpecial.TabIndex = 24
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label2.Location = New System.Drawing.Point(272, 154)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(79, 13)
    Me.Label2.TabIndex = 25
    Me.Label2.Text = "Special Info:"
    '
    'dlgPreview
    '
    Me.dlgPreview.AutoScrollMargin = New System.Drawing.Size(0, 0)
    Me.dlgPreview.AutoScrollMinSize = New System.Drawing.Size(0, 0)
    Me.dlgPreview.ClientSize = New System.Drawing.Size(400, 300)
    Me.dlgPreview.Enabled = True
    Me.dlgPreview.Icon = CType(resources.GetObject("dlgPreview.Icon"), System.Drawing.Icon)
    Me.dlgPreview.Name = "dlgPreview"
    Me.dlgPreview.Visible = False
    '
    'frmPizza
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(606, 266)
    Me.ControlBox = False
    Me.Controls.Add(Me.Label2)
    Me.Controls.Add(Me.txtSpecial)
    Me.Controls.Add(Me.grpDeliver)
    Me.Controls.Add(Me.grpToppings)
    Me.Controls.Add(Me.grpSize)
    Me.Controls.Add(Me.btnComplete)
    Me.Controls.Add(Me.btnBuild)
    Me.Controls.Add(Me.btnExit)
    Me.Controls.Add(Me.grpCustomer)
    Me.Controls.Add(Me.grpOrder)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
    Me.Name = "frmPizza"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Pizza Order #0000"
    Me.grpOrder.ResumeLayout(False)
    Me.grpOrder.PerformLayout()
    Me.grpCustomer.ResumeLayout(False)
    Me.grpCustomer.PerformLayout()
    Me.grpSize.ResumeLayout(False)
    Me.grpSize.PerformLayout()
    Me.grpToppings.ResumeLayout(False)
    Me.grpToppings.PerformLayout()
    Me.grpDeliver.ResumeLayout(False)
    Me.grpDeliver.PerformLayout()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents grpOrder As System.Windows.Forms.GroupBox
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents grpCustomer As System.Windows.Forms.GroupBox
  Friend WithEvents txtZip As System.Windows.Forms.TextBox
  Friend WithEvents txtState As System.Windows.Forms.TextBox
  Friend WithEvents txtCity As System.Windows.Forms.TextBox
  Friend WithEvents txtAddress As System.Windows.Forms.TextBox
  Friend WithEvents txtLastName As System.Windows.Forms.TextBox
  Friend WithEvents txtFirstName As System.Windows.Forms.TextBox
  Friend WithEvents lblDate As System.Windows.Forms.Label
  Friend WithEvents txtPhone As System.Windows.Forms.MaskedTextBox
  Friend WithEvents txtComment As System.Windows.Forms.TextBox
  Friend WithEvents btnFind As System.Windows.Forms.Button
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents btnExit As System.Windows.Forms.Button
  Friend WithEvents btnBuild As System.Windows.Forms.Button
  Friend WithEvents btnComplete As System.Windows.Forms.Button
  Friend WithEvents grpSize As System.Windows.Forms.GroupBox
  Friend WithEvents grpToppings As System.Windows.Forms.GroupBox
  Friend WithEvents grpDeliver As System.Windows.Forms.GroupBox
  Friend WithEvents txtSpecial As System.Windows.Forms.TextBox
  Friend WithEvents rdoLarge As System.Windows.Forms.RadioButton
  Friend WithEvents rdoMedium As System.Windows.Forms.RadioButton
  Friend WithEvents rdoSmall As System.Windows.Forms.RadioButton
  Friend WithEvents chkAnchovies As System.Windows.Forms.CheckBox
  Friend WithEvents chkShrimp As System.Windows.Forms.CheckBox
  Friend WithEvents chkGroundBeef As System.Windows.Forms.CheckBox
  Friend WithEvents chkSausage As System.Windows.Forms.CheckBox
  Friend WithEvents chkSalami As System.Windows.Forms.CheckBox
  Friend WithEvents chkTomatoes As System.Windows.Forms.CheckBox
  Friend WithEvents chkGreenPeppers As System.Windows.Forms.CheckBox
  Friend WithEvents chkOnions As System.Windows.Forms.CheckBox
  Friend WithEvents chkBlackOlives As System.Windows.Forms.CheckBox
  Friend WithEvents chkMushrooms As System.Windows.Forms.CheckBox
  Friend WithEvents chkPepperoni As System.Windows.Forms.CheckBox
  Friend WithEvents chkCheese As System.Windows.Forms.CheckBox
  Friend WithEvents chkDeliver As System.Windows.Forms.CheckBox
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents dlgPreview As System.Windows.Forms.PrintPreviewDialog
  Friend WithEvents btnCancel As System.Windows.Forms.Button
  Friend WithEvents btnSave As System.Windows.Forms.Button

End Class
