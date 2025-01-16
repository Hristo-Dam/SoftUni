using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aquarium
{
    public abstract class Fish
    {
        private string _name;
        private string _species;
        private int _size;
        private decimal _price;

        public Fish(string name, string species, decimal price)
        {
            this.Name = name;
            this.Species = species;
            this.Price = price;
        }

        public string Name
        {
            get 
            {
                if (string.IsNullOrWhiteSpace(this._name))
                {
                    throw new ArgumentException("Fish name cannot be null or empty");
                }
                else
                {
                    return this._name;
                }
            }
            set { this._name = value; }
        }
        public string Species
        {
            get
            {
                if (string.IsNullOrWhiteSpace(this._species))
                {
                    throw new ArgumentException("Fish species cannot be null or empty");
                }
                else
                {
                    return this._species;
                }
            }
            set { this._species = value; }
        }
        public int Size
        {
            get { return this._size; }
            set { this._size = value; }
        }
        public decimal Price
        {
            get
            {
                if (this._price <= 0)
                {
                    throw new ArgumentException("Fish price cannot be below or equal to 0.");
                }
                else
                {
                    return this._price;
                }
            }
            set { this._price = value; }
        }

        public abstract void Eat();
    }
}
