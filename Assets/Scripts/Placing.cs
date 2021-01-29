using TMPro;
using UnityEngine;

namespace InterfaceA2 {
    internal sealed class Placing: MonoBehaviour {
        #region Fields

        private float BT;
        private float elapsedTime;
        [SerializeField] private float delay;
        [SerializeField] private GameObject placingTextPrefab;
        [SerializeField] private GameObject[] grayBars;
        [SerializeField] private string[] texts;
        private int arrLen;
        private int i;

        #endregion

        #region Properties
        #endregion

        #region Ctors and Dtor

        public Placing() {
            BT = 0.0f;
            elapsedTime = 0.0f;
            delay = 0.0f;
            placingTextPrefab = null;
            grayBars = null;
            texts = null;
            arrLen = 0;
            i = 0;
        }

        #endregion

        #region Unity User Callback Event Funcs

        private void Awake() {
            UnityEngine.Assertions.Assert.IsNotNull(placingTextPrefab);
            UnityEngine.Assertions.Assert.IsNotNull(grayBars);
            arrLen = grayBars.Length;
            UnityEngine.Assertions.Assert.AreEqual(arrLen, texts.Length);
        }

        private void Update() {
            elapsedTime += Time.deltaTime;

            if(i < arrLen && BT <= elapsedTime) {
                Vector3 pos = ((RectTransform)grayBars[i].transform).localPosition;

                Vector3 endPos = new Vector3(pos.x + 13.5f, pos.y, 0);
                Vector3 startPos = endPos + new Vector3(200.0f, 0.0f, 0.0f);

                GameObject placingTextGO = Instantiate(placingTextPrefab, startPos, Quaternion.identity);
                placingTextGO.transform.SetParent(gameObject.transform, false);
                placingTextGO.name = "PlacingText" + i;
                placingTextGO.GetComponent<TextMeshProUGUI>().text = texts[i];

                PlacingTextAnim myAnim = placingTextGO.GetComponent<PlacingTextAnim>();
                myAnim.ShldSetAsLocalPlayer = i == arrLen - 2;
                myAnim.AnimDuration = 1.0f;
                myAnim.StartPosX = startPos.x;
                myAnim.EndPosX = endPos.x;

                ++i;
                BT = elapsedTime + delay;
            }
        }

        #endregion
    }
}