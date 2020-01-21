using Microsoft.EntityFrameworkCore.Migrations;

namespace leave_management.Data.Migrations
{
    public partial class ChangedLeaveAllocationTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_leaveAllocation_AspNetUsers_EmployeeId",
                table: "leaveAllocation");

            migrationBuilder.DropForeignKey(
                name: "FK_leaveAllocation_LeaveType_LeaveTypeId",
                table: "leaveAllocation");

            migrationBuilder.DropPrimaryKey(
                name: "PK_leaveAllocation",
                table: "leaveAllocation");

            migrationBuilder.RenameTable(
                name: "leaveAllocation",
                newName: "LeaveAllocation");

            migrationBuilder.RenameIndex(
                name: "IX_leaveAllocation_LeaveTypeId",
                table: "LeaveAllocation",
                newName: "IX_LeaveAllocation_LeaveTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_leaveAllocation_EmployeeId",
                table: "LeaveAllocation",
                newName: "IX_LeaveAllocation_EmployeeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LeaveAllocation",
                table: "LeaveAllocation",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_LeaveAllocation_AspNetUsers_EmployeeId",
                table: "LeaveAllocation",
                column: "EmployeeId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_LeaveAllocation_LeaveType_LeaveTypeId",
                table: "LeaveAllocation",
                column: "LeaveTypeId",
                principalTable: "LeaveType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LeaveAllocation_AspNetUsers_EmployeeId",
                table: "LeaveAllocation");

            migrationBuilder.DropForeignKey(
                name: "FK_LeaveAllocation_LeaveType_LeaveTypeId",
                table: "LeaveAllocation");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LeaveAllocation",
                table: "LeaveAllocation");

            migrationBuilder.RenameTable(
                name: "LeaveAllocation",
                newName: "leaveAllocation");

            migrationBuilder.RenameIndex(
                name: "IX_LeaveAllocation_LeaveTypeId",
                table: "leaveAllocation",
                newName: "IX_leaveAllocation_LeaveTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_LeaveAllocation_EmployeeId",
                table: "leaveAllocation",
                newName: "IX_leaveAllocation_EmployeeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_leaveAllocation",
                table: "leaveAllocation",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_leaveAllocation_AspNetUsers_EmployeeId",
                table: "leaveAllocation",
                column: "EmployeeId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_leaveAllocation_LeaveType_LeaveTypeId",
                table: "leaveAllocation",
                column: "LeaveTypeId",
                principalTable: "LeaveType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
