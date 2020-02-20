namespace SpaceStationRecruitment
{    
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class SpaceStation
    {
        private List<Astronaut> data;

        public SpaceStation(string name, int capacity)
        {
            this.data = new List<Astronaut>();
            this.Name = name;
            this.Capacity = capacity;
        }

        public string Name { get; set; }
        public int Capacity { get; set; }

        public int Count
        {         
           get{ return this.data.Count; }
        }

        public void Add(Astronaut astronaut) 
        {
            if (this.data.Count < this.Capacity)
            {
                this.data.Add(astronaut);
            }
        }

        public bool Remove(string name) 
        {

            return this.data.Remove(this.data.FirstOrDefault(a => a.Name == name));
            //foreach (var astronaut in data)
            //{
            //    if (astronaut.Name == name)
            //    {
            //        this.data.Remove(astronaut);
            //        return true;
            //    }
            //}

            //return false;
        }

        public Astronaut GetOldestAstronaut()
            => this.data.OrderByDescending(a => a.Age).FirstOrDefault();

        //    01.Astronaut result = new Astronaut(string.Empty, int.MinValue, string.Empty);

        //    foreach (var astronaut in this.data)
        //    {
        //        if (astronaut.Age > result.Age)
        //        {
        //            result = astronaut;
        //        }
        //    }

        //    return result;

        //    02.Astronaut result = this.data.OrderByDescending(a => a.Age).FirstOrDefault();
        //    return result;

        //    03. return this.data.OrderByDescending(a => a.Age).FirstOrDefault();

        public Astronaut GetAstronaut(string name) 
            => this.data.FirstOrDefault(a => a.Name == name);
        //
        //    01.return this.data.FirstOrDefault(a => a.Name == name);

        //    02.Astronaut result = null;

        //    foreach (var astronaut in this.data)
        //    {
        //        if (astronaut.Name > name)
        //        {
        //            result = astronaut;
        //        }
        //    }

        //    return result;
        //

        public string Report()         
        {
            var sb = new StringBuilder();

            sb.AppendLine($"Astronauts working at Space Station {this.Name}:");

            foreach (var astronaut in this.data)
            {
                sb.AppendLine(astronaut.ToString());
            }

            return sb.ToString().TrimEnd();
        }
    }
}