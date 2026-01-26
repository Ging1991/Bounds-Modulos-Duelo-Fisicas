using UnityEngine;
using UnityEngine.EventSystems;

namespace Bounds.Fisicas.Campos {

	public class CampoLugar : MonoBehaviour, IDropHandler {

		public GameObject carta;
		public int jugador;
		public int lugarID;
		public ICampoLugarControlador controlador;

		void OnMouseDown() {
			if (carta == null) {
				controlador.LugarPresionado(gameObject);
			}
		}

		public void OnDrop(PointerEventData eventData) {
			if (carta == null) {
				controlador.LugarSoltado(gameObject);
			}
		}

	}

}