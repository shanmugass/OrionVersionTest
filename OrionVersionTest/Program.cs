using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrionVersionTest.ServiceReference1;

namespace OrionVersionTest
{
    class Program
    {
        static void Main(string[] args)
        {

            var client = new InventoryClient();

            var result = client.GetBasicVersionInformationByTitle(new BasicVersionByTitleInfo
                                                          {
                                                              TitleID = new int[] { 798460 }
                                                          });

            Console.Write(result);

            const int versionId = 619275;

            var versionDetails = client.GetBasicVersionInformationByVersionID(new BasicVersionByVersionID
                                                                                  {
                                                                                      VersionID = new int[] { versionId }
                                                                                  });


            Console.Write(versionDetails);
            
        }
    }
}
