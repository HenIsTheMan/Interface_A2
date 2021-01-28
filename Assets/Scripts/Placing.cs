using TMPro;
using UnityEngine;

namespace InterfaceA2 {
    internal sealed class Placing: MonoBehaviour {
        #region Fields

        [SerializeField] private GameObject placingTextPrefab;
        [SerializeField] private GameObject[] grayBars;
        [SerializeField] private string[] texts;
        int arrLen;

        #endregion

        #region Properties
        #endregion

        #region Ctors and Dtor

        public Placing() {
            placingTextPrefab = null;
            grayBars = null;
            texts = null;
            arrLen = 0;
        }

        #endregion

        #region Unity User Callback Event Funcs

        private void Awake() {
            UnityEngine.Assertions.Assert.IsNotNull(placingTextPrefab);
            UnityEngine.Assertions.Assert.IsNotNull(grayBars);
            arrLen = grayBars.Length;
            UnityEngine.Assertions.Assert.AreEqual(arrLen, texts.Length);
        }

        private void Start() {
            for(int i = 0; i < arrLen; ++i) {
                Vector3 pos = ((RectTransform)grayBars[i].transform).localPosition;

                Vector3 endPos = new Vector3(pos.x + 13.5f, pos.y, 0);
                Vector3 startPos = endPos + new Vector3(30.0f, 0.0f, 0.0f);

                GameObject placingTextGO = Instantiate(placingTextPrefab, startPos, Quaternion.identity);
                placingTextGO.transform.SetParent(gameObject.transform, false);
                placingTextGO.name = "PlacingText" + i;
                placingTextGO.GetComponent<TextMeshProUGUI>().text = texts[i];

                PlacingTextAnim myAnim = placingTextGO.GetComponent<PlacingTextAnim>();
                myAnim.AnimDuration = 1.0f;
                myAnim.StartPosX = startPos.x;
                myAnim.EndPosX = endPos.x;
            }
        }

        #endregion
    }
}