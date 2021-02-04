using System;
using System.Collections.Generic;
using MongoDB.Driver;
using WebApplication1.Controllers;
using WebApplication1.Models;
using System.Linq;

namespace WebApplication1 { 

    public class Mongo
    {
        private readonly IMongoDatabase _db;

        private readonly IMongoCollection<Pessoa> _pessoaCollection;

        public Mongo()
        {
            var cliente = new MongoClient("");

            _db = cliente.GetDatabase("");

            _pessoaCollection = _db.GetCollection<Pessoa>("");
        }

        public IList<Pessoa> List(Pagging pagging)
        {
            return _pessoaCollection.Find("").Skip((pagging.CurrentPage - 1) * pagging.CurrentPage).Limit(pagging.PageSize).ToList();
        }

        public bool InsertOrUpdate(Pessoa pessoa)
        {
            if (pessoa.Id > 0)
                return _pessoaCollection.ReplaceOne(f => f.Id == pessoa.Id, pessoa).IsAcknowledged;
            else
            {
                try
                {
                    _pessoaCollection.InsertOne(pessoa);
                    return true;
                }
                catch(Exception)
                {
                    return false;
                }
            }
        }

        public bool Delete(Pessoa pessoa)
        {
            return _pessoaCollection.DeleteOne(d => d.Id == pessoa.Id).IsAcknowledged;
        }

        public bool Delete(int id)
        {
            return _pessoaCollection.DeleteOne(d => d.Id == id).IsAcknowledged;
        }

    }
}
