namespace RawData
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Car> cars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()
                    .Split()
                    .ToArray();

                string model = input[0];

                int engineSpeed = int.Parse(input[1]);
                int enginePower = int.Parse(input[2]);

                int cargoWeight = int.Parse(input[3]);
                string cargoType = input[4];

                Engine engine = new Engine(engineSpeed, enginePower);
                Cargo cargo = new Cargo(cargoWeight, cargoType);

                Tire[] tires = new Tire[4];

                tires[0].Pressure = double.Parse(input[5]);
                tires[0].Age = int.Parse(input[6]);

                tires[1].Pressure = double.Parse(input[7]);
                tires[1].Age = int.Parse(input[8]);

                tires[2].Pressure = double.Parse(input[9]);
                tires[2].Age = int.Parse(input[10]);

                tires[3].Pressure = double.Parse(input[11]);
                tires[3].Age = int.Parse(input[12]);

                Car car = new Car(model, engine, cargo, tires);

                cars.Add(car);

            }

            string command = Console.ReadLine();
            List<Car> resultList = new List<Car>();

            if(command == "fragale")
            {
                foreach (Car car in cars)
                {
                    if (car.Cargo.Type == "fragale")
                    {
                        foreach (Tire tire in car._tiers)
                        {
                            if (tire.Pressure < 1)
                            {
                                resultList.Add(car);
                                break;
                            }
                        }
                    }
                }
            }
            else if (command == "flammable")
            {
                foreach (Car car in cars)
                {
                    if (car.Engine.Power > 250)
                    {
                        resultList.Add(car);
                    }
                }
            }

            foreach (Car car in  resultList)
            {
                Console.WriteLine(car.Model);
            }
        }
    }
}