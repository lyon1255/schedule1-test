using System;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Employees;
using Il2CppScheduleOne.ObjectScripts;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.NPCs.Behaviour
{
	// Token: 0x02000347 RID: 839
	public class BagTrashCanBehaviour : Behaviour
	{
		// Token: 0x06003EBE RID: 16062 RVA: 0x0013D8D0 File Offset: 0x0013BAD0
		// Note: this type is marked as 'beforefieldinit'.
		static BagTrashCanBehaviour()
		{
			Il2CppClassPointerStore<BagTrashCanBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.Behaviour", "BagTrashCanBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BagTrashCanBehaviour>.NativeClassPtr);
			BagTrashCanBehaviour.NativeFieldInfoPtr_ACTION_MAX_DISTANCE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BagTrashCanBehaviour>.NativeClassPtr, "ACTION_MAX_DISTANCE");
			BagTrashCanBehaviour.NativeFieldInfoPtr_BAG_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BagTrashCanBehaviour>.NativeClassPtr, "BAG_TIME");
			BagTrashCanBehaviour.NativeFieldInfoPtr__TargetTrashCan_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BagTrashCanBehaviour>.NativeClassPtr, "<TargetTrashCan>k__BackingField");
			BagTrashCanBehaviour.NativeFieldInfoPtr_actionCoroutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BagTrashCanBehaviour>.NativeClassPtr, "actionCoroutine");
			BagTrashCanBehaviour.NativeFieldInfoPtr_onPerfomAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BagTrashCanBehaviour>.NativeClassPtr, "onPerfomAction");
			BagTrashCanBehaviour.NativeFieldInfoPtr_onPerfomDone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BagTrashCanBehaviour>.NativeClassPtr, "onPerfomDone");
			BagTrashCanBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BagTrashCanBehaviour>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.BagTrashCanBehaviourAssembly-CSharp.dll_Excuted");
			BagTrashCanBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BagTrashCanBehaviour>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.NPCs.Behaviour.BagTrashCanBehaviourAssembly-CSharp.dll_Excuted");
			BagTrashCanBehaviour.NativeMethodInfoPtr_get_TargetTrashCan_Public_get_TrashContainerItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BagTrashCanBehaviour>.NativeClassPtr, 100670695);
			BagTrashCanBehaviour.NativeMethodInfoPtr_set_TargetTrashCan_Private_set_Void_TrashContainerItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BagTrashCanBehaviour>.NativeClassPtr, 100670696);
			BagTrashCanBehaviour.NativeMethodInfoPtr_get_Cleaner_Private_get_Cleaner_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BagTrashCanBehaviour>.NativeClassPtr, 100670697);
			BagTrashCanBehaviour.NativeMethodInfoPtr_SetTargetTrashCan_Public_Void_TrashContainerItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BagTrashCanBehaviour>.NativeClassPtr, 100670698);
			BagTrashCanBehaviour.NativeMethodInfoPtr_Begin_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BagTrashCanBehaviour>.NativeClassPtr, 100670699);
			BagTrashCanBehaviour.NativeMethodInfoPtr_Resume_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BagTrashCanBehaviour>.NativeClassPtr, 100670700);
			BagTrashCanBehaviour.NativeMethodInfoPtr_StartAction_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BagTrashCanBehaviour>.NativeClassPtr, 100670701);
			BagTrashCanBehaviour.NativeMethodInfoPtr_Pause_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BagTrashCanBehaviour>.NativeClassPtr, 100670702);
			BagTrashCanBehaviour.NativeMethodInfoPtr_Disable_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BagTrashCanBehaviour>.NativeClassPtr, 100670703);
			BagTrashCanBehaviour.NativeMethodInfoPtr_End_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BagTrashCanBehaviour>.NativeClassPtr, 100670704);
			BagTrashCanBehaviour.NativeMethodInfoPtr_StopAllActions_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BagTrashCanBehaviour>.NativeClassPtr, 100670705);
			BagTrashCanBehaviour.NativeMethodInfoPtr_ActiveMinPass_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BagTrashCanBehaviour>.NativeClassPtr, 100670706);
			BagTrashCanBehaviour.NativeMethodInfoPtr_GoToTarget_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BagTrashCanBehaviour>.NativeClassPtr, 100670707);
			BagTrashCanBehaviour.NativeMethodInfoPtr_PerformAction_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BagTrashCanBehaviour>.NativeClassPtr, 100670708);
			BagTrashCanBehaviour.NativeMethodInfoPtr_IsAtDestination_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BagTrashCanBehaviour>.NativeClassPtr, 100670709);
			BagTrashCanBehaviour.NativeMethodInfoPtr_AreActionConditionsMet_Private_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BagTrashCanBehaviour>.NativeClassPtr, 100670710);
			BagTrashCanBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BagTrashCanBehaviour>.NativeClassPtr, 100670711);
			BagTrashCanBehaviour.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BagTrashCanBehaviour>.NativeClassPtr, 100670712);
			BagTrashCanBehaviour.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BagTrashCanBehaviour>.NativeClassPtr, 100670713);
			BagTrashCanBehaviour.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BagTrashCanBehaviour>.NativeClassPtr, 100670714);
			BagTrashCanBehaviour.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BagTrashCanBehaviour>.NativeClassPtr, 100670715);
			BagTrashCanBehaviour.NativeMethodInfoPtr_RpcWriter___Observers_PerformAction_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BagTrashCanBehaviour>.NativeClassPtr, 100670716);
			BagTrashCanBehaviour.NativeMethodInfoPtr_RpcLogic___PerformAction_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BagTrashCanBehaviour>.NativeClassPtr, 100670717);
			BagTrashCanBehaviour.NativeMethodInfoPtr_RpcReader___Observers_PerformAction_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BagTrashCanBehaviour>.NativeClassPtr, 100670718);
			BagTrashCanBehaviour.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BagTrashCanBehaviour>.NativeClassPtr, 100670719);
		}

		// Token: 0x1700135A RID: 4954
		// (get) Token: 0x06003EBF RID: 16063 RVA: 0x0013DB94 File Offset: 0x0013BD94
		// (set) Token: 0x06003EC0 RID: 16064 RVA: 0x0013DBD4 File Offset: 0x0013BDD4
		public unsafe TrashContainerItem TargetTrashCan
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BagTrashCanBehaviour.NativeMethodInfoPtr_get_TargetTrashCan_Public_get_TrashContainerItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TrashContainerItem>(intPtr3) : null;
			}
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 115138, RefRangeEnd = 115149, XrefRangeStart = 115138, XrefRangeEnd = 115149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BagTrashCanBehaviour.NativeMethodInfoPtr_set_TargetTrashCan_Private_set_Void_TrashContainerItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700135B RID: 4955
		// (get) Token: 0x06003EC1 RID: 16065 RVA: 0x0013DC18 File Offset: 0x0013BE18
		public unsafe Cleaner Cleaner
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 147024, XrefRangeEnd = 147027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BagTrashCanBehaviour.NativeMethodInfoPtr_get_Cleaner_Private_get_Cleaner_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Cleaner>(intPtr3) : null;
			}
		}

		// Token: 0x06003EC2 RID: 16066 RVA: 0x0013DC58 File Offset: 0x0013BE58
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 115138, RefRangeEnd = 115149, XrefRangeStart = 115138, XrefRangeEnd = 115149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTargetTrashCan(TrashContainerItem trashCan)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(trashCan);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BagTrashCanBehaviour.NativeMethodInfoPtr_SetTargetTrashCan_Public_Void_TrashContainerItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003EC3 RID: 16067 RVA: 0x0013DC9C File Offset: 0x0013BE9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 147027, XrefRangeEnd = 147029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Begin()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BagTrashCanBehaviour.NativeMethodInfoPtr_Begin_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003EC4 RID: 16068 RVA: 0x0013DCD8 File Offset: 0x0013BED8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 147029, XrefRangeEnd = 147031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Resume()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BagTrashCanBehaviour.NativeMethodInfoPtr_Resume_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003EC5 RID: 16069 RVA: 0x0013DD14 File Offset: 0x0013BF14
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 147040, RefRangeEnd = 147042, XrefRangeStart = 147031, XrefRangeEnd = 147040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartAction()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BagTrashCanBehaviour.NativeMethodInfoPtr_StartAction_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003EC6 RID: 16070 RVA: 0x0013DD48 File Offset: 0x0013BF48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 147042, XrefRangeEnd = 147044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Pause()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BagTrashCanBehaviour.NativeMethodInfoPtr_Pause_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003EC7 RID: 16071 RVA: 0x0013DD84 File Offset: 0x0013BF84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 147044, XrefRangeEnd = 147045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Disable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BagTrashCanBehaviour.NativeMethodInfoPtr_Disable_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003EC8 RID: 16072 RVA: 0x0013DDC0 File Offset: 0x0013BFC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 147045, XrefRangeEnd = 147047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void End()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BagTrashCanBehaviour.NativeMethodInfoPtr_End_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003EC9 RID: 16073 RVA: 0x0013DDFC File Offset: 0x0013BFFC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 147063, RefRangeEnd = 147065, XrefRangeStart = 147047, XrefRangeEnd = 147063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopAllActions()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BagTrashCanBehaviour.NativeMethodInfoPtr_StopAllActions_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003ECA RID: 16074 RVA: 0x0013DE30 File Offset: 0x0013C030
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 147065, XrefRangeEnd = 147088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ActiveMinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BagTrashCanBehaviour.NativeMethodInfoPtr_ActiveMinPass_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003ECB RID: 16075 RVA: 0x0013DE6C File Offset: 0x0013C06C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 147088, XrefRangeEnd = 147096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GoToTarget()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BagTrashCanBehaviour.NativeMethodInfoPtr_GoToTarget_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003ECC RID: 16076 RVA: 0x0013DEA0 File Offset: 0x0013C0A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 147096, XrefRangeEnd = 147117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PerformAction()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BagTrashCanBehaviour.NativeMethodInfoPtr_PerformAction_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003ECD RID: 16077 RVA: 0x0013DED4 File Offset: 0x0013C0D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 147117, XrefRangeEnd = 147127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsAtDestination()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BagTrashCanBehaviour.NativeMethodInfoPtr_IsAtDestination_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003ECE RID: 16078 RVA: 0x0013DF10 File Offset: 0x0013C110
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 147143, RefRangeEnd = 147146, XrefRangeStart = 147127, XrefRangeEnd = 147143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool AreActionConditionsMet(bool checkAccess)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref checkAccess;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BagTrashCanBehaviour.NativeMethodInfoPtr_AreActionConditionsMet_Private_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003ECF RID: 16079 RVA: 0x0013DF5C File Offset: 0x0013C15C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BagTrashCanBehaviour() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BagTrashCanBehaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BagTrashCanBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003ED0 RID: 16080 RVA: 0x0013DF98 File Offset: 0x0013C198
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 147146, XrefRangeEnd = 147151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BagTrashCanBehaviour.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06003ED1 RID: 16081 RVA: 0x0013DFD8 File Offset: 0x0013C1D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 147151, XrefRangeEnd = 147159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BagTrashCanBehaviour.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003ED2 RID: 16082 RVA: 0x0013E014 File Offset: 0x0013C214
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 147159, XrefRangeEnd = 147160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BagTrashCanBehaviour.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003ED3 RID: 16083 RVA: 0x0013E050 File Offset: 0x0013C250
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BagTrashCanBehaviour.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003ED4 RID: 16084 RVA: 0x0013E08C File Offset: 0x0013C28C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 147160, XrefRangeEnd = 147178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_PerformAction_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BagTrashCanBehaviour.NativeMethodInfoPtr_RpcWriter___Observers_PerformAction_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003ED5 RID: 16085 RVA: 0x0013E0C0 File Offset: 0x0013C2C0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 147189, RefRangeEnd = 147191, XrefRangeStart = 147178, XrefRangeEnd = 147189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___PerformAction_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BagTrashCanBehaviour.NativeMethodInfoPtr_RpcLogic___PerformAction_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003ED6 RID: 16086 RVA: 0x0013E0F4 File Offset: 0x0013C2F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 147191, XrefRangeEnd = 147194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_PerformAction_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BagTrashCanBehaviour.NativeMethodInfoPtr_RpcReader___Observers_PerformAction_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003ED7 RID: 16087 RVA: 0x0013E144 File Offset: 0x0013C344
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BagTrashCanBehaviour.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003ED8 RID: 16088 RVA: 0x0001F6AC File Offset: 0x0001D8AC
		public BagTrashCanBehaviour(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001352 RID: 4946
		// (get) Token: 0x06003ED9 RID: 16089 RVA: 0x0013E180 File Offset: 0x0013C380
		// (set) Token: 0x06003EDA RID: 16090 RVA: 0x0001F6B5 File Offset: 0x0001D8B5
		public unsafe static float ACTION_MAX_DISTANCE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(BagTrashCanBehaviour.NativeFieldInfoPtr_ACTION_MAX_DISTANCE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BagTrashCanBehaviour.NativeFieldInfoPtr_ACTION_MAX_DISTANCE, (void*)(&value));
			}
		}

		// Token: 0x17001353 RID: 4947
		// (get) Token: 0x06003EDB RID: 16091 RVA: 0x0013E19C File Offset: 0x0013C39C
		// (set) Token: 0x06003EDC RID: 16092 RVA: 0x0001F6C3 File Offset: 0x0001D8C3
		public unsafe static float BAG_TIME
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(BagTrashCanBehaviour.NativeFieldInfoPtr_BAG_TIME, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BagTrashCanBehaviour.NativeFieldInfoPtr_BAG_TIME, (void*)(&value));
			}
		}

		// Token: 0x17001354 RID: 4948
		// (get) Token: 0x06003EDD RID: 16093 RVA: 0x0013E1B8 File Offset: 0x0013C3B8
		// (set) Token: 0x06003EDE RID: 16094 RVA: 0x0001F6D1 File Offset: 0x0001D8D1
		public unsafe TrashContainerItem _TargetTrashCan_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BagTrashCanBehaviour.NativeFieldInfoPtr__TargetTrashCan_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TrashContainerItem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BagTrashCanBehaviour.NativeFieldInfoPtr__TargetTrashCan_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001355 RID: 4949
		// (get) Token: 0x06003EDF RID: 16095 RVA: 0x0013E1E8 File Offset: 0x0013C3E8
		// (set) Token: 0x06003EE0 RID: 16096 RVA: 0x0001F6F0 File Offset: 0x0001D8F0
		public unsafe Coroutine actionCoroutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BagTrashCanBehaviour.NativeFieldInfoPtr_actionCoroutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BagTrashCanBehaviour.NativeFieldInfoPtr_actionCoroutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001356 RID: 4950
		// (get) Token: 0x06003EE1 RID: 16097 RVA: 0x0013E218 File Offset: 0x0013C418
		// (set) Token: 0x06003EE2 RID: 16098 RVA: 0x0001F70F File Offset: 0x0001D90F
		public unsafe UnityEvent onPerfomAction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BagTrashCanBehaviour.NativeFieldInfoPtr_onPerfomAction);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BagTrashCanBehaviour.NativeFieldInfoPtr_onPerfomAction), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001357 RID: 4951
		// (get) Token: 0x06003EE3 RID: 16099 RVA: 0x0013E248 File Offset: 0x0013C448
		// (set) Token: 0x06003EE4 RID: 16100 RVA: 0x0001F72E File Offset: 0x0001D92E
		public unsafe UnityEvent onPerfomDone
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BagTrashCanBehaviour.NativeFieldInfoPtr_onPerfomDone);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BagTrashCanBehaviour.NativeFieldInfoPtr_onPerfomDone), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001358 RID: 4952
		// (get) Token: 0x06003EE5 RID: 16101 RVA: 0x0013E278 File Offset: 0x0013C478
		// (set) Token: 0x06003EE6 RID: 16102 RVA: 0x0001F74D File Offset: 0x0001D94D
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BagTrashCanBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BagTrashCanBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17001359 RID: 4953
		// (get) Token: 0x06003EE7 RID: 16103 RVA: 0x0013E2A0 File Offset: 0x0013C4A0
		// (set) Token: 0x06003EE8 RID: 16104 RVA: 0x0001F768 File Offset: 0x0001D968
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BagTrashCanBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BagTrashCanBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04002995 RID: 10645
		private static readonly IntPtr NativeFieldInfoPtr_ACTION_MAX_DISTANCE;

		// Token: 0x04002996 RID: 10646
		private static readonly IntPtr NativeFieldInfoPtr_BAG_TIME;

		// Token: 0x04002997 RID: 10647
		private static readonly IntPtr NativeFieldInfoPtr__TargetTrashCan_k__BackingField;

		// Token: 0x04002998 RID: 10648
		private static readonly IntPtr NativeFieldInfoPtr_actionCoroutine;

		// Token: 0x04002999 RID: 10649
		private static readonly IntPtr NativeFieldInfoPtr_onPerfomAction;

		// Token: 0x0400299A RID: 10650
		private static readonly IntPtr NativeFieldInfoPtr_onPerfomDone;

		// Token: 0x0400299B RID: 10651
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x0400299C RID: 10652
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x0400299D RID: 10653
		private static readonly IntPtr NativeMethodInfoPtr_get_TargetTrashCan_Public_get_TrashContainerItem_0;

		// Token: 0x0400299E RID: 10654
		private static readonly IntPtr NativeMethodInfoPtr_set_TargetTrashCan_Private_set_Void_TrashContainerItem_0;

		// Token: 0x0400299F RID: 10655
		private static readonly IntPtr NativeMethodInfoPtr_get_Cleaner_Private_get_Cleaner_0;

		// Token: 0x040029A0 RID: 10656
		private static readonly IntPtr NativeMethodInfoPtr_SetTargetTrashCan_Public_Void_TrashContainerItem_0;

		// Token: 0x040029A1 RID: 10657
		private static readonly IntPtr NativeMethodInfoPtr_Begin_Protected_Virtual_Void_0;

		// Token: 0x040029A2 RID: 10658
		private static readonly IntPtr NativeMethodInfoPtr_Resume_Protected_Virtual_Void_0;

		// Token: 0x040029A3 RID: 10659
		private static readonly IntPtr NativeMethodInfoPtr_StartAction_Private_Void_0;

		// Token: 0x040029A4 RID: 10660
		private static readonly IntPtr NativeMethodInfoPtr_Pause_Protected_Virtual_Void_0;

		// Token: 0x040029A5 RID: 10661
		private static readonly IntPtr NativeMethodInfoPtr_Disable_Public_Virtual_Void_0;

		// Token: 0x040029A6 RID: 10662
		private static readonly IntPtr NativeMethodInfoPtr_End_Protected_Virtual_Void_0;

		// Token: 0x040029A7 RID: 10663
		private static readonly IntPtr NativeMethodInfoPtr_StopAllActions_Private_Void_0;

		// Token: 0x040029A8 RID: 10664
		private static readonly IntPtr NativeMethodInfoPtr_ActiveMinPass_Public_Virtual_Void_0;

		// Token: 0x040029A9 RID: 10665
		private static readonly IntPtr NativeMethodInfoPtr_GoToTarget_Private_Void_0;

		// Token: 0x040029AA RID: 10666
		private static readonly IntPtr NativeMethodInfoPtr_PerformAction_Private_Void_0;

		// Token: 0x040029AB RID: 10667
		private static readonly IntPtr NativeMethodInfoPtr_IsAtDestination_Private_Boolean_0;

		// Token: 0x040029AC RID: 10668
		private static readonly IntPtr NativeMethodInfoPtr_AreActionConditionsMet_Private_Boolean_Boolean_0;

		// Token: 0x040029AD RID: 10669
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040029AE RID: 10670
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x040029AF RID: 10671
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x040029B0 RID: 10672
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x040029B1 RID: 10673
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x040029B2 RID: 10674
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_PerformAction_2166136261_Private_Void_0;

		// Token: 0x040029B3 RID: 10675
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___PerformAction_2166136261_Private_Void_0;

		// Token: 0x040029B4 RID: 10676
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_PerformAction_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x040029B5 RID: 10677
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x02000942 RID: 2370
		[ObfuscatedName("ScheduleOne.NPCs.Behaviour.BagTrashCanBehaviour+<<PerformAction>g__Action|21_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBaObObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600C78B RID: 51083 RVA: 0x0030664C File Offset: 0x0030484C
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBaObObUnique()
			{
				Il2CppClassPointerStore<BagTrashCanBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBaObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BagTrashCanBehaviour>.NativeClassPtr, "<<PerformAction>g__Action|21_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BagTrashCanBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBaObObUnique>.NativeClassPtr);
				BagTrashCanBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBaObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BagTrashCanBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBaObObUnique>.NativeClassPtr, "<>1__state");
				BagTrashCanBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBaObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BagTrashCanBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBaObObUnique>.NativeClassPtr, "<>2__current");
				BagTrashCanBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBaObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BagTrashCanBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBaObObUnique>.NativeClassPtr, "<>4__this");
				BagTrashCanBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBaObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BagTrashCanBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBaObObUnique>.NativeClassPtr, 100670720);
				BagTrashCanBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBaObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BagTrashCanBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBaObObUnique>.NativeClassPtr, 100670721);
				BagTrashCanBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBaObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BagTrashCanBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBaObObUnique>.NativeClassPtr, 100670722);
				BagTrashCanBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBaObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BagTrashCanBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBaObObUnique>.NativeClassPtr, 100670723);
				BagTrashCanBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBaObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BagTrashCanBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBaObObUnique>.NativeClassPtr, 100670724);
				BagTrashCanBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBaObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BagTrashCanBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBaObObUnique>.NativeClassPtr, 100670725);
			}

			// Token: 0x0600C78C RID: 51084 RVA: 0x0030672C File Offset: 0x0030492C
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBaObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BagTrashCanBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBaObObUnique>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BagTrashCanBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBaObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C78D RID: 51085 RVA: 0x00306774 File Offset: 0x00304974
			[CallerCount(13604)]
			[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BagTrashCanBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBaObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C78E RID: 51086 RVA: 0x003067A8 File Offset: 0x003049A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 147015, XrefRangeEnd = 147019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BagTrashCanBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBaObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003E32 RID: 15922
			// (get) Token: 0x0600C78F RID: 51087 RVA: 0x003067E4 File Offset: 0x003049E4
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BagTrashCanBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBaObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600C790 RID: 51088 RVA: 0x00306824 File Offset: 0x00304A24
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 147019, XrefRangeEnd = 147024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BagTrashCanBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBaObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003E33 RID: 15923
			// (get) Token: 0x0600C791 RID: 51089 RVA: 0x00306858 File Offset: 0x00304A58
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BagTrashCanBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBaObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600C792 RID: 51090 RVA: 0x00061166 File Offset: 0x0005F366
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBaObObUnique(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003E2F RID: 15919
			// (get) Token: 0x0600C793 RID: 51091 RVA: 0x00306898 File Offset: 0x00304A98
			// (set) Token: 0x0600C794 RID: 51092 RVA: 0x0006116F File Offset: 0x0005F36F
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BagTrashCanBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBaObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BagTrashCanBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBaObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003E30 RID: 15920
			// (get) Token: 0x0600C795 RID: 51093 RVA: 0x003068C0 File Offset: 0x00304AC0
			// (set) Token: 0x0600C796 RID: 51094 RVA: 0x0006118A File Offset: 0x0005F38A
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BagTrashCanBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBaObObUnique.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BagTrashCanBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBaObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003E31 RID: 15921
			// (get) Token: 0x0600C797 RID: 51095 RVA: 0x003068F0 File Offset: 0x00304AF0
			// (set) Token: 0x0600C798 RID: 51096 RVA: 0x000611A9 File Offset: 0x0005F3A9
			public unsafe BagTrashCanBehaviour __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BagTrashCanBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBaObObUnique.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BagTrashCanBehaviour>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BagTrashCanBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBaObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400870C RID: 34572
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400870D RID: 34573
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400870E RID: 34574
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400870F RID: 34575
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008710 RID: 34576
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008711 RID: 34577
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008712 RID: 34578
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008713 RID: 34579
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008714 RID: 34580
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
