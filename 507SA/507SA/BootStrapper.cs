using _507SA.DependencyInjection;
using AutoMapper;


namespace _507SA
{
	public static class Bootstrapper
	{
		public static void Initialize()
		{
			DependencyResolverConfig.RegisterType(
				new WebTypeResolver()
			);

			Mapper.Initialize(config =>
			{
				config.AddProfile(new MappingProfile());
			});
			Mapper.AssertConfigurationIsValid();

		}
	}
}