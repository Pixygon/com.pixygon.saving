using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnityEngine;

namespace Pixygon.Saving
{
    /*
    public abstract class Repository<T> : MonoBehaviour where T : Base {
        [HideInInspector] public DataContext context;

        private List<T> Entities => context.Set<T>();

        public T GetById(string id) {
            return Entities.FirstOrDefault(e => e.id == id);
        }

        public void Add(T entity) {
            
        }

        public void Modify(T entity) {
            
        }

        public void Delete(T entity) {
            
        }

        public async Task Save() {
            await context.Save();
        }
    }
    */
}
