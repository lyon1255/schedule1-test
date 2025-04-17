using System;
using Il2CppFishNet.Object;
using Il2CppFishNet.Object.Synchronizing;
using Il2CppFishNet.Serializing;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Persistence.Datas;
using UnityEngine.Events;

namespace Il2CppScheduleOne.NPCs
{
	// Token: 0x020002D6 RID: 726
	public class NPCHealth : NetworkBehaviour
	{
		// Token: 0x06003436 RID: 13366 RVA: 0x00117B18 File Offset: 0x00115D18
		// Note: this type is marked as 'beforefieldinit'.
		static NPCHealth()
		{
			Il2CppClassPointerStore<NPCHealth>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs", "NPCHealth");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCHealth>.NativeClassPtr);
			NPCHealth.NativeFieldInfoPtr_REVIVE_DAYS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCHealth>.NativeClassPtr, "REVIVE_DAYS");
			NPCHealth.NativeFieldInfoPtr__Health_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCHealth>.NativeClassPtr, "<Health>k__BackingField");
			NPCHealth.NativeFieldInfoPtr__IsDead_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCHealth>.NativeClassPtr, "<IsDead>k__BackingField");
			NPCHealth.NativeFieldInfoPtr__IsKnockedOut_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCHealth>.NativeClassPtr, "<IsKnockedOut>k__BackingField");
			NPCHealth.NativeFieldInfoPtr__DaysPassedSinceDeath_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCHealth>.NativeClassPtr, "<DaysPassedSinceDeath>k__BackingField");
			NPCHealth.NativeFieldInfoPtr_Invincible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCHealth>.NativeClassPtr, "Invincible");
			NPCHealth.NativeFieldInfoPtr_MaxHealth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCHealth>.NativeClassPtr, "MaxHealth");
			NPCHealth.NativeFieldInfoPtr_npc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCHealth>.NativeClassPtr, "npc");
			NPCHealth.NativeFieldInfoPtr_onDie = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCHealth>.NativeClassPtr, "onDie");
			NPCHealth.NativeFieldInfoPtr_onKnockedOut = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCHealth>.NativeClassPtr, "onKnockedOut");
			NPCHealth.NativeFieldInfoPtr_AfflictedWithLethalEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCHealth>.NativeClassPtr, "AfflictedWithLethalEffect");
			NPCHealth.NativeFieldInfoPtr_syncVar____Health_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCHealth>.NativeClassPtr, "syncVar___<Health>k__BackingField");
			NPCHealth.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCHealth>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.NPCs.NPCHealthAssembly-CSharp.dll_Excuted");
			NPCHealth.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCHealth>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.NPCs.NPCHealthAssembly-CSharp.dll_Excuted");
			NPCHealth.NativeMethodInfoPtr_get_Health_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCHealth>.NativeClassPtr, 100669185);
			NPCHealth.NativeMethodInfoPtr_set_Health_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCHealth>.NativeClassPtr, 100669186);
			NPCHealth.NativeMethodInfoPtr_get_IsDead_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCHealth>.NativeClassPtr, 100669187);
			NPCHealth.NativeMethodInfoPtr_set_IsDead_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCHealth>.NativeClassPtr, 100669188);
			NPCHealth.NativeMethodInfoPtr_get_IsKnockedOut_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCHealth>.NativeClassPtr, 100669189);
			NPCHealth.NativeMethodInfoPtr_set_IsKnockedOut_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCHealth>.NativeClassPtr, 100669190);
			NPCHealth.NativeMethodInfoPtr_get_DaysPassedSinceDeath_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCHealth>.NativeClassPtr, 100669191);
			NPCHealth.NativeMethodInfoPtr_set_DaysPassedSinceDeath_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCHealth>.NativeClassPtr, 100669192);
			NPCHealth.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCHealth>.NativeClassPtr, 100669193);
			NPCHealth.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCHealth>.NativeClassPtr, 100669194);
			NPCHealth.NativeMethodInfoPtr_OnStartServer_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCHealth>.NativeClassPtr, 100669195);
			NPCHealth.NativeMethodInfoPtr_Load_Public_Void_NPCHealthData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCHealth>.NativeClassPtr, 100669196);
			NPCHealth.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCHealth>.NativeClassPtr, 100669197);
			NPCHealth.NativeMethodInfoPtr_SetAfflictedWithLethalEffect_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCHealth>.NativeClassPtr, 100669198);
			NPCHealth.NativeMethodInfoPtr_SleepStart_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCHealth>.NativeClassPtr, 100669199);
			NPCHealth.NativeMethodInfoPtr_TakeDamage_Public_Void_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCHealth>.NativeClassPtr, 100669200);
			NPCHealth.NativeMethodInfoPtr_Die_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCHealth>.NativeClassPtr, 100669201);
			NPCHealth.NativeMethodInfoPtr_KnockOut_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCHealth>.NativeClassPtr, 100669202);
			NPCHealth.NativeMethodInfoPtr_Revive_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCHealth>.NativeClassPtr, 100669203);
			NPCHealth.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCHealth>.NativeClassPtr, 100669204);
			NPCHealth.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCHealth>.NativeClassPtr, 100669205);
			NPCHealth.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCHealth>.NativeClassPtr, 100669206);
			NPCHealth.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCHealth>.NativeClassPtr, 100669207);
			NPCHealth.NativeMethodInfoPtr_sync___get_value__Health_k__BackingField_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCHealth>.NativeClassPtr, 100669208);
			NPCHealth.NativeMethodInfoPtr_sync___set_value__Health_k__BackingField_Public_set_Void_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCHealth>.NativeClassPtr, 100669209);
			NPCHealth.NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_NPCs_NPCHealth_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCHealth>.NativeClassPtr, 100669210);
			NPCHealth.NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCHealth>.NativeClassPtr, 100669211);
		}

		// Token: 0x170010EA RID: 4330
		// (get) Token: 0x06003437 RID: 13367 RVA: 0x00117E7C File Offset: 0x0011607C
		// (set) Token: 0x06003438 RID: 13368 RVA: 0x00117EB8 File Offset: 0x001160B8
		public unsafe float Health
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCHealth.NativeMethodInfoPtr_get_Health_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 134916, RefRangeEnd = 134922, XrefRangeStart = 134909, XrefRangeEnd = 134916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCHealth.NativeMethodInfoPtr_set_Health_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170010EB RID: 4331
		// (get) Token: 0x06003439 RID: 13369 RVA: 0x00117EF8 File Offset: 0x001160F8
		// (set) Token: 0x0600343A RID: 13370 RVA: 0x00117F34 File Offset: 0x00116134
		public unsafe bool IsDead
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCHealth.NativeMethodInfoPtr_get_IsDead_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCHealth.NativeMethodInfoPtr_set_IsDead_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170010EC RID: 4332
		// (get) Token: 0x0600343B RID: 13371 RVA: 0x00117F74 File Offset: 0x00116174
		// (set) Token: 0x0600343C RID: 13372 RVA: 0x00117FB0 File Offset: 0x001161B0
		public unsafe bool IsKnockedOut
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCHealth.NativeMethodInfoPtr_get_IsKnockedOut_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCHealth.NativeMethodInfoPtr_set_IsKnockedOut_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170010ED RID: 4333
		// (get) Token: 0x0600343D RID: 13373 RVA: 0x00117FF0 File Offset: 0x001161F0
		// (set) Token: 0x0600343E RID: 13374 RVA: 0x0011802C File Offset: 0x0011622C
		public unsafe int DaysPassedSinceDeath
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCHealth.NativeMethodInfoPtr_get_DaysPassedSinceDeath_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCHealth.NativeMethodInfoPtr_set_DaysPassedSinceDeath_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600343F RID: 13375 RVA: 0x0011806C File Offset: 0x0011626C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134922, XrefRangeEnd = 134923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCHealth.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003440 RID: 13376 RVA: 0x001180A8 File Offset: 0x001162A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134923, XrefRangeEnd = 134941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCHealth.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003441 RID: 13377 RVA: 0x001180DC File Offset: 0x001162DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134941, XrefRangeEnd = 134943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnStartServer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCHealth.NativeMethodInfoPtr_OnStartServer_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003442 RID: 13378 RVA: 0x00118118 File Offset: 0x00116318
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 134944, RefRangeEnd = 134945, XrefRangeStart = 134943, XrefRangeEnd = 134944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Load(NPCHealthData healthData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(healthData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCHealth.NativeMethodInfoPtr_Load_Public_Void_NPCHealthData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003443 RID: 13379 RVA: 0x0011815C File Offset: 0x0011635C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134945, XrefRangeEnd = 134947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCHealth.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003444 RID: 13380 RVA: 0x00118190 File Offset: 0x00116390
		[CallerCount(0)]
		public unsafe void SetAfflictedWithLethalEffect(bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCHealth.NativeMethodInfoPtr_SetAfflictedWithLethalEffect_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003445 RID: 13381 RVA: 0x001181D0 File Offset: 0x001163D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134947, XrefRangeEnd = 134965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SleepStart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCHealth.NativeMethodInfoPtr_SleepStart_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003446 RID: 13382 RVA: 0x00118204 File Offset: 0x00116404
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 134980, RefRangeEnd = 134982, XrefRangeStart = 134965, XrefRangeEnd = 134980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TakeDamage(float damage, bool isLethal = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref damage;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isLethal;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCHealth.NativeMethodInfoPtr_TakeDamage_Public_Void_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003447 RID: 13383 RVA: 0x00118250 File Offset: 0x00116450
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134982, XrefRangeEnd = 134994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Die()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCHealth.NativeMethodInfoPtr_Die_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003448 RID: 13384 RVA: 0x0011828C File Offset: 0x0011648C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134994, XrefRangeEnd = 135006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void KnockOut()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCHealth.NativeMethodInfoPtr_KnockOut_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003449 RID: 13385 RVA: 0x001182C8 File Offset: 0x001164C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135006, XrefRangeEnd = 135020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Revive()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCHealth.NativeMethodInfoPtr_Revive_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600344A RID: 13386 RVA: 0x00118304 File Offset: 0x00116504
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135020, XrefRangeEnd = 135021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NPCHealth() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCHealth>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCHealth.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600344B RID: 13387 RVA: 0x00118340 File Offset: 0x00116540
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135021, XrefRangeEnd = 135037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCHealth.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600344C RID: 13388 RVA: 0x0011837C File Offset: 0x0011657C
		[CallerCount(0)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCHealth.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600344D RID: 13389 RVA: 0x001183B8 File Offset: 0x001165B8
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCHealth.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170010EE RID: 4334
		// (get) Token: 0x0600344E RID: 13390 RVA: 0x001183F4 File Offset: 0x001165F4
		// (set) Token: 0x0600344F RID: 13391 RVA: 0x00118430 File Offset: 0x00116630
		public unsafe float SyncAccessor_<Health>k__BackingField
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCHealth.NativeMethodInfoPtr_sync___get_value__Health_k__BackingField_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135037, XrefRangeEnd = 135045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCHealth.NativeMethodInfoPtr_sync___set_value__Health_k__BackingField_Public_set_Void_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003450 RID: 13392 RVA: 0x0011847C File Offset: 0x0011667C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135045, XrefRangeEnd = 135046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ReadSyncVar___ScheduleOne_NPCs_NPCHealth(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref UInt321;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref Boolean2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCHealth.NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_NPCs_NPCHealth_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003451 RID: 13393 RVA: 0x001184F0 File Offset: 0x001166F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 135083, RefRangeEnd = 135084, XrefRangeStart = 135046, XrefRangeEnd = 135083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Method_Protected_Virtual_New_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCHealth.NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003452 RID: 13394 RVA: 0x0001B96F File Offset: 0x00019B6F
		public NPCHealth(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170010DC RID: 4316
		// (get) Token: 0x06003453 RID: 13395 RVA: 0x0011852C File Offset: 0x0011672C
		// (set) Token: 0x06003454 RID: 13396 RVA: 0x0001B978 File Offset: 0x00019B78
		public unsafe static int REVIVE_DAYS
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(NPCHealth.NativeFieldInfoPtr_REVIVE_DAYS, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NPCHealth.NativeFieldInfoPtr_REVIVE_DAYS, (void*)(&value));
			}
		}

		// Token: 0x170010DD RID: 4317
		// (get) Token: 0x06003455 RID: 13397 RVA: 0x00118548 File Offset: 0x00116748
		// (set) Token: 0x06003456 RID: 13398 RVA: 0x0001B986 File Offset: 0x00019B86
		public unsafe float _Health_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCHealth.NativeFieldInfoPtr__Health_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCHealth.NativeFieldInfoPtr__Health_k__BackingField)) = value;
			}
		}

		// Token: 0x170010DE RID: 4318
		// (get) Token: 0x06003457 RID: 13399 RVA: 0x00118570 File Offset: 0x00116770
		// (set) Token: 0x06003458 RID: 13400 RVA: 0x0001B9A1 File Offset: 0x00019BA1
		public unsafe bool _IsDead_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCHealth.NativeFieldInfoPtr__IsDead_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCHealth.NativeFieldInfoPtr__IsDead_k__BackingField)) = value;
			}
		}

		// Token: 0x170010DF RID: 4319
		// (get) Token: 0x06003459 RID: 13401 RVA: 0x00118598 File Offset: 0x00116798
		// (set) Token: 0x0600345A RID: 13402 RVA: 0x0001B9BC File Offset: 0x00019BBC
		public unsafe bool _IsKnockedOut_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCHealth.NativeFieldInfoPtr__IsKnockedOut_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCHealth.NativeFieldInfoPtr__IsKnockedOut_k__BackingField)) = value;
			}
		}

		// Token: 0x170010E0 RID: 4320
		// (get) Token: 0x0600345B RID: 13403 RVA: 0x001185C0 File Offset: 0x001167C0
		// (set) Token: 0x0600345C RID: 13404 RVA: 0x0001B9D7 File Offset: 0x00019BD7
		public unsafe int _DaysPassedSinceDeath_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCHealth.NativeFieldInfoPtr__DaysPassedSinceDeath_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCHealth.NativeFieldInfoPtr__DaysPassedSinceDeath_k__BackingField)) = value;
			}
		}

		// Token: 0x170010E1 RID: 4321
		// (get) Token: 0x0600345D RID: 13405 RVA: 0x001185E8 File Offset: 0x001167E8
		// (set) Token: 0x0600345E RID: 13406 RVA: 0x0001B9F2 File Offset: 0x00019BF2
		public unsafe bool Invincible
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCHealth.NativeFieldInfoPtr_Invincible);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCHealth.NativeFieldInfoPtr_Invincible)) = value;
			}
		}

		// Token: 0x170010E2 RID: 4322
		// (get) Token: 0x0600345F RID: 13407 RVA: 0x00118610 File Offset: 0x00116810
		// (set) Token: 0x06003460 RID: 13408 RVA: 0x0001BA0D File Offset: 0x00019C0D
		public unsafe float MaxHealth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCHealth.NativeFieldInfoPtr_MaxHealth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCHealth.NativeFieldInfoPtr_MaxHealth)) = value;
			}
		}

		// Token: 0x170010E3 RID: 4323
		// (get) Token: 0x06003461 RID: 13409 RVA: 0x00118638 File Offset: 0x00116838
		// (set) Token: 0x06003462 RID: 13410 RVA: 0x0001BA28 File Offset: 0x00019C28
		public unsafe NPC npc
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCHealth.NativeFieldInfoPtr_npc);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPC>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCHealth.NativeFieldInfoPtr_npc), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010E4 RID: 4324
		// (get) Token: 0x06003463 RID: 13411 RVA: 0x00118668 File Offset: 0x00116868
		// (set) Token: 0x06003464 RID: 13412 RVA: 0x0001BA47 File Offset: 0x00019C47
		public unsafe UnityEvent onDie
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCHealth.NativeFieldInfoPtr_onDie);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCHealth.NativeFieldInfoPtr_onDie), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010E5 RID: 4325
		// (get) Token: 0x06003465 RID: 13413 RVA: 0x00118698 File Offset: 0x00116898
		// (set) Token: 0x06003466 RID: 13414 RVA: 0x0001BA66 File Offset: 0x00019C66
		public unsafe UnityEvent onKnockedOut
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCHealth.NativeFieldInfoPtr_onKnockedOut);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCHealth.NativeFieldInfoPtr_onKnockedOut), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010E6 RID: 4326
		// (get) Token: 0x06003467 RID: 13415 RVA: 0x001186C8 File Offset: 0x001168C8
		// (set) Token: 0x06003468 RID: 13416 RVA: 0x0001BA85 File Offset: 0x00019C85
		public unsafe bool AfflictedWithLethalEffect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCHealth.NativeFieldInfoPtr_AfflictedWithLethalEffect);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCHealth.NativeFieldInfoPtr_AfflictedWithLethalEffect)) = value;
			}
		}

		// Token: 0x170010E7 RID: 4327
		// (get) Token: 0x06003469 RID: 13417 RVA: 0x001186F0 File Offset: 0x001168F0
		// (set) Token: 0x0600346A RID: 13418 RVA: 0x0001BAA0 File Offset: 0x00019CA0
		public unsafe SyncVar<float> syncVar____Health_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCHealth.NativeFieldInfoPtr_syncVar____Health_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SyncVar<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCHealth.NativeFieldInfoPtr_syncVar____Health_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010E8 RID: 4328
		// (get) Token: 0x0600346B RID: 13419 RVA: 0x00118720 File Offset: 0x00116920
		// (set) Token: 0x0600346C RID: 13420 RVA: 0x0001BABF File Offset: 0x00019CBF
		public unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCHealth.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCHealth.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x170010E9 RID: 4329
		// (get) Token: 0x0600346D RID: 13421 RVA: 0x00118748 File Offset: 0x00116948
		// (set) Token: 0x0600346E RID: 13422 RVA: 0x0001BADA File Offset: 0x00019CDA
		public unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCHealth.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCHealth.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04002207 RID: 8711
		private static readonly IntPtr NativeFieldInfoPtr_REVIVE_DAYS;

		// Token: 0x04002208 RID: 8712
		private static readonly IntPtr NativeFieldInfoPtr__Health_k__BackingField;

		// Token: 0x04002209 RID: 8713
		private static readonly IntPtr NativeFieldInfoPtr__IsDead_k__BackingField;

		// Token: 0x0400220A RID: 8714
		private static readonly IntPtr NativeFieldInfoPtr__IsKnockedOut_k__BackingField;

		// Token: 0x0400220B RID: 8715
		private static readonly IntPtr NativeFieldInfoPtr__DaysPassedSinceDeath_k__BackingField;

		// Token: 0x0400220C RID: 8716
		private static readonly IntPtr NativeFieldInfoPtr_Invincible;

		// Token: 0x0400220D RID: 8717
		private static readonly IntPtr NativeFieldInfoPtr_MaxHealth;

		// Token: 0x0400220E RID: 8718
		private static readonly IntPtr NativeFieldInfoPtr_npc;

		// Token: 0x0400220F RID: 8719
		private static readonly IntPtr NativeFieldInfoPtr_onDie;

		// Token: 0x04002210 RID: 8720
		private static readonly IntPtr NativeFieldInfoPtr_onKnockedOut;

		// Token: 0x04002211 RID: 8721
		private static readonly IntPtr NativeFieldInfoPtr_AfflictedWithLethalEffect;

		// Token: 0x04002212 RID: 8722
		private static readonly IntPtr NativeFieldInfoPtr_syncVar____Health_k__BackingField;

		// Token: 0x04002213 RID: 8723
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04002214 RID: 8724
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04002215 RID: 8725
		private static readonly IntPtr NativeMethodInfoPtr_get_Health_Public_get_Single_0;

		// Token: 0x04002216 RID: 8726
		private static readonly IntPtr NativeMethodInfoPtr_set_Health_Private_set_Void_Single_0;

		// Token: 0x04002217 RID: 8727
		private static readonly IntPtr NativeMethodInfoPtr_get_IsDead_Public_get_Boolean_0;

		// Token: 0x04002218 RID: 8728
		private static readonly IntPtr NativeMethodInfoPtr_set_IsDead_Private_set_Void_Boolean_0;

		// Token: 0x04002219 RID: 8729
		private static readonly IntPtr NativeMethodInfoPtr_get_IsKnockedOut_Public_get_Boolean_0;

		// Token: 0x0400221A RID: 8730
		private static readonly IntPtr NativeMethodInfoPtr_set_IsKnockedOut_Private_set_Void_Boolean_0;

		// Token: 0x0400221B RID: 8731
		private static readonly IntPtr NativeMethodInfoPtr_get_DaysPassedSinceDeath_Public_get_Int32_0;

		// Token: 0x0400221C RID: 8732
		private static readonly IntPtr NativeMethodInfoPtr_set_DaysPassedSinceDeath_Private_set_Void_Int32_0;

		// Token: 0x0400221D RID: 8733
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x0400221E RID: 8734
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x0400221F RID: 8735
		private static readonly IntPtr NativeMethodInfoPtr_OnStartServer_Public_Virtual_Void_0;

		// Token: 0x04002220 RID: 8736
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Void_NPCHealthData_0;

		// Token: 0x04002221 RID: 8737
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04002222 RID: 8738
		private static readonly IntPtr NativeMethodInfoPtr_SetAfflictedWithLethalEffect_Public_Void_Boolean_0;

		// Token: 0x04002223 RID: 8739
		private static readonly IntPtr NativeMethodInfoPtr_SleepStart_Public_Void_0;

		// Token: 0x04002224 RID: 8740
		private static readonly IntPtr NativeMethodInfoPtr_TakeDamage_Public_Void_Single_Boolean_0;

		// Token: 0x04002225 RID: 8741
		private static readonly IntPtr NativeMethodInfoPtr_Die_Public_Virtual_New_Void_0;

		// Token: 0x04002226 RID: 8742
		private static readonly IntPtr NativeMethodInfoPtr_KnockOut_Public_Virtual_New_Void_0;

		// Token: 0x04002227 RID: 8743
		private static readonly IntPtr NativeMethodInfoPtr_Revive_Public_Virtual_New_Void_0;

		// Token: 0x04002228 RID: 8744
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002229 RID: 8745
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x0400222A RID: 8746
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x0400222B RID: 8747
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x0400222C RID: 8748
		private static readonly IntPtr NativeMethodInfoPtr_sync___get_value__Health_k__BackingField_Public_get_Single_0;

		// Token: 0x0400222D RID: 8749
		private static readonly IntPtr NativeMethodInfoPtr_sync___set_value__Health_k__BackingField_Public_set_Void_Single_Boolean_0;

		// Token: 0x0400222E RID: 8750
		private static readonly IntPtr NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_NPCs_NPCHealth_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0;

		// Token: 0x0400222F RID: 8751
		private static readonly IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0;
	}
}
