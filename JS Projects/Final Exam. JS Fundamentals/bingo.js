function winningCard(inputCard){
    if (inputCard.length !== 20) {
        console.log("Invalid Bingo Card"); // 1, 5
        return;
    }
    else if (!inputCard.includes('&') && !inputCard.includes('*') && !inputCard.includes('%') && !inputCard.includes('#')) {
        console.log(`Card "${inputCard}" - doesn't win`); // 
        return;
    }

    let winningChars = ['&', '*', '%', '#'];
    let usedChar = '';

    let firstHalf = inputCard.slice(0, 10);
    let firstHalfCount = 0;

    let secondHalf = inputCard.slice(10, 20);
    let secondHalfCount = 0;

    let checkCharOnIndex = 0;

    for (let k = 0; k < 4; k++) {

        for (let i = 0; i < 10; i++) {
            if (firstHalf[i] == winningChars[checkCharOnIndex]) {
                firstHalfCount++;
            }
            if (secondHalf[i] == winningChars[checkCharOnIndex]) {
                secondHalfCount++;
            }
        }

        if (firstHalfCount !== secondHalfCount) {
            //console.log("Invalid Bingo Card");
            console.log(`Card "${inputCard}" - doesn't win`);
            return;
        }
        else if (firstHalfCount == 10 && secondHalfCount == 10) {
            console.log(`Bingo! "${inputCard}" - 10 simbols: ${winningChars[checkCharOnIndex]}`); // 7
            return;
        }
        else if ((firstHalfCount >= 6 && firstHalfCount < 10) && secondHalfCount == firstHalfCount) {
            console.log(`Card has won a Line "${inputCard}" - ${firstHalfCount} simbols: ${winningChars[checkCharOnIndex]}`); // 6
            return;
        }

        checkCharOnIndex++;
    }
}

// winningCard('Bing&&&&&&Oo&&&&&&ye')
// winningCard('&&&&&&&&&&&&&&&&&&&&')
// winningCard('dgsa')
// winningCard('skdhagsdncpotwnufmla')