using UnityEngine;

namespace Pixygon.Saving {
    public class SaveTimer : MonoBehaviour {
        private float _saveTimer;
        private float _saveInterval = 30f;

        private void Awake() {
            _saveTimer = _saveInterval;
        }
        private void Update() {
            if (_saveTimer > 0f) {
                _saveTimer -= Time.deltaTime;
            } else {
                SaveManager.DoSave();
                _saveTimer = _saveInterval;
            }
        }
    }
}