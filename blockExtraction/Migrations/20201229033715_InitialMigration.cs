using Microsoft.EntityFrameworkCore.Migrations;

namespace Blockex.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BtcUcBlockchainXs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    lock_time = table.Column<int>(type: "int", nullable: false),
                    ver = table.Column<int>(type: "int", nullable: false),
                    size = table.Column<int>(type: "int", nullable: false),
                    time = table.Column<long>(type: "bigint", nullable: false),
                    tx_index = table.Column<int>(type: "int", nullable: false),
                    vin_sz = table.Column<int>(type: "int", nullable: false),
                    hash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    vout_size = table.Column<int>(type: "int", nullable: false),
                    relayed_by = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BtcUcBlockchainXs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BtcUcBlockcypherXs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    lock_time = table.Column<int>(type: "int", nullable: false),
                    ver = table.Column<int>(type: "int", nullable: false),
                    size = table.Column<int>(type: "int", nullable: false),
                    time = table.Column<long>(type: "bigint", nullable: false),
                    tx_index = table.Column<int>(type: "int", nullable: false),
                    vin_sz = table.Column<int>(type: "int", nullable: false),
                    hash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    vout_size = table.Column<int>(type: "int", nullable: false),
                    relayed_by = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BtcUcBlockcypherXs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HexNumbers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    _hex = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _isBigNumber = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HexNumbers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BtcUcBlockchainBodies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Op = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    xId = table.Column<int>(type: "int", nullable: true),
                    created_at = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BtcUcBlockchainBodies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BtcUcBlockchainBodies_BtcUcBlockchainXs_xId",
                        column: x => x.xId,
                        principalTable: "BtcUcBlockchainXs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BtcUcBlockchainOuts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    spent = table.Column<bool>(type: "bit", nullable: false),
                    tx_index = table.Column<int>(type: "int", nullable: false),
                    addr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    value = table.Column<long>(type: "bigint", nullable: false),
                    n = table.Column<int>(type: "int", nullable: false),
                    script = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BtcUcBlockchainXId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BtcUcBlockchainOuts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BtcUcBlockchainOuts_BtcUcBlockchainXs_BtcUcBlockchainXId",
                        column: x => x.BtcUcBlockchainXId,
                        principalTable: "BtcUcBlockchainXs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BtcUcBlockcypherBodies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Op = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    xId = table.Column<int>(type: "int", nullable: true),
                    created_at = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BtcUcBlockcypherBodies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BtcUcBlockcypherBodies_BtcUcBlockcypherXs_xId",
                        column: x => x.xId,
                        principalTable: "BtcUcBlockcypherXs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BtcUcBlockcypherOuts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    spent = table.Column<bool>(type: "bit", nullable: false),
                    tx_index = table.Column<int>(type: "int", nullable: false),
                    addr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    value = table.Column<long>(type: "bigint", nullable: false),
                    n = table.Column<int>(type: "int", nullable: false),
                    script = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BtcUcBlockcypherXId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BtcUcBlockcypherOuts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BtcUcBlockcypherOuts_BtcUcBlockcypherXs_BtcUcBlockcypherXId",
                        column: x => x.BtcUcBlockcypherXId,
                        principalTable: "BtcUcBlockcypherXs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EthBlocks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Hash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ParentHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Number = table.Column<long>(type: "bigint", nullable: false),
                    Timestamp = table.Column<long>(type: "bigint", nullable: false),
                    Nonce = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Difficulty = table.Column<long>(type: "bigint", nullable: false),
                    GasLimitId = table.Column<int>(type: "int", nullable: true),
                    GasUsedId = table.Column<int>(type: "int", nullable: true),
                    Miner = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExtraData = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EthBlocks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EthBlocks_HexNumbers_GasLimitId",
                        column: x => x.GasLimitId,
                        principalTable: "HexNumbers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EthBlocks_HexNumbers_GasUsedId",
                        column: x => x.GasUsedId,
                        principalTable: "HexNumbers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BtcUcBlockchains",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    _id = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Blockchain = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Source = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    bodyId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BtcUcBlockchains", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BtcUcBlockchains_BtcUcBlockchainBodies_bodyId",
                        column: x => x.bodyId,
                        principalTable: "BtcUcBlockchainBodies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BtcUcBlockchainInputs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    sequence = table.Column<long>(type: "bigint", nullable: false),
                    prev_outId = table.Column<int>(type: "int", nullable: true),
                    BtcUcBlockchainXId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BtcUcBlockchainInputs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BtcUcBlockchainInputs_BtcUcBlockchainOuts_prev_outId",
                        column: x => x.prev_outId,
                        principalTable: "BtcUcBlockchainOuts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BtcUcBlockchainInputs_BtcUcBlockchainXs_BtcUcBlockchainXId",
                        column: x => x.BtcUcBlockchainXId,
                        principalTable: "BtcUcBlockchainXs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BtcUcBlockcyphers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    _id = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Blockchain = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Source = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    bodyId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BtcUcBlockcyphers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BtcUcBlockcyphers_BtcUcBlockcypherBodies_bodyId",
                        column: x => x.bodyId,
                        principalTable: "BtcUcBlockcypherBodies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BtcUcBlockcypherInputs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    sequence = table.Column<long>(type: "bigint", nullable: false),
                    prev_outId = table.Column<int>(type: "int", nullable: true),
                    BtcUcBlockcypherXId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BtcUcBlockcypherInputs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BtcUcBlockcypherInputs_BtcUcBlockcypherOuts_prev_outId",
                        column: x => x.prev_outId,
                        principalTable: "BtcUcBlockcypherOuts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BtcUcBlockcypherInputs_BtcUcBlockcypherXs_BtcUcBlockcypherXId",
                        column: x => x.BtcUcBlockcypherXId,
                        principalTable: "BtcUcBlockcypherXs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EthTransactions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Hash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BlockHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TransactionIndex = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Confirmations = table.Column<int>(type: "int", nullable: false),
                    GasPriceId = table.Column<int>(type: "int", nullable: true),
                    GasLimitId = table.Column<int>(type: "int", nullable: true),
                    To = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ValueId = table.Column<int>(type: "int", nullable: true),
                    Nonce = table.Column<int>(type: "int", nullable: false),
                    data = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    r = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    s = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    v = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    creates = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChainId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EthBlockId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EthTransactions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EthTransactions_EthBlocks_EthBlockId",
                        column: x => x.EthBlockId,
                        principalTable: "EthBlocks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EthTransactions_HexNumbers_GasLimitId",
                        column: x => x.GasLimitId,
                        principalTable: "HexNumbers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EthTransactions_HexNumbers_GasPriceId",
                        column: x => x.GasPriceId,
                        principalTable: "HexNumbers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EthTransactions_HexNumbers_ValueId",
                        column: x => x.ValueId,
                        principalTable: "HexNumbers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SourceHeaders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    _id = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Blockchain = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Source = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BodyId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SourceHeaders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SourceHeaders_EthBlocks_BodyId",
                        column: x => x.BodyId,
                        principalTable: "EthBlocks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BtcUcBlockchainBodies_xId",
                table: "BtcUcBlockchainBodies",
                column: "xId");

            migrationBuilder.CreateIndex(
                name: "IX_BtcUcBlockchainInputs_BtcUcBlockchainXId",
                table: "BtcUcBlockchainInputs",
                column: "BtcUcBlockchainXId");

            migrationBuilder.CreateIndex(
                name: "IX_BtcUcBlockchainInputs_prev_outId",
                table: "BtcUcBlockchainInputs",
                column: "prev_outId");

            migrationBuilder.CreateIndex(
                name: "IX_BtcUcBlockchainOuts_BtcUcBlockchainXId",
                table: "BtcUcBlockchainOuts",
                column: "BtcUcBlockchainXId");

            migrationBuilder.CreateIndex(
                name: "IX_BtcUcBlockchains_bodyId",
                table: "BtcUcBlockchains",
                column: "bodyId");

            migrationBuilder.CreateIndex(
                name: "IX_BtcUcBlockcypherBodies_xId",
                table: "BtcUcBlockcypherBodies",
                column: "xId");

            migrationBuilder.CreateIndex(
                name: "IX_BtcUcBlockcypherInputs_BtcUcBlockcypherXId",
                table: "BtcUcBlockcypherInputs",
                column: "BtcUcBlockcypherXId");

            migrationBuilder.CreateIndex(
                name: "IX_BtcUcBlockcypherInputs_prev_outId",
                table: "BtcUcBlockcypherInputs",
                column: "prev_outId");

            migrationBuilder.CreateIndex(
                name: "IX_BtcUcBlockcypherOuts_BtcUcBlockcypherXId",
                table: "BtcUcBlockcypherOuts",
                column: "BtcUcBlockcypherXId");

            migrationBuilder.CreateIndex(
                name: "IX_BtcUcBlockcyphers_bodyId",
                table: "BtcUcBlockcyphers",
                column: "bodyId");

            migrationBuilder.CreateIndex(
                name: "IX_EthBlocks_GasLimitId",
                table: "EthBlocks",
                column: "GasLimitId");

            migrationBuilder.CreateIndex(
                name: "IX_EthBlocks_GasUsedId",
                table: "EthBlocks",
                column: "GasUsedId");

            migrationBuilder.CreateIndex(
                name: "IX_EthTransactions_EthBlockId",
                table: "EthTransactions",
                column: "EthBlockId");

            migrationBuilder.CreateIndex(
                name: "IX_EthTransactions_GasLimitId",
                table: "EthTransactions",
                column: "GasLimitId");

            migrationBuilder.CreateIndex(
                name: "IX_EthTransactions_GasPriceId",
                table: "EthTransactions",
                column: "GasPriceId");

            migrationBuilder.CreateIndex(
                name: "IX_EthTransactions_ValueId",
                table: "EthTransactions",
                column: "ValueId");

            migrationBuilder.CreateIndex(
                name: "IX_SourceHeaders_BodyId",
                table: "SourceHeaders",
                column: "BodyId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BtcUcBlockchainInputs");

            migrationBuilder.DropTable(
                name: "BtcUcBlockchains");

            migrationBuilder.DropTable(
                name: "BtcUcBlockcypherInputs");

            migrationBuilder.DropTable(
                name: "BtcUcBlockcyphers");

            migrationBuilder.DropTable(
                name: "EthTransactions");

            migrationBuilder.DropTable(
                name: "SourceHeaders");

            migrationBuilder.DropTable(
                name: "BtcUcBlockchainOuts");

            migrationBuilder.DropTable(
                name: "BtcUcBlockchainBodies");

            migrationBuilder.DropTable(
                name: "BtcUcBlockcypherOuts");

            migrationBuilder.DropTable(
                name: "BtcUcBlockcypherBodies");

            migrationBuilder.DropTable(
                name: "EthBlocks");

            migrationBuilder.DropTable(
                name: "BtcUcBlockchainXs");

            migrationBuilder.DropTable(
                name: "BtcUcBlockcypherXs");

            migrationBuilder.DropTable(
                name: "HexNumbers");
        }
    }
}
