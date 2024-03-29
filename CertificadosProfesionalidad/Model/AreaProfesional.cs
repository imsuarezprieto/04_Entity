﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace CertificadosProfesionalidad.Model
{
	public class AreaProfesional : INotifyPropertyChanged
	{
		private String codigo;
		private String denominacion;

		[Key, DatabaseGenerated( DatabaseGeneratedOption.Identity )]
		public Byte AreaProfesionalID { get; set; }

		[Index( IsUnique = true )]
		[Required]
		[Column( TypeName = "CHAR" )]
		[StringLength( 4, MinimumLength = 4 )]
		[RegularExpression( @"[A-Z]{4}" )]
		public String Codigo
		{
			get => codigo;
			set
			{
				if (value != codigo)
				{
					codigo = value;
					PropertyChanged?.Invoke( this, new PropertyChangedEventArgs( "Codigo" ) );
				}
			}
		}

		[Required]
		public String Denominacion
		{
			get => this.denominacion;
			set
			{
				if (value != denominacion)
				{
					denominacion = value;
					PropertyChanged?.Invoke( this, new PropertyChangedEventArgs( "Denominacion" ) );
				}
			}
		}

		public ISet<FamiliaProfesional> FamiliasProfesionales { get; set; } = new HashSet<FamiliaProfesional>();

		public event PropertyChangedEventHandler PropertyChanged;

	}
}
