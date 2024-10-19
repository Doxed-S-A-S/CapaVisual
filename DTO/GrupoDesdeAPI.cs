using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaVisual.DTO
{
    class GrupoDesdeAPI
    {
        
            public int id_grupo { get; set; }
            public string nombre_grupo { get; set; }
            public string descripcion { get; set; }
            public string url_imagen { get; set; }
            public string imagen_banner { get; set; }

            // Propiedades que pueden ser nulas, pero sin usar "nullable reference types"
            public bool privacidad { get; set; }  // Puede ser null en C# 7.3
            public string rol { get; set; }         // Puede ser null
            public int? id_cuenta { get; set; }     // Este sigue siendo nullable porque int? es válido en C# 7.3
            public string nombre_usuario { get; set; }  // Puede ser null
        
    }
}
