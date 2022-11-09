using System;
using UnityEngine;

namespace Pixygon.Saving {
    [Serializable]
    public class SettingsSaveData : ISaveData {
        public string _playerName;
        public Vector3 _playerPos;
        public float _playerRot;
        public bool _hasStarted;
        public string _waxWallet;
        public string _ethWallet;
        public string _eosWallet;
        public string _tezWallet;
        public string _polygonWallet;
        public string _solanaWallet;
        public string _flowWallet;
    }
}