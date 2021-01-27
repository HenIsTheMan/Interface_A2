using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

namespace InterfaceA2 {
    internal sealed class LangDropdown: MonoBehaviour, IPointerClickHandler, ICancelHandler {
        #region Fields

        [SerializeField] private AudioTrigger audioTriggerScript;
        [SerializeField] private TMP_Dropdown dropdown;

        #endregion

        #region Properties
        #endregion

        #region Ctors and Dtor

        public LangDropdown() {
            audioTriggerScript = null;
            dropdown = null;
        }

        #endregion

        #region Unity User Callback Event Funcs

        private void Awake() {
            UnityEngine.Assertions.Assert.IsNotNull(audioTriggerScript);
            UnityEngine.Assertions.Assert.IsNotNull(dropdown);
        }

        void Start() {
            dropdown.onValueChanged.AddListener(delegate {
                OnDropdownValChange(dropdown);
            });
        }

        #endregion

        public void OnPointerClick(PointerEventData eventData) {
            audioTriggerScript.PlayAudio();
        }

        public void OnCancel(BaseEventData eventData) {
            audioTriggerScript.PlayAudio();
        }

        private void OnDropdownValChange(TMP_Dropdown dropdown) => audioTriggerScript.PlayAudio();
	}
}