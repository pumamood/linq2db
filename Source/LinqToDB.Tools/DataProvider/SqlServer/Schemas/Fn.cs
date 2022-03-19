﻿using System;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;

using JetBrains.Annotations;

using LinqToDB.Expressions;
using LinqToDB.SqlQuery;

namespace LinqToDB.Tools.DataProvider.SqlServer.Schemas
{
	[PublicAPI]
	public static class Fn
	{
		#region Data type

		/// <summary>
		/// <para><b><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/datalength-transact-sql">DATALENGTH (Transact-SQL)</see></b></para>
		/// <para>This function returns the number of bytes used to represent any expression.</para>
		/// <c>DATALENGTH</c> becomes really helpful when used with data types that can store variable-length data, such as:
		/// <list type="bullet">
		/// <item>ntext</item>
		/// <item>nvarchar</item>
		/// <item>text</item>
		/// <item>varbinary</item>
		/// <item>varchar</item>
		/// </list>
		/// <para>
		/// For a NULL value, <c>DATALENGTH</c> returns NULL.
		/// </para>
		/// <remarks type="note">
		/// Use the <see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/len-transact-sql">LEN</see>
		/// to return the number of characters encoded into a given string expression,
		/// and <see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/datalength-transact-sql">DATALENGTH</see> to return the size in bytes
		/// for a given string expression. These outputs may differ depending on the data type and type of encoding used in the column.
		/// For more information on storage differences between different encoding types,
		/// see <see href="https://docs.microsoft.com/en-us/sql/relational-databases/collations/collation-and-unicode-support">Collation and Unicode Support</see>.
		/// </remarks>
		/// </summary>
		/// <typeparam name="T">An <see href="https://docs.microsoft.com/en-us/sql/t-sql/language-elements/expressions-transact-sql">expression</see> of any data type.</typeparam>
		/// <param name="expression">An <see href="https://docs.microsoft.com/en-us/sql/t-sql/language-elements/expressions-transact-sql">expression</see> of any data type.</param>
		/// <returns><b>bigint</b> if expression has an <b>nvarchar(max)</b>, <b>varbinary(max)</b>, or <b>varchar(max)</b> data type; otherwise <b>int</b>.</returns>
		/// <exception cref="InvalidOperationException" />
		[Sql.Function(ProviderName.SqlServer, "DATALENGTH", 0, ServerSideOnly=true)]
		[return: NotNullIfNotNull("expression")]
		public static int? DataLength<T>(T expression)
		{
			throw new InvalidOperationException($"'{nameof(DataLength)}' is a server side only function.");
		}

		/// <summary>
		/// <para><b><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/datalength-transact-sql">DATALENGTH (Transact-SQL)</see></b></para>
		/// <para>This function returns the number of bytes used to represent any expression.</para>
		/// <c>DATALENGTH</c> becomes really helpful when used with data types that can store variable-length data, such as:
		/// <list type="bullet">
		/// <item>ntext</item>
		/// <item>nvarchar</item>
		/// <item>text</item>
		/// <item>varbinary</item>
		/// <item>varchar</item>
		/// </list>
		/// <para>
		/// For a NULL value, <c>DATALENGTH</c> returns NULL.
		/// </para>
		/// <remarks type="note">
		/// Use the <see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/len-transact-sql">LEN</see>
		/// to return the number of characters encoded into a given string expression,
		/// and <see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/datalength-transact-sql">DATALENGTH</see> to return the size in bytes
		/// for a given string expression. These outputs may differ depending on the data type and type of encoding used in the column.
		/// For more information on storage differences between different encoding types,
		/// see <see href="https://docs.microsoft.com/en-us/sql/relational-databases/collations/collation-and-unicode-support">Collation and Unicode Support</see>.
		/// </remarks>
		/// </summary>
		/// <typeparam name="T">An <see href="https://docs.microsoft.com/en-us/sql/t-sql/language-elements/expressions-transact-sql">expression</see> of any data type.</typeparam>
		/// <param name="expression">An <see href="https://docs.microsoft.com/en-us/sql/t-sql/language-elements/expressions-transact-sql">expression</see> of any data type.</param>
		/// <returns><b>bigint</b> if expression has an <b>nvarchar(max)</b>, <b>varbinary(max)</b>, or <b>varchar(max)</b> data type; otherwise <b>int</b>.</returns>
		/// <exception cref="InvalidOperationException" />
		[Sql.Function(ProviderName.SqlServer, "DATALENGTH", 0, ServerSideOnly=true)]
		[return: NotNullIfNotNull("expression")]
		public static long? DataLengthL<T>(T expression)
		{
			throw new InvalidOperationException($"'{nameof(DataLengthL)}' is a server side only function.");
		}

		/// <summary>
		/// <para><b><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/ident-current-transact-sql">IDENT_CURRENT (Transact-SQL)</see></b></para>
		/// <para>Returns the last identity value generated for a specified table or view. The last identity value generated can be for any session and any scope.</para>
		/// </summary>
		/// <param name="table_or_view">Is the name of the table or view whose identity value is returned. <c>table_or_view</c> is <b>varchar</b>, with no default.</param>
		/// <returns>numeric(<see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/max-precision-transact-sql">@@MAXPRECISION</see>, 0))</returns>
		/// <exception cref="InvalidOperationException" />
		[Sql.Function(ProviderName.SqlServer, "IDENT_CURRENT", ServerSideOnly=true)]
		public static decimal IdentityCurrent(string table_or_view)
		{
			throw new InvalidOperationException($"'{nameof(IdentityCurrent)}' is a server side only function.");
		}

		/// <summary>
		/// <para><b><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/ident-incr-transact-sql">IDENT_INCR (Transact-SQL)</see></b></para>
		/// <para>Returns the increment value specified when creating a table or view's identity column.</para>
		/// </summary>
		/// <param name="table_or_view">Is an <see href="https://docs.microsoft.com/en-us/sql/t-sql/language-elements/expressions-transact-sql">expression</see>
		/// specifying the table or view to check for a valid identity increment value.
		/// <c>table_or_view</c> can be a character string constant enclosed in quotation marks. It can also be a variable, a function, or a column name.
		/// <c>table_or_view</c> is <b>char</b>, <b>nchar</b>, <b>varchar</b>, or <b>nvarchar</b>.</param>
		/// <returns>numeric(<see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/max-precision-transact-sql">@@MAXPRECISION</see>, 0))</returns>
		/// <exception cref="InvalidOperationException" />
		[Sql.Function(ProviderName.SqlServer, "IDENT_INCR", ServerSideOnly=true)]
		public static decimal IdentityIncrement(string table_or_view)
		{
			throw new InvalidOperationException($"'{nameof(IdentityIncrement)}' is a server side only function.");
		}

		/// <summary>
		/// <para><b><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/ident-seed-transact-sql">IDENT_SEED (Transact-SQL)</see></b></para>
		/// <para>Returns the original seed value specified when creating an identity column in a table or a view.
		/// Changing the current value of an identity column by using DBCC CHECKIDENT doesn't change the value returned by this function.</para>
		/// </summary>
		/// <param name="table_or_view">Is an <see href="https://docs.microsoft.com/en-us/sql/t-sql/language-elements/expressions-transact-sql">expression</see>
		/// specifying the table or view to check for a valid identity increment value.
		/// <c>table_or_view</c> can be a character string constant enclosed in quotation marks. It can also be a variable, a function, or a column name.
		/// <c>table_or_view</c> is <b>char</b>, <b>nchar</b>, <b>varchar</b>, or <b>nvarchar</b>.</param>
		/// <returns>numeric(<see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/max-precision-transact-sql">@@MAXPRECISION</see>, 0))</returns>
		/// <exception cref="InvalidOperationException" />
		[Sql.Function(ProviderName.SqlServer, "IDENT_SEED", ServerSideOnly=true)]
		public static decimal IdentitySeed(string table_or_view)
		{
			throw new InvalidOperationException($"'{nameof(IdentitySeed)}' is a server side only function.");
		}

		#endregion

		#region Metadata

		/// <summary>
		/// <para><b><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/app-name-transact-sql">APP_NAME (Transact-SQL)</see></b></para>
		/// <para>This function returns the application name for the current session, if the application sets that name value.</para>
		/// </summary>
		/// <returns>nvarchar(128)</returns>
		/// <exception cref="InvalidOperationException" />
		[Sql.Function(ProviderName.SqlServer, "APP_NAME", ServerSideOnly=true)]
		public static string AppName()
		{
			throw new InvalidOperationException($"'{nameof(AppName)}' is a server side only function.");
		}

		/// <summary>
		/// <para><b><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/col-length-transact-sql">COL_LENGTH (Transact-SQL)</see></b></para>
		/// <para>This function returns the defined length of a column, in bytes.</para>
		/// </summary>
		/// <param name="table">The name of the table whose column length information we want to determine. <c>table</c> is an expression of type <b>nvarchar</b>.</param>
		/// <param name="column">The column name whose length we want to determine. <c>column</c> is an expression of type <b>nvarchar</b>.</param>
		/// <returns>smallint</returns>
		/// <exception cref="InvalidOperationException" />
		[Sql.Function(ProviderName.SqlServer, "COL_LENGTH", ServerSideOnly=true)]
		public static short? ColumnLength(string table, string column)
		{
			throw new InvalidOperationException($"'{nameof(ColumnLength)}' is a server side only function.");
		}

		/// <summary>
		/// <para><b><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/col-name-transact-sql">COL_NAME (Transact-SQL)</see></b></para>
		/// <para>This function returns the name of a table column, based on the table identification number and column identification number values of that table column.</para>
		/// </summary>
		/// <param name="table_id">The identification number of the table containing that column. The <c>table_id</c> argument has an <b>int</b> data type.</param>
		/// <param name="column_id">The identification number of the column. The <c>column_id</c> argument has an <b>int</b> data type.</param>
		/// <returns>sysname</returns>
		/// <exception cref="InvalidOperationException" />
		[Sql.Function(ProviderName.SqlServer, "COL_NAME", ServerSideOnly=true)]
		public static string? ColumnName(int? table_id, int column_id)
		{
			throw new InvalidOperationException($"'{nameof(ColumnName)}' is a server side only function.");
		}

		public enum ColumnPropertyName
		{
			AllowsNull,
			ColumnId,
			FullTextTypeColumn,
			GeneratedAlwaysType,
			IsColumnSet,
			IsComputed,
			IsCursorType,
			IsDeterministic,
			IsFulltextIndexed,
			IsHidden,
			IsIdentity,
			IsIdNotForRepl,
			IsIndexable,
			IsOutParam,
			IsPrecise,
			IsRowGuidCol,
			IsSparse,
			IsSystemVerified,
			IsXmlIndexable,
			Precision,
			Scale,
			StatisticalSemantics,
			SystemDataAccess,
			UserDataAccess,
			UsesAnsiTrim,
		}

		/// <summary>
		/// <para><b><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/columnproperty-transact-sql">COLUMNPROPERTY (Transact-SQL)</see></b></para>
		/// <para>This function returns column or parameter information.</para>
		/// </summary>
		/// <param name="id">An <see href="https://docs.microsoft.com/en-us/sql/t-sql/language-elements/expressions-transact-sql">expression</see>
		/// containing the identifier (ID) of the table or procedure.</param>
		/// <param name="column">An expression containing the name of the column or parameter.</param>
		/// <param name="property">For the <c>id</c> argument, the property argument specifies the information type that the <c>COLUMNPROPERTY</c> function will return.</param>
		/// <returns>int</returns>
		/// <exception cref="InvalidOperationException" />
		[Sql.Extension(ProviderName.SqlServer, "COLUMNPROPERTY", ServerSideOnly=true, BuilderType=typeof(PropertyBuilder<ColumnPropertyName>))]
		public static int? ColumnProperty(int? id, string column, [SqlQueryDependent] ColumnPropertyName property)
		{
			throw new InvalidOperationException($"'{nameof(ColumnProperty)}' is a server side only function.");
		}

		public enum DatabasePropertyName
		{
			Collation,
			ComparisonStyle,
			Edition,
			IsAnsiNullDefault,
			IsAnsiNullsEnabled,
			IsAnsiPaddingEnabled,
			IsAnsiWarningsEnabled,
			IsArithmeticAbortEnabled,
			IsAutoClose,
			IsAutoCreateStatistics,
			IsAutoCreateStatisticsIncremental,
			IsAutoShrink,
			IsAutoUpdateStatistics,
			IsClone,
			IsCloseCursorsOnCommitEnabled,
			IsFulltextEnabled,
			IsInStandBy,
			IsLocalCursorsDefault,
			IsMemoryOptimizedElevateToSnapshotEnabled,
			IsMergePublished,
			IsNullConcat,
			IsNumericRoundAbortEnabled,
			IsParameterizationForced,
			IsQuotedIdentifiersEnabled,
			IsPublished,
			IsRecursiveTriggersEnabled,
			IsSubscribed,
			IsSyncWithBackup,
			IsTornPageDetectionEnabled,
			IsVerifiedClone,
			IsXTPSupported,
			LastGoodCheckDbTime,
			LCID,
			MaxSizeInBytes,
			Recovery,
			ServiceObjective,
			ServiceObjectiveId,
			SQLSortOrder,
			Status,
			Updateability,
			UserAccess,
			Version,
		}

		/// <summary>
		/// <para><b><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/databasepropertyex-transact-sql">DATABASEPROPERTYEX (Transact-SQL)</see></b></para>
		/// <para>For a specified database in SQL Server, this function returns the current setting of the specified database option or property.</para>
		/// </summary>
		/// <param name="database">An expression specifying the name of the database for which <c>DATABASEPROPERTYEX</c> will return the named property information.
		/// <c>database</c> has an <b>nvarchar(128)</b> data type.</param>
		/// <param name="property">An expression specifying the name of the database property to return. <c>property</c> has a <b>varchar(128)</b> data type</param>
		/// <returns>sql_variant</returns>
		/// <exception cref="InvalidOperationException" />
		[Sql.Extension(ProviderName.SqlServer, "DATABASEPROPERTYEX", ServerSideOnly=true, BuilderType=typeof(PropertyBuilder<DatabasePropertyName>))]
		public static object? DatabasePropertyEx(string database, [SqlQueryDependent] DatabasePropertyName property)
		{
			throw new InvalidOperationException($"'{nameof(DatabasePropertyEx)}' is a server side only function.");
		}

		/// <summary>
		/// <para><b><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/db-id-transact-sql">DB_ID (Transact-SQL)</see></b></para>
		/// <para>This function returns the database identification (ID) number of a specified database.</para>
		/// </summary>
		/// <param name="database_name">The name of the database whose database ID number <c>DB_ID</c> will return.
		/// If the call to <c>DB_ID</c> omits <c>database_name</c>, <c>DB_ID</c> returns the ID of the current database.</param>
		/// <returns>int</returns>
		/// <exception cref="InvalidOperationException" />
		[Sql.Function(ProviderName.SqlServer, "DB_ID", ServerSideOnly=true)]
		public static int? DbID(string database_name)
		{
			throw new InvalidOperationException($"'{nameof(DbID)}' is a server side only function.");
		}

		/// <summary>
		/// <para><b><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/db-id-transact-sql">DB_ID (Transact-SQL)</see></b></para>
		/// <para>This function returns the database identification (ID) number of a specified database.</para>
		/// </summary>
		/// <returns>int</returns>
		/// <exception cref="InvalidOperationException" />
		[Sql.Function(ProviderName.SqlServer, "DB_ID", ServerSideOnly=true)]
		public static int DbID()
		{
			throw new InvalidOperationException($"'{nameof(DbID)}' is a server side only function.");
		}

		/// <summary>
		/// <para><b><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/db-name-transact-sql">DB_NAME (Transact-SQL)</see></b></para>
		/// <para>This function returns the name of a specified database.</para>
		/// </summary>
		/// <param name="database_id">The identification number (ID) of the database whose name <c>DB_NAME</c> will return.
		/// If the call to <c>DB_NAME</c> omits <c>database_id</c>, <c>DB_NAME</c> returns the name of the current database.</param>
		/// <returns>nvarchar(128)</returns>
		/// <exception cref="InvalidOperationException" />
		[Sql.Function(ProviderName.SqlServer, "DB_NAME", ServerSideOnly=true)]
		public static string? DbName(int database_id)
		{
			throw new InvalidOperationException($"'{nameof(DbName)}' is a server side only function.");
		}

		/// <summary>
		/// <para><b><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/db-name-transact-sql">DB_NAME (Transact-SQL)</see></b></para>
		/// <para>This function returns the name of a specified database.</para>
		/// </summary>
		/// <returns>nvarchar(128)</returns>
		/// <exception cref="InvalidOperationException" />
		[Sql.Function(ProviderName.SqlServer, "DB_NAME", ServerSideOnly=true)]
		public static string DbName()
		{
			throw new InvalidOperationException($"'{nameof(DbName)}' is a server side only function.");
		}

		/// <summary>
		/// <para><b><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/file-id-transact-sql">FILE_ID (Transact-SQL)</see></b></para>
		/// <para>For the given logical name for a component file of the current database, this function returns the file identification (ID) number.</para>
		/// </summary>
		/// <param name="file_name">An expression of type <b>sysname</b>, representing the logical name of the file whose file ID value <c>FILE_ID</c> will return.</param>
		/// <returns>smallint</returns>
		/// <exception cref="InvalidOperationException" />
		[Sql.Function(ProviderName.SqlServer, "FILE_ID", ServerSideOnly=true)]
		public static short? FileID(string? file_name)
		{
			throw new InvalidOperationException($"'{nameof(FileID)}' is a server side only function.");
		}

		/// <summary>
		/// <para><b><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/file-idex-transact-sql">FILE_IDEX (Transact-SQL)</see></b></para>
		/// <para>This function returns the file identification (ID) number for the specified logical name of a data, log, or full-text file of the current database.</para>
		/// </summary>
		/// <param name="file_name">An expression of type <b>sysname</b> that returns the file ID value 'FILE_IDEX' for the name of the file.</param>
		/// <returns>int</returns>
		/// <exception cref="InvalidOperationException" />
		[Sql.Function(ProviderName.SqlServer, "FILE_IDEX", ServerSideOnly=true)]
		public static int? FileIDEx(string? file_name)
		{
			throw new InvalidOperationException($"'{nameof(FileIDEx)}' is a server side only function.");
		}

		/// <summary>
		/// <para><b><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/file-name-transact-sql">FILE_NAME (Transact-SQL)</see></b></para>
		/// <para>This function returns the logical file name for a given file identification (ID) number.</para>
		/// </summary>
		/// <param name="file_id">The file identification number whose file name <c>FILE_NAME</c> will return. file_id has an <b>int</b> data type.</param>
		/// <returns>nvarchar(128)</returns>
		/// <exception cref="InvalidOperationException" />
		[Sql.Function(ProviderName.SqlServer, "FILE_NAME", ServerSideOnly=true)]
		public static string? FileName(int? file_id)
		{
			throw new InvalidOperationException($"'{nameof(FileName)}' is a server side only function.");
		}

		/// <summary>
		/// <para><b><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/filegroup-id-transact-sql">FILEGROUP_ID (Transact-SQL)</see></b></para>
		/// <para>This function returns the filegroup identification (ID) number for a specified filegroup name.</para>
		/// </summary>
		/// <param name="filegroup_name">An expression of type <b>sysname</b>, representing the filegroup name whose filegroup ID <c>FILEGROUP_ID</c> will return.</param>
		/// <returns>int</returns>
		/// <exception cref="InvalidOperationException" />
		[Sql.Function(ProviderName.SqlServer, "FILEGROUP_ID", ServerSideOnly=true)]
		public static int? FileGroupID(string? filegroup_name)
		{
			throw new InvalidOperationException($"'{nameof(FileGroupID)}' is a server side only function.");
		}

		/// <summary>
		/// <para><b><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/filegroup-name-transact-sql">FILEGROUP_NAME (Transact-SQL)</see></b></para>
		/// <para>This function returns the filegroup name for the specified filegroup identification (ID) number.</para>
		/// </summary>
		/// <param name="filegroup_id">The filegroup ID number whose filegroup name <c>FILEGROUP_NAME</c> will return. filegroup_id has a <b>smallint</b> data type.</param>
		/// <returns>nvarchar(128)</returns>
		/// <exception cref="InvalidOperationException" />
		[Sql.Function(ProviderName.SqlServer, "FILEGROUP_Name", ServerSideOnly=true)]
		public static string? FileGroupName(short? filegroup_id)
		{
			throw new InvalidOperationException($"'{nameof(FileGroupName)}' is a server side only function.");
		}

		public enum FileGroupPropertyName
		{
			IsReadOnly,
			IsUserDefinedFG,
			IsDefault,
		}

		/// <summary>
		/// <para><b><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/FILEGROUPPROPERTY-transact-sql">FILEGROUPPROPERTY (Transact-SQL)</see></b></para>
		/// <para>This function returns the filegroup property value for a specified name and filegroup value.</para>
		/// </summary>
		/// <param name="filegroup_name">An expression of type <b>sysname</b> that represents the filegroup name for which
		/// <c>FILEGROUPPROPERTY</c> returns the named property information.</param>
		/// <param name="property">An expression of type <b>varchar(128)</b> that returns the name of the filegroup property.</param>
		/// <returns>int</returns>
		/// <exception cref="InvalidOperationException" />
		[Sql.Extension(ProviderName.SqlServer, "FILEGROUPPROPERTY", ServerSideOnly=true, BuilderType=typeof(PropertyBuilder<FileGroupPropertyName>))]
		public static int? FileGroupProperty(string? filegroup_name, [SqlQueryDependent] FileGroupPropertyName property)
		{
			throw new InvalidOperationException($"'{nameof(FileGroupProperty)}' is a server side only function.");
		}

		public enum FilePropertyName
		{
			IsReadOnly,
			IsPrimaryFile,
			IsLogFile,
			SpaceUsed,
		}

		/// <summary>
		/// <para><b><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/FILEPROPERTY-transact-sql">FILEPROPERTY (Transact-SQL)</see></b></para>
		/// <para>Returns the specified file name property value when a file name in the current database and a property name are specified.
		/// Returns NULL for files that are not in the current database.</para>
		/// </summary>
		/// <param name="file_name">Is an expression that contains the name of the file associated with the current database for which to return property information.
		/// <c>file_name</c> is <b>nchar(128)</b>.</param>
		/// <param name="property">Is an expression that contains the name of the file property to return. <c>property</c> is <b>varchar(128)</b>,
		/// and can be one of the following values.</param>
		/// <returns>int</returns>
		/// <exception cref="InvalidOperationException" />
		[Sql.Extension(ProviderName.SqlServer, "FILEPROPERTY", ServerSideOnly=true, BuilderType=typeof(PropertyBuilder<FilePropertyName>))]
		public static int? FileProperty(string? file_name, [SqlQueryDependent] FilePropertyName property)
		{
			throw new InvalidOperationException($"'{nameof(FileProperty)}' is a server side only function.");
		}

		public enum FilePropertyExName
		{
			BlobTier,
			AccountType,
			IsInferredTier,
			IsPageBlob,
		}

		/// <summary>
		/// <para><b><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/FILEPROPERTYEX-transact-sql">FILEPROPERTYEX (Transact-SQL)</see></b></para>
		/// <para>Returns the specified extended file property value when a file name in the current database and a property name are specified.
		/// Returns NULL for files that are not in the current database or for extended file properties that do not exist.
		/// Currently, extended file properties only apply to databases that are in Azure Blob storage.</para>
		/// </summary>
		/// <param name="file_name">Is an expression that contains the name of the file associated with the current database for which to return property information.
		/// <c>file_name</c> is <b>nchar(128)</b>.</param>
		/// <param name="property">Is an expression that contains the name of the file property to return. <c>property</c> is <b>varchar(128)</b>,
		/// and can be one of the following values.</param>
		/// <returns>sql_variant</returns>
		/// <exception cref="InvalidOperationException" />
		[Sql.Extension(ProviderName.SqlServer, "FILEPROPERTYEX", ServerSideOnly=true, BuilderType=typeof(PropertyBuilder<FilePropertyExName>))]
		public static object? FilePropertyEx(string? file_name, [SqlQueryDependent] FilePropertyExName property)
		{
			throw new InvalidOperationException($"'{nameof(FileProperty)}' is a server side only function.");
		}

		public enum FullTextCatalogPropertyName
		{
			AccentSensitivity,
			IndexSize,
			ItemCount,
			LogSize,
			MergeStatus,
			PopulateCompletionAge,
			PopulateStatus,
			UniqueKeyCount,
			ImportStatus,
		}

		/// <summary>
		/// <para><b><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/FULLTEXTCATALOGPROPERTY-transact-sql">FULLTEXTCATALOGPROPERTY (Transact-SQL)</see></b></para>
		/// <para>Returns information about full-text catalog properties in SQL Server.</para>
		/// </summary>
		/// <param name="catalog_name">Is an expression containing the name of the full-text catalog.</param>
		/// <param name="property">Is an expression containing the name of the full-text catalog property.
		/// The table lists the properties and provides descriptions of the information returned.</param>
		/// <returns>int</returns>
		/// <exception cref="InvalidOperationException" />
		[Sql.Extension(ProviderName.SqlServer, "FULLTEXTCATALOGPROPERTY", ServerSideOnly=true, BuilderType=typeof(PropertyBuilder<FullTextCatalogPropertyName>))]
		public static int? FullTextCatalogProperty(string? catalog_name, [SqlQueryDependent] FullTextCatalogPropertyName property)
		{
			throw new InvalidOperationException($"'{nameof(FullTextCatalogProperty)}' is a server side only function.");
		}

		public enum FullTextServicePropertyName
		{
			ResourceUsage,
			ConnectTimeout,
			IsFulltextInstalled,
			DataTimeout,
			LoadOSResources,
			VerifySignature,
		}

		/// <summary>
		/// <para><b><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/FULLTEXTSERVICEPROPERTY-transact-sql">FULLTEXTSERVICEPROPERTY (Transact-SQL)</see></b></para>
		/// <para>Returns information related to the properties of the Full-Text Engine. These properties can be set and retrieved by using <b>sp_fulltext_service</b>.</para>
		/// </summary>
		/// <param name="property">Is an expression containing the name of the full-text service-level property.
		/// The table lists the properties and provides descriptions of the information returned.</param>
		/// <returns>int</returns>
		/// <exception cref="InvalidOperationException" />
		[Sql.Extension(ProviderName.SqlServer, "FULLTEXTSERVICEPROPERTY", ServerSideOnly=true, BuilderType=typeof(PropertyBuilder<FullTextServicePropertyName>))]
		public static int? FullTextServiceProperty([SqlQueryDependent] FullTextServicePropertyName property)
		{
			throw new InvalidOperationException($"'{nameof(FullTextServiceProperty)}' is a server side only function.");
		}

		/// <summary>
		/// <para><b><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/index-col-transact-sql">INDEX_COL (Transact-SQL)</see></b></para>
		/// <para>Returns the indexed column name. Returns NULL for XML indexes.</para>
		/// </summary>
		/// <param name="table_or_view">Is the name of the table or indexed view. <c>table_or_view_name</c> must be delimited by single quotation marks and
		/// can be fully qualified by database name and schema name.</param>
		/// <param name="index_id">Is the ID of the index. <c>index_ID</c> is <b>int</b>.</param>
		/// <param name="key_id">Is the index key column position. <c>key_ID</c> is <b>int</b>.</param>
		/// <returns>nvarchar(128)</returns>
		/// <exception cref="InvalidOperationException" />
		[Sql.Function(ProviderName.SqlServer, "INDEX_COL", ServerSideOnly=true)]
		public static string? IndexColumn(string table_or_view, int index_id, int key_id)
		{
			throw new InvalidOperationException($"'{nameof(IndexColumn)}' is a server side only function.");
		}

		public enum IndexKeyPropertyName
		{
			ColumnId,
			IsDescending,
		}

		/// <summary>
		/// <para><b><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/INDEXKEY-PROPERTY-transact-sql">INDEXKEY_PROPERTY (Transact-SQL)</see></b></para>
		/// <para>Returns information about the index key. Returns NULL for XML indexes.</para>
		/// </summary>
		/// <param name="object_ID">Is the object identification number of the table or indexed view. <c>object_ID</c> is <b>int</b>.</param>
		/// <param name="index_ID">Is the index identification number. <c>index_ID</c> is <b>int</b>.</param>
		/// <param name="key_ID">Is the index key column position. <c>key_ID</c> is <b>int</b>.</param>
		/// <param name="property">Is the name of the property for which information will be returned.
		/// <c>property</c> is a character string and can be one of the following values.</param>
		/// <returns>int</returns>
		/// <exception cref="InvalidOperationException" />
		[Sql.Extension(ProviderName.SqlServer, "INDEXKEY_PROPERTY", ServerSideOnly=true, BuilderType=typeof(PropertyBuilder<IndexKeyPropertyName>))]
		public static int? IndexKeyProperty(int? object_ID, int? index_ID, int? key_ID, [SqlQueryDependent] IndexKeyPropertyName property)
		{
			throw new InvalidOperationException($"'{nameof(IndexKeyProperty)}' is a server side only function.");
		}

		public enum IndexPropertyName
		{
			IndexDepth,
			IndexFillFactor,
			IndexID,
			IsAutoStatistics,
			IsClustered,
			IsDisabled,
			IsFulltextKey,
			IsHypothetical,
			IsPadIndex,
			IsPageLockDisallowed,
			IsRowLockDisallowed,
			IsStatistics,
			IsUnique,
			IsColumnstore,
			IsOptimizedForSequentialKey,
		}

		/// <summary>
		/// <para><b><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/INDEXPROPERTY-transact-sql">INDEXPROPERTY (Transact-SQL)</see></b></para>
		/// <para>Returns information about the index key. Returns NULL for XML indexes.</para>
		/// </summary>
		/// <param name="object_ID">Is an expression that contains the object identification number of the table or indexed view for
		/// which to provide index property information.  <c>object_ID</c> is <b>int</b>.</param>
		/// <param name="index_or_statistics_name">Is an expression that contains the name of the index or statistics for which to return property information.
		/// <c>index_or_statistics_name</c> is <b>nvarchar(128).</b></param>
		/// <param name="property">Is an expression that contains the name of the database property to return.
		/// <c>property</c> is <b>varchar(128)</b>, and can be one of these values.</param>
		/// <returns>int</returns>
		/// <exception cref="InvalidOperationException" />
		[Sql.Extension(ProviderName.SqlServer, "INDEXPROPERTY", ServerSideOnly=true, BuilderType=typeof(PropertyBuilder<IndexPropertyName>))]
		public static int? IndexProperty(int? object_ID, string? index_or_statistics_name, [SqlQueryDependent] IndexPropertyName property)
		{
			throw new InvalidOperationException($"'{nameof(IndexProperty)}' is a server side only function.");
		}

		class NextValueForBuilder : Sql.IExtensionCallBuilder
		{
			public void Build(Sql.ISqExtensionBuilder builder)
			{
				builder.AddExpression("sequence_name", builder.GetValue<string>("sequence_name"));
			}
		}

		/// <summary>
		/// <para><b><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/NEXT-VALUE-FOR-transact-sql">NEXT VALUE FOR (Transact-SQL)</see></b></para>
		/// <para>Generates a sequence number from the specified sequence object.</para>
		/// </summary>
		/// <param name="sequence_name">The name of the sequence object that generates the number.</param>
		/// <returns>Returns a number using the type of the sequence.</returns>
		/// <exception cref="InvalidOperationException" />
		[Sql.Extension(ProviderName.SqlServer, "NEXT VALUE FOR {sequence_name}", ServerSideOnly=true, BuilderType=typeof(NextValueForBuilder))]
		public static object? NextValueFor([SqlQueryDependent] string sequence_name)
		{
			throw new InvalidOperationException($"'{nameof(NextValueFor)}' is a server side only function.");
		}

		/// <summary>
		/// <para><b><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/NEXT-VALUE-FOR-transact-sql">NEXT VALUE FOR (Transact-SQL)</see></b></para>
		/// <para>Generates a sequence number from the specified sequence object.</para>
		/// </summary>
		/// <param name="sequence_name">The name of the sequence object that generates the number.</param>
		/// <returns>Returns a number using the type of the sequence.</returns>
		/// <exception cref="InvalidOperationException" />
		[Sql.Extension(ProviderName.SqlServer, "NEXT VALUE FOR {sequence_name} OVER ({order_by_clause})",
			ServerSideOnly=true, BuilderType=typeof(NextValueForBuilder), ChainPrecedence=1)]
		public static AnalyticFunctions.INeedsOrderByOnly<object?> NextValueForOver([SqlQueryDependent] string sequence_name)
		{
			throw new InvalidOperationException($"'{nameof(NextValueForOver)}' is a server side only function.");
		}











		/// <summary>
		/// <para><b><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/object-id-transact-sql">OBJECT_ID (Transact-SQL)</see></b></para>
		/// <para>Returns the database object identification number of a schema-scoped object.</para>
		/// </summary>
		/// <param name="object_name">Is the object to be used. <c>object_name</c> is either <b>varchar</b> or <b>nvarchar</b>. If <c>object_name</c> is <b>varchar</b>,
		/// it is implicitly converted to <b>nvarchar</b>. Specifying the database and schema names is optional.</param>
		/// <returns>int</returns>
		/// <exception cref="InvalidOperationException" />
		[Sql.Function(ProviderName.SqlServer, "OBJECT_ID", ServerSideOnly=true)]
		public static int? ObjectID(string object_name)
		{
			throw new InvalidOperationException($"'{nameof(ObjectID)}' is a server side only function.");
		}

		/// <summary>
		/// <para><b><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/object-id-transact-sql">OBJECT_ID (Transact-SQL)</see></b></para>
		/// <para>Returns the database object identification number of a schema-scoped object.</para>
		/// </summary>
		/// <param name="object_name">Is the object to be used. <c>object_name</c> is either <b>varchar</b> or <b>nvarchar</b>. If <c>object_name</c> is <b>varchar</b>,
		/// it is implicitly converted to <b>nvarchar</b>. Specifying the database and schema names is optional.</param>
		/// <param name="object_type">Is the schema-scoped object type. <c>object_type</c> is either <b>varchar</b> or <b>nvarchar</b>.
		/// If <c>object_type</c> is varchar, it is implicitly converted to <b>nvarchar</b>. For a list of object <b>types</b>, see the type column in
		/// <see href="https://docs.microsoft.com/en-us/sql/relational-databases/system-catalog-views/sys-objects-transact-sql">sys.objects (Transact-SQL)</see>.</param>
		/// <returns>int</returns>
		/// <exception cref="InvalidOperationException" />
		[Sql.Function(ProviderName.SqlServer, "OBJECT_ID", ServerSideOnly=true)]
		public static int? ObjectID(string object_name, string object_type)
		{
			throw new InvalidOperationException($"'{nameof(ObjectID)}' is a server side only function.");
		}

		#endregion

		class PropertyBuilder<T> : Sql.IExtensionCallBuilder
		{
			public void Build(Sql.ISqExtensionBuilder builder)
			{
				var method = (MethodInfo)builder.Member;
				var props  = method.GetParameters();
				var ps     = new ISqlExpression[props.Length];

				for (var i = 0; i < props.Length; i++)
				{
					var prop = props[i];

					ps[i] = prop.ParameterType == typeof(T)
						? new SqlExpression('\'' + builder.GetValue<T>(prop.Name!)?.ToString() + '\'', Precedence.Primary)
						: builder.GetExpression(prop.Name!);
				}

				builder.ResultExpression = new SqlFunction(method.ReturnType, builder.Expression, ps);
			}
		}
	}
}
