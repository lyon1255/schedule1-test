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
	// Token: 0x0200034A RID: 842
	public class EmptyTrashGrabberBehaviour : Behaviour
	{
		// Token: 0x06003F41 RID: 16193 RVA: 0x0013F82C File Offset: 0x0013DA2C
		// Note: this type is marked as 'beforefieldinit'.
		static EmptyTrashGrabberBehaviour()
		{
			Il2CppClassPointerStore<EmptyTrashGrabberBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.Behaviour", "EmptyTrashGrabberBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EmptyTrashGrabberBehaviour>.NativeClassPtr);
			EmptyTrashGrabberBehaviour.NativeFieldInfoPtr_ACTION_MAX_DISTANCE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmptyTrashGrabberBehaviour>.NativeClassPtr, "ACTION_MAX_DISTANCE");
			EmptyTrashGrabberBehaviour.NativeFieldInfoPtr_EQUIPPABLE_ASSET_PATH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmptyTrashGrabberBehaviour>.NativeClassPtr, "EQUIPPABLE_ASSET_PATH");
			EmptyTrashGrabberBehaviour.NativeFieldInfoPtr__TargetTrashCan_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmptyTrashGrabberBehaviour>.NativeClassPtr, "<TargetTrashCan>k__BackingField");
			EmptyTrashGrabberBehaviour.NativeFieldInfoPtr_actionCoroutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmptyTrashGrabberBehaviour>.NativeClassPtr, "actionCoroutine");
			EmptyTrashGrabberBehaviour.NativeFieldInfoPtr_onPerfomAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmptyTrashGrabberBehaviour>.NativeClassPtr, "onPerfomAction");
			EmptyTrashGrabberBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmptyTrashGrabberBehaviour>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.EmptyTrashGrabberBehaviourAssembly-CSharp.dll_Excuted");
			EmptyTrashGrabberBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmptyTrashGrabberBehaviour>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.NPCs.Behaviour.EmptyTrashGrabberBehaviourAssembly-CSharp.dll_Excuted");
			EmptyTrashGrabberBehaviour.NativeMethodInfoPtr_get_TargetTrashCan_Public_get_TrashContainerItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmptyTrashGrabberBehaviour>.NativeClassPtr, 100670800);
			EmptyTrashGrabberBehaviour.NativeMethodInfoPtr_set_TargetTrashCan_Private_set_Void_TrashContainerItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmptyTrashGrabberBehaviour>.NativeClassPtr, 100670801);
			EmptyTrashGrabberBehaviour.NativeMethodInfoPtr_get_Cleaner_Private_get_Cleaner_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmptyTrashGrabberBehaviour>.NativeClassPtr, 100670802);
			EmptyTrashGrabberBehaviour.NativeMethodInfoPtr_SetTargetTrashCan_Public_Void_TrashContainerItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmptyTrashGrabberBehaviour>.NativeClassPtr, 100670803);
			EmptyTrashGrabberBehaviour.NativeMethodInfoPtr_Begin_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmptyTrashGrabberBehaviour>.NativeClassPtr, 100670804);
			EmptyTrashGrabberBehaviour.NativeMethodInfoPtr_Resume_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmptyTrashGrabberBehaviour>.NativeClassPtr, 100670805);
			EmptyTrashGrabberBehaviour.NativeMethodInfoPtr_StartAction_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmptyTrashGrabberBehaviour>.NativeClassPtr, 100670806);
			EmptyTrashGrabberBehaviour.NativeMethodInfoPtr_Pause_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmptyTrashGrabberBehaviour>.NativeClassPtr, 100670807);
			EmptyTrashGrabberBehaviour.NativeMethodInfoPtr_Disable_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmptyTrashGrabberBehaviour>.NativeClassPtr, 100670808);
			EmptyTrashGrabberBehaviour.NativeMethodInfoPtr_End_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmptyTrashGrabberBehaviour>.NativeClassPtr, 100670809);
			EmptyTrashGrabberBehaviour.NativeMethodInfoPtr_StopAllActions_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmptyTrashGrabberBehaviour>.NativeClassPtr, 100670810);
			EmptyTrashGrabberBehaviour.NativeMethodInfoPtr_ActiveMinPass_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmptyTrashGrabberBehaviour>.NativeClassPtr, 100670811);
			EmptyTrashGrabberBehaviour.NativeMethodInfoPtr_GoToTarget_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmptyTrashGrabberBehaviour>.NativeClassPtr, 100670812);
			EmptyTrashGrabberBehaviour.NativeMethodInfoPtr_PerformAction_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmptyTrashGrabberBehaviour>.NativeClassPtr, 100670813);
			EmptyTrashGrabberBehaviour.NativeMethodInfoPtr_IsAtDestination_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmptyTrashGrabberBehaviour>.NativeClassPtr, 100670814);
			EmptyTrashGrabberBehaviour.NativeMethodInfoPtr_AreActionConditionsMet_Private_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmptyTrashGrabberBehaviour>.NativeClassPtr, 100670815);
			EmptyTrashGrabberBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmptyTrashGrabberBehaviour>.NativeClassPtr, 100670816);
			EmptyTrashGrabberBehaviour.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmptyTrashGrabberBehaviour>.NativeClassPtr, 100670817);
			EmptyTrashGrabberBehaviour.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmptyTrashGrabberBehaviour>.NativeClassPtr, 100670818);
			EmptyTrashGrabberBehaviour.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmptyTrashGrabberBehaviour>.NativeClassPtr, 100670819);
			EmptyTrashGrabberBehaviour.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmptyTrashGrabberBehaviour>.NativeClassPtr, 100670820);
			EmptyTrashGrabberBehaviour.NativeMethodInfoPtr_RpcWriter___Observers_PerformAction_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmptyTrashGrabberBehaviour>.NativeClassPtr, 100670821);
			EmptyTrashGrabberBehaviour.NativeMethodInfoPtr_RpcLogic___PerformAction_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmptyTrashGrabberBehaviour>.NativeClassPtr, 100670822);
			EmptyTrashGrabberBehaviour.NativeMethodInfoPtr_RpcReader___Observers_PerformAction_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmptyTrashGrabberBehaviour>.NativeClassPtr, 100670823);
			EmptyTrashGrabberBehaviour.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmptyTrashGrabberBehaviour>.NativeClassPtr, 100670824);
		}

		// Token: 0x17001375 RID: 4981
		// (get) Token: 0x06003F42 RID: 16194 RVA: 0x0013FADC File Offset: 0x0013DCDC
		// (set) Token: 0x06003F43 RID: 16195 RVA: 0x0013FB1C File Offset: 0x0013DD1C
		public unsafe TrashContainerItem TargetTrashCan
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmptyTrashGrabberBehaviour.NativeMethodInfoPtr_get_TargetTrashCan_Public_get_TrashContainerItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmptyTrashGrabberBehaviour.NativeMethodInfoPtr_set_TargetTrashCan_Private_set_Void_TrashContainerItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001376 RID: 4982
		// (get) Token: 0x06003F44 RID: 16196 RVA: 0x0013FB60 File Offset: 0x0013DD60
		public unsafe Cleaner Cleaner
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 147692, RefRangeEnd = 147695, XrefRangeStart = 147689, XrefRangeEnd = 147692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmptyTrashGrabberBehaviour.NativeMethodInfoPtr_get_Cleaner_Private_get_Cleaner_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Cleaner>(intPtr3) : null;
			}
		}

		// Token: 0x06003F45 RID: 16197 RVA: 0x0013FBA0 File Offset: 0x0013DDA0
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 115138, RefRangeEnd = 115149, XrefRangeStart = 115138, XrefRangeEnd = 115149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTargetTrashCan(TrashContainerItem trashCan)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(trashCan);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmptyTrashGrabberBehaviour.NativeMethodInfoPtr_SetTargetTrashCan_Public_Void_TrashContainerItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003F46 RID: 16198 RVA: 0x0013FBE4 File Offset: 0x0013DDE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 147695, XrefRangeEnd = 147697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Begin()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EmptyTrashGrabberBehaviour.NativeMethodInfoPtr_Begin_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003F47 RID: 16199 RVA: 0x0013FC20 File Offset: 0x0013DE20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 147697, XrefRangeEnd = 147699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Resume()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EmptyTrashGrabberBehaviour.NativeMethodInfoPtr_Resume_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003F48 RID: 16200 RVA: 0x0013FC5C File Offset: 0x0013DE5C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 147711, RefRangeEnd = 147713, XrefRangeStart = 147699, XrefRangeEnd = 147711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartAction()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmptyTrashGrabberBehaviour.NativeMethodInfoPtr_StartAction_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003F49 RID: 16201 RVA: 0x0013FC90 File Offset: 0x0013DE90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 147713, XrefRangeEnd = 147715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Pause()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EmptyTrashGrabberBehaviour.NativeMethodInfoPtr_Pause_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003F4A RID: 16202 RVA: 0x0013FCCC File Offset: 0x0013DECC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Disable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EmptyTrashGrabberBehaviour.NativeMethodInfoPtr_Disable_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003F4B RID: 16203 RVA: 0x0013FD08 File Offset: 0x0013DF08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 147715, XrefRangeEnd = 147717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void End()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EmptyTrashGrabberBehaviour.NativeMethodInfoPtr_End_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003F4C RID: 16204 RVA: 0x0013FD44 File Offset: 0x0013DF44
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 147727, RefRangeEnd = 147729, XrefRangeStart = 147717, XrefRangeEnd = 147727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopAllActions()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmptyTrashGrabberBehaviour.NativeMethodInfoPtr_StopAllActions_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003F4D RID: 16205 RVA: 0x0013FD78 File Offset: 0x0013DF78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 147729, XrefRangeEnd = 147756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ActiveMinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EmptyTrashGrabberBehaviour.NativeMethodInfoPtr_ActiveMinPass_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003F4E RID: 16206 RVA: 0x0013FDB4 File Offset: 0x0013DFB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 147756, XrefRangeEnd = 147768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GoToTarget()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmptyTrashGrabberBehaviour.NativeMethodInfoPtr_GoToTarget_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003F4F RID: 16207 RVA: 0x0013FDE8 File Offset: 0x0013DFE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 147768, XrefRangeEnd = 147789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PerformAction()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmptyTrashGrabberBehaviour.NativeMethodInfoPtr_PerformAction_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003F50 RID: 16208 RVA: 0x0013FE1C File Offset: 0x0013E01C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsAtDestination()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmptyTrashGrabberBehaviour.NativeMethodInfoPtr_IsAtDestination_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003F51 RID: 16209 RVA: 0x0013FE58 File Offset: 0x0013E058
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 147800, RefRangeEnd = 147805, XrefRangeStart = 147789, XrefRangeEnd = 147800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool AreActionConditionsMet(bool checkAccess)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref checkAccess;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmptyTrashGrabberBehaviour.NativeMethodInfoPtr_AreActionConditionsMet_Private_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003F52 RID: 16210 RVA: 0x0013FEA4 File Offset: 0x0013E0A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EmptyTrashGrabberBehaviour() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EmptyTrashGrabberBehaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmptyTrashGrabberBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003F53 RID: 16211 RVA: 0x0013FEE0 File Offset: 0x0013E0E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 147805, XrefRangeEnd = 147810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmptyTrashGrabberBehaviour.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06003F54 RID: 16212 RVA: 0x0013FF20 File Offset: 0x0013E120
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 147810, XrefRangeEnd = 147818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EmptyTrashGrabberBehaviour.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003F55 RID: 16213 RVA: 0x0013FF5C File Offset: 0x0013E15C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EmptyTrashGrabberBehaviour.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003F56 RID: 16214 RVA: 0x0013FF98 File Offset: 0x0013E198
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EmptyTrashGrabberBehaviour.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003F57 RID: 16215 RVA: 0x0013FFD4 File Offset: 0x0013E1D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 147818, XrefRangeEnd = 147836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_PerformAction_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmptyTrashGrabberBehaviour.NativeMethodInfoPtr_RpcWriter___Observers_PerformAction_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003F58 RID: 16216 RVA: 0x00140008 File Offset: 0x0013E208
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 147847, RefRangeEnd = 147849, XrefRangeStart = 147836, XrefRangeEnd = 147847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___PerformAction_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmptyTrashGrabberBehaviour.NativeMethodInfoPtr_RpcLogic___PerformAction_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003F59 RID: 16217 RVA: 0x0014003C File Offset: 0x0013E23C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 147849, XrefRangeEnd = 147852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_PerformAction_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmptyTrashGrabberBehaviour.NativeMethodInfoPtr_RpcReader___Observers_PerformAction_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003F5A RID: 16218 RVA: 0x0014008C File Offset: 0x0013E28C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EmptyTrashGrabberBehaviour.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003F5B RID: 16219 RVA: 0x0001F911 File Offset: 0x0001DB11
		public EmptyTrashGrabberBehaviour(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700136E RID: 4974
		// (get) Token: 0x06003F5C RID: 16220 RVA: 0x001400C8 File Offset: 0x0013E2C8
		// (set) Token: 0x06003F5D RID: 16221 RVA: 0x0001F91A File Offset: 0x0001DB1A
		public unsafe static float ACTION_MAX_DISTANCE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(EmptyTrashGrabberBehaviour.NativeFieldInfoPtr_ACTION_MAX_DISTANCE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EmptyTrashGrabberBehaviour.NativeFieldInfoPtr_ACTION_MAX_DISTANCE, (void*)(&value));
			}
		}

		// Token: 0x1700136F RID: 4975
		// (get) Token: 0x06003F5E RID: 16222 RVA: 0x001400E4 File Offset: 0x0013E2E4
		// (set) Token: 0x06003F5F RID: 16223 RVA: 0x0001F928 File Offset: 0x0001DB28
		public unsafe static string EQUIPPABLE_ASSET_PATH
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EmptyTrashGrabberBehaviour.NativeFieldInfoPtr_EQUIPPABLE_ASSET_PATH, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EmptyTrashGrabberBehaviour.NativeFieldInfoPtr_EQUIPPABLE_ASSET_PATH, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001370 RID: 4976
		// (get) Token: 0x06003F60 RID: 16224 RVA: 0x00140104 File Offset: 0x0013E304
		// (set) Token: 0x06003F61 RID: 16225 RVA: 0x0001F93A File Offset: 0x0001DB3A
		public unsafe TrashContainerItem _TargetTrashCan_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmptyTrashGrabberBehaviour.NativeFieldInfoPtr__TargetTrashCan_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TrashContainerItem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmptyTrashGrabberBehaviour.NativeFieldInfoPtr__TargetTrashCan_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001371 RID: 4977
		// (get) Token: 0x06003F62 RID: 16226 RVA: 0x00140134 File Offset: 0x0013E334
		// (set) Token: 0x06003F63 RID: 16227 RVA: 0x0001F959 File Offset: 0x0001DB59
		public unsafe Coroutine actionCoroutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmptyTrashGrabberBehaviour.NativeFieldInfoPtr_actionCoroutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmptyTrashGrabberBehaviour.NativeFieldInfoPtr_actionCoroutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001372 RID: 4978
		// (get) Token: 0x06003F64 RID: 16228 RVA: 0x00140164 File Offset: 0x0013E364
		// (set) Token: 0x06003F65 RID: 16229 RVA: 0x0001F978 File Offset: 0x0001DB78
		public unsafe UnityEvent onPerfomAction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmptyTrashGrabberBehaviour.NativeFieldInfoPtr_onPerfomAction);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmptyTrashGrabberBehaviour.NativeFieldInfoPtr_onPerfomAction), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001373 RID: 4979
		// (get) Token: 0x06003F66 RID: 16230 RVA: 0x00140194 File Offset: 0x0013E394
		// (set) Token: 0x06003F67 RID: 16231 RVA: 0x0001F997 File Offset: 0x0001DB97
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmptyTrashGrabberBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmptyTrashGrabberBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17001374 RID: 4980
		// (get) Token: 0x06003F68 RID: 16232 RVA: 0x001401BC File Offset: 0x0013E3BC
		// (set) Token: 0x06003F69 RID: 16233 RVA: 0x0001F9B2 File Offset: 0x0001DBB2
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmptyTrashGrabberBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmptyTrashGrabberBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x040029FC RID: 10748
		private static readonly IntPtr NativeFieldInfoPtr_ACTION_MAX_DISTANCE;

		// Token: 0x040029FD RID: 10749
		private static readonly IntPtr NativeFieldInfoPtr_EQUIPPABLE_ASSET_PATH;

		// Token: 0x040029FE RID: 10750
		private static readonly IntPtr NativeFieldInfoPtr__TargetTrashCan_k__BackingField;

		// Token: 0x040029FF RID: 10751
		private static readonly IntPtr NativeFieldInfoPtr_actionCoroutine;

		// Token: 0x04002A00 RID: 10752
		private static readonly IntPtr NativeFieldInfoPtr_onPerfomAction;

		// Token: 0x04002A01 RID: 10753
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04002A02 RID: 10754
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04002A03 RID: 10755
		private static readonly IntPtr NativeMethodInfoPtr_get_TargetTrashCan_Public_get_TrashContainerItem_0;

		// Token: 0x04002A04 RID: 10756
		private static readonly IntPtr NativeMethodInfoPtr_set_TargetTrashCan_Private_set_Void_TrashContainerItem_0;

		// Token: 0x04002A05 RID: 10757
		private static readonly IntPtr NativeMethodInfoPtr_get_Cleaner_Private_get_Cleaner_0;

		// Token: 0x04002A06 RID: 10758
		private static readonly IntPtr NativeMethodInfoPtr_SetTargetTrashCan_Public_Void_TrashContainerItem_0;

		// Token: 0x04002A07 RID: 10759
		private static readonly IntPtr NativeMethodInfoPtr_Begin_Protected_Virtual_Void_0;

		// Token: 0x04002A08 RID: 10760
		private static readonly IntPtr NativeMethodInfoPtr_Resume_Protected_Virtual_Void_0;

		// Token: 0x04002A09 RID: 10761
		private static readonly IntPtr NativeMethodInfoPtr_StartAction_Private_Void_0;

		// Token: 0x04002A0A RID: 10762
		private static readonly IntPtr NativeMethodInfoPtr_Pause_Protected_Virtual_Void_0;

		// Token: 0x04002A0B RID: 10763
		private static readonly IntPtr NativeMethodInfoPtr_Disable_Public_Virtual_Void_0;

		// Token: 0x04002A0C RID: 10764
		private static readonly IntPtr NativeMethodInfoPtr_End_Protected_Virtual_Void_0;

		// Token: 0x04002A0D RID: 10765
		private static readonly IntPtr NativeMethodInfoPtr_StopAllActions_Private_Void_0;

		// Token: 0x04002A0E RID: 10766
		private static readonly IntPtr NativeMethodInfoPtr_ActiveMinPass_Public_Virtual_Void_0;

		// Token: 0x04002A0F RID: 10767
		private static readonly IntPtr NativeMethodInfoPtr_GoToTarget_Private_Void_0;

		// Token: 0x04002A10 RID: 10768
		private static readonly IntPtr NativeMethodInfoPtr_PerformAction_Private_Void_0;

		// Token: 0x04002A11 RID: 10769
		private static readonly IntPtr NativeMethodInfoPtr_IsAtDestination_Private_Boolean_0;

		// Token: 0x04002A12 RID: 10770
		private static readonly IntPtr NativeMethodInfoPtr_AreActionConditionsMet_Private_Boolean_Boolean_0;

		// Token: 0x04002A13 RID: 10771
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002A14 RID: 10772
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x04002A15 RID: 10773
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04002A16 RID: 10774
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04002A17 RID: 10775
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04002A18 RID: 10776
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_PerformAction_2166136261_Private_Void_0;

		// Token: 0x04002A19 RID: 10777
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___PerformAction_2166136261_Private_Void_0;

		// Token: 0x04002A1A RID: 10778
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_PerformAction_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x04002A1B RID: 10779
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x02000946 RID: 2374
		[ObfuscatedName("ScheduleOne.NPCs.Behaviour.EmptyTrashGrabberBehaviour+<<PerformAction>g__Action|20_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEmObObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600C7C7 RID: 51143 RVA: 0x00307214 File Offset: 0x00305414
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEmObObUnique()
			{
				Il2CppClassPointerStore<EmptyTrashGrabberBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEmObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EmptyTrashGrabberBehaviour>.NativeClassPtr, "<<PerformAction>g__Action|20_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EmptyTrashGrabberBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEmObObUnique>.NativeClassPtr);
				EmptyTrashGrabberBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEmObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmptyTrashGrabberBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEmObObUnique>.NativeClassPtr, "<>1__state");
				EmptyTrashGrabberBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEmObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmptyTrashGrabberBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEmObObUnique>.NativeClassPtr, "<>2__current");
				EmptyTrashGrabberBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEmObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmptyTrashGrabberBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEmObObUnique>.NativeClassPtr, "<>4__this");
				EmptyTrashGrabberBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEmObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmptyTrashGrabberBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEmObObUnique>.NativeClassPtr, 100670825);
				EmptyTrashGrabberBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEmObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmptyTrashGrabberBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEmObObUnique>.NativeClassPtr, 100670826);
				EmptyTrashGrabberBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEmObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmptyTrashGrabberBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEmObObUnique>.NativeClassPtr, 100670827);
				EmptyTrashGrabberBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEmObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmptyTrashGrabberBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEmObObUnique>.NativeClassPtr, 100670828);
				EmptyTrashGrabberBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEmObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmptyTrashGrabberBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEmObObUnique>.NativeClassPtr, 100670829);
				EmptyTrashGrabberBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEmObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmptyTrashGrabberBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEmObObUnique>.NativeClassPtr, 100670830);
			}

			// Token: 0x0600C7C8 RID: 51144 RVA: 0x003072F4 File Offset: 0x003054F4
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEmObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EmptyTrashGrabberBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEmObObUnique>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmptyTrashGrabberBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEmObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C7C9 RID: 51145 RVA: 0x0030733C File Offset: 0x0030553C
			[CallerCount(13604)]
			[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmptyTrashGrabberBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEmObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C7CA RID: 51146 RVA: 0x00307370 File Offset: 0x00305570
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 147631, XrefRangeEnd = 147684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmptyTrashGrabberBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEmObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003E48 RID: 15944
			// (get) Token: 0x0600C7CB RID: 51147 RVA: 0x003073AC File Offset: 0x003055AC
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmptyTrashGrabberBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEmObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600C7CC RID: 51148 RVA: 0x003073EC File Offset: 0x003055EC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 147684, XrefRangeEnd = 147689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmptyTrashGrabberBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEmObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003E49 RID: 15945
			// (get) Token: 0x0600C7CD RID: 51149 RVA: 0x00307420 File Offset: 0x00305620
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmptyTrashGrabberBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEmObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600C7CE RID: 51150 RVA: 0x00061324 File Offset: 0x0005F524
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEmObObUnique(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003E45 RID: 15941
			// (get) Token: 0x0600C7CF RID: 51151 RVA: 0x00307460 File Offset: 0x00305660
			// (set) Token: 0x0600C7D0 RID: 51152 RVA: 0x0006132D File Offset: 0x0005F52D
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmptyTrashGrabberBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEmObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmptyTrashGrabberBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEmObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003E46 RID: 15942
			// (get) Token: 0x0600C7D1 RID: 51153 RVA: 0x00307488 File Offset: 0x00305688
			// (set) Token: 0x0600C7D2 RID: 51154 RVA: 0x00061348 File Offset: 0x0005F548
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmptyTrashGrabberBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEmObObUnique.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmptyTrashGrabberBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEmObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003E47 RID: 15943
			// (get) Token: 0x0600C7D3 RID: 51155 RVA: 0x003074B8 File Offset: 0x003056B8
			// (set) Token: 0x0600C7D4 RID: 51156 RVA: 0x00061367 File Offset: 0x0005F567
			public unsafe EmptyTrashGrabberBehaviour __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmptyTrashGrabberBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEmObObUnique.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EmptyTrashGrabberBehaviour>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmptyTrashGrabberBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEmObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008732 RID: 34610
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008733 RID: 34611
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008734 RID: 34612
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008735 RID: 34613
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008736 RID: 34614
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008737 RID: 34615
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008738 RID: 34616
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008739 RID: 34617
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400873A RID: 34618
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
