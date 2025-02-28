function solve() {
    const addButtons = Array.from(document.querySelectorAll('.product-add'));
    const checkoutButton = document.querySelector('.checkout');
    const cart = document.querySelector('textarea');

    let totalPrice = 0;
    let products = [];

    for (const button of addButtons) {
        button.addEventListener('click', addToCart);
    }

    function addToCart(e){
        const product = e.currentTarget.parentNode;
        const productPrice = product.querySelector('.product-line-price').textContent;
        const productTitle = product.querySelector('.product-title').textContent;

        if (!products.includes(productTitle)) {
            products.push(productTitle);
        }

        totalPrice += Number(productPrice);
        cart.value += `Added ${productTitle} for ${productPrice} to the cart.\n`;
    }

    checkoutButton.addEventListener('click', () => {

        cart.value += `You bouth ${products.join(', ')} for ${totalPrice.toFixed(2)}.`;

        for (const btn of addButtons) {
            btn.removeEventListener('click', addToCart);
        }

    });



















    




    // let products = [];
    // let textArea = document.getElementsByTagName('textarea')[0];
    // let addButtons = document.getElementsByClassName('add-product');
    // let checkoutButton = document.getElementsByClassName('checkout')[0];
    // let totalPrice = 0;
    // let boughtProducts = [];

    // for (let i = 0; i < addButtons.length; i++) {
    //     addButtons[i].addEventListener('click', function (e) {
    //         let product = e.target.parentElement.parentElement;
    //         let productName = product.getElementsByClassName('product-title')[0].textContent;
    //         let productPrice = Number(product.getElementsByClassName('product-line-price')[0].textContent);
    //         products.push({ name: productName, price: productPrice });
    //         textArea.value += `Added ${productName} for ${productPrice.toFixed(2)} to the cart.\n`;
    //         totalPrice += productPrice;
    //     });
    // }

    // checkoutButton.addEventListener('click', function () {
    //     let uniqueProducts = [];
    //     products.forEach(product => {
    //         if (!uniqueProducts.includes(product.name)) {
    //             uniqueProducts.push(product.name);
    //         }
    //     });

    //     textArea.value += `You bought ${uniqueProducts.join(', ')} for ${totalPrice.toFixed(2)}.`;

    //     addButtons = document.getElementsByClassName('add-product');
    //     for (let i = 0; i < addButtons.length; i++) {
    //         addButtons[i].disabled = true;
    //     }

    //     checkoutButton.disabled = true;
    // });
}