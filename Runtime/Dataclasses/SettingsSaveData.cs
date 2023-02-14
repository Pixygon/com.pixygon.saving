using System;
using UnityEngine;

namespace Pixygon.Saving {
    [Serializable]
    public class SettingsSaveData : ISaveData {
        public string _playerName;
        public Vector3 _playerPos;
        public float _playerRot;
        public bool _hasStarted;
        public bool _isLoggedIn;
        public AccountData _user;
    }
    
    [Serializable]
    public class AccountData {
        public string _id;
        public string userName;
        //public string password;
        public string email;
        public string picturePath;
        public string[] friends;
        public string waxWallet;
        public string ethWallet;
        public string tezWallet;
        public bool artist;
        public string[] transactions;
        public string role;
        public int viewedProfile;
        public int impressions;
    }
}