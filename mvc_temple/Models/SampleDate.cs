namespace mvc_temple.Models
{
    public class SampleDate
    {

        private static List<user> users = new List<user>()
        {
            new user() {name="ahmed",email="aaa",phone="01000",willAttend="true"},
            new user() {name="ali",email="bbb",phone="0122222",willAttend="true"}
        };
        public static List<user> user { get => users; }


        public static void AddUser(user user)
        {
            users.Add(user);
        }
    }
}
