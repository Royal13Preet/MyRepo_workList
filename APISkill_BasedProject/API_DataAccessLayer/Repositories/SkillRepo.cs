using API_DataAccessLayer.DBModel;

namespace API_DataAccessLayer.Repositories
{
    public class SkillRepo : ISkillRepo
    {
        private readonly AppDbContext _appDbContext;

        public SkillRepo(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        
        public bool AddSkill(Skill skill)
        {
            _appDbContext.Skills.Add(skill);
            _appDbContext.SaveChanges();
            return true;
        }
        
        public IEnumerable<Skill> GetAllSkills()
        {
            return _appDbContext.Skills;
        }
    }
}
