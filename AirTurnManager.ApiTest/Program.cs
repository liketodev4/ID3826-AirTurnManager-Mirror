using AirTurnManager.Api.Foundation;
using System;

namespace AirTurnManager.ApiTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Api test starting. {DateTime.Now}");

            var atb = new ATBase();
            atb._type = ATBase.ATObjectType.ATObjectTypeATBase;
            try
            {
                var result = ATBase.ATBaseNew(null);

            }
            catch (Exception)
            {

                throw;
            }



            Console.ReadKey();
        }
    }
}
