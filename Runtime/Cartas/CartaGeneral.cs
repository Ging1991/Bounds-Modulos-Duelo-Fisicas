using Bounds.Cartas;
using Bounds.Modulos.Duelo.Fisicas;
using DG.Tweening;
using UnityEngine;

namespace Bounds.Fisicas.Carta {

	public class CartaGeneral : MonoBehaviour {

		private ICartaObservador observador;
		public CartaFisica cartaFisica;
		public CartaImagenID cartaImagenID;

		public void Iniciar(ICartaObservador observador) {
			this.observador = observador;
		}

		public void Mostrar(int cartaID, string imagen, string rareza, string clase, string borde, int ataque, int defensa, int nivel) {

			cartaImagenID.primitiva.SetIlustracionImagen(cartaImagenID.generador.GetImagen(cartaID, imagen));

			Color tintaRareza = cartaImagenID.generador.proveedorColores.GetElemento($"TINTA_{rareza}");
			cartaImagenID.primitiva.SetFondoBordeColor(tintaRareza);

			cartaImagenID.SetNivel(nivel, rareza);

			cartaImagenID.primitiva.SetFondoRellenoColor(cartaImagenID.generador.proveedorColores.GetElemento($"RELLENO_{borde}"));
			cartaImagenID.primitiva.ataque.SetColorRelleno(cartaImagenID.generador.proveedorColores.GetElemento($"RELLENO_CLARO_{borde}"));
			cartaImagenID.primitiva.defensa.SetColorRelleno(cartaImagenID.generador.proveedorColores.GetElemento($"RELLENO_CLARO_{borde}"));

			if (clase == "CRIATURA") {
				cartaImagenID.primitiva.ataque.gameObject.SetActive(true);
				cartaImagenID.primitiva.defensa.gameObject.SetActive(true);
				cartaImagenID.primitiva.ataque.SetValor(ataque);
				cartaImagenID.primitiva.defensa.SetValor(defensa);
			}
			else if (clase == "EQUIPO") {
				cartaImagenID.primitiva.ataque.gameObject.SetActive(false);
				cartaImagenID.primitiva.defensa.gameObject.SetActive(true);
				cartaImagenID.primitiva.defensa.SetValor(defensa);
			}
			else {
				cartaImagenID.primitiva.ataque.gameObject.SetActive(false);
				cartaImagenID.primitiva.defensa.gameObject.SetActive(false);
			}

		}


		void OnMouseDown() {
			observador.PresionarCarta(1, gameObject);
		}


		public void Sacudir() {
			transform.DOShakePosition(0.5f, 0.9f, 15);
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