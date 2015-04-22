using AutoMapper;
using BSUIR.Chepurok.EducationEpam.BLL.Entities;
using BSUIR.Chepurok.EducationEpam.Entities.Models;
using System.Linq;

namespace BSUIR.Chepurok.EducationEpam.DI.AutoMapper
{
  public class EducationProfile : Profile
  {
    protected override void Configure()
    {
      Mapper.CreateMap<Answer, AnswerEntity>()
        .ForMember(d => d.ContentQuestion, s => s.MapFrom(t => t.Question.ContentQuestion));
      Mapper.CreateMap<AnswerEntity, Answer>();

      Mapper.CreateMap<Badge, BadgeEntity>();        
      Mapper.CreateMap<BadgeEntity, Badge>();

      Mapper.CreateMap<Category, CategoryEntity>();
      Mapper.CreateMap<CategoryEntity, Category>();

      Mapper.CreateMap<Comment, CommentEntity>()
        .ForMember(d => d.TitleLession, s => s.MapFrom(t => t.Lession.TitleLession))
        .ForMember(d => d.UserName, s => s.MapFrom(t => t.User.Firstname + " " + t.User.Surname));
      Mapper.CreateMap<CommentEntity, Comment>();

      Mapper.CreateMap<Lession, LessionEntity>()
        .ForMember(d => d.NameCategory, s => s.MapFrom(t => t.Category.Title))
        .ForMember(d => d.NameUser, s => s.ResolveUsing<UserLessionResolver>());        
      Mapper.CreateMap<LessionEntity, Lession>();

      Mapper.CreateMap<Like, LikeEntity>()
        .ForMember(d => d.NameUser, s => s.MapFrom(t => t.User.Firstname + " " + t.User.Surname));
      Mapper.CreateMap<LikeEntity, Like>();

      Mapper.CreateMap<News, NewsEntity>()
        .ForMember(d => d.NameUser, s => s.MapFrom(t => t.User.Firstname + " " + t.User.Surname));
      Mapper.CreateMap<NewsEntity, News>();
      
      Mapper.CreateMap<Post, PostEntity>()
        .ForMember(d => d.NameTopic, s => s.MapFrom(t => t.Topic.NameTopic))
        .ForMember(d => d.NameUser, s => s.MapFrom(t => t.User.Firstname + " " + t.User.Surname));
      Mapper.CreateMap<PostEntity, Post>();

      Mapper.CreateMap<Question, QuestionEntity>();
      Mapper.CreateMap<QuestionEntity, Question>();

      Mapper.CreateMap<Role, RoleEntity>();
      Mapper.CreateMap<RoleEntity, Role>();

      Mapper.CreateMap<Test, TestEntity>()
        .ForMember(d => d.NameLession, s => s.MapFrom(t => t.Lession.TitleLession));
      Mapper.CreateMap<TestEntity, Test>();

      Mapper.CreateMap<Topic, TopicEntity>()
        .ForMember(d => d.NameUser, s => s.MapFrom(t => t.User.Firstname + " " + t.User.Surname))
        .ForMember(d => d.CountPosts, s => s.MapFrom(t => t.Posts.Where(m => m.TopicID == t.TopicID).Count()));
      Mapper.CreateMap<TopicEntity, Topic>();

      Mapper.CreateMap<User, UserEntity>()
        .ForMember(d => d.NameRole, s => s.MapFrom(t => t.Role.NameRole))
        .ForMember(d => d.CountNews, s => s.MapFrom(t => t.News.Where(m => m.UserID == t.UserID).Count()))
        .ForMember(d => d.CountTopics, s => s.MapFrom(t => t.Topics.Where(m => m.UserID == t.UserID).Count()))
        .ForMember(d => d.CountPosts, s => s.MapFrom(t => t.Posts.Where(m => m.UserID == t.UserID).Count()));
      Mapper.CreateMap<UserEntity, User>();
    }
  }

  public class UserLessionResolver : ValueResolver<Lession, string>
  {
    protected override string ResolveCore(Lession source)
    {
      var user = source.Users.First(r => r.UserID == source.CreatorID);
      return user.Firstname + " " + user.Surname;
    }
  }
}