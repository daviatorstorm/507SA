using _507SA.ModelsVM;
using _507SA.Session;
using AutoMapper;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _507SA
{
	public class MappingProfile : Profile
	{
		[Obsolete]
		protected override void Configure()
		{
			CreateMap<User, UserVM>()
				.ForMember(d => d.Message, o => o.Ignore())
				.ForMember(d => d.ConfirmPassword, o => o.Ignore());
			CreateMap<Nowelty, NoweltyVM>();
			CreateMap<Subject, SubjectVM>();
			CreateMap<User, UserContext>();
		}
	}
}