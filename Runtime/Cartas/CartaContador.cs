using System.Collections.Generic;
using Bounds.Visuales;
using UnityEngine;

namespace Bounds.Fisicas.Carta {

	public class CartaContador : MonoBehaviour {

		public GameObject claseContador;
		readonly Dictionary<string, GameObject> contadores = new();

		public void SetContador(string tipo, int cantidad, bool estaGirado) {

			if (!contadores.ContainsKey(tipo)) {

				GameObject instancia = Instantiate(claseContador);
				instancia.transform.SetParent(transform);

				instancia.transform.localPosition = new Vector3(60, 80 - contadores.Keys.Count * 50, 0);
				instancia.transform.localScale = new Vector3(1, 1, 1);

				Quaternion rotacion = Quaternion.Euler(0, 0, 0);
				if (estaGirado)
					rotacion = Quaternion.Euler(0, 0, 0);

				instancia.transform.localRotation = rotacion;

				instancia.GetComponent<ContadorCarta>().SetTipo(tipo);
				contadores.Add(tipo, instancia);
			}

			GameObject contador = contadores[tipo];
			if (cantidad == 0) {
				contadores.Remove(tipo);
				Destroy(contador);

			}
			else {
				contador.GetComponent<ContadorCarta>().SetCantidad(cantidad);
			}
		}


	}

}