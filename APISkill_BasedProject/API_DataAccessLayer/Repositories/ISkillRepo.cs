using API_DataAccessLayer.DBModel;

namespace API_DataAccessLayer.Repositories
{
    public interface ISkillRepo
    {
        public bool AddSkill(Skill skill);

        public IEnumerable<Skill> GetAllSkills();
    }
}

