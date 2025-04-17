using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppScheduleOne.Combat;
using Il2CppScheduleOne.Law;
using Il2CppScheduleOne.Noise;
using Il2CppScheduleOne.PlayerScripts;
using UnityEngine;

namespace Il2CppScheduleOne.NPCs.Responses
{
	// Token: 0x020002EE RID: 750
	public class NPCResponses_Civilian : NPCResponses
	{
		// Token: 0x060038B7 RID: 14519 RVA: 0x00128BB4 File Offset: 0x00126DB4
		// Note: this type is marked as 'beforefieldinit'.
		static NPCResponses_Civilian()
		{
			Il2CppClassPointerStore<NPCResponses_Civilian>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.Responses", "NPCResponses_Civilian");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCResponses_Civilian>.NativeClassPtr);
			NPCResponses_Civilian.NativeFieldInfoPtr_CanCallPolice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCResponses_Civilian>.NativeClassPtr, "CanCallPolice");
			NPCResponses_Civilian.NativeFieldInfoPtr_currentThreatResponse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCResponses_Civilian>.NativeClassPtr, "currentThreatResponse");
			NPCResponses_Civilian.NativeFieldInfoPtr_timeSinceLastThreat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCResponses_Civilian>.NativeClassPtr, "timeSinceLastThreat");
			NPCResponses_Civilian.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCResponses_Civilian>.NativeClassPtr, 100669889);
			NPCResponses_Civilian.NativeMethodInfoPtr_GunshotHeard_Public_Virtual_Void_NoiseEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCResponses_Civilian>.NativeClassPtr, 100669890);
			NPCResponses_Civilian.NativeMethodInfoPtr_ExplosionHeard_Public_Virtual_Void_NoiseEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCResponses_Civilian>.NativeClassPtr, 100669891);
			NPCResponses_Civilian.NativeMethodInfoPtr_PlayerFailedPickpocket_Public_Virtual_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCResponses_Civilian>.NativeClassPtr, 100669892);
			NPCResponses_Civilian.NativeMethodInfoPtr_RespondToFirstNonLethalAttack_Protected_Virtual_Void_Player_Impact_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCResponses_Civilian>.NativeClassPtr, 100669893);
			NPCResponses_Civilian.NativeMethodInfoPtr_RespondToAnnoyingImpact_Protected_Virtual_Void_Player_Impact_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCResponses_Civilian>.NativeClassPtr, 100669894);
			NPCResponses_Civilian.NativeMethodInfoPtr_RespondToLethalAttack_Protected_Virtual_Void_Player_Impact_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCResponses_Civilian>.NativeClassPtr, 100669895);
			NPCResponses_Civilian.NativeMethodInfoPtr_RespondToRepeatedNonLethalAttack_Protected_Virtual_Void_Player_Impact_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCResponses_Civilian>.NativeClassPtr, 100669896);
			NPCResponses_Civilian.NativeMethodInfoPtr_RespondToLethalOrRepeatedAttack_Private_Void_Player_Impact_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCResponses_Civilian>.NativeClassPtr, 100669897);
			NPCResponses_Civilian.NativeMethodInfoPtr_RespondToAimedAt_Public_Virtual_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCResponses_Civilian>.NativeClassPtr, 100669898);
			NPCResponses_Civilian.NativeMethodInfoPtr_ExecuteThreatResponse_Private_Void_EAttackResponse_Player_Vector3_Crime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCResponses_Civilian>.NativeClassPtr, 100669899);
			NPCResponses_Civilian.NativeMethodInfoPtr_GetThreatResponse_Private_EAttackResponse_EThreatType_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCResponses_Civilian>.NativeClassPtr, 100669900);
			NPCResponses_Civilian.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCResponses_Civilian>.NativeClassPtr, 100669901);
		}

		// Token: 0x060038B8 RID: 14520 RVA: 0x00128D24 File Offset: 0x00126F24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141475, XrefRangeEnd = 141478, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCResponses_Civilian.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060038B9 RID: 14521 RVA: 0x00128D60 File Offset: 0x00126F60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141478, XrefRangeEnd = 141492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void GunshotHeard(NoiseEvent gunshotSound)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(gunshotSound);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCResponses_Civilian.NativeMethodInfoPtr_GunshotHeard_Public_Virtual_Void_NoiseEvent_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060038BA RID: 14522 RVA: 0x00128DB0 File Offset: 0x00126FB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141492, XrefRangeEnd = 141521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ExplosionHeard(NoiseEvent explosionSound)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(explosionSound);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCResponses_Civilian.NativeMethodInfoPtr_ExplosionHeard_Public_Virtual_Void_NoiseEvent_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060038BB RID: 14523 RVA: 0x00128E00 File Offset: 0x00127000
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141521, XrefRangeEnd = 141530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void PlayerFailedPickpocket(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCResponses_Civilian.NativeMethodInfoPtr_PlayerFailedPickpocket_Public_Virtual_Void_Player_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060038BC RID: 14524 RVA: 0x00128E50 File Offset: 0x00127050
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141530, XrefRangeEnd = 141534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void RespondToFirstNonLethalAttack(Player perpetrator, Impact impact)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(perpetrator);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(impact);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCResponses_Civilian.NativeMethodInfoPtr_RespondToFirstNonLethalAttack_Protected_Virtual_Void_Player_Impact_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060038BD RID: 14525 RVA: 0x00128EB0 File Offset: 0x001270B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141534, XrefRangeEnd = 141538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void RespondToAnnoyingImpact(Player perpetrator, Impact impact)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(perpetrator);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(impact);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCResponses_Civilian.NativeMethodInfoPtr_RespondToAnnoyingImpact_Protected_Virtual_Void_Player_Impact_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060038BE RID: 14526 RVA: 0x00128F10 File Offset: 0x00127110
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141538, XrefRangeEnd = 141540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void RespondToLethalAttack(Player perpetrator, Impact impact)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(perpetrator);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(impact);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCResponses_Civilian.NativeMethodInfoPtr_RespondToLethalAttack_Protected_Virtual_Void_Player_Impact_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060038BF RID: 14527 RVA: 0x00128F70 File Offset: 0x00127170
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141540, XrefRangeEnd = 141542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void RespondToRepeatedNonLethalAttack(Player perpetrator, Impact impact)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(perpetrator);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(impact);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCResponses_Civilian.NativeMethodInfoPtr_RespondToRepeatedNonLethalAttack_Protected_Virtual_Void_Player_Impact_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060038C0 RID: 14528 RVA: 0x00128FD0 File Offset: 0x001271D0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 141547, RefRangeEnd = 141549, XrefRangeStart = 141542, XrefRangeEnd = 141547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RespondToLethalOrRepeatedAttack(Player perpetrator, Impact impact)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(perpetrator);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(impact);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCResponses_Civilian.NativeMethodInfoPtr_RespondToLethalOrRepeatedAttack_Private_Void_Player_Impact_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060038C1 RID: 14529 RVA: 0x00129024 File Offset: 0x00127224
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141549, XrefRangeEnd = 141560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void RespondToAimedAt(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCResponses_Civilian.NativeMethodInfoPtr_RespondToAimedAt_Public_Virtual_Void_Player_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060038C2 RID: 14530 RVA: 0x00129074 File Offset: 0x00127274
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 141588, RefRangeEnd = 141591, XrefRangeStart = 141560, XrefRangeEnd = 141588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ExecuteThreatResponse(NPCResponses_Civilian.EAttackResponse response, Player target, Vector3 threatOrigin, Crime crime = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref response;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(target);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref threatOrigin;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(crime);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCResponses_Civilian.NativeMethodInfoPtr_ExecuteThreatResponse_Private_Void_EAttackResponse_Player_Vector3_Crime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060038C3 RID: 14531 RVA: 0x001290E8 File Offset: 0x001272E8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 141609, RefRangeEnd = 141611, XrefRangeStart = 141591, XrefRangeEnd = 141609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NPCResponses_Civilian.EAttackResponse GetThreatResponse(NPCResponses_Civilian.EThreatType type, Player threatSource)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref type;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(threatSource);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCResponses_Civilian.NativeMethodInfoPtr_GetThreatResponse_Private_EAttackResponse_EThreatType_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060038C4 RID: 14532 RVA: 0x00129144 File Offset: 0x00127344
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141611, XrefRangeEnd = 141612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NPCResponses_Civilian() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCResponses_Civilian>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCResponses_Civilian.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060038C5 RID: 14533 RVA: 0x0001D36C File Offset: 0x0001B56C
		public NPCResponses_Civilian(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001206 RID: 4614
		// (get) Token: 0x060038C6 RID: 14534 RVA: 0x00129180 File Offset: 0x00127380
		// (set) Token: 0x060038C7 RID: 14535 RVA: 0x0001D375 File Offset: 0x0001B575
		public unsafe bool CanCallPolice
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCResponses_Civilian.NativeFieldInfoPtr_CanCallPolice);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCResponses_Civilian.NativeFieldInfoPtr_CanCallPolice)) = value;
			}
		}

		// Token: 0x17001207 RID: 4615
		// (get) Token: 0x060038C8 RID: 14536 RVA: 0x001291A8 File Offset: 0x001273A8
		// (set) Token: 0x060038C9 RID: 14537 RVA: 0x0001D390 File Offset: 0x0001B590
		public unsafe NPCResponses_Civilian.EAttackResponse currentThreatResponse
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCResponses_Civilian.NativeFieldInfoPtr_currentThreatResponse);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCResponses_Civilian.NativeFieldInfoPtr_currentThreatResponse)) = value;
			}
		}

		// Token: 0x17001208 RID: 4616
		// (get) Token: 0x060038CA RID: 14538 RVA: 0x001291D0 File Offset: 0x001273D0
		// (set) Token: 0x060038CB RID: 14539 RVA: 0x0001D3AB File Offset: 0x0001B5AB
		public unsafe float timeSinceLastThreat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCResponses_Civilian.NativeFieldInfoPtr_timeSinceLastThreat);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCResponses_Civilian.NativeFieldInfoPtr_timeSinceLastThreat)) = value;
			}
		}

		// Token: 0x04002568 RID: 9576
		private static readonly IntPtr NativeFieldInfoPtr_CanCallPolice;

		// Token: 0x04002569 RID: 9577
		private static readonly IntPtr NativeFieldInfoPtr_currentThreatResponse;

		// Token: 0x0400256A RID: 9578
		private static readonly IntPtr NativeFieldInfoPtr_timeSinceLastThreat;

		// Token: 0x0400256B RID: 9579
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_Void_0;

		// Token: 0x0400256C RID: 9580
		private static readonly IntPtr NativeMethodInfoPtr_GunshotHeard_Public_Virtual_Void_NoiseEvent_0;

		// Token: 0x0400256D RID: 9581
		private static readonly IntPtr NativeMethodInfoPtr_ExplosionHeard_Public_Virtual_Void_NoiseEvent_0;

		// Token: 0x0400256E RID: 9582
		private static readonly IntPtr NativeMethodInfoPtr_PlayerFailedPickpocket_Public_Virtual_Void_Player_0;

		// Token: 0x0400256F RID: 9583
		private static readonly IntPtr NativeMethodInfoPtr_RespondToFirstNonLethalAttack_Protected_Virtual_Void_Player_Impact_0;

		// Token: 0x04002570 RID: 9584
		private static readonly IntPtr NativeMethodInfoPtr_RespondToAnnoyingImpact_Protected_Virtual_Void_Player_Impact_0;

		// Token: 0x04002571 RID: 9585
		private static readonly IntPtr NativeMethodInfoPtr_RespondToLethalAttack_Protected_Virtual_Void_Player_Impact_0;

		// Token: 0x04002572 RID: 9586
		private static readonly IntPtr NativeMethodInfoPtr_RespondToRepeatedNonLethalAttack_Protected_Virtual_Void_Player_Impact_0;

		// Token: 0x04002573 RID: 9587
		private static readonly IntPtr NativeMethodInfoPtr_RespondToLethalOrRepeatedAttack_Private_Void_Player_Impact_0;

		// Token: 0x04002574 RID: 9588
		private static readonly IntPtr NativeMethodInfoPtr_RespondToAimedAt_Public_Virtual_Void_Player_0;

		// Token: 0x04002575 RID: 9589
		private static readonly IntPtr NativeMethodInfoPtr_ExecuteThreatResponse_Private_Void_EAttackResponse_Player_Vector3_Crime_0;

		// Token: 0x04002576 RID: 9590
		private static readonly IntPtr NativeMethodInfoPtr_GetThreatResponse_Private_EAttackResponse_EThreatType_Player_0;

		// Token: 0x04002577 RID: 9591
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000934 RID: 2356
		[OriginalName("Assembly-CSharp.dll", "", "EAttackResponse")]
		public enum EAttackResponse
		{
			// Token: 0x040086BC RID: 34492
			None,
			// Token: 0x040086BD RID: 34493
			Panic,
			// Token: 0x040086BE RID: 34494
			Flee,
			// Token: 0x040086BF RID: 34495
			CallPolice,
			// Token: 0x040086C0 RID: 34496
			Fight
		}

		// Token: 0x02000935 RID: 2357
		[OriginalName("Assembly-CSharp.dll", "", "EThreatType")]
		public enum EThreatType
		{
			// Token: 0x040086C2 RID: 34498
			None,
			// Token: 0x040086C3 RID: 34499
			AimedAt,
			// Token: 0x040086C4 RID: 34500
			GunshotHeard,
			// Token: 0x040086C5 RID: 34501
			ExplosionHeard
		}
	}
}
