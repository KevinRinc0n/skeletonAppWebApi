using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dominio.Entities;

public class Salon
{
    public int IdSalon { get; set; }    
    public string NombreSalon { get; set; }
    public int Capacidad { get; set; }


    public ICollection<Matricula> Matriculas { get; set; }
    public ICollection<TrainerSalon> TrainerSalones { get; set; }
}
