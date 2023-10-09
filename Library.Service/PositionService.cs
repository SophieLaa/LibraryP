using Library.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Data.Repositories;
using Library.Web;

namespace Library.Service
{
    public class PositionService : IPositionService
    {
        private readonly IPositionRepository _positionRepository;

        public PositionService(IPositionRepository positionRepository)
        {
            _positionRepository = positionRepository;
        }

        public void AddPosition(PositionData positionViewModel)
        {
            var position = new Position
            {
                PositionTitle = positionViewModel.PositionTitle,
              
            };

            _positionRepository.Add(position);
            _positionRepository.Save();
        }
    }
}
