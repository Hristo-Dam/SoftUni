const usernameInput = document.querySelector("#username");
const ulOutput = document.querySelector("#repos");

const loadBtn = document.querySelector("button");
loadBtn.addEventListener("click", handleRepos)

function handleRepos() {
    ulOutput.innerHTML = '<a href="{repo.html_url}">{repo.full_name}</a>';
    const username = usernameInput.value;

    fetch(`https://api.github.com/users/${username}/repos`)
        .then(response => {
            if (!response.ok) {
                return Promise.reject('Bad Request with status:' + response.status);
            }
            return response;
        })
        .then(response => response.json())
        .then(loadSuccess)
        // .then(data =>{
        //     loadSuccess(data)
        // })
        .catch(handleError)

    usernameInput.value = "";
}

function loadSuccess(data) {
    ulOutput.firstElementChild.remove();

    data.forEach(repo => {
        const li = document.createElement("li");

        const a = document.createElement("a");
        a.setAttribute("href", repo.html_url);
        a.textContent = repo.full_name;

        li.appendChild(a);
        ulOutput.appendChild(li);
    })
}

function handleError(data) {
    ulOutput.firstElementChild.innerHTML = data;
}


//En este caso llamamos la data se pasa de forma implicida a la funcion
//.then(loadSuccess)