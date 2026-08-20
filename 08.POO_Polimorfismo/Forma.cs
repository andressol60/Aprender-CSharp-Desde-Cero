using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.POO_Polimorfismo
{
    public class Forma
    {
        public decimal basse {  get; set; }
        public decimal altura { get; set; }
        public virtual decimal CalculaArea(decimal basse, decimal altura)
        {
            decimal area = (basse * altura)/2;
            return area;
        }
    }
}
