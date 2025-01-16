function lastKNumbersSequence(n, k){
    let seq = [1]
    for (let current = 1; current < n; current++){
        let start = Math.max(0, current - k);   
        let end = current - 1;
        let sum = // TODO: Sum the values of seq[start … end]
        seq[current] = sum;
    }
}
lastKNumbersSequence(6, 3);