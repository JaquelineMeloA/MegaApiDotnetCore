using System.Collections.Generic;
using MegamanApi.api.Domain.Entities.Models;

namespace Megaman.Database
{
    public interface IRobotRepository
    {
        bool SaveChanges();

        IEnumerable<Robot> GetAllRobots();
        
        Robot GetRobotById(int id);

        void AddRobot(Robot robot);
        
    }
}