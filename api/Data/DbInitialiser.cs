using Api.Models;
//using (var context = new MyContext())

namespace Api.Data
{
    public static class DbInitialiser
    {
        public static void Initialise(ApiContext context)
        {

            if (context.userData.Any()) return;   // DB has been seeded

            var users = new UserData[]
            {
                new UserData
                {
                    Id = 0,
                    firstName = "John",
                    lastName = "Smith",
                    phoneNum = 00000000
                },
                new UserData
                {
                    Id = 1,
                    firstName = "Jane",
                    lastName = "Smith",
                    phoneNum = 11111111
                },
                new UserData
                {
                    Id = 2,
                    firstName = "Jim",
                    lastName = "Doe",
                    phoneNum = 22222222
                }
            };

            context.userData!.AddRange(users);
            context.SaveChanges();
        }
    }
}
