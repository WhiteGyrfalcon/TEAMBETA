namespace InternetGameBlog.Common
{
	public static class EntityValidationConstants
	{
		public static class Game
		{
			public const int NameMinLength = 1;
			public const int NameMaxLength = 1;

			public const int CreatorCompanyMinLength = 1;
			public const int CreatorCompanyMaxLength = 1;

			public const int PlatformMinLength = 1;
			public const int PlatformMaxLength = 1;
		}

		public static class User
		{
			public const int PasswordMinLength = 6;
			public const int PasswordMaxLength = 100;

			public const int FirstNameMinLength = 2;
			public const int FirstNameMaxLength = 50;

			public const int LastNameMinLength = 3;
			public const int LastNameMaxLength = 50;
		}
	}
}