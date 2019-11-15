using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace CertificadosProfesionalidad.Model
{
	public class FamiliaProfesional
	{
		[Key]
		public Byte						FamiliaProfesionalID	{ get; set; }
		[Required]
		public String					Denominacion			{ get; set; }
		public ISet<AreaProfesional>	AreasProfesionales		{ get; private set; } = new HashSet<AreaProfesional>();
	}
}
