function tvSeries(movieName, seasons, episodes, durationEpisode){
    let numberOfAllEpisodes = episodes*seasons;
    let timeInMinutes = (durationEpisode *= 1.2) * numberOfAllEpisodes + (10 * seasons);
    console.log(`Total time needed to watch the ${movieName} series is ${timeInMinutes} minutes.`)
}
tvSeries('Lucifer', 3, 18, 55)