function stringSubstring(searchedWord, sentence){
    sentence = sentence.toLowerCase()
    //console.log(sentence);
    sentence = sentence.split(" ")
    //console.log(sentence)
    if (sentence.includes(searchedWord) == true){
        console.log(searchedWord)
    }
    else{
        console.log(searchedWord + " not found!")
    }
}
stringSubstring('javascript', 'JavaScript is the best programming language')
stringSubstring('python', 'JavaScript is the best programming language')
    