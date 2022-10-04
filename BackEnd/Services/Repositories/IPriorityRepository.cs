using BackEnd.Models;
using System.Collections.Generic;

namespace BackEnd.Services.Repositories
{
    public interface IPriorityRepository
    {
        List<Priority> GetAll();
    }
}