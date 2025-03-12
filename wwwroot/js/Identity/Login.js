function SubmitLoginDetails(event) {
    event.preventDefault();
    const email = document.querySelector('.form-control[type="email"]').value;
    const password = document.querySelector('.form-control[type="password"]').value;

    // Add your login logic here
    console.log('Logging in with:', email, password);
}

function googleLogin() {
    // Add your Google login logic here
    console.log('Google login clicked');
}

function otpLogin() {
    // Add your OTP login logic here
    console.log('OTP login clicked');
}