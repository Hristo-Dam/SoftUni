function attachGradientEvents() {
    let gradientBox = document.getElementById('gradient');
    gradientBox.addEventListener('mousemove', calculate);
    gradientBox.addEventListener('mouserest', reset);

    function calculate(event){
        let offsetX = event.offsetX;
        let width = this.clientWidth;
        let percent = offsetX / width * 100;

        let result = document.getElementById('result');
        result.textContent = Math.trunc(percent) + '%';
    }

    function reset(){
        document.getElementById('result').textContent = '';
    }
}