using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
public class WSPerson : IWSPerson
{
    public Person GetPersonById(string id)
    {
        if (id == "1")
        {
            return new Person { Identifier = "1036404019", Name = "Jhaider" };
        }
        else if(id == "2")
        {
            return new Person { Identifier = "231456987", Name = "Pedro" };
        }
        else
        {
            return new Person { Error = "The person was not found" };
        }
    }
}
