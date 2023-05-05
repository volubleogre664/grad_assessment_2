using Assessment_2.Models;

namespace Assessment_2.Data
{
    public class MockData
    {
        public static List<Person> GetPeople()
        {
            return new ()
            {
                new Person { Id = 1, Name = "Eren Yeager", Age = 19 },
                new Person { Id = 2, Name = "Mikasa Ackerman", Age = 19 },
                new Person { Id = 3, Name = "Armin Arlert", Age = 19 },
                new Person { Id = 4, Name = "Levi Ackerman", Age = 34 },
                new Person { Id = 5, Name = "Reiner Braun", Age = 21 },
                new Person { Id = 6, Name = "Bertholdt Hoover", Age = 20 },
                new Person { Id = 7, Name = "Annie Leonhart", Age = 20 },
                new Person { Id = 8, Name = "Zeke Yeager", Age = 30 },
                new Person { Id = 9, Name = "Historia Reiss", Age = 20 },
                new Person { Id = 10, Name = "Erwin Smith", Age = 32 },
                new Person { Id = 11, Name = "Hange Zoe", Age = 27 },
                new Person { Id = 12, Name = "Connie Springer", Age = 19 },
                new Person { Id = 13, Name = "Jean Kirstein", Age = 19 },
                new Person { Id = 14, Name = "Sasha Braus", Age = 19 },
                new Person { Id = 15, Name = "Ymir", Age = 21 },
                new Person { Id = 16, Name = "Grisha Yeager", Age = 38 },
                new Person { Id = 17, Name = "Carla Yeager", Age = 33 },
                new Person { Id = 18, Name = "Dina Fritz", Age = 33 },
                new Person { Id = 19, Name = "Frieda Reiss", Age = 23 },
                new Person { Id = 20, Name = "Rod Reiss", Age = 52 },
                new Person { Id = 21, Name = "Kenny Ackerman", Age = 36 },
                new Person { Id = 22, Name = "Marlo Freudenberg", Age = 22 },
                new Person { Id = 23, Name = "Hitch Dreyse", Age = 25 },
                new Person { Id = 24, Name = "Nile Dok", Age = 44 },
                new Person { Id = 25, Name = "Pieck Finger", Age = 27 },
                new Person { Id = 26, Name = "Gabi Braun", Age = 12 },
                new Person { Id = 27, Name = "Falco Grice", Age = 15 },
                new Person { Id = 28, Name = "Colt Grice", Age = 24 },
                new Person { Id = 29, Name = "Willy Tybur", Age = 30 },
                new Person { Id = 30, Name = "Porco Galliard", Age = 22 }
            };
        }
    }
}
