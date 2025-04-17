using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Combat;
using Il2CppScheduleOne.Noise;
using Il2CppScheduleOne.NPCs.Responses;
using Il2CppScheduleOne.PlayerScripts;
using Il2CppScheduleOne.Vehicles;

namespace Il2CppScheduleOne.Police
{
	// Token: 0x020001F8 RID: 504
	public class NPCResponses_Police : NPCResponses
	{
		// Token: 0x060028B4 RID: 10420 RVA: 0x000F11A0 File Offset: 0x000EF3A0
		// Note: this type is marked as 'beforefieldinit'.
		static NPCResponses_Police()
		{
			Il2CppClassPointerStore<NPCResponses_Police>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Police", "NPCResponses_Police");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCResponses_Police>.NativeClassPtr);
			NPCResponses_Police.NativeFieldInfoPtr_officer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCResponses_Police>.NativeClassPtr, "officer");
			NPCResponses_Police.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCResponses_Police>.NativeClassPtr, 100667886);
			NPCResponses_Police.NativeMethodInfoPtr_HitByCar_Public_Virtual_Void_LandVehicle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCResponses_Police>.NativeClassPtr, 100667887);
			NPCResponses_Police.NativeMethodInfoPtr_NoticedDrugDeal_Public_Virtual_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCResponses_Police>.NativeClassPtr, 100667888);
			NPCResponses_Police.NativeMethodInfoPtr_NoticedPettyCrime_Public_Virtual_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCResponses_Police>.NativeClassPtr, 100667889);
			NPCResponses_Police.NativeMethodInfoPtr_NoticedVandalism_Public_Virtual_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCResponses_Police>.NativeClassPtr, 100667890);
			NPCResponses_Police.NativeMethodInfoPtr_SawPickpocketing_Public_Virtual_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCResponses_Police>.NativeClassPtr, 100667891);
			NPCResponses_Police.NativeMethodInfoPtr_NoticePlayerBrandishingWeapon_Public_Virtual_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCResponses_Police>.NativeClassPtr, 100667892);
			NPCResponses_Police.NativeMethodInfoPtr_NoticePlayerDischargingWeapon_Public_Virtual_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCResponses_Police>.NativeClassPtr, 100667893);
			NPCResponses_Police.NativeMethodInfoPtr_NoticedWantedPlayer_Public_Virtual_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCResponses_Police>.NativeClassPtr, 100667894);
			NPCResponses_Police.NativeMethodInfoPtr_NoticedSuspiciousPlayer_Public_Virtual_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCResponses_Police>.NativeClassPtr, 100667895);
			NPCResponses_Police.NativeMethodInfoPtr_NoticedViolatingCurfew_Public_Virtual_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCResponses_Police>.NativeClassPtr, 100667896);
			NPCResponses_Police.NativeMethodInfoPtr_RespondToFirstNonLethalAttack_Protected_Virtual_Void_Player_Impact_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCResponses_Police>.NativeClassPtr, 100667897);
			NPCResponses_Police.NativeMethodInfoPtr_RespondToLethalAttack_Protected_Virtual_Void_Player_Impact_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCResponses_Police>.NativeClassPtr, 100667898);
			NPCResponses_Police.NativeMethodInfoPtr_RespondToRepeatedNonLethalAttack_Protected_Virtual_Void_Player_Impact_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCResponses_Police>.NativeClassPtr, 100667899);
			NPCResponses_Police.NativeMethodInfoPtr_RespondToAnnoyingImpact_Protected_Virtual_Void_Player_Impact_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCResponses_Police>.NativeClassPtr, 100667900);
			NPCResponses_Police.NativeMethodInfoPtr_RespondToAimedAt_Public_Virtual_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCResponses_Police>.NativeClassPtr, 100667901);
			NPCResponses_Police.NativeMethodInfoPtr_ImpactReceived_Public_Virtual_Void_Impact_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCResponses_Police>.NativeClassPtr, 100667902);
			NPCResponses_Police.NativeMethodInfoPtr_GunshotHeard_Public_Virtual_Void_NoiseEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCResponses_Police>.NativeClassPtr, 100667903);
			NPCResponses_Police.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCResponses_Police>.NativeClassPtr, 100667904);
		}

		// Token: 0x060028B5 RID: 10421 RVA: 0x000F1360 File Offset: 0x000EF560
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118672, XrefRangeEnd = 118680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCResponses_Police.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028B6 RID: 10422 RVA: 0x000F139C File Offset: 0x000EF59C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118680, XrefRangeEnd = 118699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void HitByCar(LandVehicle vehicle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(vehicle);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCResponses_Police.NativeMethodInfoPtr_HitByCar_Public_Virtual_Void_LandVehicle_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028B7 RID: 10423 RVA: 0x000F13EC File Offset: 0x000EF5EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118699, XrefRangeEnd = 118710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NoticedDrugDeal(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCResponses_Police.NativeMethodInfoPtr_NoticedDrugDeal_Public_Virtual_Void_Player_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028B8 RID: 10424 RVA: 0x000F143C File Offset: 0x000EF63C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118710, XrefRangeEnd = 118716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NoticedPettyCrime(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCResponses_Police.NativeMethodInfoPtr_NoticedPettyCrime_Public_Virtual_Void_Player_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028B9 RID: 10425 RVA: 0x000F148C File Offset: 0x000EF68C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118716, XrefRangeEnd = 118727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NoticedVandalism(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCResponses_Police.NativeMethodInfoPtr_NoticedVandalism_Public_Virtual_Void_Player_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028BA RID: 10426 RVA: 0x000F14DC File Offset: 0x000EF6DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118727, XrefRangeEnd = 118738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SawPickpocketing(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCResponses_Police.NativeMethodInfoPtr_SawPickpocketing_Public_Virtual_Void_Player_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028BB RID: 10427 RVA: 0x000F152C File Offset: 0x000EF72C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118738, XrefRangeEnd = 118749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NoticePlayerBrandishingWeapon(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCResponses_Police.NativeMethodInfoPtr_NoticePlayerBrandishingWeapon_Public_Virtual_Void_Player_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028BC RID: 10428 RVA: 0x000F157C File Offset: 0x000EF77C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118749, XrefRangeEnd = 118760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NoticePlayerDischargingWeapon(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCResponses_Police.NativeMethodInfoPtr_NoticePlayerDischargingWeapon_Public_Virtual_Void_Player_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028BD RID: 10429 RVA: 0x000F15CC File Offset: 0x000EF7CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118760, XrefRangeEnd = 118770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NoticedWantedPlayer(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCResponses_Police.NativeMethodInfoPtr_NoticedWantedPlayer_Public_Virtual_Void_Player_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028BE RID: 10430 RVA: 0x000F161C File Offset: 0x000EF81C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118770, XrefRangeEnd = 118774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NoticedSuspiciousPlayer(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCResponses_Police.NativeMethodInfoPtr_NoticedSuspiciousPlayer_Public_Virtual_Void_Player_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028BF RID: 10431 RVA: 0x000F166C File Offset: 0x000EF86C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118774, XrefRangeEnd = 118789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NoticedViolatingCurfew(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCResponses_Police.NativeMethodInfoPtr_NoticedViolatingCurfew_Public_Virtual_Void_Player_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028C0 RID: 10432 RVA: 0x000F16BC File Offset: 0x000EF8BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118789, XrefRangeEnd = 118800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void RespondToFirstNonLethalAttack(Player perpetrator, Impact impact)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(perpetrator);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(impact);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCResponses_Police.NativeMethodInfoPtr_RespondToFirstNonLethalAttack_Protected_Virtual_Void_Player_Impact_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028C1 RID: 10433 RVA: 0x000F171C File Offset: 0x000EF91C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118800, XrefRangeEnd = 118808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void RespondToLethalAttack(Player perpetrator, Impact impact)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(perpetrator);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(impact);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCResponses_Police.NativeMethodInfoPtr_RespondToLethalAttack_Protected_Virtual_Void_Player_Impact_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028C2 RID: 10434 RVA: 0x000F177C File Offset: 0x000EF97C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118808, XrefRangeEnd = 118826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void RespondToRepeatedNonLethalAttack(Player perpetrator, Impact impact)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(perpetrator);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(impact);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCResponses_Police.NativeMethodInfoPtr_RespondToRepeatedNonLethalAttack_Protected_Virtual_Void_Player_Impact_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028C3 RID: 10435 RVA: 0x000F17DC File Offset: 0x000EF9DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118826, XrefRangeEnd = 118835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void RespondToAnnoyingImpact(Player perpetrator, Impact impact)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(perpetrator);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(impact);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCResponses_Police.NativeMethodInfoPtr_RespondToAnnoyingImpact_Protected_Virtual_Void_Player_Impact_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028C4 RID: 10436 RVA: 0x000F183C File Offset: 0x000EFA3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118835, XrefRangeEnd = 118843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void RespondToAimedAt(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCResponses_Police.NativeMethodInfoPtr_RespondToAimedAt_Public_Virtual_Void_Player_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028C5 RID: 10437 RVA: 0x000F188C File Offset: 0x000EFA8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118843, XrefRangeEnd = 118845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ImpactReceived(Impact impact)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(impact);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCResponses_Police.NativeMethodInfoPtr_ImpactReceived_Public_Virtual_Void_Impact_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028C6 RID: 10438 RVA: 0x000F18DC File Offset: 0x000EFADC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118845, XrefRangeEnd = 118860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void GunshotHeard(NoiseEvent gunshotSound)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(gunshotSound);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCResponses_Police.NativeMethodInfoPtr_GunshotHeard_Public_Virtual_Void_NoiseEvent_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028C7 RID: 10439 RVA: 0x000F192C File Offset: 0x000EFB2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118860, XrefRangeEnd = 118861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NPCResponses_Police() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCResponses_Police>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCResponses_Police.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028C8 RID: 10440 RVA: 0x000161D3 File Offset: 0x000143D3
		public NPCResponses_Police(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000D93 RID: 3475
		// (get) Token: 0x060028C9 RID: 10441 RVA: 0x000F1968 File Offset: 0x000EFB68
		// (set) Token: 0x060028CA RID: 10442 RVA: 0x000161DC File Offset: 0x000143DC
		public unsafe PoliceOfficer officer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCResponses_Police.NativeFieldInfoPtr_officer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PoliceOfficer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCResponses_Police.NativeFieldInfoPtr_officer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001B00 RID: 6912
		private static readonly IntPtr NativeFieldInfoPtr_officer;

		// Token: 0x04001B01 RID: 6913
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04001B02 RID: 6914
		private static readonly IntPtr NativeMethodInfoPtr_HitByCar_Public_Virtual_Void_LandVehicle_0;

		// Token: 0x04001B03 RID: 6915
		private static readonly IntPtr NativeMethodInfoPtr_NoticedDrugDeal_Public_Virtual_Void_Player_0;

		// Token: 0x04001B04 RID: 6916
		private static readonly IntPtr NativeMethodInfoPtr_NoticedPettyCrime_Public_Virtual_Void_Player_0;

		// Token: 0x04001B05 RID: 6917
		private static readonly IntPtr NativeMethodInfoPtr_NoticedVandalism_Public_Virtual_Void_Player_0;

		// Token: 0x04001B06 RID: 6918
		private static readonly IntPtr NativeMethodInfoPtr_SawPickpocketing_Public_Virtual_Void_Player_0;

		// Token: 0x04001B07 RID: 6919
		private static readonly IntPtr NativeMethodInfoPtr_NoticePlayerBrandishingWeapon_Public_Virtual_Void_Player_0;

		// Token: 0x04001B08 RID: 6920
		private static readonly IntPtr NativeMethodInfoPtr_NoticePlayerDischargingWeapon_Public_Virtual_Void_Player_0;

		// Token: 0x04001B09 RID: 6921
		private static readonly IntPtr NativeMethodInfoPtr_NoticedWantedPlayer_Public_Virtual_Void_Player_0;

		// Token: 0x04001B0A RID: 6922
		private static readonly IntPtr NativeMethodInfoPtr_NoticedSuspiciousPlayer_Public_Virtual_Void_Player_0;

		// Token: 0x04001B0B RID: 6923
		private static readonly IntPtr NativeMethodInfoPtr_NoticedViolatingCurfew_Public_Virtual_Void_Player_0;

		// Token: 0x04001B0C RID: 6924
		private static readonly IntPtr NativeMethodInfoPtr_RespondToFirstNonLethalAttack_Protected_Virtual_Void_Player_Impact_0;

		// Token: 0x04001B0D RID: 6925
		private static readonly IntPtr NativeMethodInfoPtr_RespondToLethalAttack_Protected_Virtual_Void_Player_Impact_0;

		// Token: 0x04001B0E RID: 6926
		private static readonly IntPtr NativeMethodInfoPtr_RespondToRepeatedNonLethalAttack_Protected_Virtual_Void_Player_Impact_0;

		// Token: 0x04001B0F RID: 6927
		private static readonly IntPtr NativeMethodInfoPtr_RespondToAnnoyingImpact_Protected_Virtual_Void_Player_Impact_0;

		// Token: 0x04001B10 RID: 6928
		private static readonly IntPtr NativeMethodInfoPtr_RespondToAimedAt_Public_Virtual_Void_Player_0;

		// Token: 0x04001B11 RID: 6929
		private static readonly IntPtr NativeMethodInfoPtr_ImpactReceived_Public_Virtual_Void_Impact_0;

		// Token: 0x04001B12 RID: 6930
		private static readonly IntPtr NativeMethodInfoPtr_GunshotHeard_Public_Virtual_Void_NoiseEvent_0;

		// Token: 0x04001B13 RID: 6931
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
