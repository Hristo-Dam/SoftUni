function modernTimes(sentence){
    sentence = sentence.split(" ");
    let result = [];
    let count = 0;

    for (let word of sentence){
        if (word[0] == "#" && word.length > 1){
            count = 0;
            for (let i = 1; i <= word.length; i++){
                let char = word[i].charCodeAt(0)
                if ((char >= 65 && char <= 90) || (char >= 97 && char <= 122)){
                    count++;
                    if (count == word.length - 1){
                        result.push(word)
                    }
                }
            }
        }
    }
    console.log(result);
}
modernTimes('Nowadays everyone uses # to tag a #special word in #socialMedia')