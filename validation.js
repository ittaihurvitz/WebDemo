function validateLogin(event) {
    let password = document.getElementById("password").value;
    if (password.length < 4) {
        let message = "<p>password must be at least 4 characters long.<p>";
        let messageElement = document.getElementById("message");
        messageElement.innerHTML = message;
        return false;
        //event.preventDefault();
    }
}

function validateRegistration(event) {
    let familyName = document.getElementById("familyName").value;
    if (familyName.length < 2) {
        let message = "<p>Family name must be at least 2 characters long.<p>";
        let messageElement = document.getElementById("message");
        messageElement.innerHTML = message;
        return false;
        //event.preventDefault();
    }
}