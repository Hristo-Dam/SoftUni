function movie(input){
    
    let movieScore = 0;
    let bestMovieScore = -Infinity;
    let bestMovieName = '-';

    for(let k = 0; k <  input.length; k++){

        if(k > 7){
            console.log('The title limit has been transferred.');
            console.log(`The movie tonight is ${bestMovieName} collected points: ${bestMovieScore}.`);
        }

        let currentTitle =  input[k];

        for(let i = 0; i < currentTitle.length; i++){

            let currentChar = currentTitle[i];
            let add = currentChar.charCodeAt(0);
            movieScore += add;
            
            if(Number(currentChar)){
                
            }
            else if(currentChar === ' '){
                
            }
            else if(currentChar === currentChar.toLowerCase()){
                let subtract = currentTitle.length * 2;
                movieScore -= subtract;
            }
            else if(currentChar === currentChar.toUpperCase()){
                let subtract = currentTitle.length;
                movieScore -= subtract;
            }

        }

        if(movieScore > bestMovieScore){
            bestMovieScore = movieScore;
            bestMovieName = currentTitle.toString();   
        }
        movieScore = 0;
    }

    console.log(`The movie tonight is ${bestMovieName} collected points: ${bestMovieScore}.`);
}

movie(['The Hurt Locker']);
movie(['Amadeus', 'The Hurt Locker', 'The Godfather', 'Se7en'])
movie(['Django Unchained']);
movie(['Django Unchained', 'Joker', 'Oldboy', 'Hamilton', 'Klaus', 'Prisoners', 'Inside Out'])
