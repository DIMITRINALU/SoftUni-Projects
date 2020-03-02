namespace CustomRandomList 
{
    using System.Collections.Generic;

    public class RandomList : List<string>
    {  
        public RandomList(List<string> list)
        {
            this.StringList = list;
        }

        public List<string> StringList { get; set; }

        public string RandomString()
        {
            var random = new System.Random();

            int index = random.Next(this.StringList.Count);
            string randomString = this.StringList[index];

            this.StringList.RemoveAt(index);

            return randomString;
        }
    }
}