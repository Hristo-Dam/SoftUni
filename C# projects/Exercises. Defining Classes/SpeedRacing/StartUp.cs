namespace SpeedRacing
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());
            List<Car> listOfCars = new List<Car>();

            List<string> input = new List<string>();

            for (int i = 0; i < numberOfLines; i++)
            {
                input = Console.ReadLine()
                .Split()
                .ToList();
                listOfCars.Add(new Car(input[0], double.Parse(input[1]), double.Parse(input[2])));
            }

            input = Console.ReadLine()
                .Split()
                .ToList();

            while (input[0] != "End")
            {
                Car currentCar = listOfCars.Where(x => x.Model == input[1]).First();
                currentCar.Calculate(currentCar.Model, double.Parse(input[2]));

                input = Console.ReadLine()
                .Split()
                .ToList();
            }

            foreach (Car car in listOfCars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:F2} {car.TraveledDistance}");
            }
        }
    }
}