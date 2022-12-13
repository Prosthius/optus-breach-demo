using Api.Models;
//using (var context = new MyContext())

namespace Api.Data
{
    public static class DbInitialiser
    {
        public static void Initialise(ApiContext context)
        {

            if (context.users.Any()) return;   // DB has been seeded

            var users = new UserData[]
            {
                new UserData
                {
                    firstName = "John",
                    lastName = "Smith",
                    phoneNum = 00000000
                },
                new UserData
                {
                    firstName = "Jane",
                    lastName = "Smith",
                    phoneNum = 11111111
                },
                new UserData
                {
                    firstName = "Jim",
                    lastName = "Doe",
                    phoneNum = 22222222
                }
            };

            context.users!.AddRange(users);
            context.SaveChanges();
        }
    }
}
