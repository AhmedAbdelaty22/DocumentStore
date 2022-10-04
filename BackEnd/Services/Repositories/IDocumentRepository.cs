using BackEnd.Models;
using System.Collections.Generic;

namespace BackEnd.Services.Repositories
{
    public interface IDocumentRepository
    {
        int Delete(int id);
        List<Document> GetAll();
        Document GetById(int id);
        int Insert(Document doc);
        int Update(int id, Document doc);
    }
}