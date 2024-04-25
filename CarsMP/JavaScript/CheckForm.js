function CheckForm() {

    var uName = document.getElementById("username").value;
    if (!userNameOK(uName)) return false;

//----------------------------------------------------------------------

    var fName = document.getElementById("firstName").value;
    if (fName.length < 5 || fName.length > 10) {
        document.getElementById("mFName").value = "First Name must be between 5-10 Characters!";
        document.getElementById("mFName").style.display = "inline";
        return false;
    }
    else document.getElementById("mFName").style.display = "none";

//----------------------------------------------------------------------

    var lName = document.getElementById("lastName").value;
    if (lName.length < 5 || lName.length > 10) {
        document.getElementById("mLName").value = "Last Name must be between 5-10 Characters!";
        document.getElementById("mLName").style.display = "inline";
        return false;
    }
    else document.getElementById("mLName").style.display = "none";

//----------------------------------------------------------------------

    var email = document.getElementById("email").value;
    if (!emailOK(email)) return false;

//----------------------------------------------------------------------

    var phone = document.getElementById("Phone").value;
    if (phone.length != 7) {
        document.getElementById("mPhone").value = "Phone Number must be 7 numbers only";
        document.getElementById("mPhone").style.display = "inline";
        return false;
    }
    else document.getElementById("mPhone").style.display = "none";
    if (isNaN(phone)) {
        document.getElementById("mPhone").value = "Phone Number must only contain Numbers";
        document.getElementById("mPhone").style.display = "inline";
        return false;
    }
    else document.getElementById("mPhone").style.display = "none";

//------------------------------------------------------------------------------

    var hobies = document.getElementsByName("hobies");
    var hobChecked = false;

    for (var i = 0; i < hobies.length; i++)
        if (hobies[i].checked) hobChecked = true;

    if (hobChecked == false) {
        document.getElementById("mHobies").value = "Choose at least one hobby";
        document.getElementById("mHobies").style.display = "inline";
        return false;
    }
    else document.getElementById("mHobies").style.display = "none";

//----------------------------------------------------------------------

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

//----------------------------------------------------------------------

    // everything is checked and is fine!
    return true;

}


// Extra functions/methods for checking!
// 🠗
// 🠗

function userNameOK(name) {

    var msg = "";

    if (name.length < 6)
        msg = "Username is too short";
    else if (name.length > 30)
        msg = "Username must be between 6-30 characters";
    else if (isHebrew(name))
        msg = "Username must only be in english";
    else if (isQuot(name))
        msg = "Username cannot contain apostrophes or hyphens";
    else if (isBadChars(name))
        msg = "Username can contain English letters and/or numbers only";

    if (msg != "") {
        document.getElementById("mUName").value = msg;
        document.getElementById("mUName").style.display = "inline";
        return false;
    }
    else document.getElementById("mUName").style.display = "none";

    return true;

}

function emailOK(mail) {

    var msg = "";
    var atSign = mail.indexOf('@');
    var dotSign = mail.indexOf('.', atSign);

    if (mail.length < 6)
        msg = "Email Address is too short";
    else if (mail.length > 30)
        msg = "Email Address must be between 6-30 characters";
    else if (isHebrew(mail))
        msg = "Email Address must only be in english";
    else if (isQuot(mail) || isBadChars(mail))
        msg = "Email address contains invalid characters";

    else if (atSign == -1 || atSign != mail.lastIndexOf('@'))
        msg = "Email address must contain exactly one @";
    else if (dotSign == -1)
        msg = "Email address must contain at least one period";
    else if (dotSign - atSign < 2)
        msg = "The dot must appear at least 2 characters after @";

    else if (dotSign == mail.length - 1 || mail.indexOf('.') == 0)
        msg = "The dot cannot appear at the beginning or end of the address";
    else if (atSign == 0 || atSign == mail.length - 1)
        msg = "The @ sign cannot appear at the beginning or end of the address";

    if (msg != "") {
        document.getElementById("mEmail").value = msg;
        document.getElementById("mEmail").style.display = "inline";
        return false;
    }
    else document.getElementById("mEmail").style.display = "none";

    return true;

}

// check if Quote marks or Slash is used
function isQuot(str) {
    var quot = '\"', quot1 = "\'";
    if (str.indexOf(quot) != -1 || str.indexOf(quot1) != -1)
        return true;
    return false;
}

// check if bad characters are used
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

// check if text is in hebrew!
function isHebrew(str) {

    for (var i = 0; i < str.length; i++) {
        if (str.charAt(i) >= 'א' && str.charAt(i) <= 'ת')
            return true;
    }
    return false;

}
