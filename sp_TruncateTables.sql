USE [blockex]
GO

/****** Object:  StoredProcedure [dbo].[sp_TruncateTables]    Script Date: 29/12/2020 2:26:39 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_TruncateTables]
	-- Add the parameters for the stored procedure here
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

ALTER TABLE [dbo].[SourceHeaders] DROP CONSTRAINT [FK_SourceHeaders_EthBlocks_BodyId]
ALTER TABLE [dbo].[EthTransactions] DROP CONSTRAINT [FK_EthTransactions_HexNumbers_ValueId]
ALTER TABLE [dbo].[EthTransactions] DROP CONSTRAINT [FK_EthTransactions_HexNumbers_GasPriceId]
ALTER TABLE [dbo].[EthTransactions] DROP CONSTRAINT [FK_EthTransactions_HexNumbers_GasLimitId]
ALTER TABLE [dbo].[EthTransactions] DROP CONSTRAINT [FK_EthTransactions_EthBlocks_EthBlockId]
ALTER TABLE [dbo].[EthBlocks] DROP CONSTRAINT [FK_EthBlocks_HexNumbers_GasUsedId]
ALTER TABLE [dbo].[EthBlocks] DROP CONSTRAINT [FK_EthBlocks_HexNumbers_GasLimitId]
ALTER TABLE [dbo].[BtcUcBlockcyphers] DROP CONSTRAINT [FK_BtcUcBlockcyphers_BtcUcBlockcypherBodies_bodyId]
ALTER TABLE [dbo].[BtcUcBlockcypherOuts] DROP CONSTRAINT [FK_BtcUcBlockcypherOuts_BtcUcBlockcypherXs_BtcUcBlockcypherXId]
ALTER TABLE [dbo].[BtcUcBlockcypherInputs] DROP CONSTRAINT [FK_BtcUcBlockcypherInputs_BtcUcBlockcypherXs_BtcUcBlockcypherXId]
ALTER TABLE [dbo].[BtcUcBlockcypherInputs] DROP CONSTRAINT [FK_BtcUcBlockcypherInputs_BtcUcBlockcypherOuts_prev_outId]
ALTER TABLE [dbo].[BtcUcBlockcypherBodies] DROP CONSTRAINT [FK_BtcUcBlockcypherBodies_BtcUcBlockcypherXs_xId]
ALTER TABLE [dbo].[BtcUcBlockchains] DROP CONSTRAINT [FK_BtcUcBlockchains_BtcUcBlockchainBodies_bodyId]
ALTER TABLE [dbo].[BtcUcBlockchainOuts] DROP CONSTRAINT [FK_BtcUcBlockchainOuts_BtcUcBlockchainXs_BtcUcBlockchainXId]
ALTER TABLE [dbo].[BtcUcBlockchainInputs] DROP CONSTRAINT [FK_BtcUcBlockchainInputs_BtcUcBlockchainXs_BtcUcBlockchainXId]
ALTER TABLE [dbo].[BtcUcBlockchainInputs] DROP CONSTRAINT [FK_BtcUcBlockchainInputs_BtcUcBlockchainOuts_prev_outId]
ALTER TABLE [dbo].[BtcUcBlockchainBodies] DROP CONSTRAINT [FK_BtcUcBlockchainBodies_BtcUcBlockchainXs_xId]
/****** Object:  Table [dbo].[SourceHeaders]    Script Date: 29/12/2020 2:11:22 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SourceHeaders]') AND type in (N'U'))
TRUNCATE TABLE [dbo].[SourceHeaders]
/****** Object:  Table [dbo].[HexNumbers]    Script Date: 29/12/2020 2:11:22 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[HexNumbers]') AND type in (N'U'))
TRUNCATE TABLE [dbo].[HexNumbers]
/****** Object:  Table [dbo].[EthTransactions]    Script Date: 29/12/2020 2:11:22 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EthTransactions]') AND type in (N'U'))
TRUNCATE TABLE [dbo].[EthTransactions]
/****** Object:  Table [dbo].[EthBlocks]    Script Date: 29/12/2020 2:11:22 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EthBlocks]') AND type in (N'U'))
TRUNCATE TABLE [dbo].[EthBlocks]
/****** Object:  Table [dbo].[BtcUcBlockcypherXs]    Script Date: 29/12/2020 2:11:22 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[BtcUcBlockcypherXs]') AND type in (N'U'))
TRUNCATE TABLE [dbo].[BtcUcBlockcypherXs]
/****** Object:  Table [dbo].[BtcUcBlockcyphers]    Script Date: 29/12/2020 2:11:22 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[BtcUcBlockcyphers]') AND type in (N'U'))
TRUNCATE TABLE [dbo].[BtcUcBlockcyphers]
/****** Object:  Table [dbo].[BtcUcBlockcypherOuts]    Script Date: 29/12/2020 2:11:22 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[BtcUcBlockcypherOuts]') AND type in (N'U'))
TRUNCATE TABLE [dbo].[BtcUcBlockcypherOuts]
/****** Object:  Table [dbo].[BtcUcBlockcypherInputs]    Script Date: 29/12/2020 2:11:22 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[BtcUcBlockcypherInputs]') AND type in (N'U'))
TRUNCATE TABLE [dbo].[BtcUcBlockcypherInputs]
/****** Object:  Table [dbo].[BtcUcBlockcypherBodies]    Script Date: 29/12/2020 2:11:22 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[BtcUcBlockcypherBodies]') AND type in (N'U'))
TRUNCATE TABLE [dbo].[BtcUcBlockcypherBodies]
/****** Object:  Table [dbo].[BtcUcBlockchainXs]    Script Date: 29/12/2020 2:11:22 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[BtcUcBlockchainXs]') AND type in (N'U'))
TRUNCATE TABLE [dbo].[BtcUcBlockchainXs]
/****** Object:  Table [dbo].[BtcUcBlockchains]    Script Date: 29/12/2020 2:11:22 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[BtcUcBlockchains]') AND type in (N'U'))
TRUNCATE TABLE [dbo].[BtcUcBlockchains]
/****** Object:  Table [dbo].[BtcUcBlockchainOuts]    Script Date: 29/12/2020 2:11:22 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[BtcUcBlockchainOuts]') AND type in (N'U'))
TRUNCATE TABLE [dbo].[BtcUcBlockchainOuts]
/****** Object:  Table [dbo].[BtcUcBlockchainInputs]    Script Date: 29/12/2020 2:11:22 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[BtcUcBlockchainInputs]') AND type in (N'U'))
TRUNCATE TABLE [dbo].[BtcUcBlockchainInputs]
/****** Object:  Table [dbo].[BtcUcBlockchainBodies]    Script Date: 29/12/2020 2:11:22 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[BtcUcBlockchainBodies]') AND type in (N'U'))
TRUNCATE TABLE [dbo].[BtcUcBlockchainBodies]
/****** Object:  Table [dbo].[BtcUcBlockchainBodies]    Script Date: 29/12/2020 2:11:22 PM ******/

ALTER TABLE [dbo].[BtcUcBlockchainBodies]  WITH CHECK ADD  CONSTRAINT [FK_BtcUcBlockchainBodies_BtcUcBlockchainXs_xId] FOREIGN KEY([xId])
REFERENCES [dbo].[BtcUcBlockchainXs] ([Id])
ALTER TABLE [dbo].[BtcUcBlockchainBodies] CHECK CONSTRAINT [FK_BtcUcBlockchainBodies_BtcUcBlockchainXs_xId]
ALTER TABLE [dbo].[BtcUcBlockchainInputs]  WITH CHECK ADD  CONSTRAINT [FK_BtcUcBlockchainInputs_BtcUcBlockchainOuts_prev_outId] FOREIGN KEY([prev_outId])
REFERENCES [dbo].[BtcUcBlockchainOuts] ([Id])
ALTER TABLE [dbo].[BtcUcBlockchainInputs] CHECK CONSTRAINT [FK_BtcUcBlockchainInputs_BtcUcBlockchainOuts_prev_outId]
ALTER TABLE [dbo].[BtcUcBlockchainInputs]  WITH CHECK ADD  CONSTRAINT [FK_BtcUcBlockchainInputs_BtcUcBlockchainXs_BtcUcBlockchainXId] FOREIGN KEY([BtcUcBlockchainXId])
REFERENCES [dbo].[BtcUcBlockchainXs] ([Id])
ALTER TABLE [dbo].[BtcUcBlockchainInputs] CHECK CONSTRAINT [FK_BtcUcBlockchainInputs_BtcUcBlockchainXs_BtcUcBlockchainXId]
ALTER TABLE [dbo].[BtcUcBlockchainOuts]  WITH CHECK ADD  CONSTRAINT [FK_BtcUcBlockchainOuts_BtcUcBlockchainXs_BtcUcBlockchainXId] FOREIGN KEY([BtcUcBlockchainXId])
REFERENCES [dbo].[BtcUcBlockchainXs] ([Id])
ALTER TABLE [dbo].[BtcUcBlockchainOuts] CHECK CONSTRAINT [FK_BtcUcBlockchainOuts_BtcUcBlockchainXs_BtcUcBlockchainXId]
ALTER TABLE [dbo].[BtcUcBlockchains]  WITH CHECK ADD  CONSTRAINT [FK_BtcUcBlockchains_BtcUcBlockchainBodies_bodyId] FOREIGN KEY([bodyId])
REFERENCES [dbo].[BtcUcBlockchainBodies] ([Id])
ALTER TABLE [dbo].[BtcUcBlockchains] CHECK CONSTRAINT [FK_BtcUcBlockchains_BtcUcBlockchainBodies_bodyId]
ALTER TABLE [dbo].[BtcUcBlockcypherBodies]  WITH CHECK ADD  CONSTRAINT [FK_BtcUcBlockcypherBodies_BtcUcBlockcypherXs_xId] FOREIGN KEY([xId])
REFERENCES [dbo].[BtcUcBlockcypherXs] ([Id])
ALTER TABLE [dbo].[BtcUcBlockcypherBodies] CHECK CONSTRAINT [FK_BtcUcBlockcypherBodies_BtcUcBlockcypherXs_xId]
ALTER TABLE [dbo].[BtcUcBlockcypherInputs]  WITH CHECK ADD  CONSTRAINT [FK_BtcUcBlockcypherInputs_BtcUcBlockcypherOuts_prev_outId] FOREIGN KEY([prev_outId])
REFERENCES [dbo].[BtcUcBlockcypherOuts] ([Id])
ALTER TABLE [dbo].[BtcUcBlockcypherInputs] CHECK CONSTRAINT [FK_BtcUcBlockcypherInputs_BtcUcBlockcypherOuts_prev_outId]
ALTER TABLE [dbo].[BtcUcBlockcypherInputs]  WITH CHECK ADD  CONSTRAINT [FK_BtcUcBlockcypherInputs_BtcUcBlockcypherXs_BtcUcBlockcypherXId] FOREIGN KEY([BtcUcBlockcypherXId])
REFERENCES [dbo].[BtcUcBlockcypherXs] ([Id])
ALTER TABLE [dbo].[BtcUcBlockcypherInputs] CHECK CONSTRAINT [FK_BtcUcBlockcypherInputs_BtcUcBlockcypherXs_BtcUcBlockcypherXId]
ALTER TABLE [dbo].[BtcUcBlockcypherOuts]  WITH CHECK ADD  CONSTRAINT [FK_BtcUcBlockcypherOuts_BtcUcBlockcypherXs_BtcUcBlockcypherXId] FOREIGN KEY([BtcUcBlockcypherXId])
REFERENCES [dbo].[BtcUcBlockcypherXs] ([Id])
ALTER TABLE [dbo].[BtcUcBlockcypherOuts] CHECK CONSTRAINT [FK_BtcUcBlockcypherOuts_BtcUcBlockcypherXs_BtcUcBlockcypherXId]
ALTER TABLE [dbo].[BtcUcBlockcyphers]  WITH CHECK ADD  CONSTRAINT [FK_BtcUcBlockcyphers_BtcUcBlockcypherBodies_bodyId] FOREIGN KEY([bodyId])
REFERENCES [dbo].[BtcUcBlockcypherBodies] ([Id])
ALTER TABLE [dbo].[BtcUcBlockcyphers] CHECK CONSTRAINT [FK_BtcUcBlockcyphers_BtcUcBlockcypherBodies_bodyId]
ALTER TABLE [dbo].[EthBlocks]  WITH CHECK ADD  CONSTRAINT [FK_EthBlocks_HexNumbers_GasLimitId] FOREIGN KEY([GasLimitId])
REFERENCES [dbo].[HexNumbers] ([Id])
ALTER TABLE [dbo].[EthBlocks] CHECK CONSTRAINT [FK_EthBlocks_HexNumbers_GasLimitId]
ALTER TABLE [dbo].[EthBlocks]  WITH CHECK ADD  CONSTRAINT [FK_EthBlocks_HexNumbers_GasUsedId] FOREIGN KEY([GasUsedId])
REFERENCES [dbo].[HexNumbers] ([Id])
ALTER TABLE [dbo].[EthBlocks] CHECK CONSTRAINT [FK_EthBlocks_HexNumbers_GasUsedId]
ALTER TABLE [dbo].[EthTransactions]  WITH CHECK ADD  CONSTRAINT [FK_EthTransactions_EthBlocks_EthBlockId] FOREIGN KEY([EthBlockId])
REFERENCES [dbo].[EthBlocks] ([Id])
ALTER TABLE [dbo].[EthTransactions] CHECK CONSTRAINT [FK_EthTransactions_EthBlocks_EthBlockId]
ALTER TABLE [dbo].[EthTransactions]  WITH CHECK ADD  CONSTRAINT [FK_EthTransactions_HexNumbers_GasLimitId] FOREIGN KEY([GasLimitId])
REFERENCES [dbo].[HexNumbers] ([Id])
ALTER TABLE [dbo].[EthTransactions] CHECK CONSTRAINT [FK_EthTransactions_HexNumbers_GasLimitId]
ALTER TABLE [dbo].[EthTransactions]  WITH CHECK ADD  CONSTRAINT [FK_EthTransactions_HexNumbers_GasPriceId] FOREIGN KEY([GasPriceId])
REFERENCES [dbo].[HexNumbers] ([Id])
ALTER TABLE [dbo].[EthTransactions] CHECK CONSTRAINT [FK_EthTransactions_HexNumbers_GasPriceId]
ALTER TABLE [dbo].[EthTransactions]  WITH CHECK ADD  CONSTRAINT [FK_EthTransactions_HexNumbers_ValueId] FOREIGN KEY([ValueId])
REFERENCES [dbo].[HexNumbers] ([Id])
ALTER TABLE [dbo].[EthTransactions] CHECK CONSTRAINT [FK_EthTransactions_HexNumbers_ValueId]
ALTER TABLE [dbo].[SourceHeaders]  WITH CHECK ADD  CONSTRAINT [FK_SourceHeaders_EthBlocks_BodyId] FOREIGN KEY([BodyId])
REFERENCES [dbo].[EthBlocks] ([Id])
ALTER TABLE [dbo].[SourceHeaders] CHECK CONSTRAINT [FK_SourceHeaders_EthBlocks_BodyId]
END
GO


