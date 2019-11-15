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
				this.AreasProfesionales = new ObservableCollection<Model.AreaProfesional>(context.AreasProfesionales.AsEnumerable());
            }
        }
    }
}
