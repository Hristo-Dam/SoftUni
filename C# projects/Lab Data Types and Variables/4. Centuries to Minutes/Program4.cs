decimal centuries = int.Parse(Console.ReadLine());

decimal years = centuries * 100M;
decimal days = centuries * 365.24M;
decimal hours = centuries * 876576M;
decimal minutes = centuries * 52594560M;

Console.WriteLine($"{centuries} centuries = {years} years = {days:F0} days = {hours} hours = {minutes} minutes");