using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Response
{

    /// <summary>
    /// Clase del data response vacío, cuando hay algún error. Tiene los métodos que crean cada uno de los objetos de error para retornar en el response
    /// <param name="Data">String que siempre va en null</param>
    /// <param name="Notifications">Objeto tipo notificación con código, mensaje y descripción de cada error</param>
    /// </summary>
    public class EmptyDataResponse // Clase para retornar un response de los errores.
    {

        /// <summary>
        /// Método que crea un objeto para el error 500
        /// </summary>
        public static readonly EmptyDataResponse Error500 = new()
        {
            Data = null,
            Notification = new Notification
            {
                Code = ((int)System.Net.HttpStatusCode.InternalServerError).ToString(),
                Message = "InternalServerError",
                Description = "Internal Server Error.The request resource was not found.",
                Timestamp = DateTime.Now.ToUniversalTime()
            }
        };

        /// <summary>
        /// Método que crea un objeto para el error 400
        /// </summary>
        public static readonly EmptyDataResponse Error400 = new()
        {
            Data = null,
            Notification = new Notification
            {
                Code = ((int)System.Net.HttpStatusCode.BadRequest).ToString(),
                Message = "Bad Request",
                Description = "BadRequest. The request could not be understood by the server",
                Timestamp = DateTime.Now.ToUniversalTime()
            }
        };

        /// <summary>
        /// Método que crea un objeto para el error 404
        /// </summary>
        public static readonly EmptyDataResponse Error404 = new()
        {
            Data = null,
            Notification = new Notification
            {

                Code = ((int)System.Net.HttpStatusCode.NotFound).ToString(),
                Message = "Not Found",
                Description = "Not Found. The request resource was not found",
                Timestamp = DateTime.Now.ToUniversalTime()
            }
        };

        public string Data { get; set; }

        public Notification Notification { get; set; }
    }
}
