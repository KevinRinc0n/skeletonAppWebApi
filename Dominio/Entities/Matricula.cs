using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dominio.Entities;

public class Matricula
{
   public int IdMat { get; set; } 
   public int IdPersonaFk { get; set; } 
   public int IdSalonFk { get; set; } 
}
