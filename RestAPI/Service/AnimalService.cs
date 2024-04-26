using RestAPI.Models;
using System.Reflection.Metadata.Ecma335;

namespace RestAPI.Service
{
    public class AnimalService
    {
        private List<Animal> tmpAnimalRepo = new List<Animal>();
        public AnimalService() {
            tmpAnimalRepo.Add(
                new Animal(1,"pies","pies desc","pies category","sample area")
                );
            tmpAnimalRepo.Add(
                new Animal(2, "kot", "kot desc", "kot category", "sample area")
                );
                }
        public List<Animal> getAll()
        {
            return new List<Animal>(tmpAnimalRepo);
        }
        
         public Animal get(int id)
        {
            return tmpAnimalRepo
                .Find(x => x.GetId() == id);
        }
        public void delete(int id)
        {
            Animal toDelete = tmpAnimalRepo
                                .Find(x => x.GetId() == id);
            tmpAnimalRepo.Remove(toDelete);
        }
        public Animal update(int id, Animal toUpdate)
        {
            delete(id);
            return add(toUpdate);
           
        }
        public Animal add(Animal toAdd)
        {
            tmpAnimalRepo.Add(toAdd);
            return toAdd;
        }

    }
}
