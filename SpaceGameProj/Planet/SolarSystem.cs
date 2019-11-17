using System.Collections.Generic;

namespace SpaceGameProj
{

    public class SolarSystem
    {
        public SolarSystem(string name, int numberOfPlanets, List<Planet> planets)
        {
            this.name = name;
            this.numberOfPlanets = numberOfPlanets;
            this.planets = planets;
        }

        private string name;
        private int numberOfPlanets;
        private List<Planet> planets;

        public string GetName() => this.name;
        public int GetNumberOfPlanets() => this.numberOfPlanets;
        public List<Planet> GetPlanets() => this.planets;
    }
}