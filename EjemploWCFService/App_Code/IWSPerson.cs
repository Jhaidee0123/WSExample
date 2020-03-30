using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
[ServiceContract]
public interface IWSPerson
{
	[OperationContract]
	Person GetPersonById(string id);

	// TODO: agregue aquí sus operaciones de servicio
}

[DataContract]
public class Person : ErrorResponse
{
	[DataMember]
	public string Identifier { get; set; }
	[DataMember]
	public string Name { get; set; }
}

[DataContract]
public class ErrorResponse
{
	[DataMember]
	public string Error { get; set; }
}

