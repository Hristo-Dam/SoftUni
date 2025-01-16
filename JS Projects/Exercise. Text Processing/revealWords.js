function revealWords(words, sentence){
    let separatedWords = [];
    separatedWords = words.split(', ');
    let newSentance = "";
    let letterCount = 0;
    let stringToReplace = "";
    let splittedSentance = sentence.split(" ");

    for (word of separatedWords){

        letterCount = word.length;

        for (let i = 0; i < letterCount; i++){
            stringToReplace += "*"
        }

        for (part of splittedSentance){
            if (part == stringToReplace){
                part = part.replaceAll(stringToReplace, word)
            }
        }
        letterCount = 0;
    }

    for(word of splittedSentance){
        newSentance += word + " ";
    }

    console.log(newSentance);

}
//revealWords('great', 'softuni is ***** place for learning new programming languages')
revealWords('great, learning', 'softuni is ***** place for ******** new programming languages')    