namespace MobilePhoneDevices
{
    using System;
    using System.Collections.Generic;

    public class GSMTest
    {
        public static List<GSM> GeneratePhones()
        {
            List<GSM> phones = new List<GSM>();

            phones.Add(new GSM
                ("Lumia 900", "Nokia", 699.99m, "Penka Ivanova", new Battery(BatteryType.NiCd,150,25), new Display(3.5m, 2.4m, 320000000)));

            phones.Add(new GSM
                ("Xperia", "Sony", 249.99m, "Dushka Dragoeva", new Battery(BatteryType.Li_Ion), new Display(3.1m, 2.1m, 1000000)));

            phones.Add(new GSM
                ("Galaxy S6", "Samsung", 1049.99m, "Rosen Vasilev", new Battery(BatteryType.NiMH), new Display(4.1m, 3.1m, 64000000)));

            phones.Add(GSM.IPhone);

            return phones;
        }
    }
}
