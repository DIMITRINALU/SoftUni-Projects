namespace Repository
{
    using System.Collections.Generic;

    public class Repository
    {
        private readonly Dictionary<int, Person> data;
        private int id;

        public Repository()
        {
            this.data = new Dictionary<int, Person>();
            this.id = 0;
        }

        public int Count => this.data.Count;

        public void Add(Person person) 
        {
            this.data.Add(id++, person);
        }

        public Person Get(int id) 
        {
            return this.data[id];
        }

        public bool Update(int id, Person newPerson) 
        {
            if (this.data.ContainsKey(id))
            {
                this.data[id] = newPerson;
                return true;
            }

            return false;
        }

        public bool Delete(int id) 
        {
            if (this.data.ContainsKey(id))
            {
                this.data.Remove(id);
                return true;
            }

            return false;
        }
    }
}