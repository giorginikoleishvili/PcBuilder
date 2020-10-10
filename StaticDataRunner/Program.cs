using Newtonsoft.Json;
using PcBuilder.Data.Models;
using StaticDataRunner.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace StaticDataRunner
{
    class Program
    {
        static void Main(string[] args)
        {
            var cont = new PcBuilder_DevContext();
            var js = System.IO.File.ReadAllText(@"C:\Users\gnikoleishvili\Desktop\Document\PcBuilder\PcBuilder\StaticDataRunner\Data\Memory\Manufacturer\Manufacturer.json");

            var data = JsonConvert.DeserializeObject<List<CommonModel>>(js);
            foreach (var item in data)
            {
               
                var entity = new ManufacturerType
                {
                     Name = item.Name.Trim(),
                      HardwareTypeId = 1005
                };
                cont.ManufacturerType.Add(entity);
            }
            cont.SaveChanges();
        }
    }

//    foreach (var item in data)
//            {
//                var split = item.Name.Split("x");
//    var count = split[0].Trim();
//    var volume = split[1].Trim();
//    var volumenCountStr = Regex.Match(volume, @"\d+").Value;
//    string volumeType = string.Empty;
//                foreach (var c in volumenCountStr)
//                {
//                    volumeType = volume.Replace(c,' ').Split()[1];
//                }
//var entity = new Module
//{
//    VolumeTypeId = volumeType == "GB" ? 2 : 1,
//    Volume = int.Parse(volumenCountStr),
//    Count = int.Parse(count)
//};
//cont.Module.Add(entity);
//            }
}
