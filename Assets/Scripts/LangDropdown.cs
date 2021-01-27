using TMPro;
using UnityEngine;

namespace InterfaceA2 {
    internal sealed class LangDropdown: TMP_Dropdown {
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

        protected override GameObject CreateDropdownList(GameObject template) {
            audioTriggerScript.PlayAudio();
            return base.CreateDropdownList(template);
        }

        protected override void DestroyDropdownList(GameObject dropdownList) {
            audioTriggerScript.PlayAudio();
            base.DestroyDropdownList(dropdownList);
        }
	}
}