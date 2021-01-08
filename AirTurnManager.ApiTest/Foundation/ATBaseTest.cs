using AirTurnManager.Api.Foundation;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirTurnManager.ApiTest.Foundation
{
    public class ATBaseTest
    {
        public bool Run()
        {
            var atBaseStruct = ATBase.CreateATBaseStruct();

            Print(atBaseStruct);

            var result = ATBase.ATBaseNew(ref atBaseStruct);
            Print(result);

            
            //var result1=ATBase.ATBaseInit(ref result);
            //Print(result1);

            //var atbsNew = ATBase.CreateATBaseStruct();
            //atbsNew._type = ATBase.ATObjectType.ATObjectTypeATBaseArray;
            //Print(atbsNew);
            //var result = ATBase.ATBaseCopy(ref atbsNew, ref atBaseStruct);
            //Print(result);
            //Print(atbsNew);

            return true;
        }

        public void Print(object obj)
        {
            var json = JsonConvert.SerializeObject(obj, Formatting.Indented);
            Console.WriteLine(json);
        }
    }
}
