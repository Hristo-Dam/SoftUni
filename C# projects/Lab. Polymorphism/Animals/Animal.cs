using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Animal
    {
        private string _name;
        private string _favoriteFood;

        public Animal(string name, string favoriteFood)
        {
            this.Name = name;
            this.FavoriteFood = favoriteFood;
        }

        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }
        public string FavoriteFood
        {
            get { return this._favoriteFood; }
            set { this._favoriteFood = value; }
        }

        public virtual string ExplaneSelf()
        {
            return $"I am {this.Name} and my favorite food is {this.FavoriteFood}";
        }
    }
}
