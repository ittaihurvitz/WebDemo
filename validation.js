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
    let lastName = document.getElementById("lastName").value;
    if (lastName.length < 2) {
        let message = "<p>last name must be at least 2 characters long.<p>";
        let messageElement = document.getElementById("message");
        messageElement.innerHTML = message;
        return false;
        //event.preventDefault();
    }
}