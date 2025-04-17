using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Combat;
using Il2CppScheduleOne.Noise;
using Il2CppScheduleOne.NPCs.Actions;
using Il2CppScheduleOne.PlayerScripts;
using Il2CppScheduleOne.Vehicles;
using UnityEngine;

namespace Il2CppScheduleOne.NPCs.Responses
{
	// Token: 0x020002ED RID: 749
	public class NPCResponses : MonoBehaviour
	{
		// Token: 0x0600388E RID: 14478 RVA: 0x0012806C File Offset: 0x0012626C
		// Note: this type is marked as 'beforefieldinit'.
		static NPCResponses()
		{
			Il2CppClassPointerStore<NPCResponses>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.Responses", "NPCResponses");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCResponses>.NativeClassPtr);
			NPCResponses.NativeFieldInfoPtr_ASSAULT_RELATIONSHIPCHANGE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCResponses>.NativeClassPtr, "ASSAULT_RELATIONSHIPCHANGE");
			NPCResponses.NativeFieldInfoPtr_DEADLYASSAULT_RELATIONSHIPCHANGE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCResponses>.NativeClassPtr, "DEADLYASSAULT_RELATIONSHIPCHANGE");
			NPCResponses.NativeFieldInfoPtr_AIMED_AT_RELATIONSHIPCHANGE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCResponses>.NativeClassPtr, "AIMED_AT_RELATIONSHIPCHANGE");
			NPCResponses.NativeFieldInfoPtr_PICKPOCKET_RELATIONSHIPCHANGE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCResponses>.NativeClassPtr, "PICKPOCKET_RELATIONSHIPCHANGE");
			NPCResponses.NativeFieldInfoPtr__npc_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCResponses>.NativeClassPtr, "<npc>k__BackingField");
			NPCResponses.NativeFieldInfoPtr_timeSinceLastImpact = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCResponses>.NativeClassPtr, "timeSinceLastImpact");
			NPCResponses.NativeFieldInfoPtr_timeSinceAimedAt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCResponses>.NativeClassPtr, "timeSinceAimedAt");
			NPCResponses.NativeMethodInfoPtr_get_npc_Protected_get_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCResponses>.NativeClassPtr, 100669864);
			NPCResponses.NativeMethodInfoPtr_set_npc_Private_set_Void_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCResponses>.NativeClassPtr, 100669865);
			NPCResponses.NativeMethodInfoPtr_get_actions_Protected_get_NPCActions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCResponses>.NativeClassPtr, 100669866);
			NPCResponses.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCResponses>.NativeClassPtr, 100669867);
			NPCResponses.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCResponses>.NativeClassPtr, 100669868);
			NPCResponses.NativeMethodInfoPtr_GunshotHeard_Public_Virtual_New_Void_NoiseEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCResponses>.NativeClassPtr, 100669869);
			NPCResponses.NativeMethodInfoPtr_ExplosionHeard_Public_Virtual_New_Void_NoiseEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCResponses>.NativeClassPtr, 100669870);
			NPCResponses.NativeMethodInfoPtr_NoticedPettyCrime_Public_Virtual_New_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCResponses>.NativeClassPtr, 100669871);
			NPCResponses.NativeMethodInfoPtr_NoticedVandalism_Public_Virtual_New_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCResponses>.NativeClassPtr, 100669872);
			NPCResponses.NativeMethodInfoPtr_SawPickpocketing_Public_Virtual_New_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCResponses>.NativeClassPtr, 100669873);
			NPCResponses.NativeMethodInfoPtr_NoticePlayerBrandishingWeapon_Public_Virtual_New_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCResponses>.NativeClassPtr, 100669874);
			NPCResponses.NativeMethodInfoPtr_NoticePlayerDischargingWeapon_Public_Virtual_New_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCResponses>.NativeClassPtr, 100669875);
			NPCResponses.NativeMethodInfoPtr_PlayerFailedPickpocket_Public_Virtual_New_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCResponses>.NativeClassPtr, 100669876);
			NPCResponses.NativeMethodInfoPtr_NoticedDrugDeal_Public_Virtual_New_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCResponses>.NativeClassPtr, 100669877);
			NPCResponses.NativeMethodInfoPtr_NoticedViolatingCurfew_Public_Virtual_New_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCResponses>.NativeClassPtr, 100669878);
			NPCResponses.NativeMethodInfoPtr_NoticedWantedPlayer_Public_Virtual_New_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCResponses>.NativeClassPtr, 100669879);
			NPCResponses.NativeMethodInfoPtr_NoticedSuspiciousPlayer_Public_Virtual_New_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCResponses>.NativeClassPtr, 100669880);
			NPCResponses.NativeMethodInfoPtr_HitByCar_Public_Virtual_New_Void_LandVehicle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCResponses>.NativeClassPtr, 100669881);
			NPCResponses.NativeMethodInfoPtr_ImpactReceived_Public_Virtual_New_Void_Impact_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCResponses>.NativeClassPtr, 100669882);
			NPCResponses.NativeMethodInfoPtr_RespondToFirstNonLethalAttack_Protected_Virtual_New_Void_Player_Impact_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCResponses>.NativeClassPtr, 100669883);
			NPCResponses.NativeMethodInfoPtr_RespondToRepeatedNonLethalAttack_Protected_Virtual_New_Void_Player_Impact_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCResponses>.NativeClassPtr, 100669884);
			NPCResponses.NativeMethodInfoPtr_RespondToLethalAttack_Protected_Virtual_New_Void_Player_Impact_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCResponses>.NativeClassPtr, 100669885);
			NPCResponses.NativeMethodInfoPtr_RespondToAnnoyingImpact_Protected_Virtual_New_Void_Player_Impact_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCResponses>.NativeClassPtr, 100669886);
			NPCResponses.NativeMethodInfoPtr_RespondToAimedAt_Public_Virtual_New_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCResponses>.NativeClassPtr, 100669887);
			NPCResponses.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCResponses>.NativeClassPtr, 100669888);
		}

		// Token: 0x17001204 RID: 4612
		// (get) Token: 0x0600388F RID: 14479 RVA: 0x0012831C File Offset: 0x0012651C
		// (set) Token: 0x06003890 RID: 14480 RVA: 0x0012835C File Offset: 0x0012655C
		public unsafe NPC npc
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 17402, RefRangeEnd = 17403, XrefRangeStart = 17402, XrefRangeEnd = 17403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCResponses.NativeMethodInfoPtr_get_npc_Protected_get_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NPC>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCResponses.NativeMethodInfoPtr_set_npc_Private_set_Void_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001205 RID: 4613
		// (get) Token: 0x06003891 RID: 14481 RVA: 0x001283A0 File Offset: 0x001265A0
		public unsafe NPCActions actions
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCResponses.NativeMethodInfoPtr_get_actions_Protected_get_NPCActions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NPCActions>(intPtr3) : null;
			}
		}

		// Token: 0x06003892 RID: 14482 RVA: 0x001283E0 File Offset: 0x001265E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 141433, RefRangeEnd = 141434, XrefRangeStart = 141429, XrefRangeEnd = 141433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCResponses.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003893 RID: 14483 RVA: 0x0012841C File Offset: 0x0012661C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141434, XrefRangeEnd = 141436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCResponses.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003894 RID: 14484 RVA: 0x00128458 File Offset: 0x00126658
		[CallerCount(13604)]
		[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void GunshotHeard(NoiseEvent gunshotSound)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(gunshotSound);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCResponses.NativeMethodInfoPtr_GunshotHeard_Public_Virtual_New_Void_NoiseEvent_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003895 RID: 14485 RVA: 0x001284A8 File Offset: 0x001266A8
		[CallerCount(13604)]
		[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ExplosionHeard(NoiseEvent explosionSound)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(explosionSound);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCResponses.NativeMethodInfoPtr_ExplosionHeard_Public_Virtual_New_Void_NoiseEvent_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003896 RID: 14486 RVA: 0x001284F8 File Offset: 0x001266F8
		[CallerCount(13604)]
		[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void NoticedPettyCrime(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCResponses.NativeMethodInfoPtr_NoticedPettyCrime_Public_Virtual_New_Void_Player_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003897 RID: 14487 RVA: 0x00128548 File Offset: 0x00126748
		[CallerCount(13604)]
		[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void NoticedVandalism(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCResponses.NativeMethodInfoPtr_NoticedVandalism_Public_Virtual_New_Void_Player_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003898 RID: 14488 RVA: 0x00128598 File Offset: 0x00126798
		[CallerCount(13604)]
		[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SawPickpocketing(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCResponses.NativeMethodInfoPtr_SawPickpocketing_Public_Virtual_New_Void_Player_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003899 RID: 14489 RVA: 0x001285E8 File Offset: 0x001267E8
		[CallerCount(13604)]
		[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void NoticePlayerBrandishingWeapon(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCResponses.NativeMethodInfoPtr_NoticePlayerBrandishingWeapon_Public_Virtual_New_Void_Player_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600389A RID: 14490 RVA: 0x00128638 File Offset: 0x00126838
		[CallerCount(13604)]
		[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void NoticePlayerDischargingWeapon(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCResponses.NativeMethodInfoPtr_NoticePlayerDischargingWeapon_Public_Virtual_New_Void_Player_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600389B RID: 14491 RVA: 0x00128688 File Offset: 0x00126888
		[CallerCount(0)]
		public unsafe virtual void PlayerFailedPickpocket(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCResponses.NativeMethodInfoPtr_PlayerFailedPickpocket_Public_Virtual_New_Void_Player_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600389C RID: 14492 RVA: 0x001286D8 File Offset: 0x001268D8
		[CallerCount(13604)]
		[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void NoticedDrugDeal(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCResponses.NativeMethodInfoPtr_NoticedDrugDeal_Public_Virtual_New_Void_Player_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600389D RID: 14493 RVA: 0x00128728 File Offset: 0x00126928
		[CallerCount(13604)]
		[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void NoticedViolatingCurfew(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCResponses.NativeMethodInfoPtr_NoticedViolatingCurfew_Public_Virtual_New_Void_Player_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600389E RID: 14494 RVA: 0x00128778 File Offset: 0x00126978
		[CallerCount(13604)]
		[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void NoticedWantedPlayer(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCResponses.NativeMethodInfoPtr_NoticedWantedPlayer_Public_Virtual_New_Void_Player_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600389F RID: 14495 RVA: 0x001287C8 File Offset: 0x001269C8
		[CallerCount(13604)]
		[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void NoticedSuspiciousPlayer(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCResponses.NativeMethodInfoPtr_NoticedSuspiciousPlayer_Public_Virtual_New_Void_Player_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060038A0 RID: 14496 RVA: 0x00128818 File Offset: 0x00126A18
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 141461, RefRangeEnd = 141462, XrefRangeStart = 141436, XrefRangeEnd = 141461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void HitByCar(LandVehicle vehicle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(vehicle);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCResponses.NativeMethodInfoPtr_HitByCar_Public_Virtual_New_Void_LandVehicle_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060038A1 RID: 14497 RVA: 0x00128868 File Offset: 0x00126A68
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 141464, RefRangeEnd = 141465, XrefRangeStart = 141462, XrefRangeEnd = 141464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ImpactReceived(Impact impact)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(impact);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCResponses.NativeMethodInfoPtr_ImpactReceived_Public_Virtual_New_Void_Impact_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060038A2 RID: 14498 RVA: 0x001288B8 File Offset: 0x00126AB8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 141465, RefRangeEnd = 141467, XrefRangeStart = 141465, XrefRangeEnd = 141465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RespondToFirstNonLethalAttack(Player perpetrator, Impact impact)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(perpetrator);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(impact);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCResponses.NativeMethodInfoPtr_RespondToFirstNonLethalAttack_Protected_Virtual_New_Void_Player_Impact_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060038A3 RID: 14499 RVA: 0x00128918 File Offset: 0x00126B18
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 141467, RefRangeEnd = 141469, XrefRangeStart = 141467, XrefRangeEnd = 141467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RespondToRepeatedNonLethalAttack(Player perpetrator, Impact impact)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(perpetrator);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(impact);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCResponses.NativeMethodInfoPtr_RespondToRepeatedNonLethalAttack_Protected_Virtual_New_Void_Player_Impact_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060038A4 RID: 14500 RVA: 0x00128978 File Offset: 0x00126B78
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 141469, RefRangeEnd = 141471, XrefRangeStart = 141469, XrefRangeEnd = 141469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RespondToLethalAttack(Player perpetrator, Impact impact)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(perpetrator);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(impact);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCResponses.NativeMethodInfoPtr_RespondToLethalAttack_Protected_Virtual_New_Void_Player_Impact_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060038A5 RID: 14501 RVA: 0x001289D8 File Offset: 0x00126BD8
		[CallerCount(13604)]
		[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RespondToAnnoyingImpact(Player perpetrator, Impact impact)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(perpetrator);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(impact);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCResponses.NativeMethodInfoPtr_RespondToAnnoyingImpact_Protected_Virtual_New_Void_Player_Impact_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060038A6 RID: 14502 RVA: 0x00128A38 File Offset: 0x00126C38
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 141471, RefRangeEnd = 141472, XrefRangeStart = 141471, XrefRangeEnd = 141471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RespondToAimedAt(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCResponses.NativeMethodInfoPtr_RespondToAimedAt_Public_Virtual_New_Void_Player_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060038A7 RID: 14503 RVA: 0x00128A88 File Offset: 0x00126C88
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 141473, RefRangeEnd = 141475, XrefRangeStart = 141472, XrefRangeEnd = 141473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NPCResponses() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCResponses>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCResponses.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060038A8 RID: 14504 RVA: 0x0001D2D6 File Offset: 0x0001B4D6
		public NPCResponses(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170011FD RID: 4605
		// (get) Token: 0x060038A9 RID: 14505 RVA: 0x00128AC4 File Offset: 0x00126CC4
		// (set) Token: 0x060038AA RID: 14506 RVA: 0x0001D2DF File Offset: 0x0001B4DF
		public unsafe static float ASSAULT_RELATIONSHIPCHANGE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(NPCResponses.NativeFieldInfoPtr_ASSAULT_RELATIONSHIPCHANGE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NPCResponses.NativeFieldInfoPtr_ASSAULT_RELATIONSHIPCHANGE, (void*)(&value));
			}
		}

		// Token: 0x170011FE RID: 4606
		// (get) Token: 0x060038AB RID: 14507 RVA: 0x00128AE0 File Offset: 0x00126CE0
		// (set) Token: 0x060038AC RID: 14508 RVA: 0x0001D2ED File Offset: 0x0001B4ED
		public unsafe static float DEADLYASSAULT_RELATIONSHIPCHANGE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(NPCResponses.NativeFieldInfoPtr_DEADLYASSAULT_RELATIONSHIPCHANGE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NPCResponses.NativeFieldInfoPtr_DEADLYASSAULT_RELATIONSHIPCHANGE, (void*)(&value));
			}
		}

		// Token: 0x170011FF RID: 4607
		// (get) Token: 0x060038AD RID: 14509 RVA: 0x00128AFC File Offset: 0x00126CFC
		// (set) Token: 0x060038AE RID: 14510 RVA: 0x0001D2FB File Offset: 0x0001B4FB
		public unsafe static float AIMED_AT_RELATIONSHIPCHANGE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(NPCResponses.NativeFieldInfoPtr_AIMED_AT_RELATIONSHIPCHANGE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NPCResponses.NativeFieldInfoPtr_AIMED_AT_RELATIONSHIPCHANGE, (void*)(&value));
			}
		}

		// Token: 0x17001200 RID: 4608
		// (get) Token: 0x060038AF RID: 14511 RVA: 0x00128B18 File Offset: 0x00126D18
		// (set) Token: 0x060038B0 RID: 14512 RVA: 0x0001D309 File Offset: 0x0001B509
		public unsafe static float PICKPOCKET_RELATIONSHIPCHANGE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(NPCResponses.NativeFieldInfoPtr_PICKPOCKET_RELATIONSHIPCHANGE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NPCResponses.NativeFieldInfoPtr_PICKPOCKET_RELATIONSHIPCHANGE, (void*)(&value));
			}
		}

		// Token: 0x17001201 RID: 4609
		// (get) Token: 0x060038B1 RID: 14513 RVA: 0x00128B34 File Offset: 0x00126D34
		// (set) Token: 0x060038B2 RID: 14514 RVA: 0x0001D317 File Offset: 0x0001B517
		public unsafe NPC _npc_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCResponses.NativeFieldInfoPtr__npc_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPC>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCResponses.NativeFieldInfoPtr__npc_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001202 RID: 4610
		// (get) Token: 0x060038B3 RID: 14515 RVA: 0x00128B64 File Offset: 0x00126D64
		// (set) Token: 0x060038B4 RID: 14516 RVA: 0x0001D336 File Offset: 0x0001B536
		public unsafe float timeSinceLastImpact
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCResponses.NativeFieldInfoPtr_timeSinceLastImpact);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCResponses.NativeFieldInfoPtr_timeSinceLastImpact)) = value;
			}
		}

		// Token: 0x17001203 RID: 4611
		// (get) Token: 0x060038B5 RID: 14517 RVA: 0x00128B8C File Offset: 0x00126D8C
		// (set) Token: 0x060038B6 RID: 14518 RVA: 0x0001D351 File Offset: 0x0001B551
		public unsafe float timeSinceAimedAt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCResponses.NativeFieldInfoPtr_timeSinceAimedAt);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCResponses.NativeFieldInfoPtr_timeSinceAimedAt)) = value;
			}
		}

		// Token: 0x04002548 RID: 9544
		private static readonly IntPtr NativeFieldInfoPtr_ASSAULT_RELATIONSHIPCHANGE;

		// Token: 0x04002549 RID: 9545
		private static readonly IntPtr NativeFieldInfoPtr_DEADLYASSAULT_RELATIONSHIPCHANGE;

		// Token: 0x0400254A RID: 9546
		private static readonly IntPtr NativeFieldInfoPtr_AIMED_AT_RELATIONSHIPCHANGE;

		// Token: 0x0400254B RID: 9547
		private static readonly IntPtr NativeFieldInfoPtr_PICKPOCKET_RELATIONSHIPCHANGE;

		// Token: 0x0400254C RID: 9548
		private static readonly IntPtr NativeFieldInfoPtr__npc_k__BackingField;

		// Token: 0x0400254D RID: 9549
		private static readonly IntPtr NativeFieldInfoPtr_timeSinceLastImpact;

		// Token: 0x0400254E RID: 9550
		private static readonly IntPtr NativeFieldInfoPtr_timeSinceAimedAt;

		// Token: 0x0400254F RID: 9551
		private static readonly IntPtr NativeMethodInfoPtr_get_npc_Protected_get_NPC_0;

		// Token: 0x04002550 RID: 9552
		private static readonly IntPtr NativeMethodInfoPtr_set_npc_Private_set_Void_NPC_0;

		// Token: 0x04002551 RID: 9553
		private static readonly IntPtr NativeMethodInfoPtr_get_actions_Protected_get_NPCActions_0;

		// Token: 0x04002552 RID: 9554
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x04002553 RID: 9555
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x04002554 RID: 9556
		private static readonly IntPtr NativeMethodInfoPtr_GunshotHeard_Public_Virtual_New_Void_NoiseEvent_0;

		// Token: 0x04002555 RID: 9557
		private static readonly IntPtr NativeMethodInfoPtr_ExplosionHeard_Public_Virtual_New_Void_NoiseEvent_0;

		// Token: 0x04002556 RID: 9558
		private static readonly IntPtr NativeMethodInfoPtr_NoticedPettyCrime_Public_Virtual_New_Void_Player_0;

		// Token: 0x04002557 RID: 9559
		private static readonly IntPtr NativeMethodInfoPtr_NoticedVandalism_Public_Virtual_New_Void_Player_0;

		// Token: 0x04002558 RID: 9560
		private static readonly IntPtr NativeMethodInfoPtr_SawPickpocketing_Public_Virtual_New_Void_Player_0;

		// Token: 0x04002559 RID: 9561
		private static readonly IntPtr NativeMethodInfoPtr_NoticePlayerBrandishingWeapon_Public_Virtual_New_Void_Player_0;

		// Token: 0x0400255A RID: 9562
		private static readonly IntPtr NativeMethodInfoPtr_NoticePlayerDischargingWeapon_Public_Virtual_New_Void_Player_0;

		// Token: 0x0400255B RID: 9563
		private static readonly IntPtr NativeMethodInfoPtr_PlayerFailedPickpocket_Public_Virtual_New_Void_Player_0;

		// Token: 0x0400255C RID: 9564
		private static readonly IntPtr NativeMethodInfoPtr_NoticedDrugDeal_Public_Virtual_New_Void_Player_0;

		// Token: 0x0400255D RID: 9565
		private static readonly IntPtr NativeMethodInfoPtr_NoticedViolatingCurfew_Public_Virtual_New_Void_Player_0;

		// Token: 0x0400255E RID: 9566
		private static readonly IntPtr NativeMethodInfoPtr_NoticedWantedPlayer_Public_Virtual_New_Void_Player_0;

		// Token: 0x0400255F RID: 9567
		private static readonly IntPtr NativeMethodInfoPtr_NoticedSuspiciousPlayer_Public_Virtual_New_Void_Player_0;

		// Token: 0x04002560 RID: 9568
		private static readonly IntPtr NativeMethodInfoPtr_HitByCar_Public_Virtual_New_Void_LandVehicle_0;

		// Token: 0x04002561 RID: 9569
		private static readonly IntPtr NativeMethodInfoPtr_ImpactReceived_Public_Virtual_New_Void_Impact_0;

		// Token: 0x04002562 RID: 9570
		private static readonly IntPtr NativeMethodInfoPtr_RespondToFirstNonLethalAttack_Protected_Virtual_New_Void_Player_Impact_0;

		// Token: 0x04002563 RID: 9571
		private static readonly IntPtr NativeMethodInfoPtr_RespondToRepeatedNonLethalAttack_Protected_Virtual_New_Void_Player_Impact_0;

		// Token: 0x04002564 RID: 9572
		private static readonly IntPtr NativeMethodInfoPtr_RespondToLethalAttack_Protected_Virtual_New_Void_Player_Impact_0;

		// Token: 0x04002565 RID: 9573
		private static readonly IntPtr NativeMethodInfoPtr_RespondToAnnoyingImpact_Protected_Virtual_New_Void_Player_Impact_0;

		// Token: 0x04002566 RID: 9574
		private static readonly IntPtr NativeMethodInfoPtr_RespondToAimedAt_Public_Virtual_New_Void_Player_0;

		// Token: 0x04002567 RID: 9575
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
