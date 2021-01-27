using UnityEngine;
using UnityEngine.EventSystems;

namespace InterfaceA2 {
    internal sealed class LangDropdown: MonoBehaviour, IPointerClickHandler {
        #region Fields

        [SerializeField] private AudioTrigger audioTriggerScript;

        #endregion

        #region Properties
        #endregion

        #region Ctors and Dtor

        public LangDropdown() {
            audioTriggerScript = null;
        }

        #endregion

        #region Unity User Callback Event Funcs
        #endregion

        private void Awake() {
            UnityEngine.Assertions.Assert.IsNotNull(audioTriggerScript);
        }

        public void OnPointerClick(PointerEventData eventData) {
            audioTriggerScript.PlayAudio();
        }
    }
}