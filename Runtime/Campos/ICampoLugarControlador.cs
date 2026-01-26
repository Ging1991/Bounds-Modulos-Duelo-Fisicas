using UnityEngine;

namespace Bounds.Fisicas.Campos {

	public interface ICampoLugarControlador {

		void LugarPresionado(GameObject objeto);

		void LugarSoltado(GameObject objeto);

	}

}