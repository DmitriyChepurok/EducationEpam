using AutoMapper;
using BSUIR.Chepurok.EducationEpam.BLL.Entities;
using BSUIR.Chepurok.EducationEpam.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSUIR.Chepurok.EducationEpam.DI.AutoMapper
{
  public class EducationProfile : Profile
  {
    protected override void Configure()
    {
      Mapper.CreateMap<Answer, AnswerEntity>();
      Mapper.CreateMap<AnswerEntity, Answer>();

      Mapper.CreateMap<Badge, BadgeEntity>();
      Mapper.CreateMap<BadgeEntity, Badge>();

      Mapper.CreateMap<Category, CategoryEntity>();
      Mapper.CreateMap<CategoryEntity, Category>();

      Mapper.CreateMap<Comment, CommentEntity>();
      Mapper.CreateMap<CommentEntity, Comment>();

      Mapper.CreateMap<Lession, LessionEntity>();
      Mapper.CreateMap<LessionEntity, Lession>();

      Mapper.CreateMap<Like, LikeEntity>();
      Mapper.CreateMap<LikeEntity, Like>();

      Mapper.CreateMap<News, NewsEntity>();
      Mapper.CreateMap<NewsEntity, News>();
      
      Mapper.CreateMap<Post, PostEntity>();
      Mapper.CreateMap<PostEntity, Post>();

      Mapper.CreateMap<Question, QuestionEntity>();
      Mapper.CreateMap<QuestionEntity, Question>();

      Mapper.CreateMap<Role, RoleEntity>();
      Mapper.CreateMap<RoleEntity, Role>();

      Mapper.CreateMap<Test, TestEntity>();
      Mapper.CreateMap<TestEntity, Test>();

      Mapper.CreateMap<Topic, TopicEntity>();
      Mapper.CreateMap<TopicEntity, Topic>();

      Mapper.CreateMap<User, UserEntity>()
        .ForMember(d => d.NameRole, s => s.MapFrom(t => t.Role.NameRole));
      Mapper.CreateMap<UserEntity, User>();
    }
  }
}
