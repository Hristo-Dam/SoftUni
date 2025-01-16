function createArticle() {
	let title = document.getElementById("createTitle");
	let content = document.getElementById("createContent");
	let articles = document.getElementById("articles");

	if (title.value.trim() !== " " && content.value.trim() !== ""){

		let article = document.createElement("article");
		let articleTitle = document.createElement("h3");
		let articleContent = document.createElement("p");

		articleTitle.textContent = title.value;
		articleContent.textContent = content.value;

		article.appendChild(articleTitle);
		article.appendChild(articleContent);

		articles.appendChild(article);
	}
	title.value = "";
	content.value = "";
}