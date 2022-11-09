using System;
using UnityEngine;

namespace Pixygon.Saving
{
    [Serializable]
    public class PhotoSaveDatas : ISaveData {
        public PhotoData[] _photoSaveData;
    }

    [Serializable]
    public class PhotoData {
        public int _subjectId;
        public Vector3 _location;
        public string _date;
        public string _cameraSettings;
        public string _photoPath;

        public override string ToString() {
            return $"SubjectID: {_subjectId}\nLocation: {_location}\nDate: {_date}\n{_cameraSettings}\nPhoto Path: {_photoPath}";
        }
    }
}