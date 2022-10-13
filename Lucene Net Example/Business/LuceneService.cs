using Lucene_Net_Example.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Lucene_Net_Example.Business
{
    public class LuceneService
    {
        public async Task<List<Person>> SelectData(string searchKey)
        {
            List<Person> list = new List<Person>();
            return list;
        }
        public bool InsertData(List<Person> person)
        {
            return true;
        }

        public bool UpdateData(List<Person> person)
        {
            return true;
        }

        public bool DeleteData(string name)
        {
            return true;
        }
    }
}
