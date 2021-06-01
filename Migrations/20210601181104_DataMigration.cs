using Microsoft.EntityFrameworkCore.Migrations;

namespace ToDoListTeltonika.Migrations
{
    public partial class DataMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.InsertData(
            table: "Users",
            columns: new[] { "Email", "Password", "Role" },
            values: new object[,]
            {
                        {"admin@admin.com","KqoiNVvVzeUuyYaAHNaA","role1"},
                        {"user1@todo.com","ni6XYFcV4E7agdvOSIqI", "role2"},
                        {"user2@todo.com","2K3g4vbRvN0LVfL8yS5t", "role2"}
            });

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "UserId", "TaskDescription", "State" },
                values: new object[,]
                {
                        {"1","Wash dishes","Not completed"},
                        {"1","Clean dining table", "completed"},
                        {"2","Make dinner", "completed"},
                        {"2","Do laundry", "In progress" }
                });

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
