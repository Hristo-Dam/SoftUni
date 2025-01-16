function validate() {
    let inputBox = document.getElementById('email');
    inputBox.addEventListener('change', onChange);

    let regex = /^[a-z]+@[a-z]+.[a-z]+$/gm;

    function onChange(){
        if (!regex.test(inputBox.value)){
            inputBox.classList.add('error');
        } else {
            inputBox.classList.remove('error');
        }
    }
}