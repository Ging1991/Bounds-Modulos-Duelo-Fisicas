using System;
using System.Collections.Generic;
using Bounds.Global.Colecciones;

namespace Ging1991.Infraestructura {

	public class Azar {
		
		private static readonly Random generador = new Random();


		public static int GenerarEnteroEntre(int minimo, int maximo) {
			return generador.Next(minimo, maximo);
		}


		public static int ValorAleatorio(List<int> elementos) {
			return elementos[GenerarEnteroEntre(0, elementos.Count)];
		}


		public static Coleccion.Carta ValorAleatorio(List<Coleccion.Carta> elementos) {
			return elementos[GenerarEnteroEntre(0, elementos.Count)];
		}


		public static string ValorAleatorio(List<string> elementos) {
			return elementos[GenerarEnteroEntre(0, elementos.Count)];
		}


		public static UnityEngine.GameObject ValorAleatorio(List<UnityEngine.GameObject> elementos) {
			return elementos[GenerarEnteroEntre(0, elementos.Count)];
		}


	}

}