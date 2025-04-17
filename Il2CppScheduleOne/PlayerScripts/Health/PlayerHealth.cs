using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Object;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.PlayerScripts.Health
{
	// Token: 0x020003ED RID: 1005
	public class PlayerHealth : NetworkBehaviour
	{
		// Token: 0x060052C3 RID: 21187 RVA: 0x00186D6C File Offset: 0x00184F6C
		// Note: this type is marked as 'beforefieldinit'.
		static PlayerHealth()
		{
			Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.PlayerScripts.Health", "PlayerHealth");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr);
			PlayerHealth.NativeFieldInfoPtr_MAX_HEALTH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, "MAX_HEALTH");
			PlayerHealth.NativeFieldInfoPtr_HEALTH_RECOVERY_PER_MINUTE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, "HEALTH_RECOVERY_PER_MINUTE");
			PlayerHealth.NativeFieldInfoPtr__IsAlive_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, "<IsAlive>k__BackingField");
			PlayerHealth.NativeFieldInfoPtr__CurrentHealth_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, "<CurrentHealth>k__BackingField");
			PlayerHealth.NativeFieldInfoPtr__TimeSinceLastDamage_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, "<TimeSinceLastDamage>k__BackingField");
			PlayerHealth.NativeFieldInfoPtr_Player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, "Player");
			PlayerHealth.NativeFieldInfoPtr_BloodParticles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, "BloodParticles");
			PlayerHealth.NativeFieldInfoPtr_onHealthChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, "onHealthChanged");
			PlayerHealth.NativeFieldInfoPtr_onDie = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, "onDie");
			PlayerHealth.NativeFieldInfoPtr_onRevive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, "onRevive");
			PlayerHealth.NativeFieldInfoPtr_AfflictedWithLethalEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, "AfflictedWithLethalEffect");
			PlayerHealth.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.PlayerScripts.Health.PlayerHealthAssembly-CSharp.dll_Excuted");
			PlayerHealth.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.PlayerScripts.Health.PlayerHealthAssembly-CSharp.dll_Excuted");
			PlayerHealth.NativeMethodInfoPtr_get_IsAlive_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, 100673638);
			PlayerHealth.NativeMethodInfoPtr_set_IsAlive_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, 100673639);
			PlayerHealth.NativeMethodInfoPtr_get_CurrentHealth_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, 100673640);
			PlayerHealth.NativeMethodInfoPtr_set_CurrentHealth_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, 100673641);
			PlayerHealth.NativeMethodInfoPtr_get_TimeSinceLastDamage_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, 100673642);
			PlayerHealth.NativeMethodInfoPtr_set_TimeSinceLastDamage_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, 100673643);
			PlayerHealth.NativeMethodInfoPtr_get_CanTakeDamage_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, 100673644);
			PlayerHealth.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, 100673645);
			PlayerHealth.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, 100673646);
			PlayerHealth.NativeMethodInfoPtr_TakeDamage_Public_Void_Single_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, 100673647);
			PlayerHealth.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, 100673648);
			PlayerHealth.NativeMethodInfoPtr_MinPass_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, 100673649);
			PlayerHealth.NativeMethodInfoPtr_SetAfflictedWithLethalEffect_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, 100673650);
			PlayerHealth.NativeMethodInfoPtr_RecoverHealth_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, 100673651);
			PlayerHealth.NativeMethodInfoPtr_SetHealth_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, 100673652);
			PlayerHealth.NativeMethodInfoPtr_SendDie_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, 100673653);
			PlayerHealth.NativeMethodInfoPtr_Die_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, 100673654);
			PlayerHealth.NativeMethodInfoPtr_SendRevive_Public_Void_Vector3_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, 100673655);
			PlayerHealth.NativeMethodInfoPtr_Revive_Public_Void_Vector3_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, 100673656);
			PlayerHealth.NativeMethodInfoPtr_PlayBloodMist_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, 100673657);
			PlayerHealth.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, 100673658);
			PlayerHealth.NativeMethodInfoPtr__Awake_b__22_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, 100673659);
			PlayerHealth.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, 100673660);
			PlayerHealth.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, 100673661);
			PlayerHealth.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, 100673662);
			PlayerHealth.NativeMethodInfoPtr_RpcWriter___Observers_TakeDamage_3505310624_Private_Void_Single_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, 100673663);
			PlayerHealth.NativeMethodInfoPtr_RpcLogic___TakeDamage_3505310624_Public_Void_Single_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, 100673664);
			PlayerHealth.NativeMethodInfoPtr_RpcReader___Observers_TakeDamage_3505310624_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, 100673665);
			PlayerHealth.NativeMethodInfoPtr_RpcWriter___Server_SendDie_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, 100673666);
			PlayerHealth.NativeMethodInfoPtr_RpcLogic___SendDie_2166136261_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, 100673667);
			PlayerHealth.NativeMethodInfoPtr_RpcReader___Server_SendDie_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, 100673668);
			PlayerHealth.NativeMethodInfoPtr_RpcWriter___Observers_Die_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, 100673669);
			PlayerHealth.NativeMethodInfoPtr_RpcLogic___Die_2166136261_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, 100673670);
			PlayerHealth.NativeMethodInfoPtr_RpcReader___Observers_Die_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, 100673671);
			PlayerHealth.NativeMethodInfoPtr_RpcWriter___Server_SendRevive_3848837105_Private_Void_Vector3_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, 100673672);
			PlayerHealth.NativeMethodInfoPtr_RpcLogic___SendRevive_3848837105_Public_Void_Vector3_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, 100673673);
			PlayerHealth.NativeMethodInfoPtr_RpcReader___Server_SendRevive_3848837105_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, 100673674);
			PlayerHealth.NativeMethodInfoPtr_RpcWriter___Observers_Revive_3848837105_Private_Void_Vector3_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, 100673675);
			PlayerHealth.NativeMethodInfoPtr_RpcLogic___Revive_3848837105_Public_Void_Vector3_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, 100673676);
			PlayerHealth.NativeMethodInfoPtr_RpcReader___Observers_Revive_3848837105_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, 100673677);
			PlayerHealth.NativeMethodInfoPtr_RpcWriter___Observers_PlayBloodMist_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, 100673678);
			PlayerHealth.NativeMethodInfoPtr_RpcLogic___PlayBloodMist_2166136261_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, 100673679);
			PlayerHealth.NativeMethodInfoPtr_RpcReader___Observers_PlayBloodMist_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, 100673680);
			PlayerHealth.NativeMethodInfoPtr_Method_Private_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, 100673681);
		}

		// Token: 0x170018FF RID: 6399
		// (get) Token: 0x060052C4 RID: 21188 RVA: 0x00187210 File Offset: 0x00185410
		// (set) Token: 0x060052C5 RID: 21189 RVA: 0x0018724C File Offset: 0x0018544C
		public unsafe bool IsAlive
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHealth.NativeMethodInfoPtr_get_IsAlive_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHealth.NativeMethodInfoPtr_set_IsAlive_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001900 RID: 6400
		// (get) Token: 0x060052C6 RID: 21190 RVA: 0x0018728C File Offset: 0x0018548C
		// (set) Token: 0x060052C7 RID: 21191 RVA: 0x001872C8 File Offset: 0x001854C8
		public unsafe float CurrentHealth
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 86619, RefRangeEnd = 86621, XrefRangeStart = 86619, XrefRangeEnd = 86621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHealth.NativeMethodInfoPtr_get_CurrentHealth_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHealth.NativeMethodInfoPtr_set_CurrentHealth_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001901 RID: 6401
		// (get) Token: 0x060052C8 RID: 21192 RVA: 0x00187308 File Offset: 0x00185508
		// (set) Token: 0x060052C9 RID: 21193 RVA: 0x00187344 File Offset: 0x00185544
		public unsafe float TimeSinceLastDamage
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHealth.NativeMethodInfoPtr_get_TimeSinceLastDamage_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHealth.NativeMethodInfoPtr_set_TimeSinceLastDamage_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001902 RID: 6402
		// (get) Token: 0x060052CA RID: 21194 RVA: 0x00187384 File Offset: 0x00185584
		public unsafe bool CanTakeDamage
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 177995, RefRangeEnd = 177996, XrefRangeStart = 177989, XrefRangeEnd = 177995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHealth.NativeMethodInfoPtr_get_CanTakeDamage_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060052CB RID: 21195 RVA: 0x001873C0 File Offset: 0x001855C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 177996, XrefRangeEnd = 178008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerHealth.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060052CC RID: 21196 RVA: 0x001873FC File Offset: 0x001855FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178008, XrefRangeEnd = 178040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHealth.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060052CD RID: 21197 RVA: 0x00187430 File Offset: 0x00185630
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 178052, RefRangeEnd = 178056, XrefRangeStart = 178040, XrefRangeEnd = 178052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TakeDamage(float damage, bool flinch = true, bool playBloodMist = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref damage;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flinch;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref playBloodMist;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHealth.NativeMethodInfoPtr_TakeDamage_Public_Void_Single_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060052CE RID: 21198 RVA: 0x0018748C File Offset: 0x0018568C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178056, XrefRangeEnd = 178070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHealth.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060052CF RID: 21199 RVA: 0x001874C0 File Offset: 0x001856C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178070, XrefRangeEnd = 178080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHealth.NativeMethodInfoPtr_MinPass_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060052D0 RID: 21200 RVA: 0x001874F4 File Offset: 0x001856F4
		[CallerCount(0)]
		public unsafe void SetAfflictedWithLethalEffect(bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHealth.NativeMethodInfoPtr_SetAfflictedWithLethalEffect_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060052D1 RID: 21201 RVA: 0x00187534 File Offset: 0x00185734
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 178090, RefRangeEnd = 178092, XrefRangeStart = 178080, XrefRangeEnd = 178090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RecoverHealth(float recovery)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref recovery;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHealth.NativeMethodInfoPtr_RecoverHealth_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060052D2 RID: 21202 RVA: 0x00187574 File Offset: 0x00185774
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 178097, RefRangeEnd = 178099, XrefRangeStart = 178092, XrefRangeEnd = 178097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetHealth(float health)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref health;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHealth.NativeMethodInfoPtr_SetHealth_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060052D3 RID: 21203 RVA: 0x001875B4 File Offset: 0x001857B4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 178120, RefRangeEnd = 178123, XrefRangeStart = 178099, XrefRangeEnd = 178120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendDie()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHealth.NativeMethodInfoPtr_SendDie_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060052D4 RID: 21204 RVA: 0x001875E8 File Offset: 0x001857E8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 178144, RefRangeEnd = 178146, XrefRangeStart = 178123, XrefRangeEnd = 178144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Die()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHealth.NativeMethodInfoPtr_Die_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060052D5 RID: 21205 RVA: 0x0018761C File Offset: 0x0018581C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 178149, RefRangeEnd = 178150, XrefRangeStart = 178146, XrefRangeEnd = 178149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendRevive(Vector3 position, Quaternion rotation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref position;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHealth.NativeMethodInfoPtr_SendRevive_Public_Void_Vector3_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060052D6 RID: 21206 RVA: 0x00187668 File Offset: 0x00185868
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178150, XrefRangeEnd = 178152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Revive(Vector3 position, Quaternion rotation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref position;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHealth.NativeMethodInfoPtr_Revive_Public_Void_Vector3_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060052D7 RID: 21207 RVA: 0x001876B4 File Offset: 0x001858B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178152, XrefRangeEnd = 178170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayBloodMist()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHealth.NativeMethodInfoPtr_PlayBloodMist_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060052D8 RID: 21208 RVA: 0x001876E8 File Offset: 0x001858E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178170, XrefRangeEnd = 178171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayerHealth() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHealth.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060052D9 RID: 21209 RVA: 0x00187724 File Offset: 0x00185924
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178171, XrefRangeEnd = 178175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Awake_b__22_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHealth.NativeMethodInfoPtr__Awake_b__22_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060052DA RID: 21210 RVA: 0x00187758 File Offset: 0x00185958
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178175, XrefRangeEnd = 178213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerHealth.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060052DB RID: 21211 RVA: 0x00187794 File Offset: 0x00185994
		[CallerCount(0)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerHealth.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060052DC RID: 21212 RVA: 0x001877D0 File Offset: 0x001859D0
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerHealth.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060052DD RID: 21213 RVA: 0x0018780C File Offset: 0x00185A0C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 178052, RefRangeEnd = 178056, XrefRangeStart = 178052, XrefRangeEnd = 178056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_TakeDamage_3505310624(float damage, bool flinch = true, bool playBloodMist = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref damage;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flinch;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref playBloodMist;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHealth.NativeMethodInfoPtr_RpcWriter___Observers_TakeDamage_3505310624_Private_Void_Single_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060052DE RID: 21214 RVA: 0x00187868 File Offset: 0x00185A68
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 178266, RefRangeEnd = 178267, XrefRangeStart = 178213, XrefRangeEnd = 178266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___TakeDamage_3505310624(float damage, bool flinch = true, bool playBloodMist = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref damage;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flinch;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref playBloodMist;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHealth.NativeMethodInfoPtr_RpcLogic___TakeDamage_3505310624_Public_Void_Single_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060052DF RID: 21215 RVA: 0x001878C4 File Offset: 0x00185AC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178267, XrefRangeEnd = 178270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_TakeDamage_3505310624(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHealth.NativeMethodInfoPtr_RpcReader___Observers_TakeDamage_3505310624_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060052E0 RID: 21216 RVA: 0x00187914 File Offset: 0x00185B14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178270, XrefRangeEnd = 178288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendDie_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHealth.NativeMethodInfoPtr_RpcWriter___Server_SendDie_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060052E1 RID: 21217 RVA: 0x00187948 File Offset: 0x00185B48
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 178144, RefRangeEnd = 178146, XrefRangeStart = 178144, XrefRangeEnd = 178146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendDie_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHealth.NativeMethodInfoPtr_RpcLogic___SendDie_2166136261_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060052E2 RID: 21218 RVA: 0x0018797C File Offset: 0x00185B7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178288, XrefRangeEnd = 178291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendDie_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHealth.NativeMethodInfoPtr_RpcReader___Server_SendDie_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060052E3 RID: 21219 RVA: 0x001879E0 File Offset: 0x00185BE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178291, XrefRangeEnd = 178309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_Die_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHealth.NativeMethodInfoPtr_RpcWriter___Observers_Die_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060052E4 RID: 21220 RVA: 0x00187A14 File Offset: 0x00185C14
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 178329, RefRangeEnd = 178332, XrefRangeStart = 178309, XrefRangeEnd = 178329, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___Die_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHealth.NativeMethodInfoPtr_RpcLogic___Die_2166136261_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060052E5 RID: 21221 RVA: 0x00187A48 File Offset: 0x00185C48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178332, XrefRangeEnd = 178335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_Die_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHealth.NativeMethodInfoPtr_RpcReader___Observers_Die_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060052E6 RID: 21222 RVA: 0x00187A98 File Offset: 0x00185C98
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 178368, RefRangeEnd = 178369, XrefRangeStart = 178335, XrefRangeEnd = 178368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendRevive_3848837105(Vector3 position, Quaternion rotation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref position;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHealth.NativeMethodInfoPtr_RpcWriter___Server_SendRevive_3848837105_Private_Void_Vector3_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060052E7 RID: 21223 RVA: 0x00187AE4 File Offset: 0x00185CE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendRevive_3848837105(Vector3 position, Quaternion rotation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref position;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHealth.NativeMethodInfoPtr_RpcLogic___SendRevive_3848837105_Public_Void_Vector3_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060052E8 RID: 21224 RVA: 0x00187B30 File Offset: 0x00185D30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178369, XrefRangeEnd = 178378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendRevive_3848837105(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHealth.NativeMethodInfoPtr_RpcReader___Server_SendRevive_3848837105_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060052E9 RID: 21225 RVA: 0x00187B94 File Offset: 0x00185D94
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 178402, RefRangeEnd = 178406, XrefRangeStart = 178378, XrefRangeEnd = 178402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_Revive_3848837105(Vector3 position, Quaternion rotation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref position;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHealth.NativeMethodInfoPtr_RpcWriter___Observers_Revive_3848837105_Private_Void_Vector3_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060052EA RID: 21226 RVA: 0x00187BE0 File Offset: 0x00185DE0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 178436, RefRangeEnd = 178441, XrefRangeStart = 178406, XrefRangeEnd = 178436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___Revive_3848837105(Vector3 position, Quaternion rotation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref position;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHealth.NativeMethodInfoPtr_RpcLogic___Revive_3848837105_Public_Void_Vector3_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060052EB RID: 21227 RVA: 0x00187C2C File Offset: 0x00185E2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178441, XrefRangeEnd = 178449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_Revive_3848837105(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHealth.NativeMethodInfoPtr_RpcReader___Observers_Revive_3848837105_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060052EC RID: 21228 RVA: 0x00187C7C File Offset: 0x00185E7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_PlayBloodMist_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHealth.NativeMethodInfoPtr_RpcWriter___Observers_PlayBloodMist_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060052ED RID: 21229 RVA: 0x00187CB0 File Offset: 0x00185EB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178449, XrefRangeEnd = 178456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___PlayBloodMist_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHealth.NativeMethodInfoPtr_RpcLogic___PlayBloodMist_2166136261_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060052EE RID: 21230 RVA: 0x00187CE4 File Offset: 0x00185EE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178456, XrefRangeEnd = 178463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_PlayBloodMist_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHealth.NativeMethodInfoPtr_RpcReader___Observers_PlayBloodMist_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060052EF RID: 21231 RVA: 0x00187D34 File Offset: 0x00185F34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178463, XrefRangeEnd = 178475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Method_Private_Void_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHealth.NativeMethodInfoPtr_Method_Private_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060052F0 RID: 21232 RVA: 0x000277B6 File Offset: 0x000259B6
		public PlayerHealth(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170018F2 RID: 6386
		// (get) Token: 0x060052F1 RID: 21233 RVA: 0x00187D68 File Offset: 0x00185F68
		// (set) Token: 0x060052F2 RID: 21234 RVA: 0x000277BF File Offset: 0x000259BF
		public unsafe static float MAX_HEALTH
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PlayerHealth.NativeFieldInfoPtr_MAX_HEALTH, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerHealth.NativeFieldInfoPtr_MAX_HEALTH, (void*)(&value));
			}
		}

		// Token: 0x170018F3 RID: 6387
		// (get) Token: 0x060052F3 RID: 21235 RVA: 0x00187D84 File Offset: 0x00185F84
		// (set) Token: 0x060052F4 RID: 21236 RVA: 0x000277CD File Offset: 0x000259CD
		public unsafe static float HEALTH_RECOVERY_PER_MINUTE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PlayerHealth.NativeFieldInfoPtr_HEALTH_RECOVERY_PER_MINUTE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerHealth.NativeFieldInfoPtr_HEALTH_RECOVERY_PER_MINUTE, (void*)(&value));
			}
		}

		// Token: 0x170018F4 RID: 6388
		// (get) Token: 0x060052F5 RID: 21237 RVA: 0x00187DA0 File Offset: 0x00185FA0
		// (set) Token: 0x060052F6 RID: 21238 RVA: 0x000277DB File Offset: 0x000259DB
		public unsafe bool _IsAlive_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHealth.NativeFieldInfoPtr__IsAlive_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHealth.NativeFieldInfoPtr__IsAlive_k__BackingField)) = value;
			}
		}

		// Token: 0x170018F5 RID: 6389
		// (get) Token: 0x060052F7 RID: 21239 RVA: 0x00187DC8 File Offset: 0x00185FC8
		// (set) Token: 0x060052F8 RID: 21240 RVA: 0x000277F6 File Offset: 0x000259F6
		public unsafe float _CurrentHealth_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHealth.NativeFieldInfoPtr__CurrentHealth_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHealth.NativeFieldInfoPtr__CurrentHealth_k__BackingField)) = value;
			}
		}

		// Token: 0x170018F6 RID: 6390
		// (get) Token: 0x060052F9 RID: 21241 RVA: 0x00187DF0 File Offset: 0x00185FF0
		// (set) Token: 0x060052FA RID: 21242 RVA: 0x00027811 File Offset: 0x00025A11
		public unsafe float _TimeSinceLastDamage_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHealth.NativeFieldInfoPtr__TimeSinceLastDamage_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHealth.NativeFieldInfoPtr__TimeSinceLastDamage_k__BackingField)) = value;
			}
		}

		// Token: 0x170018F7 RID: 6391
		// (get) Token: 0x060052FB RID: 21243 RVA: 0x00187E18 File Offset: 0x00186018
		// (set) Token: 0x060052FC RID: 21244 RVA: 0x0002782C File Offset: 0x00025A2C
		public unsafe Player Player
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHealth.NativeFieldInfoPtr_Player);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Player>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHealth.NativeFieldInfoPtr_Player), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170018F8 RID: 6392
		// (get) Token: 0x060052FD RID: 21245 RVA: 0x00187E48 File Offset: 0x00186048
		// (set) Token: 0x060052FE RID: 21246 RVA: 0x0002784B File Offset: 0x00025A4B
		public unsafe ParticleSystem BloodParticles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHealth.NativeFieldInfoPtr_BloodParticles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHealth.NativeFieldInfoPtr_BloodParticles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170018F9 RID: 6393
		// (get) Token: 0x060052FF RID: 21247 RVA: 0x00187E78 File Offset: 0x00186078
		// (set) Token: 0x06005300 RID: 21248 RVA: 0x0002786A File Offset: 0x00025A6A
		public unsafe UnityEvent<float> onHealthChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHealth.NativeFieldInfoPtr_onHealthChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHealth.NativeFieldInfoPtr_onHealthChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170018FA RID: 6394
		// (get) Token: 0x06005301 RID: 21249 RVA: 0x00187EA8 File Offset: 0x001860A8
		// (set) Token: 0x06005302 RID: 21250 RVA: 0x00027889 File Offset: 0x00025A89
		public unsafe UnityEvent onDie
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHealth.NativeFieldInfoPtr_onDie);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHealth.NativeFieldInfoPtr_onDie), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170018FB RID: 6395
		// (get) Token: 0x06005303 RID: 21251 RVA: 0x00187ED8 File Offset: 0x001860D8
		// (set) Token: 0x06005304 RID: 21252 RVA: 0x000278A8 File Offset: 0x00025AA8
		public unsafe UnityEvent onRevive
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHealth.NativeFieldInfoPtr_onRevive);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHealth.NativeFieldInfoPtr_onRevive), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170018FC RID: 6396
		// (get) Token: 0x06005305 RID: 21253 RVA: 0x00187F08 File Offset: 0x00186108
		// (set) Token: 0x06005306 RID: 21254 RVA: 0x000278C7 File Offset: 0x00025AC7
		public unsafe bool AfflictedWithLethalEffect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHealth.NativeFieldInfoPtr_AfflictedWithLethalEffect);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHealth.NativeFieldInfoPtr_AfflictedWithLethalEffect)) = value;
			}
		}

		// Token: 0x170018FD RID: 6397
		// (get) Token: 0x06005307 RID: 21255 RVA: 0x00187F30 File Offset: 0x00186130
		// (set) Token: 0x06005308 RID: 21256 RVA: 0x000278E2 File Offset: 0x00025AE2
		public unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHealth.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHealth.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x170018FE RID: 6398
		// (get) Token: 0x06005309 RID: 21257 RVA: 0x00187F58 File Offset: 0x00186158
		// (set) Token: 0x0600530A RID: 21258 RVA: 0x000278FD File Offset: 0x00025AFD
		public unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHealth.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHealth.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x0400381A RID: 14362
		private static readonly IntPtr NativeFieldInfoPtr_MAX_HEALTH;

		// Token: 0x0400381B RID: 14363
		private static readonly IntPtr NativeFieldInfoPtr_HEALTH_RECOVERY_PER_MINUTE;

		// Token: 0x0400381C RID: 14364
		private static readonly IntPtr NativeFieldInfoPtr__IsAlive_k__BackingField;

		// Token: 0x0400381D RID: 14365
		private static readonly IntPtr NativeFieldInfoPtr__CurrentHealth_k__BackingField;

		// Token: 0x0400381E RID: 14366
		private static readonly IntPtr NativeFieldInfoPtr__TimeSinceLastDamage_k__BackingField;

		// Token: 0x0400381F RID: 14367
		private static readonly IntPtr NativeFieldInfoPtr_Player;

		// Token: 0x04003820 RID: 14368
		private static readonly IntPtr NativeFieldInfoPtr_BloodParticles;

		// Token: 0x04003821 RID: 14369
		private static readonly IntPtr NativeFieldInfoPtr_onHealthChanged;

		// Token: 0x04003822 RID: 14370
		private static readonly IntPtr NativeFieldInfoPtr_onDie;

		// Token: 0x04003823 RID: 14371
		private static readonly IntPtr NativeFieldInfoPtr_onRevive;

		// Token: 0x04003824 RID: 14372
		private static readonly IntPtr NativeFieldInfoPtr_AfflictedWithLethalEffect;

		// Token: 0x04003825 RID: 14373
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04003826 RID: 14374
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04003827 RID: 14375
		private static readonly IntPtr NativeMethodInfoPtr_get_IsAlive_Public_get_Boolean_0;

		// Token: 0x04003828 RID: 14376
		private static readonly IntPtr NativeMethodInfoPtr_set_IsAlive_Protected_set_Void_Boolean_0;

		// Token: 0x04003829 RID: 14377
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentHealth_Public_get_Single_0;

		// Token: 0x0400382A RID: 14378
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentHealth_Protected_set_Void_Single_0;

		// Token: 0x0400382B RID: 14379
		private static readonly IntPtr NativeMethodInfoPtr_get_TimeSinceLastDamage_Public_get_Single_0;

		// Token: 0x0400382C RID: 14380
		private static readonly IntPtr NativeMethodInfoPtr_set_TimeSinceLastDamage_Protected_set_Void_Single_0;

		// Token: 0x0400382D RID: 14381
		private static readonly IntPtr NativeMethodInfoPtr_get_CanTakeDamage_Public_get_Boolean_0;

		// Token: 0x0400382E RID: 14382
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x0400382F RID: 14383
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04003830 RID: 14384
		private static readonly IntPtr NativeMethodInfoPtr_TakeDamage_Public_Void_Single_Boolean_Boolean_0;

		// Token: 0x04003831 RID: 14385
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04003832 RID: 14386
		private static readonly IntPtr NativeMethodInfoPtr_MinPass_Private_Void_0;

		// Token: 0x04003833 RID: 14387
		private static readonly IntPtr NativeMethodInfoPtr_SetAfflictedWithLethalEffect_Public_Void_Boolean_0;

		// Token: 0x04003834 RID: 14388
		private static readonly IntPtr NativeMethodInfoPtr_RecoverHealth_Public_Void_Single_0;

		// Token: 0x04003835 RID: 14389
		private static readonly IntPtr NativeMethodInfoPtr_SetHealth_Public_Void_Single_0;

		// Token: 0x04003836 RID: 14390
		private static readonly IntPtr NativeMethodInfoPtr_SendDie_Public_Void_0;

		// Token: 0x04003837 RID: 14391
		private static readonly IntPtr NativeMethodInfoPtr_Die_Public_Void_0;

		// Token: 0x04003838 RID: 14392
		private static readonly IntPtr NativeMethodInfoPtr_SendRevive_Public_Void_Vector3_Quaternion_0;

		// Token: 0x04003839 RID: 14393
		private static readonly IntPtr NativeMethodInfoPtr_Revive_Public_Void_Vector3_Quaternion_0;

		// Token: 0x0400383A RID: 14394
		private static readonly IntPtr NativeMethodInfoPtr_PlayBloodMist_Public_Void_0;

		// Token: 0x0400383B RID: 14395
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400383C RID: 14396
		private static readonly IntPtr NativeMethodInfoPtr__Awake_b__22_0_Private_Void_0;

		// Token: 0x0400383D RID: 14397
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x0400383E RID: 14398
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x0400383F RID: 14399
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04003840 RID: 14400
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_TakeDamage_3505310624_Private_Void_Single_Boolean_Boolean_0;

		// Token: 0x04003841 RID: 14401
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___TakeDamage_3505310624_Public_Void_Single_Boolean_Boolean_0;

		// Token: 0x04003842 RID: 14402
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_TakeDamage_3505310624_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003843 RID: 14403
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendDie_2166136261_Private_Void_0;

		// Token: 0x04003844 RID: 14404
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendDie_2166136261_Public_Void_0;

		// Token: 0x04003845 RID: 14405
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendDie_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04003846 RID: 14406
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_Die_2166136261_Private_Void_0;

		// Token: 0x04003847 RID: 14407
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___Die_2166136261_Public_Void_0;

		// Token: 0x04003848 RID: 14408
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_Die_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003849 RID: 14409
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendRevive_3848837105_Private_Void_Vector3_Quaternion_0;

		// Token: 0x0400384A RID: 14410
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendRevive_3848837105_Public_Void_Vector3_Quaternion_0;

		// Token: 0x0400384B RID: 14411
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendRevive_3848837105_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x0400384C RID: 14412
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_Revive_3848837105_Private_Void_Vector3_Quaternion_0;

		// Token: 0x0400384D RID: 14413
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___Revive_3848837105_Public_Void_Vector3_Quaternion_0;

		// Token: 0x0400384E RID: 14414
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_Revive_3848837105_Private_Void_PooledReader_Channel_0;

		// Token: 0x0400384F RID: 14415
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_PlayBloodMist_2166136261_Private_Void_0;

		// Token: 0x04003850 RID: 14416
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___PlayBloodMist_2166136261_Public_Void_0;

		// Token: 0x04003851 RID: 14417
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_PlayBloodMist_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003852 RID: 14418
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Void_PDM_0;
	}
}
