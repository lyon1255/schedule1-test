using System;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Employees;
using Il2CppScheduleOne.Trash;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.NPCs.Behaviour
{
	// Token: 0x0200034E RID: 846
	public class PickUpTrashBehaviour : Behaviour
	{
		// Token: 0x06003FFB RID: 16379 RVA: 0x001425E8 File Offset: 0x001407E8
		// Note: this type is marked as 'beforefieldinit'.
		static PickUpTrashBehaviour()
		{
			Il2CppClassPointerStore<PickUpTrashBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.Behaviour", "PickUpTrashBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PickUpTrashBehaviour>.NativeClassPtr);
			PickUpTrashBehaviour.NativeFieldInfoPtr_ACTION_MAX_DISTANCE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PickUpTrashBehaviour>.NativeClassPtr, "ACTION_MAX_DISTANCE");
			PickUpTrashBehaviour.NativeFieldInfoPtr_EQUIPPABLE_ASSET_PATH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PickUpTrashBehaviour>.NativeClassPtr, "EQUIPPABLE_ASSET_PATH");
			PickUpTrashBehaviour.NativeFieldInfoPtr__TargetTrash_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PickUpTrashBehaviour>.NativeClassPtr, "<TargetTrash>k__BackingField");
			PickUpTrashBehaviour.NativeFieldInfoPtr_actionCoroutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PickUpTrashBehaviour>.NativeClassPtr, "actionCoroutine");
			PickUpTrashBehaviour.NativeFieldInfoPtr_onPerfomAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PickUpTrashBehaviour>.NativeClassPtr, "onPerfomAction");
			PickUpTrashBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PickUpTrashBehaviour>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.PickUpTrashBehaviourAssembly-CSharp.dll_Excuted");
			PickUpTrashBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PickUpTrashBehaviour>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.NPCs.Behaviour.PickUpTrashBehaviourAssembly-CSharp.dll_Excuted");
			PickUpTrashBehaviour.NativeMethodInfoPtr_get_TargetTrash_Public_get_TrashItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PickUpTrashBehaviour>.NativeClassPtr, 100670956);
			PickUpTrashBehaviour.NativeMethodInfoPtr_set_TargetTrash_Private_set_Void_TrashItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PickUpTrashBehaviour>.NativeClassPtr, 100670957);
			PickUpTrashBehaviour.NativeMethodInfoPtr_get_Cleaner_Private_get_Cleaner_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PickUpTrashBehaviour>.NativeClassPtr, 100670958);
			PickUpTrashBehaviour.NativeMethodInfoPtr_SetTargetTrash_Public_Void_TrashItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PickUpTrashBehaviour>.NativeClassPtr, 100670959);
			PickUpTrashBehaviour.NativeMethodInfoPtr_Begin_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PickUpTrashBehaviour>.NativeClassPtr, 100670960);
			PickUpTrashBehaviour.NativeMethodInfoPtr_Resume_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PickUpTrashBehaviour>.NativeClassPtr, 100670961);
			PickUpTrashBehaviour.NativeMethodInfoPtr_StartAction_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PickUpTrashBehaviour>.NativeClassPtr, 100670962);
			PickUpTrashBehaviour.NativeMethodInfoPtr_Pause_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PickUpTrashBehaviour>.NativeClassPtr, 100670963);
			PickUpTrashBehaviour.NativeMethodInfoPtr_Disable_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PickUpTrashBehaviour>.NativeClassPtr, 100670964);
			PickUpTrashBehaviour.NativeMethodInfoPtr_End_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PickUpTrashBehaviour>.NativeClassPtr, 100670965);
			PickUpTrashBehaviour.NativeMethodInfoPtr_StopAllActions_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PickUpTrashBehaviour>.NativeClassPtr, 100670966);
			PickUpTrashBehaviour.NativeMethodInfoPtr_ActiveMinPass_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PickUpTrashBehaviour>.NativeClassPtr, 100670967);
			PickUpTrashBehaviour.NativeMethodInfoPtr_GoToTarget_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PickUpTrashBehaviour>.NativeClassPtr, 100670968);
			PickUpTrashBehaviour.NativeMethodInfoPtr_PerformAction_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PickUpTrashBehaviour>.NativeClassPtr, 100670969);
			PickUpTrashBehaviour.NativeMethodInfoPtr_IsAtDestination_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PickUpTrashBehaviour>.NativeClassPtr, 100670970);
			PickUpTrashBehaviour.NativeMethodInfoPtr_AreActionConditionsMet_Private_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PickUpTrashBehaviour>.NativeClassPtr, 100670971);
			PickUpTrashBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PickUpTrashBehaviour>.NativeClassPtr, 100670972);
			PickUpTrashBehaviour.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PickUpTrashBehaviour>.NativeClassPtr, 100670973);
			PickUpTrashBehaviour.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PickUpTrashBehaviour>.NativeClassPtr, 100670974);
			PickUpTrashBehaviour.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PickUpTrashBehaviour>.NativeClassPtr, 100670975);
			PickUpTrashBehaviour.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PickUpTrashBehaviour>.NativeClassPtr, 100670976);
			PickUpTrashBehaviour.NativeMethodInfoPtr_RpcWriter___Observers_PerformAction_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PickUpTrashBehaviour>.NativeClassPtr, 100670977);
			PickUpTrashBehaviour.NativeMethodInfoPtr_RpcLogic___PerformAction_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PickUpTrashBehaviour>.NativeClassPtr, 100670978);
			PickUpTrashBehaviour.NativeMethodInfoPtr_RpcReader___Observers_PerformAction_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PickUpTrashBehaviour>.NativeClassPtr, 100670979);
			PickUpTrashBehaviour.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PickUpTrashBehaviour>.NativeClassPtr, 100670980);
		}

		// Token: 0x1700139B RID: 5019
		// (get) Token: 0x06003FFC RID: 16380 RVA: 0x00142898 File Offset: 0x00140A98
		// (set) Token: 0x06003FFD RID: 16381 RVA: 0x001428D8 File Offset: 0x00140AD8
		public unsafe TrashItem TargetTrash
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PickUpTrashBehaviour.NativeMethodInfoPtr_get_TargetTrash_Public_get_TrashItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TrashItem>(intPtr3) : null;
			}
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 115138, RefRangeEnd = 115149, XrefRangeStart = 115138, XrefRangeEnd = 115149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PickUpTrashBehaviour.NativeMethodInfoPtr_set_TargetTrash_Private_set_Void_TrashItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700139C RID: 5020
		// (get) Token: 0x06003FFE RID: 16382 RVA: 0x0014291C File Offset: 0x00140B1C
		public unsafe Cleaner Cleaner
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 148893, RefRangeEnd = 148896, XrefRangeStart = 148890, XrefRangeEnd = 148893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PickUpTrashBehaviour.NativeMethodInfoPtr_get_Cleaner_Private_get_Cleaner_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Cleaner>(intPtr3) : null;
			}
		}

		// Token: 0x06003FFF RID: 16383 RVA: 0x0014295C File Offset: 0x00140B5C
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 115138, RefRangeEnd = 115149, XrefRangeStart = 115138, XrefRangeEnd = 115149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTargetTrash(TrashItem trash)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(trash);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PickUpTrashBehaviour.NativeMethodInfoPtr_SetTargetTrash_Public_Void_TrashItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004000 RID: 16384 RVA: 0x001429A0 File Offset: 0x00140BA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 148896, XrefRangeEnd = 148898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Begin()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PickUpTrashBehaviour.NativeMethodInfoPtr_Begin_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004001 RID: 16385 RVA: 0x001429DC File Offset: 0x00140BDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 148898, XrefRangeEnd = 148900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Resume()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PickUpTrashBehaviour.NativeMethodInfoPtr_Resume_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004002 RID: 16386 RVA: 0x00142A18 File Offset: 0x00140C18
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 148912, RefRangeEnd = 148914, XrefRangeStart = 148900, XrefRangeEnd = 148912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartAction()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PickUpTrashBehaviour.NativeMethodInfoPtr_StartAction_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004003 RID: 16387 RVA: 0x00142A4C File Offset: 0x00140C4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 148914, XrefRangeEnd = 148916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Pause()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PickUpTrashBehaviour.NativeMethodInfoPtr_Pause_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004004 RID: 16388 RVA: 0x00142A88 File Offset: 0x00140C88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Disable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PickUpTrashBehaviour.NativeMethodInfoPtr_Disable_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004005 RID: 16389 RVA: 0x00142AC4 File Offset: 0x00140CC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 148916, XrefRangeEnd = 148918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void End()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PickUpTrashBehaviour.NativeMethodInfoPtr_End_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004006 RID: 16390 RVA: 0x00142B00 File Offset: 0x00140D00
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 148928, RefRangeEnd = 148930, XrefRangeStart = 148918, XrefRangeEnd = 148928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopAllActions()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PickUpTrashBehaviour.NativeMethodInfoPtr_StopAllActions_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004007 RID: 16391 RVA: 0x00142B34 File Offset: 0x00140D34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 148930, XrefRangeEnd = 148959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ActiveMinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PickUpTrashBehaviour.NativeMethodInfoPtr_ActiveMinPass_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004008 RID: 16392 RVA: 0x00142B70 File Offset: 0x00140D70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 148959, XrefRangeEnd = 148970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GoToTarget()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PickUpTrashBehaviour.NativeMethodInfoPtr_GoToTarget_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004009 RID: 16393 RVA: 0x00142BA4 File Offset: 0x00140DA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 148970, XrefRangeEnd = 148991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PerformAction()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PickUpTrashBehaviour.NativeMethodInfoPtr_PerformAction_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600400A RID: 16394 RVA: 0x00142BD8 File Offset: 0x00140DD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsAtDestination()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PickUpTrashBehaviour.NativeMethodInfoPtr_IsAtDestination_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600400B RID: 16395 RVA: 0x00142C14 File Offset: 0x00140E14
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 149000, RefRangeEnd = 149003, XrefRangeStart = 148991, XrefRangeEnd = 149000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool AreActionConditionsMet(bool checkAccess)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref checkAccess;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PickUpTrashBehaviour.NativeMethodInfoPtr_AreActionConditionsMet_Private_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600400C RID: 16396 RVA: 0x00142C60 File Offset: 0x00140E60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PickUpTrashBehaviour() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PickUpTrashBehaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PickUpTrashBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600400D RID: 16397 RVA: 0x00142C9C File Offset: 0x00140E9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 149003, XrefRangeEnd = 149008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PickUpTrashBehaviour.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600400E RID: 16398 RVA: 0x00142CDC File Offset: 0x00140EDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 149008, XrefRangeEnd = 149016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PickUpTrashBehaviour.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600400F RID: 16399 RVA: 0x00142D18 File Offset: 0x00140F18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PickUpTrashBehaviour.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004010 RID: 16400 RVA: 0x00142D54 File Offset: 0x00140F54
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PickUpTrashBehaviour.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004011 RID: 16401 RVA: 0x00142D90 File Offset: 0x00140F90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 149016, XrefRangeEnd = 149034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_PerformAction_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PickUpTrashBehaviour.NativeMethodInfoPtr_RpcWriter___Observers_PerformAction_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004012 RID: 16402 RVA: 0x00142DC4 File Offset: 0x00140FC4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 149052, RefRangeEnd = 149054, XrefRangeStart = 149034, XrefRangeEnd = 149052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___PerformAction_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PickUpTrashBehaviour.NativeMethodInfoPtr_RpcLogic___PerformAction_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004013 RID: 16403 RVA: 0x00142DF8 File Offset: 0x00140FF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 149054, XrefRangeEnd = 149057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_PerformAction_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PickUpTrashBehaviour.NativeMethodInfoPtr_RpcReader___Observers_PerformAction_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004014 RID: 16404 RVA: 0x00142E48 File Offset: 0x00141048
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PickUpTrashBehaviour.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004015 RID: 16405 RVA: 0x0001FC9D File Offset: 0x0001DE9D
		public PickUpTrashBehaviour(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001394 RID: 5012
		// (get) Token: 0x06004016 RID: 16406 RVA: 0x00142E84 File Offset: 0x00141084
		// (set) Token: 0x06004017 RID: 16407 RVA: 0x0001FCA6 File Offset: 0x0001DEA6
		public unsafe static float ACTION_MAX_DISTANCE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PickUpTrashBehaviour.NativeFieldInfoPtr_ACTION_MAX_DISTANCE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PickUpTrashBehaviour.NativeFieldInfoPtr_ACTION_MAX_DISTANCE, (void*)(&value));
			}
		}

		// Token: 0x17001395 RID: 5013
		// (get) Token: 0x06004018 RID: 16408 RVA: 0x00142EA0 File Offset: 0x001410A0
		// (set) Token: 0x06004019 RID: 16409 RVA: 0x0001FCB4 File Offset: 0x0001DEB4
		public unsafe static string EQUIPPABLE_ASSET_PATH
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PickUpTrashBehaviour.NativeFieldInfoPtr_EQUIPPABLE_ASSET_PATH, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PickUpTrashBehaviour.NativeFieldInfoPtr_EQUIPPABLE_ASSET_PATH, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001396 RID: 5014
		// (get) Token: 0x0600401A RID: 16410 RVA: 0x00142EC0 File Offset: 0x001410C0
		// (set) Token: 0x0600401B RID: 16411 RVA: 0x0001FCC6 File Offset: 0x0001DEC6
		public unsafe TrashItem _TargetTrash_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickUpTrashBehaviour.NativeFieldInfoPtr__TargetTrash_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TrashItem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickUpTrashBehaviour.NativeFieldInfoPtr__TargetTrash_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001397 RID: 5015
		// (get) Token: 0x0600401C RID: 16412 RVA: 0x00142EF0 File Offset: 0x001410F0
		// (set) Token: 0x0600401D RID: 16413 RVA: 0x0001FCE5 File Offset: 0x0001DEE5
		public unsafe Coroutine actionCoroutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickUpTrashBehaviour.NativeFieldInfoPtr_actionCoroutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickUpTrashBehaviour.NativeFieldInfoPtr_actionCoroutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001398 RID: 5016
		// (get) Token: 0x0600401E RID: 16414 RVA: 0x00142F20 File Offset: 0x00141120
		// (set) Token: 0x0600401F RID: 16415 RVA: 0x0001FD04 File Offset: 0x0001DF04
		public unsafe UnityEvent onPerfomAction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickUpTrashBehaviour.NativeFieldInfoPtr_onPerfomAction);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickUpTrashBehaviour.NativeFieldInfoPtr_onPerfomAction), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001399 RID: 5017
		// (get) Token: 0x06004020 RID: 16416 RVA: 0x00142F50 File Offset: 0x00141150
		// (set) Token: 0x06004021 RID: 16417 RVA: 0x0001FD23 File Offset: 0x0001DF23
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickUpTrashBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickUpTrashBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x1700139A RID: 5018
		// (get) Token: 0x06004022 RID: 16418 RVA: 0x00142F78 File Offset: 0x00141178
		// (set) Token: 0x06004023 RID: 16419 RVA: 0x0001FD3E File Offset: 0x0001DF3E
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickUpTrashBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickUpTrashBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04002A8E RID: 10894
		private static readonly IntPtr NativeFieldInfoPtr_ACTION_MAX_DISTANCE;

		// Token: 0x04002A8F RID: 10895
		private static readonly IntPtr NativeFieldInfoPtr_EQUIPPABLE_ASSET_PATH;

		// Token: 0x04002A90 RID: 10896
		private static readonly IntPtr NativeFieldInfoPtr__TargetTrash_k__BackingField;

		// Token: 0x04002A91 RID: 10897
		private static readonly IntPtr NativeFieldInfoPtr_actionCoroutine;

		// Token: 0x04002A92 RID: 10898
		private static readonly IntPtr NativeFieldInfoPtr_onPerfomAction;

		// Token: 0x04002A93 RID: 10899
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04002A94 RID: 10900
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04002A95 RID: 10901
		private static readonly IntPtr NativeMethodInfoPtr_get_TargetTrash_Public_get_TrashItem_0;

		// Token: 0x04002A96 RID: 10902
		private static readonly IntPtr NativeMethodInfoPtr_set_TargetTrash_Private_set_Void_TrashItem_0;

		// Token: 0x04002A97 RID: 10903
		private static readonly IntPtr NativeMethodInfoPtr_get_Cleaner_Private_get_Cleaner_0;

		// Token: 0x04002A98 RID: 10904
		private static readonly IntPtr NativeMethodInfoPtr_SetTargetTrash_Public_Void_TrashItem_0;

		// Token: 0x04002A99 RID: 10905
		private static readonly IntPtr NativeMethodInfoPtr_Begin_Protected_Virtual_Void_0;

		// Token: 0x04002A9A RID: 10906
		private static readonly IntPtr NativeMethodInfoPtr_Resume_Protected_Virtual_Void_0;

		// Token: 0x04002A9B RID: 10907
		private static readonly IntPtr NativeMethodInfoPtr_StartAction_Private_Void_0;

		// Token: 0x04002A9C RID: 10908
		private static readonly IntPtr NativeMethodInfoPtr_Pause_Protected_Virtual_Void_0;

		// Token: 0x04002A9D RID: 10909
		private static readonly IntPtr NativeMethodInfoPtr_Disable_Public_Virtual_Void_0;

		// Token: 0x04002A9E RID: 10910
		private static readonly IntPtr NativeMethodInfoPtr_End_Protected_Virtual_Void_0;

		// Token: 0x04002A9F RID: 10911
		private static readonly IntPtr NativeMethodInfoPtr_StopAllActions_Private_Void_0;

		// Token: 0x04002AA0 RID: 10912
		private static readonly IntPtr NativeMethodInfoPtr_ActiveMinPass_Public_Virtual_Void_0;

		// Token: 0x04002AA1 RID: 10913
		private static readonly IntPtr NativeMethodInfoPtr_GoToTarget_Private_Void_0;

		// Token: 0x04002AA2 RID: 10914
		private static readonly IntPtr NativeMethodInfoPtr_PerformAction_Private_Void_0;

		// Token: 0x04002AA3 RID: 10915
		private static readonly IntPtr NativeMethodInfoPtr_IsAtDestination_Private_Boolean_0;

		// Token: 0x04002AA4 RID: 10916
		private static readonly IntPtr NativeMethodInfoPtr_AreActionConditionsMet_Private_Boolean_Boolean_0;

		// Token: 0x04002AA5 RID: 10917
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002AA6 RID: 10918
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x04002AA7 RID: 10919
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04002AA8 RID: 10920
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04002AA9 RID: 10921
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04002AAA RID: 10922
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_PerformAction_2166136261_Private_Void_0;

		// Token: 0x04002AAB RID: 10923
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___PerformAction_2166136261_Private_Void_0;

		// Token: 0x04002AAC RID: 10924
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_PerformAction_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x04002AAD RID: 10925
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x0200094E RID: 2382
		[ObfuscatedName("ScheduleOne.NPCs.Behaviour.PickUpTrashBehaviour+<<PerformAction>g__Action|20_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPiObObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600C82D RID: 51245 RVA: 0x00308658 File Offset: 0x00306858
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPiObObUnique()
			{
				Il2CppClassPointerStore<PickUpTrashBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPiObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PickUpTrashBehaviour>.NativeClassPtr, "<<PerformAction>g__Action|20_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PickUpTrashBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPiObObUnique>.NativeClassPtr);
				PickUpTrashBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPiObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PickUpTrashBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPiObObUnique>.NativeClassPtr, "<>1__state");
				PickUpTrashBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPiObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PickUpTrashBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPiObObUnique>.NativeClassPtr, "<>2__current");
				PickUpTrashBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPiObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PickUpTrashBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPiObObUnique>.NativeClassPtr, "<>4__this");
				PickUpTrashBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PickUpTrashBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPiObObUnique>.NativeClassPtr, 100670981);
				PickUpTrashBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PickUpTrashBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPiObObUnique>.NativeClassPtr, 100670982);
				PickUpTrashBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PickUpTrashBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPiObObUnique>.NativeClassPtr, 100670983);
				PickUpTrashBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PickUpTrashBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPiObObUnique>.NativeClassPtr, 100670984);
				PickUpTrashBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PickUpTrashBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPiObObUnique>.NativeClassPtr, 100670985);
				PickUpTrashBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PickUpTrashBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPiObObUnique>.NativeClassPtr, 100670986);
			}

			// Token: 0x0600C82E RID: 51246 RVA: 0x00308738 File Offset: 0x00306938
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPiObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PickUpTrashBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPiObObUnique>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PickUpTrashBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C82F RID: 51247 RVA: 0x00308780 File Offset: 0x00306980
			[CallerCount(13604)]
			[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PickUpTrashBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C830 RID: 51248 RVA: 0x003087B4 File Offset: 0x003069B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 148881, XrefRangeEnd = 148885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PickUpTrashBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003E6D RID: 15981
			// (get) Token: 0x0600C831 RID: 51249 RVA: 0x003087F0 File Offset: 0x003069F0
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PickUpTrashBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600C832 RID: 51250 RVA: 0x00308830 File Offset: 0x00306A30
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 148885, XrefRangeEnd = 148890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PickUpTrashBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003E6E RID: 15982
			// (get) Token: 0x0600C833 RID: 51251 RVA: 0x00308864 File Offset: 0x00306A64
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PickUpTrashBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600C834 RID: 51252 RVA: 0x00061608 File Offset: 0x0005F808
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPiObObUnique(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003E6A RID: 15978
			// (get) Token: 0x0600C835 RID: 51253 RVA: 0x003088A4 File Offset: 0x00306AA4
			// (set) Token: 0x0600C836 RID: 51254 RVA: 0x00061611 File Offset: 0x0005F811
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickUpTrashBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPiObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickUpTrashBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPiObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003E6B RID: 15979
			// (get) Token: 0x0600C837 RID: 51255 RVA: 0x003088CC File Offset: 0x00306ACC
			// (set) Token: 0x0600C838 RID: 51256 RVA: 0x0006162C File Offset: 0x0005F82C
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickUpTrashBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPiObObUnique.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickUpTrashBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPiObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003E6C RID: 15980
			// (get) Token: 0x0600C839 RID: 51257 RVA: 0x003088FC File Offset: 0x00306AFC
			// (set) Token: 0x0600C83A RID: 51258 RVA: 0x0006164B File Offset: 0x0005F84B
			public unsafe PickUpTrashBehaviour __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickUpTrashBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPiObObUnique.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PickUpTrashBehaviour>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickUpTrashBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPiObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008779 RID: 34681
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400877A RID: 34682
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400877B RID: 34683
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400877C RID: 34684
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400877D RID: 34685
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400877E RID: 34686
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400877F RID: 34687
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008780 RID: 34688
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008781 RID: 34689
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
