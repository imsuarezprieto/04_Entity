using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CertificadosProfesionalidad.ViewModel
{
    public class AreaProfesional
    {
        public ObservableCollection<Model.AreaProfesional> AreasProfesionales { get; private set; }

        public AreaProfesional()
        {
            using (var context = new Data.DBContext())
            {
                //IEnumerable<Model.AreaProfesional> ap = context.AreasProfesionales.AsEnumerable();
                this.AreasProfesionales = new ObservableCollection<Model.AreaProfesional>(context.AreasProfesionales.AsEnumerable());
            }
        }
    }
}
