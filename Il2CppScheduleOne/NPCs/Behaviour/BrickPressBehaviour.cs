using System;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ObjectScripts;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2CppScheduleOne.NPCs.Behaviour
{
	// Token: 0x02000348 RID: 840
	public class BrickPressBehaviour : Behaviour
	{
		// Token: 0x06003EE9 RID: 16105 RVA: 0x0013E2C8 File Offset: 0x0013C4C8
		// Note: this type is marked as 'beforefieldinit'.
		static BrickPressBehaviour()
		{
			Il2CppClassPointerStore<BrickPressBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.Behaviour", "BrickPressBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BrickPressBehaviour>.NativeClassPtr);
			BrickPressBehaviour.NativeFieldInfoPtr_BASE_PACKAGING_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BrickPressBehaviour>.NativeClassPtr, "BASE_PACKAGING_TIME");
			BrickPressBehaviour.NativeFieldInfoPtr__Press_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BrickPressBehaviour>.NativeClassPtr, "<Press>k__BackingField");
			BrickPressBehaviour.NativeFieldInfoPtr__PackagingInProgress_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BrickPressBehaviour>.NativeClassPtr, "<PackagingInProgress>k__BackingField");
			BrickPressBehaviour.NativeFieldInfoPtr_packagingRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BrickPressBehaviour>.NativeClassPtr, "packagingRoutine");
			BrickPressBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BrickPressBehaviour>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.BrickPressBehaviourAssembly-CSharp.dll_Excuted");
			BrickPressBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BrickPressBehaviour>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.NPCs.Behaviour.BrickPressBehaviourAssembly-CSharp.dll_Excuted");
			BrickPressBehaviour.NativeMethodInfoPtr_get_Press_Public_get_BrickPress_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrickPressBehaviour>.NativeClassPtr, 100670726);
			BrickPressBehaviour.NativeMethodInfoPtr_set_Press_Protected_set_Void_BrickPress_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrickPressBehaviour>.NativeClassPtr, 100670727);
			BrickPressBehaviour.NativeMethodInfoPtr_get_PackagingInProgress_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrickPressBehaviour>.NativeClassPtr, 100670728);
			BrickPressBehaviour.NativeMethodInfoPtr_set_PackagingInProgress_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrickPressBehaviour>.NativeClassPtr, 100670729);
			BrickPressBehaviour.NativeMethodInfoPtr_Begin_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrickPressBehaviour>.NativeClassPtr, 100670730);
			BrickPressBehaviour.NativeMethodInfoPtr_Resume_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrickPressBehaviour>.NativeClassPtr, 100670731);
			BrickPressBehaviour.NativeMethodInfoPtr_Pause_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrickPressBehaviour>.NativeClassPtr, 100670732);
			BrickPressBehaviour.NativeMethodInfoPtr_Disable_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrickPressBehaviour>.NativeClassPtr, 100670733);
			BrickPressBehaviour.NativeMethodInfoPtr_End_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrickPressBehaviour>.NativeClassPtr, 100670734);
			BrickPressBehaviour.NativeMethodInfoPtr_ActiveMinPass_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrickPressBehaviour>.NativeClassPtr, 100670735);
			BrickPressBehaviour.NativeMethodInfoPtr_StartPackaging_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrickPressBehaviour>.NativeClassPtr, 100670736);
			BrickPressBehaviour.NativeMethodInfoPtr_AssignStation_Public_Void_BrickPress_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrickPressBehaviour>.NativeClassPtr, 100670737);
			BrickPressBehaviour.NativeMethodInfoPtr_IsAtStation_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrickPressBehaviour>.NativeClassPtr, 100670738);
			BrickPressBehaviour.NativeMethodInfoPtr_GoToStation_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrickPressBehaviour>.NativeClassPtr, 100670739);
			BrickPressBehaviour.NativeMethodInfoPtr_BeginPackaging_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrickPressBehaviour>.NativeClassPtr, 100670740);
			BrickPressBehaviour.NativeMethodInfoPtr_StopPackaging_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrickPressBehaviour>.NativeClassPtr, 100670741);
			BrickPressBehaviour.NativeMethodInfoPtr_IsStationReady_Public_Boolean_BrickPress_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrickPressBehaviour>.NativeClassPtr, 100670742);
			BrickPressBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrickPressBehaviour>.NativeClassPtr, 100670743);
			BrickPressBehaviour.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrickPressBehaviour>.NativeClassPtr, 100670744);
			BrickPressBehaviour.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrickPressBehaviour>.NativeClassPtr, 100670745);
			BrickPressBehaviour.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrickPressBehaviour>.NativeClassPtr, 100670746);
			BrickPressBehaviour.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrickPressBehaviour>.NativeClassPtr, 100670747);
			BrickPressBehaviour.NativeMethodInfoPtr_RpcWriter___Observers_BeginPackaging_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrickPressBehaviour>.NativeClassPtr, 100670748);
			BrickPressBehaviour.NativeMethodInfoPtr_RpcLogic___BeginPackaging_2166136261_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrickPressBehaviour>.NativeClassPtr, 100670749);
			BrickPressBehaviour.NativeMethodInfoPtr_RpcReader___Observers_BeginPackaging_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrickPressBehaviour>.NativeClassPtr, 100670750);
			BrickPressBehaviour.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrickPressBehaviour>.NativeClassPtr, 100670751);
		}

		// Token: 0x17001362 RID: 4962
		// (get) Token: 0x06003EEA RID: 16106 RVA: 0x0013E578 File Offset: 0x0013C778
		// (set) Token: 0x06003EEB RID: 16107 RVA: 0x0013E5B8 File Offset: 0x0013C7B8
		public unsafe BrickPress Press
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BrickPressBehaviour.NativeMethodInfoPtr_get_Press_Public_get_BrickPress_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<BrickPress>(intPtr3) : null;
			}
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 115138, RefRangeEnd = 115149, XrefRangeStart = 115138, XrefRangeEnd = 115149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BrickPressBehaviour.NativeMethodInfoPtr_set_Press_Protected_set_Void_BrickPress_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001363 RID: 4963
		// (get) Token: 0x06003EEC RID: 16108 RVA: 0x0013E5FC File Offset: 0x0013C7FC
		// (set) Token: 0x06003EED RID: 16109 RVA: 0x0013E638 File Offset: 0x0013C838
		public unsafe bool PackagingInProgress
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BrickPressBehaviour.NativeMethodInfoPtr_get_PackagingInProgress_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BrickPressBehaviour.NativeMethodInfoPtr_set_PackagingInProgress_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003EEE RID: 16110 RVA: 0x0013E678 File Offset: 0x0013C878
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 147217, XrefRangeEnd = 147219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Begin()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BrickPressBehaviour.NativeMethodInfoPtr_Begin_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003EEF RID: 16111 RVA: 0x0013E6B4 File Offset: 0x0013C8B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 147219, XrefRangeEnd = 147221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Resume()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BrickPressBehaviour.NativeMethodInfoPtr_Resume_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003EF0 RID: 16112 RVA: 0x0013E6F0 File Offset: 0x0013C8F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 147221, XrefRangeEnd = 147223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Pause()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BrickPressBehaviour.NativeMethodInfoPtr_Pause_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003EF1 RID: 16113 RVA: 0x0013E72C File Offset: 0x0013C92C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Disable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BrickPressBehaviour.NativeMethodInfoPtr_Disable_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003EF2 RID: 16114 RVA: 0x0013E768 File Offset: 0x0013C968
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 147223, XrefRangeEnd = 147236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void End()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BrickPressBehaviour.NativeMethodInfoPtr_End_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003EF3 RID: 16115 RVA: 0x0013E7A4 File Offset: 0x0013C9A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 147236, XrefRangeEnd = 147248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ActiveMinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BrickPressBehaviour.NativeMethodInfoPtr_ActiveMinPass_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003EF4 RID: 16116 RVA: 0x0013E7E0 File Offset: 0x0013C9E0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 147254, RefRangeEnd = 147256, XrefRangeStart = 147248, XrefRangeEnd = 147254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartPackaging()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BrickPressBehaviour.NativeMethodInfoPtr_StartPackaging_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003EF5 RID: 16117 RVA: 0x0013E814 File Offset: 0x0013CA14
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 115138, RefRangeEnd = 115149, XrefRangeStart = 115138, XrefRangeEnd = 115149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AssignStation(BrickPress press)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(press);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BrickPressBehaviour.NativeMethodInfoPtr_AssignStation_Public_Void_BrickPress_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003EF6 RID: 16118 RVA: 0x0013E858 File Offset: 0x0013CA58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 147256, XrefRangeEnd = 147259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsAtStation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BrickPressBehaviour.NativeMethodInfoPtr_IsAtStation_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003EF7 RID: 16119 RVA: 0x0013E894 File Offset: 0x0013CA94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 147259, XrefRangeEnd = 147262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GoToStation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BrickPressBehaviour.NativeMethodInfoPtr_GoToStation_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003EF8 RID: 16120 RVA: 0x0013E8C8 File Offset: 0x0013CAC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 147262, XrefRangeEnd = 147283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BeginPackaging()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BrickPressBehaviour.NativeMethodInfoPtr_BeginPackaging_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003EF9 RID: 16121 RVA: 0x0013E8FC File Offset: 0x0013CAFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 147283, XrefRangeEnd = 147284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopPackaging()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BrickPressBehaviour.NativeMethodInfoPtr_StopPackaging_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003EFA RID: 16122 RVA: 0x0013E930 File Offset: 0x0013CB30
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 147300, RefRangeEnd = 147303, XrefRangeStart = 147284, XrefRangeEnd = 147300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsStationReady(BrickPress press)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(press);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BrickPressBehaviour.NativeMethodInfoPtr_IsStationReady_Public_Boolean_BrickPress_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003EFB RID: 16123 RVA: 0x0013E980 File Offset: 0x0013CB80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BrickPressBehaviour() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BrickPressBehaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BrickPressBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003EFC RID: 16124 RVA: 0x0013E9BC File Offset: 0x0013CBBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 147303, XrefRangeEnd = 147308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BrickPressBehaviour.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06003EFD RID: 16125 RVA: 0x0013E9FC File Offset: 0x0013CBFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 147308, XrefRangeEnd = 147316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BrickPressBehaviour.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003EFE RID: 16126 RVA: 0x0013EA38 File Offset: 0x0013CC38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 147316, XrefRangeEnd = 147317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BrickPressBehaviour.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003EFF RID: 16127 RVA: 0x0013EA74 File Offset: 0x0013CC74
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BrickPressBehaviour.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003F00 RID: 16128 RVA: 0x0013EAB0 File Offset: 0x0013CCB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 147317, XrefRangeEnd = 147335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_BeginPackaging_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BrickPressBehaviour.NativeMethodInfoPtr_RpcWriter___Observers_BeginPackaging_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003F01 RID: 16129 RVA: 0x0013EAE4 File Offset: 0x0013CCE4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 147349, RefRangeEnd = 147351, XrefRangeStart = 147335, XrefRangeEnd = 147349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___BeginPackaging_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BrickPressBehaviour.NativeMethodInfoPtr_RpcLogic___BeginPackaging_2166136261_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003F02 RID: 16130 RVA: 0x0013EB18 File Offset: 0x0013CD18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 147351, XrefRangeEnd = 147354, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_BeginPackaging_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BrickPressBehaviour.NativeMethodInfoPtr_RpcReader___Observers_BeginPackaging_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003F03 RID: 16131 RVA: 0x0013EB68 File Offset: 0x0013CD68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BrickPressBehaviour.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003F04 RID: 16132 RVA: 0x0001F783 File Offset: 0x0001D983
		public BrickPressBehaviour(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700135C RID: 4956
		// (get) Token: 0x06003F05 RID: 16133 RVA: 0x0013EBA4 File Offset: 0x0013CDA4
		// (set) Token: 0x06003F06 RID: 16134 RVA: 0x0001F78C File Offset: 0x0001D98C
		public unsafe static float BASE_PACKAGING_TIME
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(BrickPressBehaviour.NativeFieldInfoPtr_BASE_PACKAGING_TIME, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BrickPressBehaviour.NativeFieldInfoPtr_BASE_PACKAGING_TIME, (void*)(&value));
			}
		}

		// Token: 0x1700135D RID: 4957
		// (get) Token: 0x06003F07 RID: 16135 RVA: 0x0013EBC0 File Offset: 0x0013CDC0
		// (set) Token: 0x06003F08 RID: 16136 RVA: 0x0001F79A File Offset: 0x0001D99A
		public unsafe BrickPress _Press_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressBehaviour.NativeFieldInfoPtr__Press_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BrickPress>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressBehaviour.NativeFieldInfoPtr__Press_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700135E RID: 4958
		// (get) Token: 0x06003F09 RID: 16137 RVA: 0x0013EBF0 File Offset: 0x0013CDF0
		// (set) Token: 0x06003F0A RID: 16138 RVA: 0x0001F7B9 File Offset: 0x0001D9B9
		public unsafe bool _PackagingInProgress_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressBehaviour.NativeFieldInfoPtr__PackagingInProgress_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressBehaviour.NativeFieldInfoPtr__PackagingInProgress_k__BackingField)) = value;
			}
		}

		// Token: 0x1700135F RID: 4959
		// (get) Token: 0x06003F0B RID: 16139 RVA: 0x0013EC18 File Offset: 0x0013CE18
		// (set) Token: 0x06003F0C RID: 16140 RVA: 0x0001F7D4 File Offset: 0x0001D9D4
		public unsafe Coroutine packagingRoutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressBehaviour.NativeFieldInfoPtr_packagingRoutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressBehaviour.NativeFieldInfoPtr_packagingRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001360 RID: 4960
		// (get) Token: 0x06003F0D RID: 16141 RVA: 0x0013EC48 File Offset: 0x0013CE48
		// (set) Token: 0x06003F0E RID: 16142 RVA: 0x0001F7F3 File Offset: 0x0001D9F3
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17001361 RID: 4961
		// (get) Token: 0x06003F0F RID: 16143 RVA: 0x0013EC70 File Offset: 0x0013CE70
		// (set) Token: 0x06003F10 RID: 16144 RVA: 0x0001F80E File Offset: 0x0001DA0E
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x040029B6 RID: 10678
		private static readonly IntPtr NativeFieldInfoPtr_BASE_PACKAGING_TIME;

		// Token: 0x040029B7 RID: 10679
		private static readonly IntPtr NativeFieldInfoPtr__Press_k__BackingField;

		// Token: 0x040029B8 RID: 10680
		private static readonly IntPtr NativeFieldInfoPtr__PackagingInProgress_k__BackingField;

		// Token: 0x040029B9 RID: 10681
		private static readonly IntPtr NativeFieldInfoPtr_packagingRoutine;

		// Token: 0x040029BA RID: 10682
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x040029BB RID: 10683
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x040029BC RID: 10684
		private static readonly IntPtr NativeMethodInfoPtr_get_Press_Public_get_BrickPress_0;

		// Token: 0x040029BD RID: 10685
		private static readonly IntPtr NativeMethodInfoPtr_set_Press_Protected_set_Void_BrickPress_0;

		// Token: 0x040029BE RID: 10686
		private static readonly IntPtr NativeMethodInfoPtr_get_PackagingInProgress_Public_get_Boolean_0;

		// Token: 0x040029BF RID: 10687
		private static readonly IntPtr NativeMethodInfoPtr_set_PackagingInProgress_Protected_set_Void_Boolean_0;

		// Token: 0x040029C0 RID: 10688
		private static readonly IntPtr NativeMethodInfoPtr_Begin_Protected_Virtual_Void_0;

		// Token: 0x040029C1 RID: 10689
		private static readonly IntPtr NativeMethodInfoPtr_Resume_Protected_Virtual_Void_0;

		// Token: 0x040029C2 RID: 10690
		private static readonly IntPtr NativeMethodInfoPtr_Pause_Protected_Virtual_Void_0;

		// Token: 0x040029C3 RID: 10691
		private static readonly IntPtr NativeMethodInfoPtr_Disable_Public_Virtual_Void_0;

		// Token: 0x040029C4 RID: 10692
		private static readonly IntPtr NativeMethodInfoPtr_End_Protected_Virtual_Void_0;

		// Token: 0x040029C5 RID: 10693
		private static readonly IntPtr NativeMethodInfoPtr_ActiveMinPass_Public_Virtual_Void_0;

		// Token: 0x040029C6 RID: 10694
		private static readonly IntPtr NativeMethodInfoPtr_StartPackaging_Private_Void_0;

		// Token: 0x040029C7 RID: 10695
		private static readonly IntPtr NativeMethodInfoPtr_AssignStation_Public_Void_BrickPress_0;

		// Token: 0x040029C8 RID: 10696
		private static readonly IntPtr NativeMethodInfoPtr_IsAtStation_Public_Boolean_0;

		// Token: 0x040029C9 RID: 10697
		private static readonly IntPtr NativeMethodInfoPtr_GoToStation_Public_Void_0;

		// Token: 0x040029CA RID: 10698
		private static readonly IntPtr NativeMethodInfoPtr_BeginPackaging_Public_Void_0;

		// Token: 0x040029CB RID: 10699
		private static readonly IntPtr NativeMethodInfoPtr_StopPackaging_Private_Void_0;

		// Token: 0x040029CC RID: 10700
		private static readonly IntPtr NativeMethodInfoPtr_IsStationReady_Public_Boolean_BrickPress_0;

		// Token: 0x040029CD RID: 10701
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040029CE RID: 10702
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x040029CF RID: 10703
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x040029D0 RID: 10704
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x040029D1 RID: 10705
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x040029D2 RID: 10706
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_BeginPackaging_2166136261_Private_Void_0;

		// Token: 0x040029D3 RID: 10707
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___BeginPackaging_2166136261_Public_Void_0;

		// Token: 0x040029D4 RID: 10708
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_BeginPackaging_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x040029D5 RID: 10709
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x02000943 RID: 2371
		[ObfuscatedName("ScheduleOne.NPCs.Behaviour.BrickPressBehaviour+<<BeginPackaging>g__Package|20_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBrSiSiObObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600C799 RID: 51097 RVA: 0x00306920 File Offset: 0x00304B20
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBrSiSiObObUnique()
			{
				Il2CppClassPointerStore<BrickPressBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBrSiSiObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BrickPressBehaviour>.NativeClassPtr, "<<BeginPackaging>g__Package|20_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BrickPressBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBrSiSiObObUnique>.NativeClassPtr);
				BrickPressBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBrSiSiObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BrickPressBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBrSiSiObObUnique>.NativeClassPtr, "<>1__state");
				BrickPressBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBrSiSiObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BrickPressBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBrSiSiObObUnique>.NativeClassPtr, "<>2__current");
				BrickPressBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBrSiSiObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BrickPressBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBrSiSiObObUnique>.NativeClassPtr, "<>4__this");
				BrickPressBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBrSiSiObObUnique.NativeFieldInfoPtr__packageTime_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BrickPressBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBrSiSiObObUnique>.NativeClassPtr, "<packageTime>5__2");
				BrickPressBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBrSiSiObObUnique.NativeFieldInfoPtr__i_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BrickPressBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBrSiSiObObUnique>.NativeClassPtr, "<i>5__3");
				BrickPressBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBrSiSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrickPressBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBrSiSiObObUnique>.NativeClassPtr, 100670752);
				BrickPressBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBrSiSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrickPressBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBrSiSiObObUnique>.NativeClassPtr, 100670753);
				BrickPressBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBrSiSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrickPressBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBrSiSiObObUnique>.NativeClassPtr, 100670754);
				BrickPressBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBrSiSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrickPressBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBrSiSiObObUnique>.NativeClassPtr, 100670755);
				BrickPressBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBrSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrickPressBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBrSiSiObObUnique>.NativeClassPtr, 100670756);
				BrickPressBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBrSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrickPressBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBrSiSiObObUnique>.NativeClassPtr, 100670757);
			}

			// Token: 0x0600C79A RID: 51098 RVA: 0x00306A28 File Offset: 0x00304C28
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBrSiSiObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BrickPressBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBrSiSiObObUnique>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BrickPressBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBrSiSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C79B RID: 51099 RVA: 0x00306A70 File Offset: 0x00304C70
			[CallerCount(13604)]
			[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BrickPressBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBrSiSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C79C RID: 51100 RVA: 0x00306AA4 File Offset: 0x00304CA4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 147194, XrefRangeEnd = 147212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BrickPressBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBrSiSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003E39 RID: 15929
			// (get) Token: 0x0600C79D RID: 51101 RVA: 0x00306AE0 File Offset: 0x00304CE0
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BrickPressBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBrSiSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600C79E RID: 51102 RVA: 0x00306B20 File Offset: 0x00304D20
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 147212, XrefRangeEnd = 147217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BrickPressBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBrSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003E3A RID: 15930
			// (get) Token: 0x0600C79F RID: 51103 RVA: 0x00306B54 File Offset: 0x00304D54
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BrickPressBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBrSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600C7A0 RID: 51104 RVA: 0x000611C8 File Offset: 0x0005F3C8
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBrSiSiObObUnique(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003E34 RID: 15924
			// (get) Token: 0x0600C7A1 RID: 51105 RVA: 0x00306B94 File Offset: 0x00304D94
			// (set) Token: 0x0600C7A2 RID: 51106 RVA: 0x000611D1 File Offset: 0x0005F3D1
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBrSiSiObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBrSiSiObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003E35 RID: 15925
			// (get) Token: 0x0600C7A3 RID: 51107 RVA: 0x00306BBC File Offset: 0x00304DBC
			// (set) Token: 0x0600C7A4 RID: 51108 RVA: 0x000611EC File Offset: 0x0005F3EC
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBrSiSiObObUnique.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBrSiSiObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003E36 RID: 15926
			// (get) Token: 0x0600C7A5 RID: 51109 RVA: 0x00306BEC File Offset: 0x00304DEC
			// (set) Token: 0x0600C7A6 RID: 51110 RVA: 0x0006120B File Offset: 0x0005F40B
			public unsafe BrickPressBehaviour __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBrSiSiObObUnique.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BrickPressBehaviour>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBrSiSiObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003E37 RID: 15927
			// (get) Token: 0x0600C7A7 RID: 51111 RVA: 0x00306C1C File Offset: 0x00304E1C
			// (set) Token: 0x0600C7A8 RID: 51112 RVA: 0x0006122A File Offset: 0x0005F42A
			public unsafe float _packageTime_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBrSiSiObObUnique.NativeFieldInfoPtr__packageTime_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBrSiSiObObUnique.NativeFieldInfoPtr__packageTime_5__2)) = value;
				}
			}

			// Token: 0x17003E38 RID: 15928
			// (get) Token: 0x0600C7A9 RID: 51113 RVA: 0x00306C44 File Offset: 0x00304E44
			// (set) Token: 0x0600C7AA RID: 51114 RVA: 0x00061245 File Offset: 0x0005F445
			public unsafe float _i_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBrSiSiObObUnique.NativeFieldInfoPtr__i_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBrSiSiObObUnique.NativeFieldInfoPtr__i_5__3)) = value;
				}
			}

			// Token: 0x04008715 RID: 34581
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008716 RID: 34582
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008717 RID: 34583
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008718 RID: 34584
			private static readonly IntPtr NativeFieldInfoPtr__packageTime_5__2;

			// Token: 0x04008719 RID: 34585
			private static readonly IntPtr NativeFieldInfoPtr__i_5__3;

			// Token: 0x0400871A RID: 34586
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400871B RID: 34587
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400871C RID: 34588
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400871D RID: 34589
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400871E RID: 34590
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400871F RID: 34591
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
