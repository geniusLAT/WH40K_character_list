using FluentMigrator;

namespace Wh40kCharacterList.WebApi.Migrations;

[Migration(1790161606, "initial")]
public sealed class Initial : Migration
{
    public override void Up()
    {
        Create.Table("user_tbl")
            .WithColumn("id").AsCustom("BIGSERIAL").Unique().NotNullable().PrimaryKey()
            .WithColumn("name").AsString().NotNullable()
            .WithColumn("admin").AsBoolean().NotNullable()
            .WithColumn("password").AsString().NotNullable()
            .WithColumn("last_token").AsString().NotNullable()
            .WithColumn("creation_date").AsDateTime().NotNullable().WithDefault(SystemMethods.CurrentUTCDateTime)
            .WithColumn("last_update").AsDateTime().NotNullable().WithDefault(SystemMethods.CurrentUTCDateTime);

        Create.Table("character_tbl")
            .WithColumn("id").AsCustom("BIGSERIAL").NotNullable().PrimaryKey()
            .WithColumn("json").AsString().NotNullable();

        Create.Table("character_right_tbl")
            .WithColumn("id").AsCustom("BIGSERIAL").NotNullable().PrimaryKey()
            .WithColumn("character_id").AsInt64().NotNullable().ForeignKey("character_tbl", "id")
            .WithColumn("user_id").AsInt64().NotNullable().ForeignKey("user_tbl", "id");
    }

    public override void Down()
    {
        Delete.Table("character_right_tbl");
        Delete.Table("character_tbl");
        Delete.Table("user_tbl");
    }
}
