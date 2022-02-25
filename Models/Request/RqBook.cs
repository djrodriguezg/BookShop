using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Request
{
    /// <summary>
    /// Request Book
    /// </summary
    public class RqBook
    {   /// <summary>
        /// titulo del Libro
        /// </summary>	
        [Required]
        public string TITLE { get; set; }
        /// <summary>
        /// Año
        /// </summary>
        [Required]
        public int YEAR { get; set; }
        /// <summary>
        /// Genero
        /// </summary>
        [Required]
        public string GENRE { get; set; }
        /// <summary>
        /// Numero de Paginas
        /// </summary>
        [Required]
        public int NUMBER_PAGES { get; set; }
        /// <summary>
        /// Editorial
        /// </summary>
        [Required]
        public int ID_PUBLISHER { get; set; }
        /// <summary>
        /// Autor
        /// </summary>
        [Required]
        public int ID_AUTHOR { get; set; }
    }
}
