using System.Collections.ObjectModel;
using System.Linq;


namespace CertificadosProfesionalidad.ViewModel
{
	public class AreaProfesional
	{
		public ObservableCollection<Model.AreaProfesional> AreasProfesionales { get; set; }

		public AreaProfesional()
		{
			using (var context = new Data.DBContext())
			{
				//context.AreasProfesionales.Add( new Model.AreaProfesional { Codigo = "IFCD", Denominacion = "Desarrollo" } );
				//context.AreasProfesionales.Add( new Model.AreaProfesional { Codigo = "IFCM", Denominacion = "Comunicaciones" } );
				//context.AreasProfesionales.Add( new Model.AreaProfesional { Codigo = "IFCT", Denominacion = "Sistemas y telemática" } );
				//context.SaveChanges();

				this.AreasProfesionales = new ObservableCollection<Model.AreaProfesional>( context.AreasProfesionales.AsEnumerable() );
			}
		}
	}
}
