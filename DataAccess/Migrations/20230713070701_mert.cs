using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class mert : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Apis",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApiAdress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Apis", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Calibrations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TimeStamp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Parameter = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ZeroRef = table.Column<double>(type: "float", nullable: false),
                    ZeroMeas = table.Column<double>(type: "float", nullable: false),
                    ZeroDiff = table.Column<double>(type: "float", nullable: false),
                    ZeroStd = table.Column<double>(type: "float", nullable: false),
                    SpanRef = table.Column<double>(type: "float", nullable: false),
                    SpanMeas = table.Column<double>(type: "float", nullable: false),
                    SpanDiff = table.Column<double>(type: "float", nullable: false),
                    SpanStd = table.Column<double>(type: "float", nullable: false),
                    ResultFactor = table.Column<double>(type: "float", nullable: false),
                    IsItValid = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Calibrations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Channels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DesarjDebiRead = table.Column<bool>(type: "bit", nullable: false),
                    DesarjDebiSend = table.Column<bool>(type: "bit", nullable: false),
                    HariciDebiRead = table.Column<bool>(type: "bit", nullable: false),
                    HariciDebiSend = table.Column<bool>(type: "bit", nullable: false),
                    HariciDebi2Read = table.Column<bool>(type: "bit", nullable: false),
                    HariciDebi2Send = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Channels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DB12s",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HaftaGunu = table.Column<byte>(type: "tinyint", nullable: false),
                    HaftaGunuSaat = table.Column<byte>(type: "tinyint", nullable: false),
                    HaftaGunuDakika = table.Column<byte>(type: "tinyint", nullable: false),
                    GunlukYikamaSaat = table.Column<byte>(type: "tinyint", nullable: false),
                    GunlukYikamaDakika = table.Column<byte>(type: "tinyint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DB12s", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DB41s",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TesisDebi = table.Column<double>(type: "float", nullable: false),
                    TesisGünlükDebi = table.Column<double>(type: "float", nullable: false),
                    DesarjDebi = table.Column<double>(type: "float", nullable: false),
                    HariciDebi = table.Column<double>(type: "float", nullable: false),
                    HariciDebi2 = table.Column<double>(type: "float", nullable: false),
                    NumuneHiz = table.Column<double>(type: "float", nullable: false),
                    NumuneDebi = table.Column<double>(type: "float", nullable: false),
                    Ph = table.Column<double>(type: "float", nullable: false),
                    Iletkenlik = table.Column<double>(type: "float", nullable: false),
                    CozunmusOksijen = table.Column<double>(type: "float", nullable: false),
                    NumuneSicaklik = table.Column<double>(type: "float", nullable: false),
                    Koi = table.Column<double>(type: "float", nullable: false),
                    Akm = table.Column<double>(type: "float", nullable: false),
                    KabinNem = table.Column<double>(type: "float", nullable: false),
                    KabinSicaklik = table.Column<double>(type: "float", nullable: false),
                    Pompa1Hz = table.Column<double>(type: "float", nullable: false),
                    Pompa2Hz = table.Column<double>(type: "float", nullable: false),
                    UpsGirisVolt = table.Column<double>(type: "float", nullable: false),
                    UpsCikisVolt = table.Column<double>(type: "float", nullable: false),
                    UpsKapasite = table.Column<double>(type: "float", nullable: false),
                    UpsSicaklik = table.Column<double>(type: "float", nullable: false),
                    UpsYuk = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DB41s", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DB4s",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SystemTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DB4s", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "InputTags",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReadTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Kapi = table.Column<bool>(type: "bit", nullable: false),
                    Duman = table.Column<bool>(type: "bit", nullable: false),
                    SuBaskini = table.Column<bool>(type: "bit", nullable: false),
                    AcilStop = table.Column<bool>(type: "bit", nullable: false),
                    Pompa1Termik = table.Column<bool>(type: "bit", nullable: false),
                    Pompa2Termik = table.Column<bool>(type: "bit", nullable: false),
                    TemizSuTermik = table.Column<bool>(type: "bit", nullable: false),
                    YikamaTanki = table.Column<bool>(type: "bit", nullable: false),
                    Enerji = table.Column<bool>(type: "bit", nullable: false),
                    Pompa1CalisiyorMu = table.Column<bool>(type: "bit", nullable: false),
                    Pompa2CalisiyorMu = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InputTags", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MailServers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UseSSL = table.Column<bool>(type: "bit", nullable: false),
                    Host = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Port = table.Column<int>(type: "int", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UseDefaultCredentials = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MailServers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MailStatements",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StatementName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Parameter = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Statement = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LowerLimit = table.Column<double>(type: "float", nullable: true),
                    UpperLimit = table.Column<double>(type: "float", nullable: true),
                    CoolDown = table.Column<TimeSpan>(type: "time", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MailStatements", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MBTags",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReadTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    YikamaVarMi = table.Column<bool>(type: "bit", nullable: false),
                    HaftalikYikamaVarMi = table.Column<bool>(type: "bit", nullable: false),
                    ModAutoMu = table.Column<bool>(type: "bit", nullable: false),
                    ModBakimMi = table.Column<bool>(type: "bit", nullable: false),
                    ModKalibrasyonMu = table.Column<bool>(type: "bit", nullable: false),
                    AkmTetik = table.Column<bool>(type: "bit", nullable: false),
                    KoiTetik = table.Column<bool>(type: "bit", nullable: false),
                    PhTetik = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MBTags", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OperationClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OperationClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Plcs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IpAdress = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plcs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Samples",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SampleCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SampleType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PlaceOfDelivery = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastState = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sampler = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Samples", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SendDatas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Stationid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Readtime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SoftwareVersion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AkisHizi = table.Column<double>(type: "float", nullable: false),
                    AKM = table.Column<double>(type: "float", nullable: false),
                    CozunmusOksijen = table.Column<double>(type: "float", nullable: false),
                    Debi = table.Column<double>(type: "float", nullable: false),
                    DesarjDebi = table.Column<double>(type: "float", nullable: false),
                    HariciDebi = table.Column<double>(type: "float", nullable: false),
                    HariciDebi2 = table.Column<double>(type: "float", nullable: false),
                    KOi = table.Column<double>(type: "float", nullable: false),
                    pH = table.Column<double>(type: "float", nullable: false),
                    Sicaklik = table.Column<double>(type: "float", nullable: false),
                    Iletkenlik = table.Column<double>(type: "float", nullable: false),
                    Period = table.Column<int>(type: "int", nullable: false),
                    AkisHizi_Status = table.Column<int>(type: "int", nullable: false),
                    AKM_Status = table.Column<int>(type: "int", nullable: false),
                    CozunmusOksijen_Status = table.Column<int>(type: "int", nullable: false),
                    Debi_Status = table.Column<int>(type: "int", nullable: false),
                    DesarjDebi_Status = table.Column<int>(type: "int", nullable: false),
                    HariciDebi_Status = table.Column<int>(type: "int", nullable: false),
                    HariciDebi2_Status = table.Column<int>(type: "int", nullable: false),
                    KOi_Status = table.Column<int>(type: "int", nullable: false),
                    pH_Status = table.Column<int>(type: "int", nullable: false),
                    Sicaklik_Status = table.Column<int>(type: "int", nullable: false),
                    Iletkenlik_Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SendDatas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Stations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StationName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserOperationClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    OperationClaimId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserOperationClaims", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Apis");

            migrationBuilder.DropTable(
                name: "Calibrations");

            migrationBuilder.DropTable(
                name: "Channels");

            migrationBuilder.DropTable(
                name: "DB12s");

            migrationBuilder.DropTable(
                name: "DB41s");

            migrationBuilder.DropTable(
                name: "DB4s");

            migrationBuilder.DropTable(
                name: "InputTags");

            migrationBuilder.DropTable(
                name: "MailServers");

            migrationBuilder.DropTable(
                name: "MailStatements");

            migrationBuilder.DropTable(
                name: "MBTags");

            migrationBuilder.DropTable(
                name: "OperationClaims");

            migrationBuilder.DropTable(
                name: "Plcs");

            migrationBuilder.DropTable(
                name: "Samples");

            migrationBuilder.DropTable(
                name: "SendDatas");

            migrationBuilder.DropTable(
                name: "Stations");

            migrationBuilder.DropTable(
                name: "UserOperationClaims");
        }
    }
}
