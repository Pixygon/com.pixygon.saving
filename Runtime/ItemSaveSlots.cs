using System;

namespace Pixygon.Saving {
    [Serializable]
    public class ItemSaveSlots {
        public string _id;
        public int _quantity;

        public ItemSaveSlots(string id, int quantity) {
            _id = id;
            _quantity = quantity;
        }
    }
}