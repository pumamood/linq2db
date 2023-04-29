// ---------------------------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by LinqToDB scaffolding tool (https://github.com/linq2db/linq2db).
// Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
// ---------------------------------------------------------------------------------------------------


#pragma warning disable 1573, 1591
#nullable enable

namespace Cli.Fluent.Informix
{
	public class Person
	{
		public int     Personid   { get; set; } // SERIAL
		public string  Firstname  { get; set; } = null!; // NVARCHAR(50)
		public string  Lastname   { get; set; } = null!; // NVARCHAR(50)
		public string? Middlename { get; set; } // NVARCHAR(50)
		public char    Gender     { get; set; } // CHAR(1)

		#region Associations
		/// <summary>
		/// FK_doctor_person backreference
		/// </summary>
		public Doctor? Doctor { get; set; }

		/// <summary>
		/// FK_patient_person backreference
		/// </summary>
		public Patient? Patient { get; set; }
		#endregion
	}
}