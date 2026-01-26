using Bounds.Modulos.Cartas;
using Bounds.Modulos.Cartas.Ilustradores;
using Bounds.Modulos.Cartas.Persistencia;
using Bounds.Modulos.Cartas.Tinteros;
using Bounds.Modulos.Duelo.Fisicas;
using UnityEngine;

namespace Bounds.Fisicas.Carta {

	public class CartaGeneral : MonoBehaviour {

		public bool bocaArriba = true;
		private ICartaObservador observador;

		public void Iniciar(int cartaID, string imagen, string rareza, DatosDeCartas datos, IlustradorDeCartas ilustrador,
				ITintero tintero, ICartaObservador observador) {
			GetComponentInChildren<CartaFrente>().Inicializar(datos, ilustrador, tintero);
			GetComponentInChildren<CartaFrente>().Mostrar(cartaID, imagen, rareza);
			this.observador = observador;
		}


		void OnMouseDown() {
			observador.PresionarCarta(1, gameObject);
		}


		public void ColocarBocaAbajo(bool inmediato = true) {
			if (bocaArriba) {
				GetComponentInChildren<CartaFisica>().ColocarBocaAbajo();
				bocaArriba = false;
			}
		}


		public void ColocarBocaArriba(bool inmediato = true) {
			if (!bocaArriba) {
				GetComponentInChildren<CartaFisica>().ColocarBocaArriba();
				bocaArriba = true;
			}
		}


		void OnMouseEnter() {/*
			EmblemaConocimiento conocimiento = EmblemaConocimiento.getInstancia();
			Fisica fisica = conocimiento.traerFisica();
			if (fisica.TraerCartasEnMano(1).Contains(gameObject)) {
				//GetComponentInChildren<CartaFisica>().Acercar();
			}*/
		}


		void OnMouseExit() {/*
			EmblemaConocimiento conocimiento = EmblemaConocimiento.getInstancia();
			Fisica fisica = conocimiento.traerFisica();
			if (fisica.TraerCartasEnMano(1).Contains(gameObject)) {
				//GetComponentInChildren<CartaFisica>().Alejar();
			}*/
		}


	}

}