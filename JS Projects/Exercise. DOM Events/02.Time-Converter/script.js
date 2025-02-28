function attachEventsListeners() {
    let days = document.getElementById('days');
    let hours = document.getElementById('hours');
    let minutes = document.getElementById('minutes');
    let seconds = document.getElementById('seconds');

    const daysBtn = document.getElementById('daysBtn');
    const hoursBtn = document.getElementById('hoursBtn');
    const minutesBtn = document.getElementById('minutesBtn');
    const secondsBtn = document.getElementById('secondsBtn');

    daysBtn.addEventListener('click', daysConverter);
    hoursBtn.addEventListener('click', hoursConverter);
    minutesBtn.addEventListener('click', minutesConverter);
    secondsBtn.addEventListener('click', secondsConverter);

    function daysConverter() {
        days = document.getElementById('days').value;

        days = Number(days);
        hours = days * 24;
        minutes = hours * 60;
        seconds = minutes * 60;

        document.getElementById('hours').value = hours;
        document.getElementById('minutes').value = minutes;
        document.getElementById('seconds').value = seconds;
    }

    function hoursConverter() {
        hours = document.getElementById('hours').value;

        hours = Number(hours);
        days = hours / 24;
        minutes = hours * 60;
        seconds = minutes * 60;

        document.getElementById('days').value = days;
        document.getElementById('minutes').value = minutes;
        document.getElementById('seconds').value = seconds;
    }

    function minutesConverter() {
        minutes = document.getElementById('minutes').value;

        minutes = Number(minutes);
        hours = minutes / 60;
        days = hours / 24;
        seconds = minutes * 60;

        document.getElementById('days').value = days;
        document.getElementById('hours').value = hours;
        document.getElementById('seconds').value = seconds;
    }

    function secondsConverter() {
        seconds = document.getElementById('seconds').value;

        seconds = Number(seconds);
        minutes = seconds / 60;
        hours = minutes / 60;
        days = hours / 24;

        document.getElementById('days').value = days;
        document.getElementById('hours').value = hours;
        document.getElementById('minutes').value = minutes;
    }
}