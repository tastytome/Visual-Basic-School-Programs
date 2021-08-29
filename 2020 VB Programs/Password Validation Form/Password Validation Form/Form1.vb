Imports System.Text.RegularExpressions

Public Class Form1

    '-- At the start of the program before any Validations, set all of 
    '--the data entry inputs to not being valid. 
    Dim blnNameValid As Boolean = False
    Dim blnPhoneNumberValid As Boolean = False
    Dim blnEmailValid As Boolean = False
    Dim blnPasswordValid As Boolean = False
    Dim blnConfirmPassword As Boolean = False

    '--Set a Master Variable where we can indicate all validations are OK 
    Dim blnAllInputDataIsValid As Boolean = False
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        '--Set the Hide Password Button (which is stacked on top of the Open Eye 
        '--Show Password Button), to be invisible and disabled from being clicked. 
        btnHidePW.Visible = False
        btnHidePW.Enabled = False

        '--Set the Hide Confirm Password Button (which is stacked on top of the Open Eye 
        '--Show Confirm Password Button), to be invisible and disabled from being clicked. 
        btnHideConfirmPW.Visible = False
        btnHideConfirmPW.Enabled = False

        '--When the Form first loads set the Properties of the Password Text Box so that 
        '--its maximum length is 20. 
        txtPassword.MaxLength = 20
        '--Set the Length of the Name text Box to be 60 characters long
        txtName.MaxLength = 60
        '--Set the Length of the Mobile Phone text Box to be 12 characters long
        txtPhone.MaxLength = 12
        '--Set the Length of the Email text Box to be 200 characters long
        txtEmail.MaxLength = 200

    End Sub

    '--VALIDATION FOR THE USER ENTERING THEIR NAME
    '--Use the KeyPress event on the NAME textbox to validate that every character the
    '--User types in is either an Upper or Lower Case Letter, or a hyphen dash, or a space, 
    '--or a backspace, or the Enter Key. 
    '--
    '--We do the checking by determining the Decimal ASCII Code value of the key that has been pressed
    '--and only allowing the following Keys: 
    '--A to Z Upper Case = ASCII values 65 to 90
    '--a to z Lower Case = ASCII values 97 to 122
    '--
    '--For names like "Watson-Smythe" or "Van Der Meer" also allow Hyphen = 45 and Space = 32 
    '--
    '--Need to also allow Backspace Key ASCII = 8 to delete any typos from the text box; 
    '--but arrow keys to move back and forth inside the Text Box always work ok without ASCII Codes.
    '--
    '--Also allow the Enter Key ASCII = 13 to be pressed. 
    '--
    '--The e.Handled = True statement tells VB the KeyPress Event has been handled by 
    '--the Program Code, and this then stops the Text Box from handling the KeyPress Event 
    '--which in turn will then stop the bad character data appearing in the Text Box.
    '--
    '--THEY COULD LEAVE THE MEMBER NAME BLANK AND SO NONE OF THE CODE BELOW WILL BE EXECUTED, 
    '--BUT WE WILL DETECT AN EMPTY NAME TEXT BOX IN THE NAME VALIDATION SUBMODULE FURTHER DOWN BELOW. 

    Private Sub txtName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtName.KeyPress

        If (Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90) Or (Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122) Or Asc(e.KeyChar) = 45 Or Asc(e.KeyChar) = 32 Or Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 13 Then
            '--The Input is okay
        Else
            e.Handled = True
            'MessageBox.Show("Enter Numbers Only", "Input Error")
        End If
        '----------------------------------

    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

        '--Each time we enter the Validation module, we need to re-check all of the text boxes  
        '--just in case the user has gone back and changed any of the previous values. 
        '--So we set all of the Validation Checks as False to force them to be redone. 

        blnNameValid = False
        blnPhoneNumberValid = False
        blnEmailValid = False
        blnPasswordValid = False
        blnConfirmPassword = False

        DoValidations()

        '--if all validation flags true...or do we add a flag for this
        '--and do the all ok flag setting down in the DoValidations() submodule 
        '--THEN we can below here just give the Member Application Form Submitted message

        If blnAllInputDataIsValid = True Then
            MessageBox.Show("Your Membership Application has been Submitted.", "Submit Successful")
            '--Now disable the Button on the Form, because the User has Submitted ok. 
            btnSubmit.Enabled = False
            '--Also disable all Text Boxes on the Form, because the User has completed it ok.
            txtName.Enabled = False
            txtPhone.Enabled = False
            txtEmail.Enabled = False
            txtPassword.Enabled = False
            txtConfirmPW.Enabled = False
        End If

    End Sub

    Public Sub DoValidations()

        '--We want the user to fill the fields out in Order on the Form from Top to Bottom: 
        '--Name, Phone, Email, Password, Confirm Password. 
        '--We then check through all of the text box fields in order, using separate submodules
        '--for each text box. 

        '--As soon as one input is flagged as not Valid, there is no point in checking
        '--the rest of the fields - eg. Get the User to fix one field box at a time. 

        If blnNameValid = False Then
            Validate_MemberName()
        End If

        '--If the Member Name is Valid, Check the Phone Number
        If blnNameValid = True And blnPhoneNumberValid = False Then
            Validate_PhoneNumber()
        End If

        '--If Member Name and Phone Valid, Check the Email
        If blnNameValid = True And blnPhoneNumberValid = True _
           And blnEmailValid = False Then
            Validate_Email()
        End If

        '--If Name, Phone, and Email Valid, Check the Password
        If blnNameValid = True And blnPhoneNumberValid = True _
           And blnEmailValid = True And blnPasswordValid = False Then
            Validate_Password()
        End If

        '--Finally, if the Name, Phone, Email, and Password are ALL VALID
        '--then check that the Confirm Password text is identical to the Password text. 
        If blnNameValid = True And blnPhoneNumberValid = True _
           And blnEmailValid = True And blnPasswordValid = True _
           And blnConfirmPassword = False Then
            Validate_ConfirmPassword()
        End If

        '--If every single field is Valid we can set the "blnAllInputDataIsValid" variable
        '--to True so that the main btnSubmit Click Module can give a successful message to the user. 

        If blnNameValid = True And blnPhoneNumberValid = True _
           And blnEmailValid = True And blnPasswordValid = True _
           And blnConfirmPassword = True Then

            blnAllInputDataIsValid = True

        End If

    End Sub

    Public Sub Validate_MemberName()
        '--We have KeyPress event Validation to make sure that they only type in
        '--Letters and Numbers, but they may have left the Name Field totally Blank. 
        '--Check the Name is not Blank, and if it is then ask them to enter it.  





        'Add the required Code here by going back And Reviewing the ASCII Codes And Regex Validations Lesson. 






    End Sub

    Public Sub Validate_PhoneNumber()

        '--We are going to use our own Custom Regular Expression, which is 
        '--a lot like making an Input Mask when doing work in MS-Access Databases.
        '--We then check that the actual data the user has entered into the Text Box 
        '--matches the data pattern which we set up in our custom Regular Expression. 





        'Add the required Code here by going back And Reviewing the ASCII Codes And Regex Validations Lesson. 






        '--Note that the above processing will also take care of existence checking, because a
        '--Blank or empty Phone Number will not pass the Regex Pattern Matching. 

        '--Also Check that the First Character of the Phone Number is a Zero. 

        Dim strPhoneNumber As String

        strPhoneNumber = txtPhone.Text

        If strPhoneNumber.Substring(0, 1) <> "0" Then
            MessageBox.Show("The first digit of the Phone Number must be Zero.", "Phone Error")
            blnPhoneNumberValid = False
            txtPhone.Focus()
        End If

    End Sub

    Public Sub Validate_Email()

        '--We are going to use our own Custom Regular Expression, which is 
        '--a lot like making an Input Mask when doing work in MS-Access Databases.
        '--We then check that the actual data the user has entered into the Text Box 
        '--matches the data pattern which we set up in our custom Regular Expression. 







        'Add the required Code here by going back And Reviewing the ASCII Codes And Regex Validations Lesson. 





    End Sub
    Public Sub Validate_Password()

        '--Copy the Password text box contents to a local program variable storage
        Dim strUserPassword As String
        strUserPassword = txtPassword.Text

        '--We will assume that the Password data could all be Invalid. 
        blnPasswordValid = False

        '--Start off by setting all of our Password Checklist Items to False
        Dim blnPasswordNotBlank As Boolean = False
        Dim blnPasswordLengthValid As Boolean = False
        Dim blnLettersAndNumbersOnly As Boolean = False
        Dim blnPasswordContainsLetters As Boolean = False
        Dim blnPasswordContainsNumbers As Boolean = False

        '--First check that the Password text Box is not Blank 
        If strUserPassword = Nothing Then
            blnPasswordNotBlank = False
            MessageBox.Show("Please type in a Password that you would like to use.", "Password Missing")
            txtPassword.Focus()
        Else
            blnPasswordNotBlank = True
        End If

        '--Next we check if the Password is 8 characters or longer 
        If strUserPassword.Length < 8 Then
            blnPasswordLengthValid = False
            MessageBox.Show("Password must be between 8 and 20 characters long.", "Password Too Short")
            txtPassword.Focus()
        Else
            blnPasswordLengthValid = True
        End If

        '--Next we check that the Password Contains only Letters and Numbers.
        '--Remember in Visual Basic that when we get substrings, the index starts at ZERO.
        '--This means we Loop from 0 to the total number of chars minus 1. 
        '--
        '--Lowercase Letters = ASCII 97 to 122
        '--Uppercase Letters = ASCII 65 to 90
        '--Number Digits 0 to 9 = ASCII 48 to 57
        '--
        '--We need to count any bad characters we find, and at the end of the Loop Checking
        '--we need this count to be Zero. 
        '--We will also count the Good Letters and Numbers as well. 

        Dim intPW_InvalidCharsCount As Integer = 0
        Dim intPW_LettersAndNumbersCount As Integer = 0


        For i = 0 To strUserPassword.Length - 1

            If (Asc(strUserPassword.Substring(i, 1)) >= 65 _
               And Asc(strUserPassword.Substring(i, 1)) <= 90) _
                Or (Asc(strUserPassword.Substring(i, 1)) >= 97 _
                And Asc(strUserPassword.Substring(i, 1)) <= 122) _
                Or (Asc(strUserPassword.Substring(i, 1)) >= 48 _
                        And Asc(strUserPassword.Substring(i, 1)) <= 57) Then

                intPW_LettersAndNumbersCount = intPW_LettersAndNumbersCount + 1
            Else
                intPW_InvalidCharsCount = intPW_InvalidCharsCount + 1
                txtPassword.Focus()
            End If

        Next

        '--If the above loop found anything that was not letters or numbers, give a Message
        '--to the user instructing them to fix the problem. 
        If intPW_InvalidCharsCount > 0 Then
            blnLettersAndNumbersOnly = False
            MessageBox.Show("Password must contain only Letters and Numbers.", "Invalid Password")
            txtPassword.Focus()
        Else
            blnLettersAndNumbersOnly = True
        End If

        '--Do an Integrity Check : Good + Invalid should match the total string length
        If (intPW_LettersAndNumbersCount + intPW_InvalidCharsCount) <> strUserPassword.Length Then
            MessageBox.Show("Password Count Error - Contact System Support.", "Password Module Fail")
            txtPassword.Focus()
        End If


        '--Next we check that the Password Contains at least one letter character
        '--because the User could have entered all letters and passed the previous check. 
        '--Remember in Visual Basic that when we get substrings, the index starts at ZERO.
        '--This means we Loop from 0 to the total number of chars minus 1. 

        Dim intPWLetterCount As Integer = 0

        For i = 0 To strUserPassword.Length - 1
            '--Check If the current character is Uppercase Letter
            If Asc(strUserPassword.Substring(i, 1)) >= 65 _
               And Asc(strUserPassword.Substring(i, 1)) <= 90 Then
                intPWLetterCount = intPWLetterCount + 1
            End If

            '--Check If the current character is Lowercase Letter
            If Asc(strUserPassword.Substring(i, 1)) >= 97 _
               And Asc(strUserPassword.Substring(i, 1)) <= 122 Then
                intPWLetterCount = intPWLetterCount + 1
            End If

        Next

        '--After the Loop has finished scanning through all the characters that the User 
        '--has entered into the Password box, check that we do not have Zero Letters. 
        '--If we have Zero letters in the Password then this is an Error. 
        If intPWLetterCount = 0 Then
            blnPasswordContainsLetters = False
            MessageBox.Show("Password must contain at least one Alphabet Letter.", "No Letters in PW")
            txtPassword.Focus()
        Else
            blnPasswordContainsLetters = True
        End If

        '--Last of all we also check that the Password Contains at least one Numerical Digit.
        '--Remember in Visual Basic that when we get substrings, the index starts at ZERO.
        '--This means we Loop AGAIN from 0 to the total number of chars minus 1. 
        '--Note that ASCII Character Codes for the Number digits 0 to 9 are 48 to 57

        'So we loop through all of the Password text box again, but this time check for numbers. 

        Dim intPWNumbersCount As Integer = 0

        For i = 0 To strUserPassword.Length - 1
            '--Check If the current character is a 0 to 9 Number
            If Asc(strUserPassword.Substring(i, 1)) >= 48 _
                   And Asc(strUserPassword.Substring(i, 1)) <= 57 Then
                intPWNumbersCount = intPWNumbersCount + 1
            End If

        Next

        '--After the Loop has finished scanning through all the characters that the User 
        '--has entered into the Password box, check if we are missing having any numbers at all. 
        '--If we have no number digits in the Password then this is an Error. 
        If intPWNumbersCount = 0 Then
            blnPasswordContainsNumbers = False
            MessageBox.Show("Password must contain at least one number value.", "No Numbers in PW")
            txtPassword.Focus()
        Else
            blnPasswordContainsNumbers = True
        End If

        '--The final check is to see if the Password has passed ALL of our Tests and is 
        '--completely valid. If it is we can set "blnPasswordValid = True" to finish PW Validation.
        '--This Information is then passed back to the MAIN DoValidation() module .

        If blnPasswordNotBlank = True _
            And blnPasswordLengthValid = True _
            And blnLettersAndNumbersOnly = True _
            And blnPasswordContainsLetters = True _
            And blnPasswordContainsNumbers = True Then

            blnPasswordValid = True

        End If

    End Sub

    Public Sub Validate_ConfirmPassword()
        '--Processing reaches here after the Password is valid, so all we need to do is 
        '--Check that the ConfirmPassword is identical to the Password then we know that 
        '--the ConfirmPassword is valid too. 

        If txtConfirmPW.Text = txtPassword.Text Then
            blnConfirmPassword = True
        Else
            blnConfirmPassword = False
            MessageBox.Show("Confirm Password does not match original Password." _
                            & vbCrLf & "Fix the Confirm Password so that it matches.", "Confirm PW Error")
        End If

    End Sub



    Private Sub btnShowPW_Click(sender As Object, e As EventArgs)
        '--When the User clicks the No Eye to Show Password Button, reset the Password text
        '--box to its default setting of having Nothing for the password hiding character. 
        txtPassword.PasswordChar = Nothing
        txtPassword.Focus()

        '--We also now want to toggle (or switch over) to the No Eye Hide Button so that 
        '--the User will be able to click it to put the Password back into Hide mode if 
        '--they want to rehide the Password. 
        btnHideConfirmPW.Visible = False
        btnHideConfirmPW.Enabled = False
        btnHidePW.Visible = True
        btnHidePW.Enabled = True

    End Sub



    Private Sub btnHidePW_Click(sender As Object, e As EventArgs)
        '--When the User clicks the Eye Icon Hide Password Button, we set the Password text
        '--box hiding function to be active by setting the Property to * or # or x etc. 
        txtPassword.PasswordChar = "*"
        txtPassword.Focus()

        '--We also now want to toggle (or switch over) to the Eye Hide Button so that 
        '--the User will be able to click it to put the Password into Show mode if 
        '--they want to show the Password.
        btnHidePW.Visible = False
        btnHidePW.Enabled = False
        btnHideConfirmPW.Visible = True
        btnHideConfirmPW.Enabled = True

    End Sub

    'Private Sub btnShowConfirmPW_Click(sender As Object, e As EventArgs) Handles btnShowConfirmPW.Click
    '--When the User clicks the No Eye toggle to Show Password Button, reset the Password text
    '--box to its default setting of having Nothing for the password hiding character. 





    'Add the required Code here by modelling what has been done for the Normal Password Show/Hide Toggle Buttons above. 







    'End Sub

    Private Sub btnHideConfirmPW_Click(sender As Object, e As EventArgs)
        '--When the User clicks the Eye toggle Hide Password Button, we set the Password text
        '--box hiding function to be active by setting the Property to * or # or x etc. 





        'Add the required Code here by modelling what has been done for the Normal Password Show/Hide Toggle Buttons above. 









    End Sub
End Class