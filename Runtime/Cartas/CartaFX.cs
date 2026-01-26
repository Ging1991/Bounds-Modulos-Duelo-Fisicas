using Ging1991.Core;
using UnityEngine;

namespace Bounds.Fisicas.Carta {

	public class CartaFX : MonoBehaviour {

		public GameObject efectoSeleccionOBJ;
		private GameObject efectoSeleccionInstancia;
		public GameObject simboloAtaque;
		public GameObject simboloMuro;


		public void GanarPuntaje(int cantidad) {/*
			EmblemaConocimiento conocimiento = EmblemaConocimiento.getInstancia();
			Instanciador instanciador = conocimiento.traerInstanciador();
			GameObject efecto = instanciador.CrearTextoFlotanteVerde(gameObject.transform.localPosition, cantidad);
			efecto.transform.localPosition = gameObject.transform.localPosition + new Vector3(0, -65, 0);
			ControlDuelo.Instancia.GetComponent<GestorDeSonidos>().ReproducirSonido("FxEspadas");*/
		}


		public void PotencialAtacante(bool puedeAtacar) {/*
			if (puedeAtacar) {
				PotencialAtacante(false);
				EmblemaConocimiento conocimiento = EmblemaConocimiento.getInstancia();
				Instanciador instanciador = conocimiento.traerInstanciador();
				simboloAtaque = instanciador.CrearEspadaAtaque(gameObject.transform.localPosition);
			}
			else {
				if (simboloAtaque != null)
					Destroy(simboloAtaque);
			}*/
		}


		public void EfectoMuro(bool mostrar) {/*
			if (mostrar) {
				EfectoMuro(false);
				EmblemaConocimiento conocimiento = EmblemaConocimiento.getInstancia();
				Instanciador instanciador = conocimiento.traerInstanciador();
				simboloMuro = instanciador.CrearMuro(gameObject.transform.localPosition);
			}
			else {
				if (simboloMuro != null)
					Destroy(simboloMuro);
			}*/
		}


		public void PerderPuntaje(int cantidad) {/*
			EmblemaConocimiento conocimiento = EmblemaConocimiento.getInstancia();
			Instanciador instanciador = conocimiento.traerInstanciador();
			instanciador.CrearTextoFlotanteRojo(gameObject.transform.localPosition + new Vector3(0, -75, 0), -cantidad);
			//EfectosDeSonido.Tocar("FxEspadas");*/
		}


		public void seleccionar(bool usar2 = false) {
			deseleccionar();
			efectoSeleccionInstancia = Instantiate(efectoSeleccionOBJ, transform.position, Quaternion.identity);
			efectoSeleccionInstancia.transform.SetParent(transform);
			efectoSeleccionInstancia.transform.localScale = new Vector3(1, 1, 1);
			efectoSeleccionInstancia.transform.localPosition = efectoSeleccionInstancia.transform.localPosition + new Vector3(0, 3, 0.2f);
			efectoSeleccionInstancia.transform.localRotation = Quaternion.identity;
			efectoSeleccionInstancia.transform.localScale = new Vector3(3f, 3f, 0);
			/*
						CartaMovimiento movimiento = gameObject.GetComponent<CartaMovimiento>();
						if (movimiento.estaGirado) {
							Vector3 posicion = efectoSeleccionInstancia.transform.localPosition;
							efectoSeleccionInstancia.transform.localPosition = posicion;
						}*/
		}


		public void deseleccionar() {
			if (efectoSeleccionInstancia != null)
				Destroy(efectoSeleccionInstancia);
		}


		public bool estaSeleccionado() {
			return efectoSeleccionInstancia != null;
		}


	}

}