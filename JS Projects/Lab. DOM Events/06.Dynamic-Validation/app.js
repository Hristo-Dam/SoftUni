function validate() {
    const email = document.getElementById('email');
    email.addEventListener('change', (e) => {
        const pattern = /^[a-z]+@[a-z]+\.[a-z]+$/gm;

        if (!pattern.test(email.value)) {
            email.classList.add('error');
        }
        else{
            email.classList.remove('error');
        }
    });
}