USE [blockex]
GO

/****** Object:  View [dbo].[vwBtcUcBlockchains]    Script Date: 29/12/2020 2:30:01 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO



CREATE view [dbo].[vwBtcUcBlockchains] as 
select
Unconfirmeds._id Unconfirmeds__id,
Unconfirmeds.Blockchain Unconfirmeds_Blockchain,
Unconfirmeds.Source Unconfirmeds_Source,
Unconfirmeds.bodyId Unconfirmeds_bodyId,
UnconfirmedBodies.Op UnconfirmedBodies_Op,
UnconfirmedXs.lock_time UnconfirmedXs_lock_time,
UnconfirmedXs.ver UnconfirmedXs_ver,
UnconfirmedXs.size UnconfirmedXs_size,
UnconfirmedXs.time UnconfirmedXs_time,
UnconfirmedXs.tx_index UnconfirmedXs_tx_index,
UnconfirmedXs.vin_sz UnconfirmedXs_vin_sz,
UnconfirmedXs.hash UnconfirmedXs_hash,
UnconfirmedXs.vout_size UnconfirmedXs_vout_size,
UnconfirmedXs.relayed_by UnconfirmedXs_relayed_by,
Inputs.sequence Inputs_sequence,
Outs.spent Outs_spent,
Outs.tx_index Outs_tx_index,
Outs.addr Outs_address,
Outs.value Outs_value,
Outs.n Outs_n,
Outs.script Outs_script
from BtcUcBlockchains Unconfirmeds
left join BtcUcBlockchainBodies UnconfirmedBodies on Unconfirmeds.bodyId = UnconfirmedBodies.Id
left join BtcUcBlockchainXs UnconfirmedXs on UnconfirmedXs.Id = UnconfirmedBodies.xId
left join BtcUcBlockchainInputs Inputs on Inputs.BtcUcBlockchainXId = UnconfirmedXs.Id
left join BtcUcBlockchainOuts Outs on outs.BtcUcBlockchainXId = UnconfirmedXs.id
GO


