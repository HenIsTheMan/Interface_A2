using TMPro;
using UnityEngine;

namespace InterfaceA2 {
    internal sealed class LangDropdown: MonoBehaviour {
        #region Fields

        [SerializeField] private TMP_Dropdown dropdown;

        #endregion

        #region Properties
        #endregion

        #region Ctors and Dtor

        public LangDropdown() {
            dropdown = null;
        }

        #endregion

        #region Unity User Callback Event Funcs

        private void Awake() {
            UnityEngine.Assertions.Assert.IsNotNull(dropdown);
        }

        void Start() {
            dropdown.onValueChanged.AddListener(delegate {
                OnDropdownValChange(dropdown);
            });
        }

        #endregion

        private void OnDropdownValChange(TMP_Dropdown dropdown) {
            Debug.Log(dropdown.value, this);
            //dropdown.value;
        }
    }
}