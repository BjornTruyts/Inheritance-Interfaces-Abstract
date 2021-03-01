using System;
using System.Collections.Generic;
using System.Text;

namespace Voorbeeld_Polymorfisme_1_Animals_p3.Classes
{
    public class Zoo
    {
        Animal[] _animals;

        public Zoo()
        {
            _animals = new Animal[2];
            _animals[0] = new Blackbird();
            _animals[1] = new Sparrow();
        }

        public void ProduceSounds()
        {
            foreach (Animal animal in _animals)
            {
                animal.MakeSound();
                //animal.Sing();    //Unique to Blackbirds, not known by parent class Animal.
                //animal.Chirp();   //Unique to Sparrows, also not known.
            }
        }
    }
}
