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
	// Token: 0x02000355 RID: 853
	public class StopDryingRackBehaviour : Behaviour
	{
		// Token: 0x06004140 RID: 16704 RVA: 0x001474D8 File Offset: 0x001456D8
		// Note: this type is marked as 'beforefieldinit'.
		static StopDryingRackBehaviour()
		{
			Il2CppClassPointerStore<StopDryingRackBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.Behaviour", "StopDryingRackBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StopDryingRackBehaviour>.NativeClassPtr);
			StopDryingRackBehaviour.NativeFieldInfoPtr_TIME_PER_ITEM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StopDryingRackBehaviour>.NativeClassPtr, "TIME_PER_ITEM");
			StopDryingRackBehaviour.NativeFieldInfoPtr__Rack_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StopDryingRackBehaviour>.NativeClassPtr, "<Rack>k__BackingField");
			StopDryingRackBehaviour.NativeFieldInfoPtr__WorkInProgress_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StopDryingRackBehaviour>.NativeClassPtr, "<WorkInProgress>k__BackingField");
			StopDryingRackBehaviour.NativeFieldInfoPtr_workRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StopDryingRackBehaviour>.NativeClassPtr, "workRoutine");
			StopDryingRackBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StopDryingRackBehaviour>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.StopDryingRackBehaviourAssembly-CSharp.dll_Excuted");
			StopDryingRackBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StopDryingRackBehaviour>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.NPCs.Behaviour.StopDryingRackBehaviourAssembly-CSharp.dll_Excuted");
			StopDryingRackBehaviour.NativeMethodInfoPtr_get_Rack_Public_get_DryingRack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StopDryingRackBehaviour>.NativeClassPtr, 100671218);
			StopDryingRackBehaviour.NativeMethodInfoPtr_set_Rack_Protected_set_Void_DryingRack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StopDryingRackBehaviour>.NativeClassPtr, 100671219);
			StopDryingRackBehaviour.NativeMethodInfoPtr_get_WorkInProgress_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StopDryingRackBehaviour>.NativeClassPtr, 100671220);
			StopDryingRackBehaviour.NativeMethodInfoPtr_set_WorkInProgress_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StopDryingRackBehaviour>.NativeClassPtr, 100671221);
			StopDryingRackBehaviour.NativeMethodInfoPtr_Begin_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StopDryingRackBehaviour>.NativeClassPtr, 100671222);
			StopDryingRackBehaviour.NativeMethodInfoPtr_Resume_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StopDryingRackBehaviour>.NativeClassPtr, 100671223);
			StopDryingRackBehaviour.NativeMethodInfoPtr_Pause_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StopDryingRackBehaviour>.NativeClassPtr, 100671224);
			StopDryingRackBehaviour.NativeMethodInfoPtr_Disable_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StopDryingRackBehaviour>.NativeClassPtr, 100671225);
			StopDryingRackBehaviour.NativeMethodInfoPtr_End_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StopDryingRackBehaviour>.NativeClassPtr, 100671226);
			StopDryingRackBehaviour.NativeMethodInfoPtr_ActiveMinPass_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StopDryingRackBehaviour>.NativeClassPtr, 100671227);
			StopDryingRackBehaviour.NativeMethodInfoPtr_StartWork_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StopDryingRackBehaviour>.NativeClassPtr, 100671228);
			StopDryingRackBehaviour.NativeMethodInfoPtr_AssignRack_Public_Void_DryingRack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StopDryingRackBehaviour>.NativeClassPtr, 100671229);
			StopDryingRackBehaviour.NativeMethodInfoPtr_IsAtStation_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StopDryingRackBehaviour>.NativeClassPtr, 100671230);
			StopDryingRackBehaviour.NativeMethodInfoPtr_GoToStation_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StopDryingRackBehaviour>.NativeClassPtr, 100671231);
			StopDryingRackBehaviour.NativeMethodInfoPtr_BeginAction_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StopDryingRackBehaviour>.NativeClassPtr, 100671232);
			StopDryingRackBehaviour.NativeMethodInfoPtr_StopCauldron_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StopDryingRackBehaviour>.NativeClassPtr, 100671233);
			StopDryingRackBehaviour.NativeMethodInfoPtr_IsRackReady_Public_Boolean_DryingRack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StopDryingRackBehaviour>.NativeClassPtr, 100671234);
			StopDryingRackBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StopDryingRackBehaviour>.NativeClassPtr, 100671235);
			StopDryingRackBehaviour.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StopDryingRackBehaviour>.NativeClassPtr, 100671236);
			StopDryingRackBehaviour.NativeMethodInfoPtr__BeginAction_b__20_1_Private_Boolean_DryingOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StopDryingRackBehaviour>.NativeClassPtr, 100671237);
			StopDryingRackBehaviour.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StopDryingRackBehaviour>.NativeClassPtr, 100671238);
			StopDryingRackBehaviour.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StopDryingRackBehaviour>.NativeClassPtr, 100671239);
			StopDryingRackBehaviour.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StopDryingRackBehaviour>.NativeClassPtr, 100671240);
			StopDryingRackBehaviour.NativeMethodInfoPtr_RpcWriter___Observers_BeginAction_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StopDryingRackBehaviour>.NativeClassPtr, 100671241);
			StopDryingRackBehaviour.NativeMethodInfoPtr_RpcLogic___BeginAction_2166136261_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StopDryingRackBehaviour>.NativeClassPtr, 100671242);
			StopDryingRackBehaviour.NativeMethodInfoPtr_RpcReader___Observers_BeginAction_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StopDryingRackBehaviour>.NativeClassPtr, 100671243);
			StopDryingRackBehaviour.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StopDryingRackBehaviour>.NativeClassPtr, 100671244);
		}

		// Token: 0x170013DF RID: 5087
		// (get) Token: 0x06004141 RID: 16705 RVA: 0x0014779C File Offset: 0x0014599C
		// (set) Token: 0x06004142 RID: 16706 RVA: 0x001477DC File Offset: 0x001459DC
		public unsafe DryingRack Rack
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StopDryingRackBehaviour.NativeMethodInfoPtr_get_Rack_Public_get_DryingRack_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StopDryingRackBehaviour.NativeMethodInfoPtr_set_Rack_Protected_set_Void_DryingRack_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170013E0 RID: 5088
		// (get) Token: 0x06004143 RID: 16707 RVA: 0x00147820 File Offset: 0x00145A20
		// (set) Token: 0x06004144 RID: 16708 RVA: 0x0014785C File Offset: 0x00145A5C
		public unsafe bool WorkInProgress
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StopDryingRackBehaviour.NativeMethodInfoPtr_get_WorkInProgress_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StopDryingRackBehaviour.NativeMethodInfoPtr_set_WorkInProgress_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004145 RID: 16709 RVA: 0x0014789C File Offset: 0x00145A9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151053, XrefRangeEnd = 151055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Begin()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StopDryingRackBehaviour.NativeMethodInfoPtr_Begin_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004146 RID: 16710 RVA: 0x001478D8 File Offset: 0x00145AD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151055, XrefRangeEnd = 151057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Resume()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StopDryingRackBehaviour.NativeMethodInfoPtr_Resume_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004147 RID: 16711 RVA: 0x00147914 File Offset: 0x00145B14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Pause()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StopDryingRackBehaviour.NativeMethodInfoPtr_Pause_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004148 RID: 16712 RVA: 0x00147950 File Offset: 0x00145B50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Disable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StopDryingRackBehaviour.NativeMethodInfoPtr_Disable_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004149 RID: 16713 RVA: 0x0014798C File Offset: 0x00145B8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151057, XrefRangeEnd = 151070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void End()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StopDryingRackBehaviour.NativeMethodInfoPtr_End_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600414A RID: 16714 RVA: 0x001479C8 File Offset: 0x00145BC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151070, XrefRangeEnd = 151092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ActiveMinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StopDryingRackBehaviour.NativeMethodInfoPtr_ActiveMinPass_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600414B RID: 16715 RVA: 0x00147A04 File Offset: 0x00145C04
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 151098, RefRangeEnd = 151100, XrefRangeStart = 151092, XrefRangeEnd = 151098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartWork()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StopDryingRackBehaviour.NativeMethodInfoPtr_StartWork_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600414C RID: 16716 RVA: 0x00147A38 File Offset: 0x00145C38
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 115138, RefRangeEnd = 115149, XrefRangeStart = 115138, XrefRangeEnd = 115149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AssignRack(DryingRack rack)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(rack);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StopDryingRackBehaviour.NativeMethodInfoPtr_AssignRack_Public_Void_DryingRack_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600414D RID: 16717 RVA: 0x00147A7C File Offset: 0x00145C7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151100, XrefRangeEnd = 151108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsAtStation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StopDryingRackBehaviour.NativeMethodInfoPtr_IsAtStation_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600414E RID: 16718 RVA: 0x00147AB8 File Offset: 0x00145CB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151108, XrefRangeEnd = 151116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GoToStation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StopDryingRackBehaviour.NativeMethodInfoPtr_GoToStation_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600414F RID: 16719 RVA: 0x00147AEC File Offset: 0x00145CEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151116, XrefRangeEnd = 151137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BeginAction()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StopDryingRackBehaviour.NativeMethodInfoPtr_BeginAction_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004150 RID: 16720 RVA: 0x00147B20 File Offset: 0x00145D20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopCauldron()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StopDryingRackBehaviour.NativeMethodInfoPtr_StopCauldron_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004151 RID: 16721 RVA: 0x00147B54 File Offset: 0x00145D54
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 151174, RefRangeEnd = 151177, XrefRangeStart = 151137, XrefRangeEnd = 151174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsRackReady(DryingRack rack)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(rack);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StopDryingRackBehaviour.NativeMethodInfoPtr_IsRackReady_Public_Boolean_DryingRack_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004152 RID: 16722 RVA: 0x00147BA4 File Offset: 0x00145DA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StopDryingRackBehaviour() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StopDryingRackBehaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StopDryingRackBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004153 RID: 16723 RVA: 0x00147BE0 File Offset: 0x00145DE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151177, XrefRangeEnd = 151182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StopDryingRackBehaviour.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06004154 RID: 16724 RVA: 0x00147C20 File Offset: 0x00145E20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151182, XrefRangeEnd = 151184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _BeginAction_b__20_1(DryingOperation x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StopDryingRackBehaviour.NativeMethodInfoPtr__BeginAction_b__20_1_Private_Boolean_DryingOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004155 RID: 16725 RVA: 0x00147C70 File Offset: 0x00145E70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151184, XrefRangeEnd = 151192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StopDryingRackBehaviour.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004156 RID: 16726 RVA: 0x00147CAC File Offset: 0x00145EAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StopDryingRackBehaviour.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004157 RID: 16727 RVA: 0x00147CE8 File Offset: 0x00145EE8
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StopDryingRackBehaviour.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004158 RID: 16728 RVA: 0x00147D24 File Offset: 0x00145F24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151192, XrefRangeEnd = 151210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_BeginAction_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StopDryingRackBehaviour.NativeMethodInfoPtr_RpcWriter___Observers_BeginAction_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004159 RID: 16729 RVA: 0x00147D58 File Offset: 0x00145F58
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 151224, RefRangeEnd = 151226, XrefRangeStart = 151210, XrefRangeEnd = 151224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___BeginAction_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StopDryingRackBehaviour.NativeMethodInfoPtr_RpcLogic___BeginAction_2166136261_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600415A RID: 16730 RVA: 0x00147D8C File Offset: 0x00145F8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151226, XrefRangeEnd = 151229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_BeginAction_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StopDryingRackBehaviour.NativeMethodInfoPtr_RpcReader___Observers_BeginAction_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600415B RID: 16731 RVA: 0x00147DDC File Offset: 0x00145FDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StopDryingRackBehaviour.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600415C RID: 16732 RVA: 0x000202BF File Offset: 0x0001E4BF
		public StopDryingRackBehaviour(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170013D9 RID: 5081
		// (get) Token: 0x0600415D RID: 16733 RVA: 0x00147E18 File Offset: 0x00146018
		// (set) Token: 0x0600415E RID: 16734 RVA: 0x000202C8 File Offset: 0x0001E4C8
		public unsafe static float TIME_PER_ITEM
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(StopDryingRackBehaviour.NativeFieldInfoPtr_TIME_PER_ITEM, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(StopDryingRackBehaviour.NativeFieldInfoPtr_TIME_PER_ITEM, (void*)(&value));
			}
		}

		// Token: 0x170013DA RID: 5082
		// (get) Token: 0x0600415F RID: 16735 RVA: 0x00147E34 File Offset: 0x00146034
		// (set) Token: 0x06004160 RID: 16736 RVA: 0x000202D6 File Offset: 0x0001E4D6
		public unsafe DryingRack _Rack_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StopDryingRackBehaviour.NativeFieldInfoPtr__Rack_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DryingRack>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StopDryingRackBehaviour.NativeFieldInfoPtr__Rack_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170013DB RID: 5083
		// (get) Token: 0x06004161 RID: 16737 RVA: 0x00147E64 File Offset: 0x00146064
		// (set) Token: 0x06004162 RID: 16738 RVA: 0x000202F5 File Offset: 0x0001E4F5
		public unsafe bool _WorkInProgress_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StopDryingRackBehaviour.NativeFieldInfoPtr__WorkInProgress_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StopDryingRackBehaviour.NativeFieldInfoPtr__WorkInProgress_k__BackingField)) = value;
			}
		}

		// Token: 0x170013DC RID: 5084
		// (get) Token: 0x06004163 RID: 16739 RVA: 0x00147E8C File Offset: 0x0014608C
		// (set) Token: 0x06004164 RID: 16740 RVA: 0x00020310 File Offset: 0x0001E510
		public unsafe Coroutine workRoutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StopDryingRackBehaviour.NativeFieldInfoPtr_workRoutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StopDryingRackBehaviour.NativeFieldInfoPtr_workRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170013DD RID: 5085
		// (get) Token: 0x06004165 RID: 16741 RVA: 0x00147EBC File Offset: 0x001460BC
		// (set) Token: 0x06004166 RID: 16742 RVA: 0x0002032F File Offset: 0x0001E52F
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StopDryingRackBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StopDryingRackBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x170013DE RID: 5086
		// (get) Token: 0x06004167 RID: 16743 RVA: 0x00147EE4 File Offset: 0x001460E4
		// (set) Token: 0x06004168 RID: 16744 RVA: 0x0002034A File Offset: 0x0001E54A
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StopDryingRackBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StopDryingRackBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04002B8D RID: 11149
		private static readonly IntPtr NativeFieldInfoPtr_TIME_PER_ITEM;

		// Token: 0x04002B8E RID: 11150
		private static readonly IntPtr NativeFieldInfoPtr__Rack_k__BackingField;

		// Token: 0x04002B8F RID: 11151
		private static readonly IntPtr NativeFieldInfoPtr__WorkInProgress_k__BackingField;

		// Token: 0x04002B90 RID: 11152
		private static readonly IntPtr NativeFieldInfoPtr_workRoutine;

		// Token: 0x04002B91 RID: 11153
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04002B92 RID: 11154
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04002B93 RID: 11155
		private static readonly IntPtr NativeMethodInfoPtr_get_Rack_Public_get_DryingRack_0;

		// Token: 0x04002B94 RID: 11156
		private static readonly IntPtr NativeMethodInfoPtr_set_Rack_Protected_set_Void_DryingRack_0;

		// Token: 0x04002B95 RID: 11157
		private static readonly IntPtr NativeMethodInfoPtr_get_WorkInProgress_Public_get_Boolean_0;

		// Token: 0x04002B96 RID: 11158
		private static readonly IntPtr NativeMethodInfoPtr_set_WorkInProgress_Protected_set_Void_Boolean_0;

		// Token: 0x04002B97 RID: 11159
		private static readonly IntPtr NativeMethodInfoPtr_Begin_Protected_Virtual_Void_0;

		// Token: 0x04002B98 RID: 11160
		private static readonly IntPtr NativeMethodInfoPtr_Resume_Protected_Virtual_Void_0;

		// Token: 0x04002B99 RID: 11161
		private static readonly IntPtr NativeMethodInfoPtr_Pause_Protected_Virtual_Void_0;

		// Token: 0x04002B9A RID: 11162
		private static readonly IntPtr NativeMethodInfoPtr_Disable_Public_Virtual_Void_0;

		// Token: 0x04002B9B RID: 11163
		private static readonly IntPtr NativeMethodInfoPtr_End_Protected_Virtual_Void_0;

		// Token: 0x04002B9C RID: 11164
		private static readonly IntPtr NativeMethodInfoPtr_ActiveMinPass_Public_Virtual_Void_0;

		// Token: 0x04002B9D RID: 11165
		private static readonly IntPtr NativeMethodInfoPtr_StartWork_Private_Void_0;

		// Token: 0x04002B9E RID: 11166
		private static readonly IntPtr NativeMethodInfoPtr_AssignRack_Public_Void_DryingRack_0;

		// Token: 0x04002B9F RID: 11167
		private static readonly IntPtr NativeMethodInfoPtr_IsAtStation_Public_Boolean_0;

		// Token: 0x04002BA0 RID: 11168
		private static readonly IntPtr NativeMethodInfoPtr_GoToStation_Public_Void_0;

		// Token: 0x04002BA1 RID: 11169
		private static readonly IntPtr NativeMethodInfoPtr_BeginAction_Public_Void_0;

		// Token: 0x04002BA2 RID: 11170
		private static readonly IntPtr NativeMethodInfoPtr_StopCauldron_Private_Void_0;

		// Token: 0x04002BA3 RID: 11171
		private static readonly IntPtr NativeMethodInfoPtr_IsRackReady_Public_Boolean_DryingRack_0;

		// Token: 0x04002BA4 RID: 11172
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002BA5 RID: 11173
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x04002BA6 RID: 11174
		private static readonly IntPtr NativeMethodInfoPtr__BeginAction_b__20_1_Private_Boolean_DryingOperation_0;

		// Token: 0x04002BA7 RID: 11175
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04002BA8 RID: 11176
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04002BA9 RID: 11177
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04002BAA RID: 11178
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_BeginAction_2166136261_Private_Void_0;

		// Token: 0x04002BAB RID: 11179
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___BeginAction_2166136261_Public_Void_0;

		// Token: 0x04002BAC RID: 11180
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_BeginAction_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x04002BAD RID: 11181
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x0200095B RID: 2395
		[ObfuscatedName("ScheduleOne.NPCs.Behaviour.StopDryingRackBehaviour+<<BeginAction>g__Package|20_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStObObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600C8D5 RID: 51413 RVA: 0x0030A660 File Offset: 0x00308860
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStObObUnique()
			{
				Il2CppClassPointerStore<StopDryingRackBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StopDryingRackBehaviour>.NativeClassPtr, "<<BeginAction>g__Package|20_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StopDryingRackBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStObObUnique>.NativeClassPtr);
				StopDryingRackBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StopDryingRackBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStObObUnique>.NativeClassPtr, "<>1__state");
				StopDryingRackBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StopDryingRackBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStObObUnique>.NativeClassPtr, "<>2__current");
				StopDryingRackBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StopDryingRackBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStObObUnique>.NativeClassPtr, "<>4__this");
				StopDryingRackBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StopDryingRackBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStObObUnique>.NativeClassPtr, 100671245);
				StopDryingRackBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StopDryingRackBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStObObUnique>.NativeClassPtr, 100671246);
				StopDryingRackBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StopDryingRackBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStObObUnique>.NativeClassPtr, 100671247);
				StopDryingRackBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StopDryingRackBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStObObUnique>.NativeClassPtr, 100671248);
				StopDryingRackBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StopDryingRackBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStObObUnique>.NativeClassPtr, 100671249);
				StopDryingRackBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StopDryingRackBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStObObUnique>.NativeClassPtr, 100671250);
			}

			// Token: 0x0600C8D6 RID: 51414 RVA: 0x0030A740 File Offset: 0x00308940
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StopDryingRackBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStObObUnique>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StopDryingRackBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C8D7 RID: 51415 RVA: 0x0030A788 File Offset: 0x00308988
			[CallerCount(13604)]
			[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StopDryingRackBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C8D8 RID: 51416 RVA: 0x0030A7BC File Offset: 0x003089BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151027, XrefRangeEnd = 151048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StopDryingRackBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003EAB RID: 16043
			// (get) Token: 0x0600C8D9 RID: 51417 RVA: 0x0030A7F8 File Offset: 0x003089F8
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StopDryingRackBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600C8DA RID: 51418 RVA: 0x0030A838 File Offset: 0x00308A38
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151048, XrefRangeEnd = 151053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StopDryingRackBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003EAC RID: 16044
			// (get) Token: 0x0600C8DB RID: 51419 RVA: 0x0030A86C File Offset: 0x00308A6C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StopDryingRackBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600C8DC RID: 51420 RVA: 0x00061B23 File Offset: 0x0005FD23
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStObObUnique(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003EA8 RID: 16040
			// (get) Token: 0x0600C8DD RID: 51421 RVA: 0x0030A8AC File Offset: 0x00308AAC
			// (set) Token: 0x0600C8DE RID: 51422 RVA: 0x00061B2C File Offset: 0x0005FD2C
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StopDryingRackBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StopDryingRackBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003EA9 RID: 16041
			// (get) Token: 0x0600C8DF RID: 51423 RVA: 0x0030A8D4 File Offset: 0x00308AD4
			// (set) Token: 0x0600C8E0 RID: 51424 RVA: 0x00061B47 File Offset: 0x0005FD47
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StopDryingRackBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStObObUnique.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StopDryingRackBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003EAA RID: 16042
			// (get) Token: 0x0600C8E1 RID: 51425 RVA: 0x0030A904 File Offset: 0x00308B04
			// (set) Token: 0x0600C8E2 RID: 51426 RVA: 0x00061B66 File Offset: 0x0005FD66
			public unsafe StopDryingRackBehaviour __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StopDryingRackBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStObObUnique.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<StopDryingRackBehaviour>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StopDryingRackBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040087EF RID: 34799
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040087F0 RID: 34800
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040087F1 RID: 34801
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040087F2 RID: 34802
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040087F3 RID: 34803
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040087F4 RID: 34804
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040087F5 RID: 34805
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040087F6 RID: 34806
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040087F7 RID: 34807
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
