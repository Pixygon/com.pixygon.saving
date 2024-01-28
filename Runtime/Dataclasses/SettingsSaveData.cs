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
        public string email;
        public string displayName;
        public string picturePath;
        public string pfpChain;
        public bool usePfp;
        public string bio;
        public string[] following;
        public string[] followers;
        public string[] waxCollections;
        public string waxWallet;
        public string ethWallet;
        public string tezWallet;
        public string matWallet;
        public string imxWallet;
        public string twitchUser;
        public int dreadwagerSkin;
        public string latestActivity;
        public string latestGame;
        public string[] pixyGoQueue;
        public bool artist;
        public string[] transactions;
        public string role;
        public int viewedProfile;
        public int impressions;
        public int gameXp;
        public int streamerXp;
        public int communityXp;
        public int viewerXp;
        public bool isVerified;
        public int verificationCode;
        public string passwordRecoveryTime;
        public string passwordRecoveryHash;
        public string[] links;
    }
}