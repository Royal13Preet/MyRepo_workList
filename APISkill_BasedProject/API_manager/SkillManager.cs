using API_DataAccessLayer.DBModel;
using API_DataAccessLayer.Repositories;
using API_manager.DTo_s;
using AutoMapper;

namespace API_manager
{
    public class SkillManager : ISkillManager
    {
        private readonly ISkillRepo _skillRepo;
        private readonly IMapper _mapper;

        public SkillManager(ISkillRepo skillRepo, IMapper mapper)
        {
            _skillRepo = skillRepo;
            _mapper = mapper;
        }

        public bool AddSkill(AddSkill addSkill)
        {
            var entity = _mapper.Map<Skill>(addSkill);
            _skillRepo.AddSkill(entity);
            return true;
        }

        public IEnumerable<Skill> GetAllSkills()
        {
            return _skillRepo.GetAllSkills();
        }
    }
}
