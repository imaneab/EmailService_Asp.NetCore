﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmailService.Models
{
	public class Filiere
	{
		public Filiere()
		{
			Etudiants = new HashSet<Etudiant>();
		}

		public int ID { get; set; }
		[Required]
		[StringLength(100)]
		public string Titre { get; set; }
		public string Desc { get; set; }
		[Timestamp]
		public byte[] CreatedAt;
		[Timestamp]
		public byte[] UpdatedAt;
		public virtual ICollection<Etudiant> Etudiants { get; set; }

	}
}
