using Lucene.Net.Analysis;
using Lucene.Net.Documents;
using Lucene.Net.Index;
using Lucene.Net.Search;
using Lucene.Net.Store;
using Lucene.Net.Util;
using Lucene_Net_Example.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection.Metadata;
using System.Threading.Tasks;

namespace Lucene_Net_Example.Business
{
    public class LuceneService
    {
        private const LuceneVersion MATCH_LUCENE_VERSION = LuceneVersion.LUCENE_48;

        private readonly Analyzer _analyzer;
        private readonly Analyzer _standardAnalyzer;
        public async Task<List<Person>> SelectData(string searchKey)
        {
            List<Person> list = new List<Person>();
            return list;
        }
        public bool InsertData(List<Person> person)
        {
            var indexPath = Path.Combine(Environment.CurrentDirectory, "LuceneFolder");
            using var writer = new IndexWriter(FSDirectory.Open(indexPath), new IndexWriterConfig(MATCH_LUCENE_VERSION, _analyzer));
            using var searchManager = new SearcherManager(writer, true, null);
            foreach (var value in person)
            {
                var docx = new Lucene.Net.Documents.Document();
                docx.Add(new StringField("Firstname", value.Firstname.ToString() ?? "", Field.Store.YES));
                docx.Add(new StringField("Lastname", value.Lastname.ToString() ?? "", Field.Store.YES));
                docx.Add(new StringField("Country", value.Country.ToString() ?? "", Field.Store.YES));
                docx.Add(new StringField("Gender", value.Gender.ToString() ?? "", Field.Store.YES));
                docx.Add(new StringField("Age", value.Age.ToString() ?? "", Field.Store.YES));
                writer.AddDocument(docx);
                writer.Flush(true, true);
                writer.Commit();
            }
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
