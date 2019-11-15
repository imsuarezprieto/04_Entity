using System.Windows.Controls;


namespace CertificadosProfesionalidad.View
{
	public partial class AreaProfesional : UserControl
    {
        public AreaProfesional()
        {
            InitializeComponent();
            DataContext = new ViewModel.AreaProfesional();
        }
    }
}
