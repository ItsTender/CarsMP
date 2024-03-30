function CheckForm() {

    var uName = document.getElementById("username").value;
    var msg = "";
    if (uName.length < 6)
        msg = "Username is too Short!";
    else if (uName.length > 15)
        msg = "Username must be between 6-15 Characters!";
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

    //---------------------------------------------------------------------

    //var hobies = document.getElementById("hobies");
    //var hobChecked = false;


    //for (var i = 0; i < hobies.length; i++) {
      //  if (hobies[i].checked) hobChecked = true;
    //}

    //if (hobChecked == false) {
    //   msg = "Choose at least One Hobby";
    //    document.getElementById("mHobies").value = msg;
    //    document.getElementById("mHobies").style.display = "inline";
    //
    //    return false;
    //}
    //else document.getElementById("mHobies").style.display = "none";

}