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
	// Token: 0x02000352 RID: 850
	public class StartDryingRackBehaviour : Behaviour
	{
		// Token: 0x060040D3 RID: 16595 RVA: 0x00145AD8 File Offset: 0x00143CD8
		// Note: this type is marked as 'beforefieldinit'.
		static StartDryingRackBehaviour()
		{
			Il2CppClassPointerStore<StartDryingRackBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.Behaviour", "StartDryingRackBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StartDryingRackBehaviour>.NativeClassPtr);
			StartDryingRackBehaviour.NativeFieldInfoPtr_TIME_PER_ITEM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartDryingRackBehaviour>.NativeClassPtr, "TIME_PER_ITEM");
			StartDryingRackBehaviour.NativeFieldInfoPtr__Rack_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartDryingRackBehaviour>.NativeClassPtr, "<Rack>k__BackingField");
			StartDryingRackBehaviour.NativeFieldInfoPtr__WorkInProgress_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartDryingRackBehaviour>.NativeClassPtr, "<WorkInProgress>k__BackingField");
			StartDryingRackBehaviour.NativeFieldInfoPtr_workRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartDryingRackBehaviour>.NativeClassPtr, "workRoutine");
			StartDryingRackBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartDryingRackBehaviour>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.StartDryingRackBehaviourAssembly-CSharp.dll_Excuted");
			StartDryingRackBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartDryingRackBehaviour>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.NPCs.Behaviour.StartDryingRackBehaviourAssembly-CSharp.dll_Excuted");
			StartDryingRackBehaviour.NativeMethodInfoPtr_get_Rack_Public_get_DryingRack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartDryingRackBehaviour>.NativeClassPtr, 100671133);
			StartDryingRackBehaviour.NativeMethodInfoPtr_set_Rack_Protected_set_Void_DryingRack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartDryingRackBehaviour>.NativeClassPtr, 100671134);
			StartDryingRackBehaviour.NativeMethodInfoPtr_get_WorkInProgress_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartDryingRackBehaviour>.NativeClassPtr, 100671135);
			StartDryingRackBehaviour.NativeMethodInfoPtr_set_WorkInProgress_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartDryingRackBehaviour>.NativeClassPtr, 100671136);
			StartDryingRackBehaviour.NativeMethodInfoPtr_Begin_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartDryingRackBehaviour>.NativeClassPtr, 100671137);
			StartDryingRackBehaviour.NativeMethodInfoPtr_Resume_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartDryingRackBehaviour>.NativeClassPtr, 100671138);
			StartDryingRackBehaviour.NativeMethodInfoPtr_Pause_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartDryingRackBehaviour>.NativeClassPtr, 100671139);
			StartDryingRackBehaviour.NativeMethodInfoPtr_Disable_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartDryingRackBehaviour>.NativeClassPtr, 100671140);
			StartDryingRackBehaviour.NativeMethodInfoPtr_End_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartDryingRackBehaviour>.NativeClassPtr, 100671141);
			StartDryingRackBehaviour.NativeMethodInfoPtr_ActiveMinPass_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartDryingRackBehaviour>.NativeClassPtr, 100671142);
			StartDryingRackBehaviour.NativeMethodInfoPtr_StartWork_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartDryingRackBehaviour>.NativeClassPtr, 100671143);
			StartDryingRackBehaviour.NativeMethodInfoPtr_AssignRack_Public_Void_DryingRack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartDryingRackBehaviour>.NativeClassPtr, 100671144);
			StartDryingRackBehaviour.NativeMethodInfoPtr_IsAtStation_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartDryingRackBehaviour>.NativeClassPtr, 100671145);
			StartDryingRackBehaviour.NativeMethodInfoPtr_GoToStation_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartDryingRackBehaviour>.NativeClassPtr, 100671146);
			StartDryingRackBehaviour.NativeMethodInfoPtr_BeginAction_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartDryingRackBehaviour>.NativeClassPtr, 100671147);
			StartDryingRackBehaviour.NativeMethodInfoPtr_StopCauldron_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartDryingRackBehaviour>.NativeClassPtr, 100671148);
			StartDryingRackBehaviour.NativeMethodInfoPtr_IsRackReady_Public_Boolean_DryingRack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartDryingRackBehaviour>.NativeClassPtr, 100671149);
			StartDryingRackBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartDryingRackBehaviour>.NativeClassPtr, 100671150);
			StartDryingRackBehaviour.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartDryingRackBehaviour>.NativeClassPtr, 100671151);
			StartDryingRackBehaviour.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartDryingRackBehaviour>.NativeClassPtr, 100671152);
			StartDryingRackBehaviour.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartDryingRackBehaviour>.NativeClassPtr, 100671153);
			StartDryingRackBehaviour.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartDryingRackBehaviour>.NativeClassPtr, 100671154);
			StartDryingRackBehaviour.NativeMethodInfoPtr_RpcWriter___Observers_BeginAction_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartDryingRackBehaviour>.NativeClassPtr, 100671155);
			StartDryingRackBehaviour.NativeMethodInfoPtr_RpcLogic___BeginAction_2166136261_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartDryingRackBehaviour>.NativeClassPtr, 100671156);
			StartDryingRackBehaviour.NativeMethodInfoPtr_RpcReader___Observers_BeginAction_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartDryingRackBehaviour>.NativeClassPtr, 100671157);
			StartDryingRackBehaviour.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartDryingRackBehaviour>.NativeClassPtr, 100671158);
		}

		// Token: 0x170013C9 RID: 5065
		// (get) Token: 0x060040D4 RID: 16596 RVA: 0x00145D88 File Offset: 0x00143F88
		// (set) Token: 0x060040D5 RID: 16597 RVA: 0x00145DC8 File Offset: 0x00143FC8
		public unsafe DryingRack Rack
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartDryingRackBehaviour.NativeMethodInfoPtr_get_Rack_Public_get_DryingRack_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DryingRack>(intPtr3) : null;
			}
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 115138, RefRangeEnd = 115149, XrefRangeStart = 115138, XrefRangeEnd = 115149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartDryingRackBehaviour.NativeMethodInfoPtr_set_Rack_Protected_set_Void_DryingRack_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170013CA RID: 5066
		// (get) Token: 0x060040D6 RID: 16598 RVA: 0x00145E0C File Offset: 0x0014400C
		// (set) Token: 0x060040D7 RID: 16599 RVA: 0x00145E48 File Offset: 0x00144048
		public unsafe bool WorkInProgress
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartDryingRackBehaviour.NativeMethodInfoPtr_get_WorkInProgress_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartDryingRackBehaviour.NativeMethodInfoPtr_set_WorkInProgress_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060040D8 RID: 16600 RVA: 0x00145E88 File Offset: 0x00144088
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150423, XrefRangeEnd = 150425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Begin()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StartDryingRackBehaviour.NativeMethodInfoPtr_Begin_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060040D9 RID: 16601 RVA: 0x00145EC4 File Offset: 0x001440C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150425, XrefRangeEnd = 150427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Resume()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StartDryingRackBehaviour.NativeMethodInfoPtr_Resume_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060040DA RID: 16602 RVA: 0x00145F00 File Offset: 0x00144100
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Pause()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StartDryingRackBehaviour.NativeMethodInfoPtr_Pause_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060040DB RID: 16603 RVA: 0x00145F3C File Offset: 0x0014413C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Disable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StartDryingRackBehaviour.NativeMethodInfoPtr_Disable_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060040DC RID: 16604 RVA: 0x00145F78 File Offset: 0x00144178
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150427, XrefRangeEnd = 150440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void End()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StartDryingRackBehaviour.NativeMethodInfoPtr_End_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060040DD RID: 16605 RVA: 0x00145FB4 File Offset: 0x001441B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150440, XrefRangeEnd = 150462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ActiveMinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StartDryingRackBehaviour.NativeMethodInfoPtr_ActiveMinPass_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060040DE RID: 16606 RVA: 0x00145FF0 File Offset: 0x001441F0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 150468, RefRangeEnd = 150470, XrefRangeStart = 150462, XrefRangeEnd = 150468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartWork()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartDryingRackBehaviour.NativeMethodInfoPtr_StartWork_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060040DF RID: 16607 RVA: 0x00146024 File Offset: 0x00144224
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 115138, RefRangeEnd = 115149, XrefRangeStart = 115138, XrefRangeEnd = 115149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AssignRack(DryingRack rack)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(rack);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartDryingRackBehaviour.NativeMethodInfoPtr_AssignRack_Public_Void_DryingRack_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060040E0 RID: 16608 RVA: 0x00146068 File Offset: 0x00144268
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150470, XrefRangeEnd = 150478, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsAtStation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartDryingRackBehaviour.NativeMethodInfoPtr_IsAtStation_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060040E1 RID: 16609 RVA: 0x001460A4 File Offset: 0x001442A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150478, XrefRangeEnd = 150486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GoToStation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartDryingRackBehaviour.NativeMethodInfoPtr_GoToStation_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060040E2 RID: 16610 RVA: 0x001460D8 File Offset: 0x001442D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150486, XrefRangeEnd = 150507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BeginAction()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartDryingRackBehaviour.NativeMethodInfoPtr_BeginAction_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060040E3 RID: 16611 RVA: 0x0014610C File Offset: 0x0014430C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopCauldron()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartDryingRackBehaviour.NativeMethodInfoPtr_StopCauldron_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060040E4 RID: 16612 RVA: 0x00146140 File Offset: 0x00144340
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 150530, RefRangeEnd = 150533, XrefRangeStart = 150507, XrefRangeEnd = 150530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsRackReady(DryingRack rack)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(rack);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartDryingRackBehaviour.NativeMethodInfoPtr_IsRackReady_Public_Boolean_DryingRack_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060040E5 RID: 16613 RVA: 0x00146190 File Offset: 0x00144390
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StartDryingRackBehaviour() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StartDryingRackBehaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartDryingRackBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060040E6 RID: 16614 RVA: 0x001461CC File Offset: 0x001443CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150533, XrefRangeEnd = 150538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartDryingRackBehaviour.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060040E7 RID: 16615 RVA: 0x0014620C File Offset: 0x0014440C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150538, XrefRangeEnd = 150546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StartDryingRackBehaviour.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060040E8 RID: 16616 RVA: 0x00146248 File Offset: 0x00144448
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StartDryingRackBehaviour.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060040E9 RID: 16617 RVA: 0x00146284 File Offset: 0x00144484
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StartDryingRackBehaviour.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060040EA RID: 16618 RVA: 0x001462C0 File Offset: 0x001444C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150546, XrefRangeEnd = 150564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_BeginAction_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartDryingRackBehaviour.NativeMethodInfoPtr_RpcWriter___Observers_BeginAction_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060040EB RID: 16619 RVA: 0x001462F4 File Offset: 0x001444F4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 150578, RefRangeEnd = 150580, XrefRangeStart = 150564, XrefRangeEnd = 150578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___BeginAction_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartDryingRackBehaviour.NativeMethodInfoPtr_RpcLogic___BeginAction_2166136261_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060040EC RID: 16620 RVA: 0x00146328 File Offset: 0x00144528
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150580, XrefRangeEnd = 150583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_BeginAction_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartDryingRackBehaviour.NativeMethodInfoPtr_RpcReader___Observers_BeginAction_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060040ED RID: 16621 RVA: 0x00146378 File Offset: 0x00144578
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StartDryingRackBehaviour.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060040EE RID: 16622 RVA: 0x000200C5 File Offset: 0x0001E2C5
		public StartDryingRackBehaviour(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170013C3 RID: 5059
		// (get) Token: 0x060040EF RID: 16623 RVA: 0x001463B4 File Offset: 0x001445B4
		// (set) Token: 0x060040F0 RID: 16624 RVA: 0x000200CE File Offset: 0x0001E2CE
		public unsafe static float TIME_PER_ITEM
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(StartDryingRackBehaviour.NativeFieldInfoPtr_TIME_PER_ITEM, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(StartDryingRackBehaviour.NativeFieldInfoPtr_TIME_PER_ITEM, (void*)(&value));
			}
		}

		// Token: 0x170013C4 RID: 5060
		// (get) Token: 0x060040F1 RID: 16625 RVA: 0x001463D0 File Offset: 0x001445D0
		// (set) Token: 0x060040F2 RID: 16626 RVA: 0x000200DC File Offset: 0x0001E2DC
		public unsafe DryingRack _Rack_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartDryingRackBehaviour.NativeFieldInfoPtr__Rack_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DryingRack>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartDryingRackBehaviour.NativeFieldInfoPtr__Rack_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170013C5 RID: 5061
		// (get) Token: 0x060040F3 RID: 16627 RVA: 0x00146400 File Offset: 0x00144600
		// (set) Token: 0x060040F4 RID: 16628 RVA: 0x000200FB File Offset: 0x0001E2FB
		public unsafe bool _WorkInProgress_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartDryingRackBehaviour.NativeFieldInfoPtr__WorkInProgress_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartDryingRackBehaviour.NativeFieldInfoPtr__WorkInProgress_k__BackingField)) = value;
			}
		}

		// Token: 0x170013C6 RID: 5062
		// (get) Token: 0x060040F5 RID: 16629 RVA: 0x00146428 File Offset: 0x00144628
		// (set) Token: 0x060040F6 RID: 16630 RVA: 0x00020116 File Offset: 0x0001E316
		public unsafe Coroutine workRoutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartDryingRackBehaviour.NativeFieldInfoPtr_workRoutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartDryingRackBehaviour.NativeFieldInfoPtr_workRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170013C7 RID: 5063
		// (get) Token: 0x060040F7 RID: 16631 RVA: 0x00146458 File Offset: 0x00144658
		// (set) Token: 0x060040F8 RID: 16632 RVA: 0x00020135 File Offset: 0x0001E335
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartDryingRackBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartDryingRackBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x170013C8 RID: 5064
		// (get) Token: 0x060040F9 RID: 16633 RVA: 0x00146480 File Offset: 0x00144680
		// (set) Token: 0x060040FA RID: 16634 RVA: 0x00020150 File Offset: 0x0001E350
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartDryingRackBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartDryingRackBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04002B38 RID: 11064
		private static readonly IntPtr NativeFieldInfoPtr_TIME_PER_ITEM;

		// Token: 0x04002B39 RID: 11065
		private static readonly IntPtr NativeFieldInfoPtr__Rack_k__BackingField;

		// Token: 0x04002B3A RID: 11066
		private static readonly IntPtr NativeFieldInfoPtr__WorkInProgress_k__BackingField;

		// Token: 0x04002B3B RID: 11067
		private static readonly IntPtr NativeFieldInfoPtr_workRoutine;

		// Token: 0x04002B3C RID: 11068
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04002B3D RID: 11069
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04002B3E RID: 11070
		private static readonly IntPtr NativeMethodInfoPtr_get_Rack_Public_get_DryingRack_0;

		// Token: 0x04002B3F RID: 11071
		private static readonly IntPtr NativeMethodInfoPtr_set_Rack_Protected_set_Void_DryingRack_0;

		// Token: 0x04002B40 RID: 11072
		private static readonly IntPtr NativeMethodInfoPtr_get_WorkInProgress_Public_get_Boolean_0;

		// Token: 0x04002B41 RID: 11073
		private static readonly IntPtr NativeMethodInfoPtr_set_WorkInProgress_Protected_set_Void_Boolean_0;

		// Token: 0x04002B42 RID: 11074
		private static readonly IntPtr NativeMethodInfoPtr_Begin_Protected_Virtual_Void_0;

		// Token: 0x04002B43 RID: 11075
		private static readonly IntPtr NativeMethodInfoPtr_Resume_Protected_Virtual_Void_0;

		// Token: 0x04002B44 RID: 11076
		private static readonly IntPtr NativeMethodInfoPtr_Pause_Protected_Virtual_Void_0;

		// Token: 0x04002B45 RID: 11077
		private static readonly IntPtr NativeMethodInfoPtr_Disable_Public_Virtual_Void_0;

		// Token: 0x04002B46 RID: 11078
		private static readonly IntPtr NativeMethodInfoPtr_End_Protected_Virtual_Void_0;

		// Token: 0x04002B47 RID: 11079
		private static readonly IntPtr NativeMethodInfoPtr_ActiveMinPass_Public_Virtual_Void_0;

		// Token: 0x04002B48 RID: 11080
		private static readonly IntPtr NativeMethodInfoPtr_StartWork_Private_Void_0;

		// Token: 0x04002B49 RID: 11081
		private static readonly IntPtr NativeMethodInfoPtr_AssignRack_Public_Void_DryingRack_0;

		// Token: 0x04002B4A RID: 11082
		private static readonly IntPtr NativeMethodInfoPtr_IsAtStation_Public_Boolean_0;

		// Token: 0x04002B4B RID: 11083
		private static readonly IntPtr NativeMethodInfoPtr_GoToStation_Public_Void_0;

		// Token: 0x04002B4C RID: 11084
		private static readonly IntPtr NativeMethodInfoPtr_BeginAction_Public_Void_0;

		// Token: 0x04002B4D RID: 11085
		private static readonly IntPtr NativeMethodInfoPtr_StopCauldron_Private_Void_0;

		// Token: 0x04002B4E RID: 11086
		private static readonly IntPtr NativeMethodInfoPtr_IsRackReady_Public_Boolean_DryingRack_0;

		// Token: 0x04002B4F RID: 11087
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002B50 RID: 11088
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x04002B51 RID: 11089
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04002B52 RID: 11090
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04002B53 RID: 11091
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04002B54 RID: 11092
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_BeginAction_2166136261_Private_Void_0;

		// Token: 0x04002B55 RID: 11093
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___BeginAction_2166136261_Public_Void_0;

		// Token: 0x04002B56 RID: 11094
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_BeginAction_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x04002B57 RID: 11095
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x02000958 RID: 2392
		[ObfuscatedName("ScheduleOne.NPCs.Behaviour.StartDryingRackBehaviour+<<BeginAction>g__Package|20_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600C8A1 RID: 51361 RVA: 0x00309CA8 File Offset: 0x00307EA8
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObObUnique()
			{
				Il2CppClassPointerStore<StartDryingRackBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StartDryingRackBehaviour>.NativeClassPtr, "<<BeginAction>g__Package|20_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StartDryingRackBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObObUnique>.NativeClassPtr);
				StartDryingRackBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartDryingRackBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObObUnique>.NativeClassPtr, "<>1__state");
				StartDryingRackBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartDryingRackBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObObUnique>.NativeClassPtr, "<>2__current");
				StartDryingRackBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartDryingRackBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObObUnique>.NativeClassPtr, "<>4__this");
				StartDryingRackBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObObUnique.NativeFieldInfoPtr__itemCount_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartDryingRackBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObObUnique>.NativeClassPtr, "<itemCount>5__2");
				StartDryingRackBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartDryingRackBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObObUnique>.NativeClassPtr, 100671159);
				StartDryingRackBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartDryingRackBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObObUnique>.NativeClassPtr, 100671160);
				StartDryingRackBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartDryingRackBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObObUnique>.NativeClassPtr, 100671161);
				StartDryingRackBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartDryingRackBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObObUnique>.NativeClassPtr, 100671162);
				StartDryingRackBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartDryingRackBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObObUnique>.NativeClassPtr, 100671163);
				StartDryingRackBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartDryingRackBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObObUnique>.NativeClassPtr, 100671164);
			}

			// Token: 0x0600C8A2 RID: 51362 RVA: 0x00309D9C File Offset: 0x00307F9C
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StartDryingRackBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObObUnique>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartDryingRackBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C8A3 RID: 51363 RVA: 0x00309DE4 File Offset: 0x00307FE4
			[CallerCount(13604)]
			[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartDryingRackBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C8A4 RID: 51364 RVA: 0x00309E18 File Offset: 0x00308018
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150401, XrefRangeEnd = 150418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartDryingRackBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003E98 RID: 16024
			// (get) Token: 0x0600C8A5 RID: 51365 RVA: 0x00309E54 File Offset: 0x00308054
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartDryingRackBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600C8A6 RID: 51366 RVA: 0x00309E94 File Offset: 0x00308094
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150418, XrefRangeEnd = 150423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartDryingRackBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003E99 RID: 16025
			// (get) Token: 0x0600C8A7 RID: 51367 RVA: 0x00309EC8 File Offset: 0x003080C8
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartDryingRackBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600C8A8 RID: 51368 RVA: 0x0006196E File Offset: 0x0005FB6E
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObObUnique(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003E94 RID: 16020
			// (get) Token: 0x0600C8A9 RID: 51369 RVA: 0x00309F08 File Offset: 0x00308108
			// (set) Token: 0x0600C8AA RID: 51370 RVA: 0x00061977 File Offset: 0x0005FB77
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartDryingRackBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartDryingRackBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003E95 RID: 16021
			// (get) Token: 0x0600C8AB RID: 51371 RVA: 0x00309F30 File Offset: 0x00308130
			// (set) Token: 0x0600C8AC RID: 51372 RVA: 0x00061992 File Offset: 0x0005FB92
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartDryingRackBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObObUnique.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartDryingRackBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003E96 RID: 16022
			// (get) Token: 0x0600C8AD RID: 51373 RVA: 0x00309F60 File Offset: 0x00308160
			// (set) Token: 0x0600C8AE RID: 51374 RVA: 0x000619B1 File Offset: 0x0005FBB1
			public unsafe StartDryingRackBehaviour __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartDryingRackBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObObUnique.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<StartDryingRackBehaviour>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartDryingRackBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003E97 RID: 16023
			// (get) Token: 0x0600C8AF RID: 51375 RVA: 0x00309F90 File Offset: 0x00308190
			// (set) Token: 0x0600C8B0 RID: 51376 RVA: 0x000619D0 File Offset: 0x0005FBD0
			public unsafe int _itemCount_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartDryingRackBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObObUnique.NativeFieldInfoPtr__itemCount_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartDryingRackBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObObUnique.NativeFieldInfoPtr__itemCount_5__2)) = value;
				}
			}

			// Token: 0x040087CF RID: 34767
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040087D0 RID: 34768
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040087D1 RID: 34769
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040087D2 RID: 34770
			private static readonly IntPtr NativeFieldInfoPtr__itemCount_5__2;

			// Token: 0x040087D3 RID: 34771
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040087D4 RID: 34772
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040087D5 RID: 34773
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040087D6 RID: 34774
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040087D7 RID: 34775
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040087D8 RID: 34776
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
