using UnityEngine;

namespace InterfaceA2 {
    internal sealed class CrossButtonWIP: MonoBehaviour {
        #region Fields
        #endregion

        #region Properties
        #endregion

        #region Ctors and Dtor

        private CrossButtonWIP() {
        }

        #endregion

        #region Unity User Callback Event Funcs
        #endregion

        public void OnButtonClick() {
            gameObject.transform.parent.gameObject.SetActive(false);
        }
    }
}