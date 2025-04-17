using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Object;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.PlayerScripts;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Casino
{
	// Token: 0x020004A4 RID: 1188
	public class CasinoGamePlayers : NetworkBehaviour
	{
		// Token: 0x06006757 RID: 26455 RVA: 0x001D07CC File Offset: 0x001CE9CC
		// Note: this type is marked as 'beforefieldinit'.
		static CasinoGamePlayers()
		{
			Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Casino", "CasinoGamePlayers");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr);
			CasinoGamePlayers.NativeFieldInfoPtr_PlayerLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, "PlayerLimit");
			CasinoGamePlayers.NativeFieldInfoPtr_Players = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, "Players");
			CasinoGamePlayers.NativeFieldInfoPtr_onPlayerListChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, "onPlayerListChanged");
			CasinoGamePlayers.NativeFieldInfoPtr_onPlayerScoresChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, "onPlayerScoresChanged");
			CasinoGamePlayers.NativeFieldInfoPtr_playerScores = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, "playerScores");
			CasinoGamePlayers.NativeFieldInfoPtr_playerDatas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, "playerDatas");
			CasinoGamePlayers.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Casino.CasinoGamePlayersAssembly-CSharp.dll_Excuted");
			CasinoGamePlayers.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Casino.CasinoGamePlayersAssembly-CSharp.dll_Excuted");
			CasinoGamePlayers.NativeMethodInfoPtr_get_CurrentPlayerCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100676395);
			CasinoGamePlayers.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100676396);
			CasinoGamePlayers.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100676397);
			CasinoGamePlayers.NativeMethodInfoPtr_AddPlayer_Public_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100676398);
			CasinoGamePlayers.NativeMethodInfoPtr_RemovePlayer_Public_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100676399);
			CasinoGamePlayers.NativeMethodInfoPtr_SetPlayerScore_Public_Void_Player_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100676400);
			CasinoGamePlayers.NativeMethodInfoPtr_GetPlayerScore_Public_Int32_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100676401);
			CasinoGamePlayers.NativeMethodInfoPtr_GetPlayer_Public_Player_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100676402);
			CasinoGamePlayers.NativeMethodInfoPtr_GetPlayerIndex_Public_Int32_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100676403);
			CasinoGamePlayers.NativeMethodInfoPtr_RequestAddPlayer_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100676404);
			CasinoGamePlayers.NativeMethodInfoPtr_AddPlayerToArray_Private_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100676405);
			CasinoGamePlayers.NativeMethodInfoPtr_RequestRemovePlayer_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100676406);
			CasinoGamePlayers.NativeMethodInfoPtr_RemovePlayerFromArray_Private_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100676407);
			CasinoGamePlayers.NativeMethodInfoPtr_RequestSetScore_Private_Void_NetworkObject_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100676408);
			CasinoGamePlayers.NativeMethodInfoPtr_SetPlayerScore_Private_Void_NetworkConnection_NetworkObject_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100676409);
			CasinoGamePlayers.NativeMethodInfoPtr_SetPlayerList_Private_Void_NetworkConnection_Il2CppReferenceArray_1_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100676410);
			CasinoGamePlayers.NativeMethodInfoPtr_GetPlayerData_Public_CasinoGamePlayerData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100676411);
			CasinoGamePlayers.NativeMethodInfoPtr_GetPlayerData_Public_CasinoGamePlayerData_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100676412);
			CasinoGamePlayers.NativeMethodInfoPtr_GetPlayerData_Public_CasinoGamePlayerData_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100676413);
			CasinoGamePlayers.NativeMethodInfoPtr_SendPlayerBool_Public_Void_NetworkObject_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100676414);
			CasinoGamePlayers.NativeMethodInfoPtr_ReceivePlayerBool_Private_Void_NetworkConnection_NetworkObject_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100676415);
			CasinoGamePlayers.NativeMethodInfoPtr_SendPlayerFloat_Public_Void_NetworkObject_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100676416);
			CasinoGamePlayers.NativeMethodInfoPtr_ReceivePlayerFloat_Private_Void_NetworkConnection_NetworkObject_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100676417);
			CasinoGamePlayers.NativeMethodInfoPtr_GetPlayerObjects_Private_Il2CppReferenceArray_1_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100676418);
			CasinoGamePlayers.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100676419);
			CasinoGamePlayers.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100676420);
			CasinoGamePlayers.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100676421);
			CasinoGamePlayers.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100676422);
			CasinoGamePlayers.NativeMethodInfoPtr_RpcWriter___Server_RequestAddPlayer_3323014238_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100676423);
			CasinoGamePlayers.NativeMethodInfoPtr_RpcLogic___RequestAddPlayer_3323014238_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100676424);
			CasinoGamePlayers.NativeMethodInfoPtr_RpcReader___Server_RequestAddPlayer_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100676425);
			CasinoGamePlayers.NativeMethodInfoPtr_RpcWriter___Server_RequestRemovePlayer_3323014238_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100676426);
			CasinoGamePlayers.NativeMethodInfoPtr_RpcLogic___RequestRemovePlayer_3323014238_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100676427);
			CasinoGamePlayers.NativeMethodInfoPtr_RpcReader___Server_RequestRemovePlayer_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100676428);
			CasinoGamePlayers.NativeMethodInfoPtr_RpcWriter___Server_RequestSetScore_4172557123_Private_Void_NetworkObject_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100676429);
			CasinoGamePlayers.NativeMethodInfoPtr_RpcLogic___RequestSetScore_4172557123_Private_Void_NetworkObject_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100676430);
			CasinoGamePlayers.NativeMethodInfoPtr_RpcReader___Server_RequestSetScore_4172557123_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100676431);
			CasinoGamePlayers.NativeMethodInfoPtr_RpcWriter___Observers_SetPlayerScore_1865307316_Private_Void_NetworkConnection_NetworkObject_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100676432);
			CasinoGamePlayers.NativeMethodInfoPtr_RpcLogic___SetPlayerScore_1865307316_Private_Void_NetworkConnection_NetworkObject_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100676433);
			CasinoGamePlayers.NativeMethodInfoPtr_RpcReader___Observers_SetPlayerScore_1865307316_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100676434);
			CasinoGamePlayers.NativeMethodInfoPtr_RpcWriter___Target_SetPlayerScore_1865307316_Private_Void_NetworkConnection_NetworkObject_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100676435);
			CasinoGamePlayers.NativeMethodInfoPtr_RpcReader___Target_SetPlayerScore_1865307316_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100676436);
			CasinoGamePlayers.NativeMethodInfoPtr_RpcWriter___Observers_SetPlayerList_204172449_Private_Void_NetworkConnection_Il2CppReferenceArray_1_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100676437);
			CasinoGamePlayers.NativeMethodInfoPtr_RpcLogic___SetPlayerList_204172449_Private_Void_NetworkConnection_Il2CppReferenceArray_1_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100676438);
			CasinoGamePlayers.NativeMethodInfoPtr_RpcReader___Observers_SetPlayerList_204172449_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100676439);
			CasinoGamePlayers.NativeMethodInfoPtr_RpcWriter___Target_SetPlayerList_204172449_Private_Void_NetworkConnection_Il2CppReferenceArray_1_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100676440);
			CasinoGamePlayers.NativeMethodInfoPtr_RpcReader___Target_SetPlayerList_204172449_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100676441);
			CasinoGamePlayers.NativeMethodInfoPtr_RpcWriter___Server_SendPlayerBool_77262511_Private_Void_NetworkObject_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100676442);
			CasinoGamePlayers.NativeMethodInfoPtr_RpcLogic___SendPlayerBool_77262511_Public_Void_NetworkObject_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100676443);
			CasinoGamePlayers.NativeMethodInfoPtr_RpcReader___Server_SendPlayerBool_77262511_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100676444);
			CasinoGamePlayers.NativeMethodInfoPtr_RpcWriter___Observers_ReceivePlayerBool_1748594478_Private_Void_NetworkConnection_NetworkObject_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100676445);
			CasinoGamePlayers.NativeMethodInfoPtr_RpcLogic___ReceivePlayerBool_1748594478_Private_Void_NetworkConnection_NetworkObject_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100676446);
			CasinoGamePlayers.NativeMethodInfoPtr_RpcReader___Observers_ReceivePlayerBool_1748594478_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100676447);
			CasinoGamePlayers.NativeMethodInfoPtr_RpcWriter___Target_ReceivePlayerBool_1748594478_Private_Void_NetworkConnection_NetworkObject_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100676448);
			CasinoGamePlayers.NativeMethodInfoPtr_RpcReader___Target_ReceivePlayerBool_1748594478_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100676449);
			CasinoGamePlayers.NativeMethodInfoPtr_RpcWriter___Server_SendPlayerFloat_2931762093_Private_Void_NetworkObject_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100676450);
			CasinoGamePlayers.NativeMethodInfoPtr_RpcLogic___SendPlayerFloat_2931762093_Public_Void_NetworkObject_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100676451);
			CasinoGamePlayers.NativeMethodInfoPtr_RpcReader___Server_SendPlayerFloat_2931762093_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100676452);
			CasinoGamePlayers.NativeMethodInfoPtr_RpcWriter___Observers_ReceivePlayerFloat_2317689966_Private_Void_NetworkConnection_NetworkObject_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100676453);
			CasinoGamePlayers.NativeMethodInfoPtr_RpcLogic___ReceivePlayerFloat_2317689966_Private_Void_NetworkConnection_NetworkObject_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100676454);
			CasinoGamePlayers.NativeMethodInfoPtr_RpcReader___Observers_ReceivePlayerFloat_2317689966_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100676455);
			CasinoGamePlayers.NativeMethodInfoPtr_RpcWriter___Target_ReceivePlayerFloat_2317689966_Private_Void_NetworkConnection_NetworkObject_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100676456);
			CasinoGamePlayers.NativeMethodInfoPtr_RpcReader___Target_ReceivePlayerFloat_2317689966_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100676457);
			CasinoGamePlayers.NativeMethodInfoPtr_Method_Private_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100676458);
		}

		// Token: 0x17001F1C RID: 7964
		// (get) Token: 0x06006758 RID: 26456 RVA: 0x001D0D9C File Offset: 0x001CEF9C
		public unsafe int CurrentPlayerCount
		{
			[CallerCount(22)]
			[CachedScanResults(RefRangeStart = 209053, RefRangeEnd = 209075, XrefRangeStart = 209035, XrefRangeEnd = 209053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_get_CurrentPlayerCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06006759 RID: 26457 RVA: 0x001D0DD8 File Offset: 0x001CEFD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209075, XrefRangeEnd = 209079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CasinoGamePlayers.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600675A RID: 26458 RVA: 0x001D0E14 File Offset: 0x001CF014
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209079, XrefRangeEnd = 209094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnSpawnServer(NetworkConnection connection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CasinoGamePlayers.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600675B RID: 26459 RVA: 0x001D0E64 File Offset: 0x001CF064
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209094, XrefRangeEnd = 209116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddPlayer(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_AddPlayer_Public_Void_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600675C RID: 26460 RVA: 0x001D0EA8 File Offset: 0x001CF0A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209116, XrefRangeEnd = 209135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemovePlayer(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_RemovePlayer_Public_Void_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600675D RID: 26461 RVA: 0x001D0EEC File Offset: 0x001CF0EC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 209147, RefRangeEnd = 209152, XrefRangeStart = 209135, XrefRangeEnd = 209147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPlayerScore(Player player, int score)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref score;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_SetPlayerScore_Public_Void_Player_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600675E RID: 26462 RVA: 0x001D0F3C File Offset: 0x001CF13C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 209162, RefRangeEnd = 209164, XrefRangeStart = 209152, XrefRangeEnd = 209162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetPlayerScore(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_GetPlayerScore_Public_Int32_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600675F RID: 26463 RVA: 0x001D0F8C File Offset: 0x001CF18C
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 209164, RefRangeEnd = 209173, XrefRangeStart = 209164, XrefRangeEnd = 209164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Player GetPlayer(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_GetPlayer_Public_Player_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Player>(intPtr3) : null;
		}

		// Token: 0x06006760 RID: 26464 RVA: 0x001D0FD8 File Offset: 0x001CF1D8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 209176, RefRangeEnd = 209180, XrefRangeStart = 209173, XrefRangeEnd = 209176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetPlayerIndex(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_GetPlayerIndex_Public_Int32_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006761 RID: 26465 RVA: 0x001D1028 File Offset: 0x001CF228
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209180, XrefRangeEnd = 209202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RequestAddPlayer(NetworkObject playerObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(playerObject);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_RequestAddPlayer_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006762 RID: 26466 RVA: 0x001D106C File Offset: 0x001CF26C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209202, XrefRangeEnd = 209206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddPlayerToArray(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_AddPlayerToArray_Private_Void_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006763 RID: 26467 RVA: 0x001D10B0 File Offset: 0x001CF2B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209206, XrefRangeEnd = 209225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RequestRemovePlayer(NetworkObject playerObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(playerObject);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_RequestRemovePlayer_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006764 RID: 26468 RVA: 0x001D10F4 File Offset: 0x001CF2F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209225, XrefRangeEnd = 209229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemovePlayerFromArray(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_RemovePlayerFromArray_Private_Void_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006765 RID: 26469 RVA: 0x001D1138 File Offset: 0x001CF338
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209229, XrefRangeEnd = 209250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RequestSetScore(NetworkObject playerObject, int score)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(playerObject);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref score;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_RequestSetScore_Private_Void_NetworkObject_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006766 RID: 26470 RVA: 0x001D1188 File Offset: 0x001CF388
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 209296, RefRangeEnd = 209299, XrefRangeStart = 209250, XrefRangeEnd = 209296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPlayerScore(NetworkConnection conn, NetworkObject playerObject, int score)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(playerObject);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref score;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_SetPlayerScore_Private_Void_NetworkConnection_NetworkObject_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006767 RID: 26471 RVA: 0x001D11EC File Offset: 0x001CF3EC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 209341, RefRangeEnd = 209345, XrefRangeStart = 209299, XrefRangeEnd = 209341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPlayerList(NetworkConnection conn, Il2CppReferenceArray<NetworkObject> playerObjects)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(playerObjects);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_SetPlayerList_Private_Void_NetworkConnection_Il2CppReferenceArray_1_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006768 RID: 26472 RVA: 0x001D1240 File Offset: 0x001CF440
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209345, XrefRangeEnd = 209350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CasinoGamePlayerData GetPlayerData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_GetPlayerData_Public_CasinoGamePlayerData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CasinoGamePlayerData>(intPtr3) : null;
		}

		// Token: 0x06006769 RID: 26473 RVA: 0x001D1280 File Offset: 0x001CF480
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 209364, RefRangeEnd = 209373, XrefRangeStart = 209350, XrefRangeEnd = 209364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CasinoGamePlayerData GetPlayerData(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_GetPlayerData_Public_CasinoGamePlayerData_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CasinoGamePlayerData>(intPtr3) : null;
		}

		// Token: 0x0600676A RID: 26474 RVA: 0x001D12D0 File Offset: 0x001CF4D0
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 209378, RefRangeEnd = 209384, XrefRangeStart = 209373, XrefRangeEnd = 209378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CasinoGamePlayerData GetPlayerData(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_GetPlayerData_Public_CasinoGamePlayerData_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CasinoGamePlayerData>(intPtr3) : null;
		}

		// Token: 0x0600676B RID: 26475 RVA: 0x001D131C File Offset: 0x001CF51C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209384, XrefRangeEnd = 209407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendPlayerBool(NetworkObject playerObject, string key, bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(playerObject);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(key);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_SendPlayerBool_Public_Void_NetworkObject_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600676C RID: 26476 RVA: 0x001D1380 File Offset: 0x001CF580
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 209453, RefRangeEnd = 209456, XrefRangeStart = 209407, XrefRangeEnd = 209453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReceivePlayerBool(NetworkConnection conn, NetworkObject playerObject, string key, bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(playerObject);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(key);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_ReceivePlayerBool_Private_Void_NetworkConnection_NetworkObject_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600676D RID: 26477 RVA: 0x001D13F4 File Offset: 0x001CF5F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 209479, RefRangeEnd = 209480, XrefRangeStart = 209456, XrefRangeEnd = 209479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendPlayerFloat(NetworkObject playerObject, string key, float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(playerObject);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(key);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_SendPlayerFloat_Public_Void_NetworkObject_String_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600676E RID: 26478 RVA: 0x001D1458 File Offset: 0x001CF658
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 209526, RefRangeEnd = 209529, XrefRangeStart = 209480, XrefRangeEnd = 209526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReceivePlayerFloat(NetworkConnection conn, NetworkObject playerObject, string key, float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(playerObject);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(key);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_ReceivePlayerFloat_Private_Void_NetworkConnection_NetworkObject_String_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600676F RID: 26479 RVA: 0x001D14CC File Offset: 0x001CF6CC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 209538, RefRangeEnd = 209542, XrefRangeStart = 209529, XrefRangeEnd = 209538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<NetworkObject> GetPlayerObjects()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_GetPlayerObjects_Private_Il2CppReferenceArray_1_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<NetworkObject>>(intPtr3) : null;
		}

		// Token: 0x06006770 RID: 26480 RVA: 0x001D150C File Offset: 0x001CF70C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209542, XrefRangeEnd = 209557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CasinoGamePlayers() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006771 RID: 26481 RVA: 0x001D1548 File Offset: 0x001CF748
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209557, XrefRangeEnd = 209637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CasinoGamePlayers.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006772 RID: 26482 RVA: 0x001D1584 File Offset: 0x001CF784
		[CallerCount(0)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CasinoGamePlayers.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006773 RID: 26483 RVA: 0x001D15C0 File Offset: 0x001CF7C0
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CasinoGamePlayers.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006774 RID: 26484 RVA: 0x001D15FC File Offset: 0x001CF7FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209637, XrefRangeEnd = 209656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_RequestAddPlayer_3323014238(NetworkObject playerObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(playerObject);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_RpcWriter___Server_RequestAddPlayer_3323014238_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006775 RID: 26485 RVA: 0x001D1640 File Offset: 0x001CF840
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 209695, RefRangeEnd = 209699, XrefRangeStart = 209656, XrefRangeEnd = 209695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___RequestAddPlayer_3323014238(NetworkObject playerObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(playerObject);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_RpcLogic___RequestAddPlayer_3323014238_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006776 RID: 26486 RVA: 0x001D1684 File Offset: 0x001CF884
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209699, XrefRangeEnd = 209703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_RequestAddPlayer_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_RpcReader___Server_RequestAddPlayer_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006777 RID: 26487 RVA: 0x001D16E8 File Offset: 0x001CF8E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_RequestRemovePlayer_3323014238(NetworkObject playerObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(playerObject);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_RpcWriter___Server_RequestRemovePlayer_3323014238_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006778 RID: 26488 RVA: 0x001D172C File Offset: 0x001CF92C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209703, XrefRangeEnd = 209723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___RequestRemovePlayer_3323014238(NetworkObject playerObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(playerObject);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_RpcLogic___RequestRemovePlayer_3323014238_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006779 RID: 26489 RVA: 0x001D1770 File Offset: 0x001CF970
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209723, XrefRangeEnd = 209741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_RequestRemovePlayer_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_RpcReader___Server_RequestRemovePlayer_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600677A RID: 26490 RVA: 0x001D17D4 File Offset: 0x001CF9D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_RequestSetScore_4172557123(NetworkObject playerObject, int score)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(playerObject);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref score;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_RpcWriter___Server_RequestSetScore_4172557123_Private_Void_NetworkObject_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600677B RID: 26491 RVA: 0x001D1824 File Offset: 0x001CFA24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209741, XrefRangeEnd = 209742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___RequestSetScore_4172557123(NetworkObject playerObject, int score)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(playerObject);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref score;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_RpcLogic___RequestSetScore_4172557123_Private_Void_NetworkObject_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600677C RID: 26492 RVA: 0x001D1874 File Offset: 0x001CFA74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209742, XrefRangeEnd = 209747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_RequestSetScore_4172557123(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_RpcReader___Server_RequestSetScore_4172557123_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600677D RID: 26493 RVA: 0x001D18D8 File Offset: 0x001CFAD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209747, XrefRangeEnd = 209768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetPlayerScore_1865307316(NetworkConnection conn, NetworkObject playerObject, int score)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(playerObject);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref score;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_RpcWriter___Observers_SetPlayerScore_1865307316_Private_Void_NetworkConnection_NetworkObject_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600677E RID: 26494 RVA: 0x001D193C File Offset: 0x001CFB3C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 209786, RefRangeEnd = 209789, XrefRangeStart = 209768, XrefRangeEnd = 209786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetPlayerScore_1865307316(NetworkConnection conn, NetworkObject playerObject, int score)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(playerObject);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref score;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_RpcLogic___SetPlayerScore_1865307316_Private_Void_NetworkConnection_NetworkObject_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600677F RID: 26495 RVA: 0x001D19A0 File Offset: 0x001CFBA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209789, XrefRangeEnd = 209795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetPlayerScore_1865307316(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_RpcReader___Observers_SetPlayerScore_1865307316_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006780 RID: 26496 RVA: 0x001D19F0 File Offset: 0x001CFBF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209795, XrefRangeEnd = 209807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_SetPlayerScore_1865307316(NetworkConnection conn, NetworkObject playerObject, int score)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(playerObject);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref score;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_RpcWriter___Target_SetPlayerScore_1865307316_Private_Void_NetworkConnection_NetworkObject_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006781 RID: 26497 RVA: 0x001D1A54 File Offset: 0x001CFC54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209807, XrefRangeEnd = 209813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_SetPlayerScore_1865307316(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_RpcReader___Target_SetPlayerScore_1865307316_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006782 RID: 26498 RVA: 0x001D1AA4 File Offset: 0x001CFCA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209813, XrefRangeEnd = 209832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetPlayerList_204172449(NetworkConnection conn, Il2CppReferenceArray<NetworkObject> playerObjects)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(playerObjects);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_RpcWriter___Observers_SetPlayerList_204172449_Private_Void_NetworkConnection_Il2CppReferenceArray_1_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006783 RID: 26499 RVA: 0x001D1AF8 File Offset: 0x001CFCF8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 209867, RefRangeEnd = 209870, XrefRangeStart = 209832, XrefRangeEnd = 209867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetPlayerList_204172449(NetworkConnection conn, Il2CppReferenceArray<NetworkObject> playerObjects)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(playerObjects);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_RpcLogic___SetPlayerList_204172449_Private_Void_NetworkConnection_Il2CppReferenceArray_1_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006784 RID: 26500 RVA: 0x001D1B4C File Offset: 0x001CFD4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209870, XrefRangeEnd = 209874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetPlayerList_204172449(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_RpcReader___Observers_SetPlayerList_204172449_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006785 RID: 26501 RVA: 0x001D1B9C File Offset: 0x001CFD9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209874, XrefRangeEnd = 209893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_SetPlayerList_204172449(NetworkConnection conn, Il2CppReferenceArray<NetworkObject> playerObjects)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(playerObjects);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_RpcWriter___Target_SetPlayerList_204172449_Private_Void_NetworkConnection_Il2CppReferenceArray_1_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006786 RID: 26502 RVA: 0x001D1BF0 File Offset: 0x001CFDF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209893, XrefRangeEnd = 209897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_SetPlayerList_204172449(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_RpcReader___Target_SetPlayerList_204172449_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006787 RID: 26503 RVA: 0x001D1C40 File Offset: 0x001CFE40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209897, XrefRangeEnd = 209909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendPlayerBool_77262511(NetworkObject playerObject, string key, bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(playerObject);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(key);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_RpcWriter___Server_SendPlayerBool_77262511_Private_Void_NetworkObject_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006788 RID: 26504 RVA: 0x001D1CA4 File Offset: 0x001CFEA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209909, XrefRangeEnd = 209910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendPlayerBool_77262511(NetworkObject playerObject, string key, bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(playerObject);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(key);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_RpcLogic___SendPlayerBool_77262511_Public_Void_NetworkObject_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006789 RID: 26505 RVA: 0x001D1D08 File Offset: 0x001CFF08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209910, XrefRangeEnd = 209915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendPlayerBool_77262511(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_RpcReader___Server_SendPlayerBool_77262511_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600678A RID: 26506 RVA: 0x001D1D6C File Offset: 0x001CFF6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209915, XrefRangeEnd = 209936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_ReceivePlayerBool_1748594478(NetworkConnection conn, NetworkObject playerObject, string key, bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(playerObject);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(key);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_RpcWriter___Observers_ReceivePlayerBool_1748594478_Private_Void_NetworkConnection_NetworkObject_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600678B RID: 26507 RVA: 0x001D1DE0 File Offset: 0x001CFFE0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 209959, RefRangeEnd = 209962, XrefRangeStart = 209936, XrefRangeEnd = 209959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ReceivePlayerBool_1748594478(NetworkConnection conn, NetworkObject playerObject, string key, bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(playerObject);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(key);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_RpcLogic___ReceivePlayerBool_1748594478_Private_Void_NetworkConnection_NetworkObject_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600678C RID: 26508 RVA: 0x001D1E54 File Offset: 0x001D0054
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209962, XrefRangeEnd = 209967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_ReceivePlayerBool_1748594478(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_RpcReader___Observers_ReceivePlayerBool_1748594478_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600678D RID: 26509 RVA: 0x001D1EA4 File Offset: 0x001D00A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209967, XrefRangeEnd = 209979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_ReceivePlayerBool_1748594478(NetworkConnection conn, NetworkObject playerObject, string key, bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(playerObject);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(key);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_RpcWriter___Target_ReceivePlayerBool_1748594478_Private_Void_NetworkConnection_NetworkObject_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600678E RID: 26510 RVA: 0x001D1F18 File Offset: 0x001D0118
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209979, XrefRangeEnd = 209984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_ReceivePlayerBool_1748594478(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_RpcReader___Target_ReceivePlayerBool_1748594478_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600678F RID: 26511 RVA: 0x001D1F68 File Offset: 0x001D0168
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209984, XrefRangeEnd = 209996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendPlayerFloat_2931762093(NetworkObject playerObject, string key, float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(playerObject);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(key);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_RpcWriter___Server_SendPlayerFloat_2931762093_Private_Void_NetworkObject_String_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006790 RID: 26512 RVA: 0x001D1FCC File Offset: 0x001D01CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209996, XrefRangeEnd = 209997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendPlayerFloat_2931762093(NetworkObject playerObject, string key, float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(playerObject);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(key);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_RpcLogic___SendPlayerFloat_2931762093_Public_Void_NetworkObject_String_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006791 RID: 26513 RVA: 0x001D2030 File Offset: 0x001D0230
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209997, XrefRangeEnd = 210003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendPlayerFloat_2931762093(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_RpcReader___Server_SendPlayerFloat_2931762093_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006792 RID: 26514 RVA: 0x001D2094 File Offset: 0x001D0294
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210003, XrefRangeEnd = 210024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_ReceivePlayerFloat_2317689966(NetworkConnection conn, NetworkObject playerObject, string key, float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(playerObject);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(key);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_RpcWriter___Observers_ReceivePlayerFloat_2317689966_Private_Void_NetworkConnection_NetworkObject_String_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006793 RID: 26515 RVA: 0x001D2108 File Offset: 0x001D0308
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 210047, RefRangeEnd = 210050, XrefRangeStart = 210024, XrefRangeEnd = 210047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ReceivePlayerFloat_2317689966(NetworkConnection conn, NetworkObject playerObject, string key, float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(playerObject);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(key);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_RpcLogic___ReceivePlayerFloat_2317689966_Private_Void_NetworkConnection_NetworkObject_String_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006794 RID: 26516 RVA: 0x001D217C File Offset: 0x001D037C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210050, XrefRangeEnd = 210056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_ReceivePlayerFloat_2317689966(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_RpcReader___Observers_ReceivePlayerFloat_2317689966_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006795 RID: 26517 RVA: 0x001D21CC File Offset: 0x001D03CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210056, XrefRangeEnd = 210068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_ReceivePlayerFloat_2317689966(NetworkConnection conn, NetworkObject playerObject, string key, float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(playerObject);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(key);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_RpcWriter___Target_ReceivePlayerFloat_2317689966_Private_Void_NetworkConnection_NetworkObject_String_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006796 RID: 26518 RVA: 0x001D2240 File Offset: 0x001D0440
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210068, XrefRangeEnd = 210074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_ReceivePlayerFloat_2317689966(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_RpcReader___Target_ReceivePlayerFloat_2317689966_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006797 RID: 26519 RVA: 0x001D2290 File Offset: 0x001D0490
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210074, XrefRangeEnd = 210078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Method_Private_Void_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_Method_Private_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006798 RID: 26520 RVA: 0x00030D0F File Offset: 0x0002EF0F
		public CasinoGamePlayers(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001F14 RID: 7956
		// (get) Token: 0x06006799 RID: 26521 RVA: 0x001D22C4 File Offset: 0x001D04C4
		// (set) Token: 0x0600679A RID: 26522 RVA: 0x00030D18 File Offset: 0x0002EF18
		public unsafe int PlayerLimit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGamePlayers.NativeFieldInfoPtr_PlayerLimit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGamePlayers.NativeFieldInfoPtr_PlayerLimit)) = value;
			}
		}

		// Token: 0x17001F15 RID: 7957
		// (get) Token: 0x0600679B RID: 26523 RVA: 0x001D22EC File Offset: 0x001D04EC
		// (set) Token: 0x0600679C RID: 26524 RVA: 0x00030D33 File Offset: 0x0002EF33
		public unsafe Il2CppReferenceArray<Player> Players
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGamePlayers.NativeFieldInfoPtr_Players);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Player>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGamePlayers.NativeFieldInfoPtr_Players), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F16 RID: 7958
		// (get) Token: 0x0600679D RID: 26525 RVA: 0x001D231C File Offset: 0x001D051C
		// (set) Token: 0x0600679E RID: 26526 RVA: 0x00030D52 File Offset: 0x0002EF52
		public unsafe UnityEvent onPlayerListChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGamePlayers.NativeFieldInfoPtr_onPlayerListChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGamePlayers.NativeFieldInfoPtr_onPlayerListChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F17 RID: 7959
		// (get) Token: 0x0600679F RID: 26527 RVA: 0x001D234C File Offset: 0x001D054C
		// (set) Token: 0x060067A0 RID: 26528 RVA: 0x00030D71 File Offset: 0x0002EF71
		public unsafe UnityEvent onPlayerScoresChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGamePlayers.NativeFieldInfoPtr_onPlayerScoresChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGamePlayers.NativeFieldInfoPtr_onPlayerScoresChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F18 RID: 7960
		// (get) Token: 0x060067A1 RID: 26529 RVA: 0x001D237C File Offset: 0x001D057C
		// (set) Token: 0x060067A2 RID: 26530 RVA: 0x00030D90 File Offset: 0x0002EF90
		public unsafe Dictionary<Player, int> playerScores
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGamePlayers.NativeFieldInfoPtr_playerScores);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<Player, int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGamePlayers.NativeFieldInfoPtr_playerScores), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F19 RID: 7961
		// (get) Token: 0x060067A3 RID: 26531 RVA: 0x001D23AC File Offset: 0x001D05AC
		// (set) Token: 0x060067A4 RID: 26532 RVA: 0x00030DAF File Offset: 0x0002EFAF
		public unsafe Dictionary<Player, CasinoGamePlayerData> playerDatas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGamePlayers.NativeFieldInfoPtr_playerDatas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<Player, CasinoGamePlayerData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGamePlayers.NativeFieldInfoPtr_playerDatas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F1A RID: 7962
		// (get) Token: 0x060067A5 RID: 26533 RVA: 0x001D23DC File Offset: 0x001D05DC
		// (set) Token: 0x060067A6 RID: 26534 RVA: 0x00030DCE File Offset: 0x0002EFCE
		public unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGamePlayers.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGamePlayers.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17001F1B RID: 7963
		// (get) Token: 0x060067A7 RID: 26535 RVA: 0x001D2404 File Offset: 0x001D0604
		// (set) Token: 0x060067A8 RID: 26536 RVA: 0x00030DE9 File Offset: 0x0002EFE9
		public unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGamePlayers.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGamePlayers.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x040046BD RID: 18109
		private static readonly IntPtr NativeFieldInfoPtr_PlayerLimit;

		// Token: 0x040046BE RID: 18110
		private static readonly IntPtr NativeFieldInfoPtr_Players;

		// Token: 0x040046BF RID: 18111
		private static readonly IntPtr NativeFieldInfoPtr_onPlayerListChanged;

		// Token: 0x040046C0 RID: 18112
		private static readonly IntPtr NativeFieldInfoPtr_onPlayerScoresChanged;

		// Token: 0x040046C1 RID: 18113
		private static readonly IntPtr NativeFieldInfoPtr_playerScores;

		// Token: 0x040046C2 RID: 18114
		private static readonly IntPtr NativeFieldInfoPtr_playerDatas;

		// Token: 0x040046C3 RID: 18115
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x040046C4 RID: 18116
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x040046C5 RID: 18117
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentPlayerCount_Public_get_Int32_0;

		// Token: 0x040046C6 RID: 18118
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x040046C7 RID: 18119
		private static readonly IntPtr NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0;

		// Token: 0x040046C8 RID: 18120
		private static readonly IntPtr NativeMethodInfoPtr_AddPlayer_Public_Void_Player_0;

		// Token: 0x040046C9 RID: 18121
		private static readonly IntPtr NativeMethodInfoPtr_RemovePlayer_Public_Void_Player_0;

		// Token: 0x040046CA RID: 18122
		private static readonly IntPtr NativeMethodInfoPtr_SetPlayerScore_Public_Void_Player_Int32_0;

		// Token: 0x040046CB RID: 18123
		private static readonly IntPtr NativeMethodInfoPtr_GetPlayerScore_Public_Int32_Player_0;

		// Token: 0x040046CC RID: 18124
		private static readonly IntPtr NativeMethodInfoPtr_GetPlayer_Public_Player_Int32_0;

		// Token: 0x040046CD RID: 18125
		private static readonly IntPtr NativeMethodInfoPtr_GetPlayerIndex_Public_Int32_Player_0;

		// Token: 0x040046CE RID: 18126
		private static readonly IntPtr NativeMethodInfoPtr_RequestAddPlayer_Private_Void_NetworkObject_0;

		// Token: 0x040046CF RID: 18127
		private static readonly IntPtr NativeMethodInfoPtr_AddPlayerToArray_Private_Void_Player_0;

		// Token: 0x040046D0 RID: 18128
		private static readonly IntPtr NativeMethodInfoPtr_RequestRemovePlayer_Private_Void_NetworkObject_0;

		// Token: 0x040046D1 RID: 18129
		private static readonly IntPtr NativeMethodInfoPtr_RemovePlayerFromArray_Private_Void_Player_0;

		// Token: 0x040046D2 RID: 18130
		private static readonly IntPtr NativeMethodInfoPtr_RequestSetScore_Private_Void_NetworkObject_Int32_0;

		// Token: 0x040046D3 RID: 18131
		private static readonly IntPtr NativeMethodInfoPtr_SetPlayerScore_Private_Void_NetworkConnection_NetworkObject_Int32_0;

		// Token: 0x040046D4 RID: 18132
		private static readonly IntPtr NativeMethodInfoPtr_SetPlayerList_Private_Void_NetworkConnection_Il2CppReferenceArray_1_NetworkObject_0;

		// Token: 0x040046D5 RID: 18133
		private static readonly IntPtr NativeMethodInfoPtr_GetPlayerData_Public_CasinoGamePlayerData_0;

		// Token: 0x040046D6 RID: 18134
		private static readonly IntPtr NativeMethodInfoPtr_GetPlayerData_Public_CasinoGamePlayerData_Player_0;

		// Token: 0x040046D7 RID: 18135
		private static readonly IntPtr NativeMethodInfoPtr_GetPlayerData_Public_CasinoGamePlayerData_Int32_0;

		// Token: 0x040046D8 RID: 18136
		private static readonly IntPtr NativeMethodInfoPtr_SendPlayerBool_Public_Void_NetworkObject_String_Boolean_0;

		// Token: 0x040046D9 RID: 18137
		private static readonly IntPtr NativeMethodInfoPtr_ReceivePlayerBool_Private_Void_NetworkConnection_NetworkObject_String_Boolean_0;

		// Token: 0x040046DA RID: 18138
		private static readonly IntPtr NativeMethodInfoPtr_SendPlayerFloat_Public_Void_NetworkObject_String_Single_0;

		// Token: 0x040046DB RID: 18139
		private static readonly IntPtr NativeMethodInfoPtr_ReceivePlayerFloat_Private_Void_NetworkConnection_NetworkObject_String_Single_0;

		// Token: 0x040046DC RID: 18140
		private static readonly IntPtr NativeMethodInfoPtr_GetPlayerObjects_Private_Il2CppReferenceArray_1_NetworkObject_0;

		// Token: 0x040046DD RID: 18141
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040046DE RID: 18142
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x040046DF RID: 18143
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x040046E0 RID: 18144
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x040046E1 RID: 18145
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_RequestAddPlayer_3323014238_Private_Void_NetworkObject_0;

		// Token: 0x040046E2 RID: 18146
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___RequestAddPlayer_3323014238_Private_Void_NetworkObject_0;

		// Token: 0x040046E3 RID: 18147
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_RequestAddPlayer_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x040046E4 RID: 18148
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_RequestRemovePlayer_3323014238_Private_Void_NetworkObject_0;

		// Token: 0x040046E5 RID: 18149
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___RequestRemovePlayer_3323014238_Private_Void_NetworkObject_0;

		// Token: 0x040046E6 RID: 18150
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_RequestRemovePlayer_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x040046E7 RID: 18151
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_RequestSetScore_4172557123_Private_Void_NetworkObject_Int32_0;

		// Token: 0x040046E8 RID: 18152
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___RequestSetScore_4172557123_Private_Void_NetworkObject_Int32_0;

		// Token: 0x040046E9 RID: 18153
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_RequestSetScore_4172557123_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x040046EA RID: 18154
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetPlayerScore_1865307316_Private_Void_NetworkConnection_NetworkObject_Int32_0;

		// Token: 0x040046EB RID: 18155
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetPlayerScore_1865307316_Private_Void_NetworkConnection_NetworkObject_Int32_0;

		// Token: 0x040046EC RID: 18156
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetPlayerScore_1865307316_Private_Void_PooledReader_Channel_0;

		// Token: 0x040046ED RID: 18157
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_SetPlayerScore_1865307316_Private_Void_NetworkConnection_NetworkObject_Int32_0;

		// Token: 0x040046EE RID: 18158
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_SetPlayerScore_1865307316_Private_Void_PooledReader_Channel_0;

		// Token: 0x040046EF RID: 18159
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetPlayerList_204172449_Private_Void_NetworkConnection_Il2CppReferenceArray_1_NetworkObject_0;

		// Token: 0x040046F0 RID: 18160
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetPlayerList_204172449_Private_Void_NetworkConnection_Il2CppReferenceArray_1_NetworkObject_0;

		// Token: 0x040046F1 RID: 18161
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetPlayerList_204172449_Private_Void_PooledReader_Channel_0;

		// Token: 0x040046F2 RID: 18162
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_SetPlayerList_204172449_Private_Void_NetworkConnection_Il2CppReferenceArray_1_NetworkObject_0;

		// Token: 0x040046F3 RID: 18163
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_SetPlayerList_204172449_Private_Void_PooledReader_Channel_0;

		// Token: 0x040046F4 RID: 18164
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendPlayerBool_77262511_Private_Void_NetworkObject_String_Boolean_0;

		// Token: 0x040046F5 RID: 18165
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendPlayerBool_77262511_Public_Void_NetworkObject_String_Boolean_0;

		// Token: 0x040046F6 RID: 18166
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendPlayerBool_77262511_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x040046F7 RID: 18167
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_ReceivePlayerBool_1748594478_Private_Void_NetworkConnection_NetworkObject_String_Boolean_0;

		// Token: 0x040046F8 RID: 18168
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___ReceivePlayerBool_1748594478_Private_Void_NetworkConnection_NetworkObject_String_Boolean_0;

		// Token: 0x040046F9 RID: 18169
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_ReceivePlayerBool_1748594478_Private_Void_PooledReader_Channel_0;

		// Token: 0x040046FA RID: 18170
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_ReceivePlayerBool_1748594478_Private_Void_NetworkConnection_NetworkObject_String_Boolean_0;

		// Token: 0x040046FB RID: 18171
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_ReceivePlayerBool_1748594478_Private_Void_PooledReader_Channel_0;

		// Token: 0x040046FC RID: 18172
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendPlayerFloat_2931762093_Private_Void_NetworkObject_String_Single_0;

		// Token: 0x040046FD RID: 18173
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendPlayerFloat_2931762093_Public_Void_NetworkObject_String_Single_0;

		// Token: 0x040046FE RID: 18174
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendPlayerFloat_2931762093_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x040046FF RID: 18175
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_ReceivePlayerFloat_2317689966_Private_Void_NetworkConnection_NetworkObject_String_Single_0;

		// Token: 0x04004700 RID: 18176
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___ReceivePlayerFloat_2317689966_Private_Void_NetworkConnection_NetworkObject_String_Single_0;

		// Token: 0x04004701 RID: 18177
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_ReceivePlayerFloat_2317689966_Private_Void_PooledReader_Channel_0;

		// Token: 0x04004702 RID: 18178
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_ReceivePlayerFloat_2317689966_Private_Void_NetworkConnection_NetworkObject_String_Single_0;

		// Token: 0x04004703 RID: 18179
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_ReceivePlayerFloat_2317689966_Private_Void_PooledReader_Channel_0;

		// Token: 0x04004704 RID: 18180
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Void_PDM_0;

		// Token: 0x02000A41 RID: 2625
		[ObfuscatedName("ScheduleOne.Casino.CasinoGamePlayers+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x0600CFD7 RID: 53207 RVA: 0x0031E4A8 File Offset: 0x0031C6A8
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<CasinoGamePlayers.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CasinoGamePlayers.__c>.NativeClassPtr);
				CasinoGamePlayers.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CasinoGamePlayers.__c>.NativeClassPtr, "<>9");
				CasinoGamePlayers.__c.NativeFieldInfoPtr___9__2_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CasinoGamePlayers.__c>.NativeClassPtr, "<>9__2_0");
				CasinoGamePlayers.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers.__c>.NativeClassPtr, 100676460);
				CasinoGamePlayers.__c.NativeMethodInfoPtr__get_CurrentPlayerCount_b__2_0_Internal_Boolean_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers.__c>.NativeClassPtr, 100676461);
			}

			// Token: 0x0600CFD8 RID: 53208 RVA: 0x0031E524 File Offset: 0x0031C724
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CasinoGamePlayers.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CFD9 RID: 53209 RVA: 0x0031E560 File Offset: 0x0031C760
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209031, XrefRangeEnd = 209035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _get_CurrentPlayerCount_b__2_0(Player p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.__c.NativeMethodInfoPtr__get_CurrentPlayerCount_b__2_0_Internal_Boolean_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CFDA RID: 53210 RVA: 0x000651F7 File Offset: 0x000633F7
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004090 RID: 16528
			// (get) Token: 0x0600CFDB RID: 53211 RVA: 0x0031E5B0 File Offset: 0x0031C7B0
			// (set) Token: 0x0600CFDC RID: 53212 RVA: 0x00065200 File Offset: 0x00063400
			public unsafe static CasinoGamePlayers.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CasinoGamePlayers.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CasinoGamePlayers.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CasinoGamePlayers.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004091 RID: 16529
			// (get) Token: 0x0600CFDD RID: 53213 RVA: 0x0031E5D8 File Offset: 0x0031C7D8
			// (set) Token: 0x0600CFDE RID: 53214 RVA: 0x00065212 File Offset: 0x00063412
			public unsafe static Func<Player, bool> __9__2_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CasinoGamePlayers.__c.NativeFieldInfoPtr___9__2_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Player, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CasinoGamePlayers.__c.NativeFieldInfoPtr___9__2_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008C2A RID: 35882
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04008C2B RID: 35883
			private static readonly IntPtr NativeFieldInfoPtr___9__2_0;

			// Token: 0x04008C2C RID: 35884
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008C2D RID: 35885
			private static readonly IntPtr NativeMethodInfoPtr__get_CurrentPlayerCount_b__2_0_Internal_Boolean_Player_0;
		}
	}
}
