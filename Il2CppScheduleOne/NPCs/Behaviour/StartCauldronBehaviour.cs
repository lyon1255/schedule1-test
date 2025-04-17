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
	// Token: 0x02000350 RID: 848
	public class StartCauldronBehaviour : Behaviour
	{
		// Token: 0x06004080 RID: 16512 RVA: 0x00144774 File Offset: 0x00142974
		// Note: this type is marked as 'beforefieldinit'.
		static StartCauldronBehaviour()
		{
			Il2CppClassPointerStore<StartCauldronBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.Behaviour", "StartCauldronBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StartCauldronBehaviour>.NativeClassPtr);
			StartCauldronBehaviour.NativeFieldInfoPtr_START_CAULDRON_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartCauldronBehaviour>.NativeClassPtr, "START_CAULDRON_TIME");
			StartCauldronBehaviour.NativeFieldInfoPtr__Station_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartCauldronBehaviour>.NativeClassPtr, "<Station>k__BackingField");
			StartCauldronBehaviour.NativeFieldInfoPtr__WorkInProgress_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartCauldronBehaviour>.NativeClassPtr, "<WorkInProgress>k__BackingField");
			StartCauldronBehaviour.NativeFieldInfoPtr_workRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartCauldronBehaviour>.NativeClassPtr, "workRoutine");
			StartCauldronBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartCauldronBehaviour>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.StartCauldronBehaviourAssembly-CSharp.dll_Excuted");
			StartCauldronBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartCauldronBehaviour>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.NPCs.Behaviour.StartCauldronBehaviourAssembly-CSharp.dll_Excuted");
			StartCauldronBehaviour.NativeMethodInfoPtr_get_Station_Public_get_Cauldron_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartCauldronBehaviour>.NativeClassPtr, 100671072);
			StartCauldronBehaviour.NativeMethodInfoPtr_set_Station_Protected_set_Void_Cauldron_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartCauldronBehaviour>.NativeClassPtr, 100671073);
			StartCauldronBehaviour.NativeMethodInfoPtr_get_WorkInProgress_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartCauldronBehaviour>.NativeClassPtr, 100671074);
			StartCauldronBehaviour.NativeMethodInfoPtr_set_WorkInProgress_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartCauldronBehaviour>.NativeClassPtr, 100671075);
			StartCauldronBehaviour.NativeMethodInfoPtr_Begin_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartCauldronBehaviour>.NativeClassPtr, 100671076);
			StartCauldronBehaviour.NativeMethodInfoPtr_Resume_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartCauldronBehaviour>.NativeClassPtr, 100671077);
			StartCauldronBehaviour.NativeMethodInfoPtr_Pause_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartCauldronBehaviour>.NativeClassPtr, 100671078);
			StartCauldronBehaviour.NativeMethodInfoPtr_Disable_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartCauldronBehaviour>.NativeClassPtr, 100671079);
			StartCauldronBehaviour.NativeMethodInfoPtr_End_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartCauldronBehaviour>.NativeClassPtr, 100671080);
			StartCauldronBehaviour.NativeMethodInfoPtr_ActiveMinPass_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartCauldronBehaviour>.NativeClassPtr, 100671081);
			StartCauldronBehaviour.NativeMethodInfoPtr_StartWork_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartCauldronBehaviour>.NativeClassPtr, 100671082);
			StartCauldronBehaviour.NativeMethodInfoPtr_AssignStation_Public_Void_Cauldron_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartCauldronBehaviour>.NativeClassPtr, 100671083);
			StartCauldronBehaviour.NativeMethodInfoPtr_IsAtStation_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartCauldronBehaviour>.NativeClassPtr, 100671084);
			StartCauldronBehaviour.NativeMethodInfoPtr_GoToStation_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartCauldronBehaviour>.NativeClassPtr, 100671085);
			StartCauldronBehaviour.NativeMethodInfoPtr_BeginCauldron_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartCauldronBehaviour>.NativeClassPtr, 100671086);
			StartCauldronBehaviour.NativeMethodInfoPtr_StopCauldron_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartCauldronBehaviour>.NativeClassPtr, 100671087);
			StartCauldronBehaviour.NativeMethodInfoPtr_IsStationReady_Public_Boolean_Cauldron_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartCauldronBehaviour>.NativeClassPtr, 100671088);
			StartCauldronBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartCauldronBehaviour>.NativeClassPtr, 100671089);
			StartCauldronBehaviour.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartCauldronBehaviour>.NativeClassPtr, 100671090);
			StartCauldronBehaviour.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartCauldronBehaviour>.NativeClassPtr, 100671091);
			StartCauldronBehaviour.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartCauldronBehaviour>.NativeClassPtr, 100671092);
			StartCauldronBehaviour.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartCauldronBehaviour>.NativeClassPtr, 100671093);
			StartCauldronBehaviour.NativeMethodInfoPtr_RpcWriter___Observers_BeginCauldron_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartCauldronBehaviour>.NativeClassPtr, 100671094);
			StartCauldronBehaviour.NativeMethodInfoPtr_RpcLogic___BeginCauldron_2166136261_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartCauldronBehaviour>.NativeClassPtr, 100671095);
			StartCauldronBehaviour.NativeMethodInfoPtr_RpcReader___Observers_BeginCauldron_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartCauldronBehaviour>.NativeClassPtr, 100671096);
			StartCauldronBehaviour.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartCauldronBehaviour>.NativeClassPtr, 100671097);
		}

		// Token: 0x170013B7 RID: 5047
		// (get) Token: 0x06004081 RID: 16513 RVA: 0x00144A24 File Offset: 0x00142C24
		// (set) Token: 0x06004082 RID: 16514 RVA: 0x00144A64 File Offset: 0x00142C64
		public unsafe Cauldron Station
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartCauldronBehaviour.NativeMethodInfoPtr_get_Station_Public_get_Cauldron_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Cauldron>(intPtr3) : null;
			}
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 115138, RefRangeEnd = 115149, XrefRangeStart = 115138, XrefRangeEnd = 115149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartCauldronBehaviour.NativeMethodInfoPtr_set_Station_Protected_set_Void_Cauldron_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170013B8 RID: 5048
		// (get) Token: 0x06004083 RID: 16515 RVA: 0x00144AA8 File Offset: 0x00142CA8
		// (set) Token: 0x06004084 RID: 16516 RVA: 0x00144AE4 File Offset: 0x00142CE4
		public unsafe bool WorkInProgress
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartCauldronBehaviour.NativeMethodInfoPtr_get_WorkInProgress_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartCauldronBehaviour.NativeMethodInfoPtr_set_WorkInProgress_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004085 RID: 16517 RVA: 0x00144B24 File Offset: 0x00142D24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 149861, XrefRangeEnd = 149863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Begin()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StartCauldronBehaviour.NativeMethodInfoPtr_Begin_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004086 RID: 16518 RVA: 0x00144B60 File Offset: 0x00142D60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 149863, XrefRangeEnd = 149865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Resume()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StartCauldronBehaviour.NativeMethodInfoPtr_Resume_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004087 RID: 16519 RVA: 0x00144B9C File Offset: 0x00142D9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 149865, XrefRangeEnd = 149878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Pause()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StartCauldronBehaviour.NativeMethodInfoPtr_Pause_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004088 RID: 16520 RVA: 0x00144BD8 File Offset: 0x00142DD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Disable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StartCauldronBehaviour.NativeMethodInfoPtr_Disable_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004089 RID: 16521 RVA: 0x00144C14 File Offset: 0x00142E14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 149878, XrefRangeEnd = 149891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void End()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StartCauldronBehaviour.NativeMethodInfoPtr_End_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600408A RID: 16522 RVA: 0x00144C50 File Offset: 0x00142E50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 149891, XrefRangeEnd = 149902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ActiveMinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StartCauldronBehaviour.NativeMethodInfoPtr_ActiveMinPass_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600408B RID: 16523 RVA: 0x00144C8C File Offset: 0x00142E8C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 149908, RefRangeEnd = 149910, XrefRangeStart = 149902, XrefRangeEnd = 149908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartWork()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartCauldronBehaviour.NativeMethodInfoPtr_StartWork_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600408C RID: 16524 RVA: 0x00144CC0 File Offset: 0x00142EC0
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 115138, RefRangeEnd = 115149, XrefRangeStart = 115138, XrefRangeEnd = 115149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AssignStation(Cauldron station)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(station);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartCauldronBehaviour.NativeMethodInfoPtr_AssignStation_Public_Void_Cauldron_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600408D RID: 16525 RVA: 0x00144D04 File Offset: 0x00142F04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 149910, XrefRangeEnd = 149913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsAtStation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartCauldronBehaviour.NativeMethodInfoPtr_IsAtStation_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600408E RID: 16526 RVA: 0x00144D40 File Offset: 0x00142F40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 149913, XrefRangeEnd = 149915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GoToStation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartCauldronBehaviour.NativeMethodInfoPtr_GoToStation_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600408F RID: 16527 RVA: 0x00144D74 File Offset: 0x00142F74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 149915, XrefRangeEnd = 149936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BeginCauldron()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartCauldronBehaviour.NativeMethodInfoPtr_BeginCauldron_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004090 RID: 16528 RVA: 0x00144DA8 File Offset: 0x00142FA8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 149948, RefRangeEnd = 149950, XrefRangeStart = 149936, XrefRangeEnd = 149948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopCauldron()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartCauldronBehaviour.NativeMethodInfoPtr_StopCauldron_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004091 RID: 16529 RVA: 0x00144DDC File Offset: 0x00142FDC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 149971, RefRangeEnd = 149973, XrefRangeStart = 149950, XrefRangeEnd = 149971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsStationReady(Cauldron station)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(station);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartCauldronBehaviour.NativeMethodInfoPtr_IsStationReady_Public_Boolean_Cauldron_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004092 RID: 16530 RVA: 0x00144E2C File Offset: 0x0014302C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StartCauldronBehaviour() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StartCauldronBehaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartCauldronBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004093 RID: 16531 RVA: 0x00144E68 File Offset: 0x00143068
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 149973, XrefRangeEnd = 149978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartCauldronBehaviour.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06004094 RID: 16532 RVA: 0x00144EA8 File Offset: 0x001430A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 149978, XrefRangeEnd = 149986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StartCauldronBehaviour.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004095 RID: 16533 RVA: 0x00144EE4 File Offset: 0x001430E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StartCauldronBehaviour.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004096 RID: 16534 RVA: 0x00144F20 File Offset: 0x00143120
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StartCauldronBehaviour.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004097 RID: 16535 RVA: 0x00144F5C File Offset: 0x0014315C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 149986, XrefRangeEnd = 150004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_BeginCauldron_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartCauldronBehaviour.NativeMethodInfoPtr_RpcWriter___Observers_BeginCauldron_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004098 RID: 16536 RVA: 0x00144F90 File Offset: 0x00143190
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 150018, RefRangeEnd = 150020, XrefRangeStart = 150004, XrefRangeEnd = 150018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___BeginCauldron_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartCauldronBehaviour.NativeMethodInfoPtr_RpcLogic___BeginCauldron_2166136261_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004099 RID: 16537 RVA: 0x00144FC4 File Offset: 0x001431C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150020, XrefRangeEnd = 150023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_BeginCauldron_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartCauldronBehaviour.NativeMethodInfoPtr_RpcReader___Observers_BeginCauldron_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600409A RID: 16538 RVA: 0x00145014 File Offset: 0x00143214
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StartCauldronBehaviour.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600409B RID: 16539 RVA: 0x0001FF3A File Offset: 0x0001E13A
		public StartCauldronBehaviour(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170013B1 RID: 5041
		// (get) Token: 0x0600409C RID: 16540 RVA: 0x00145050 File Offset: 0x00143250
		// (set) Token: 0x0600409D RID: 16541 RVA: 0x0001FF43 File Offset: 0x0001E143
		public unsafe static float START_CAULDRON_TIME
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(StartCauldronBehaviour.NativeFieldInfoPtr_START_CAULDRON_TIME, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(StartCauldronBehaviour.NativeFieldInfoPtr_START_CAULDRON_TIME, (void*)(&value));
			}
		}

		// Token: 0x170013B2 RID: 5042
		// (get) Token: 0x0600409E RID: 16542 RVA: 0x0014506C File Offset: 0x0014326C
		// (set) Token: 0x0600409F RID: 16543 RVA: 0x0001FF51 File Offset: 0x0001E151
		public unsafe Cauldron _Station_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartCauldronBehaviour.NativeFieldInfoPtr__Station_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Cauldron>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartCauldronBehaviour.NativeFieldInfoPtr__Station_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170013B3 RID: 5043
		// (get) Token: 0x060040A0 RID: 16544 RVA: 0x0014509C File Offset: 0x0014329C
		// (set) Token: 0x060040A1 RID: 16545 RVA: 0x0001FF70 File Offset: 0x0001E170
		public unsafe bool _WorkInProgress_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartCauldronBehaviour.NativeFieldInfoPtr__WorkInProgress_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartCauldronBehaviour.NativeFieldInfoPtr__WorkInProgress_k__BackingField)) = value;
			}
		}

		// Token: 0x170013B4 RID: 5044
		// (get) Token: 0x060040A2 RID: 16546 RVA: 0x001450C4 File Offset: 0x001432C4
		// (set) Token: 0x060040A3 RID: 16547 RVA: 0x0001FF8B File Offset: 0x0001E18B
		public unsafe Coroutine workRoutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartCauldronBehaviour.NativeFieldInfoPtr_workRoutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartCauldronBehaviour.NativeFieldInfoPtr_workRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170013B5 RID: 5045
		// (get) Token: 0x060040A4 RID: 16548 RVA: 0x001450F4 File Offset: 0x001432F4
		// (set) Token: 0x060040A5 RID: 16549 RVA: 0x0001FFAA File Offset: 0x0001E1AA
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartCauldronBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartCauldronBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x170013B6 RID: 5046
		// (get) Token: 0x060040A6 RID: 16550 RVA: 0x0014511C File Offset: 0x0014331C
		// (set) Token: 0x060040A7 RID: 16551 RVA: 0x0001FFC5 File Offset: 0x0001E1C5
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartCauldronBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartCauldronBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04002AF8 RID: 11000
		private static readonly IntPtr NativeFieldInfoPtr_START_CAULDRON_TIME;

		// Token: 0x04002AF9 RID: 11001
		private static readonly IntPtr NativeFieldInfoPtr__Station_k__BackingField;

		// Token: 0x04002AFA RID: 11002
		private static readonly IntPtr NativeFieldInfoPtr__WorkInProgress_k__BackingField;

		// Token: 0x04002AFB RID: 11003
		private static readonly IntPtr NativeFieldInfoPtr_workRoutine;

		// Token: 0x04002AFC RID: 11004
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04002AFD RID: 11005
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04002AFE RID: 11006
		private static readonly IntPtr NativeMethodInfoPtr_get_Station_Public_get_Cauldron_0;

		// Token: 0x04002AFF RID: 11007
		private static readonly IntPtr NativeMethodInfoPtr_set_Station_Protected_set_Void_Cauldron_0;

		// Token: 0x04002B00 RID: 11008
		private static readonly IntPtr NativeMethodInfoPtr_get_WorkInProgress_Public_get_Boolean_0;

		// Token: 0x04002B01 RID: 11009
		private static readonly IntPtr NativeMethodInfoPtr_set_WorkInProgress_Protected_set_Void_Boolean_0;

		// Token: 0x04002B02 RID: 11010
		private static readonly IntPtr NativeMethodInfoPtr_Begin_Protected_Virtual_Void_0;

		// Token: 0x04002B03 RID: 11011
		private static readonly IntPtr NativeMethodInfoPtr_Resume_Protected_Virtual_Void_0;

		// Token: 0x04002B04 RID: 11012
		private static readonly IntPtr NativeMethodInfoPtr_Pause_Protected_Virtual_Void_0;

		// Token: 0x04002B05 RID: 11013
		private static readonly IntPtr NativeMethodInfoPtr_Disable_Public_Virtual_Void_0;

		// Token: 0x04002B06 RID: 11014
		private static readonly IntPtr NativeMethodInfoPtr_End_Protected_Virtual_Void_0;

		// Token: 0x04002B07 RID: 11015
		private static readonly IntPtr NativeMethodInfoPtr_ActiveMinPass_Public_Virtual_Void_0;

		// Token: 0x04002B08 RID: 11016
		private static readonly IntPtr NativeMethodInfoPtr_StartWork_Private_Void_0;

		// Token: 0x04002B09 RID: 11017
		private static readonly IntPtr NativeMethodInfoPtr_AssignStation_Public_Void_Cauldron_0;

		// Token: 0x04002B0A RID: 11018
		private static readonly IntPtr NativeMethodInfoPtr_IsAtStation_Public_Boolean_0;

		// Token: 0x04002B0B RID: 11019
		private static readonly IntPtr NativeMethodInfoPtr_GoToStation_Public_Void_0;

		// Token: 0x04002B0C RID: 11020
		private static readonly IntPtr NativeMethodInfoPtr_BeginCauldron_Public_Void_0;

		// Token: 0x04002B0D RID: 11021
		private static readonly IntPtr NativeMethodInfoPtr_StopCauldron_Private_Void_0;

		// Token: 0x04002B0E RID: 11022
		private static readonly IntPtr NativeMethodInfoPtr_IsStationReady_Public_Boolean_Cauldron_0;

		// Token: 0x04002B0F RID: 11023
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002B10 RID: 11024
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x04002B11 RID: 11025
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04002B12 RID: 11026
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04002B13 RID: 11027
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04002B14 RID: 11028
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_BeginCauldron_2166136261_Private_Void_0;

		// Token: 0x04002B15 RID: 11029
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___BeginCauldron_2166136261_Public_Void_0;

		// Token: 0x04002B16 RID: 11030
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_BeginCauldron_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x04002B17 RID: 11031
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x02000956 RID: 2390
		[ObfuscatedName("ScheduleOne.NPCs.Behaviour.StartCauldronBehaviour+<<BeginCauldron>g__Package|20_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStSiSiObObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600C87F RID: 51327 RVA: 0x00309644 File Offset: 0x00307844
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStSiSiObObUnique()
			{
				Il2CppClassPointerStore<StartCauldronBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStSiSiObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StartCauldronBehaviour>.NativeClassPtr, "<<BeginCauldron>g__Package|20_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StartCauldronBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStSiSiObObUnique>.NativeClassPtr);
				StartCauldronBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStSiSiObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartCauldronBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStSiSiObObUnique>.NativeClassPtr, "<>1__state");
				StartCauldronBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStSiSiObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartCauldronBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStSiSiObObUnique>.NativeClassPtr, "<>2__current");
				StartCauldronBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStSiSiObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartCauldronBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStSiSiObObUnique>.NativeClassPtr, "<>4__this");
				StartCauldronBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStSiSiObObUnique.NativeFieldInfoPtr__packageTime_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartCauldronBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStSiSiObObUnique>.NativeClassPtr, "<packageTime>5__2");
				StartCauldronBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStSiSiObObUnique.NativeFieldInfoPtr__i_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartCauldronBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStSiSiObObUnique>.NativeClassPtr, "<i>5__3");
				StartCauldronBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStSiSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartCauldronBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStSiSiObObUnique>.NativeClassPtr, 100671098);
				StartCauldronBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStSiSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartCauldronBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStSiSiObObUnique>.NativeClassPtr, 100671099);
				StartCauldronBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStSiSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartCauldronBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStSiSiObObUnique>.NativeClassPtr, 100671100);
				StartCauldronBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStSiSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartCauldronBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStSiSiObObUnique>.NativeClassPtr, 100671101);
				StartCauldronBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartCauldronBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStSiSiObObUnique>.NativeClassPtr, 100671102);
				StartCauldronBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartCauldronBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStSiSiObObUnique>.NativeClassPtr, 100671103);
			}

			// Token: 0x0600C880 RID: 51328 RVA: 0x0030974C File Offset: 0x0030794C
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStSiSiObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StartCauldronBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStSiSiObObUnique>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartCauldronBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStSiSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C881 RID: 51329 RVA: 0x00309794 File Offset: 0x00307994
			[CallerCount(13604)]
			[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartCauldronBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStSiSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C882 RID: 51330 RVA: 0x003097C8 File Offset: 0x003079C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 149841, XrefRangeEnd = 149856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartCauldronBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStSiSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003E8C RID: 16012
			// (get) Token: 0x0600C883 RID: 51331 RVA: 0x00309804 File Offset: 0x00307A04
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartCauldronBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStSiSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600C884 RID: 51332 RVA: 0x00309844 File Offset: 0x00307A44
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 149856, XrefRangeEnd = 149861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartCauldronBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003E8D RID: 16013
			// (get) Token: 0x0600C885 RID: 51333 RVA: 0x00309878 File Offset: 0x00307A78
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartCauldronBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600C886 RID: 51334 RVA: 0x00061855 File Offset: 0x0005FA55
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStSiSiObObUnique(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003E87 RID: 16007
			// (get) Token: 0x0600C887 RID: 51335 RVA: 0x003098B8 File Offset: 0x00307AB8
			// (set) Token: 0x0600C888 RID: 51336 RVA: 0x0006185E File Offset: 0x0005FA5E
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartCauldronBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStSiSiObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartCauldronBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStSiSiObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003E88 RID: 16008
			// (get) Token: 0x0600C889 RID: 51337 RVA: 0x003098E0 File Offset: 0x00307AE0
			// (set) Token: 0x0600C88A RID: 51338 RVA: 0x00061879 File Offset: 0x0005FA79
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartCauldronBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStSiSiObObUnique.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartCauldronBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStSiSiObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003E89 RID: 16009
			// (get) Token: 0x0600C88B RID: 51339 RVA: 0x00309910 File Offset: 0x00307B10
			// (set) Token: 0x0600C88C RID: 51340 RVA: 0x00061898 File Offset: 0x0005FA98
			public unsafe StartCauldronBehaviour __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartCauldronBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStSiSiObObUnique.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<StartCauldronBehaviour>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartCauldronBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStSiSiObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003E8A RID: 16010
			// (get) Token: 0x0600C88D RID: 51341 RVA: 0x00309940 File Offset: 0x00307B40
			// (set) Token: 0x0600C88E RID: 51342 RVA: 0x000618B7 File Offset: 0x0005FAB7
			public unsafe float _packageTime_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartCauldronBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStSiSiObObUnique.NativeFieldInfoPtr__packageTime_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartCauldronBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStSiSiObObUnique.NativeFieldInfoPtr__packageTime_5__2)) = value;
				}
			}

			// Token: 0x17003E8B RID: 16011
			// (get) Token: 0x0600C88F RID: 51343 RVA: 0x00309968 File Offset: 0x00307B68
			// (set) Token: 0x0600C890 RID: 51344 RVA: 0x000618D2 File Offset: 0x0005FAD2
			public unsafe float _i_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartCauldronBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStSiSiObObUnique.NativeFieldInfoPtr__i_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartCauldronBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStSiSiObObUnique.NativeFieldInfoPtr__i_5__3)) = value;
				}
			}

			// Token: 0x040087BA RID: 34746
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040087BB RID: 34747
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040087BC RID: 34748
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040087BD RID: 34749
			private static readonly IntPtr NativeFieldInfoPtr__packageTime_5__2;

			// Token: 0x040087BE RID: 34750
			private static readonly IntPtr NativeFieldInfoPtr__i_5__3;

			// Token: 0x040087BF RID: 34751
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040087C0 RID: 34752
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040087C1 RID: 34753
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040087C2 RID: 34754
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040087C3 RID: 34755
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040087C4 RID: 34756
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
