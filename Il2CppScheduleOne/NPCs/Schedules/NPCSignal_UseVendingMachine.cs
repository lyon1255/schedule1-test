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

namespace Il2CppScheduleOne.NPCs.Schedules
{
	// Token: 0x020002EA RID: 746
	public class NPCSignal_UseVendingMachine : NPCSignal
	{
		// Token: 0x0600382B RID: 14379 RVA: 0x001268C8 File Offset: 0x00124AC8
		// Note: this type is marked as 'beforefieldinit'.
		static NPCSignal_UseVendingMachine()
		{
			Il2CppClassPointerStore<NPCSignal_UseVendingMachine>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.Schedules", "NPCSignal_UseVendingMachine");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCSignal_UseVendingMachine>.NativeClassPtr);
			NPCSignal_UseVendingMachine.NativeFieldInfoPtr_destinationThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCSignal_UseVendingMachine>.NativeClassPtr, "destinationThreshold");
			NPCSignal_UseVendingMachine.NativeFieldInfoPtr_MachineOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCSignal_UseVendingMachine>.NativeClassPtr, "MachineOverride");
			NPCSignal_UseVendingMachine.NativeFieldInfoPtr_TargetMachine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCSignal_UseVendingMachine>.NativeClassPtr, "TargetMachine");
			NPCSignal_UseVendingMachine.NativeFieldInfoPtr_purchaseCoroutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCSignal_UseVendingMachine>.NativeClassPtr, "purchaseCoroutine");
			NPCSignal_UseVendingMachine.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCSignal_UseVendingMachine>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.NPCs.Schedules.NPCSignal_UseVendingMachineAssembly-CSharp.dll_Excuted");
			NPCSignal_UseVendingMachine.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCSignal_UseVendingMachine>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.NPCs.Schedules.NPCSignal_UseVendingMachineAssembly-CSharp.dll_Excuted");
			NPCSignal_UseVendingMachine.NativeMethodInfoPtr_get_ActionName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSignal_UseVendingMachine>.NativeClassPtr, 100669797);
			NPCSignal_UseVendingMachine.NativeMethodInfoPtr_GetName_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSignal_UseVendingMachine>.NativeClassPtr, 100669798);
			NPCSignal_UseVendingMachine.NativeMethodInfoPtr_Started_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSignal_UseVendingMachine>.NativeClassPtr, 100669799);
			NPCSignal_UseVendingMachine.NativeMethodInfoPtr_MinPassed_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSignal_UseVendingMachine>.NativeClassPtr, 100669800);
			NPCSignal_UseVendingMachine.NativeMethodInfoPtr_LateStarted_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSignal_UseVendingMachine>.NativeClassPtr, 100669801);
			NPCSignal_UseVendingMachine.NativeMethodInfoPtr_Interrupt_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSignal_UseVendingMachine>.NativeClassPtr, 100669802);
			NPCSignal_UseVendingMachine.NativeMethodInfoPtr_Resume_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSignal_UseVendingMachine>.NativeClassPtr, 100669803);
			NPCSignal_UseVendingMachine.NativeMethodInfoPtr_Skipped_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSignal_UseVendingMachine>.NativeClassPtr, 100669804);
			NPCSignal_UseVendingMachine.NativeMethodInfoPtr_IsAtDestination_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSignal_UseVendingMachine>.NativeClassPtr, 100669805);
			NPCSignal_UseVendingMachine.NativeMethodInfoPtr_GetTargetMachine_Private_VendingMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSignal_UseVendingMachine>.NativeClassPtr, 100669806);
			NPCSignal_UseVendingMachine.NativeMethodInfoPtr_WalkCallback_Protected_Virtual_Void_WalkResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSignal_UseVendingMachine>.NativeClassPtr, 100669807);
			NPCSignal_UseVendingMachine.NativeMethodInfoPtr_Purchase_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSignal_UseVendingMachine>.NativeClassPtr, 100669808);
			NPCSignal_UseVendingMachine.NativeMethodInfoPtr_CheckItem_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSignal_UseVendingMachine>.NativeClassPtr, 100669809);
			NPCSignal_UseVendingMachine.NativeMethodInfoPtr_ItemWasStolen_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSignal_UseVendingMachine>.NativeClassPtr, 100669810);
			NPCSignal_UseVendingMachine.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSignal_UseVendingMachine>.NativeClassPtr, 100669811);
			NPCSignal_UseVendingMachine.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSignal_UseVendingMachine>.NativeClassPtr, 100669812);
			NPCSignal_UseVendingMachine.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSignal_UseVendingMachine>.NativeClassPtr, 100669813);
			NPCSignal_UseVendingMachine.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSignal_UseVendingMachine>.NativeClassPtr, 100669814);
			NPCSignal_UseVendingMachine.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSignal_UseVendingMachine>.NativeClassPtr, 100669815);
			NPCSignal_UseVendingMachine.NativeMethodInfoPtr_RpcWriter___Observers_Purchase_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSignal_UseVendingMachine>.NativeClassPtr, 100669816);
			NPCSignal_UseVendingMachine.NativeMethodInfoPtr_RpcLogic___Purchase_2166136261_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSignal_UseVendingMachine>.NativeClassPtr, 100669817);
			NPCSignal_UseVendingMachine.NativeMethodInfoPtr_RpcReader___Observers_Purchase_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSignal_UseVendingMachine>.NativeClassPtr, 100669818);
			NPCSignal_UseVendingMachine.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSignal_UseVendingMachine>.NativeClassPtr, 100669819);
		}

		// Token: 0x170011F0 RID: 4592
		// (get) Token: 0x0600382C RID: 14380 RVA: 0x00126B3C File Offset: 0x00124D3C
		public new unsafe string ActionName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141093, XrefRangeEnd = 141095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCSignal_UseVendingMachine.NativeMethodInfoPtr_get_ActionName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600382D RID: 14381 RVA: 0x00126B74 File Offset: 0x00124D74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetName()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCSignal_UseVendingMachine.NativeMethodInfoPtr_GetName_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600382E RID: 14382 RVA: 0x00126BB8 File Offset: 0x00124DB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141095, XrefRangeEnd = 141107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Started()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCSignal_UseVendingMachine.NativeMethodInfoPtr_Started_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600382F RID: 14383 RVA: 0x00126BF4 File Offset: 0x00124DF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141107, XrefRangeEnd = 141137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void MinPassed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCSignal_UseVendingMachine.NativeMethodInfoPtr_MinPassed_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003830 RID: 14384 RVA: 0x00126C30 File Offset: 0x00124E30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void LateStarted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCSignal_UseVendingMachine.NativeMethodInfoPtr_LateStarted_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003831 RID: 14385 RVA: 0x00126C6C File Offset: 0x00124E6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141137, XrefRangeEnd = 141146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Interrupt()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCSignal_UseVendingMachine.NativeMethodInfoPtr_Interrupt_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003832 RID: 14386 RVA: 0x00126CA8 File Offset: 0x00124EA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Resume()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCSignal_UseVendingMachine.NativeMethodInfoPtr_Resume_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003833 RID: 14387 RVA: 0x00126CE4 File Offset: 0x00124EE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Skipped()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCSignal_UseVendingMachine.NativeMethodInfoPtr_Skipped_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003834 RID: 14388 RVA: 0x00126D20 File Offset: 0x00124F20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141146, XrefRangeEnd = 141157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsAtDestination()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCSignal_UseVendingMachine.NativeMethodInfoPtr_IsAtDestination_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003835 RID: 14389 RVA: 0x00126D5C File Offset: 0x00124F5C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 141168, RefRangeEnd = 141171, XrefRangeStart = 141157, XrefRangeEnd = 141168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VendingMachine GetTargetMachine()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCSignal_UseVendingMachine.NativeMethodInfoPtr_GetTargetMachine_Private_VendingMachine_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<VendingMachine>(intPtr3) : null;
		}

		// Token: 0x06003836 RID: 14390 RVA: 0x00126D9C File Offset: 0x00124F9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141171, XrefRangeEnd = 141173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WalkCallback(NPCMovement.WalkResult result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCSignal_UseVendingMachine.NativeMethodInfoPtr_WalkCallback_Protected_Virtual_Void_WalkResult_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003837 RID: 14391 RVA: 0x00126DE8 File Offset: 0x00124FE8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 141194, RefRangeEnd = 141196, XrefRangeStart = 141173, XrefRangeEnd = 141194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Purchase()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCSignal_UseVendingMachine.NativeMethodInfoPtr_Purchase_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003838 RID: 14392 RVA: 0x00126E1C File Offset: 0x0012501C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141196, XrefRangeEnd = 141204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CheckItem()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCSignal_UseVendingMachine.NativeMethodInfoPtr_CheckItem_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003839 RID: 14393 RVA: 0x00126E58 File Offset: 0x00125058
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141204, XrefRangeEnd = 141208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ItemWasStolen()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCSignal_UseVendingMachine.NativeMethodInfoPtr_ItemWasStolen_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600383A RID: 14394 RVA: 0x00126E8C File Offset: 0x0012508C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 140574, RefRangeEnd = 140579, XrefRangeStart = 140574, XrefRangeEnd = 140579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NPCSignal_UseVendingMachine() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCSignal_UseVendingMachine>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCSignal_UseVendingMachine.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600383B RID: 14395 RVA: 0x00126EC8 File Offset: 0x001250C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141208, XrefRangeEnd = 141213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCSignal_UseVendingMachine.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600383C RID: 14396 RVA: 0x00126F08 File Offset: 0x00125108
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141213, XrefRangeEnd = 141220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCSignal_UseVendingMachine.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600383D RID: 14397 RVA: 0x00126F44 File Offset: 0x00125144
		[CallerCount(0)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCSignal_UseVendingMachine.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600383E RID: 14398 RVA: 0x00126F80 File Offset: 0x00125180
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCSignal_UseVendingMachine.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600383F RID: 14399 RVA: 0x00126FBC File Offset: 0x001251BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141220, XrefRangeEnd = 141238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_Purchase_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCSignal_UseVendingMachine.NativeMethodInfoPtr_RpcWriter___Observers_Purchase_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003840 RID: 14400 RVA: 0x00126FF0 File Offset: 0x001251F0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 141265, RefRangeEnd = 141267, XrefRangeStart = 141238, XrefRangeEnd = 141265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___Purchase_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCSignal_UseVendingMachine.NativeMethodInfoPtr_RpcLogic___Purchase_2166136261_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003841 RID: 14401 RVA: 0x00127024 File Offset: 0x00125224
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141267, XrefRangeEnd = 141270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_Purchase_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCSignal_UseVendingMachine.NativeMethodInfoPtr_RpcReader___Observers_Purchase_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003842 RID: 14402 RVA: 0x00127074 File Offset: 0x00125274
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCSignal_UseVendingMachine.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003843 RID: 14403 RVA: 0x0001D111 File Offset: 0x0001B311
		public NPCSignal_UseVendingMachine(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170011EA RID: 4586
		// (get) Token: 0x06003844 RID: 14404 RVA: 0x001270B0 File Offset: 0x001252B0
		// (set) Token: 0x06003845 RID: 14405 RVA: 0x0001D11A File Offset: 0x0001B31A
		public unsafe static float destinationThreshold
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(NPCSignal_UseVendingMachine.NativeFieldInfoPtr_destinationThreshold, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NPCSignal_UseVendingMachine.NativeFieldInfoPtr_destinationThreshold, (void*)(&value));
			}
		}

		// Token: 0x170011EB RID: 4587
		// (get) Token: 0x06003846 RID: 14406 RVA: 0x001270CC File Offset: 0x001252CC
		// (set) Token: 0x06003847 RID: 14407 RVA: 0x0001D128 File Offset: 0x0001B328
		public unsafe VendingMachine MachineOverride
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSignal_UseVendingMachine.NativeFieldInfoPtr_MachineOverride);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VendingMachine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSignal_UseVendingMachine.NativeFieldInfoPtr_MachineOverride), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011EC RID: 4588
		// (get) Token: 0x06003848 RID: 14408 RVA: 0x001270FC File Offset: 0x001252FC
		// (set) Token: 0x06003849 RID: 14409 RVA: 0x0001D147 File Offset: 0x0001B347
		public unsafe VendingMachine TargetMachine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSignal_UseVendingMachine.NativeFieldInfoPtr_TargetMachine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VendingMachine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSignal_UseVendingMachine.NativeFieldInfoPtr_TargetMachine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011ED RID: 4589
		// (get) Token: 0x0600384A RID: 14410 RVA: 0x0012712C File Offset: 0x0012532C
		// (set) Token: 0x0600384B RID: 14411 RVA: 0x0001D166 File Offset: 0x0001B366
		public unsafe Coroutine purchaseCoroutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSignal_UseVendingMachine.NativeFieldInfoPtr_purchaseCoroutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSignal_UseVendingMachine.NativeFieldInfoPtr_purchaseCoroutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011EE RID: 4590
		// (get) Token: 0x0600384C RID: 14412 RVA: 0x0012715C File Offset: 0x0012535C
		// (set) Token: 0x0600384D RID: 14413 RVA: 0x0001D185 File Offset: 0x0001B385
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSignal_UseVendingMachine.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSignal_UseVendingMachine.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x170011EF RID: 4591
		// (get) Token: 0x0600384E RID: 14414 RVA: 0x00127184 File Offset: 0x00125384
		// (set) Token: 0x0600384F RID: 14415 RVA: 0x0001D1A0 File Offset: 0x0001B3A0
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSignal_UseVendingMachine.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSignal_UseVendingMachine.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x040024FB RID: 9467
		private static readonly IntPtr NativeFieldInfoPtr_destinationThreshold;

		// Token: 0x040024FC RID: 9468
		private static readonly IntPtr NativeFieldInfoPtr_MachineOverride;

		// Token: 0x040024FD RID: 9469
		private static readonly IntPtr NativeFieldInfoPtr_TargetMachine;

		// Token: 0x040024FE RID: 9470
		private static readonly IntPtr NativeFieldInfoPtr_purchaseCoroutine;

		// Token: 0x040024FF RID: 9471
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04002500 RID: 9472
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04002501 RID: 9473
		private static readonly IntPtr NativeMethodInfoPtr_get_ActionName_Public_get_String_0;

		// Token: 0x04002502 RID: 9474
		private static readonly IntPtr NativeMethodInfoPtr_GetName_Public_Virtual_String_0;

		// Token: 0x04002503 RID: 9475
		private static readonly IntPtr NativeMethodInfoPtr_Started_Public_Virtual_Void_0;

		// Token: 0x04002504 RID: 9476
		private static readonly IntPtr NativeMethodInfoPtr_MinPassed_Public_Virtual_Void_0;

		// Token: 0x04002505 RID: 9477
		private static readonly IntPtr NativeMethodInfoPtr_LateStarted_Public_Virtual_Void_0;

		// Token: 0x04002506 RID: 9478
		private static readonly IntPtr NativeMethodInfoPtr_Interrupt_Public_Virtual_Void_0;

		// Token: 0x04002507 RID: 9479
		private static readonly IntPtr NativeMethodInfoPtr_Resume_Public_Virtual_Void_0;

		// Token: 0x04002508 RID: 9480
		private static readonly IntPtr NativeMethodInfoPtr_Skipped_Public_Virtual_Void_0;

		// Token: 0x04002509 RID: 9481
		private static readonly IntPtr NativeMethodInfoPtr_IsAtDestination_Private_Boolean_0;

		// Token: 0x0400250A RID: 9482
		private static readonly IntPtr NativeMethodInfoPtr_GetTargetMachine_Private_VendingMachine_0;

		// Token: 0x0400250B RID: 9483
		private static readonly IntPtr NativeMethodInfoPtr_WalkCallback_Protected_Virtual_Void_WalkResult_0;

		// Token: 0x0400250C RID: 9484
		private static readonly IntPtr NativeMethodInfoPtr_Purchase_Public_Void_0;

		// Token: 0x0400250D RID: 9485
		private static readonly IntPtr NativeMethodInfoPtr_CheckItem_Private_Boolean_0;

		// Token: 0x0400250E RID: 9486
		private static readonly IntPtr NativeMethodInfoPtr_ItemWasStolen_Private_Void_0;

		// Token: 0x0400250F RID: 9487
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002510 RID: 9488
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x04002511 RID: 9489
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04002512 RID: 9490
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04002513 RID: 9491
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04002514 RID: 9492
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_Purchase_2166136261_Private_Void_0;

		// Token: 0x04002515 RID: 9493
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___Purchase_2166136261_Public_Void_0;

		// Token: 0x04002516 RID: 9494
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_Purchase_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x04002517 RID: 9495
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x02000933 RID: 2355
		[ObfuscatedName("ScheduleOne.NPCs.Schedules.NPCSignal_UseVendingMachine+<<Purchase>g__Purchase|16_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPObObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600C70C RID: 50956 RVA: 0x00304DD4 File Offset: 0x00302FD4
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPObObUnique()
			{
				Il2CppClassPointerStore<NPCSignal_UseVendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NPCSignal_UseVendingMachine>.NativeClassPtr, "<<Purchase>g__Purchase|16_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCSignal_UseVendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPObObUnique>.NativeClassPtr);
				NPCSignal_UseVendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCSignal_UseVendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPObObUnique>.NativeClassPtr, "<>1__state");
				NPCSignal_UseVendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCSignal_UseVendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPObObUnique>.NativeClassPtr, "<>2__current");
				NPCSignal_UseVendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCSignal_UseVendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPObObUnique>.NativeClassPtr, "<>4__this");
				NPCSignal_UseVendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSignal_UseVendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPObObUnique>.NativeClassPtr, 100669820);
				NPCSignal_UseVendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSignal_UseVendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPObObUnique>.NativeClassPtr, 100669821);
				NPCSignal_UseVendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSignal_UseVendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPObObUnique>.NativeClassPtr, 100669822);
				NPCSignal_UseVendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSignal_UseVendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPObObUnique>.NativeClassPtr, 100669823);
				NPCSignal_UseVendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSignal_UseVendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPObObUnique>.NativeClassPtr, 100669824);
				NPCSignal_UseVendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSignal_UseVendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPObObUnique>.NativeClassPtr, 100669825);
			}

			// Token: 0x0600C70D RID: 50957 RVA: 0x00304EB4 File Offset: 0x003030B4
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCSignal_UseVendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPObObUnique>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCSignal_UseVendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C70E RID: 50958 RVA: 0x00304EFC File Offset: 0x003030FC
			[CallerCount(13604)]
			[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCSignal_UseVendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C70F RID: 50959 RVA: 0x00304F30 File Offset: 0x00303130
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141080, XrefRangeEnd = 141088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCSignal_UseVendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003E09 RID: 15881
			// (get) Token: 0x0600C710 RID: 50960 RVA: 0x00304F6C File Offset: 0x0030316C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCSignal_UseVendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600C711 RID: 50961 RVA: 0x00304FAC File Offset: 0x003031AC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141088, XrefRangeEnd = 141093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCSignal_UseVendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003E0A RID: 15882
			// (get) Token: 0x0600C712 RID: 50962 RVA: 0x00304FE0 File Offset: 0x003031E0
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCSignal_UseVendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600C713 RID: 50963 RVA: 0x00060E23 File Offset: 0x0005F023
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPObObUnique(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003E06 RID: 15878
			// (get) Token: 0x0600C714 RID: 50964 RVA: 0x00305020 File Offset: 0x00303220
			// (set) Token: 0x0600C715 RID: 50965 RVA: 0x00060E2C File Offset: 0x0005F02C
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSignal_UseVendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSignal_UseVendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003E07 RID: 15879
			// (get) Token: 0x0600C716 RID: 50966 RVA: 0x00305048 File Offset: 0x00303248
			// (set) Token: 0x0600C717 RID: 50967 RVA: 0x00060E47 File Offset: 0x0005F047
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSignal_UseVendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPObObUnique.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSignal_UseVendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003E08 RID: 15880
			// (get) Token: 0x0600C718 RID: 50968 RVA: 0x00305078 File Offset: 0x00303278
			// (set) Token: 0x0600C719 RID: 50969 RVA: 0x00060E66 File Offset: 0x0005F066
			public unsafe NPCSignal_UseVendingMachine __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSignal_UseVendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPObObUnique.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPCSignal_UseVendingMachine>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSignal_UseVendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040086B2 RID: 34482
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040086B3 RID: 34483
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040086B4 RID: 34484
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040086B5 RID: 34485
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040086B6 RID: 34486
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040086B7 RID: 34487
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040086B8 RID: 34488
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040086B9 RID: 34489
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040086BA RID: 34490
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
