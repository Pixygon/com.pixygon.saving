using System;
using UnityEngine;

namespace Pixygon.Saving {
    [Serializable]
    public class CustomMarkerSaveDatas : ISaveData {
        public CustomMarker[] _customMarkers;
        public CustomMarker[] _beacons;
    }

    [Serializable]
    public class CustomMarker {
        public int _id;
        public int _markerType;
        public Vector3 _markerPosition;

        public CustomMarker(int id, int type, Vector3 pos) {
            _id = id;
            _markerType = type;
            _markerPosition = pos;
        }
    }
}