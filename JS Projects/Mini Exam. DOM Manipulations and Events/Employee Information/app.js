function deleteByID() {
    const input = document.querySelector('body > label > input[type=text]').value;

    let thirdColumn = Array.from(document.querySelectorAll("#employees tr td:nth-child(3)"));

    for (let td of thirdColumn){

        if (td.textContent == input) {

            let row = td.parentNode;
            row.parentNode.removeChild(row);
            document.getElementById('result').textContent = "Deleted.";

            return;
        }
    }
    document.getElementById('result').textContent = "Not found.";
}