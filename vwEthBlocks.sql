USE [blockex]
GO

/****** Object:  View [dbo].[vwEthBlocks]    Script Date: 29/12/2020 2:29:18 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

create view [dbo].[vwEthBlocks] as 
select 
_id,
Blockchain,
Source,
EthBlocks.Hash EthBlocksHash,
ParentHash,
Number,
timestamp,
EthBlocks.Nonce EthBlocksNonce,
Difficulty,
Miner,
ExtraData,
EthTransactions.hash EthTransactionHash,
TransactionIndex,
Confirmations,
EthTransactions.[To] [To],
data,
r,
s,
v,
chainId,
EthBlockId,
_hex value_hex,
_isBigNumber value_isBigNumber
from SourceHeaders
join EthBlocks on SourceHeaders.BodyId = EthBlocks.id
join EthTransactions on EthBlocks.Id = EthTransactions.EthBlockId
join HexNumbers on EthTransactions.ValueId = HexNumbers.Id
GO


