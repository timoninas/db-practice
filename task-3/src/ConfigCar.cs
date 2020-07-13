using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_operator
{
    public class ConfigCar
    {
        public int butterfly_doors;
        public int doors;
        public int clutch;
        public int engine;
        public int hood_car;
        public int trunk_car;

        public ConfigCar(int n1, int n2, int n3, int n4, int n5, int n6)
        {
            this.butterfly_doors = n1;
            this.doors = n2;
            this.clutch = n3;
            this.engine = n4;
            this.hood_car = n5;
            this.trunk_car = n6;
        }
    }
}
