using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;	

using CertificadosProfesionalidad.Model;


namespace CertificadosProfesionalidad.Data
{
	class DBContext : System.Data.Entity.DbContext
	{
		public virtual DbSet<FamiliaProfesional>	FamiliasProfesionales	{ get; set; }
		public virtual DbSet<AreaProfesional>		AreasProfesionales		{ get; set; }

		public DBContext() : base( "CertificadosProfesionalDatabase" ) {}

		protected override void OnModelCreating( DbModelBuilder modelBuilder ) { 
			modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
		}
	}
}
