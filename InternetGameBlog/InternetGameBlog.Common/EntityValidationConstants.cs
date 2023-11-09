namespace InternetGameBlog.Common
{
	public static class EntityValidationConstants
	{
		public static class Game
		{
			public const int NameMinLength = 3;
			public const int NameMaxLength = 50;

			public const int CreatorCompanyMinLength = 3;
			public const int CreatorCompanyMaxLength = 50;
		}

		public static class Platform
		{
			public const int NameMinLength = 3;
			public const int NameMaxLength = 50;
		}

		public static class User
		{
			public const int FirstNameMinLength = 2;
			public const int FirstNameMaxLength = 50;

			public const int LastNameMinLength = 3;
			public const int LastNameMaxLength = 50;
		}
	}
}