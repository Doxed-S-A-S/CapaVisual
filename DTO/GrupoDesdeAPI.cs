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
            public Boolean privacidad { get; set; }  
            public string rol { get; set; }        
            public int? id_cuenta { get; set; }     
        
    }
}
