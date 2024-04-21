function CheckForm() {

    var uName = document.getElementById("username").value;
    var msg = "";
    var msg = "";
    if (uName.length < 6)
        msg = "user name does not exist or too short"
    else if (uName.length > 30)
        msg = "user name must have 6-30 letters"
    else if (isHebrew(uName))
        msg = "user name can not be in hebrew";
    else if (isQuot(uName))
        msg = "user name must not have chars like Punctuation";
    else if (isBadChars(uName))
        msg = "user name must be only in english and in letters";
    if (msg != "") {
        document.getElementById("mUName").value = msg;
        document.getElementById("mUName").style.display = "inline";

        return false;
    }
    else document.getElementById("mUName").style.display = "none";

    //---------------------------------------------------------------------

    var fName = document.getElementById("firstName").value;
    if (fName.length < 2 || fName.length > 10) {
        document.getElementById("mFName").value = "First Name must be between 5-10 Characters!";
        document.getElementById("mFName").style.display = "inline";

        return false;
    }
    else document.getElementById("mFName").style.display = "none";

    //---------------------------------------------------------------------

    var lName = document.getElementById("lastName").value;
    if (lName.length < 5 || lName.length > 10) {
        document.getElementById("mLName").value = "Last Name must be between 5-10 Characters!";
        document.getElementById("mLName").style.display = "inline";

        return false;
    }
    else document.getElementById("mLName").style.display = "none";

    //---------------------------------------------------------------------

    var mail = document.getElementById("email").value;
    var msg = "";
    var atSign = mail.indexOf('@');
    var dotSign = mail.indexOf('.', atSign);

    if (mail.length < 6)
        msg = "The email address is too short!";
    else if (mail.length > 30)
        msg = "The email address has to be between 6-30 letters!";
    else if (isQuot(mail) || isBadChars(mail))
        msg = "Email dose include forbidden chars"
    else if (atSign == -1 || atSign != mail.lastIndexOf('@'))
        msg = "The Email Adress must have exactly One @";
    else if (dotSign == -1)
        msg = "The Email Adress must have a dot after the email!";
    else if (dotSign - atSign < 2)
        msg = "The dot must appear 2 characters after the @!";
    else if (dotSign == mail.length - 1 || mail.indexOf('.') == 0)
        msg = "The dot cannot appear at the beginning or end!";
    else if (atSign == 0 || atSign == mail.length - 1)
        msg = "The @ sign cannot appear at the beginning or end!";

    if (msg != "") {
        document.getElementById("mEmail").value = msg;
        document.getElementById("mEmail").style.display = "inline";

        return false;
    }
    else document.getElementById("mEmail").style.display = "none";

    //---------------------------------------------------------------------

    var phone = document.getElementById("Phone").value;
    if (phone.length != 7) {
        document.getElementById("mPhone").value = "Phone number must dip exactly 7 digits!";
        document.getElementById("mPhone").style.display = "inline";

        return false;
    }
    else document.getElementById("mPhone").style.display = "none";

    //---------------------------------------------------------------------

    var hobies = document.getElementsByName("hobies");
    var hobChecked = false;

    for (var i = 0; i < hobies.length; i++)
        if (hobies[i].checked) hobChecked = true;

    if (hobChecked == false) {
        document.getElementById("mHobies").value = "Choose a Hobby!"
        document.getElementById("mHobies").style.display = "inline";
        return false;
    }

    else document.getElementById("mHobies").style.display = "none";

    //---------------------------------------------------------------------

    var pw = document.getElementById("password").value;
    var pw1 = document.getElementById("rePassword").value;
    if (pw.length < 8 || pw.length > 10) {
        msg = "the password must be between 8-10 characters!";
        document.getElementById("mPassword").value = msg;
        document.getElementById("mPassword").style.display = "inline";

        return false;
    }
    else document.getElementById("mPassword").style.display = "none";

    if (pw != pw1) {
        msg = "The password and the authentication password are not the same!";
        document.getElementById("mPassword").value = msg;
        document.getElementById("mPassword").style.display = "inline";

        return false;
    }
    else document.getElementById("mPassword").style.display = "none";

    // everything is checked and is fine!
    return true;

}

/// check if there are forbidden chars like {''}
function isQuot(str) {
    var quot = '\"', quot1 = "\'";
    if (str.indexOf(quot) != -1 || str.indexOf(quot1) != -1)
        return true;
    return false;
}

// check if contains forbidden chars like exist:"$%^&*()-! []{}<>?
function isBadChars(str) {
    var badChr = "$%^&*()-! []{}<>?";
    var len = badChr.length;
    var i = 0, pos, ch;
    while (i < len) {
        ch = badChr.charAt(i);
        pos = str.indexOf(ch);
        if (pos != -1)
            return true;
        i++;
    }
    return false;
}

// check letters in hebrew
function isHebrew(str) {
    for (var i = 0; i < str.length; i++) {
        if (str.charAt(i) >= 'א'(str.charAt(i) <= 'ת'))

            return true;
    }

}