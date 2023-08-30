using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dominio.Entities;

public class Genero
{
    public int IdGeneroFk { get; set; }
    public string NombreGenero { get; set; }


    public ICollection<Persona> Personas { get; set; }
}
