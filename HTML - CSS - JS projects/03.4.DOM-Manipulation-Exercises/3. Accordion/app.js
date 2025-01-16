function toggle() {
    let moreOrLess = document.querySelector('.button')

    if (moreOrLess.textContent === 'More'){
        document.getElementById('extra').style.display = 'block';
        moreOrLess.textContent = 'Less';
    } else {
        document.getElementById('extra').style.display = 'none';
        moreOrLess.textContent = 'More';
    }
}