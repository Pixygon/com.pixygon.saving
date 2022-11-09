using System;
using UnityEngine;
using UnityEngine.Serialization;

namespace Pixygon.Saving {
    [Serializable]
    public class AvatarData : ISaveData {
        public int _bodyID;
        public int _skintoneID;
        public int _eyeID;
        public int _hairID;
        public int _haircolorID;

        public int _shirtID;
        public int _pantsID;
        public int _shoesID;
        public int _jacketID;
        public int _headgearID;
        public int _socksID;
        public int _glovesID;

        public int _accesoryIDHead;
        public int _accesoryIDBody;
        public int _accesoryIDLapel;
        public int _offhandEquipmentID;
        public int _currentTool;
        public int[] _toolID;
        public int[] _weaponID;
        public int[] _ability1ID;
        public int[] _bottles;
        public bool[] _bottleFilled;
        public bool _weaponEquipped;
        public float _bodyheight;
        public int[] _cyberwareId;

        public static AvatarData Copy(AvatarData old) {
            return new AvatarData {
                _bodyID = old._bodyID,
                _skintoneID = old._skintoneID,
                _eyeID = old._eyeID,
                _hairID = old._hairID,
                _haircolorID = old._haircolorID,
                _shirtID = old._shirtID,
                _pantsID = old._pantsID,
                _shoesID = old._shoesID,
                _jacketID = old._jacketID,
                _headgearID = old._headgearID,
                _socksID = old._socksID,
                _glovesID = old._glovesID,
                _accesoryIDHead = old._accesoryIDHead,
                _accesoryIDBody = old._accesoryIDBody,
                _accesoryIDLapel = old._accesoryIDLapel,
                _offhandEquipmentID = old._offhandEquipmentID,
                _currentTool = old._currentTool,
                _toolID = old._toolID,
                _weaponID = old._weaponID,
                _ability1ID = old._ability1ID,
                _bottles = old._bottles,
                _bottleFilled = old._bottleFilled,
                _weaponEquipped = old._weaponEquipped,
                _bodyheight = old._bodyheight,
                _cyberwareId = old._cyberwareId
            };
        }
    }

    public static class AvatarDataHelper {
        public static AvatarData NewAvatarData {
            get {
                return new AvatarData
                {
                    _bodyID = 1,
                    _skintoneID = 1,
                    _eyeID = 1,
                    _hairID = 0,
                    _haircolorID = 1,
                    _shirtID = 1,
                    _pantsID = 1,
                    _shoesID = 1,
                    _jacketID = 0,
                    _headgearID = 0,
                    _socksID = 0,
                    _glovesID = 0,
                    _accesoryIDHead = 0,
                    _accesoryIDBody = 0,
                    _accesoryIDLapel = 0,
                    _offhandEquipmentID = 0,
                    _currentTool = 0,
                    _toolID = new [] {1, 1, 1},
                    _ability1ID = new [] {0, 0, 0},
                    _bottles = new [] {0, 0, 0, 0, 0, 0, 0, 0},
                    _bottleFilled = new [] {false, false, false, false, false, false, false, false},
                    _weaponEquipped = false,
                    _bodyheight = .5f,
                    _cyberwareId = new [] {0, 0, 0, 0}
                };
            }
        }

        public static int[] ConvertToIntArray(AvatarData data)
        {
            if (data._toolID == null) data = NewAvatarData;
            if(data._toolID.Length == 0) data = NewAvatarData;
            if(data._cyberwareId == null) data = NewAvatarData;
            if(data._cyberwareId.Length == 0) data = NewAvatarData;
            return new [] {
                data._bodyID, data._skintoneID, data._eyeID, data._hairID, data._haircolorID,
                data._shirtID, data._pantsID, data._shoesID, data._jacketID, data._headgearID, data._socksID, data._glovesID,
                data._accesoryIDHead, data._accesoryIDBody, data._accesoryIDLapel, data._offhandEquipmentID,
                data._currentTool, data._toolID[0], data._toolID[1], data._toolID[2], data._ability1ID[0], data._ability1ID[1],
                data._ability1ID[2],
                data._bottles[0], data._bottles[1], data._bottles[2], data._bottles[3], data._bottles[4], data._bottles[5],
                data._bottles[6], data._bottles[7],
                data._weaponEquipped ? 1 : 0,
                Mathf.RoundToInt(data._bodyheight * 100),
                data._cyberwareId[0], data._cyberwareId[1], data._cyberwareId[2], data._cyberwareId[3],
            };
        }

        public static AvatarData ConvertToAvatarData(int[] array) {
            var data = NewAvatarData;
            if(array.Length != 37)
                return data;
            data._bodyID = array[0];
            data._skintoneID = array[1];
            data._eyeID = array[2];
            data._hairID = array[3];
            data._haircolorID = array[4];

            data._shirtID = array[5];
            data._pantsID = array[6];
            data._shoesID = array[7];
            data._jacketID = array[8];
            data._headgearID = array[9];
            data._socksID = array[10];
            data._glovesID = array[11];

            data._accesoryIDHead = array[12];
            data._accesoryIDBody = array[13];
            data._accesoryIDLapel = array[14];
            data._offhandEquipmentID = array[15];

            data._currentTool = array[16];
            data._toolID[0] = array[17];
            data._toolID[1] = array[18];
            data._toolID[2] = array[19];
            data._ability1ID[0] = array[20];
            data._ability1ID[1] = array[21];
            data._ability1ID[2] = array[22];

            data._bottles[0] = array[23];
            data._bottles[1] = array[24];
            data._bottles[2] = array[25];
            data._bottles[3] = array[26];
            data._bottles[4] = array[27];
            data._bottles[5] = array[28];
            data._bottles[6] = array[29];
            data._bottles[7] = array[30];

            data._weaponEquipped = array[31] == 1;
            data._bodyheight = array[32]*.01f;
            
            data._cyberwareId[0] = array[33];
            data._cyberwareId[1] = array[34];
            data._cyberwareId[2] = array[35];
            data._cyberwareId[3] = array[36];

            return data;
        }

        public static int[] ConvertToIntArray(string data) {
            return ConvertToIntArray(JsonUtility.FromJson<AvatarData>(data));
        }

        public static AvatarData RandomAvatarData() {
            var data = NewAvatarData;
            data._bodyID = UnityEngine.Random.Range(1, 2);
            data._hairID = UnityEngine.Random.Range(1, 8);
            data._haircolorID = UnityEngine.Random.Range(1, 8);
            data._skintoneID = UnityEngine.Random.Range(1, 3);
            data._eyeID = UnityEngine.Random.Range(1, 3);
            data._bodyheight = UnityEngine.Random.value;
            return data;
        }

    }
}