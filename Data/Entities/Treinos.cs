using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Treino.Data.Entities
{
    public class Treinos
    {
        public int Id { get; set; }
        public string Nome { get; set; } = "";
        public EnumDiaTreino Treino { get; set; }
    }


    public enum EnumDiaTreino
    {
        A = 1,
        B = 2,
        C = 3,
        D = 4
    }
}