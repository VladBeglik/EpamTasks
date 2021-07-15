﻿using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace Task5
{
	public static class Serializer<T>
	{
		/// <summary>
		/// Allows to serialize a sheet of objects of type T.
		/// </summary>
		/// <param name="path">Link to XML file for serialization.</param>
		/// <param name="list">List of objects of type T for serialization.</param>
		public static void Serialize(string path, List<T> list)
		{
			XmlSerializer formatter = new XmlSerializer(typeof(List<T>));

			using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
			{
				formatter.Serialize(fs, list);
			}
		}
	}
}