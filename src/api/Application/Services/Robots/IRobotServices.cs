using System.Collections.Generic;
using MegamanApi.api.Domain.Entities.Models;
using MegamanApi.api.UI.DTOs.Robots;

namespace MegamanApi.Application.Services.Robots
{
    public interface IRobotServices
    {
        IEnumerable<Robot> SearchAll();

        RobotReadDTO SearchById(int id);


    }
}