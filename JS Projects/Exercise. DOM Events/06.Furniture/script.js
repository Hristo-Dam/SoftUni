function solve() {
    const input = document.getElementsByTagName('textarea')[0];
    const result = document.getElementsByClassName('textarea')[1];
    const btnGenerator = document.getElementsByTagName('button')[0];

    const btnBuy = document.getElementsByTagName('textarea')[1];

    btnGenerator.addEventListener('click', (e) => {
        const target = e.target;
        console.log(target);
    })
}