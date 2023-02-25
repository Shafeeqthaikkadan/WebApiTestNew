using WebApiTest.Entities;

namespace WebApiTest.Data
{
    public static class DBInitializer
    {
        public static void Initialize(StoreContext context)
        {
            if (context.States.Any()) return;

            var states = new List<State>{
                new State{
                    Name="Kerala"
                },
                 new State{
                    Name="Tamil Nadu"
                }
            };

            foreach (var state in states)
            {
                context.States.Add(state);
            }
            context.SaveChanges();
        }
    }
}
